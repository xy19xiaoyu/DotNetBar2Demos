Imports System.Collections
Imports System.ComponentModel
Imports DevComponents.DotNetBar.SuperGrid
Imports DevComponents.DotNetBar.SuperGrid.Style

Namespace SuperGridDemo
	Partial Public Class DemoGridBasics1
        Inherits DevComponents.DotNetBar.Office2007Form
		Public Sub New()
			InitializeComponent()

			' Initialize the grid and set the sample description text

			InitializeGrid()

			ShellServices.LoadRtbText(richTextBox1, "SuperGridDemo.DemoBasics1.rtf")
		End Sub

		#Region "InitializeGrid"

		''' <summary>
		''' Initializes the default state of the grid
		''' </summary>
		Private Sub InitializeGrid()
			Dim panel As GridPanel = superGridControl1.PrimaryGrid

			Dim orderArray() As String = { "Asterids", "Eudicots", "Rosids" }

			' Set the ComboBoxEx column EditorType to our FragrantComboBox
			' and set the EditorParams to our created orderArray.
			'
			' The EditorParams property holds the parameters that will be
			' sent to the like defined EditorControl constructor when the
			' grid creates the EditControl.  The EditorParams can be any
			' array of objects, but must match in type and order to the
			' associated constructor.

			panel.Columns("ComboBoxEx").EditorType = GetType(FragrantComboBox)
			panel.Columns("ComboBoxEx").EditorParams = New Object() { orderArray }

			' Set the ButtonX column EditorType to our FlowerButton
			' and set the EditorParams to our created flowerImageList.

			panel.Columns("ButtonX").EditorType = GetType(FlowerButton)
			panel.Columns("ButtonX").EditorParams = New Object() { flowerImageList }

			' Enable the Clear button on the TextBoxDropDown edit control

			Dim ddc As GridTextBoxDropDownEditControl = TryCast(panel.Columns("TextBoxDropDown").EditControl, GridTextBoxDropDownEditControl)

			If ddc IsNot Nothing Then
				ddc.ButtonClear.Visible = True
				AddHandler ddc.ButtonClearClick, AddressOf DdcButtonClearClick
			End If

			' Set the Mask on the MaskedTextBox edit control

			Dim mtb As GridMaskedTextBoxEditControl = TryCast(panel.Columns("MaskedTextBox").EditControl, GridMaskedTextBoxEditControl)

			If mtb IsNot Nothing Then
				mtb.Mask = ">LL->L-000"
			End If

			' Now lets change the DirtyMarkerBackground on every
			' other row - just to demonstrate the operation

			For i As Integer = 0 To panel.Rows.Count - 1
				If i Mod 2 = 0 Then
					Dim row As GridRow = CType(panel.Rows(i), GridRow)

					row.RowStyles.Default.RowHeaderStyle.DirtyMarkerBackground = New Background(Color.Crimson, Color.Gainsboro, BackFillType.VerticalCenter)
				End If
			Next i
		End Sub

		#End Region

		#Region "DdcButtonClearClick"

		''' <summary>
		''' Handles Clear button clicks
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub DdcButtonClearClick(ByVal sender As Object, ByVal e As CancelEventArgs)
			Dim ddc As GridTextBoxDropDownEditControl = TryCast(sender, GridTextBoxDropDownEditControl)

			If ddc IsNot Nothing Then
				' Just set the text to an "unknown" value and
				' tell the control that we handled it

				ddc.Text = "(unknown)"

				e.Cancel = True
			End If
		End Sub

		#End Region
	End Class

	#Region "FragrantComboBox"

	Friend Class FragrantComboBox
		Inherits GridComboBoxExEditControl
		Public Sub New(ByVal orderArray As IEnumerable)
			DataSource = orderArray
		End Sub
	End Class

	#End Region

	#Region "FlowerButton"

	Friend Class FlowerButton
		Inherits GridButtonXEditControl
		#Region "Private variables"

		Private _FlowerImageList As ImageList

		#End Region

		Public Sub New(ByVal flowerImageList As ImageList)
			_FlowerImageList = flowerImageList

			AddHandler Click, AddressOf FlowerButtonClick
		End Sub

		#Region "FlowerButtonClick"

		Private Sub FlowerButtonClick(ByVal sender As Object, ByVal e As EventArgs)
			Dim s As String = TryCast(EditorCell.Value, String)

			If s IsNot Nothing Then
				Dim form As New FlowerForm()

				form.Text = s
				form.pictureBox1.Image = _FlowerImageList.Images(s)
				form.ShowDialog()
			End If
		End Sub

		#End Region
	End Class

	#End Region
End Namespace