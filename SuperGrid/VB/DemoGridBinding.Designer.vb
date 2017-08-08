Namespace SuperGridDemo
	Partial Public Class DemoGridBinding
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DemoGridBinding))
            Me.richTextBox1 = New System.Windows.Forms.RichTextBox
            Me.cboDataSource = New DevComponents.DotNetBar.Controls.ComboBoxEx
            Me.comboItem1 = New DevComponents.Editors.ComboItem
            Me.comboItem2 = New DevComponents.Editors.ComboItem
            Me.comboItem3 = New DevComponents.Editors.ComboItem
            Me.comboItem4 = New DevComponents.Editors.ComboItem
            Me.comboItem5 = New DevComponents.Editors.ComboItem
            Me.txbLastName = New DevComponents.DotNetBar.Controls.TextBoxX
            Me.txbFirstName = New DevComponents.DotNetBar.Controls.TextBoxX
            Me.superGridControl1 = New DevComponents.DotNetBar.SuperGrid.SuperGridControl
            Me.groupBox1 = New System.Windows.Forms.GroupBox
            Me.btnDetach = New DevComponents.DotNetBar.ButtonX
            Me.btnDeleteRow = New DevComponents.DotNetBar.ButtonX
            Me.btnPurge = New DevComponents.DotNetBar.ButtonX
            Me.txbHireDate = New DevComponents.DotNetBar.Controls.TextBoxX
            Me.labelX2 = New DevComponents.DotNetBar.LabelX
            Me.labelX3 = New DevComponents.DotNetBar.LabelX
            Me.labelX4 = New DevComponents.DotNetBar.LabelX
            Me.labelX5 = New DevComponents.DotNetBar.LabelX
            Me.labelX6 = New DevComponents.DotNetBar.LabelX
            Me.btnInsertRow = New DevComponents.DotNetBar.ButtonX
            Me.groupBox2 = New System.Windows.Forms.GroupBox
            Me.tbxEmployeeId = New DevComponents.DotNetBar.Controls.TextBoxX
            Me.tbxAge = New DevComponents.DotNetBar.Controls.TextBoxX
            Me.vcr1 = New SuperGridDemo.VcrControl
            Me.styleManager1 = New DevComponents.DotNetBar.StyleManager(Me.components)
            Me.groupBox1.SuspendLayout()
            Me.groupBox2.SuspendLayout()
            Me.SuspendLayout()
            '
            'richTextBox1
            '
            Me.richTextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.richTextBox1.BackColor = System.Drawing.SystemColors.Window
            Me.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.richTextBox1.Location = New System.Drawing.Point(4, 4)
            Me.richTextBox1.Name = "richTextBox1"
            Me.richTextBox1.ReadOnly = True
            Me.richTextBox1.Size = New System.Drawing.Size(787, 113)
            Me.richTextBox1.TabIndex = 0
            Me.richTextBox1.TabStop = False
            Me.richTextBox1.Text = ""
            '
            'cboDataSource
            '
            Me.cboDataSource.DisplayMember = "Text"
            Me.cboDataSource.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
            Me.cboDataSource.FormattingEnabled = True
            Me.cboDataSource.ItemHeight = 14
            Me.cboDataSource.Items.AddRange(New Object() {Me.comboItem1, Me.comboItem2, Me.comboItem3, Me.comboItem4, Me.comboItem5})
            Me.cboDataSource.Location = New System.Drawing.Point(22, 28)
            Me.cboDataSource.Name = "cboDataSource"
            Me.cboDataSource.Size = New System.Drawing.Size(121, 20)
            Me.cboDataSource.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.cboDataSource.TabIndex = 1
            '
            'comboItem1
            '
            Me.comboItem1.Text = "IList"
            '
            'comboItem2
            '
            Me.comboItem2.Text = "IListSource"
            '
            'comboItem3
            '
            Me.comboItem3.Text = "IBindingList"
            '
            'comboItem4
            '
            Me.comboItem4.Text = "DataSet"
            '
            'comboItem5
            '
            Me.comboItem5.Text = "None"
            '
            'txbLastName
            '
            Me.txbLastName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            '
            '
            '
            Me.txbLastName.Border.Class = "TextBoxBorder"
            Me.txbLastName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.txbLastName.Location = New System.Drawing.Point(43, 132)
            Me.txbLastName.Name = "txbLastName"
            Me.txbLastName.Size = New System.Drawing.Size(100, 20)
            Me.txbLastName.TabIndex = 4
            '
            'txbFirstName
            '
            Me.txbFirstName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            '
            '
            '
            Me.txbFirstName.Border.Class = "TextBoxBorder"
            Me.txbFirstName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.txbFirstName.Location = New System.Drawing.Point(43, 81)
            Me.txbFirstName.Name = "txbFirstName"
            Me.txbFirstName.Size = New System.Drawing.Size(100, 20)
            Me.txbFirstName.TabIndex = 3
            '
            'superGridControl1
            '
            Me.superGridControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.superGridControl1.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed
            Me.superGridControl1.Location = New System.Drawing.Point(4, 123)
            Me.superGridControl1.Name = "superGridControl1"
            Me.superGridControl1.PrimaryGrid.AllowRowDelete = True
            Me.superGridControl1.PrimaryGrid.AllowRowInsert = True
            Me.superGridControl1.PrimaryGrid.AutoHideDeletedRows = False
            Me.superGridControl1.PrimaryGrid.ColumnHeader.RowHeight = 30
            Me.superGridControl1.PrimaryGrid.FilterExpr = Nothing
            Me.superGridControl1.PrimaryGrid.NoRowsText = "Select a DataSource from the list to the right to populate the grid."
            Me.superGridControl1.PrimaryGrid.ShowRowGridIndex = True
            Me.superGridControl1.PrimaryGrid.Title.RowHeaderVisibility = DevComponents.DotNetBar.SuperGrid.RowHeaderVisibility.PanelControlled
            Me.superGridControl1.Size = New System.Drawing.Size(438, 395)
            Me.superGridControl1.TabIndex = 12
            Me.superGridControl1.Text = "superGridControl1"
            '
            'groupBox1
            '
            Me.groupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke
            Me.groupBox1.Controls.Add(Me.btnDetach)
            Me.groupBox1.Controls.Add(Me.cboDataSource)
            Me.groupBox1.Location = New System.Drawing.Point(453, 123)
            Me.groupBox1.Name = "groupBox1"
            Me.groupBox1.Size = New System.Drawing.Size(330, 71)
            Me.groupBox1.TabIndex = 19
            Me.groupBox1.TabStop = False
            Me.groupBox1.Text = "Data Source"
            '
            'btnDetach
            '
            Me.btnDetach.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
            Me.btnDetach.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
            Me.btnDetach.Location = New System.Drawing.Point(168, 28)
            Me.btnDetach.Name = "btnDetach"
            Me.btnDetach.Size = New System.Drawing.Size(136, 23)
            Me.btnDetach.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.btnDetach.TabIndex = 2
            Me.btnDetach.Text = "Detach Data From Source"
            '
            'btnDeleteRow
            '
            Me.btnDeleteRow.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
            Me.btnDeleteRow.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnDeleteRow.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
            Me.btnDeleteRow.Location = New System.Drawing.Point(630, 527)
            Me.btnDeleteRow.Name = "btnDeleteRow"
            Me.btnDeleteRow.Size = New System.Drawing.Size(109, 23)
            Me.btnDeleteRow.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.btnDeleteRow.TabIndex = 10
            Me.btnDeleteRow.Text = "Delete Current Row"
            '
            'btnPurge
            '
            Me.btnPurge.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
            Me.btnPurge.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.btnPurge.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
            Me.btnPurge.Location = New System.Drawing.Point(14, 530)
            Me.btnPurge.Name = "btnPurge"
            Me.btnPurge.Size = New System.Drawing.Size(208, 23)
            Me.btnPurge.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.btnPurge.TabIndex = 11
            Me.btnPurge.Text = "Purge Grid Deleted Rows"
            '
            'txbHireDate
            '
            Me.txbHireDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            '
            '
            '
            Me.txbHireDate.Border.Class = "TextBoxBorder"
            Me.txbHireDate.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.txbHireDate.Location = New System.Drawing.Point(179, 183)
            Me.txbHireDate.Name = "txbHireDate"
            Me.txbHireDate.Size = New System.Drawing.Size(141, 20)
            Me.txbHireDate.TabIndex = 7
            '
            'labelX2
            '
            Me.labelX2.AutoSize = True
            '
            '
            '
            Me.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.labelX2.Location = New System.Drawing.Point(24, 60)
            Me.labelX2.Name = "labelX2"
            Me.labelX2.Size = New System.Drawing.Size(56, 15)
            Me.labelX2.TabIndex = 23
            Me.labelX2.Text = "First Name"
            '
            'labelX3
            '
            Me.labelX3.AutoSize = True
            '
            '
            '
            Me.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.labelX3.Location = New System.Drawing.Point(24, 111)
            Me.labelX3.Name = "labelX3"
            Me.labelX3.Size = New System.Drawing.Size(56, 15)
            Me.labelX3.TabIndex = 24
            Me.labelX3.Text = "Last Name"
            '
            'labelX4
            '
            Me.labelX4.AutoSize = True
            '
            '
            '
            Me.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.labelX4.Location = New System.Drawing.Point(24, 162)
            Me.labelX4.Name = "labelX4"
            Me.labelX4.Size = New System.Drawing.Size(65, 15)
            Me.labelX4.TabIndex = 25
            Me.labelX4.Text = "Employee ID"
            '
            'labelX5
            '
            Me.labelX5.AutoSize = True
            '
            '
            '
            Me.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.labelX5.Location = New System.Drawing.Point(159, 111)
            Me.labelX5.Name = "labelX5"
            Me.labelX5.Size = New System.Drawing.Size(22, 15)
            Me.labelX5.TabIndex = 26
            Me.labelX5.Text = "Age"
            '
            'labelX6
            '
            Me.labelX6.AutoSize = True
            '
            '
            '
            Me.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.labelX6.Location = New System.Drawing.Point(159, 162)
            Me.labelX6.Name = "labelX6"
            Me.labelX6.Size = New System.Drawing.Size(49, 15)
            Me.labelX6.TabIndex = 27
            Me.labelX6.Text = "Hire Date"
            '
            'btnInsertRow
            '
            Me.btnInsertRow.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
            Me.btnInsertRow.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnInsertRow.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
            Me.btnInsertRow.Location = New System.Drawing.Point(495, 527)
            Me.btnInsertRow.Name = "btnInsertRow"
            Me.btnInsertRow.Size = New System.Drawing.Size(109, 23)
            Me.btnInsertRow.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.btnInsertRow.TabIndex = 9
            Me.btnInsertRow.Text = "Insert New Row"
            '
            'groupBox2
            '
            Me.groupBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.groupBox2.Controls.Add(Me.tbxEmployeeId)
            Me.groupBox2.Controls.Add(Me.tbxAge)
            Me.groupBox2.Controls.Add(Me.labelX6)
            Me.groupBox2.Controls.Add(Me.labelX5)
            Me.groupBox2.Controls.Add(Me.labelX4)
            Me.groupBox2.Controls.Add(Me.labelX3)
            Me.groupBox2.Controls.Add(Me.labelX2)
            Me.groupBox2.Controls.Add(Me.txbHireDate)
            Me.groupBox2.Controls.Add(Me.vcr1)
            Me.groupBox2.Controls.Add(Me.txbLastName)
            Me.groupBox2.Controls.Add(Me.txbFirstName)
            Me.groupBox2.Location = New System.Drawing.Point(451, 208)
            Me.groupBox2.Name = "groupBox2"
            Me.groupBox2.Size = New System.Drawing.Size(332, 310)
            Me.groupBox2.TabIndex = 28
            Me.groupBox2.TabStop = False
            Me.groupBox2.Text = "Row Data"
            '
            'tbxEmployeeId
            '
            '
            '
            '
            Me.tbxEmployeeId.Border.Class = "TextBoxBorder"
            Me.tbxEmployeeId.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.tbxEmployeeId.Location = New System.Drawing.Point(43, 183)
            Me.tbxEmployeeId.Name = "tbxEmployeeId"
            Me.tbxEmployeeId.Size = New System.Drawing.Size(100, 20)
            Me.tbxEmployeeId.TabIndex = 6
            '
            'tbxAge
            '
            '
            '
            '
            Me.tbxAge.Border.Class = "TextBoxBorder"
            Me.tbxAge.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.tbxAge.Location = New System.Drawing.Point(179, 132)
            Me.tbxAge.Name = "tbxAge"
            Me.tbxAge.Size = New System.Drawing.Size(100, 20)
            Me.tbxAge.TabIndex = 5
            '
            'vcr1
            '
            Me.vcr1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.vcr1.BackColor = System.Drawing.Color.LightGray
            Me.vcr1.Location = New System.Drawing.Point(39, 271)
            Me.vcr1.Name = "vcr1"
            Me.vcr1.Size = New System.Drawing.Size(267, 24)
            Me.vcr1.TabIndex = 8
            '
            'styleManager1
            '
            Me.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Windows7Blue
            Me.styleManager1.MetroColorParameters = New DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(26, Byte), Integer)))
            '
            'DemoGridBinding
            '
            Me.ClientSize = New System.Drawing.Size(791, 562)
            Me.Controls.Add(Me.groupBox2)
            Me.Controls.Add(Me.btnInsertRow)
            Me.Controls.Add(Me.btnPurge)
            Me.Controls.Add(Me.groupBox1)
            Me.Controls.Add(Me.btnDeleteRow)
            Me.Controls.Add(Me.richTextBox1)
            Me.Controls.Add(Me.superGridControl1)
            Me.DoubleBuffered = True
            Me.EnableGlass = False
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "DemoGridBinding"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "SuperGrid Demo - Data Binding"
            Me.groupBox1.ResumeLayout(False)
            Me.groupBox2.ResumeLayout(False)
            Me.groupBox2.PerformLayout()
            Me.ResumeLayout(False)

        End Sub

		#End Region

		Private superGridControl1 As DevComponents.DotNetBar.SuperGrid.SuperGridControl
		Private txbFirstName As DevComponents.DotNetBar.Controls.TextBoxX
		Private txbLastName As DevComponents.DotNetBar.Controls.TextBoxX
		Private richTextBox1 As RichTextBox
		Private WithEvents vcr1 As VcrControl
		Private WithEvents cboDataSource As DevComponents.DotNetBar.Controls.ComboBoxEx
		Private comboItem1 As DevComponents.Editors.ComboItem
		Private comboItem2 As DevComponents.Editors.ComboItem
		Private comboItem3 As DevComponents.Editors.ComboItem
		Private comboItem4 As DevComponents.Editors.ComboItem
		Private comboItem5 As DevComponents.Editors.ComboItem
		Private groupBox1 As GroupBox
		Private WithEvents btnPurge As DevComponents.DotNetBar.ButtonX
		Private WithEvents btnDetach As DevComponents.DotNetBar.ButtonX
		Private txbHireDate As DevComponents.DotNetBar.Controls.TextBoxX
		Private labelX2 As DevComponents.DotNetBar.LabelX
		Private labelX3 As DevComponents.DotNetBar.LabelX
		Private labelX4 As DevComponents.DotNetBar.LabelX
		Private labelX5 As DevComponents.DotNetBar.LabelX
		Private labelX6 As DevComponents.DotNetBar.LabelX
		Private WithEvents btnDeleteRow As DevComponents.DotNetBar.ButtonX
		Private WithEvents btnInsertRow As DevComponents.DotNetBar.ButtonX
		Private groupBox2 As GroupBox
		Private WithEvents tbxAge As DevComponents.DotNetBar.Controls.TextBoxX
        Private WithEvents tbxEmployeeId As DevComponents.DotNetBar.Controls.TextBoxX
        Private WithEvents styleManager1 As DevComponents.DotNetBar.StyleManager
	End Class
End Namespace

