Imports System.ComponentModel
Imports System.Text
Imports DevComponents.DotNetBar

Namespace CircularProgressControl
	Partial Public Class Form1
		Inherits Office2007Form
		Public Sub New()
			InitializeComponent()

			ToggleEndlessProgress.Execute()

			circularProgressItem11.IsRunning = True
			circularProgress1.IsRunning = True
		End Sub

		Private Sub ToggleEndlessProgress_Executed(ByVal sender As Object, ByVal e As EventArgs) Handles ToggleEndlessProgress.Executed
			Dim running As Boolean = Not ToggleEndlessProgress.Checked
			ToggleEndlessProgress.Checked = Not ToggleEndlessProgress.Checked
			If running Then
				ToggleEndlessProgress.Text = "Stop"
			Else
				ToggleEndlessProgress.Text = "Start"
			End If

			circularProgressItem1.IsRunning = running
			circularProgressItem2.IsRunning = running
			circularProgressItem3.IsRunning = running
			circularProgressItem4.IsRunning = running
			circularProgressItem5.IsRunning = running
		End Sub

		Private Sub timer1_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles timer1.Tick
			circularProgressItem6.Value += 2
			circularProgressItem7.Value += 2
			circularProgressItem8.Value += 2
			circularProgressItem9.Value += 2
			circularProgressItem10.Value += 2

			If circularProgressItem6.Value >= circularProgressItem6.Maximum Then
				ProgressRun.Execute()
			End If
		End Sub

		Private Sub ProgressRun_Executed(ByVal sender As Object, ByVal e As EventArgs) Handles ProgressRun.Executed
			Dim running As Boolean = Not timer1.Enabled

			If running AndAlso circularProgressItem6.Value >= circularProgressItem6.Maximum Then
				circularProgressItem6.Value = 0
				circularProgressItem7.Value = 0
				circularProgressItem8.Value = 0
				circularProgressItem9.Value = 0
				circularProgressItem10.Value = 0
			End If

			timer1.Enabled = running
			If running Then
				ProgressRun.Text = "Stop"
			Else
				ProgressRun.Text = "Start"
			End If
			ProgressRun.Checked = Not ProgressRun.Checked
		End Sub

		Private Sub ProgressValueVisible_Executed(ByVal sender As Object, ByVal e As EventArgs) Handles ProgressValueVisible.Executed
			circularProgressItem6.ProgressTextVisible = ProgressValueVisible.Checked
			circularProgressItem7.ProgressTextVisible = ProgressValueVisible.Checked
			circularProgressItem8.ProgressTextVisible = ProgressValueVisible.Checked
			circularProgressItem9.ProgressTextVisible = ProgressValueVisible.Checked
			circularProgressItem10.ProgressTextVisible = ProgressValueVisible.Checked
		End Sub

		Private Sub circularProgress1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles circularProgress1.Click
			circularProgress1.IsRunning = Not circularProgress1.IsRunning
		End Sub

	End Class
End Namespace