Imports System.Data.OleDb
Imports System.IO
Imports System.Reflection
Imports DevComponents.DotNetBar.SuperGrid
Imports DevComponents.DotNetBar.SuperGrid.Style

Namespace SuperGridDemo
	Partial Public Class DemoMasterDetail
        Inherits DevComponents.DotNetBar.Office2007Form
		#Region "Private properties"

		Private _DataSet As DataSet

		#End Region

		Public Sub New()
			InitializeComponent()

			' Initialize the grid, bind to our grid data
			' and set the sample description text

			InitializeGrid()
			BindCustomerData()

            ShellServices.LoadRtbText(richTextBox1, "SuperGridDemo.DemoMasterDetail.rtf")
		End Sub

		#Region "InitializeGrid"

		''' <summary>
		''' Initializes the default grid
		''' </summary>
		Private Sub InitializeGrid()
			Dim panel As GridPanel = superGridControl1.PrimaryGrid

			panel.Name = "Customers"
			panel.ShowToolTips = True

			panel.MinRowHeight = 20
			panel.AutoGenerateColumns = True

			panel.SelectionGranularity = SelectionGranularity.Cell

			AddHandler superGridControl1.CellValueChanged, AddressOf SuperGridControl1CellValueChanged
			AddHandler superGridControl1.GetCellStyle, AddressOf SuperGridControl1GetCellStyle
			AddHandler superGridControl1.DataBindingComplete, AddressOf SuperGridControl1DataBindingComplete
		End Sub

		#End Region

		#Region "BindCustomerData"

		''' <summary>
		''' Binds our data to the grid
		''' </summary>
		Private Sub BindCustomerData()
			Dim location As String = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) & "\Resources"

			If location IsNot Nothing Then
				_DataSet = New DataSet()

                Dim path As String = System.IO.Path.Combine(location, "nwind.mdb")

				Using cn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & path & ";User Id=admin;Password=;")
					Dim adapter As New OleDbDataAdapter("SELECT * FROM Customers;", cn)
					adapter.Fill(_DataSet, "Customers")

					CType(New OleDbDataAdapter("SELECT * FROM Orders;", cn), OleDbDataAdapter).Fill(_DataSet, "Orders")
					CType(New OleDbDataAdapter("SELECT * FROM [Order Details];", cn), OleDbDataAdapter).Fill(_DataSet, "Order Details")

					_DataSet.Relations.Add("1", _DataSet.Tables("Customers").Columns("CustomerID"), _DataSet.Tables("Orders").Columns("CustomerID"), False)

					_DataSet.Relations.Add("2", _DataSet.Tables("Orders").Columns("OrderID"), _DataSet.Tables("Order Details").Columns("OrderID"), False)
				End Using

				superGridControl1.PrimaryGrid.DataSource = _DataSet
				superGridControl1.PrimaryGrid.DataMember = "Customers"
			End If
		End Sub

		#End Region

		#Region "SuperGridControl1CellValueChanged"

		''' <summary>
		''' Handles cell value change events
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub SuperGridControl1CellValueChanged(ByVal sender As Object, ByVal e As GridCellValueChangedEventArgs)
			Dim panel As GridPanel = e.GridPanel

			' If a cell value in the "Order Details" panel has changed
			' then update its footer to reflect the change

			If panel.Name.Equals("Order Details") = True Then
				UpdateDetailsFooter(panel)
			End If
		End Sub

		#End Region

		#Region "SuperGridControl1GetCellStyle"

		''' <summary>
		''' This routine is called to retrieve application provided
		''' cell style information. The style being presented in this
		''' call is the Effective Style (style used after applying
		''' all base styles).
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub SuperGridControl1GetCellStyle(ByVal sender As Object, ByVal e As GridGetCellStyleEventArgs)
			Dim panel As GridPanel = e.GridPanel

			If panel.Name.Equals("Customers") = True Then
				If e.GridCell.GridColumn.Name.Equals("ContactTitle") = True Then
					If (CStr(e.GridCell.Value)).Equals("Owner") = True Then
						e.Style.TextColor = Color.Red
					End If
				End If
			End If
		End Sub

		#End Region

		#Region "SuperGridControl1DataBindingComplete"

		''' <summary>
		''' This routine is called after each bindable data portion has
		''' been completed. This callout lets you customize the display
		''' or visibility of the data however the application needs.
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub SuperGridControl1DataBindingComplete(ByVal sender As Object, ByVal e As GridDataBindingCompleteEventArgs)
			Dim panel As GridPanel = e.GridPanel

			Select Case panel.DataMember
				Case "Customers"
					CustomizeCustomerPanel(panel)

				Case "Orders"
					CustomizeOrdersPanel(panel)

				Case "Order Details"
					CustomizeDetailsPanel(panel)
			End Select
		End Sub

		#Region "CustomizeCustomerPanel"

		''' <summary>
		''' Customizes the CustomerPanel
		''' </summary>
		''' <param name="panel"></param>
		Private Sub CustomizeCustomerPanel(ByVal panel As GridPanel)
			panel.FrozenColumnCount = 1
			panel.ColumnHeader.RowHeight = 30

			panel.Columns("Region").NullString = "<no locale>"

			panel.Columns(0).CellStyles.Default.Background = New Background(Color.AliceBlue)

			For Each column As GridColumn In panel.Columns
				column.ColumnSortMode = ColumnSortMode.Multiple
			Next column
		End Sub

		#End Region

		#Region "CustomizeOrdersPanel"

		''' <summary>
		''' Customizes the OrdersPanel
		''' </summary>
		''' <param name="panel"></param>
		Private Sub CustomizeOrdersPanel(ByVal panel As GridPanel)
			panel.ShowRowGridIndex = True
			panel.ShowRowDirtyMarker = True
			panel.ColumnHeader.RowHeight = 30

			panel.Columns(0).CellStyles.Default.Background = New Background(Color.Beige)

			panel.Caption = New GridCaption()

			panel.Caption.Text = String.Format("Orders ({0}) for customer <font color=""Maroon""><i>""{1}</i>""</font>", panel.Rows.Count, (CType(panel.Parent, GridRow))("CompanyName").Value)

			panel.DefaultVisualStyles.CaptionStyles.Default.Alignment = Alignment.MiddleLeft
		End Sub

		#End Region

		#Region "CustomizeDetailsPanel"

		''' <summary>
		''' Customizes the DetailsPanel
		''' </summary>
		''' <param name="panel"></param>
		Private Sub CustomizeDetailsPanel(ByVal panel As GridPanel)
			panel.ColumnHeader.RowHeight = 30

			panel.Columns(0).CellStyles.Default.Background = New Background(Color.LavenderBlush)

			panel.Columns("OrderID").CellStyles.Default.Alignment = Alignment.MiddleLeft

			panel.DefaultVisualStyles.CaptionStyles.Default.Alignment = Alignment.MiddleLeft
			panel.DefaultVisualStyles.CellStyles.Default.Alignment = Alignment.MiddleRight

			UpdateDetailsFooter(panel)
		End Sub

		#End Region

		#Region "UpdateDetailsFooter"

		''' <summary>
		''' Updates the Details Footer
		''' </summary>
		''' <param name="panel"></param>
		Private Sub UpdateDetailsFooter(ByVal panel As GridPanel)
			If panel.Footer Is Nothing Then
				panel.Footer = New GridFooter()
			End If

			Dim total As Decimal = 0

			For Each row As GridRow In panel.Rows
				Dim unitPrice As Decimal = CDec(row("UnitPrice").Value)
				Dim discount As Single = CSng(row("Discount").Value)
				Dim quantity As Short = CShort(Fix(row("Quantity").Value))

				total += (unitPrice - CDec(discount)) * quantity
			Next row

			panel.Footer.Text = String.Format("Total sales <font color=""Green""><i>{0:C}</i></font>", total)
		End Sub

		#End Region

		#End Region
	End Class
End Namespace