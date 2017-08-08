Imports System.Collections
Imports System.ComponentModel
Imports DevComponents.DotNetBar

Namespace Ribbonpad
	''' <summary>
	''' Summary description for ColorPicker.
	''' </summary>
	Public Class ColorPicker
		Inherits UserControl

		Private m_CustomColors(47) As Color
		Private m_CustomColorsPos(47) As Rectangle
		Private WithEvents listWeb As ListBox
		Private WithEvents listSystem As ListBox
		Private components As System.ComponentModel.IContainer
		Friend tabStrip1 As DevComponents.DotNetBar.TabStrip
		Private tabCustom As DevComponents.DotNetBar.TabItem
		Private tabWeb As DevComponents.DotNetBar.TabItem
		Private tabSystem As DevComponents.DotNetBar.TabItem
		Private WithEvents colorPanel As Panel

		Public SelectedColor As Color=Color.Empty

		Public Sub New()
			' This call is required by the Windows.Forms Form Designer.
			InitializeComponent()

			InitCustomColors()
			InitOtherColors()
		End Sub

		Private Sub InitCustomColors()
			m_CustomColors(0)=Color.FromArgb(255,255,255)
			m_CustomColors(1)=Color.FromArgb(255,195,198)
			m_CustomColors(2)=Color.FromArgb(255,227,198)
			m_CustomColors(3)=Color.FromArgb(255,255,198)
			m_CustomColors(4)=Color.FromArgb(198,255,198)
			m_CustomColors(5)=Color.FromArgb(198,255,255)
			m_CustomColors(6)=Color.FromArgb(198,195,255)
			m_CustomColors(7)=Color.FromArgb(255,195,255)

			m_CustomColors(8)=Color.FromArgb(231,227,231)
			m_CustomColors(9)=Color.FromArgb(255,130,132)
			m_CustomColors(10)=Color.FromArgb(255,195,132)
			m_CustomColors(11)=Color.FromArgb(255,255,132)
			m_CustomColors(12)=Color.FromArgb(132,255,132)
			m_CustomColors(13)=Color.FromArgb(132,255,255)
			m_CustomColors(14)=Color.FromArgb(132,130,255)
			m_CustomColors(15)=Color.FromArgb(255,130,255)

			m_CustomColors(16)=Color.FromArgb(198,195,198)
			m_CustomColors(17)=Color.FromArgb(255,0,0)
			m_CustomColors(18)=Color.FromArgb(255,130,0)
			m_CustomColors(19)=Color.FromArgb(255,255,0)
			m_CustomColors(20)=Color.FromArgb(0,255,0)
			m_CustomColors(21)=Color.FromArgb(0,255,255)
			m_CustomColors(22)=Color.FromArgb(0,0,255)
			m_CustomColors(23)=Color.FromArgb(255,0,255)

			m_CustomColors(24)=Color.FromArgb(132,130,132)
			m_CustomColors(25)=Color.FromArgb(198,0,0)
			m_CustomColors(26)=Color.FromArgb(198,65,0)
			m_CustomColors(27)=Color.FromArgb(198,195,0)
			m_CustomColors(28)=Color.FromArgb(0,195,0)
			m_CustomColors(29)=Color.FromArgb(0,195,198)
			m_CustomColors(30)=Color.FromArgb(0,0,198)
			m_CustomColors(31)=Color.FromArgb(198,0,198)

			m_CustomColors(32)=Color.FromArgb(66,65,66)
			m_CustomColors(33)=Color.FromArgb(132,0,0)
			m_CustomColors(34)=Color.FromArgb(132,65,0)
			m_CustomColors(35)=Color.FromArgb(132,130,0)
			m_CustomColors(36)=Color.FromArgb(0,130,0)
			m_CustomColors(37)=Color.FromArgb(0,130,132)
			m_CustomColors(38)=Color.FromArgb(0,0,132)
			m_CustomColors(39)=Color.FromArgb(132,0,132)

			m_CustomColors(40)=Color.FromArgb(0,0,0)
			m_CustomColors(41)=Color.FromArgb(66,0,0)
			m_CustomColors(42)=Color.FromArgb(132,65,66)
			m_CustomColors(43)=Color.FromArgb(66,65,0)
			m_CustomColors(44)=Color.FromArgb(0,65,0)
			m_CustomColors(45)=Color.FromArgb(0,65,66)
			m_CustomColors(46)=Color.FromArgb(0,0,66)
			m_CustomColors(47)=Color.FromArgb(66,0,66)
		End Sub

		Private Sub InitOtherColors()
			listWeb.BeginUpdate()
			listWeb.Items.Clear()
			Dim type As Type = GetType(Color)
			Dim fields() As System.Reflection.PropertyInfo=type.GetProperties(System.Reflection.BindingFlags.Public Or System.Reflection.BindingFlags.Static)
			Dim clr As New Color()
			For Each pi As System.Reflection.PropertyInfo In fields
				listWeb.Items.Add(pi.GetValue(clr,Nothing))
			Next pi
			listWeb.EndUpdate()

			listSystem.BeginUpdate()
			listSystem.Items.Clear()
			type=GetType(SystemColors)
			fields=type.GetProperties(System.Reflection.BindingFlags.Public Or System.Reflection.BindingFlags.Static)
			For Each pi As System.Reflection.PropertyInfo In fields
				listSystem.Items.Add(pi.GetValue(clr,Nothing))
			Next pi
			listSystem.EndUpdate()
		End Sub


		''' <summary> 
		''' Clean up any resources being used.
		''' </summary>
		Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
				If components IsNot Nothing Then
					components.Dispose()
				End If
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Component Designer generated code"
		''' <summary> 
		''' Required method for Designer support - do not modify 
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Me.listSystem = New ListBox()
			Me.listWeb = New ListBox()
			Me.tabStrip1 = New DevComponents.DotNetBar.TabStrip()
			Me.tabCustom = New DevComponents.DotNetBar.TabItem(Me.components)
			Me.colorPanel = New Panel()
			Me.tabWeb = New DevComponents.DotNetBar.TabItem(Me.components)
			Me.tabSystem = New DevComponents.DotNetBar.TabItem(Me.components)
			Me.SuspendLayout()
			' 
			' listSystem
			' 
			Me.listSystem.Dock = DockStyle.Fill
			Me.listSystem.DrawMode = DrawMode.OwnerDrawFixed
			Me.listSystem.IntegralHeight = False
			Me.listSystem.Name = "listSystem"
			Me.listSystem.Size = New Size(200, 158)
			Me.listSystem.TabIndex = 0
'			Me.listSystem.DrawItem += New System.Windows.Forms.DrawItemEventHandler(Me.DrawSystemItem)
'			Me.listSystem.SelectedIndexChanged += New System.EventHandler(Me.SystemSelectionChange)
			' 
			' listWeb
			' 
			Me.listWeb.Dock = DockStyle.Fill
			Me.listWeb.DrawMode = DrawMode.OwnerDrawFixed
			Me.listWeb.IntegralHeight = False
			Me.listWeb.Name = "listWeb"
			Me.listWeb.Size = New Size(200, 158)
			Me.listWeb.TabIndex = 0
'			Me.listWeb.DrawItem += New System.Windows.Forms.DrawItemEventHandler(Me.DrawWebItem)
'			Me.listWeb.SelectedIndexChanged += New System.EventHandler(Me.WebSelectionChange)
			' 
			' tabStrip1
			' 
			Me.tabStrip1.AutoHideSystemBox = True
			Me.tabStrip1.CanReorderTabs = True
			Me.tabStrip1.CloseButtonVisible = False
			Me.tabStrip1.Dock = DockStyle.Bottom
			Me.tabStrip1.ForeColor = SystemColors.ControlDark
			Me.tabStrip1.Location = New Point(0, 158)
			Me.tabStrip1.Name = "tabStrip1"
			Me.tabStrip1.SelectedTab = Me.tabCustom
			Me.tabStrip1.ShowFocusRectangle = False
			Me.tabStrip1.Size = New Size(200, 24)
			Me.tabStrip1.Style = DevComponents.DotNetBar.eTabStripStyle.Office2003
			Me.tabStrip1.TabIndex = 1
			Me.tabStrip1.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox
			Me.tabStrip1.Tabs.Add(Me.tabCustom)
			Me.tabStrip1.Tabs.Add(Me.tabWeb)
			Me.tabStrip1.Tabs.Add(Me.tabSystem)
			Me.tabStrip1.Text = "tabStrip1"
			' 
			' tabCustom
			' 
			Me.tabCustom.AttachedControl = Me.colorPanel
			Me.tabCustom.CloseButtonBounds = New Rectangle(0, 0, 0, 0)
			Me.tabCustom.Name = "tabCustom"
			Me.tabCustom.Text = "Custom"
			' 
			' colorPanel
			' 
			Me.colorPanel.Dock = DockStyle.Fill
			Me.colorPanel.Name = "colorPanel"
			Me.colorPanel.Size = New Size(200, 158)
			Me.colorPanel.TabIndex = 2
'			Me.colorPanel.MouseUp += New System.Windows.Forms.MouseEventHandler(Me.CustomColorMouseUp)
'			Me.colorPanel.Paint += New System.Windows.Forms.PaintEventHandler(Me.PaintCustomColors)
			' 
			' tabWeb
			' 
			Me.tabWeb.AttachedControl = Me.listWeb
			Me.tabWeb.CloseButtonBounds = New Rectangle(0, 0, 0, 0)
			Me.tabWeb.Name = "tabWeb"
			Me.tabWeb.Text = "Web"
			' 
			' tabSystem
			' 
			Me.tabSystem.AttachedControl = Me.listSystem
			Me.tabSystem.CloseButtonBounds = New Rectangle(0, 0, 0, 0)
			Me.tabSystem.Name = "tabSystem"
			Me.tabSystem.Text = "System"
			' 
			' ColorPicker
			' 
			Me.Controls.AddRange(New Control() { Me.listWeb, Me.listSystem, Me.colorPanel, Me.tabStrip1})
			Me.ForeColor = Color.White
			Me.Name = "ColorPicker"
			Me.Size = New Size(200, 182)
			Me.ResumeLayout(False)

		End Sub
		#End Region

		Private Sub PaintCustomColors(ByVal sender As Object, ByVal e As PaintEventArgs) Handles colorPanel.Paint
			Dim r As Rectangle=Rectangle.Empty
			Dim x As Integer=6, y As Integer=6
			Dim g As Graphics=e.Graphics
			Dim side As Border3DSide=(Border3DSide.Left Or Border3DSide.Right Or Border3DSide.Top Or Border3DSide.Bottom)
			Dim width As Integer=colorPanel.ClientRectangle.Width
			Dim iIndex As Integer=0
			For Each clr As Color In m_CustomColors
				r = New Rectangle(x,y,21,21)
				If r.Right>width Then
					y+=25
					x=6
					r.X=x
					r.Y=y
				End If
				ControlPaint.DrawBorder3D(g,x,y,21,21,Border3DStyle.Sunken,side)
				r.Inflate(-2,-2)
				g.FillRectangle(New SolidBrush(clr),r)

				m_CustomColorsPos(iIndex)=r
				iIndex += 1

				x+=24
			Next clr
		End Sub

		Private Sub DrawWebItem(ByVal sender As Object, ByVal e As DrawItemEventArgs) Handles listWeb.DrawItem
			Dim r As Rectangle=e.Bounds
			Dim rClr As New Rectangle(r.X+1,r.Y+2,24,r.Height-4)

			Dim textbrush As Brush=SystemBrushes.ControlText
			If (e.State And DrawItemState.Selected)<>0 Then
				textbrush=SystemBrushes.HighlightText
				e.Graphics.FillRectangle(SystemBrushes.Highlight,e.Bounds)
			Else
				e.Graphics.FillRectangle(SystemBrushes.Window,e.Bounds)
			End If

			Dim clr As Color=CType(listWeb.Items(e.Index), Color)
			e.Graphics.FillRectangle(New SolidBrush(clr),rClr)
			e.Graphics.DrawRectangle(SystemPens.ControlText,rClr)
			r.Offset(30,0)
			r.Width-=30
			e.Graphics.DrawString(clr.Name,listWeb.Font,textbrush,r,StringFormat.GenericTypographic)
		End Sub

		Private Sub DrawSystemItem(ByVal sender As Object, ByVal e As DrawItemEventArgs) Handles listSystem.DrawItem
			Dim r As Rectangle=e.Bounds
			Dim rClr As New Rectangle(r.X+1,r.Y+2,24,r.Height-4)

			Dim textbrush As Brush=SystemBrushes.ControlText
			If (e.State And DrawItemState.Selected)<>0 Then
				textbrush=SystemBrushes.HighlightText
				e.Graphics.FillRectangle(SystemBrushes.Highlight,e.Bounds)
			Else
				e.Graphics.FillRectangle(SystemBrushes.Window,e.Bounds)
			End If

			Dim clr As Color=CType(listSystem.Items(e.Index), Color)
			e.Graphics.FillRectangle(New SolidBrush(clr),rClr)
			e.Graphics.DrawRectangle(SystemPens.ControlText,rClr)
			r.Offset(30,0)
			r.Width-=30
			e.Graphics.DrawString(clr.Name,listWeb.Font,textbrush,r,StringFormat.GenericTypographic)
		End Sub

		Private Sub CustomColorMouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles colorPanel.MouseUp
			For i As Integer = 0 To 47
				If m_CustomColorsPos(i).Contains(e.X,e.Y) Then
					SelectedColor=m_CustomColors(i)
					ColorSelected()
					Exit For
				End If
			Next i
		End Sub

		Private Sub ColorSelected()
			Dim ctrl As DevComponents.DotNetBar.PopupContainerControl=TryCast(Me.Parent, DevComponents.DotNetBar.PopupContainerControl)
			If ctrl Is Nothing Then
				Return
			End If

			' Change the Parent Item image to indicate which color was selected last
			' Assumes that Image with ImageIndex 21 is used on button
			Dim btn As DevComponents.DotNetBar.ButtonItem=TryCast(ctrl.ParentItem, DevComponents.DotNetBar.ButtonItem)
			Dim bmp As New Bitmap(btn.Image)
			Dim g As Graphics=Graphics.FromImage(bmp)
			g.DrawImageUnscaled(btn.Image,0,0)
			Using brush As New SolidBrush(Me.SelectedColor)
				g.FillRectangle(brush,0,12,16,4)
			End Using
			g.Dispose()
			btn.ImageIndex=-1
			Dim manager As DevComponents.DotNetBar.DotNetBarManager=Nothing
			If TypeOf btn.ContainerControl Is DevComponents.DotNetBar.Bar Then
				manager=TryCast((CType(btn.ContainerControl, DevComponents.DotNetBar.Bar)).Owner, DevComponents.DotNetBar.DotNetBarManager)
			ElseIf TypeOf btn.ContainerControl Is DevComponents.DotNetBar.MenuPanel Then
				manager=TryCast((CType(btn.ContainerControl, DevComponents.DotNetBar.MenuPanel)).Owner, DevComponents.DotNetBar.DotNetBarManager)
			End If
			If manager IsNot Nothing AndAlso btn.Name<>"" Then
				Dim items As ArrayList=manager.GetItems(btn.Name,True)
				For Each item As DevComponents.DotNetBar.ButtonItem In items
					item.Image=bmp
				Next item
			Else
				btn.Image=bmp
			End If

			If TypeOf btn.ContainerControl Is RibbonBar Then
				CType(btn.ContainerControl, RibbonBar).RecalcLayout()
			End If

			If btn.IsOnMenu Then
				Dim topItem As DevComponents.DotNetBar.BaseItem=ctrl.ParentItem
				Do While TypeOf topItem.Parent Is DevComponents.DotNetBar.ButtonItem
					topItem=topItem.Parent
				Loop
				topItem.Expanded=False
				If topItem.Parent IsNot Nothing Then
					topItem.Parent.AutoExpand=False
				End If
			Else
				btn.Expanded=False
			End If
		End Sub

		Private Sub WebSelectionChange(ByVal sender As Object, ByVal e As EventArgs) Handles listWeb.SelectedIndexChanged
			If listWeb.SelectedItem IsNot Nothing Then
				SelectedColor=CType(listWeb.SelectedItem, Color)
				ColorSelected()
			End If
		End Sub

		Private Sub SystemSelectionChange(ByVal sender As Object, ByVal e As EventArgs) Handles listSystem.SelectedIndexChanged
			If listSystem.SelectedItem IsNot Nothing Then
				SelectedColor=CType(listSystem.SelectedItem, Color)
				ColorSelected()
			End If
		End Sub

		Protected Overrides Sub OnBackColorChanged(ByVal e As EventArgs)
			MyBase.OnBackColorChanged(e)
			colorPanel.BackColor=Me.BackColor
		End Sub
	End Class
End Namespace
