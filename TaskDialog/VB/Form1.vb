Imports System.ComponentModel
Imports System.Text
Imports DevComponents.DotNetBar

Namespace TaskDialogTester
	Partial Public Class Form1
		Inherits Office2007Form
		Public Sub New()
            InitializeComponent()
        End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			comboBoxIcon.Items.AddRange(System.Enum.GetNames(GetType(eTaskDialogIcon)))
			comboBoxIcon.SelectedIndex = 1

			comboBoxColor.Items.AddRange(System.Enum.GetNames(GetType(eTaskDialogBackgroundColor)))
			comboBoxColor.SelectedIndex = 0
		End Sub

		Private Sub buttonX1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles buttonX1.Click
			Dim info As TaskDialogInfo = CreateTaskDialogInfo()

			Dim result As eTaskDialogResult = TaskDialog.Show(info)
			Log("{0} Task-dialog closed with result: {1}", Date.Now, result)
		End Sub
		Private Function CreateTaskDialogInfo() As TaskDialogInfo
			Dim info As New TaskDialogInfo(textBoxTitle.Text, CType(System.Enum.Parse(GetType(eTaskDialogIcon), comboBoxIcon.Text), eTaskDialogIcon), textBoxHeader.Text, textBoxContent.Text, GetTaskDialogButtons(), CType(System.Enum.Parse(GetType(eTaskDialogBackgroundColor), comboBoxColor.Text), eTaskDialogBackgroundColor), GetRadioButtons(), GetCommandButtons(), GetCheckBoxCommand(), textBoxFooter.Text, GetFooterImage())
			Return info
		End Function
		Private Function GetFooterImage() As Image
			If checkBoxFooterImage.Checked Then
				Return My.Resources.About
			End If
			Return Nothing
		End Function
		Private Function GetCheckBoxCommand() As Command
			If checkBoxVisible.Checked Then
				Return commandCheckBox
			End If
			Return Nothing
		End Function
		Private Function GetCommandButtons() As Command()
			If checkBoxTaskButtons.Checked Then
				Return New Command() { commandButton1, commandButton2 }
			End If

			Return Nothing
		End Function
		Private Function GetRadioButtons() As Command()
			If checkBoxTaskRadio.Checked Then
				Return New Command() { commandRadio1, commandRadio2 }
			End If
			Return Nothing
		End Function
		Private Function GetTaskDialogButtons() As eTaskDialogButton
			Dim button As eTaskDialogButton = eTaskDialogButton.Ok

			If checkBoxCancel.Checked Then
				button = button Or eTaskDialogButton.Cancel
			End If
			If checkBoxYes.Checked Then
				button = button Or eTaskDialogButton.Yes
			End If
			If checkBoxNo.Checked Then
				button = button Or eTaskDialogButton.No
			End If
			If checkBoxRetry.Checked Then
				button = button Or eTaskDialogButton.Retry
			End If
			If checkBoxClose.Checked Then
				button = button Or eTaskDialogButton.Close
			End If

			If (Not checkBoxOk.Checked) AndAlso button <> eTaskDialogButton.Ok Then
				button = button And Not(button And eTaskDialogButton.Ok)
			End If

			Return button
		End Function

		Private Sub commandCheckBox_Executed(ByVal sender As Object, ByVal e As EventArgs) Handles commandCheckBox.Executed
			Log("{0} Task-Dialog Check-box has been clicked. Checked={1}", Date.Now, commandCheckBox.Checked)
		End Sub

		Private Sub commandRadio1_Executed(ByVal sender As Object, ByVal e As EventArgs) Handles commandRadio1.Executed
			Log("{0} Task-Dialog Radio 1 has been clicked. Checked={1}", Date.Now, commandRadio1.Checked)
		End Sub

		Private Sub commandRadio2_Executed(ByVal sender As Object, ByVal e As EventArgs) Handles commandRadio2.Executed
			Log("{0} Task-Dialog Radio 2 has been clicked. Checked={1}", Date.Now, commandRadio2.Checked)
		End Sub

		Private Sub commandButton1_Executed(ByVal sender As Object, ByVal e As EventArgs) Handles commandButton1.Executed
			Log("{0} Task button has been clicked", Date.Now)
		End Sub

		Private Sub commandButton2_Executed(ByVal sender As Object, ByVal e As EventArgs) Handles commandButton2.Executed
			Log("{0} Task button 2 has been clicked", Date.Now)
			TaskDialog.Close(eTaskDialogResult.Custom1)
		End Sub

		Private Sub labelX3_MarkupLinkClick(ByVal sender As Object, ByVal e As MarkupLinkClickEventArgs) Handles labelX3.MarkupLinkClick
			Process.Start("http://www.devcomponents.com/kb/questions.php?questionid=5")
		End Sub
		Private Sub Log(ByVal text As String, ParamArray ByVal args() As Object)
			textBoxLog.AppendText(String.Format(text, args) & Environment.NewLine)
			textBoxLog.ScrollToCaret()
		End Sub
	End Class
End Namespace