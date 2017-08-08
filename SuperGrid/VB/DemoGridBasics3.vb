Imports System.Text
Imports DevComponents.DotNetBar
Imports DevComponents.DotNetBar.SuperGrid

Namespace SuperGridDemo
	Partial Public Class DemoGridBasics3
        Inherits DevComponents.DotNetBar.Office2007Form
		Public Sub New()
			InitializeComponent()

			' Initialize the grid, Size
			' ComboBox, and the sample description text.

			InitializeGrid()
			InitSizeComboBox()

			ShellServices.LoadRtbText(richTextBox1, "SuperGridDemo.DemoBasics3.rtf")
		End Sub

		#Region "InitializeGrid"

		''' <summary>
		''' Initializes the default grid
		''' </summary>
		Private Sub InitializeGrid()
			Dim panel As GridPanel = superGridControl1.PrimaryGrid

			' Set the ImageEdit column EditorType to our EditControl type
			' so that we can send it the ImageList and SizeMode to use

			Dim column As GridColumn = panel.Columns("ImageEdit")
			column.EditorType = GetType(MyGridImageEditControl)
			column.EditorParams = New Object() { imageList1, ImageSizeMode.Zoom }

			' Set the LabelX column EditorType to our EditControl type
			' so that we can handle the link reference mouse clicks

			column = panel.Columns("LabelX")
			column.EditorType = GetType(MyGridLabelXEditControl)
		End Sub

		#End Region

		#Region "InitSizeComboBox"

		''' <summary>
		''' Initializes the Size ComboBox
		''' </summary>
		Private Sub InitSizeComboBox()
			For Each s As String In System.Enum.GetNames(GetType(ImageSizeMode))
				cbxSizeMode.Items.Add(s)
			Next s

			cbxSizeMode.SelectedIndex = 3
		End Sub

		#End Region

		#Region "MyGridImageEditControl"

		''' <summary>
		''' GridImageEditControl with the ability
		''' to pass in a default ImageList and ImageBoxSizeMode
		''' </summary>
		Private Class MyGridImageEditControl
			Inherits GridImageEditControl
			Public Sub New(ByVal imageList As ImageList, ByVal sizeMode As ImageSizeMode)
				Me.ImageList = imageList
				ImageSizeMode = sizeMode
			End Sub
		End Class

		#End Region

		#Region "MyGridLabelXEditControl"

		''' <summary>
		''' GridLabelXEditControl with the ability to handle
		''' reference link clicks
		''' </summary>
		Private Class MyGridLabelXEditControl
			Inherits GridLabelXEditControl
			Public Sub New()
				AddHandler MarkupLinkClick, AddressOf MyGridLabelXEditControlMarkupLinkClick
			End Sub

			#Region "MyGridLabelXEditControlMarkupLinkClick"

			Private Sub MyGridLabelXEditControlMarkupLinkClick(ByVal sender As Object, ByVal e As MarkupLinkClickEventArgs)
				Dim sInfo As New ProcessStartInfo(e.HRef)
				Process.Start(sInfo)
			End Sub

			#End Region
		End Class

		#End Region

		#Region "SuperGridControl1CompareElements"

		''' <summary>
		''' Routine used to compare two IP addresses
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub SuperGridControl1CompareElements(ByVal sender As Object, ByVal e As GridCompareElementsEventArgs)
			Dim cellA As GridCell = TryCast(e.ElementA, GridCell)

			If cellA IsNot Nothing AndAlso cellA.ColumnIndex = 0 Then
				e.Cancel = True

				Dim cellB As GridCell = CType(e.ElementB, GridCell)

				Dim valueA As String = GetIpValue(TryCast(cellA.Value, String))
				Dim valueB As String = GetIpValue(TryCast(cellB.Value, String))

				e.Result = String.Compare(valueA, valueB)
			End If
		End Sub

		#Region "GetIpValue"

		''' <summary>
		''' Creates a simple string comparable
		''' representation of an IP Address
		''' </summary>
		''' <param name="t"></param>
		''' <returns></returns>
		Private Function GetIpValue(ByVal t As String) As String
			Dim sb As New StringBuilder()

			If t IsNot Nothing Then
				Dim svalues() As String = t.Split("."c)

				If svalues.Length = 4 Then
					For i As Integer = 0 To svalues.Length - 1
						sb.Append(svalues(i).Trim().PadLeft(3, "0"c))
					Next i
				End If
			End If

			Return (sb.ToString())
		End Function

		#End Region

		#End Region

		#Region "CbxSizeModeSelectedIndexChanged"

		''' <summary>
		''' Handles ImageEditSizeMode changes
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub CbxSizeModeSelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbxSizeMode.SelectedIndexChanged
			If cbxSizeMode.SelectedIndex >= 0 Then
				Dim panel As GridPanel = superGridControl1.PrimaryGrid
				Dim column As GridColumn = panel.Columns("ImageEdit")

				Dim sizeMode As ImageSizeMode = CType(System.Enum.Parse(GetType(ImageSizeMode), CStr(cbxSizeMode.SelectedItem)), ImageSizeMode)

				SetNewSizeMode(TryCast(column.EditControl, GridImageEditControl), sizeMode)
				SetNewSizeMode(TryCast(column.RenderControl, GridImageEditControl), sizeMode)

				column.InvalidateRender()
			End If
		End Sub

		#Region "SetNewSizeMode"

		''' <summary>
		''' Sets a new size mode for the given GridImageEditControl
		''' </summary>
		''' <param name="ic"></param>
		''' <param name="sizeMode"></param>
		Private Sub SetNewSizeMode(ByVal ic As GridImageEditControl, ByVal sizeMode As ImageSizeMode)
			If ic IsNot Nothing Then
				ic.ImageSizeMode = sizeMode
			End If
		End Sub

		#End Region

		#End Region

		#Region "CbxIpCompareCheckedChanged"

		''' <summary>
		''' Handles user requests to use (or not) the application
		''' defined IPAddress comparator
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub CbxIpCompareCheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbxIpCompare.CheckedChanged
			If cbxIpCompare.Checked = True Then
				AddHandler superGridControl1.CompareElements, AddressOf SuperGridControl1CompareElements
			Else
				RemoveHandler superGridControl1.CompareElements, AddressOf SuperGridControl1CompareElements
			End If
		End Sub

		#End Region
	End Class
End Namespace