namespace DataGridViewX
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.superTabControl1 = new DevComponents.DotNetBar.SuperTabControl();
            this.superTabControlPanel1 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.dataGridViewX1 = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.dataGridViewTextBoxColumn34 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompanyName = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
            this.dataGridViewTextBoxColumn36 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contact = new DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn();
            this.dataGridViewTextBoxColumn38 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn39 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Region = new DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn();
            this.PostalCode = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
            this.Country = new DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn();
            this.dataGridViewTextBoxColumn43 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn44 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customersDataSet = new DataGridViewX.CustomersDataSet();
            this.tab1 = new DevComponents.DotNetBar.SuperTabItem();
            this.superTabControlPanel2 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.itemPanel1 = new DevComponents.DotNetBar.ItemPanel();
            this.itemContainer1 = new DevComponents.DotNetBar.ItemContainer();
            this.cbNewParts = new DevComponents.DotNetBar.CheckBoxItem();
            this.cbRefurbishedParts = new DevComponents.DotNetBar.CheckBoxItem();
            this.dataGridViewX2 = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tab2 = new DevComponents.DotNetBar.SuperTabItem();
            this.lblChange = new DevComponents.DotNetBar.LabelItem();
            this.buttonItem1 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem2 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem3 = new DevComponents.DotNetBar.ButtonItem();
            this.colorPickerDropDown1 = new DevComponents.DotNetBar.ColorPickerDropDown();
            this.tabCombo = new DevComponents.DotNetBar.SuperTabItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.customersTableAdapter = new DataGridViewX.CustomersDataSetTableAdapters.CustomersTableAdapter();
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.CustomerID = new DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn();
            this.Order = new DevComponents.DotNetBar.Controls.DataGridViewMaskedTextBoxAdvColumn();
            this.Date = new DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn();
            this.Part = new DevComponents.DotNetBar.Controls.DataGridViewMaskedTextBoxAdvColumn();
            this.Spec = new DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn();
            this.Quantity = new DevComponents.DotNetBar.Controls.DataGridViewIntegerInputColumn();
            this.Quality = new DevComponents.DotNetBar.Controls.DataGridViewSliderColumn();
            this.Progress = new DevComponents.DotNetBar.Controls.DataGridViewProgressBarXColumn();
            this.Feedback = new DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn();
            ((System.ComponentModel.ISupportInitialize)(this.superTabControl1)).BeginInit();
            this.superTabControl1.SuspendLayout();
            this.superTabControlPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersDataSet)).BeginInit();
            this.superTabControlPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // superTabControl1
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.superTabControl1.ControlBox.CloseBox.Name = "";
            // 
            // 
            // 
            this.superTabControl1.ControlBox.MenuBox.Name = "";
            this.superTabControl1.ControlBox.Name = "";
            this.superTabControl1.ControlBox.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.superTabControl1.ControlBox.MenuBox,
            this.superTabControl1.ControlBox.CloseBox});
            this.superTabControl1.Controls.Add(this.superTabControlPanel2);
            this.superTabControl1.Controls.Add(this.superTabControlPanel1);
            this.superTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControl1.HorizontalText = false;
            this.superTabControl1.Location = new System.Drawing.Point(0, 0);
            this.superTabControl1.Name = "superTabControl1";
            this.superTabControl1.ReorderTabsEnabled = true;
            this.superTabControl1.SelectedTabFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.superTabControl1.SelectedTabIndex = 0;
            this.superTabControl1.Size = new System.Drawing.Size(1038, 432);
            this.superTabControl1.TabIndex = 2;
            this.superTabControl1.Tabs.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.tab1,
            this.tab2,
            this.lblChange,
            this.buttonItem1,
            this.buttonItem2,
            this.buttonItem3,
            this.colorPickerDropDown1});
            this.superTabControl1.TabStyle = DevComponents.DotNetBar.eSuperTabStyle.Office2010BackstageBlue;
            this.superTabControl1.Text = "superTabControl1";
            // 
            // superTabControlPanel1
            // 
            this.superTabControlPanel1.Controls.Add(this.dataGridViewX1);
            this.superTabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanel1.Location = new System.Drawing.Point(0, 36);
            this.superTabControlPanel1.Name = "superTabControlPanel1";
            this.superTabControlPanel1.Size = new System.Drawing.Size(1038, 396);
            this.superTabControlPanel1.TabIndex = 1;
            this.superTabControlPanel1.TabItem = this.tab1;
            // 
            // dataGridViewX1
            // 
            this.dataGridViewX1.AutoGenerateColumns = false;
            this.dataGridViewX1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewX1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn34,
            this.CompanyName,
            this.dataGridViewTextBoxColumn36,
            this.Contact,
            this.dataGridViewTextBoxColumn38,
            this.dataGridViewTextBoxColumn39,
            this.Region,
            this.PostalCode,
            this.Country,
            this.dataGridViewTextBoxColumn43,
            this.dataGridViewTextBoxColumn44});
            this.dataGridViewX1.DataSource = this.customersBindingSource;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewX1.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewX1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewX1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataGridViewX1.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewX1.Name = "dataGridViewX1";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridViewX1.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewX1.RowTemplate.Height = 35;
            this.dataGridViewX1.Size = new System.Drawing.Size(1038, 396);
            this.dataGridViewX1.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn34
            // 
            this.dataGridViewTextBoxColumn34.DataPropertyName = "CustomerID";
            this.dataGridViewTextBoxColumn34.HeaderText = "CustomerID";
            this.dataGridViewTextBoxColumn34.Name = "dataGridViewTextBoxColumn34";
            this.dataGridViewTextBoxColumn34.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // CompanyName
            // 
            this.CompanyName.DataPropertyName = "CompanyName";
            this.CompanyName.DefaultCellStyle = dataGridViewCellStyle6;
            this.CompanyName.HeaderText = "Company Name";
            this.CompanyName.Name = "CompanyName";
            this.CompanyName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CompanyName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.CompanyName.WordWrap = true;
            // 
            // dataGridViewTextBoxColumn36
            // 
            this.dataGridViewTextBoxColumn36.DataPropertyName = "ContactName";
            this.dataGridViewTextBoxColumn36.HeaderText = "Contact Name";
            this.dataGridViewTextBoxColumn36.Name = "dataGridViewTextBoxColumn36";
            // 
            // Contact
            // 
            this.Contact.DataPropertyName = "ContactTitle";
            this.Contact.HeaderText = "Contact Title";
            this.Contact.Name = "Contact";
            this.Contact.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Contact.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Contact.Text = null;
            // 
            // dataGridViewTextBoxColumn38
            // 
            this.dataGridViewTextBoxColumn38.DataPropertyName = "Address";
            this.dataGridViewTextBoxColumn38.HeaderText = "Address";
            this.dataGridViewTextBoxColumn38.Name = "dataGridViewTextBoxColumn38";
            // 
            // dataGridViewTextBoxColumn39
            // 
            this.dataGridViewTextBoxColumn39.DataPropertyName = "City";
            this.dataGridViewTextBoxColumn39.HeaderText = "City";
            this.dataGridViewTextBoxColumn39.Name = "dataGridViewTextBoxColumn39";
            // 
            // Region
            // 
            this.Region.ColorTable = DevComponents.DotNetBar.eButtonColor.MagentaWithBackground;
            this.Region.DataPropertyName = "Region";
            this.Region.HeaderText = "Region";
            this.Region.Name = "Region";
            this.Region.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Region.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Region.Text = null;
            // 
            // PostalCode
            // 
            this.PostalCode.DataPropertyName = "PostalCode";
            this.PostalCode.HeaderText = "Postal Code";
            this.PostalCode.Name = "PostalCode";
            this.PostalCode.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.PostalCode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.PostalCode.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // Country
            // 
            this.Country.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.Country.DataPropertyName = "Country";
            this.Country.HeaderText = "Country";
            this.Country.Name = "Country";
            this.Country.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Country.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Country.Text = null;
            this.Country.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            // 
            // dataGridViewTextBoxColumn43
            // 
            this.dataGridViewTextBoxColumn43.DataPropertyName = "Phone";
            this.dataGridViewTextBoxColumn43.HeaderText = "Phone";
            this.dataGridViewTextBoxColumn43.Name = "dataGridViewTextBoxColumn43";
            // 
            // dataGridViewTextBoxColumn44
            // 
            this.dataGridViewTextBoxColumn44.DataPropertyName = "Fax";
            this.dataGridViewTextBoxColumn44.HeaderText = "Fax";
            this.dataGridViewTextBoxColumn44.Name = "dataGridViewTextBoxColumn44";
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "Customers";
            this.customersBindingSource.DataSource = this.customersDataSet;
            // 
            // customersDataSet
            // 
            this.customersDataSet.DataSetName = "CustomersDataSet";
            this.customersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tab1
            // 
            this.tab1.AttachedControl = this.superTabControlPanel1;
            this.tab1.GlobalItem = false;
            this.tab1.Image = ((System.Drawing.Image)(resources.GetObject("tab1.Image")));
            this.tab1.Name = "tab1";
            this.tab1.Text = "Customer Data";
            // 
            // superTabControlPanel2
            // 
            this.superTabControlPanel2.Controls.Add(this.itemPanel1);
            this.superTabControlPanel2.Controls.Add(this.dataGridViewX2);
            this.superTabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanel2.Location = new System.Drawing.Point(0, 36);
            this.superTabControlPanel2.Name = "superTabControlPanel2";
            this.superTabControlPanel2.Size = new System.Drawing.Size(1038, 396);
            this.superTabControlPanel2.TabIndex = 0;
            this.superTabControlPanel2.TabItem = this.tab2;
            // 
            // itemPanel1
            // 
            // 
            // 
            // 
            this.itemPanel1.BackgroundStyle.Class = "ItemPanel";
            this.itemPanel1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemPanel1.ContainerControlProcessDialogKey = true;
            this.itemPanel1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.itemContainer1});
            this.itemPanel1.ItemSpacing = 20;
            this.itemPanel1.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.itemPanel1.Location = new System.Drawing.Point(46, 87);
            this.itemPanel1.Name = "itemPanel1";
            this.itemPanel1.Size = new System.Drawing.Size(124, 46);
            this.itemPanel1.TabIndex = 1;
            this.itemPanel1.Text = "itemPanel1";
            this.itemPanel1.Visible = false;
            // 
            // itemContainer1
            // 
            // 
            // 
            // 
            this.itemContainer1.BackgroundStyle.Class = "";
            this.itemContainer1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer1.ItemSpacing = 2;
            this.itemContainer1.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.itemContainer1.Name = "itemContainer1";
            this.itemContainer1.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.cbNewParts,
            this.cbRefurbishedParts});
            // 
            // cbNewParts
            // 
            this.cbNewParts.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton;
            this.cbNewParts.Checked = true;
            this.cbNewParts.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbNewParts.Name = "cbNewParts";
            this.cbNewParts.Text = "New Part";
            this.cbNewParts.Click += new System.EventHandler(this.cbNewParts_Click);
            // 
            // cbRefurbishedParts
            // 
            this.cbRefurbishedParts.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton;
            this.cbRefurbishedParts.Name = "cbRefurbishedParts";
            this.cbRefurbishedParts.Text = "Refurbished Part";
            this.cbRefurbishedParts.Click += new System.EventHandler(this.cbRefurbishedParts_Click);
            // 
            // dataGridViewX2
            // 
            this.dataGridViewX2.AutoGenerateColumns = false;
            this.dataGridViewX2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewX2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CustomerID,
            this.Order,
            this.Date,
            this.Part,
            this.Spec,
            this.Quantity,
            this.Quality,
            this.Progress,
            this.Feedback});
            this.dataGridViewX2.DataSource = this.ordersBindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewX2.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewX2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewX2.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataGridViewX2.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewX2.Name = "dataGridViewX2";
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            this.dataGridViewX2.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewX2.RowTemplate.Height = 24;
            this.dataGridViewX2.Size = new System.Drawing.Size(1038, 396);
            this.dataGridViewX2.TabIndex = 0;
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "Orders";
            this.ordersBindingSource.DataSource = this.customersDataSet;
            // 
            // tab2
            // 
            this.tab2.AttachedControl = this.superTabControlPanel2;
            this.tab2.GlobalItem = false;
            this.tab2.Image = ((System.Drawing.Image)(resources.GetObject("tab2.Image")));
            this.tab2.Name = "tab2";
            this.tab2.TabFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab2.Text = "Order Data";
            // 
            // lblChange
            // 
            this.lblChange.BeginGroup = true;
            this.lblChange.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lblChange.Name = "lblChange";
            this.lblChange.Text = "Change Colors:";
            // 
            // buttonItem1
            // 
            this.buttonItem1.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.buttonItem1.ForeColor = System.Drawing.Color.White;
            this.buttonItem1.Name = "buttonItem1";
            this.buttonItem1.Text = " Blue";
            this.buttonItem1.Click += new System.EventHandler(this.BtnBlue_Click);
            // 
            // buttonItem2
            // 
            this.buttonItem2.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.buttonItem2.ForeColor = System.Drawing.Color.White;
            this.buttonItem2.Name = "buttonItem2";
            this.buttonItem2.Text = " Black";
            this.buttonItem2.Click += new System.EventHandler(this.BtnBlack_Click);
            // 
            // buttonItem3
            // 
            this.buttonItem3.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.buttonItem3.ForeColor = System.Drawing.Color.White;
            this.buttonItem3.Name = "buttonItem3";
            this.buttonItem3.Text = " Silver";
            this.buttonItem3.Click += new System.EventHandler(this.BtnSilver_Click);
            // 
            // colorPickerDropDown1
            // 
            this.colorPickerDropDown1.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.colorPickerDropDown1.ForeColor = System.Drawing.Color.White;
            this.colorPickerDropDown1.Name = "colorPickerDropDown1";
            this.colorPickerDropDown1.Text = " Custom";
            this.colorPickerDropDown1.ColorPreview += new DevComponents.DotNetBar.ColorPreviewEventHandler(this.ColorPickerDropDown1_ColorPreview);
            this.colorPickerDropDown1.SelectedColorChanged += new System.EventHandler(this.ColorPickerDropDown1_SelectedColorChanged);
            this.colorPickerDropDown1.ExpandChange += new System.EventHandler(this.ColorPickerDropDown1_ExpandChange);
            // 
            // tabCombo
            // 
            this.tabCombo.GlobalItem = false;
            this.tabCombo.Name = "tabCombo";
            this.tabCombo.Text = "CheckBoxX\r\nComboBoxEx";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Print");
            this.imageList1.Images.SetKeyName(1, "User");
            this.imageList1.Images.SetKeyName(2, "Canada");
            this.imageList1.Images.SetKeyName(3, "France");
            this.imageList1.Images.SetKeyName(4, "Sweden");
            this.imageList1.Images.SetKeyName(5, "Spain");
            this.imageList1.Images.SetKeyName(6, "Mexico");
            this.imageList1.Images.SetKeyName(7, "Germany");
            this.imageList1.Images.SetKeyName(8, "Ireland");
            this.imageList1.Images.SetKeyName(9, "Switzerland");
            this.imageList1.Images.SetKeyName(10, "UK");
            this.imageList1.Images.SetKeyName(11, "USA");
            this.imageList1.Images.SetKeyName(12, "Venezuela");
            this.imageList1.Images.SetKeyName(13, "Argentina");
            this.imageList1.Images.SetKeyName(14, "Brazil");
            this.imageList1.Images.SetKeyName(15, "Austria");
            this.imageList1.Images.SetKeyName(16, "Italy");
            this.imageList1.Images.SetKeyName(17, "Portugal");
            this.imageList1.Images.SetKeyName(18, "Denmark");
            this.imageList1.Images.SetKeyName(19, "Belgium");
            this.imageList1.Images.SetKeyName(20, "Finland");
            this.imageList1.Images.SetKeyName(21, "Poland");
            this.imageList1.Images.SetKeyName(22, "SecHigh");
            this.imageList1.Images.SetKeyName(23, "SecMedium");
            this.imageList1.Images.SetKeyName(24, "SecLow");
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2007Blue;
            // 
            // CustomerID
            // 
            this.CustomerID.DataPropertyName = "CustomerID";
            this.CustomerID.DataSource = this.customersBindingSource;
            this.CustomerID.DisplayMember = "CompanyName";
            this.CustomerID.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CustomerID.DropDownHeight = 106;
            this.CustomerID.DropDownWidth = 121;
            this.CustomerID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CustomerID.HeaderText = "CustomerID";
            this.CustomerID.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CustomerID.IntegralHeight = false;
            this.CustomerID.ItemHeight = 15;
            this.CustomerID.MaxDropDownItems = 15;
            this.CustomerID.Name = "CustomerID";
            this.CustomerID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CustomerID.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CustomerID.ValueMember = "CustomerID";
            this.CustomerID.Width = 161;
            // 
            // Order
            // 
            this.Order.AllowPromptAsInput = false;
            this.Order.AsciiOnly = true;
            this.Order.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Order.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.Order.BackgroundStyle.Class = "TextBoxBorder";
            this.Order.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.Order.BeepOnError = true;
            this.Order.ButtonClear.DisplayPosition = 9;
            this.Order.ButtonClear.Visible = true;
            this.Order.ButtonCustom.Visible = true;
            this.Order.Culture = new System.Globalization.CultureInfo("en-US");
            this.Order.DataPropertyName = "Order";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Order.DefaultCellStyle = dataGridViewCellStyle1;
            this.Order.FocusHighlightEnabled = true;
            this.Order.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Order.HeaderText = "Order";
            this.Order.HidePromptOnLeave = true;
            this.Order.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Order.Mask = "\\#0000";
            this.Order.Name = "Order";
            this.Order.PasswordChar = '\0';
            this.Order.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Order.Text = "#";
            this.Order.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Order.Width = 120;
            // 
            // Date
            // 
            this.Date.AutoAdvance = true;
            this.Date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            // 
            // 
            // 
            this.Date.BackgroundStyle.BackColor = System.Drawing.Color.White;
            this.Date.BackgroundStyle.Class = "DataGridViewDateTimeBorder";
            this.Date.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.Date.BackgroundStyle.TextColor = System.Drawing.SystemColors.ControlText;
            this.Date.ButtonClear.DisplayPosition = 2;
            this.Date.ButtonClear.Visible = true;
            this.Date.ButtonCustom.DisplayPosition = 1;
            this.Date.ButtonCustom.Image = ((System.Drawing.Image)(resources.GetObject("Date.ButtonCustom.Image")));
            this.Date.ButtonCustom.Visible = true;
            this.Date.ButtonDropDown.Visible = true;
            this.Date.DataPropertyName = "Date";
            this.Date.Format = DevComponents.Editors.eDateTimePickerFormat.Long;
            this.Date.HeaderText = "Date";
            this.Date.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Left;
            // 
            // 
            // 
            this.Date.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.Date.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.Date.MonthCalendar.BackgroundStyle.Class = "";
            this.Date.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.Date.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.Date.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.Date.MonthCalendar.DisplayMonth = new System.DateTime(2010, 5, 1, 0, 0, 0, 0);
            this.Date.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.Date.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.Date.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.Date.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.Date.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.Date.Name = "Date";
            this.Date.ShowUpDown = true;
            this.Date.Width = 230;
            // 
            // Part
            // 
            this.Part.AllowPromptAsInput = false;
            this.Part.AsciiOnly = true;
            this.Part.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Part.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.Part.BackgroundStyle.Class = "TextBoxBorder";
            this.Part.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.Part.BeepOnError = true;
            this.Part.ButtonCustom.Image = ((System.Drawing.Image)(resources.GetObject("Part.ButtonCustom.Image")));
            this.Part.ButtonCustom.Visible = true;
            this.Part.ButtonDropDown.Visible = true;
            this.Part.Culture = new System.Globalization.CultureInfo("en-US");
            this.Part.DataPropertyName = "Part";
            this.Part.DropDownControl = this.itemPanel1;
            this.Part.FocusHighlightEnabled = true;
            this.Part.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Part.HeaderText = "Part";
            this.Part.HidePromptOnLeave = true;
            this.Part.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Part.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite;
            this.Part.Mask = "00->LLL-0000-L";
            this.Part.Name = "Part";
            this.Part.PasswordChar = '\0';
            this.Part.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Part.Text = "  -   -    -";
            this.Part.Width = 130;
            // 
            // Spec
            // 
            // 
            // 
            // 
            this.Spec.BackgroundStyle.BackColor = System.Drawing.Color.White;
            this.Spec.BackgroundStyle.Class = "DataGridViewNumericBorder";
            this.Spec.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.Spec.BackgroundStyle.TextColor = System.Drawing.SystemColors.ControlText;
            this.Spec.DataPropertyName = "Spec";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Spec.DefaultCellStyle = dataGridViewCellStyle2;
            this.Spec.FillWeight = 50F;
            this.Spec.HeaderText = "Spec";
            this.Spec.Increment = 1;
            this.Spec.Name = "Spec";
            this.Spec.ShowUpDown = true;
            this.Spec.Width = 81;
            // 
            // Quantity
            // 
            // 
            // 
            // 
            this.Quantity.BackgroundStyle.BackColor = System.Drawing.Color.White;
            this.Quantity.BackgroundStyle.Class = "DataGridViewNumericBorder";
            this.Quantity.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.Quantity.BackgroundStyle.TextColor = System.Drawing.SystemColors.ControlText;
            this.Quantity.DataPropertyName = "Quantity";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Quantity.DefaultCellStyle = dataGridViewCellStyle3;
            this.Quantity.DisplayFormat = "000";
            this.Quantity.FillWeight = 40F;
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Quantity.ShowUpDown = true;
            this.Quantity.Width = 64;
            // 
            // Quality
            // 
            this.Quality.DataPropertyName = "Quality";
            this.Quality.HeaderText = "Quality";
            this.Quality.LabelWidth = 30;
            this.Quality.Name = "Quality";
            this.Quality.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Quality.Value = 0;
            this.Quality.Width = 161;
            // 
            // Progress
            // 
            this.Progress.DataPropertyName = "Progress";
            this.Progress.HeaderText = "Progress";
            this.Progress.Name = "Progress";
            this.Progress.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Progress.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Progress.Text = null;
            this.Progress.TextVisible = true;
            this.Progress.Width = 161;
            // 
            // Feedback
            // 
            this.Feedback.Checked = false;
            this.Feedback.CheckState = System.Windows.Forms.CheckState.Unchecked;
            this.Feedback.CheckValue = "N";
            this.Feedback.CheckValueChecked = "Y";
            this.Feedback.CheckValueUnchecked = "N";
            this.Feedback.DataPropertyName = "Feedback";
            this.Feedback.HeaderText = "Feedback";
            this.Feedback.Name = "Feedback";
            this.Feedback.ThreeState = true;
            this.Feedback.Width = 161;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 432);
            this.Controls.Add(this.superTabControl1);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DataGridViewX Demo Application";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.superTabControl1)).EndInit();
            this.superTabControl1.ResumeLayout(false);
            this.superTabControlPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersDataSet)).EndInit();
            this.superTabControlPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomersDataSet customersDataSet;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private DataGridViewX.CustomersDataSetTableAdapters.CustomersTableAdapter customersTableAdapter;
        private DevComponents.DotNetBar.SuperTabControl superTabControl1;
        private DevComponents.DotNetBar.SuperTabItem tabCombo;
        private DevComponents.DotNetBar.SuperTabControlPanel superTabControlPanel2;
        private DevComponents.DotNetBar.SuperTabItem tab2;
        private DevComponents.DotNetBar.SuperTabControlPanel superTabControlPanel1;
        private DevComponents.DotNetBar.SuperTabItem tab1;
        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridViewX1;
        private System.Windows.Forms.ImageList imageList1;
        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridViewX2;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn partIDDataGridViewTextBoxColumn;
        private DevComponents.DotNetBar.ItemPanel itemPanel1;
        private DevComponents.DotNetBar.CheckBoxItem cbNewParts;
        private DevComponents.DotNetBar.CheckBoxItem cbRefurbishedParts;
        private DevComponents.DotNetBar.ItemContainer itemContainer1;
        private DevComponents.DotNetBar.ButtonItem buttonItem1;
        private DevComponents.DotNetBar.ButtonItem buttonItem2;
        private DevComponents.DotNetBar.ButtonItem buttonItem3;
        private DevComponents.DotNetBar.ColorPickerDropDown colorPickerDropDown1;
        private DevComponents.DotNetBar.LabelItem lblChange;
        private DevComponents.DotNetBar.StyleManager styleManager1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn34;
        private DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn CompanyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn36;
        private DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn Contact;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn38;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn39;
        private DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn Region;
        private DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn PostalCode;
        private DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn Country;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn43;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn44;
        private DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn CustomerID;
        private DevComponents.DotNetBar.Controls.DataGridViewMaskedTextBoxAdvColumn Order;
        private DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn Date;
        private DevComponents.DotNetBar.Controls.DataGridViewMaskedTextBoxAdvColumn Part;
        private DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn Spec;
        private DevComponents.DotNetBar.Controls.DataGridViewIntegerInputColumn Quantity;
        private DevComponents.DotNetBar.Controls.DataGridViewSliderColumn Quality;
        private DevComponents.DotNetBar.Controls.DataGridViewProgressBarXColumn Progress;
        private DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn Feedback;
    }
}

