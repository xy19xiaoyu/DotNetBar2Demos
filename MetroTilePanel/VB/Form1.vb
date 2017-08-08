Imports System.ComponentModel
Imports System.Text
Imports DevComponents.DotNetBar.Metro
Imports DevComponents.DotNetBar

Namespace MetroTilePanel
	Partial Public Class Form1
		Inherits MetroForm
		Public Sub New()
			StyleManager.MetroColorGeneratorParameters = New DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(ColorScheme.GetColor("0E6D38"), ColorScheme.GetColor("0E6D38"))
			InitializeComponent()
		End Sub
	End Class
End Namespace