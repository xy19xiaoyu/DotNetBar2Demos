Imports System.Text
Imports System.Text.RegularExpressions
Imports DevComponents.DotNetBar
Imports DevComponents.DotNetBar.Controls
Imports DevComponents.DotNetBar.SuperGrid
Imports DevComponents.DotNetBar.SuperGrid.Style

Namespace SuperGridDemo
	Partial Public Class DemoExtendedFiltering
        Inherits DevComponents.DotNetBar.Office2007Form
		#Region "Private variables"

		Private _VowelButtonItem As ButtonItem
		Private _ConsonantButtonItem As ButtonItem

		Private _FilterIndexOk As Boolean

		#End Region

		Public Sub New()
			InitializeComponent()

			' Initialize base form controls and the grid
			' and then set the sample description text

			InitControls()
			InitializeGrid()

            ShellServices.LoadRtbText(richTextBox1, "SuperGridDemo.DemoExtendedFiltering.rtf")
		End Sub

		#Region "InitControls"

		''' <summary>
		''' Initializes form level controls
		''' </summary>
		Private Sub InitControls()
			cbFilterAlignment.Items.AddRange(System.Enum.GetNames(GetType(Alignment)))
			cbFilterAlignment.SelectedIndex = 3

			cbFilterImageVisibility.Items.AddRange(System.Enum.GetNames(GetType(ImageVisibility)))
			cbFilterImageVisibility.SelectedIndex = 0

			cbMatchType.Items.AddRange(System.Enum.GetNames(GetType(FilterMatchType)))
			cbMatchType.SelectedIndex = 0

			cbFilterLevel.Items.AddRange(System.Enum.GetNames(GetType(FilterLevel)))
			cbFilterLevel.SelectedIndex = 1
		End Sub

		#End Region

		#Region "InitializeGrid"

		''' <summary>
		''' Initializes the grid
		''' </summary>
		Private Sub InitializeGrid()
			Dim panel As GridPanel = superGridControl1.PrimaryGrid

			panel.Columns("LastName").EditorType = GetType(MyComboBox)
			panel.Columns("Citizen").EditorType = GetType(MyCheckBox)

			' Add rows for the user to filter

			AddRows()

			' Hook onto a few of the filtering events
			' to demonstrate their use and simple application

			AddHandler superGridControl1.FilterBeginEdit, AddressOf SuperGridControl1FilterBeginEdit
			AddHandler superGridControl1.FilterLoadItems, AddressOf SuperGridControl1FilterLoadItems
			AddHandler superGridControl1.FilterEditValueChanged, AddressOf SuperGridControl1FilterEditValueChanged

			AddHandler superGridControl1.FilterPopupOpening, AddressOf SuperGridControl1FilterPopupOpening
			AddHandler superGridControl1.FilterPopupClosing, AddressOf SuperGridControl1FilterPopupClosing

			AddHandler superGridControl1.PreRenderFilterPopupGripBar, AddressOf PreRenderFilterPopupGripBar
			AddHandler superGridControl1.FilterPopupValueChanged, AddressOf SuperGridControl1FilterPopupValueChanged

			AddHandler superGridControl1.FilterUserFunction, AddressOf SuperGridControl1FilterUserFunction
            AddHandler superGridControl1.FilterPopupLoaded, AddressOf SuperGridControl1FilterPopupLoaded
		End Sub

		#End Region

		#Region "FilterPopup support"

		#Region "SuperGridControl1FilterPopupOpening"

		''' <summary>
		''' This routine is called when the ColumnHeader filter
		''' image has been clicked. The user has the opportunity to
		''' redefine the popup Control, as well as completely cancel
		''' the operation if needed.
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub SuperGridControl1FilterPopupOpening(ByVal sender As Object, ByVal e As GridFilterPopupOpeningEventArgs)
			' Set the grip size a little larger so we
			' can display some text in there later.

			e.FilterPopup.GripSize = New Size(14, 30)

			Select Case e.GridColumn.Name
					' If the user has checked the "UseAgeSlider"
					' checkbox, then create a Slider and tell the
					' SuperGrid to use it as the popup control.

				Case "Age"
					If cbxUseAgeSlider.Checked = True Then
						e.FilterPopup.Control = GetNewSlider(e.GridColumn)

						' Set the grip size a little larger so we
						' can display some text in there later.

						e.FilterPopup.GripSize = New Size(14, 60)
					End If

				Case "HireDate"
					' Set the grip size a little larger so we
					' can display some text in there later.

					e.FilterPopup.GripSize = New Size(14, 60)

					' When the user initially clicks on the "Index" column,
					' we present the user with an OKCancel dialog. If OK, the
					' operation continues - if Canceled, then the operation is
					' canceled and no filtering is permitted.

				Case "Index"
					e.Cancel = GetIndexMonitorResult()
			End Select
		End Sub

		#Region "GetNewSlider"

		''' <summary>
		''' Creates a new Slider Control to use for the
		''' "Age" column (when "UseAgeSlider" is checked).
		''' </summary>
		''' <param name="column"></param>
		''' <returns></returns>
		Private Function GetNewSlider(ByVal column As GridColumn) As Slider
			Dim slider As New Slider()

			slider.Tag = column

			' Setting the MinimumSize will keep the user from
			' being able to resize the FilterPopup too small

			slider.Size = New Size(150, 25)
			slider.MinimumSize = New Size(100, 25)

			slider.FocusCuesEnabled = False
			slider.LabelWidth = 30
			slider.Text = "0"

			' We want to be informed when the user
			' changes the slider value.

			AddHandler slider.ValueChanged, AddressOf SliderValueChanged

			Return (slider)
		End Function

		#Region "SliderValueChanged"

		Private Sub SliderValueChanged(ByVal sender As Object, ByVal e As EventArgs)
			Dim slider As Slider = TryCast(sender, Slider)

			If slider IsNot Nothing Then
				slider.Text = slider.Value.ToString()

				Dim column As GridColumn = TryCast(slider.Tag, GridColumn)

				If column IsNot Nothing Then
					If slider.Value <= 0 Then
						column.FilterExpr = Nothing
						column.FilterDisplayValue = "All ages"
					Else
						column.FilterExpr = (column.Name & " is between " & (slider.Value - 10) & ", " & (slider.Value + 10))

						column.FilterDisplayValue = ">= " & (slider.Value - 10) & " and <= " & (slider.Value + 10)
					End If
				End If
			End If
		End Sub

		#End Region

		#End Region

		#End Region

		#Region "SuperGridControl1FilterPopupClosing"

		''' <summary>
		''' This routine is called when the FilterPopup is
		''' being closed.
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub SuperGridControl1FilterPopupClosing(ByVal sender As Object, ByVal e As GridFilterPopupClosingEventArgs)
			' If an "Age" Popup is being closed, and we have
			' redefined the popup Control to be a Slider, then
			' unhook the ValueChanged event and dispose of it.

			If e.GridColumn.Name.Equals("Age") Then
				Dim slider As Slider = TryCast(e.FilterPopup.Control, Slider)

				If slider IsNot Nothing Then
					RemoveHandler slider.ValueChanged, AddressOf SliderValueChanged

					slider.Dispose()
				End If
			End If
		End Sub

		#End Region

		#Region "SuperGridControl1FilterPopupLoaded"

		''' <summary>
		''' This routine is called after the SuperGrid has
		''' loaded the FilterPopup with the default filter
		''' items. The user can delete or add items as needed.
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub SuperGridControl1FilterPopupLoaded(ByVal sender As Object, ByVal e As GridFilterPopupLoadedEventArgs)
			' Let's modify the items contained in the "FirstName" popup

			If e.GridColumn.Name.Equals("FirstName") Then
				' The SuperGrid uses an ItemPanel as its underlying
				' Popup Control.

				Dim itemPanel As ItemPanel = TryCast(e.FilterPopup.Control, ItemPanel)

				If itemPanel IsNot Nothing Then
					' Let's add 2 items to the list - one to filter out all
					' words that do not begin with a vowel, and another that
					' filters out all words that do not start with a consonant.

					itemPanel.Items.Add(GetVowelItem(e.GridColumn))
					itemPanel.Items.Add(GetConsonantItem(e.GridColumn))
				End If
			End If
		End Sub

		#Region "GetVowelItem"

		''' <summary>
		''' This routine creates a "Vowel" item to add to
		''' the popup ItemPanel Control.
		''' </summary>
		''' <param name="column"></param>
		''' <returns></returns>
		Private Function GetVowelItem(ByVal column As GridColumn) As BaseItem
			If _VowelButtonItem Is Nothing Then
				_VowelButtonItem = New ButtonItem("Vowels", "Vowels")
				AddHandler _VowelButtonItem.Click, AddressOf VowelItemClick

				_VowelButtonItem.Tooltip = "Shows all names starting with a vowel"

				_VowelButtonItem.BeginGroup = True
			End If

			_VowelButtonItem.Tag = column

			Return (_VowelButtonItem)
		End Function

		#Region "VowelItemClick"

		Private Sub VowelItemClick(ByVal sender As Object, ByVal e As EventArgs)
			Dim bi As ButtonItem = TryCast(sender, ButtonItem)

			If bi IsNot Nothing Then
				Dim column As GridColumn = TryCast(bi.Tag, GridColumn)

				If column IsNot Nothing Then
                    column.FilterExpr = "IndexOf(Left(, 1),""AEIOUY"") >= 0"
					column.FilterDisplayValue = "Vowels"
				End If
			End If
		End Sub

		#End Region

		#End Region

		#Region "GetConsonantItem"

		''' <summary>
		''' This routine creates a "Conosonant" item to add to
		''' the popup ItemPanel Control.
		''' </summary>
		''' <param name="column"></param>
		''' <returns></returns>
		Private Function GetConsonantItem(ByVal column As GridColumn) As BaseItem
			If _ConsonantButtonItem Is Nothing Then
				_ConsonantButtonItem = New ButtonItem("Consonants", "Consonants")
				AddHandler _ConsonantButtonItem.Click, AddressOf ConsonantItemClick

				_ConsonantButtonItem.Tooltip = "Shows all names starting with a consonant"
			End If

			_ConsonantButtonItem.Tag = column

			Return (_ConsonantButtonItem)
		End Function

		#Region "ConsonantItemClick"

		Private Sub ConsonantItemClick(ByVal sender As Object, ByVal e As EventArgs)
			Dim bi As ButtonItem = TryCast(sender, ButtonItem)

			If bi IsNot Nothing Then
				Dim column As GridColumn = TryCast(bi.Tag, GridColumn)

				If column IsNot Nothing Then
                    column.FilterExpr = "Length() > 0 && IndexOf(Left(, 1),""AEIOUY"") < 0"
					column.FilterDisplayValue = "Consonants"

					column.ShowPanelFilterExpr = Tbool.True
				End If
			End If
		End Sub

		#End Region

		#End Region

		#End Region

		#Region "PreRenderFilterPopupGripBar"

		''' <summary>
		''' This routine is called to give the user the ability
		''' to utilize and render the "GripBar" area as they see fit.
		''' The GripHandle, as well as the entire GripBar, can be
		''' completely redefined and rendered at this point.
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub PreRenderFilterPopupGripBar(ByVal sender As Object, ByVal e As GridPreRenderFilterPopupGripBarEventArgs)
			Dim r As RectangleF = e.Bounds

			' Let's make the GripBar area LightSlateGray by default,
			' and then render the current FilterDisplayValue to the
			' GripBar (with some extra text for good measure if the
			' column happens to be the "Age" column).

			e.Graphics.FillRectangle(Brushes.LightSlateGray, r)

			Using sf As New StringFormat()
				sf.LineAlignment = StringAlignment.Center
				sf.Alignment = StringAlignment.Center

				Dim s As String = TryCast(e.GridColumn.FilterDisplayValue, String)

				If String.IsNullOrEmpty(s) = True Then
					s = "<null>"
				End If

				If e.GridColumn.Name.Equals("Age") Then
					If cbxUseAgeSlider.Checked = True Then
						s = "Age range expression:" & vbLf & s
					End If
				Else
					r.Width -= e.FilterPopup.GripSize.Width
				End If

				e.Graphics.DrawString(s, SystemFonts.CaptionFont, Brushes.White, r, sf)
			End Using
		End Sub

		#End Region

		#Region "SuperGridControl1FilterPopupValueChanged"

		''' <summary>
		''' This routine is called when the user selects an
		''' item from the ItemPanel FilterPopup.
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub SuperGridControl1FilterPopupValueChanged(ByVal sender As Object, ByVal e As GridFilterPopupValueChangedEventArgs)
			' If the user has selected the "Custom" entry for the
			' "FirstName" column - and the current Filter Expression
			' is null, let's initialize a default expresion for them.

			If e.FilterItemType = FilterItemType.Custom Then
				If e.GridColumn.Name.Equals("FirstName") Then
					' There are 3 'filter' items that control the
					' filtering interaction and display of each column.
					'
					' The FilterExpr is the parsed expression string that
					' defines the filter criteria.
					'
					' The FilterValue is the value used by the FilterPanel
					' edit control when editing.
					' 
					' And the FilterDisplayValue is what is displayed in the
					' FilterPanel when not editing.

					If e.GridColumn.FilterExpr Is Nothing Then
						e.FilterValue = Nothing
						e.FilterDisplayValue = "Between ""J"" and ""M"""

						e.FilterExpr = "substring(" & e.GridColumn.Name & ", 0, 1) " & e.FilterDisplayValue
					End If
				End If
			End If
		End Sub

		#End Region

		#End Region

		#Region "FilterPanel support"

		#Region "SuperGridControl1FilterBeginEdit"

		''' <summary>
		''' This routine is called when the user clicks in
		''' a GridFilter cell and a FilterPanel edit is
		''' about to begin.
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub SuperGridControl1FilterBeginEdit(ByVal sender As Object, ByVal e As GridFilterBeginEditEventArgs)
			' The e.GridColumn will be null if the user has clicked
			' in the GridFilter RowHeader area - thus launching an edit
			' of the row level filter (Custom filter dialog will be
			' launched by default).

			If e.GridColumn IsNot Nothing Then
				' If it is for the "Index" column, then do some
				' non-sensical user validation for demonstration.

				If e.GridColumn.Name.Equals("Index") Then
					e.Cancel = GetIndexMonitorResult()
				End If
			End If
		End Sub

		#End Region

		#Region "SuperGridControl1FilterLoadItems"

		''' <summary>
		''' This routine is called before the system has loaded its
		''' default FilterPanel items.
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub SuperGridControl1FilterLoadItems(ByVal sender As Object, ByVal e As GridFilterLoadItemsEventArgs)
			' If the FilterPopup is for the "LastName" column then
			' let's add some 'range' items to the top of the list.

			If e.GridColumn.Name.Equals("LastName") Then
				e.ComboBox.Items.Add(New MyItem("""A"" to ""E"""))
				e.ComboBox.Items.Add(New MyItem("""F"" to ""J"""))
				e.ComboBox.Items.Add(New MyItem("""K"" to ""O"""))
				e.ComboBox.Items.Add(New MyItem("""P"" to ""T"""))
				e.ComboBox.Items.Add(New MyItem("""U"" to ""Z"""))
			End If
		End Sub

		#End Region

		#Region "SuperGridControl1FilterEditValueChanged"

		''' <summary>
		''' This routine is called when the user has changed
		''' the FilterPanel edit value (TextBox, ComboBox, or CheckBox).
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub SuperGridControl1FilterEditValueChanged(ByVal sender As Object, ByVal e As GridFilterEditValueChangedEventArgs)
			If e.GridColumn.Name.Equals("Age") Then
				AgeEditValueChanged(e)

			ElseIf e.GridColumn.Name.Equals("LastName") Then
				LastNameEditValueChanged(e)
			End If
		End Sub

		#Region "AgeEditValueChanged"

		''' <summary>
		''' This routine handles "Age" related edit changes.
		''' </summary>
		''' <param name="e"></param>
		Private Sub AgeEditValueChanged(ByVal e As GridFilterEditValueChangedEventArgs)
			Dim s As String = TryCast(e.NewValue, String)

			If s IsNot Nothing Then
				' Let's permit the user to type in things like
				' "20-25,27,31-40" as a valid edit filter.

				Dim reg As New Regex("((?<age>\d+(?!-)\b)|(?<range>\d+-\d+))\s*,*\s*")
				Dim mc As MatchCollection = reg.Matches(s)

				If mc.Count > 0 Then
					Dim sb As New StringBuilder()

					For Each ma As Match In mc
						Dim gp As Group = ma.Groups("age")

						sb.Append(e.GridColumn.Name)

						If gp IsNot Nothing AndAlso String.IsNullOrEmpty(gp.Value) = False Then
							sb.Append(" is like """ & gp.Value & """ or ")
						End If

						gp = ma.Groups("range")

						If gp IsNot Nothing AndAlso String.IsNullOrEmpty(gp.Value) = False Then
							Dim t() As String = gp.Value.Split("-"c)

							sb.Append(" is between " & t(0) & " and " & t(1) & " or ")
						End If
					Next ma

					sb.Length -= 4

					' Override the default parsed SuperGrid Filter Expression
					' with our new range enabled expression.

					e.NewExpr = sb.ToString()
					e.NewDisplayValue = s
				End If
			End If
		End Sub

		#End Region

		#Region "LastNameEditValueChanged"

		''' <summary>
		''' This routine handles "LastName" related edit changes.
		''' </summary>
		''' <param name="e"></param>
		Private Sub LastNameEditValueChanged(ByVal e As GridFilterEditValueChangedEventArgs)
			Dim cb As ComboBoxEx = TryCast(e.FilterPanel.Control, ComboBoxEx)

			If cb IsNot Nothing Then
				' We only want to handle selections for our
				' items, so make sure it is one of our items.

				Dim item As MyItem = TryCast(cb.SelectedItem, MyItem)

				If item IsNot Nothing Then
					Dim s As String = CStr(e.NewValue).Replace("to", "and")

					e.NewExpr = "LastName between " & s
				End If
			End If
		End Sub

		#End Region

		#End Region

		#Region "MyItem"

		''' <summary>
		''' Simple class def for items added to
		''' the FilterPanel dropDown.
		''' </summary>
		Private Class MyItem
			Public Item As String

			Public Sub New(ByVal item As String)
				Me.Item = item
			End Sub

			Public Overrides Function ToString() As String
				Return (Item)
			End Function
		End Class

		#End Region

		#End Region

		#Region "GetIndexMonitorResult"

		''' <summary>
		''' Routine presents a modal OKCancel dialog
		''' to the user.
		''' </summary>
		''' <returns>true to cancel</returns>
		Private Function GetIndexMonitorResult() As Boolean
			' If it is the first time the user has selected the
			' "Index" FilterPopup or FilterPanel, then present them
			' with the "Monitoring" dialog.

			If _FilterIndexOk = False Then
				Dim result As DialogResult = MessageBoxEx.Show("Operation will be logged. Do you want to continue?", "Monitored operation", MessageBoxButtons.OKCancel)

				_FilterIndexOk = (result = System.Windows.Forms.DialogResult.OK)
			End If

			Return (_FilterIndexOk = False)
		End Function

		#End Region

		#Region "SuperGridControl1FilterUserFunction"

		''' <summary>
		''' This routine shows how to add user defined
		''' functions that can be accessed via the expression
		''' evaluator.
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub SuperGridControl1FilterUserFunction(ByVal sender As Object, ByVal e As GridFilterUserFunctionEventArgs)
			' The first argument is the name of the user defined
			' function.  In this case we are being presented with
			' the "Sqrt" (square root) function.

			If e.Args(0).Equals("sqrt") Then
				If e.Args.Length <> 2 Then
					Throw New Exception("Sqrt: Invalid arg count")
				End If

				' Arguments 1 through e.Args.Length - 1 are the
				' actual user supplied arguments to the function.

				Dim o As Object = e.Args(1)

				' If the argument is null or empty, then
				' just set the result as 0 for the square root.

				If TypeOf o Is EmptyFilterOp OrElse o Is Nothing OrElse o Is DBNull.Value Then
					e.Result = 0
				Else
					e.Result = Math.Sqrt(Convert.ToDouble(o))
                End If

                ' Flag the fact that we handled the user function.

                e.Handled = True
			End If
		End Sub

		#End Region

		#Region "BtnResetPanelFilterClick"

		''' <summary>
		''' Handles user request to reset the panel's
		''' row level filter
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub BtnResetPanelFilterClick(ByVal sender As Object, ByVal e As EventArgs) Handles btnResetPanelFilter.Click
			superGridControl1.PrimaryGrid.FilterExpr = Nothing
		End Sub

		#End Region

		#Region "BtnResetColumnFiltersClick"

		''' <summary>
		''' Handles user's request to
		''' reset every column level filter.
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub BtnResetColumnFiltersClick(ByVal sender As Object, ByVal e As EventArgs) Handles btnResetColumnFilters.Click
			Dim panel As GridPanel = superGridControl1.PrimaryGrid

			For Each column As GridColumn In panel.Columns
				column.FilterExpr = Nothing
			Next column
		End Sub

		#End Region

		#Region "AddRows"

		''' <summary>
		''' Routine to add a random set of rows to the grid.
		''' </summary>
		Private Sub AddRows()
			Dim rand As New Random()

			superGridControl1.BeginUpdate()

			Dim panel As GridPanel = superGridControl1.PrimaryGrid

			' Add 500 root rows for the user to filter.

			For i As Integer = 0 To 499
				Dim row As GridRow = GetNewRow(i)

				panel.Rows.Add(row)

				' Add a random number of sub-rows (2 to 7).

				Dim m As Integer = rand.Next(2, 7)

				For j As Integer = 0 To m - 1
					row.Rows.Add(GetNewRow(rand.Next(0, 500)))
				Next j
			Next i

			superGridControl1.EndUpdate()
		End Sub

		#Region "GetNewRow"

		''' <summary>
		''' Create a new random Employee row
		''' </summary>
		''' <param name="count"></param>
		''' <returns></returns>
		Private Function GetNewRow(ByVal count As Integer) As GridRow
			Dim emp As MyEmployee = MyEmployee.GetNewEmployee()

			Dim firstName As Object
			If emp.Age Mod 7 = 0 Then
				firstName = (CObj(DBNull.Value))
			Else
				firstName = (emp.FirstName)
			End If
			Dim age As Object
			If emp.Age Mod 5 = 0 Then
				age = (Nothing)
			Else
				age = (CObj(emp.Age))
			End If
			Dim citizen As Object
			If emp.Age Mod 3 = 0 Then
				citizen = (Nothing)
			Else
				citizen = (CObj(emp.Citizen))
			End If
			Dim hireDate As Object
			If emp.Age Mod 6 = 0 Then
				hireDate = (Nothing)
			Else
				hireDate = (CObj(emp.HireDate))
			End If

			Dim ob1() As Object = { count, emp.LastName, firstName, age, hireDate, citizen }

			If count Mod 100 = 50 Then
				Dim n As Integer = count Mod 6 + 1

				Dim ob2(n - 1) As Object

				For j As Integer = 0 To n - 1
					ob2(j) = ob1(j)
				Next j

				Return (New GridRow(ob2))
			End If

			Return (New GridRow(ob1))
		End Function

		#End Region

		#End Region

		#Region "CbxShowPanelExprCheckedChanged"

		''' <summary>
		''' Routine handles checkbox changes for displaying
		''' the actual filter expression, or the "Custom" defined
		''' string, in the FilterPanel cell (when not editing).
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub CbxShowPanelExprCheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbxShowPanelExpr.CheckedChanged
			superGridControl1.PrimaryGrid.Filter.ShowPanelFilterExpr = cbxShowPanelExpr.Checked
		End Sub

		#End Region

		#Region "CbxUseAgeSliderCheckedChanged"

		''' <summary>
		''' Handles checkbox changes for using a user defined
		''' Slider control for the "Age" column FilterPopup.
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub CbxUseAgeSliderCheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbxUseAgeSlider.CheckedChanged
			' The column's FilterPopupSize tracks user size changes
			' to the associated FilterPopup.  When we change the popup's
			' underlying Control, we want to reset this so the popup will
			' be more correctly sized for the changed control.

			Dim column As GridColumn = superGridControl1.PrimaryGrid.Columns("Age")

			If column IsNot Nothing Then
				column.FilterPopupSize = Size.Empty
			End If
		End Sub

		#End Region

		#Region "CbFilterAlignmentSelectedIndexChanged"

		''' <summary>
		''' Handles user comboBox selections to change the
		''' alignment of the ColumnHeader Filter Image.
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub CbFilterAlignmentSelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbFilterAlignment.SelectedIndexChanged
			Dim align As Alignment = CType(System.Enum.Parse(GetType(Alignment), CStr(cbFilterAlignment.SelectedItem)), Alignment)

			superGridControl1.PrimaryGrid.ColumnHeader.FilterImageAlignment = align
		End Sub

		#End Region

		#Region "CbFilterImageVisibilitySelectedIndexChanged"

		''' <summary>
		''' Handles user comboBox selections to change the
		''' visibility of the ColumnHeader filter image.
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub CbFilterImageVisibilitySelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbFilterImageVisibility.SelectedIndexChanged
			Dim vis As ImageVisibility = CType(System.Enum.Parse(GetType(ImageVisibility), CStr(cbFilterImageVisibility.SelectedItem)), ImageVisibility)

			superGridControl1.PrimaryGrid.ColumnHeader.FilterImageVisibility = vis
		End Sub

		#End Region

		#Region "CbMatchTypeSelectedIndexChanged"

		''' <summary>
		''' Handles user comboBox selections to change the
		''' default filtering Match Type.
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub CbMatchTypeSelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbMatchType.SelectedIndexChanged
			Dim fms As FilterMatchType = CType(System.Enum.Parse(GetType(FilterMatchType), cbMatchType.Text), FilterMatchType)

			superGridControl1.PrimaryGrid.FilterMatchType = fms
		End Sub

		#End Region

		#Region "CbFilterLevelSelectedIndexChanged"

		''' <summary>
		''' Handles FilterLevel changes.
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub CbFilterLevelSelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbFilterLevel.SelectedIndexChanged
			If cbFilterLevel.SelectedIndex >= 0 Then
				superGridControl1.PrimaryGrid.FilterLevel = CType(System.Enum.Parse(GetType(FilterLevel), CStr(cbFilterLevel.SelectedItem)), FilterLevel)
			End If
		End Sub

		#End Region
	End Class
End Namespace