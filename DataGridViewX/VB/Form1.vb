Imports System.Text
Imports System.ComponentModel
Imports Microsoft.VisualBasic
Imports DevComponents.DotNetBar
Imports DevComponents.DotNetBar.Controls
Imports DevComponents.DotNetBar.Rendering

Public Class Form1

#Region "Private variables"

    Private _MColorSelected As Boolean
    Private _MBaseColorScheme As eOffice2007ColorScheme = eOffice2007ColorScheme.Blue
    Private _ContactTypes As List(Of String)

#End Region

    Public Sub New()
        InitializeComponent()

        ' Initialize our X1 and X2 DataGridViews

        X1_Initialize()
        X2_Initialize()

    End Sub

#Region "Form1_Load"

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        ' This line of code loads data into the
        ' 'customersDataSet.Customers' table. You can move, or remove it, as needed.

        CustomersTableAdapter.Fill(Me.CustomersDataSet.Customers)

        LoadOrderData()
    End Sub

#Region "LoadOrderData"

    ''' <summary>
    ''' Loads default Order data into the
    ''' customersDataSet.Orders data table
    ''' </summary>
    Private Sub LoadOrderData()
        Dim r As New Random()
        Dim [date] As DateTime = DateTime.Now
        Dim sb As New StringBuilder()

        ' Loop through the customersDataSet.Customers data table and
        ' add an Order into the customersDataSet.Orders for each one

        For i As Integer = 0 To customersDataSet.Customers.Count - 1
            CustomersDataSet.Orders.AddOrdersRow(CustomersDataSet.Customers(i).CustomerID, _
                r.[Next](1000, 9999).ToString(), [date].AddDays(-r.[Next](2, 90)), _
                GetNewPart(sb, r), CDec((r.NextDouble() * 100)), r.[Next](1, 100), _
                r.[Next](1, 100), Math.Max(0, Math.Min(r.[Next](-20, 140), 100)), GetNewFeedback(r))
        Next
    End Sub

#Region "GetNewPart"

    ''' <summary>
    ''' Gets a new Part number for the order that
    ''' conforms to the "DD-AAA-DDDDA" pattern
    ''' </summary>
    ''' <param name="sb"></param>
    ''' <param name="r"></param>
    ''' <returns></returns>
    Private Function GetNewPart(ByVal sb As StringBuilder, ByVal r As Random) As String
        sb.Length = 0

        sb.Append(r.[Next](10, 99))
        sb.Append(Microsoft.VisualBasic.Chr(r.[Next](&H41, &H5B)))
        sb.Append(Chr(r.[Next](&H41, &H5B)))
        sb.Append(Chr(r.[Next](&H41, &H5B)))
        sb.Append(r.[Next](1000, 9999))

        If (r.[Next](0, 2) = 0) Then
            sb.Append("N")
        Else
            sb.Append("R")
        End If

        Return (sb.ToString())
    End Function

#End Region

#Region "GetNewFeedback"

    ''' <summary>
    ''' Gets a new order feedback value
    ''' </summary>
    ''' <param name="r"></param>
    ''' <returns></returns>
    Private Function GetNewFeedback(ByVal r As Random) As String
        Dim fb As Integer = r.[Next](0, 4)

        Select Case fb
            Case 0
                Return "U"
            Case 1
                Return "N"
            Case Else
                Return "Y"
        End Select

    End Function

#End Region

#End Region

#End Region

#Region "DataGridViewX1 support"

#Region "X1_Initialize"

    ''' <summary>
    ''' Initialize our Data~GridViewX1 sample view
    ''' </summary>
    Private Sub X1_Initialize()
        X1Contact_Initialize()
        X1Country_Initialize()
        X1Region_Initialize()
        X1PostalCode_Initialize()

        ' Hook onto the CellContentClick so we can
        ' demonstrate one way to process cell clicks

        AddHandler dataGridViewX1.CellContentClick, AddressOf DataGridViewX1_CellContentClick
    End Sub

#End Region

#Region "X1Contact_Initialize"

    ''' <summary>
    ''' Initializes out X1 Contact environment
    ''' </summary>
    Private Sub X1Contact_Initialize()
        Dim bcx As DataGridViewButtonXColumn = TryCast(dataGridViewX1.Columns("Contact"), DataGridViewButtonXColumn)

        If bcx IsNot Nothing Then
            ' Allocate our running list of
            ' selected contact types

            _ContactTypes = New List(Of String)()
            _ContactTypes.Add("Owner")

            ' We want to be able to specify our own button text
            ' instead of using the bound data value for the text

            bcx.UseColumnTextForButtonValue = False

            ' Hook onto the following events so we can
            ' demonstrate cell customization and click processing

            AddHandler bcx.BeforeCellPaint, AddressOf X1Contact_BeforeCellPaint
            AddHandler bcx.Click, AddressOf X1Contact_ButtonClick
        End If
    End Sub

#Region "X1Contact_BeforeCellPaint"

    ''' <summary>
    ''' Handles "Contact" BeforeCellPaint events
    ''' </summary>
    ''' <param name="sender">DataGridViewButtonXColumn</param>
    ''' <param name="e">BeforeCellPaintEventArgs</param>
    Private Sub X1Contact_BeforeCellPaint(ByVal sender As Object, ByVal e As BeforeCellPaintEventArgs)
        Dim bcx As DataGridViewButtonXColumn = TryCast(sender, DataGridViewButtonXColumn)

        If bcx IsNot Nothing Then
            ' If the cell text is in our _ContactTypes list, then
            ' give our button a default background - otherwise not.

            If (_ContactTypes.Contains(bcx.Text)) Then
                bcx.ColorTable = eButtonColor.OrangeWithBackground
            Else
                bcx.ColorTable = eButtonColor.Orange
            End If
        End If

    End Sub

#End Region

#Region "X1Contact_ButtonClick"

    ''' <summary>
    ''' Handles our "Contact" cell button clicks.
    ''' 
    ''' <remarks>
    ''' Clicking on a "Contact" cell will result in the addition or removal of the
    ''' cell text from our _ContactTypes list.  The _ContactTypes list is then used
    ''' in the BeforeContactCellPaint routine to format the cell display.
    ''' </remarks>
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub X1Contact_ButtonClick(ByVal sender As Object, ByVal e As EventArgs)
        Dim cell As DataGridViewButtonXCell = TryCast(dataGridViewX1.CurrentCell, DataGridViewButtonXCell)

        If cell IsNot Nothing Then
            Dim s As String = Convert.ToString(cell.Value)

            ' If the text was already in our list, then remove it.
            ' If it wasn't, then add it.

            If _ContactTypes.Contains(s) Then
                _ContactTypes.Remove(s)
            Else
                _ContactTypes.Add(s)
            End If

            ' Update the entire column so that each column cell
            ' will be reformatted according to the new list values.

            dataGridViewX1.InvalidateColumn(cell.ColumnIndex)
        End If
    End Sub

#End Region

#End Region

#Region "X1Country_Initialize"

    ''' <summary>
    ''' Initializes our X1 Country environment
    ''' </summary>
    Private Sub X1Country_Initialize()
        Dim bcx As DataGridViewButtonXColumn = TryCast(dataGridViewX1.Columns("Country"), DataGridViewButtonXColumn)

        If bcx IsNot Nothing Then
            ' We want to be able to specify our own button text
            ' instead of using the bound data value for the text

            bcx.UseColumnTextForButtonValue = False

            ' Hook onto the BeforeCellPaint event so we can
            ' demonstrate cell customization

            AddHandler bcx.BeforeCellPaint, AddressOf X1Country_BeforeCellPaint
        End If
    End Sub

#Region "X1Country_BeforeCellPaint"

    ''' <summary>
    ''' Handles our "Country" BeforeCellPaint events
    ''' </summary>
    ''' <param name="sender">DataGridViewButtonXColumn</param>
    ''' <param name="e">BeforeCellPaintEventArgs</param>
    Private Sub X1Country_BeforeCellPaint(ByVal sender As Object, ByVal e As BeforeCellPaintEventArgs)
        Dim bcx As DataGridViewButtonXColumn = TryCast(sender, DataGridViewButtonXColumn)

        ' Set the button flag image to correspond to country

        If bcx IsNot Nothing Then
            bcx.Image = imageList1.Images(bcx.Text)
        End If
    End Sub

#End Region

#End Region

#Region "X1Region_Initialize"

    ''' <summary>
    ''' Initializes our X1 Region environment
    ''' </summary>
    Private Sub X1Region_Initialize()
        Dim bcx As DataGridViewButtonXColumn = TryCast(dataGridViewX1.Columns("RegionC"), DataGridViewButtonXColumn)

        If bcx IsNot Nothing Then
            ' Create and add a couple of levels
            ' of SubItems to our cell button

            X1Region_AddSubItems(bcx)

            ' We want to be able to specify our own button text
            ' instead of using the bound data value for the text

            bcx.UseColumnTextForButtonValue = False

            ' Hook onto the BeforeCellPaint event so we can
            ' demonstrate cell customization

            AddHandler bcx.BeforeCellPaint, AddressOf X1Region_BeforeCellPaint
        End If
    End Sub

#Region "X1Region_AddSubItems"

    ''' <summary>
    ''' Creates and adds a couple of SubItem buttons
    ''' to the Region cell button
    ''' </summary>
    ''' <param name="bcx"></param>
    Private Sub X1Region_AddSubItems(ByVal bcx As DataGridViewButtonXColumn)
        Dim bi As New ButtonItem()
        bi.Text = "Display Region Map"
        AddHandler bi.Click, AddressOf X1Region_DefaultButtonClick

        bcx.SubItems.Add(bi)

        bi = New ButtonItem()
        bi.Text = "Print..."
        bi.Image = imageList1.Images("Print")

        bcx.SubItems.Add(bi)

        Dim sbi As New ButtonItem()
        sbi.Text = "Region Contacts"
        sbi.Image = imageList1.Images("User")
        AddHandler sbi.Click, AddressOf X1Region_DefaultButtonClick

        bi.SubItems.Add(sbi)

        sbi = New ButtonItem()
        sbi.Text = "Region Statistics"
        AddHandler sbi.Click, AddressOf X1Region_DefaultButtonClick

        bi.SubItems.Add(sbi)
    End Sub

#Region "X1Region_DefaultButtonClick"

    ''' <summary>
    ''' Handles X2 "Region" SubItem button clicks
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub X1Region_DefaultButtonClick(ByVal sender As Object, ByVal e As EventArgs)
        Dim bi As ButtonItem = TryCast(sender, ButtonItem)

        If bi IsNot Nothing Then
            MessageBox.Show(bi.Text)
        End If
    End Sub

#End Region

#End Region

#Region "X1Region_BeforeCellPaint"

    ''' <summary>
    ''' Handles "Region" BeforeCellPaint events
    ''' </summary>
    ''' <param name="sender">DataGridViewButtonXColumn</param>
    ''' <param name="e">BeforeCellPaintEventArgs</param>
    Private Sub X1Region_BeforeCellPaint(ByVal sender As Object, ByVal e As BeforeCellPaintEventArgs)
        Dim bcx As DataGridViewButtonXColumn = TryCast(sender, DataGridViewButtonXColumn)

        If bcx IsNot Nothing Then
            ' If button text is null or empty, then set the text and
            ' ColorTable to reflect that fact

            If String.IsNullOrEmpty(bcx.Text) = True Then
                bcx.Text = "<font color=""FireBrick"">(Unknown)</font>"
                bcx.ColorTable = eButtonColor.Magenta
            Else
                bcx.ColorTable = eButtonColor.OrangeWithBackground
            End If
        End If
    End Sub

#End Region

#End Region

#Region "X1PostalCode_Initialize"

    ''' <summary>
    ''' Initializes our X1 PostalCode environment
    ''' </summary>
    Private Sub X1PostalCode_Initialize()
        Dim bcx As DataGridViewLabelXColumn = TryCast(dataGridViewX1.Columns("PostalCode"), DataGridViewLabelXColumn)

        If bcx IsNot Nothing Then
            ' Hook onto the BeforeCellPaint event so we can
            ' demonstrate cell customization

            AddHandler bcx.BeforeCellPaint, AddressOf X1PostalCode_BeforeCellPaint
        End If
    End Sub

#Region "X1PostalCode_BeforeCellPaint"

    ''' <summary>
    ''' Handles "PostalCode" BeforeCellPaint events
    ''' </summary>
    ''' <param name="sender">DataGridViewButtonXColumn</param>
    ''' <param name="e">BeforeCellPaintEventArgs</param>
    Private Sub X1PostalCode_BeforeCellPaint(ByVal sender As Object, ByVal e As BeforeCellPaintEventArgs)
        Dim bcx As DataGridViewLabelXColumn = TryCast(sender, DataGridViewLabelXColumn)

        If bcx IsNot Nothing Then
            ' Set the label image

            If String.IsNullOrEmpty(bcx.Text) = True Then
                bcx.Image = imageList1.Images("SecHigh")
                bcx.Text = "<font color=""red"">Postal Code not Specified</font>"
            ElseIf bcx.Text.Contains(" ") Then
                bcx.Image = imageList1.Images("SecMedium")
            Else

                bcx.Image = imageList1.Images("SecLow")
            End If
        End If
    End Sub

#End Region

#End Region

#End Region

#Region "DataGridViewX2 support"

#Region "X2_Initialize"

    ''' <summary>
    ''' Initialize out DataGridViewX2 sample view.
    ''' </summary>
    Private Sub X2_Initialize()
        X2Order_Initialize()
        X2Date_Initialize()
        X2Part_Initialize()
        X2Quality_Initialize()
        X2Progress_Initialize()
        X2Feedback_Initialize()
    End Sub

#End Region

#Region "X2Order_Initialize"

    ''' <summary>
    ''' Initializes our X2 "Order" environment
    ''' </summary>
    Private Sub X2Order_Initialize()
        Dim oc As DataGridViewMaskedTextBoxAdvColumn = TryCast(dataGridViewX2.Columns("OrderC"), DataGridViewMaskedTextBoxAdvColumn)

        If oc IsNot Nothing Then
            ' Hook onto the following events so we can
            ' demonstrate cell customization and click processing

            AddHandler oc.BeforeCellPaint, AddressOf X2Order_BeforeCellPaint
            AddHandler oc.ButtonClearClick, AddressOf X2Order_ButtonClearClick
            AddHandler oc.ButtonCustomClick, AddressOf X2Order_ButtonCustomClick
        End If
    End Sub

#Region "X2Order_BeforeCellPaint"

    ''' <summary>
    ''' Handles "Order" BeforeCellPaint events
    ''' </summary>
    ''' <param name="sender">DataGridViewMaskedTextBoxAdvColumn</param>
    ''' <param name="e">BeforeCellPaintEventArgs</param>
    Private Sub X2Order_BeforeCellPaint(ByVal sender As Object, ByVal e As BeforeCellPaintEventArgs)
        Dim oc As DataGridViewMaskedTextBoxAdvColumn = TryCast(sender, DataGridViewMaskedTextBoxAdvColumn)

        If oc IsNot Nothing Then
            Dim s As String = oc.Text.Substring(1)

            Dim value As Integer

            If Integer.TryParse(s, value) Then
                If value <= 3000 Then
                    oc.BackColor = Color.MistyRose

                ElseIf value >= 7000 Then
                    oc.BackColor = Color.PaleTurquoise
                End If
            End If
        End If
    End Sub

#End Region

#Region "X2Order_ButtonClearClick"

    ''' <summary>
    ''' Handles X2 "Order" ButtonClear Clicks
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub X2Order_ButtonClearClick(ByVal sender As Object, ByVal e As CancelEventArgs)
        Dim dr As DialogResult = MessageBox.Show("Do you really want to clear this Order Number?", "Clear Order Number", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)

        If dr = DialogResult.No Then
            e.Cancel = True
        End If
    End Sub

#End Region

#Region "X2Order_ButtonCustomClick"

    ''' <summary>
    ''' Handles X2 "Order" ButtonCustom clicks
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub X2Order_ButtonCustomClick(ByVal sender As Object, ByVal e As EventArgs)
        Dim dr As DialogResult = MessageBox.Show("Assign new Order Number?", "New Order Number", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)

        If dr = DialogResult.Yes Then
            Dim cell As DataGridViewMaskedTextBoxAdvCell = TryCast(dataGridViewX2.CurrentCell, DataGridViewMaskedTextBoxAdvCell)

            If cell IsNot Nothing Then
                Dim ec As DataGridViewMaskedTextBoxAdvEditingControl = TryCast(cell.DataGridView.EditingControl, DataGridViewMaskedTextBoxAdvEditingControl)

                If ec IsNot Nothing Then
                    Dim rand As New Random()

                    ec.Text = rand.[Next](1, 9999).ToString()
                End If
            End If
        End If
    End Sub

#End Region

#End Region

#Region "X2Date_Initialize"

    ''' <summary>
    ''' Initializes our X2 "Date" environment
    ''' </summary>
    Private Sub X2Date_Initialize()
        Dim oc As DataGridViewDateTimeInputColumn = TryCast(dataGridViewX2.Columns("DateC"), DataGridViewDateTimeInputColumn)

        If oc IsNot Nothing Then
            ' Hook onto the following events so we can
            ' demonstrate cell click processing

            AddHandler oc.ButtonClearClick, AddressOf X2Date_ButtonClearClick
            AddHandler oc.ButtonCustomClick, AddressOf X2Date_ButtonCustomClick
        End If
    End Sub

#Region "X2Date_ButtonClearClick"

    ''' <summary>
    ''' Handles X2 "Date" ButtonClear Clicks
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub X2Date_ButtonClearClick(ByVal sender As Object, ByVal e As CancelEventArgs)
        Dim dr As DialogResult = MessageBox.Show("Do you really want to clear this Date?", "Clear Date", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)

        If dr = DialogResult.No Then
            e.Cancel = True
        End If
    End Sub

#End Region

#Region "X2Date_ButtonCustomClick"

    ''' <summary>
    ''' Handles X2 "Date" ButtonCustom click events
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub X2Date_ButtonCustomClick(ByVal sender As Object, ByVal e As EventArgs)
        Dim dr As DialogResult = MessageBox.Show("Set Date to today?", "Set Date", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)

        If dr = DialogResult.Yes Then
            Dim cell As DataGridViewDateTimeInputCell = TryCast(dataGridViewX2.CurrentCell, DataGridViewDateTimeInputCell)

            If cell IsNot Nothing Then
                Dim ec As DataGridViewDateTimeInputEditingControl = TryCast(cell.DataGridView.EditingControl, DataGridViewDateTimeInputEditingControl)

                If ec IsNot Nothing Then
                    ec.Text = DateTime.Today.ToString()
                End If
            End If
        End If
    End Sub

#End Region

#End Region

#Region "X2Part_Initialize"

    ''' <summary>
    ''' Initializes our X2 "Part" environment
    ''' </summary>
    Private Sub X2Part_Initialize()
        Dim oc As DataGridViewMaskedTextBoxAdvColumn = TryCast(dataGridViewX2.Columns("PartC"), DataGridViewMaskedTextBoxAdvColumn)

        If oc IsNot Nothing Then
            ' Hook onto the following events so we can
            ' demonstrate cell customization and click processing

            AddHandler oc.BeforeCellPaint, AddressOf X2Part_BeforeCellPaint
            AddHandler oc.ButtonCustomClick, AddressOf X2Part_ButtonCustomClick
            AddHandler oc.ButtonDropDownClick, AddressOf X2Part_ButtonDropDownClick
        End If
    End Sub

#Region "X2Part_BeforeCellPaint"

    ''' <summary>
    ''' Handles X2 "Part" BeforeCellPaint events
    ''' </summary>
    ''' <param name="sender">DataGridViewMaskedTextBoxAdvColumn</param>
    ''' <param name="e">BeforeCellPaintEventArgs</param>
    Private Sub X2Part_BeforeCellPaint(ByVal sender As Object, ByVal e As BeforeCellPaintEventArgs)
        Dim oc As DataGridViewMaskedTextBoxAdvColumn = TryCast(sender, DataGridViewMaskedTextBoxAdvColumn)

        If oc IsNot Nothing Then
            Dim s As String = oc.Text

            If s.EndsWith("N") = True Then
                oc.ForeColor = Color.Green

            ElseIf s.EndsWith("X") = True Then
                oc.ForeColor = Color.Red
            End If
        End If
    End Sub

#End Region

#Region "X2Part_ButtonCustomClick"

    ''' <summary>
    ''' Handles X2 "Part" ButtonCustomClick events
    ''' </summary>
    ''' <param name="sender">DataGridViewMaskedTextBoxAdvCell</param>
    ''' <param name="e">EventArgs</param>
    Private Sub X2Part_ButtonCustomClick(ByVal sender As Object, ByVal e As EventArgs)
        Dim cell As DataGridViewMaskedTextBoxAdvCell = TryCast(dataGridViewX2.CurrentCell, DataGridViewMaskedTextBoxAdvCell)

        If cell IsNot Nothing Then
            Dim ec As DataGridViewMaskedTextBoxAdvEditingControl = TryCast(cell.DataGridView.EditingControl, DataGridViewMaskedTextBoxAdvEditingControl)

            If ec IsNot Nothing Then
                Dim s As String = ec.Text

                If s.Length > 0 Then
                    ' Changed the ending text char and display some
                    ' nonsense to the user for feedback

                    ec.Text = s.Substring(0, s.Length - 1) & "X"

                    MessageBox.Show("Inventory part " & s & " added to bug tracking database.", "Bug Track", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            End If
        End If
    End Sub

#End Region

#Region "X2Part_ButtonDropDownClick"

    ''' <summary>
    ''' Handles X2 "Part" ButtonDropDown click events
    ''' </summary>
    ''' <param name="sender">DataGridViewMaskedTextBoxAdvCell</param>
    ''' <param name="e">CancelEventArgs</param>
    Private Sub X2Part_ButtonDropDownClick(ByVal sender As Object, ByVal e As CancelEventArgs)
        Dim cell As DataGridViewMaskedTextBoxAdvCell = TryCast(dataGridViewX2.CurrentCell, DataGridViewMaskedTextBoxAdvCell)

        If cell IsNot Nothing Then
            Dim ec As DataGridViewMaskedTextBoxAdvEditingControl = TryCast(cell.DataGridView.EditingControl, DataGridViewMaskedTextBoxAdvEditingControl)

            If ec IsNot Nothing Then
                cbNewParts.Checked = ec.Text.EndsWith("N")
                cbRefurbishedParts.Checked = ec.Text.EndsWith("R")
            End If
        End If
    End Sub

#End Region

#End Region

#Region "X2Quality_Initialize"

    ''' <summary>
    ''' Initializes our X2 "Quality" environment
    ''' </summary>
    Private Sub X2Quality_Initialize()
        Dim sc As DataGridViewSliderColumn = TryCast(dataGridViewX2.Columns("QualityC"), DataGridViewSliderColumn)

        ' Hook onto the BeforeCellPaint event so we can
        ' demonstrate cell customization

        If sc IsNot Nothing Then
            AddHandler sc.BeforeCellPaint, AddressOf X2Quality_BeforeCellPaint
        End If
    End Sub

#Region "X2Quality_BeforeCellPaint"

    ''' <summary>
    ''' Handles X2 "Quality" BeforeCellPaint events
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub X2Quality_BeforeCellPaint(ByVal sender As Object, ByVal e As BeforeCellPaintEventArgs)
        Dim sc As DataGridViewSliderColumn = TryCast(sender, DataGridViewSliderColumn)

        If sc IsNot Nothing Then
            sc.Text = Convert.ToString(sc.Value)

            If (sc.Value <= 30) Then
                sc.TextColor = Color.Red
            ElseIf (sc.Value >= 90) Then
                sc.TextColor = Color.Green
            Else
                sc.TextColor = Color.Blue
            End If
        End If
    End Sub

#End Region

#End Region

#Region "X2Progress_Initialize"

    ''' <summary>
    ''' Initializes our X2 "Progress" environment
    ''' </summary>
    Private Sub X2Progress_Initialize()
        Dim pb As DataGridViewProgressBarXColumn = TryCast(dataGridViewX2.Columns("ProgressC"), DataGridViewProgressBarXColumn)

        ' Hook onto the BeforeCellPaint event so we can
        ' demonstrate cell customization

        If pb IsNot Nothing Then
            AddHandler pb.BeforeCellPaint, AddressOf X2Progress_BeforeCellPaint
        End If
    End Sub

#Region "X2Progress_BeforeCellPaint"

    ''' <summary>
    ''' Handles X2 "Progress" BeforeCellPaint events
    ''' </summary>
    ''' <param name="sender">DataGridViewProgressBarXColumn</param>
    ''' <param name="e">BeforeCellPaintEventArgs</param>
    Private Sub X2Progress_BeforeCellPaint(ByVal sender As Object, ByVal e As BeforeCellPaintEventArgs)
        Dim pbc As DataGridViewProgressBarXColumn = TryCast(sender, DataGridViewProgressBarXColumn)

        If pbc IsNot Nothing Then
            Select Case pbc.Value
                Case 0
                    pbc.Text = "Not Started"
                    Exit Select

                Case 100
                    pbc.Text = "Completed"
                    pbc.ColorTable = eProgressBarItemColor.Normal
                    Exit Select
                Case Else

                    pbc.Text = ""
                    pbc.ColorTable = eProgressBarItemColor.Paused
                    Exit Select
            End Select

            If pbc.Value < 30 Then
                pbc.ColorTable = eProgressBarItemColor.[Error]
            End If
        End If
    End Sub

#End Region

#End Region

#Region "X2Feedback_Initialize"

    ''' <summary>
    ''' Initializes our X2 "Feedback" environment
    ''' </summary>
    Private Sub X2Feedback_Initialize()
        Dim cb As DataGridViewCheckBoxXColumn = TryCast(dataGridViewX2.Columns("FeedbackC"), DataGridViewCheckBoxXColumn)

        ' Hook onto the BeforeCellPaint event so we can
        ' demonstrate cell customization

        If cb IsNot Nothing Then
            AddHandler cb.BeforeCellPaint, AddressOf X2Feedback_BeforeCellPaint
        End If
    End Sub

#Region "X2Feedback_BeforeCellPaint"

    ''' <summary>
    ''' Handles X2 "Feedback" BeforeCellPaint events
    ''' </summary>
    ''' <param name="sender">DataGridViewCheckBoxXColumn</param>
    ''' <param name="e">BeforeCellPaintEventArgs</param>
    Private Sub X2Feedback_BeforeCellPaint(ByVal sender As Object, ByVal e As BeforeCellPaintEventArgs)
        Dim sc As DataGridViewCheckBoxXColumn = TryCast(sender, DataGridViewCheckBoxXColumn)

        If sc IsNot Nothing Then
            Select Case sc.CheckState
                Case CheckState.Checked
                    sc.Text = "Positive"
                    sc.TextColor = Color.Green
                    Exit Select

                Case CheckState.Unchecked
                    sc.Text = "Negative"
                    sc.TextColor = Color.Red
                    Exit Select
                Case Else

                    sc.Text = "----"
                    sc.TextColor = Color.DarkGray
                    Exit Select
            End Select
        End If
    End Sub

#End Region

#Region "cbNewParts_Click"

    ''' <summary>
    ''' Handles X2 "Part" type change "N" events
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cbNewParts_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cbNewParts.Click
        X2Part_UpdatePartType("N")
    End Sub

#End Region

#Region "cbRefurbishedParts_Click"

    ''' <summary>
    ''' Handles X2 "Part" type change "R" events
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cbRefurbishedParts_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cbRefurbishedParts.Click
        X2Part_UpdatePartType("R")
    End Sub

#End Region

#Region "X2Part_UpdatePartType"

    ''' <summary>
    ''' Updates the X2 "Part" type from the users
    ''' RadioButton selection
    ''' </summary>
    ''' <param name="t">Text to replace</param>
    Private Sub X2Part_UpdatePartType(ByVal t As String)
        Dim cell As DataGridViewMaskedTextBoxAdvCell = TryCast(dataGridViewX2.CurrentCell, DataGridViewMaskedTextBoxAdvCell)

        If cell IsNot Nothing Then
            Dim ec As DataGridViewMaskedTextBoxAdvEditingControl = TryCast(cell.DataGridView.EditingControl, DataGridViewMaskedTextBoxAdvEditingControl)

            If ec IsNot Nothing Then
                Dim s As String = ec.Text

                If s.EndsWith(t) = False Then
                    ec.Text = s.Substring(0, s.Length - 1) + t
                End If
            End If
        End If
    End Sub

#End Region

#End Region

#End Region

#Region "DataGridViewX1_CellContentClick"

    Private Sub DataGridViewX1_CellContentClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs)
        Dim cell As DataGridViewButtonXCell = TryCast(dataGridViewX1.CurrentCell, DataGridViewButtonXCell)

        If cell IsNot Nothing Then
            Dim bc As DataGridViewButtonXColumn = TryCast(dataGridViewX1.Columns(e.ColumnIndex), DataGridViewButtonXColumn)

            If bc IsNot Nothing Then
                Dim s As String = Convert.ToString(cell.Value)

                Select Case bc.Name
                    Case "Country"
                        MessageBox.Show("What a great country " & s & " is!", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Exit Select

                    Case "RegionC"
                        If (String.IsNullOrEmpty(s)) Then
                            cell.Value = "Global"
                        Else
                            cell.Value = ""
                        End If
                        Exit Select
                End Select
            End If
        End If
    End Sub

#End Region

#Region "BtnBlue_Click"

    ''' <summary>
    ''' Sets the ColorScheme to Blue
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BtnBlue_Click(ByVal sender As Object, ByVal e As EventArgs) Handles buttonItem1.Click
        StyleManager1.ManagerStyle = eStyle.Office2007Blue
        lblChange.ForeColor = Color.Black
        RibbonPredefinedColorSchemes.ChangeOffice2007ColorTable(eOffice2007ColorScheme.Blue)
    End Sub

#End Region

#Region "BtnBlack_Click"

    ''' <summary>
    ''' Sets the ColorScheme to Black
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BtnBlack_Click(ByVal sender As Object, ByVal e As EventArgs) Handles buttonItem2.Click
        StyleManager1.ManagerStyle = eStyle.Office2007Black
        lblChange.ForeColor = Color.White
        RibbonPredefinedColorSchemes.ChangeOffice2007ColorTable(eOffice2007ColorScheme.Black)
    End Sub

#End Region

#Region "BtnSilver_Click"

    ''' <summary>
    ''' Sets the ColorScheme to Silver
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BtnSilver_Click(ByVal sender As Object, ByVal e As EventArgs) Handles buttonItem3.Click
        StyleManager1.ManagerStyle = eStyle.Office2007Silver
        lblChange.ForeColor = Color.Black
        RibbonPredefinedColorSchemes.ChangeOffice2007ColorTable(eOffice2007ColorScheme.Silver)
    End Sub

#End Region

#Region "ColorPicker support"

#Region "ColorPickerDropDown1_ColorPreview"

    ''' <summary>
    ''' Preview
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ColorPickerDropDown1_ColorPreview(ByVal sender As Object, ByVal e As ColorPreviewEventArgs) Handles colorPickerDropDown1.ColorPreview
        RibbonPredefinedColorSchemes.ChangeOffice2007ColorTable(_MBaseColorScheme, e.Color)
    End Sub

#End Region

#Region "ColorPickerDropDown1_ExpandChange"

    ''' <summary>
    ''' ExpandChange
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ColorPickerDropDown1_ExpandChange(ByVal sender As Object, ByVal e As EventArgs) Handles colorPickerDropDown1.ExpandChange
        If colorPickerDropDown1.Expanded Then
            ' Remember the starting color scheme to apply
            ' if no color is selected during live-preview

            _MColorSelected = False
            _MBaseColorScheme = DirectCast(GlobalManager.Renderer, Office2007Renderer).ColorTable.InitialColorScheme
        Else
            If _MColorSelected = False Then
                RibbonPredefinedColorSchemes.ChangeOffice2007ColorTable(_MBaseColorScheme)
            End If
        End If
    End Sub

#End Region

#Region "ColorPickerDropDown1_SelectedColorChanged"

    Private Sub ColorPickerDropDown1_SelectedColorChanged(ByVal sender As Object, ByVal e As EventArgs) Handles colorPickerDropDown1.SelectedColorChanged
        ' Indicate that color was selected for buttonStyleCustom_ExpandChange method

        _MColorSelected = True

        RibbonPredefinedColorSchemes.ChangeOffice2007ColorTable(_MBaseColorScheme, colorPickerDropDown1.SelectedColor)
    End Sub

#End Region

#End Region

End Class
