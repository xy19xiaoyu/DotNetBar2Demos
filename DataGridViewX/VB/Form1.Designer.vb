<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits DevComponents.DotNetBar.Office2007Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.superTabControl1 = New DevComponents.DotNetBar.SuperTabControl
        Me.superTabControlPanel1 = New DevComponents.DotNetBar.SuperTabControlPanel
        Me.dataGridViewX1 = New DevComponents.DotNetBar.Controls.DataGridViewX
        Me.dataGridViewTextBoxColumn34 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CompanyNameC = New DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn
        Me.dataGridViewTextBoxColumn36 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Contact = New DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn
        Me.dataGridViewTextBoxColumn38 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.dataGridViewTextBoxColumn39 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.RegionC = New DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn
        Me.PostalCode = New DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn
        Me.Country = New DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn
        Me.dataGridViewTextBoxColumn43 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.dataGridViewTextBoxColumn44 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CustomersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomersDataSet = New DataGridViewX.CustomersDataSet
        Me.tab1 = New DevComponents.DotNetBar.SuperTabItem
        Me.superTabControlPanel2 = New DevComponents.DotNetBar.SuperTabControlPanel
        Me.itemPanel1 = New DevComponents.DotNetBar.ItemPanel
        Me.itemContainer1 = New DevComponents.DotNetBar.ItemContainer
        Me.cbNewParts = New DevComponents.DotNetBar.CheckBoxItem
        Me.cbRefurbishedParts = New DevComponents.DotNetBar.CheckBoxItem
        Me.dataGridViewX2 = New DevComponents.DotNetBar.Controls.DataGridViewX
        Me.ordersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tab2 = New DevComponents.DotNetBar.SuperTabItem
        Me.lblChange = New DevComponents.DotNetBar.LabelItem
        Me.buttonItem1 = New DevComponents.DotNetBar.ButtonItem
        Me.buttonItem2 = New DevComponents.DotNetBar.ButtonItem
        Me.buttonItem3 = New DevComponents.DotNetBar.ButtonItem
        Me.colorPickerDropDown1 = New DevComponents.DotNetBar.ColorPickerDropDown
        Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.CustomersTableAdapter = New DataGridViewX.CustomersDataSetTableAdapters.CustomersTableAdapter
        Me.StyleManager1 = New DevComponents.DotNetBar.StyleManager(Me.components)
        Me.CustomerIDC = New DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn
        Me.OrderC = New DevComponents.DotNetBar.Controls.DataGridViewMaskedTextBoxAdvColumn
        Me.DateC = New DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn
        Me.PartC = New DevComponents.DotNetBar.Controls.DataGridViewMaskedTextBoxAdvColumn
        Me.SpecC = New DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn
        Me.QuantityC = New DevComponents.DotNetBar.Controls.DataGridViewIntegerInputColumn
        Me.QualityC = New DevComponents.DotNetBar.Controls.DataGridViewSliderColumn
        Me.ProgressC = New DevComponents.DotNetBar.Controls.DataGridViewProgressBarXColumn
        Me.FeedbackC = New DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn
        CType(Me.superTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.superTabControl1.SuspendLayout()
        Me.superTabControlPanel1.SuspendLayout()
        CType(Me.dataGridViewX1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomersDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.superTabControlPanel2.SuspendLayout()
        CType(Me.dataGridViewX2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ordersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'superTabControl1
        '
        '
        '
        '
        '
        '
        '
        Me.superTabControl1.ControlBox.CloseBox.Name = ""
        '
        '
        '
        Me.superTabControl1.ControlBox.MenuBox.Name = ""
        Me.superTabControl1.ControlBox.Name = ""
        Me.superTabControl1.ControlBox.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.superTabControl1.ControlBox.MenuBox, Me.superTabControl1.ControlBox.CloseBox})
        Me.superTabControl1.Controls.Add(Me.superTabControlPanel2)
        Me.superTabControl1.Controls.Add(Me.superTabControlPanel1)
        Me.superTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.superTabControl1.Location = New System.Drawing.Point(0, 0)
        Me.superTabControl1.Name = "superTabControl1"
        Me.superTabControl1.ReorderTabsEnabled = True
        Me.superTabControl1.SelectedTabFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.superTabControl1.SelectedTabIndex = 0
        Me.superTabControl1.Size = New System.Drawing.Size(1038, 432)
        Me.superTabControl1.TabIndex = 3
        Me.superTabControl1.Tabs.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.tab1, Me.tab2, Me.lblChange, Me.buttonItem1, Me.buttonItem2, Me.buttonItem3, Me.colorPickerDropDown1})
        Me.superTabControl1.TabStyle = DevComponents.DotNetBar.eSuperTabStyle.Office2010BackstageBlue
        Me.superTabControl1.Text = "superTabControl1"
        '
        'superTabControlPanel1
        '
        Me.superTabControlPanel1.Controls.Add(Me.dataGridViewX1)
        Me.superTabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.superTabControlPanel1.Location = New System.Drawing.Point(0, 36)
        Me.superTabControlPanel1.Name = "superTabControlPanel1"
        Me.superTabControlPanel1.Size = New System.Drawing.Size(1038, 396)
        Me.superTabControlPanel1.TabIndex = 1
        Me.superTabControlPanel1.TabItem = Me.tab1
        '
        'dataGridViewX1
        '
        Me.dataGridViewX1.AutoGenerateColumns = False
        Me.dataGridViewX1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridViewX1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dataGridViewTextBoxColumn34, Me.CompanyNameC, Me.dataGridViewTextBoxColumn36, Me.Contact, Me.dataGridViewTextBoxColumn38, Me.dataGridViewTextBoxColumn39, Me.RegionC, Me.PostalCode, Me.Country, Me.dataGridViewTextBoxColumn43, Me.dataGridViewTextBoxColumn44})
        Me.dataGridViewX1.DataSource = Me.CustomersBindingSource
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dataGridViewX1.DefaultCellStyle = DataGridViewCellStyle3
        Me.dataGridViewX1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dataGridViewX1.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.dataGridViewX1.Location = New System.Drawing.Point(0, 0)
        Me.dataGridViewX1.Name = "dataGridViewX1"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.dataGridViewX1.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dataGridViewX1.RowTemplate.Height = 35
        Me.dataGridViewX1.Size = New System.Drawing.Size(1038, 396)
        Me.dataGridViewX1.TabIndex = 3
        '
        'dataGridViewTextBoxColumn34
        '
        Me.dataGridViewTextBoxColumn34.DataPropertyName = "CustomerID"
        Me.dataGridViewTextBoxColumn34.HeaderText = "CustomerID"
        Me.dataGridViewTextBoxColumn34.Name = "dataGridViewTextBoxColumn34"
        Me.dataGridViewTextBoxColumn34.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'CompanyNameC
        '
        Me.CompanyNameC.DataPropertyName = "CompanyName"
        Me.CompanyNameC.HeaderText = "Company Name"
        Me.CompanyNameC.Name = "CompanyNameC"
        Me.CompanyNameC.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.CompanyNameC.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.CompanyNameC.TextAlignment = System.Drawing.StringAlignment.Center
        Me.CompanyNameC.WordWrap = True
        '
        'dataGridViewTextBoxColumn36
        '
        Me.dataGridViewTextBoxColumn36.DataPropertyName = "ContactName"
        Me.dataGridViewTextBoxColumn36.HeaderText = "Contact Name"
        Me.dataGridViewTextBoxColumn36.Name = "dataGridViewTextBoxColumn36"
        '
        'Contact
        '
        Me.Contact.DataPropertyName = "ContactTitle"
        Me.Contact.HeaderText = "Contact Title"
        Me.Contact.Name = "Contact"
        Me.Contact.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Contact.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Contact.Text = Nothing
        '
        'dataGridViewTextBoxColumn38
        '
        Me.dataGridViewTextBoxColumn38.DataPropertyName = "Address"
        Me.dataGridViewTextBoxColumn38.HeaderText = "Address"
        Me.dataGridViewTextBoxColumn38.Name = "dataGridViewTextBoxColumn38"
        '
        'dataGridViewTextBoxColumn39
        '
        Me.dataGridViewTextBoxColumn39.DataPropertyName = "City"
        Me.dataGridViewTextBoxColumn39.HeaderText = "City"
        Me.dataGridViewTextBoxColumn39.Name = "dataGridViewTextBoxColumn39"
        '
        'RegionC
        '
        Me.RegionC.ColorTable = DevComponents.DotNetBar.eButtonColor.MagentaWithBackground
        Me.RegionC.DataPropertyName = "Region"
        Me.RegionC.HeaderText = "Region"
        Me.RegionC.Name = "RegionC"
        Me.RegionC.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.RegionC.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.RegionC.Text = Nothing
        '
        'PostalCode
        '
        Me.PostalCode.DataPropertyName = "PostalCode"
        Me.PostalCode.HeaderText = "Postal Code"
        Me.PostalCode.Name = "PostalCode"
        Me.PostalCode.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.PostalCode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.PostalCode.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'Country
        '
        Me.Country.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.Country.DataPropertyName = "Country"
        Me.Country.HeaderText = "Country"
        Me.Country.Name = "Country"
        Me.Country.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Country.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Country.Text = Nothing
        Me.Country.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left
        '
        'dataGridViewTextBoxColumn43
        '
        Me.dataGridViewTextBoxColumn43.DataPropertyName = "Phone"
        Me.dataGridViewTextBoxColumn43.HeaderText = "Phone"
        Me.dataGridViewTextBoxColumn43.Name = "dataGridViewTextBoxColumn43"
        '
        'dataGridViewTextBoxColumn44
        '
        Me.dataGridViewTextBoxColumn44.DataPropertyName = "Fax"
        Me.dataGridViewTextBoxColumn44.HeaderText = "Fax"
        Me.dataGridViewTextBoxColumn44.Name = "dataGridViewTextBoxColumn44"
        '
        'CustomersBindingSource
        '
        Me.CustomersBindingSource.DataMember = "Customers"
        Me.CustomersBindingSource.DataSource = Me.CustomersDataSet
        '
        'CustomersDataSet
        '
        Me.CustomersDataSet.DataSetName = "CustomersDataSet"
        Me.CustomersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'tab1
        '
        Me.tab1.AttachedControl = Me.superTabControlPanel1
        Me.tab1.GlobalItem = False
        Me.tab1.Image = CType(resources.GetObject("tab1.Image"), System.Drawing.Image)
        Me.tab1.Name = "tab1"
        Me.tab1.Text = "Customer Data"
        '
        'superTabControlPanel2
        '
        Me.superTabControlPanel2.Controls.Add(Me.itemPanel1)
        Me.superTabControlPanel2.Controls.Add(Me.dataGridViewX2)
        Me.superTabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.superTabControlPanel2.Location = New System.Drawing.Point(0, 36)
        Me.superTabControlPanel2.Name = "superTabControlPanel2"
        Me.superTabControlPanel2.Size = New System.Drawing.Size(1038, 396)
        Me.superTabControlPanel2.TabIndex = 0
        Me.superTabControlPanel2.TabItem = Me.tab2
        '
        'itemPanel1
        '
        '
        '
        '
        Me.itemPanel1.BackgroundStyle.Class = "ItemPanel"
        Me.itemPanel1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.itemPanel1.ContainerControlProcessDialogKey = True
        Me.itemPanel1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.itemContainer1})
        Me.itemPanel1.ItemSpacing = 20
        Me.itemPanel1.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical
        Me.itemPanel1.Location = New System.Drawing.Point(80, 100)
        Me.itemPanel1.Name = "itemPanel1"
        Me.itemPanel1.Size = New System.Drawing.Size(124, 46)
        Me.itemPanel1.TabIndex = 2
        Me.itemPanel1.Text = "itemPanel1"
        Me.itemPanel1.Visible = False
        '
        'itemContainer1
        '
        '
        '
        '
        Me.itemContainer1.BackgroundStyle.Class = ""
        Me.itemContainer1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.itemContainer1.ItemSpacing = 2
        Me.itemContainer1.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical
        Me.itemContainer1.Name = "itemContainer1"
        Me.itemContainer1.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.cbNewParts, Me.cbRefurbishedParts})
        '
        'cbNewParts
        '
        Me.cbNewParts.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton
        Me.cbNewParts.Checked = True
        Me.cbNewParts.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbNewParts.Name = "cbNewParts"
        Me.cbNewParts.Text = "New Part"
        '
        'cbRefurbishedParts
        '
        Me.cbRefurbishedParts.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton
        Me.cbRefurbishedParts.Name = "cbRefurbishedParts"
        Me.cbRefurbishedParts.Text = "Refurbished Part"
        '
        'dataGridViewX2
        '
        Me.dataGridViewX2.AutoGenerateColumns = False
        Me.dataGridViewX2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridViewX2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CustomerIDC, Me.OrderC, Me.DateC, Me.PartC, Me.SpecC, Me.QuantityC, Me.QualityC, Me.ProgressC, Me.FeedbackC})
        Me.dataGridViewX2.DataSource = Me.ordersBindingSource
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dataGridViewX2.DefaultCellStyle = DataGridViewCellStyle1
        Me.dataGridViewX2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dataGridViewX2.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.dataGridViewX2.Location = New System.Drawing.Point(0, 0)
        Me.dataGridViewX2.Name = "dataGridViewX2"
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        Me.dataGridViewX2.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dataGridViewX2.RowTemplate.Height = 24
        Me.dataGridViewX2.Size = New System.Drawing.Size(1038, 396)
        Me.dataGridViewX2.TabIndex = 1
        '
        'ordersBindingSource
        '
        Me.ordersBindingSource.DataMember = "Orders"
        Me.ordersBindingSource.DataSource = Me.CustomersDataSet
        '
        'tab2
        '
        Me.tab2.AttachedControl = Me.superTabControlPanel2
        Me.tab2.GlobalItem = False
        Me.tab2.Image = CType(resources.GetObject("tab2.Image"), System.Drawing.Image)
        Me.tab2.Name = "tab2"
        Me.tab2.TabFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab2.Text = "Order Data"
        '
        'lblChange
        '
        Me.lblChange.BeginGroup = True
        Me.lblChange.ForeColor = System.Drawing.Color.Black
        Me.lblChange.Name = "lblChange"
        Me.lblChange.Text = "Change Colors:"
        '
        'buttonItem1
        '
        Me.buttonItem1.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb
        Me.buttonItem1.ForeColor = System.Drawing.Color.White
        Me.buttonItem1.Name = "buttonItem1"
        Me.buttonItem1.Text = " Blue"
        '
        'buttonItem2
        '
        Me.buttonItem2.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb
        Me.buttonItem2.ForeColor = System.Drawing.Color.White
        Me.buttonItem2.Name = "buttonItem2"
        Me.buttonItem2.Text = " Black"
        '
        'buttonItem3
        '
        Me.buttonItem3.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb
        Me.buttonItem3.ForeColor = System.Drawing.Color.White
        Me.buttonItem3.Name = "buttonItem3"
        Me.buttonItem3.Text = " Silver"
        '
        'colorPickerDropDown1
        '
        Me.colorPickerDropDown1.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb
        Me.colorPickerDropDown1.ForeColor = System.Drawing.Color.White
        Me.colorPickerDropDown1.Name = "colorPickerDropDown1"
        Me.colorPickerDropDown1.Text = " Custom"
        '
        'imageList1
        '
        Me.imageList1.ImageStream = CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.imageList1.Images.SetKeyName(0, "Print")
        Me.imageList1.Images.SetKeyName(1, "User")
        Me.imageList1.Images.SetKeyName(2, "Canada")
        Me.imageList1.Images.SetKeyName(3, "France")
        Me.imageList1.Images.SetKeyName(4, "Sweden")
        Me.imageList1.Images.SetKeyName(5, "Spain")
        Me.imageList1.Images.SetKeyName(6, "Mexico")
        Me.imageList1.Images.SetKeyName(7, "Germany")
        Me.imageList1.Images.SetKeyName(8, "Ireland")
        Me.imageList1.Images.SetKeyName(9, "Switzerland")
        Me.imageList1.Images.SetKeyName(10, "UK")
        Me.imageList1.Images.SetKeyName(11, "USA")
        Me.imageList1.Images.SetKeyName(12, "Venezuela")
        Me.imageList1.Images.SetKeyName(13, "Argentina")
        Me.imageList1.Images.SetKeyName(14, "Brazil")
        Me.imageList1.Images.SetKeyName(15, "Austria")
        Me.imageList1.Images.SetKeyName(16, "Italy")
        Me.imageList1.Images.SetKeyName(17, "Portugal")
        Me.imageList1.Images.SetKeyName(18, "Denmark")
        Me.imageList1.Images.SetKeyName(19, "Belgium")
        Me.imageList1.Images.SetKeyName(20, "Finland")
        Me.imageList1.Images.SetKeyName(21, "Poland")
        Me.imageList1.Images.SetKeyName(22, "SecHigh")
        Me.imageList1.Images.SetKeyName(23, "SecMedium")
        Me.imageList1.Images.SetKeyName(24, "SecLow")
        '
        'CustomersTableAdapter
        '
        Me.CustomersTableAdapter.ClearBeforeFill = True
        '
        'StyleManager1
        '
        Me.StyleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2007Blue
        '
        'CustomerIDC
        '
        Me.CustomerIDC.DataPropertyName = "CustomerID"
        Me.CustomerIDC.DataSource = Me.CustomersBindingSource
        Me.CustomerIDC.DisplayMember = "CompanyName"
        Me.CustomerIDC.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CustomerIDC.DropDownHeight = 106
        Me.CustomerIDC.DropDownWidth = 121
        Me.CustomerIDC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CustomerIDC.HeaderText = "CustomerID"
        Me.CustomerIDC.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.CustomerIDC.IntegralHeight = False
        Me.CustomerIDC.ItemHeight = 15
        Me.CustomerIDC.MaxDropDownItems = 15
        Me.CustomerIDC.Name = "CustomerIDC"
        Me.CustomerIDC.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.CustomerIDC.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CustomerIDC.ValueMember = "CustomerID"
        Me.CustomerIDC.Width = 161
        '
        'OrderC
        '
        Me.OrderC.AllowPromptAsInput = False
        Me.OrderC.AsciiOnly = True
        Me.OrderC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.OrderC.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.OrderC.BackgroundStyle.Class = "TextBoxBorder"
        Me.OrderC.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.OrderC.BeepOnError = True
        Me.OrderC.ButtonClear.DisplayPosition = 9
        Me.OrderC.ButtonClear.Visible = True
        Me.OrderC.ButtonCustom.Visible = True
        Me.OrderC.Culture = New System.Globalization.CultureInfo("en-US")
        Me.OrderC.DataPropertyName = "Order"
        Me.OrderC.FocusHighlightEnabled = True
        Me.OrderC.ForeColor = System.Drawing.SystemColors.ControlText
        Me.OrderC.HeaderText = "Order"
        Me.OrderC.HidePromptOnLeave = True
        Me.OrderC.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.OrderC.Mask = "\#0000"
        Me.OrderC.Name = "OrderC"
        Me.OrderC.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.OrderC.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.OrderC.Text = "#"
        Me.OrderC.Width = 120
        '
        'DateC
        '
        Me.DateC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        '
        '
        '
        Me.DateC.BackgroundStyle.BackColor = System.Drawing.Color.White
        Me.DateC.BackgroundStyle.Class = "DataGridViewDateTimeBorder"
        Me.DateC.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.DateC.BackgroundStyle.TextColor = System.Drawing.SystemColors.ControlText
        Me.DateC.ButtonClear.DisplayPosition = 2
        Me.DateC.ButtonClear.Visible = True
        Me.DateC.ButtonCustom.DisplayPosition = 1
        Me.DateC.ButtonCustom.Image = CType(resources.GetObject("DateC.ButtonCustom.Image"), System.Drawing.Image)
        Me.DateC.ButtonCustom.Visible = True
        Me.DateC.ButtonDropDown.Visible = True
        Me.DateC.DataPropertyName = "Date"
        Me.DateC.Format = DevComponents.Editors.eDateTimePickerFormat.[Long]
        Me.DateC.HeaderText = "Date"
        Me.DateC.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Left
        '
        '
        '
        Me.DateC.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.DateC.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window
        Me.DateC.MonthCalendar.BackgroundStyle.Class = ""
        Me.DateC.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.DateC.MonthCalendar.CommandsBackgroundStyle.Class = ""
        Me.DateC.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.DateC.MonthCalendar.DisplayMonth = New Date(2010, 5, 1, 0, 0, 0, 0)
        Me.DateC.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.DateC.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.DateC.MonthCalendar.NavigationBackgroundStyle.Class = ""
        Me.DateC.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.DateC.MonthCalendar.WeeklyMarkedDays = New System.DayOfWeek(-1) {}
        Me.DateC.Name = "DateC"
        Me.DateC.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DateC.ShowUpDown = True
        Me.DateC.Width = 230
        '
        'PartC
        '
        Me.PartC.AllowPromptAsInput = False
        Me.PartC.AsciiOnly = True
        Me.PartC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.PartC.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.PartC.BackgroundStyle.Class = "TextBoxBorder"
        Me.PartC.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.PartC.BeepOnError = True
        Me.PartC.ButtonCustom.Image = CType(resources.GetObject("PartC.ButtonCustom.Image"), System.Drawing.Image)
        Me.PartC.ButtonCustom.Visible = True
        Me.PartC.ButtonDropDown.Visible = True
        Me.PartC.Culture = New System.Globalization.CultureInfo("en-US")
        Me.PartC.DataPropertyName = "Part"
        Me.PartC.DropDownControl = Me.itemPanel1
        Me.PartC.FocusHighlightEnabled = True
        Me.PartC.ForeColor = System.Drawing.SystemColors.ControlText
        Me.PartC.HeaderText = "Part"
        Me.PartC.HidePromptOnLeave = True
        Me.PartC.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PartC.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite
        Me.PartC.Mask = "00->LLL-0000-L"
        Me.PartC.Name = "PartC"
        Me.PartC.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.PartC.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.PartC.Text = "  -   -    -"
        Me.PartC.Width = 130
        '
        'SpecC
        '
        '
        '
        '
        Me.SpecC.BackgroundStyle.BackColor = System.Drawing.Color.White
        Me.SpecC.BackgroundStyle.Class = "DataGridViewNumericBorder"
        Me.SpecC.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.SpecC.BackgroundStyle.TextColor = System.Drawing.SystemColors.ControlText
        Me.SpecC.DataPropertyName = "Spec"
        Me.SpecC.FillWeight = 50.0!
        Me.SpecC.HeaderText = "Spec"
        Me.SpecC.Increment = 1
        Me.SpecC.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Left
        Me.SpecC.Name = "SpecC"
        Me.SpecC.ShowUpDown = True
        Me.SpecC.Width = 81
        '
        'QuantityC
        '
        '
        '
        '
        Me.QuantityC.BackgroundStyle.BackColor = System.Drawing.Color.White
        Me.QuantityC.BackgroundStyle.Class = "DataGridViewNumericBorder"
        Me.QuantityC.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.QuantityC.BackgroundStyle.TextColor = System.Drawing.SystemColors.ControlText
        Me.QuantityC.DataPropertyName = "Quantity"
        Me.QuantityC.DisplayFormat = "000"
        Me.QuantityC.FillWeight = 40.0!
        Me.QuantityC.HeaderText = "Quantity"
        Me.QuantityC.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Left
        Me.QuantityC.Name = "QuantityC"
        Me.QuantityC.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.QuantityC.ShowUpDown = True
        Me.QuantityC.Width = 64
        '
        'QualityC
        '
        Me.QualityC.DataPropertyName = "Quality"
        Me.QualityC.HeaderText = "Quality"
        Me.QualityC.LabelWidth = 30
        Me.QualityC.Name = "QualityC"
        Me.QualityC.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.QualityC.Value = 0
        Me.QualityC.Width = 161
        '
        'ProgressC
        '
        Me.ProgressC.DataPropertyName = "Progress"
        Me.ProgressC.HeaderText = "Progress"
        Me.ProgressC.Name = "ProgressC"
        Me.ProgressC.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ProgressC.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.ProgressC.Text = Nothing
        Me.ProgressC.TextVisible = True
        Me.ProgressC.Width = 161
        '
        'FeedbackC
        '
        Me.FeedbackC.Checked = False
        Me.FeedbackC.CheckState = System.Windows.Forms.CheckState.Unchecked
        Me.FeedbackC.CheckValue = "N"
        Me.FeedbackC.CheckValueChecked = "Y"
        Me.FeedbackC.CheckValueUnchecked = "N"
        Me.FeedbackC.DataPropertyName = "Feedback"
        Me.FeedbackC.HeaderText = "Feedback"
        Me.FeedbackC.Name = "FeedbackC"
        Me.FeedbackC.ThreeState = True
        Me.FeedbackC.Width = 161
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1038, 432)
        Me.Controls.Add(Me.superTabControl1)
        Me.DoubleBuffered = True
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DataGridViewX Demo Application"
        CType(Me.superTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.superTabControl1.ResumeLayout(False)
        Me.superTabControlPanel1.ResumeLayout(False)
        CType(Me.dataGridViewX1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomersDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.superTabControlPanel2.ResumeLayout(False)
        CType(Me.dataGridViewX2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ordersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents superTabControl1 As DevComponents.DotNetBar.SuperTabControl
    Private WithEvents superTabControlPanel1 As DevComponents.DotNetBar.SuperTabControlPanel
    Private WithEvents tab1 As DevComponents.DotNetBar.SuperTabItem
    Private WithEvents superTabControlPanel2 As DevComponents.DotNetBar.SuperTabControlPanel
    Private WithEvents tab2 As DevComponents.DotNetBar.SuperTabItem
    Private WithEvents lblChange As DevComponents.DotNetBar.LabelItem
    Private WithEvents buttonItem1 As DevComponents.DotNetBar.ButtonItem
    Private WithEvents buttonItem2 As DevComponents.DotNetBar.ButtonItem
    Private WithEvents buttonItem3 As DevComponents.DotNetBar.ButtonItem
    Private WithEvents colorPickerDropDown1 As DevComponents.DotNetBar.ColorPickerDropDown
    Private WithEvents dataGridViewX1 As DevComponents.DotNetBar.Controls.DataGridViewX
    Private WithEvents imageList1 As System.Windows.Forms.ImageList
    Private WithEvents CustomerID As DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn
    Private WithEvents Quantity As DevComponents.DotNetBar.Controls.DataGridViewIntegerInputColumn
    Private WithEvents Quality As DevComponents.DotNetBar.Controls.DataGridViewSliderColumn
    Private WithEvents Progress As DevComponents.DotNetBar.Controls.DataGridViewProgressBarXColumn
    Private WithEvents CustomersTableAdapter As DataGridViewX.CustomersDataSetTableAdapters.CustomersTableAdapter
    Private WithEvents CustomersBindingSource As System.Windows.Forms.BindingSource
    Private WithEvents CustomersDataSet As DataGridViewX.CustomersDataSet
    Friend WithEvents ordersBindingSource As System.Windows.Forms.BindingSource
    Private WithEvents dataGridViewX2 As DevComponents.DotNetBar.Controls.DataGridViewX
    Private WithEvents itemPanel1 As DevComponents.DotNetBar.ItemPanel
    Private WithEvents itemContainer1 As DevComponents.DotNetBar.ItemContainer
    Private WithEvents cbNewParts As DevComponents.DotNetBar.CheckBoxItem
    Private WithEvents cbRefurbishedParts As DevComponents.DotNetBar.CheckBoxItem
    Friend WithEvents StyleManager1 As DevComponents.DotNetBar.StyleManager
    Friend WithEvents dataGridViewTextBoxColumn34 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CompanyNameC As DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn
    Friend WithEvents dataGridViewTextBoxColumn36 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Contact As DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn
    Friend WithEvents dataGridViewTextBoxColumn38 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dataGridViewTextBoxColumn39 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RegionC As DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn
    Friend WithEvents PostalCode As DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn
    Friend WithEvents Country As DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn
    Friend WithEvents dataGridViewTextBoxColumn43 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dataGridViewTextBoxColumn44 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CustomerIDC As DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn
    Friend WithEvents OrderC As DevComponents.DotNetBar.Controls.DataGridViewMaskedTextBoxAdvColumn
    Friend WithEvents DateC As DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn
    Friend WithEvents PartC As DevComponents.DotNetBar.Controls.DataGridViewMaskedTextBoxAdvColumn
    Friend WithEvents SpecC As DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn
    Friend WithEvents QuantityC As DevComponents.DotNetBar.Controls.DataGridViewIntegerInputColumn
    Friend WithEvents QualityC As DevComponents.DotNetBar.Controls.DataGridViewSliderColumn
    Friend WithEvents ProgressC As DevComponents.DotNetBar.Controls.DataGridViewProgressBarXColumn
    Friend WithEvents FeedbackC As DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn

End Class
