Namespace MetroBill
	Partial Public Class MainForm
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
			Me.components = New System.ComponentModel.Container()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
			Me.metroStatusBar1 = New DevComponents.DotNetBar.Metro.MetroStatusBar()
			Me.labelItem1 = New DevComponents.DotNetBar.LabelItem()
			Me.metroShell1 = New DevComponents.DotNetBar.Metro.MetroShell()
			Me.metroTabPanel2 = New DevComponents.DotNetBar.Metro.MetroTabPanel()
			Me.metroToolbar2 = New DevComponents.DotNetBar.Metro.MetroToolbar()
			Me.buttonItem9 = New DevComponents.DotNetBar.ButtonItem()
			Me.newClientButton = New DevComponents.DotNetBar.ButtonItem()
			Me.clientReportButton = New DevComponents.DotNetBar.ButtonItem()
			Me.advTree2 = New DevComponents.AdvTree.AdvTree()
			Me.columnHeader4 = New DevComponents.AdvTree.ColumnHeader()
			Me.columnHeader5 = New DevComponents.AdvTree.ColumnHeader()
			Me.columnHeader6 = New DevComponents.AdvTree.ColumnHeader()
			Me.nodeConnector2 = New DevComponents.AdvTree.NodeConnector()
			Me.elementStyle2 = New DevComponents.DotNetBar.ElementStyle()
			Me.metroTabPanel1 = New DevComponents.DotNetBar.Metro.MetroTabPanel()
			Me.metroToolbar1 = New DevComponents.DotNetBar.Metro.MetroToolbar()
			Me.voidInvoiceButton = New DevComponents.DotNetBar.ButtonItem()
			Me.addNoteButton = New DevComponents.DotNetBar.ButtonItem()
			Me.buttonItem7 = New DevComponents.DotNetBar.ButtonItem()
			Me.newInvoiceButton = New DevComponents.DotNetBar.ButtonItem()
			Me.markAsPaidButton = New DevComponents.DotNetBar.ButtonItem()
			Me.buttonItem8 = New DevComponents.DotNetBar.ButtonItem()
			Me.richTextBox1 = New RichTextBox()
			Me.expandableSplitter1 = New DevComponents.DotNetBar.ExpandableSplitter()
			Me.advTree1 = New DevComponents.AdvTree.AdvTree()
			Me.columnHeader1 = New DevComponents.AdvTree.ColumnHeader()
			Me.columnHeader2 = New DevComponents.AdvTree.ColumnHeader()
			Me.columnHeader3 = New DevComponents.AdvTree.ColumnHeader()
			Me.nodeConnector1 = New DevComponents.AdvTree.NodeConnector()
			Me.elementStyle1 = New DevComponents.DotNetBar.ElementStyle()
			Me.metroAppButton1 = New DevComponents.DotNetBar.Metro.MetroAppButton()
			Me.superTabControl1 = New DevComponents.DotNetBar.SuperTabControl()
			Me.superTabControlPanel1 = New DevComponents.DotNetBar.SuperTabControlPanel()
			Me.superTabItem1 = New DevComponents.DotNetBar.SuperTabItem()
			Me.superTabControlPanel3 = New DevComponents.DotNetBar.SuperTabControlPanel()
			Me.superTabItem3 = New DevComponents.DotNetBar.SuperTabItem()
			Me.superTabControlPanel4 = New DevComponents.DotNetBar.SuperTabControlPanel()
			Me.superTabItem4 = New DevComponents.DotNetBar.SuperTabItem()
			Me.superTabControlPanel2 = New DevComponents.DotNetBar.SuperTabControlPanel()
			Me.superTabItem2 = New DevComponents.DotNetBar.SuperTabItem()
			Me.buttonItem2 = New DevComponents.DotNetBar.ButtonItem()
			Me.buttonItem3 = New DevComponents.DotNetBar.ButtonItem()
			Me.buttonItem4 = New DevComponents.DotNetBar.ButtonItem()
			Me.buttonItem5 = New DevComponents.DotNetBar.ButtonItem()
			Me.buttonItem6 = New DevComponents.DotNetBar.ButtonItem()
			Me.metroTabItem1 = New DevComponents.DotNetBar.Metro.MetroTabItem()
			Me.metroTabItem2 = New DevComponents.DotNetBar.Metro.MetroTabItem()
			Me.colorThemeButton = New DevComponents.DotNetBar.ButtonItem()
			Me.qatCustomizeItem1 = New DevComponents.DotNetBar.QatCustomizeItem()
			Me.styleManager1 = New DevComponents.DotNetBar.StyleManager(Me.components)
			Me.metroShell1.SuspendLayout()
			Me.metroTabPanel2.SuspendLayout()
			CType(Me.advTree2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.metroTabPanel1.SuspendLayout()
			CType(Me.advTree1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.superTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.superTabControl1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' metroStatusBar1
			' 
			Me.metroStatusBar1.BackColor = Color.White
			' 
			' 
			' 
			Me.metroStatusBar1.BackgroundStyle.Class = ""
			Me.metroStatusBar1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
			Me.metroStatusBar1.ContainerControlProcessDialogKey = True
			Me.metroStatusBar1.Dock = DockStyle.Bottom
			Me.metroStatusBar1.Font = New Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, (CByte(0)))
			Me.metroStatusBar1.ForeColor = Color.Black
			Me.metroStatusBar1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() { Me.labelItem1})
			Me.metroStatusBar1.Location = New Point(0, 518)
			Me.metroStatusBar1.Name = "metroStatusBar1"
			Me.metroStatusBar1.Size = New Size(852, 22)
			Me.metroStatusBar1.TabIndex = 0
			Me.metroStatusBar1.Text = "metroStatusBar1"
			' 
			' labelItem1
			' 
			Me.labelItem1.Name = "labelItem1"
			Me.labelItem1.Text = "READY"
			' 
			' metroShell1
			' 
			Me.metroShell1.BackColor = Color.White
			' 
			' 
			' 
			Me.metroShell1.BackgroundStyle.Class = ""
			Me.metroShell1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
			Me.metroShell1.CaptionVisible = True
			Me.metroShell1.Controls.Add(Me.metroTabPanel1)
			Me.metroShell1.Controls.Add(Me.metroTabPanel2)
			Me.metroShell1.Dock = DockStyle.Fill
			Me.metroShell1.ForeColor = Color.Black
			Me.metroShell1.HelpButtonText = Nothing
			Me.metroShell1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() { Me.metroAppButton1, Me.metroTabItem1, Me.metroTabItem2})
			Me.metroShell1.KeyTipsFont = New Font("Tahoma", 7F)
			Me.metroShell1.Location = New Point(0, 1)
			Me.metroShell1.Name = "metroShell1"
			Me.metroShell1.QuickToolbarItems.AddRange(New DevComponents.DotNetBar.BaseItem() { Me.colorThemeButton, Me.qatCustomizeItem1})
			Me.metroShell1.Size = New Size(852, 517)
			Me.metroShell1.SystemText.MaximizeRibbonText = "&Maximize the Ribbon"
			Me.metroShell1.SystemText.MinimizeRibbonText = "Mi&nimize the Ribbon"
			Me.metroShell1.SystemText.QatAddItemText = "&Add to Quick Access Toolbar"
			Me.metroShell1.SystemText.QatCustomizeMenuLabel = "<b>Customize Quick Access Toolbar</b>"
			Me.metroShell1.SystemText.QatCustomizeText = "&Customize Quick Access Toolbar..."
			Me.metroShell1.SystemText.QatDialogAddButton = "&Add >>"
			Me.metroShell1.SystemText.QatDialogCancelButton = "Cancel"
			Me.metroShell1.SystemText.QatDialogCaption = "Customize Quick Access Toolbar"
			Me.metroShell1.SystemText.QatDialogCategoriesLabel = "&Choose commands from:"
			Me.metroShell1.SystemText.QatDialogOkButton = "OK"
			Me.metroShell1.SystemText.QatDialogPlacementCheckbox = "&Place Quick Access Toolbar below the Ribbon"
			Me.metroShell1.SystemText.QatDialogRemoveButton = "&Remove"
			Me.metroShell1.SystemText.QatPlaceAboveRibbonText = "&Place Quick Access Toolbar above the Ribbon"
			Me.metroShell1.SystemText.QatPlaceBelowRibbonText = "&Place Quick Access Toolbar below the Ribbon"
			Me.metroShell1.SystemText.QatRemoveItemText = "&Remove from Quick Access Toolbar"
			Me.metroShell1.TabIndex = 1
			Me.metroShell1.TabStripFont = New Font("Segoe UI", 10.25F, FontStyle.Bold, GraphicsUnit.Point, (CByte(0)))
			Me.metroShell1.Text = "metroShell1"
'			Me.metroShell1.SelectedTabChanged += New System.EventHandler(Me.metroShell1_SelectedTabChanged)
'			Me.metroShell1.SettingsButtonClick += New System.EventHandler(Me.metroShell1_SettingsButtonClick)
'			Me.metroShell1.HelpButtonClick += New System.EventHandler(Me.metroShell1_HelpButtonClick)
			' 
			' metroTabPanel2
			' 
			Me.metroTabPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
			Me.metroTabPanel2.Controls.Add(Me.metroToolbar2)
			Me.metroTabPanel2.Controls.Add(Me.advTree2)
			Me.metroTabPanel2.Dock = DockStyle.Fill
			Me.metroTabPanel2.Font = New Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, (CByte(0)))
			Me.metroTabPanel2.Location = New Point(0, 51)
			Me.metroTabPanel2.Name = "metroTabPanel2"
			Me.metroTabPanel2.Padding = New Padding(16, 3, 16, 40)
			Me.metroTabPanel2.Size = New Size(852, 466)
			' 
			' 
			' 
			Me.metroTabPanel2.Style.Class = ""
			Me.metroTabPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square
			' 
			' 
			' 
			Me.metroTabPanel2.StyleMouseDown.Class = ""
			Me.metroTabPanel2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
			' 
			' 
			' 
			Me.metroTabPanel2.StyleMouseOver.Class = ""
			Me.metroTabPanel2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
			Me.metroTabPanel2.TabIndex = 2
			Me.metroTabPanel2.Visible = False
			' 
			' metroToolbar2
			' 
			Me.metroToolbar2.BackColor = Color.White
			' 
			' 
			' 
			Me.metroToolbar2.BackgroundStyle.Class = ""
			Me.metroToolbar2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
			Me.metroToolbar2.ContainerControlProcessDialogKey = True
			Me.metroToolbar2.ExpandDirection = DevComponents.DotNetBar.Metro.eExpandDirection.Top
			Me.metroToolbar2.ExtraItems.AddRange(New DevComponents.DotNetBar.BaseItem() { Me.buttonItem9})
			Me.metroToolbar2.ForeColor = Color.Black
			Me.metroToolbar2.Items.AddRange(New DevComponents.DotNetBar.BaseItem() { Me.newClientButton, Me.clientReportButton})
			Me.metroToolbar2.Location = New Point(250, 427)
			Me.metroToolbar2.Name = "metroToolbar2"
			Me.metroToolbar2.Size = New Size(388, 38)
			Me.metroToolbar2.TabIndex = 1
			Me.metroToolbar2.Text = "Clients"
			' 
			' buttonItem9
			' 
			Me.buttonItem9.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
			Me.buttonItem9.Image = My.Resources.Delete1
			Me.buttonItem9.ImageAlt = My.Resources.DeleteWhite
			Me.buttonItem9.Name = "buttonItem9"
			Me.buttonItem9.Text = "Delete Client"
			Me.buttonItem9.Tooltip = "Deletes selected client"
			' 
			' newClientButton
			' 
			Me.newClientButton.Image = My.Resources.User1
			Me.newClientButton.ImageAlt = My.Resources.UserWhite1
			Me.newClientButton.Name = "newClientButton"
			Me.newClientButton.Text = "Add new client"
			Me.newClientButton.Tooltip = "Add new client"
			' 
			' clientReportButton
			' 
			Me.clientReportButton.Image = My.Resources.Table1
			Me.clientReportButton.ImageAlt = My.Resources.TableWhite1
			Me.clientReportButton.Name = "clientReportButton"
			Me.clientReportButton.Text = "Client Report"
			Me.clientReportButton.Tooltip = "Client Activity Report"
			' 
			' advTree2
			' 
			Me.advTree2.AccessibleRole = AccessibleRole.Outline
			Me.advTree2.AllowDrop = True
			Me.advTree2.BackColor = Color.White
			' 
			' 
			' 
			Me.advTree2.BackgroundStyle.Class = "TreeBorderKey"
			Me.advTree2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
			Me.advTree2.Columns.Add(Me.columnHeader4)
			Me.advTree2.Columns.Add(Me.columnHeader5)
			Me.advTree2.Columns.Add(Me.columnHeader6)
			Me.advTree2.Dock = DockStyle.Fill
			Me.advTree2.ExpandWidth = 0
			Me.advTree2.ForeColor = Color.Black
			Me.advTree2.Indent = 0
			Me.advTree2.Location = New Point(16, 3)
			Me.advTree2.Name = "advTree2"
			Me.advTree2.NodesConnector = Me.nodeConnector2
			Me.advTree2.NodeStyle = Me.elementStyle2
			Me.advTree2.PathSeparator = ";"
			Me.advTree2.Size = New Size(820, 423)
			Me.advTree2.Styles.Add(Me.elementStyle2)
			Me.advTree2.TabIndex = 0
			Me.advTree2.Text = "advTree2"
			' 
			' columnHeader4
			' 
			Me.columnHeader4.Name = "columnHeader4"
			Me.columnHeader4.Text = "Name"
			Me.columnHeader4.Width.Relative = 60
			' 
			' columnHeader5
			' 
			Me.columnHeader5.Name = "columnHeader5"
			Me.columnHeader5.Text = "Location"
			Me.columnHeader5.Width.Relative = 20
			' 
			' columnHeader6
			' 
			Me.columnHeader6.Name = "columnHeader6"
			Me.columnHeader6.Text = "Total Billed"
			Me.columnHeader6.Width.Relative = 20
			' 
			' nodeConnector2
			' 
			Me.nodeConnector2.LineColor = SystemColors.ControlText
			' 
			' elementStyle2
			' 
			Me.elementStyle2.Class = ""
			Me.elementStyle2.CornerType = DevComponents.DotNetBar.eCornerType.Square
			Me.elementStyle2.Name = "elementStyle2"
			Me.elementStyle2.TextColor = Color.Black
			' 
			' metroTabPanel1
			' 
			Me.metroTabPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
			Me.metroTabPanel1.Controls.Add(Me.metroToolbar1)
			Me.metroTabPanel1.Controls.Add(Me.richTextBox1)
			Me.metroTabPanel1.Controls.Add(Me.expandableSplitter1)
			Me.metroTabPanel1.Controls.Add(Me.advTree1)
			Me.metroTabPanel1.Dock = DockStyle.Fill
			Me.metroTabPanel1.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, (CByte(0)))
			Me.metroTabPanel1.Location = New Point(0, 51)
			Me.metroTabPanel1.Name = "metroTabPanel1"
			Me.metroTabPanel1.Padding = New Padding(16, 3, 16, 40)
			Me.metroTabPanel1.Size = New Size(852, 466)
			' 
			' 
			' 
			Me.metroTabPanel1.Style.Class = ""
			Me.metroTabPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square
			' 
			' 
			' 
			Me.metroTabPanel1.StyleMouseDown.Class = ""
			Me.metroTabPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
			' 
			' 
			' 
			Me.metroTabPanel1.StyleMouseOver.Class = ""
			Me.metroTabPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
			Me.metroTabPanel1.TabIndex = 1
			' 
			' metroToolbar1
			' 
			Me.metroToolbar1.BackColor = Color.White
			' 
			' 
			' 
			Me.metroToolbar1.BackgroundStyle.Class = ""
			Me.metroToolbar1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
			Me.metroToolbar1.ContainerControlProcessDialogKey = True
			Me.metroToolbar1.ExpandDirection = DevComponents.DotNetBar.Metro.eExpandDirection.Top
			Me.metroToolbar1.ExtraItems.AddRange(New DevComponents.DotNetBar.BaseItem() { Me.voidInvoiceButton, Me.addNoteButton, Me.buttonItem7})
			Me.metroToolbar1.ForeColor = Color.Black
			Me.metroToolbar1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() { Me.newInvoiceButton, Me.markAsPaidButton, Me.buttonItem8})
			Me.metroToolbar1.Location = New Point(250, 420)
			Me.metroToolbar1.Name = "metroToolbar1"
			Me.metroToolbar1.Size = New Size(388, 38)
			Me.metroToolbar1.TabIndex = 0
			Me.metroToolbar1.Text = "Invoices"
			' 
			' voidInvoiceButton
			' 
			Me.voidInvoiceButton.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
			Me.voidInvoiceButton.Image = My.Resources.Delete1
			Me.voidInvoiceButton.ImageAlt = My.Resources.DeleteWhite
			Me.voidInvoiceButton.Name = "voidInvoiceButton"
			Me.voidInvoiceButton.Text = "Void Invoice"
			Me.voidInvoiceButton.Tooltip = "Void Selected Invoice"
			' 
			' addNoteButton
			' 
			Me.addNoteButton.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
			Me.addNoteButton.Image = My.Resources.BookNote
			Me.addNoteButton.ImageAlt = My.Resources.BookNoteWhite
			Me.addNoteButton.Name = "addNoteButton"
			Me.addNoteButton.Text = "Add a Note"
			Me.addNoteButton.Tooltip = "Add note to selected invoice"
			' 
			' buttonItem7
			' 
			Me.buttonItem7.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
			Me.buttonItem7.Image = My.Resources.PaperClip
			Me.buttonItem7.ImageAlt = My.Resources.PaperClipWhite
			Me.buttonItem7.Name = "buttonItem7"
			Me.buttonItem7.Text = "Attach a File"
			Me.buttonItem7.Tooltip = "Attach a file to selected invoice"
			' 
			' newInvoiceButton
			' 
			Me.newInvoiceButton.Image = My.Resources.NewInvoice1
			Me.newInvoiceButton.ImageAlt = My.Resources.NewInvoiceWhite
			Me.newInvoiceButton.Name = "newInvoiceButton"
			Me.newInvoiceButton.Text = "Create New Invoice"
			Me.newInvoiceButton.Tooltip = "Create New Invoice"
			' 
			' markAsPaidButton
			' 
			Me.markAsPaidButton.Image = My.Resources.MarkAsPaid
			Me.markAsPaidButton.ImageAlt = My.Resources.MarkAsPaidWhite
			Me.markAsPaidButton.Name = "markAsPaidButton"
			Me.markAsPaidButton.Text = "Mark As Paid"
			Me.markAsPaidButton.Tooltip = "Mark selected invoice as PAID"
			' 
			' buttonItem8
			' 
			Me.buttonItem8.Image = My.Resources.Print1
			Me.buttonItem8.ImageAlt = My.Resources.PrintWhite
			Me.buttonItem8.Name = "buttonItem8"
			Me.buttonItem8.Text = "Print selected invoice"
			Me.buttonItem8.Tooltip = "Print selected invoice"
			' 
			' richTextBox1
			' 
			Me.richTextBox1.BackColor = Color.White
			Me.richTextBox1.BorderStyle = BorderStyle.None
			Me.richTextBox1.Dock = DockStyle.Fill
			Me.richTextBox1.ForeColor = Color.Black
			Me.richTextBox1.Location = New Point(16, 181)
			Me.richTextBox1.Name = "richTextBox1"
			Me.richTextBox1.ScrollBars = RichTextBoxScrollBars.None
			Me.richTextBox1.Size = New Size(820, 245)
			Me.richTextBox1.TabIndex = 2
			Me.richTextBox1.Text = ""
			' 
			' expandableSplitter1
			' 
			Me.expandableSplitter1.BackColor = Color.FromArgb((CInt((CByte(216)))), (CInt((CByte(216)))), (CInt((CByte(216)))))
			Me.expandableSplitter1.BackColor2 = Color.Empty
			Me.expandableSplitter1.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
			Me.expandableSplitter1.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
			Me.expandableSplitter1.Dock = DockStyle.Top
			Me.expandableSplitter1.Expandable = False
			Me.expandableSplitter1.ExpandFillColor = Color.Empty
			Me.expandableSplitter1.ExpandFillColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
			Me.expandableSplitter1.ExpandLineColor = Color.FromArgb((CInt((CByte(140)))), (CInt((CByte(140)))), (CInt((CByte(140)))))
			Me.expandableSplitter1.ExpandLineColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
			Me.expandableSplitter1.ForeColor = Color.Black
			Me.expandableSplitter1.GripDarkColor = Color.FromArgb((CInt((CByte(140)))), (CInt((CByte(140)))), (CInt((CByte(140)))))
			Me.expandableSplitter1.GripDarkColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
			Me.expandableSplitter1.GripLightColor = Color.White
			Me.expandableSplitter1.GripLightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
			Me.expandableSplitter1.HotBackColor = Color.FromArgb((CInt((CByte(127)))), (CInt((CByte(127)))), (CInt((CByte(127)))))
			Me.expandableSplitter1.HotBackColor2 = Color.Empty
			Me.expandableSplitter1.HotBackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground2
			Me.expandableSplitter1.HotBackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground
			Me.expandableSplitter1.HotExpandFillColor = Color.Empty
			Me.expandableSplitter1.HotExpandFillColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
			Me.expandableSplitter1.HotExpandLineColor = Color.FromArgb((CInt((CByte(140)))), (CInt((CByte(140)))), (CInt((CByte(140)))))
			Me.expandableSplitter1.HotExpandLineColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
			Me.expandableSplitter1.HotGripDarkColor = Color.Empty
			Me.expandableSplitter1.HotGripDarkColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
			Me.expandableSplitter1.HotGripLightColor = Color.White
			Me.expandableSplitter1.HotGripLightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
			Me.expandableSplitter1.Location = New Point(16, 175)
			Me.expandableSplitter1.Name = "expandableSplitter1"
			Me.expandableSplitter1.Size = New Size(820, 6)
			Me.expandableSplitter1.Style = DevComponents.DotNetBar.eSplitterStyle.Office2007
			Me.expandableSplitter1.TabIndex = 1
			Me.expandableSplitter1.TabStop = False
			' 
			' advTree1
			' 
			Me.advTree1.AccessibleRole = AccessibleRole.Outline
			Me.advTree1.AllowDrop = True
			Me.advTree1.BackColor = Color.White
			' 
			' 
			' 
			Me.advTree1.BackgroundStyle.Class = ""
			Me.advTree1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
			Me.advTree1.Columns.Add(Me.columnHeader1)
			Me.advTree1.Columns.Add(Me.columnHeader2)
			Me.advTree1.Columns.Add(Me.columnHeader3)
			Me.advTree1.Dock = DockStyle.Top
			Me.advTree1.ExpandWidth = 0
			Me.advTree1.ForeColor = Color.Black
			Me.advTree1.GridColumnLines = False
			Me.advTree1.Indent = 0
			Me.advTree1.Location = New Point(16, 3)
			Me.advTree1.Name = "advTree1"
			Me.advTree1.NodesConnector = Me.nodeConnector1
			Me.advTree1.NodeStyle = Me.elementStyle1
			Me.advTree1.PathSeparator = ";"
			Me.advTree1.SelectionBoxStyle = DevComponents.AdvTree.eSelectionStyle.FullRowSelect
			Me.advTree1.Size = New Size(820, 172)
			Me.advTree1.Styles.Add(Me.elementStyle1)
			Me.advTree1.TabIndex = 0
			Me.advTree1.Text = "advTree1"
'			Me.advTree1.AfterNodeSelect += New DevComponents.AdvTree.AdvTreeNodeEventHandler(Me.advTree1_AfterNodeSelect)
			' 
			' columnHeader1
			' 
			Me.columnHeader1.Name = "columnHeader1"
			Me.columnHeader1.Text = "Date"
			Me.columnHeader1.Width.Relative = 10
			' 
			' columnHeader2
			' 
			Me.columnHeader2.Name = "columnHeader2"
			Me.columnHeader2.Text = "Client"
			Me.columnHeader2.Width.Relative = 70
			' 
			' columnHeader3
			' 
			Me.columnHeader3.Name = "columnHeader3"
			Me.columnHeader3.Text = "Amount"
			Me.columnHeader3.Width.Relative = 20
			' 
			' nodeConnector1
			' 
			Me.nodeConnector1.LineColor = SystemColors.ControlText
			' 
			' elementStyle1
			' 
			Me.elementStyle1.Class = ""
			Me.elementStyle1.CornerType = DevComponents.DotNetBar.eCornerType.Square
			Me.elementStyle1.Name = "elementStyle1"
			Me.elementStyle1.TextColor = Color.Black
			' 
			' metroAppButton1
			' 
			Me.metroAppButton1.AutoExpandOnClick = True
			Me.metroAppButton1.BackstageTab = Me.superTabControl1
			Me.metroAppButton1.CanCustomize = False
			Me.metroAppButton1.ImageFixedSize = New Size(16, 16)
			Me.metroAppButton1.ImagePaddingHorizontal = 0
			Me.metroAppButton1.ImagePaddingVertical = 0
			Me.metroAppButton1.Name = "metroAppButton1"
			Me.metroAppButton1.ShowSubItems = False
			Me.metroAppButton1.Text = "&File"
'			Me.metroAppButton1.ExpandChange += New System.EventHandler(Me.metroAppButton1_ExpandChange)
			' 
			' superTabControl1
			' 
			Me.superTabControl1.Anchor = (CType((((AnchorStyles.Top Or AnchorStyles.Bottom) Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
			Me.superTabControl1.BackColor = Color.White
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
			Me.superTabControl1.ControlBox.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() { Me.superTabControl1.ControlBox.MenuBox, Me.superTabControl1.ControlBox.CloseBox})
			Me.superTabControl1.ControlBox.Visible = False
			Me.superTabControl1.Controls.Add(Me.superTabControlPanel1)
			Me.superTabControl1.Controls.Add(Me.superTabControlPanel3)
			Me.superTabControl1.Controls.Add(Me.superTabControlPanel4)
			Me.superTabControl1.Controls.Add(Me.superTabControlPanel2)
			Me.superTabControl1.ForeColor = Color.Black
			Me.superTabControl1.ItemPadding.Left = 6
			Me.superTabControl1.ItemPadding.Right = 4
			Me.superTabControl1.ItemPadding.Top = 4
			Me.superTabControl1.Location = New Point(0, 52)
			Me.superTabControl1.Name = "superTabControl1"
			Me.superTabControl1.ReorderTabsEnabled = False
			Me.superTabControl1.SelectedTabFont = New Font("Segoe UI", 9.75F)
			Me.superTabControl1.SelectedTabIndex = 3
			Me.superTabControl1.Size = New Size(852, 488)
			Me.superTabControl1.TabAlignment = DevComponents.DotNetBar.eTabStripAlignment.Left
			Me.superTabControl1.TabFont = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, (CByte(0)))
			Me.superTabControl1.TabHorizontalSpacing = 16
			Me.superTabControl1.TabIndex = 2
			Me.superTabControl1.Tabs.AddRange(New DevComponents.DotNetBar.BaseItem() { Me.buttonItem2, Me.buttonItem3, Me.buttonItem4, Me.superTabItem1, Me.superTabItem2, Me.superTabItem3, Me.superTabItem4, Me.buttonItem5, Me.buttonItem6})
			Me.superTabControl1.TabStyle = DevComponents.DotNetBar.eSuperTabStyle.Office2010BackstageBlue
			Me.superTabControl1.TabVerticalSpacing = 8
			' 
			' superTabControlPanel1
			' 
			Me.superTabControlPanel1.Dock = DockStyle.Fill
			Me.superTabControlPanel1.Location = New Point(95, 0)
			Me.superTabControlPanel1.Name = "superTabControlPanel1"
			Me.superTabControlPanel1.Size = New Size(757, 488)
			Me.superTabControlPanel1.TabIndex = 1
			Me.superTabControlPanel1.TabItem = Me.superTabItem1
			' 
			' superTabItem1
			' 
			Me.superTabItem1.AttachedControl = Me.superTabControlPanel1
			Me.superTabItem1.GlobalItem = False
			Me.superTabItem1.KeyTips = "R"
			Me.superTabItem1.Name = "superTabItem1"
			Me.superTabItem1.Text = "Recent"
			' 
			' superTabControlPanel3
			' 
			Me.superTabControlPanel3.Dock = DockStyle.Fill
			Me.superTabControlPanel3.Location = New Point(95, 0)
			Me.superTabControlPanel3.Name = "superTabControlPanel3"
			Me.superTabControlPanel3.Size = New Size(757, 488)
			Me.superTabControlPanel3.TabIndex = 3
			Me.superTabControlPanel3.TabItem = Me.superTabItem3
			' 
			' superTabItem3
			' 
			Me.superTabItem3.AttachedControl = Me.superTabControlPanel3
			Me.superTabItem3.GlobalItem = False
			Me.superTabItem3.KeyTips = "P"
			Me.superTabItem3.Name = "superTabItem3"
			Me.superTabItem3.Text = "Print"
			' 
			' superTabControlPanel4
			' 
			Me.superTabControlPanel4.BackgroundImagePosition = DevComponents.DotNetBar.eStyleBackgroundImage.BottomRight
			Me.superTabControlPanel4.Dock = DockStyle.Fill
			Me.superTabControlPanel4.Location = New Point(95, 0)
			Me.superTabControlPanel4.Name = "superTabControlPanel4"
			Me.superTabControlPanel4.Size = New Size(757, 488)
			Me.superTabControlPanel4.TabIndex = 4
			Me.superTabControlPanel4.TabItem = Me.superTabItem4
			' 
			' superTabItem4
			' 
			Me.superTabItem4.AttachedControl = Me.superTabControlPanel4
			Me.superTabItem4.GlobalItem = False
			Me.superTabItem4.KeyTips = "H"
			Me.superTabItem4.Name = "superTabItem4"
			Me.superTabItem4.Text = "Help"
			' 
			' superTabControlPanel2
			' 
			Me.superTabControlPanel2.Dock = DockStyle.Fill
			Me.superTabControlPanel2.Location = New Point(95, 0)
			Me.superTabControlPanel2.Name = "superTabControlPanel2"
			Me.superTabControlPanel2.Size = New Size(757, 488)
			Me.superTabControlPanel2.TabIndex = 2
			Me.superTabControlPanel2.TabItem = Me.superTabItem2
			' 
			' superTabItem2
			' 
			Me.superTabItem2.AttachedControl = Me.superTabControlPanel2
			Me.superTabItem2.GlobalItem = False
			Me.superTabItem2.KeyTips = "N"
			Me.superTabItem2.Name = "superTabItem2"
			Me.superTabItem2.Text = "New"
			' 
			' buttonItem2
			' 
			Me.buttonItem2.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
			Me.buttonItem2.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue
			Me.buttonItem2.Image = (CType(resources.GetObject("buttonItem2.Image"), Image))
			Me.buttonItem2.ImagePaddingHorizontal = 18
			Me.buttonItem2.ImagePaddingVertical = 10
			Me.buttonItem2.KeyTips = "S"
			Me.buttonItem2.Name = "buttonItem2"
			Me.buttonItem2.Stretch = True
			Me.buttonItem2.Text = "Save"
			' 
			' buttonItem3
			' 
			Me.buttonItem3.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
			Me.buttonItem3.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue
			Me.buttonItem3.Image = (CType(resources.GetObject("buttonItem3.Image"), Image))
			Me.buttonItem3.ImagePaddingHorizontal = 18
			Me.buttonItem3.ImagePaddingVertical = 10
			Me.buttonItem3.KeyTips = "O"
			Me.buttonItem3.Name = "buttonItem3"
			Me.buttonItem3.Stretch = True
			Me.buttonItem3.Text = "Open"
			' 
			' buttonItem4
			' 
			Me.buttonItem4.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
			Me.buttonItem4.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue
			Me.buttonItem4.Image = (CType(resources.GetObject("buttonItem4.Image"), Image))
			Me.buttonItem4.ImagePaddingHorizontal = 18
			Me.buttonItem4.ImagePaddingVertical = 10
			Me.buttonItem4.KeyTips = "C"
			Me.buttonItem4.Name = "buttonItem4"
			Me.buttonItem4.Stretch = True
			Me.buttonItem4.Text = "Close"
			' 
			' buttonItem5
			' 
			Me.buttonItem5.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
			Me.buttonItem5.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue
			Me.buttonItem5.Image = (CType(resources.GetObject("buttonItem5.Image"), Image))
			Me.buttonItem5.ImagePaddingHorizontal = 18
			Me.buttonItem5.ImagePaddingVertical = 10
			Me.buttonItem5.KeyTips = "T"
			Me.buttonItem5.Name = "buttonItem5"
			Me.buttonItem5.Stretch = True
			Me.buttonItem5.Text = "Options"
			' 
			' buttonItem6
			' 
			Me.buttonItem6.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
			Me.buttonItem6.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue
			Me.buttonItem6.Image = (CType(resources.GetObject("buttonItem6.Image"), Image))
			Me.buttonItem6.ImagePaddingHorizontal = 18
			Me.buttonItem6.ImagePaddingVertical = 10
			Me.buttonItem6.KeyTips = "X"
			Me.buttonItem6.Name = "buttonItem6"
			Me.buttonItem6.Stretch = True
			Me.buttonItem6.Text = "Exit"
			' 
			' metroTabItem1
			' 
			Me.metroTabItem1.Checked = True
			Me.metroTabItem1.Name = "metroTabItem1"
			Me.metroTabItem1.Panel = Me.metroTabPanel1
			Me.metroTabItem1.Text = "&INVOICES"
			' 
			' metroTabItem2
			' 
			Me.metroTabItem2.Name = "metroTabItem2"
			Me.metroTabItem2.Panel = Me.metroTabPanel2
			Me.metroTabItem2.Text = "&CLIENTS"
			' 
			' colorThemeButton
			' 
			Me.colorThemeButton.AutoExpandOnClick = True
			Me.colorThemeButton.CanCustomize = False
			Me.colorThemeButton.Image = My.Resources.ColorScheme
			Me.colorThemeButton.Name = "colorThemeButton"
			Me.colorThemeButton.ShowSubItems = False
			Me.colorThemeButton.Text = "Metro Color Themes"
			Me.colorThemeButton.Tooltip = "Choose Metro Color Theme"
			' 
			' qatCustomizeItem1
			' 
			Me.qatCustomizeItem1.BeginGroup = True
			Me.qatCustomizeItem1.Name = "qatCustomizeItem1"
			' 
			' styleManager1
			' 
			Me.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Metro
			Me.styleManager1.MetroColorParameters = New DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(Color.White, Color.FromArgb((CInt((CByte(255)))), (CInt((CByte(163)))), (CInt((CByte(26))))))
			' 
			' MainForm
			' 
			Me.AutoScaleDimensions = New SizeF(6F, 13F)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.ClientSize = New Size(853, 541)
			Me.Controls.Add(Me.superTabControl1)
			Me.Controls.Add(Me.metroShell1)
			Me.Controls.Add(Me.metroStatusBar1)
			Me.Font = New Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, (CByte(0)))
			Me.Icon = (CType(resources.GetObject("$this.Icon"), Icon))
			Me.MinimumSize = New Size(600, 400)
			Me.Name = "MainForm"
			Me.Text = "DotNetBar Metro Bill"
			Me.metroShell1.ResumeLayout(False)
			Me.metroShell1.PerformLayout()
			Me.metroTabPanel2.ResumeLayout(False)
			CType(Me.advTree2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.metroTabPanel1.ResumeLayout(False)
			CType(Me.advTree1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.superTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.superTabControl1.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private metroStatusBar1 As DevComponents.DotNetBar.Metro.MetroStatusBar
		Private WithEvents metroShell1 As DevComponents.DotNetBar.Metro.MetroShell
		Private metroTabPanel1 As DevComponents.DotNetBar.Metro.MetroTabPanel
		Private metroTabPanel2 As DevComponents.DotNetBar.Metro.MetroTabPanel
		Private WithEvents metroAppButton1 As DevComponents.DotNetBar.Metro.MetroAppButton
		Private metroTabItem1 As DevComponents.DotNetBar.Metro.MetroTabItem
		Private metroTabItem2 As DevComponents.DotNetBar.Metro.MetroTabItem
		Private qatCustomizeItem1 As DevComponents.DotNetBar.QatCustomizeItem
		Private styleManager1 As DevComponents.DotNetBar.StyleManager
		Private superTabControl1 As DevComponents.DotNetBar.SuperTabControl
		Private superTabControlPanel4 As DevComponents.DotNetBar.SuperTabControlPanel
		Private superTabItem4 As DevComponents.DotNetBar.SuperTabItem
		Private superTabControlPanel3 As DevComponents.DotNetBar.SuperTabControlPanel
		Private superTabItem3 As DevComponents.DotNetBar.SuperTabItem
		Private superTabControlPanel2 As DevComponents.DotNetBar.SuperTabControlPanel
		Private superTabItem2 As DevComponents.DotNetBar.SuperTabItem
		Private superTabControlPanel1 As DevComponents.DotNetBar.SuperTabControlPanel
		Private superTabItem1 As DevComponents.DotNetBar.SuperTabItem
		Private buttonItem2 As DevComponents.DotNetBar.ButtonItem
		Private buttonItem3 As DevComponents.DotNetBar.ButtonItem
		Private buttonItem4 As DevComponents.DotNetBar.ButtonItem
		Private buttonItem5 As DevComponents.DotNetBar.ButtonItem
		Private buttonItem6 As DevComponents.DotNetBar.ButtonItem
		Private richTextBox1 As RichTextBox
		Private expandableSplitter1 As DevComponents.DotNetBar.ExpandableSplitter
		Private WithEvents advTree1 As DevComponents.AdvTree.AdvTree
		Private nodeConnector1 As DevComponents.AdvTree.NodeConnector
		Private elementStyle1 As DevComponents.DotNetBar.ElementStyle
		Private metroToolbar1 As DevComponents.DotNetBar.Metro.MetroToolbar
		Private columnHeader1 As DevComponents.AdvTree.ColumnHeader
		Private columnHeader2 As DevComponents.AdvTree.ColumnHeader
		Private columnHeader3 As DevComponents.AdvTree.ColumnHeader
		Private newInvoiceButton As DevComponents.DotNetBar.ButtonItem
		Private voidInvoiceButton As DevComponents.DotNetBar.ButtonItem
		Private addNoteButton As DevComponents.DotNetBar.ButtonItem
		Private markAsPaidButton As DevComponents.DotNetBar.ButtonItem
		Private buttonItem7 As DevComponents.DotNetBar.ButtonItem
		Private metroToolbar2 As DevComponents.DotNetBar.Metro.MetroToolbar
		Private newClientButton As DevComponents.DotNetBar.ButtonItem
		Private clientReportButton As DevComponents.DotNetBar.ButtonItem
		Private advTree2 As DevComponents.AdvTree.AdvTree
		Private nodeConnector2 As DevComponents.AdvTree.NodeConnector
		Private elementStyle2 As DevComponents.DotNetBar.ElementStyle
		Private buttonItem8 As DevComponents.DotNetBar.ButtonItem
		Private buttonItem9 As DevComponents.DotNetBar.ButtonItem
		Private colorThemeButton As DevComponents.DotNetBar.ButtonItem
		Private columnHeader4 As DevComponents.AdvTree.ColumnHeader
		Private columnHeader5 As DevComponents.AdvTree.ColumnHeader
		Private columnHeader6 As DevComponents.AdvTree.ColumnHeader
		Private labelItem1 As DevComponents.DotNetBar.LabelItem
	End Class
End Namespace