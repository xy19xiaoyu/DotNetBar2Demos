namespace SuperGridDemo
{
    partial class DemoGridBinding
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
            this.richTextBox1 = new DevComponents.DotNetBar.Controls.RichTextBoxEx();
            this.cboDataSource = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem1 = new DevComponents.Editors.ComboItem();
            this.comboItem2 = new DevComponents.Editors.ComboItem();
            this.comboItem3 = new DevComponents.Editors.ComboItem();
            this.comboItem4 = new DevComponents.Editors.ComboItem();
            this.comboItem5 = new DevComponents.Editors.ComboItem();
            this.txbLastName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txbFirstName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.superGridControl1 = new DevComponents.DotNetBar.SuperGrid.SuperGridControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDetach = new DevComponents.DotNetBar.ButtonX();
            this.btnDeleteRow = new DevComponents.DotNetBar.ButtonX();
            this.btnPurge = new DevComponents.DotNetBar.ButtonX();
            this.txbHireDate = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.btnInsertRow = new DevComponents.DotNetBar.ButtonX();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbxEmployeeId = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbxAge = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.vcr1 = new SuperGridDemo.VcrControl();
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.richTextBox1.BackColorRichTextBox = System.Drawing.Color.White;
            // 
            // 
            // 
            this.richTextBox1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.richTextBox1.Location = new System.Drawing.Point(4, 4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(787, 113);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.TabStop = false;
            // 
            // cboDataSource
            // 
            this.cboDataSource.DisplayMember = "Text";
            this.cboDataSource.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboDataSource.FormattingEnabled = true;
            this.cboDataSource.ItemHeight = 14;
            this.cboDataSource.Items.AddRange(new object[] {
            this.comboItem1,
            this.comboItem2,
            this.comboItem3,
            this.comboItem4,
            this.comboItem5});
            this.cboDataSource.Location = new System.Drawing.Point(22, 28);
            this.cboDataSource.Name = "cboDataSource";
            this.cboDataSource.Size = new System.Drawing.Size(121, 20);
            this.cboDataSource.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboDataSource.TabIndex = 1;
            this.cboDataSource.SelectedIndexChanged += new System.EventHandler(this.CboDataSourceSelectedIndexChanged);
            // 
            // comboItem1
            // 
            this.comboItem1.Text = "IList";
            // 
            // comboItem2
            // 
            this.comboItem2.Text = "IListSource";
            // 
            // comboItem3
            // 
            this.comboItem3.Text = "IBindingList";
            // 
            // comboItem4
            // 
            this.comboItem4.Text = "DataSet";
            // 
            // comboItem5
            // 
            this.comboItem5.Text = "None";
            // 
            // txbLastName
            // 
            this.txbLastName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txbLastName.Border.Class = "TextBoxBorder";
            this.txbLastName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txbLastName.Location = new System.Drawing.Point(43, 132);
            this.txbLastName.Name = "txbLastName";
            this.txbLastName.Size = new System.Drawing.Size(100, 20);
            this.txbLastName.TabIndex = 4;
            // 
            // txbFirstName
            // 
            this.txbFirstName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txbFirstName.Border.Class = "TextBoxBorder";
            this.txbFirstName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txbFirstName.Location = new System.Drawing.Point(43, 81);
            this.txbFirstName.Name = "txbFirstName";
            this.txbFirstName.Size = new System.Drawing.Size(100, 20);
            this.txbFirstName.TabIndex = 3;
            // 
            // superGridControl1
            // 
            this.superGridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.superGridControl1.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed;
            this.superGridControl1.Location = new System.Drawing.Point(4, 123);
            this.superGridControl1.Name = "superGridControl1";
            this.superGridControl1.PrimaryGrid.AllowRowDelete = true;
            this.superGridControl1.PrimaryGrid.AllowRowInsert = true;
            this.superGridControl1.PrimaryGrid.AutoHideDeletedRows = false;
            this.superGridControl1.PrimaryGrid.ColumnHeader.RowHeight = 30;
            this.superGridControl1.PrimaryGrid.FilterExpr = null;
            this.superGridControl1.PrimaryGrid.NoRowsText = "Select a DataSource from the list to the right to populate the grid.";
            this.superGridControl1.PrimaryGrid.ShowRowGridIndex = true;
            this.superGridControl1.PrimaryGrid.Title.RowHeaderVisibility = DevComponents.DotNetBar.SuperGrid.RowHeaderVisibility.PanelControlled;
            this.superGridControl1.Size = new System.Drawing.Size(438, 395);
            this.superGridControl1.TabIndex = 12;
            this.superGridControl1.Text = "superGridControl1";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.btnDetach);
            this.groupBox1.Controls.Add(this.cboDataSource);
            this.groupBox1.Location = new System.Drawing.Point(453, 123);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(330, 71);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data Source";
            // 
            // btnDetach
            // 
            this.btnDetach.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDetach.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDetach.Location = new System.Drawing.Point(168, 28);
            this.btnDetach.Name = "btnDetach";
            this.btnDetach.Size = new System.Drawing.Size(136, 23);
            this.btnDetach.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnDetach.TabIndex = 2;
            this.btnDetach.Text = "Detach Data From Source";
            this.btnDetach.Click += new System.EventHandler(this.BtnDetachClick);
            // 
            // btnDeleteRow
            // 
            this.btnDeleteRow.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDeleteRow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteRow.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDeleteRow.Location = new System.Drawing.Point(630, 527);
            this.btnDeleteRow.Name = "btnDeleteRow";
            this.btnDeleteRow.Size = new System.Drawing.Size(109, 23);
            this.btnDeleteRow.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnDeleteRow.TabIndex = 10;
            this.btnDeleteRow.Text = "Delete Current Row";
            this.btnDeleteRow.Click += new System.EventHandler(this.BtnDeleteRowClick);
            // 
            // btnPurge
            // 
            this.btnPurge.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnPurge.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPurge.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnPurge.Location = new System.Drawing.Point(14, 530);
            this.btnPurge.Name = "btnPurge";
            this.btnPurge.Size = new System.Drawing.Size(208, 23);
            this.btnPurge.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnPurge.TabIndex = 11;
            this.btnPurge.Text = "Purge Grid Deleted Rows";
            this.btnPurge.Click += new System.EventHandler(this.BtnPurgeClick);
            // 
            // txbHireDate
            // 
            this.txbHireDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txbHireDate.Border.Class = "TextBoxBorder";
            this.txbHireDate.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txbHireDate.Location = new System.Drawing.Point(179, 183);
            this.txbHireDate.Name = "txbHireDate";
            this.txbHireDate.Size = new System.Drawing.Size(141, 20);
            this.txbHireDate.TabIndex = 7;
            // 
            // labelX2
            // 
            this.labelX2.AutoSize = true;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(24, 60);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(56, 15);
            this.labelX2.TabIndex = 23;
            this.labelX2.Text = "First Name";
            // 
            // labelX3
            // 
            this.labelX3.AutoSize = true;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(24, 111);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(56, 15);
            this.labelX3.TabIndex = 24;
            this.labelX3.Text = "Last Name";
            // 
            // labelX4
            // 
            this.labelX4.AutoSize = true;
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(24, 162);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(65, 15);
            this.labelX4.TabIndex = 25;
            this.labelX4.Text = "Employee ID";
            // 
            // labelX5
            // 
            this.labelX5.AutoSize = true;
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(159, 111);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(22, 15);
            this.labelX5.TabIndex = 26;
            this.labelX5.Text = "Age";
            // 
            // labelX6
            // 
            this.labelX6.AutoSize = true;
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Location = new System.Drawing.Point(159, 162);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(49, 15);
            this.labelX6.TabIndex = 27;
            this.labelX6.Text = "Hire Date";
            // 
            // btnInsertRow
            // 
            this.btnInsertRow.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnInsertRow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInsertRow.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnInsertRow.Location = new System.Drawing.Point(495, 527);
            this.btnInsertRow.Name = "btnInsertRow";
            this.btnInsertRow.Size = new System.Drawing.Size(109, 23);
            this.btnInsertRow.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnInsertRow.TabIndex = 9;
            this.btnInsertRow.Text = "Insert New Row";
            this.btnInsertRow.Click += new System.EventHandler(this.BtnInsertRowClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.tbxEmployeeId);
            this.groupBox2.Controls.Add(this.tbxAge);
            this.groupBox2.Controls.Add(this.labelX6);
            this.groupBox2.Controls.Add(this.labelX5);
            this.groupBox2.Controls.Add(this.labelX4);
            this.groupBox2.Controls.Add(this.labelX3);
            this.groupBox2.Controls.Add(this.labelX2);
            this.groupBox2.Controls.Add(this.txbHireDate);
            this.groupBox2.Controls.Add(this.vcr1);
            this.groupBox2.Controls.Add(this.txbLastName);
            this.groupBox2.Controls.Add(this.txbFirstName);
            this.groupBox2.Location = new System.Drawing.Point(451, 208);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(332, 310);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Row Data";
            // 
            // tbxEmployeeId
            // 
            // 
            // 
            // 
            this.tbxEmployeeId.Border.Class = "TextBoxBorder";
            this.tbxEmployeeId.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbxEmployeeId.Location = new System.Drawing.Point(43, 183);
            this.tbxEmployeeId.Name = "tbxEmployeeId";
            this.tbxEmployeeId.Size = new System.Drawing.Size(100, 20);
            this.tbxEmployeeId.TabIndex = 6;
            this.tbxEmployeeId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbxNumericKeyPress);
            // 
            // tbxAge
            // 
            // 
            // 
            // 
            this.tbxAge.Border.Class = "TextBoxBorder";
            this.tbxAge.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbxAge.Location = new System.Drawing.Point(179, 132);
            this.tbxAge.Name = "tbxAge";
            this.tbxAge.Size = new System.Drawing.Size(100, 20);
            this.tbxAge.TabIndex = 5;
            this.tbxAge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbxNumericKeyPress);
            // 
            // vcr1
            // 
            this.vcr1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.vcr1.BackColor = System.Drawing.Color.LightGray;
            this.vcr1.Location = new System.Drawing.Point(39, 271);
            this.vcr1.Name = "vcr1";
            this.vcr1.Size = new System.Drawing.Size(267, 24);
            this.vcr1.TabIndex = 8;
            this.vcr1.NextClick += new System.EventHandler<System.EventArgs>(this.VcrNextClick);
            this.vcr1.LastClick += new System.EventHandler<System.EventArgs>(this.VcrLastClick);
            this.vcr1.PreviousClick += new System.EventHandler<System.EventArgs>(this.VcrPreviousClick);
            this.vcr1.FirstClick += new System.EventHandler<System.EventArgs>(this.VcrFirstClick);
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Windows7Blue;
            this.styleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(163)))), ((int)(((byte)(26))))));
            // 
            // DemoGridBinding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 562);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnInsertRow);
            this.Controls.Add(this.btnPurge);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDeleteRow);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.superGridControl1);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Name = "DemoGridBinding";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SuperGrid Demo - Data Binding";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.SuperGrid.SuperGridControl superGridControl1;
        private DevComponents.DotNetBar.Controls.TextBoxX txbFirstName;
        private DevComponents.DotNetBar.Controls.TextBoxX txbLastName;
        private DevComponents.DotNetBar.Controls.RichTextBoxEx richTextBox1;
        private VcrControl vcr1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboDataSource;
        private DevComponents.Editors.ComboItem comboItem1;
        private DevComponents.Editors.ComboItem comboItem2;
        private DevComponents.Editors.ComboItem comboItem3;
        private DevComponents.Editors.ComboItem comboItem4;
        private DevComponents.Editors.ComboItem comboItem5;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevComponents.DotNetBar.ButtonX btnPurge;
        private DevComponents.DotNetBar.ButtonX btnDetach;
        private DevComponents.DotNetBar.Controls.TextBoxX txbHireDate;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.ButtonX btnDeleteRow;
        private DevComponents.DotNetBar.ButtonX btnInsertRow;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevComponents.DotNetBar.Controls.TextBoxX tbxAge;
        private DevComponents.DotNetBar.Controls.TextBoxX tbxEmployeeId;
        private DevComponents.DotNetBar.StyleManager styleManager1;
    }
}

