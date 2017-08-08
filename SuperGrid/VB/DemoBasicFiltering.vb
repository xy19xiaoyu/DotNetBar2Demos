Imports System.ComponentModel
Imports DevComponents.DotNetBar.SuperGrid

Namespace SuperGridDemo
	Partial Public Class DemoBasicFiltering
        Inherits DevComponents.DotNetBar.Office2007Form
		#Region "Private variables"

		Private _Rand As New Random()

		#End Region

		Public Sub New()
			InitializeComponent()

			' Initialize the grid
			' and set the sample description text

			InitializeGrid()

            ShellServices.LoadRtbText(richTextBox1, "SuperGridDemo.DemoBasicFiltering.rtf")
		End Sub

		#Region "InitializeGrid"

		''' <summary>
		''' Initialize the grid
		''' </summary>
		Private Sub InitializeGrid()
			Dim panel As GridPanel = superGridControl1.PrimaryGrid

			panel.Columns("LastName").EditorType = GetType(MyComboBox)
			panel.Columns("Citizen").EditorType = GetType(MyCheckBox)

			' Add some initial rows for the user to filter

			AddRows()
		End Sub

		#End Region

		#Region "AddRows"

		''' <summary>
		''' Adds 1000 random data rows for the user to filter
		''' </summary>
		Private Sub AddRows()
			Dim panel As GridPanel = superGridControl1.PrimaryGrid

			superGridControl1.BeginUpdate()

			Dim count As Integer = panel.Rows.Count

			For i As Integer = 0 To 999
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

				Dim ob1() As Object = { count + i, emp.LastName, firstName, age, hireDate, citizen }

				If i < 12 Then
					Dim n As Integer = i Mod 6 + 1

					Dim ob2(n - 1) As Object

					For j As Integer = 0 To n - 1
						ob2(j) = ob1(j)
					Next j

					panel.Rows.Add(New GridRow(ob2))
				Else
					panel.Rows.Add(New GridRow(ob1))
				End If
			Next i

			superGridControl1.EndUpdate()

			' We'll stop it at 10,000 - just for grins

			If panel.Rows.Count >= 10000 Then
				btnAddRows.Enabled = False
			End If
		End Sub

		#End Region

		#Region "BtnAddRowsClick"

		''' <summary>
		''' Handles user request to add another 1000 rows
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub BtnAddRowsClick(ByVal sender As Object, ByVal e As EventArgs) Handles btnAddRows.Click
			AddRows()
		End Sub

		#End Region

		#Region "BtnResetPanelFilterClick"

		''' <summary>
		''' Handles user request to reset the
		''' row level panel filter
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub BtnResetPanelFilterClick(ByVal sender As Object, ByVal e As EventArgs) Handles btnResetPanelFilter.Click
			superGridControl1.PrimaryGrid.FilterExpr = Nothing
		End Sub

		#End Region

		#Region "BtnResetColumnFiltersClick"

		''' <summary>
		''' Handles user request to
		''' reset each column level filter
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
	End Class

	#Region "MyCombo"

	''' <summary>
	''' Simple class definition to enable ThreeState
	''' </summary>
	Public Class MyCheckBox
		Inherits GridCheckBoxXEditControl
		Public Sub New()
			ThreeState = True
		End Sub
	End Class

	#End Region

	#Region "MyCombo"

	''' <summary>
	''' Simple class to create combo with
	''' every base employee name added by default
	''' </summary>
	Public Class MyComboBox
		Inherits GridComboBoxExEditControl
		Public Sub New()
			For Each name As String In MyEmployee.LastNames
				If name IsNot Nothing Then
					Items.Add(name)
				Else
					Items.Add("")
				End If
			Next name
		End Sub
	End Class

	#End Region

	#Region "MyEmployee"

	''' <summary>
	''' Simple MyEmployee class definition
	''' </summary>
	Public Class MyEmployee
        Implements INotifyPropertyChanged

		#Region "Private variables"

		Private _FirstName As String
		Private _LastName As String
		Private _Age As Integer
		Private _Id As Integer
		Private _HireDate As Date
        Private _Citizen As Boolean

		Private Shared _Rand As New Random()

        Public Shared FirstNames() As String = {Nothing, "Isabella", "Sophia", "Emma", _
            "Olivia", "Ava", "Emily", "Abigail", "Madison", "Chloe", "Mia", "Addison", _
            "Elizabeth", "Ella", "Natalie", "Samantha", "Alexis", "Lily", "Grace", "Hailey", _
            "Alyssa", "Lillian", "Hannah", "Avery", "Leah", "Nevaeh", "Sofia", "Ashley", _
            "Anna", "Brianna", "Sarah", "Zoe", "Victoria", "Gabriella", "Brooklyn", "Kaylee", _
            "Taylor", "Layla", "Allison", "Evelyn", "Riley", "Amelia", "Khloe"}

        Public Shared LastNames() As String = {Nothing, "Anderson", "Brown", "Clark", "Davis", _
            "García", "González", "Hall", "Harris", "Hernández", "Jackson", "Johnson", "Jones", _
            "Lee", "Lewis", "López", "Martin", "Martínez", "Miller", "Moore", "Pérez", "Robinson", _
            "Rodríguez", "Smith", "Taylor", "Thomas", "Thompson", "Walker", "White", "Williams", _
            "Wilson", "Young"}

		#End Region

		Public Sub New(ByVal firstName As String, ByVal lastName As String, ByVal age As Integer, ByVal id As Integer, ByVal hireDate As Date, ByVal citizen As Boolean)
			_FirstName = firstName
			_LastName = lastName
			_Age = age
			_Id = id
			_HireDate = hireDate
			_Citizen = citizen
		End Sub

		#Region "GetNewEmployee"

		''' <summary>
		''' Gets a new, random employee
		''' </summary>
		''' <returns></returns>
        Public Shared Function GetNewEmployee() As MyEmployee
            Dim fname As String = FirstNames(_Rand.Next(FirstNames.Length))
            Dim lname As String = LastNames(_Rand.Next(LastNames.Length))

            Dim age_Renamed As Integer = _Rand.Next(18, 70)
            Dim id_Renamed As Integer = _Rand.Next(10000, 12000)

            Dim hireDate_Renamed As Date = Date.Now.AddMonths(_Rand.Next(0, 12))

            hireDate_Renamed = hireDate_Renamed.AddYears(_Rand.Next(-20, 20))
            hireDate_Renamed = hireDate_Renamed.AddDays(_Rand.Next(0, 20))

            Return (New MyEmployee(fname, lname, age_Renamed, id_Renamed, _
                    hireDate_Renamed, (age_Renamed + id_Renamed) Mod 2 = 0))
        End Function

		#End Region

		#Region "Public properties"

		#Region "FirstName"

		Public Property FirstName() As String
			Get
				Return (_FirstName)
			End Get

			Set(ByVal value As String)
				_FirstName = value

				OnPropertyChanged("FirstName")
			End Set
		End Property

		#End Region

		#Region "LastName"

		Public Property LastName() As String
			Get
				Return (_LastName)
			End Get

			Set(ByVal value As String)
				_LastName = value

				OnPropertyChanged("LastName")
			End Set
		End Property

		#End Region

		#Region "Age"

		Public Property Age() As Integer
			Get
				Return (_Age)
			End Get

			Set(ByVal value As Integer)
				_Age = value

				OnPropertyChanged("Age")
			End Set
		End Property

		#End Region

		#Region "Id"

		Public Property Id() As Integer
			Get
				Return (_Id)
			End Get

			Set(ByVal value As Integer)
				_Id = value

				OnPropertyChanged("Id")
			End Set
		End Property

		#End Region

		#Region "HireDate"

		Public Property HireDate() As Date
			Get
				Return (_HireDate)
			End Get

			Set(ByVal value As Date)
				_HireDate = value

				OnPropertyChanged("HireDate")
			End Set
		End Property

		#End Region

		#Region "Citizen"

		Public Property Citizen() As Boolean
			Get
				Return (_Citizen)
			End Get

			Set(ByVal value As Boolean)
				_Citizen = value

				OnPropertyChanged("Citizen")
			End Set
		End Property

		#End Region

		#End Region

		#Region "INotifyPropertyChanged Members"

		''' <summary>
		''' Occurs when property value has changed.
		''' </summary>
		Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

		Public Sub OnPropertyChanged(ByVal [property] As String)
			OnPropertyChanged(New PropertyChangedEventArgs([property]))
		End Sub

		''' <summary>
		''' Raises the PropertyChanged event.
		''' </summary>
		''' <param name="e">Event arguments</param>
		Protected Overridable Sub OnPropertyChanged(ByVal e As PropertyChangedEventArgs)
			Dim eh As PropertyChangedEventHandler = PropertyChangedEvent

			If eh IsNot Nothing Then
				eh(Me, e)
			End If
		End Sub

		#End Region
	End Class

	#End Region
End Namespace