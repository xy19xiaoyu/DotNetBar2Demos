Imports System.Collections
Imports System.ComponentModel
Imports System.Media
Imports DevComponents.DotNetBar.SuperGrid

Namespace SuperGridDemo
	Partial Public Class DemoGridBinding
        Inherits DevComponents.DotNetBar.Office2007Form
		#Region "Private variables"

		Private _Bm As BindingManagerBase

		#End Region

		Public Sub New()
			InitializeComponent()

			' Initialize the grid, selected comboBox
			' Data Source, and the sample description text.

			InitializeGrid()

            ShellServices.LoadRtbText(richTextBox1, "SuperGridDemo.DemoGridBinding.rtf")
		End Sub

		#Region "InitializeGrid"

		''' <summary>
		''' Initializes our default sample environment
		''' </summary>
		Private Sub InitializeGrid()
			' None - is the default

			cboDataSource.SelectedIndex = 4

			' Hook onto a few of the SuperGrid events in order to
			' kave our UI reflect the current state of the grid

			AddHandler superGridControl1.RowDeleted, AddressOf SuperGridControl1RowDeleted
			AddHandler superGridControl1.RowRestored, AddressOf SuperGridControl1RowRestored
			AddHandler superGridControl1.RowsPurged, AddressOf SuperGridControl1RowsPurged

			' When new rows are added via the grid, let's
			' see that they have something imaginative in them

			AddHandler superGridControl1.RowSetDefaultValues, AddressOf SuperGridControl1RowSetDefaultValues
		End Sub

		#End Region

		#Region "Internal properties"

		''' <summary>
		''' Gets and sets the BindingManager we use in this
		''' sampe to traverse through the set data collection
		''' </summary>
		Friend Property Bm() As BindingManagerBase
			Get
				Return (_Bm)
			End Get

			Set(ByVal value As BindingManagerBase)
				If _Bm IsNot Nothing Then
					RemoveHandler _Bm.PositionChanged, AddressOf BmPositionChanged
				End If

				_Bm = value

				If _Bm IsNot Nothing Then
					AddHandler _Bm.PositionChanged, AddressOf BmPositionChanged
				End If
			End Set
		End Property

		#End Region

		#Region "SuperGridControl1RowsPurged"

		''' <summary>
		''' This event is sent when deleted rows have been purged.
		''' We will use it to disable the "purge" button after a
		''' purge has been performed by the user.
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub SuperGridControl1RowsPurged(ByVal sender As Object, ByVal e As GridRowEventArgs)
			btnPurge.Enabled = False
		End Sub

		#End Region

		#Region "SuperGridControl1RowRestored"

		''' <summary>
		''' This event is sent when user deleted rows are
		''' restored or 'undeleted'.
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub SuperGridControl1RowRestored(ByVal sender As Object, ByVal e As GridRowRestoredEventArgs)
			btnPurge.Enabled = (superGridControl1.PrimaryGrid.DeletedRowCount > 0)
		End Sub

		#End Region

		#Region "SuperGridControl1RowDeleted"

		''' <summary>
		''' This event is sent after
		''' rows have been deleted by the user.
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub SuperGridControl1RowDeleted(ByVal sender As Object, ByVal e As GridRowDeletedEventArgs)
			btnPurge.Enabled = (superGridControl1.PrimaryGrid.DeletedRowCount > 0)
		End Sub

		#End Region

		#Region "SuperGridControl1RowSetDefaultValues"

		''' <summary>
		''' This event is sent when a new row is added.  It gives
		''' our application the opportunity to establish a new
		''' set of default values for the added row.
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub SuperGridControl1RowSetDefaultValues(ByVal sender As Object, ByVal e As GridRowSetDefaultValuesEventArgs)
			e.GridRow.Cells(0).Value = "John*"
			e.GridRow.Cells(1).Value = "Doe"
			e.GridRow.Cells(2).Value = 20
			e.GridRow.Cells(3).Value = 20001
			e.GridRow.Cells(4).Value = Date.Now
		End Sub

		#End Region

		#Region "CboDataSourceSelectedIndexChanged"

		''' <summary>
		''' Handles user comboBox selection of a new data source.
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub CboDataSourceSelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cboDataSource.SelectedIndexChanged
			Dim dataSource As Object = Nothing
			Dim dataMember As String = Nothing
			Dim context As Object = Nothing

			Select Case cboDataSource.SelectedIndex
					' IList
				Case 0
					Dim list As New List(Of Employee)()

					For i As Integer = 0 To 49
						list.Add(Employee.GetNewEmployee())
					Next i

					dataSource = list
					context = dataSource

					' IListSource
				Case 1
					Dim listSource As IListSource = New EmployeeListSource()
					dataSource = listSource
					context = listSource.GetList()

					' IBindingList
				Case 2
					Dim bindingList As New BindingList(Of Employee)()

					For i As Integer = 0 To 49
						bindingList.Add(Employee.GetNewEmployee())
					Next i

					dataSource = bindingList
					context = dataSource

					' DataSet
				Case 3
					dataSource = GetEmployeeDataSet()
					dataMember = "Employees"
					context = (CType(dataSource, DataSet)).Tables("Employees")
			End Select

			' Set the SuperGrid DataSource and DataMember, and
			' set our BindingManager for later data traversal

			superGridControl1.PrimaryGrid.DataSource = dataSource
			superGridControl1.PrimaryGrid.DataMember = dataMember

            If dataSource Is Nothing Then Bm = Nothing Else Bm = superGridControl1.BindingContext(context)

			' Make sure our UI reflects the current state of affairs

			btnDetach.Enabled = (cboDataSource.SelectedIndex < 4)
			btnDeleteRow.Enabled = btnDetach.Enabled
			btnInsertRow.Enabled = btnDeleteRow.Enabled

			btnPurge.Enabled = False

			UpdateVcr()
			UpdateBindings(context)
		End Sub

		#End Region

		#Region "UpdateBindings"

		''' <summary>
		''' Establishes our data bindings for the form
		''' level controls in our sample app
		''' </summary>
		''' <param name="context"></param>
		Private Sub UpdateBindings(ByVal context As Object)
			txbFirstName.DataBindings.Clear()
			txbLastName.DataBindings.Clear()
			tbxAge.DataBindings.Clear()
			tbxEmployeeId.DataBindings.Clear()
			txbHireDate.DataBindings.Clear()

			If context IsNot Nothing Then
				txbFirstName.DataBindings.Add(New Binding("Text", context, "FirstName"))
				txbLastName.DataBindings.Add(New Binding("Text", context, "LastName"))
				tbxAge.DataBindings.Add(New Binding("Text", context, "Age"))
				tbxEmployeeId.DataBindings.Add(New Binding("Text", context, "Id"))
				txbHireDate.DataBindings.Add(New Binding("Text", context, "HireDate"))
			Else
				txbFirstName.Text = ""
				txbLastName.Text = ""
				tbxAge.Text = ""
				tbxEmployeeId.Text = ""
				txbHireDate.Text = ""
			End If
		End Sub

		#End Region

		#Region "GetEmployeeDataSet"

		''' <summary>
		''' Creates our Employee DataSet
		''' </summary>
		''' <returns></returns>
		Private Function GetEmployeeDataSet() As DataSet
			Dim table As New DataTable("Employees")

			Dim col As New DataColumn()
			col.ColumnName = "FirstName"
			col.DataType = Type.GetType("System.String")
			table.Columns.Add(col)

			col = New DataColumn()
			col.ColumnName = "LastName"
			col.DataType = Type.GetType("System.String")
			table.Columns.Add(col)

			col = New DataColumn()
			col.ColumnName = "Age"
			col.DataType = Type.GetType("System.Int32")
			table.Columns.Add(col)

			col = New DataColumn()
			col.ColumnName = "Id"
			col.DataType = Type.GetType("System.Int32")
			table.Columns.Add(col)

			col = New DataColumn()
			col.ColumnName= "HireDate"
			col.DataType = Type.GetType("System.DateTime")
			table.Columns.Add(col)

			Dim ds As New DataSet("MyDataSet")
			ds.Tables.Add(table)

			table.BeginLoadData()

			' Add 50 rows to fiddle with

			For i As Integer = 0 To 49
				Dim row As DataRow = table.NewRow()

				Dim emp As Employee = Employee.GetNewEmployee()

				row(0) = emp.FirstName
				row(1) = emp.LastName
				row(2) = emp.Age
				row(3) = emp.Id
				row(4) = emp.HireDate

				table.Rows.Add(row)

				row.AcceptChanges()
			Next i

			table.EndLoadData()

			Return (ds)
		End Function

		#End Region

		#Region "BtnPurgeClick"

		''' <summary>
		''' Handles user requests to purge grid deleted records
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub BtnPurgeClick(ByVal sender As Object, ByVal e As EventArgs) Handles btnPurge.Click
			superGridControl1.PrimaryGrid.PurgeDeletedRows()

			If Bm.Count > 0 Then
				btnDeleteRow.Enabled = True
			End If

			btnPurge.Enabled = False
		End Sub

		#End Region

		#Region "BtnDetachClick"

		''' <summary>
		''' Detaches the grid from the current set data source,
		''' enabling the grid operate on unbound data
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub BtnDetachClick(ByVal sender As Object, ByVal e As EventArgs) Handles btnDetach.Click
			superGridControl1.PrimaryGrid.DetachDataSource(True)

			btnDetach.Enabled = False
		End Sub

		#End Region

		#Region "Vcr Control support"

		#Region "BmPositionChanged"

		''' <summary>
		''' Updates out VCR control when the user
		''' moves position in the data collection
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub BmPositionChanged(ByVal sender As Object, ByVal e As EventArgs)
			UpdateVcr()
		End Sub

		#End Region

		#Region "VcrFirstClick"

		''' <summary>
		''' Handles VCR "first record" clicks
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub VcrFirstClick(ByVal sender As Object, ByVal e As EventArgs) Handles vcr1.FirstClick
			If _Bm IsNot Nothing Then
				_Bm.Position = 0
			End If

			UpdateVcr()
		End Sub

		#End Region

		#Region "VcrPreviousClick"

		''' <summary>
		''' Handles user "previous record" clicks
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub VcrPreviousClick(ByVal sender As Object, ByVal e As EventArgs) Handles vcr1.PreviousClick
			If _Bm IsNot Nothing Then
				_Bm.Position -= 1
			End If

			UpdateVcr()
		End Sub

		#End Region

		#Region "VcrNextClick"

		''' <summary>
		''' Handles user "Next record" clicks
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub VcrNextClick(ByVal sender As Object, ByVal e As EventArgs) Handles vcr1.NextClick
			If _Bm IsNot Nothing Then
				_Bm.Position += 1
			End If

			UpdateVcr()
		End Sub

		#End Region

		#Region "VcrLastClick"

		''' <summary>
		''' Handles user "Last record" clicks
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub VcrLastClick(ByVal sender As Object, ByVal e As EventArgs) Handles vcr1.LastClick
			If _Bm IsNot Nothing Then
				_Bm.Position = _Bm.Count
			End If

			UpdateVcr()
		End Sub

		#End Region

		#Region "UpdateVcr"

		''' <summary>
		''' Updates our VCR states
		''' </summary>
		Private Sub UpdateVcr()
			If _Bm Is Nothing OrElse _Bm.Count <= 1 Then
				vcr1.FirstButton.Enabled = False
				vcr1.PreviousButton.Enabled = False
				vcr1.NextButton.Enabled = False
				vcr1.LastButton.Enabled = False

                vcr1.Label.Text = IIf(_Bm Is Nothing OrElse _Bm.Count = 0, "No records", "Only Record")
			Else
				If _Bm.Position = 0 Then
					vcr1.PreviousButton.Enabled = False
					vcr1.FirstButton.Enabled = vcr1.PreviousButton.Enabled

					vcr1.NextButton.Enabled = (_Bm.Count > 1)
					vcr1.LastButton.Enabled = vcr1.NextButton.Enabled

					vcr1.Label.Text = "First of " & _Bm.Count & " records"
				ElseIf _Bm.Position = _Bm.Count - 1 Then
					vcr1.LastButton.Enabled = False
					vcr1.NextButton.Enabled = False

					vcr1.PreviousButton.Enabled = (_Bm.Count > 1)
					vcr1.FirstButton.Enabled = vcr1.PreviousButton.Enabled

					vcr1.Label.Text = "Last of " & _Bm.Count & " records"
				Else
					vcr1.FirstButton.Enabled = True
					vcr1.PreviousButton.Enabled = True
					vcr1.NextButton.Enabled = True
					vcr1.LastButton.Enabled = True

					vcr1.Label.Text = "Record " & (_Bm.Position + 1) & " of " & _Bm.Count
				End If
			End If
		End Sub

		#End Region

		#End Region

		#Region "BtnDeleteRowClick"

		''' <summary>
		''' Deletes the current positioned row.
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub BtnDeleteRowClick(ByVal sender As Object, ByVal e As EventArgs) Handles btnDeleteRow.Click
			If Bm IsNot Nothing Then
				If Bm.Position >= 0 Then
					Bm.RemoveAt(Bm.Position)

					If Bm.Count = 0 Then
						btnDeleteRow.Enabled = False
					End If

					' For those interfaces that don't support automatic
					' notification, lets refresh the display ourselves

					If cboDataSource.SelectedIndex = 0 OrElse cboDataSource.SelectedIndex = 1 Then
						superGridControl1.PrimaryGrid.InvalidateLayout()
					End If
				End If
			End If
		End Sub

		#End Region

		#Region "BtnInsertRowClick"

		''' <summary>
		''' Handles user requests to insert
		''' a new row at the current position.
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub BtnInsertRowClick(ByVal sender As Object, ByVal e As EventArgs) Handles btnInsertRow.Click
			If Bm IsNot Nothing Then
				Dim index As Integer = Math.Max(0, Bm.Position)

				Select Case cboDataSource.SelectedIndex
					Case 0, 2
						Dim ilist As IList = TryCast(superGridControl1.PrimaryGrid.DataSource, IList)

						If ilist IsNot Nothing Then
							Dim emp As Employee = Employee.GetNewEmployee()
							emp.FirstName &= "*"

							ilist.Insert(index, emp)

							superGridControl1.PrimaryGrid.InvalidateLayout()
						End If

					Case 1
						Dim ilistSource As IListSource = TryCast(superGridControl1.PrimaryGrid.DataSource, IListSource)

						If ilistSource IsNot Nothing Then
							Dim emp As Employee = Employee.GetNewEmployee()
							emp.FirstName &= "*"

							ilistSource.GetList().Insert(index, emp)
						End If

					Case 3
						Dim dataSet As DataSet = TryCast(superGridControl1.PrimaryGrid.DataSource, DataSet)

						If dataSet IsNot Nothing Then
							Dim table As DataTable = dataSet.Tables (superGridControl1.PrimaryGrid.DataMember)

							Dim row As DataRow = table.NewRow()

							Dim emp As Employee = Employee.GetNewEmployee()
							row(0) = emp.FirstName & "*"
							row(1) = emp.LastName
							row(2) = emp.Age
							row(3) = emp.Id
							row(4) = emp.HireDate

							table.Rows.InsertAt(row, index)

							row.AcceptChanges()
						End If
				End Select

				If Bm.Count > 0 Then
					btnDeleteRow.Enabled = True
				End If
			End If
		End Sub

		#End Region

		#Region "TbxNumericKeyPress"

		''' <summary>
		''' Used to limit our 'age' and 'EmployeeId' TextBox
		''' input to numeric data only (only decimals, non-negative, etc)
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub TbxNumericKeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles tbxEmployeeId.KeyPress, tbxAge.KeyPress
			e.Handled = (Not Char.IsDigit(e.KeyChar)) AndAlso e.KeyChar <> ChrW(8)

			If e.Handled = True Then
				SystemSounds.Beep.Play()
			End If
		End Sub

		#End Region
	End Class

	#Region "Employee"

	''' <summary>
	''' Simple Employee class definition
	''' </summary>
	Public Class Employee
		Implements INotifyPropertyChanged
		#Region "Private variables"

		Private _FirstName As String
		Private _LastName As String
		Private _Age As Integer
		Private _Id As Integer
		Private _HireDate As Date

		Private Shared _Rand As New Random()

		Private Shared FirstNames() As String = { "Isabella", "Sophia", "Emma", "Olivia", "Ava", "Emily", "Abigail", "Madison", "Chloe", "Mia", "Addison", "Elizabeth", "Ella", "Natalie", "Samantha", "Alexis", "Lily", "Grace", "Hailey", "Alyssa", "Lillian", "Hannah", "Avery", "Leah", "Nevaeh", "Sofia", "Ashley", "Anna", "Brianna", "Sarah", "Zoe", "Victoria", "Gabriella", "Brooklyn", "Kaylee", "Taylor", "Layla", "Allison", "Evelyn", "Riley", "Amelia", "Khloe"}

		Private Shared LastNames() As String = { "Smith", "Johnson", "Williams", "Brown", "Jones", "Miller", "Davis", "García", "Rodríguez", "Wilson", "Martínez", "Anderson", "Taylor", "Thomas", "Hernández", "Moore", "Martin", "Jackson", "Thompson", "White", "López", "Lee", "González", "Harris", "Clark", "Lewis", "Robinson", "Walker", "Pérez", "Hall", "Young"}

		#End Region

		Public Sub New()
		End Sub

		Public Sub New(ByVal firstName As String, ByVal lastName As String, ByVal age As Integer, ByVal id As Integer, ByVal hireDate As Date)
			_FirstName = firstName
			_LastName = lastName
			_Age = age
			_Id = id
			_HireDate = hireDate
		End Sub

		#Region "GetNewEmployee"

		''' <summary>
		''' Gets a new, random employee
		''' </summary>
		''' <returns></returns>
		Public Shared Function GetNewEmployee() As Employee
			Dim fname As String = FirstNames(_Rand.Next(FirstNames.Length))
			Dim lname As String = LastNames(_Rand.Next(LastNames.Length))

			Dim age As Integer = _Rand.Next(18, 70)
			Dim id As Integer = _Rand.Next(10000, 12000)

			Dim hireDate As Date = Date.Now.AddMonths(-_Rand.Next(12, 240))

			Return (New Employee(fname, lname, age, id, hireDate))
		End Function

		#End Region

		#Region "Public properties"

		Public Property FirstName() As String
			Get
				Return (_FirstName)
			End Get

			Set(ByVal value As String)
				_FirstName = value

				OnPropertyChanged("FirstName")
			End Set
		End Property

		Public Property LastName() As String
			Get
				Return (_LastName)
			End Get

			Set(ByVal value As String)
				_LastName = value

				OnPropertyChanged("LastName")
			End Set
		End Property

		Public Property Age() As Integer
			Get
				Return (_Age)
			End Get

			Set(ByVal value As Integer)
				_Age = value

				OnPropertyChanged("Age")
			End Set
		End Property

		Public Property Id() As Integer
			Get
				Return (_Id)
			End Get

			Set(ByVal value As Integer)
				_Id = value

				OnPropertyChanged("Id")
			End Set
		End Property

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

	#Region "EmployeeListSource"

	''' <summary>
	''' Our IListSource employee class
	''' </summary>
	Public Class EmployeeListSource
		Implements IListSource
		#Region "Private variables"

		Private _Ble As BindingList(Of Employee)

		#End Region

		Public Sub New()
			_Ble = New BindingList(Of Employee)()

			For i As Integer = 0 To 49
				_Ble.Add(Employee.GetNewEmployee())
			Next i
		End Sub

		#Region "IListSource Members"

		Private ReadOnly Property ContainsListCollection() As Boolean Implements IListSource.ContainsListCollection
			Get
				Return (False)
			End Get
		End Property

		Private Function GetList() As IList Implements IListSource.GetList
			Return (_Ble)
		End Function

		#End Region
	End Class

	#End Region
End Namespace