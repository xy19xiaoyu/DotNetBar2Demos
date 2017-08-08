Namespace SuperGridDemo
	Partial Public Class DemoGridArchitecture
        Inherits DevComponents.DotNetBar.Office2007Form
		Public Sub New()
			InitializeComponent()

			' Set the sample description text

			ShellServices.LoadRtbText(richTextBox1, "SuperGridDemo.DemoArchitecture.rtf")
		End Sub
	End Class
End Namespace