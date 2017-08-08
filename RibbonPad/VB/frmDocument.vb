Imports System.Collections
Imports System.ComponentModel
Imports DevComponents.DotNetBar

Namespace Ribbonpad
	''' <summary>
	''' Summary description for frmDocument.
	''' </summary>
	Public Class frmDocument
		Inherits DevComponents.DotNetBar.Office2007Form
		Public WithEvents rtfText As RichTextBox
		Public DocumentChanged As Boolean=False
		Public FileName As String = ""
		Public WithEvents CommandUndo As Command
		Public WithEvents CommandCut As Command
		Public WithEvents CommandCopy As Command
		Public WithEvents CommandPaste As Command
		Public WithEvents CommandDelete As Command
		Private WithEvents CommandSelectAll As Command
		Private WithEvents CommandFindNext As Command
		Private WithEvents CommandReplace As Command
		Public CommandStatus As Command
		Public WithEvents CommandFontBold As Command
		Public WithEvents CommandFontItalic As Command
		Public WithEvents CommandFontUnderline As Command
		Public WithEvents CommandFontStrike As Command
		Public WithEvents CommandAlignLeft As Command
		Public WithEvents CommandAlignCenter As Command
		Public WithEvents CommandAlignRight As Command
		Public WithEvents CommandTextColor As Command
		Public WithEvents CommandFind As Command
		Public WithEvents CommandFont As Command
		Public WithEvents CommandFontSize As Command
		Public WithEvents CommandZoom As Command
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.Container = Nothing

		Public Sub New()
			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()

			'
			' TODO: Add any constructor code after InitializeComponent call
			'
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

		#Region "Windows Form Designer generated code"
		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.rtfText = New RichTextBox()
			Me.CommandUndo = New DevComponents.DotNetBar.Command()
			Me.CommandCut = New DevComponents.DotNetBar.Command()
			Me.CommandCopy = New DevComponents.DotNetBar.Command()
			Me.CommandPaste = New DevComponents.DotNetBar.Command()
			Me.CommandDelete = New DevComponents.DotNetBar.Command()
			Me.CommandSelectAll = New DevComponents.DotNetBar.Command()
			Me.CommandFindNext = New DevComponents.DotNetBar.Command()
			Me.CommandReplace = New DevComponents.DotNetBar.Command()
			Me.CommandStatus = New DevComponents.DotNetBar.Command()
			Me.CommandFontBold = New DevComponents.DotNetBar.Command()
			Me.CommandFontItalic = New DevComponents.DotNetBar.Command()
			Me.CommandFontUnderline = New DevComponents.DotNetBar.Command()
			Me.CommandFontStrike = New DevComponents.DotNetBar.Command()
			Me.CommandAlignLeft = New DevComponents.DotNetBar.Command()
			Me.CommandAlignCenter = New DevComponents.DotNetBar.Command()
			Me.CommandAlignRight = New DevComponents.DotNetBar.Command()
			Me.CommandTextColor = New DevComponents.DotNetBar.Command()
			Me.CommandFind = New DevComponents.DotNetBar.Command()
			Me.CommandFont = New DevComponents.DotNetBar.Command()
			Me.CommandFontSize = New DevComponents.DotNetBar.Command()
			Me.CommandZoom = New DevComponents.DotNetBar.Command()
			Me.SuspendLayout()
			' 
			' rtfText
			' 
			Me.rtfText.BorderStyle = BorderStyle.None
			Me.rtfText.Dock = DockStyle.Fill
			Me.rtfText.HideSelection = False
			Me.rtfText.Name = "rtfText"
			Me.rtfText.Size = New Size(124, 87)
			Me.rtfText.TabIndex = 0
			Me.rtfText.Text = ""
'			Me.rtfText.MouseDown += New System.Windows.Forms.MouseEventHandler(Me.OnMouseDown)
'			Me.rtfText.TextChanged += New System.EventHandler(Me.rtfText_TextChanged)
'			Me.rtfText.SelectionChanged += New System.EventHandler(Me.TextSelectionChanged)
			' 
			' CommandUndo
			' 
'			Me.CommandUndo.Executed += New System.EventHandler(Me.CommandUndo_Executed)
			' 
			' CommandCut
			' 
'			Me.CommandCut.Executed += New System.EventHandler(Me.CommandCut_Executed)
			' 
			' CommandCopy
			' 
'			Me.CommandCopy.Executed += New System.EventHandler(Me.CommandCopy_Executed)
			' 
			' CommandPaste
			' 
'			Me.CommandPaste.Executed += New System.EventHandler(Me.CommandPaste_Executed)
			' 
			' CommandDelete
			' 
'			Me.CommandDelete.Executed += New System.EventHandler(Me.CommandDelete_Executed)
			' 
			' CommandSelectAll
			' 
'			Me.CommandSelectAll.Executed += New System.EventHandler(Me.CommandSelectAll_Executed)
			' 
			' CommandFindNext
			' 
'			Me.CommandFindNext.Executed += New System.EventHandler(Me.CommandFindNext_Executed)
			' 
			' CommandReplace
			' 
'			Me.CommandReplace.Executed += New System.EventHandler(Me.CommandReplace_Executed)
			' 
			' CommandFontBold
			' 
'			Me.CommandFontBold.Executed += New System.EventHandler(Me.CommandFontBold_Executed)
			' 
			' CommandFontItalic
			' 
'			Me.CommandFontItalic.Executed += New System.EventHandler(Me.CommandFontItalic_Executed)
			' 
			' CommandFontUnderline
			' 
'			Me.CommandFontUnderline.Executed += New System.EventHandler(Me.CommandFontUnderline_Executed)
			' 
			' CommandFontStrike
			' 
'			Me.CommandFontStrike.Executed += New System.EventHandler(Me.CommandFontStrike_Executed)
			' 
			' CommandAlignLeft
			' 
'			Me.CommandAlignLeft.Executed += New System.EventHandler(Me.CommandAlignLeft_Executed)
			' 
			' CommandAlignCenter
			' 
'			Me.CommandAlignCenter.Executed += New System.EventHandler(Me.CommandAlignCenter_Executed)
			' 
			' CommandAlignRight
			' 
'			Me.CommandAlignRight.Executed += New System.EventHandler(Me.CommandAlignRight_Executed)
			' 
			' CommandTextColor
			' 
'			Me.CommandTextColor.Executed += New System.EventHandler(Me.CommandTextColor_Executed)
			' 
			' CommandFind
			' 
'			Me.CommandFind.Executed += New System.EventHandler(Me.CommandFind_Executed)
			' 
			' CommandFont
			' 
'			Me.CommandFont.Executed += New System.EventHandler(Me.CommandFont_Executed)
			' 
			' CommandFontSize
			' 
'			Me.CommandFontSize.Executed += New System.EventHandler(Me.CommandFontSize_Executed)
			' 
			' CommandZoom
			' 
'			Me.CommandZoom.Executed += New System.EventHandler(Me.CommandZoom_Executed)
			' 
			' frmDocument
			' 
			Me.AutoScaleBaseSize = New Size(5, 13)
			Me.BackColor = Color.FromArgb((CByte(125)), (CByte(125)), (CByte(125)))
			Me.ClientSize = New Size(124, 87)
			Me.Controls.AddRange(New Control() { Me.rtfText})
			Me.Name = "frmDocument"
			Me.Text = "frmDocument"
'			Me.Closing += New System.ComponentModel.CancelEventHandler(Me.FormClosing)
'			Me.Closed += New System.EventHandler(Me.FormClosed)
			Me.ResumeLayout(False)

		End Sub
		#End Region

		Private Overloads Sub OnMouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles rtfText.MouseDown
			If e.Button<>MouseButtons.Right Then
				Return
			End If

			Dim mdi As frmMain=TryCast(Me.ParentForm, frmMain)
			mdi.EditContextMenu()
		End Sub

		Private Sub TextSelectionChanged(ByVal sender As Object, ByVal e As EventArgs) Handles rtfText.SelectionChanged
			UpdateSelectionCommandsState()
		End Sub

		Private Sub UpdateStatusBar()
			'frmMain mdi=this.ParentForm as frmMain;
			CommandStatus.Text = "Ln " & (rtfText.GetLineFromCharIndex(rtfText.SelectionStart) + 1) & vbTab & "Ch " & rtfText.SelectionStart
			'mdi.labelPosition.Text="Ln "+(rtfText.GetLineFromCharIndex(rtfText.SelectionStart)+1)+"\tCh "+rtfText.SelectionStart;
		End Sub

		Private Sub UpdateSelectionCommandsState()
			UpdateStatusBar()

			CommandCut.Enabled = rtfText.SelectionLength > 0
			CommandCopy.Enabled = rtfText.SelectionLength > 0
			CommandDelete.Enabled = rtfText.SelectionLength > 0

			CommandFontBold.Checked = rtfText.SelectionFont.Bold
			CommandFontItalic.Checked = rtfText.SelectionFont.Italic
			CommandFontUnderline.Checked = rtfText.SelectionFont.Underline
			CommandFontStrike.Checked = rtfText.SelectionFont.Strikeout
			If rtfText.SelectionFont IsNot Nothing Then
				CommandFont.Text = rtfText.SelectionFont.Name
			Else
				CommandFont.Text = ""
			End If
			CommandFontSize.Text = (CInt(Fix(rtfText.SelectionFont.Size))).ToString()

			CommandAlignLeft.Checked=(rtfText.SelectionAlignment=HorizontalAlignment.Left)
			CommandAlignRight.Checked=(rtfText.SelectionAlignment=HorizontalAlignment.Right)
			CommandAlignCenter.Checked=(rtfText.SelectionAlignment=HorizontalAlignment.Center)
		End Sub

		Public Sub FormActivated()
			EnableDocMenuItems()
			UpdateStatusBar()
		End Sub

		Private Sub EnableDocMenuItems()
			If Not Me.Visible Then
				Return
			End If

			' Enable Edit Commands
			CommandPaste.Enabled = True
			CommandSelectAll.Enabled = True
			CommandFind.Enabled = True
			CommandFindNext.Enabled = True
			CommandReplace.Enabled = True

			' Enable Format Commands
			CommandAlignLeft.Enabled = True
			CommandAlignRight.Enabled = True
			CommandAlignCenter.Enabled = True

			CommandFontBold.Enabled = True
			CommandFontItalic.Enabled = True
			CommandFontUnderline.Enabled = True
			CommandFontStrike.Enabled = True

			CommandTextColor.Enabled = True

			CommandFontSize.Enabled = True
			CommandFont.Enabled = True

			' Update zoom value
			Dim val As Integer = CInt(Fix(rtfText.ZoomFactor * 100))
			CommandZoom.Text = val.ToString() & "%"
			If val < 100 Then
				val = CInt(Fix(CSng(val) * 100 \ 75 - 25))
			ElseIf val > 100 Then
				val = CInt(Fix((val + 100) * 100f / 400 - 100))
			End If
			CommandZoom.SetValue("Value", val)

			UpdateSelectionCommandsState()
		End Sub

		Public Sub FormDeactivated()
			DisableDocMenuItems()
		End Sub

		Private Sub DisableDocMenuItems()
			CommandCut.Enabled=False
			CommandCopy.Enabled=False
			CommandPaste.Enabled=False
			CommandDelete.Enabled=False
			CommandSelectAll.Enabled=False
			CommandFind.Enabled=False
			CommandFindNext.Enabled=False
			CommandReplace.Enabled=False

			' Disable Format items
			CommandFontBold.Enabled=False
			CommandFontItalic.Enabled = False
			CommandFontUnderline.Enabled = False
			CommandFontStrike.Enabled = False
			CommandAlignLeft.Enabled = False
			CommandAlignRight.Enabled=False
			CommandAlignCenter.Enabled=False
			CommandTextColor.Enabled=False

			CommandFontSize.Enabled=False
			CommandFont.Enabled=False
		End Sub



		Private Sub rtfText_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles rtfText.TextChanged
			DocumentChanged=True
		End Sub

		Public Sub OpenFile(ByVal filename As String)
			If filename.Substring(filename.Length-4,4).ToLower()=".txt" Then
				rtfText.LoadFile(filename,RichTextBoxStreamType.PlainText)
			Else
				rtfText.LoadFile(filename,RichTextBoxStreamType.RichText)
			End If
			Me.FileName=filename
			DocumentChanged=False
		End Sub

		Public Sub SaveFile()
			If Me.FileName.Substring(Me.FileName.Length-4,4).ToLower()=".txt" Then
				rtfText.SaveFile(Me.FileName,RichTextBoxStreamType.PlainText)
			Else
				rtfText.SaveFile(Me.FileName,RichTextBoxStreamType.RichText)
			End If

			DocumentChanged=False
		End Sub

		Private Sub FormClosed(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Closed
			Dim mdi As frmMain=TryCast(Me.ParentForm, frmMain)
			mdi.labelPosition.Text=""
			FormDeactivated()
		End Sub

		Private Sub FormClosing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
			If Me.DocumentChanged Then
				Dim dlg As DialogResult=MessageBoxEx.Show(Me,"Document '" & Me.FileName &"' has changed. Save changes?","Notepad",MessageBoxButtons.YesNoCancel)
				If dlg=DialogResult.Cancel Then
					e.Cancel=True
				ElseIf dlg=DialogResult.Yes Then
					If Me.FileName="" Then
						CType(Me.MdiParent, frmMain).SaveDocument(Me)
					End If
					If Me.FileName<>"" Then
						SaveFile()
					End If
				End If
			End If
		End Sub

		Private Sub CommandUndo_Executed(ByVal sender As Object, ByVal e As EventArgs) Handles CommandUndo.Executed
			rtfText.Undo()
			CommandExecuted()
		End Sub

		Private Sub CommandCut_Executed(ByVal sender As Object, ByVal e As EventArgs) Handles CommandCut.Executed
			rtfText.Cut()
			CommandExecuted()
		End Sub

		Private Sub CommandCopy_Executed(ByVal sender As Object, ByVal e As EventArgs) Handles CommandCopy.Executed
			rtfText.Copy()
			CommandExecuted()
		End Sub

		Private Sub CommandPaste_Executed(ByVal sender As Object, ByVal e As EventArgs) Handles CommandPaste.Executed
			rtfText.Paste()
			CommandExecuted()
		End Sub

		Private Sub CommandDelete_Executed(ByVal sender As Object, ByVal e As EventArgs) Handles CommandDelete.Executed
			rtfText.SelectedText = ""
			CommandExecuted()
		End Sub

		Private Sub CommandSelectAll_Executed(ByVal sender As Object, ByVal e As EventArgs) Handles CommandSelectAll.Executed
			rtfText.SelectAll()
			CommandExecuted()
		End Sub

		Private Sub CommandFindNext_Executed(ByVal sender As Object, ByVal e As EventArgs) Handles CommandFindNext.Executed
			MessageBoxEx.Show("Not implemented yet.")
			CommandExecuted()
		End Sub

		Private Sub CommandReplace_Executed(ByVal sender As Object, ByVal e As EventArgs) Handles CommandReplace.Executed
			MessageBoxEx.Show("Not implemented yet.")
			CommandExecuted()
		End Sub

		Private Sub CommandFontBold_Executed(ByVal sender As Object, ByVal e As EventArgs) Handles CommandFontBold.Executed
			If rtfText.SelectionFont.Bold Then
				rtfText.SelectionFont = New Font(rtfText.SelectionFont, (rtfText.SelectionFont.Style And Not(rtfText.SelectionFont.Style And FontStyle.Bold)))
			Else
				rtfText.SelectionFont = New Font(rtfText.SelectionFont, (rtfText.SelectionFont.Style Or FontStyle.Bold))
			End If
			CommandExecuted()
		End Sub

		Private Sub CommandFontItalic_Executed(ByVal sender As Object, ByVal e As EventArgs) Handles CommandFontItalic.Executed
			If rtfText.SelectionFont.Italic Then
				rtfText.SelectionFont = New Font(rtfText.SelectionFont, (rtfText.SelectionFont.Style And Not(rtfText.SelectionFont.Style And FontStyle.Italic)))
			Else
				rtfText.SelectionFont = New Font(rtfText.SelectionFont, (rtfText.SelectionFont.Style Or FontStyle.Italic))
			End If
			CommandExecuted()
		End Sub

		Private Sub CommandFontUnderline_Executed(ByVal sender As Object, ByVal e As EventArgs) Handles CommandFontUnderline.Executed
			If rtfText.SelectionFont.Underline Then
				rtfText.SelectionFont = New Font(rtfText.SelectionFont, (rtfText.SelectionFont.Style And Not(rtfText.SelectionFont.Style And FontStyle.Underline)))
			Else
				rtfText.SelectionFont = New Font(rtfText.SelectionFont, (rtfText.SelectionFont.Style Or FontStyle.Underline))
			End If
			CommandExecuted()
		End Sub

		Private Sub CommandFontStrike_Executed(ByVal sender As Object, ByVal e As EventArgs) Handles CommandFontStrike.Executed
			If rtfText.SelectionFont.Strikeout Then
				rtfText.SelectionFont = New Font(rtfText.SelectionFont, (rtfText.SelectionFont.Style And Not(rtfText.SelectionFont.Style And FontStyle.Strikeout)))
			Else
				rtfText.SelectionFont = New Font(rtfText.SelectionFont, (rtfText.SelectionFont.Style Or FontStyle.Strikeout))
			End If
			CommandExecuted()
		End Sub

		Private Sub CommandAlignLeft_Executed(ByVal sender As Object, ByVal e As EventArgs) Handles CommandAlignLeft.Executed
			rtfText.SelectionAlignment = HorizontalAlignment.Left
			CommandExecuted()
		End Sub

		Private Sub CommandAlignCenter_Executed(ByVal sender As Object, ByVal e As EventArgs) Handles CommandAlignCenter.Executed
			rtfText.SelectionAlignment = HorizontalAlignment.Center
			CommandExecuted()
		End Sub

		Private Sub CommandAlignRight_Executed(ByVal sender As Object, ByVal e As EventArgs) Handles CommandAlignRight.Executed
			rtfText.SelectionAlignment = HorizontalAlignment.Right
			CommandExecuted()
		End Sub

		Private Sub CommandTextColor_Executed(ByVal sender As Object, ByVal e As EventArgs) Handles CommandTextColor.Executed
			If TypeOf sender Is ColorPickerDropDown Then
				rtfText.SelectionColor = (CType(sender, ColorPickerDropDown)).SelectedColor
			End If
			CommandExecuted()
		End Sub

		Private Sub CommandFind_Executed(ByVal sender As Object, ByVal e As EventArgs) Handles CommandFind.Executed
			Dim source As ICommandSource = TryCast(sender, ICommandSource)
			If source IsNot Nothing AndAlso TypeOf source.CommandParameter Is String Then
				Dim searchText As String = source.CommandParameter.ToString()
				rtfText.Find(searchText, rtfText.SelectionStart + rtfText.SelectionLength, RichTextBoxFinds.None)
			End If
			CommandExecuted()
		End Sub

		Private Sub CommandFont_Executed(ByVal sender As Object, ByVal e As EventArgs) Handles CommandFont.Executed
			Dim combo As ComboBoxItem = TryCast(sender, ComboBoxItem)
			If combo IsNot Nothing AndAlso combo.SelectedItem IsNot Nothing Then
				Try
					Dim font As New Font(combo.SelectedItem.ToString(), rtfText.SelectionFont.Size)
					rtfText.SelectionFont = font
				Catch
				End Try
			End If
			CommandExecuted()
		End Sub

		Private Sub CommandFontSize_Executed(ByVal sender As Object, ByVal e As EventArgs) Handles CommandFontSize.Executed
			Dim combo As ComboBoxItem = TryCast(sender, ComboBoxItem)
			If combo IsNot Nothing AndAlso combo.SelectedItem IsNot Nothing Then
				Dim font As New Font(rtfText.SelectionFont.FontFamily, Integer.Parse(combo.SelectedItem.ToString()))
				rtfText.SelectionFont = font
			End If
			CommandExecuted()
		End Sub

		Private Sub CommandExecuted()
			DocumentChanged = True
			UpdateSelectionCommandsState()
		End Sub

		Private Sub CommandZoom_Executed(ByVal sender As Object, ByVal e As EventArgs) Handles CommandZoom.Executed
			Dim zoomSlider As SliderItem = TryCast(sender, SliderItem)
			If zoomSlider Is Nothing Then
				Return
			End If

			Dim val As Integer = zoomSlider.Value
			If val < 100 Then
				val = CInt(Fix(CSng(val) / 100 * 75 + 25))
			Else
				val = CInt(Fix((val - 100) / 100f * 400 + 100))
			End If

			rtfText.ZoomFactor = val / 100f
			CommandZoom.Text = val.ToString() & "%"
		End Sub
	End Class
End Namespace
