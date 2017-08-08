Imports System.ComponentModel
Imports System.Text
Imports System.Drawing.Drawing2D
Imports DevComponents.DotNetBar.Keyboard
Imports DevComponents.DotNetBar.Metro

Namespace TestVirtualKeyboard
	Partial Public Class Form5
		Inherits MetroForm
		Public Sub New()
			InitializeComponent()
			' Assign Custom Renderer we created below
			touchKeyboard1.Renderer = New ThreeDRenderer()
		End Sub

		Private Sub defaultRendererToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles buttonItem2.Click
			touchKeyboard1.Renderer = Nothing ' Setting Renderer to null will use a default renderer.
		End Sub

		Private Sub dRendererToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles buttonItem3.Click
			touchKeyboard1.Renderer = New ThreeDRenderer()
		End Sub
	End Class


	' Using a custom renderer means to extend the Renderer class. Extending the Renderer class means to implement four methods:
	' - DrawBackground
	' - DrawKey
	' - DrawTopBar
	' - DrawCloseButton
	' If you need to allocate resources that are used for each keys (for example a Brush or a Pen), you should override the BeginFrame function
	' end allocate it there and override the EndFrame function and deallocate the resource there. BeginFrame and EndFrame are called once at
	' the beginning / end of each frame. Each call to the DrawXXX methods in the Renderer class happen between a call to BeginFrame and a call to
	' EndFrame.

	Public Class ThreeDRenderer
		Inherits Renderer
		Private _Font As New Font("Segoe UI", 10, FontStyle.Bold)
		Private _Format As StringFormat
		''' <summary>
		''' Initializes a new instance of the ThreeDRenderer class.
		''' </summary>
		Public Sub New()
			_Format = CType(StringFormat.GenericDefault.Clone(), StringFormat)
			_Format.LineAlignment = StringAlignment.Center
			_Format.Alignment = StringAlignment.Center
		End Sub
		Public Overrides Sub DrawBackground(ByVal args As BackgroundRendererEventArgs)
			'
			Using brush As New TextureBrush(My.Resources.Fiber)
				brush.WrapMode = System.Drawing.Drawing2D.WrapMode.Tile
				args.Graphics.FillRectangle(brush, args.Bounds)
			End Using
		End Sub

		Public Overrides Sub DrawKey(ByVal args As KeyRendererEventArgs)
			Dim keyBounds As Rectangle = args.Bounds
			args.Graphics.FillRectangle(ColorTable.KeysBrush, keyBounds)

			If args.IsDown OrElse args.Key.Style = KeyStyle.Pressed OrElse args.Key.Style = KeyStyle.Toggled Then
				Draw3DBorder(args.Graphics, keyBounds, ColorTable.DarkKeysBrush, ColorTable.LightKeysBrush)
				keyBounds.Offset(1, 1)
				If args.Key.Style = KeyStyle.Toggled Then
					args.Graphics.DrawString(args.Key.Caption, _Font, ColorTable.ToggleTextBrush, keyBounds, _Format)
				Else
					args.Graphics.DrawString(args.Key.Caption, _Font, ColorTable.TextBrush, keyBounds, _Format)
				End If
			Else
				Draw3DBorder(args.Graphics, keyBounds, ColorTable.LightKeysBrush, ColorTable.DarkKeysBrush)
				args.Graphics.DrawString(args.Key.Caption, _Font, ColorTable.TextBrush, keyBounds, _Format)
			End If
		End Sub

		Public Overrides Sub DrawTopBar(ByVal args As TopBarRendererEventArgs)
			args.Graphics.DrawString(args.Text, _Font, ColorTable.TopBarTextBrush, args.Bounds)
		End Sub

		Public Overrides Sub DrawCloseButton(ByVal args As CloseButtonRendererEventArgs)
			If args.IsDown Then
				Draw3DBorder(args.Graphics, args.Bounds, ColorTable.DarkKeysBrush, ColorTable.LightKeysBrush)
			Else
				Draw3DBorder(args.Graphics, args.Bounds, ColorTable.LightKeysBrush, ColorTable.DarkKeysBrush)
			End If

			Dim rect As Rectangle = args.Bounds
			rect.Inflate(-5, -5)

			Using p As New Pen(ColorTable.TextBrush, 2)
				args.Graphics.DrawLine(p, rect.Left, rect.Top, rect.Right, rect.Bottom)
				args.Graphics.DrawLine(p, rect.Left, rect.Bottom, rect.Right, rect.Top)
			End Using

		End Sub

		Private Shared Sub Draw3DBorder(ByVal g As Graphics, ByVal bounds As Rectangle, ByVal light As Brush, ByVal dark As Brush)
			Dim borderSize As Integer = 1
			g.FillRectangle(light, New Rectangle(bounds.Left, bounds.Top, bounds.Width, borderSize))
			g.FillRectangle(light, New Rectangle(bounds.Left, bounds.Top, borderSize, bounds.Height))
			g.FillRectangle(dark, New Rectangle(bounds.Left, bounds.Bottom - borderSize, bounds.Width, borderSize))
			g.FillRectangle(dark, New Rectangle(bounds.Right - borderSize, bounds.Top, borderSize, bounds.Height))
		End Sub
	End Class
End Namespace
