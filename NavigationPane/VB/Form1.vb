Imports System.Collections
Imports System.ComponentModel
Imports DevComponents.DotNetBar

Namespace NavigationPane
	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Public Class Form1
		Inherits Office2007Form
		Private WithEvents navigationPane1 As DevComponents.DotNetBar.NavigationPane
		Private buttonItem1 As DevComponents.DotNetBar.ButtonItem
		Private navigationPanePanel1 As DevComponents.DotNetBar.NavigationPanePanel
		Private buttonItem2 As DevComponents.DotNetBar.ButtonItem
		Private navigationPanePanel2 As DevComponents.DotNetBar.NavigationPanePanel
		Private buttonItem3 As DevComponents.DotNetBar.ButtonItem
		Private navigationPanePanel3 As DevComponents.DotNetBar.NavigationPanePanel
		Private buttonItem4 As DevComponents.DotNetBar.ButtonItem
		Private navigationPanePanel4 As DevComponents.DotNetBar.NavigationPanePanel
		Private buttonItem5 As DevComponents.DotNetBar.ButtonItem
		Private navigationPanePanel5 As DevComponents.DotNetBar.NavigationPanePanel
		Private treeView1 As TreeView
		Private panelEx1 As DevComponents.DotNetBar.PanelEx
		Private imageList1 As ImageList
		Private expandablePanel1 As DevComponents.DotNetBar.ExpandablePanel
		Private textEvents As TextBox
		Private styleManager1 As StyleManager
		Private bar1 As Bar
		Private WithEvents buttonItem6 As ButtonItem
		Private WithEvents checkBoxItem1 As CheckBoxItem
		Private components As System.ComponentModel.IContainer

		Public Sub New()
			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()

			'
			' TODO: Add any constructor code after InitializeComponent call
			'
		End Sub

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
				If components IsNot Nothing Then
					components.Dispose()
				End If
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
			Dim treeNode1 As New TreeNode("Deleted Items", 1, 1)
			Dim treeNode2 As New TreeNode("Drafts", 1, 1)
			Dim treeNode3 As New TreeNode("Inbox", 1, 1)
			Dim treeNode4 As New TreeNode("Outbox", 1, 1)
			Dim treeNode5 As New TreeNode("Sent Items", 1, 1)
			Dim treeNode6 As New TreeNode("Personal Folders", 0, 0, New TreeNode() { treeNode1, treeNode2, treeNode3, treeNode4, treeNode5})
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
			Me.navigationPane1 = New DevComponents.DotNetBar.NavigationPane()
			Me.navigationPanePanel1 = New DevComponents.DotNetBar.NavigationPanePanel()
			Me.treeView1 = New TreeView()
			Me.imageList1 = New ImageList(Me.components)
			Me.panelEx1 = New DevComponents.DotNetBar.PanelEx()
			Me.buttonItem1 = New DevComponents.DotNetBar.ButtonItem()
			Me.navigationPanePanel2 = New DevComponents.DotNetBar.NavigationPanePanel()
			Me.buttonItem2 = New DevComponents.DotNetBar.ButtonItem()
			Me.navigationPanePanel3 = New DevComponents.DotNetBar.NavigationPanePanel()
			Me.buttonItem3 = New DevComponents.DotNetBar.ButtonItem()
			Me.navigationPanePanel5 = New DevComponents.DotNetBar.NavigationPanePanel()
			Me.buttonItem5 = New DevComponents.DotNetBar.ButtonItem()
			Me.navigationPanePanel4 = New DevComponents.DotNetBar.NavigationPanePanel()
			Me.buttonItem4 = New DevComponents.DotNetBar.ButtonItem()
			Me.expandablePanel1 = New DevComponents.DotNetBar.ExpandablePanel()
			Me.textEvents = New TextBox()
			Me.styleManager1 = New DevComponents.DotNetBar.StyleManager(Me.components)
			Me.bar1 = New DevComponents.DotNetBar.Bar()
			Me.buttonItem6 = New DevComponents.DotNetBar.ButtonItem()
			Me.checkBoxItem1 = New DevComponents.DotNetBar.CheckBoxItem()
			Me.navigationPane1.SuspendLayout()
			Me.navigationPanePanel1.SuspendLayout()
			Me.expandablePanel1.SuspendLayout()
			CType(Me.bar1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' navigationPane1
			' 
			Me.navigationPane1.CanCollapse = True
			Me.navigationPane1.Controls.Add(Me.navigationPanePanel1)
			Me.navigationPane1.Controls.Add(Me.navigationPanePanel2)
			Me.navigationPane1.Controls.Add(Me.navigationPanePanel3)
			Me.navigationPane1.Controls.Add(Me.navigationPanePanel5)
			Me.navigationPane1.Controls.Add(Me.navigationPanePanel4)
			Me.navigationPane1.Dock = DockStyle.Left
			Me.navigationPane1.ItemPaddingBottom = 2
			Me.navigationPane1.ItemPaddingTop = 2
			Me.navigationPane1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() { Me.buttonItem1, Me.buttonItem2, Me.buttonItem3, Me.buttonItem4, Me.buttonItem5})
			Me.navigationPane1.Location = New Point(0, 0)
			Me.navigationPane1.Name = "navigationPane1"
			Me.navigationPane1.NavigationBarHeight = 172
			Me.navigationPane1.Size = New Size(184, 440)
			Me.navigationPane1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
			Me.navigationPane1.TabIndex = 0
			' 
			' 
			' 
			Me.navigationPane1.TitlePanel.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2010
			Me.navigationPane1.TitlePanel.Dock = DockStyle.Top
			Me.navigationPane1.TitlePanel.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, (CByte(0)))
			Me.navigationPane1.TitlePanel.Location = New Point(0, 0)
			Me.navigationPane1.TitlePanel.Name = "panelEx1"
			Me.navigationPane1.TitlePanel.Size = New Size(184, 24)
			Me.navigationPane1.TitlePanel.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
			Me.navigationPane1.TitlePanel.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
			Me.navigationPane1.TitlePanel.Style.BorderSide = DevComponents.DotNetBar.eBorderSide.Bottom
			Me.navigationPane1.TitlePanel.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
			Me.navigationPane1.TitlePanel.Style.GradientAngle = 90
			Me.navigationPane1.TitlePanel.Style.MarginLeft = 4
			Me.navigationPane1.TitlePanel.TabIndex = 0
			Me.navigationPane1.TitlePanel.Text = "Mail"
'			Me.navigationPane1.ExpandedChanging += New DevComponents.DotNetBar.ExpandChangeEventHandler(Me.navigationPane1_ExpandedChanging)
'			Me.navigationPane1.PanelChanging += New DevComponents.DotNetBar.PanelChangingEventHandler(Me.navigationPane1_PanelChanging)
'			Me.navigationPane1.BeforePanelPopup += New DevComponents.DotNetBar.PanelPopupEventHandler(Me.navigationPane1_BeforePanelPopup)
'			Me.navigationPane1.ExpandedChanged += New DevComponents.DotNetBar.ExpandChangeEventHandler(Me.navigationPane1_ExpandedChanged)
'			Me.navigationPane1.ItemClick += New System.EventHandler(Me.navigationPane1_ItemClick)
			' 
			' navigationPanePanel1
			' 
			Me.navigationPanePanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2010
			Me.navigationPanePanel1.Controls.Add(Me.treeView1)
			Me.navigationPanePanel1.Controls.Add(Me.panelEx1)
			Me.navigationPanePanel1.Dock = DockStyle.Fill
			Me.navigationPanePanel1.Location = New Point(0, 24)
			Me.navigationPanePanel1.Name = "navigationPanePanel1"
            Me.navigationPanePanel1.Padding = New System.Windows.Forms.Padding(1, 1, 1, 0)
			Me.navigationPanePanel1.ParentItem = Me.buttonItem1
			Me.navigationPanePanel1.Size = New Size(184, 244)
			Me.navigationPanePanel1.Style.Alignment = StringAlignment.Center
			Me.navigationPanePanel1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
			Me.navigationPanePanel1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
			Me.navigationPanePanel1.Style.BackgroundImagePosition = DevComponents.DotNetBar.eBackgroundImagePosition.Tile
			Me.navigationPanePanel1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
			Me.navigationPanePanel1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
			Me.navigationPanePanel1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
			Me.navigationPanePanel1.Style.GradientAngle = 90
			Me.navigationPanePanel1.StyleMouseDown.Alignment = StringAlignment.Center
			Me.navigationPanePanel1.StyleMouseOver.Alignment = StringAlignment.Center
			Me.navigationPanePanel1.TabIndex = 2
			' 
			' treeView1
			' 
			Me.treeView1.BorderStyle = BorderStyle.None
			Me.treeView1.Dock = DockStyle.Fill
			Me.treeView1.ImageIndex = 0
			Me.treeView1.ImageList = Me.imageList1
			Me.treeView1.Location = New Point(1, 21)
			Me.treeView1.Name = "treeView1"
			treeNode1.ImageIndex = 1
			treeNode1.Name = ""
			treeNode1.SelectedImageIndex = 1
			treeNode1.Text = "Deleted Items"
			treeNode2.ImageIndex = 1
			treeNode2.Name = ""
			treeNode2.SelectedImageIndex = 1
			treeNode2.Text = "Drafts"
			treeNode3.ImageIndex = 1
			treeNode3.Name = ""
			treeNode3.SelectedImageIndex = 1
			treeNode3.Text = "Inbox"
			treeNode4.ImageIndex = 1
			treeNode4.Name = ""
			treeNode4.SelectedImageIndex = 1
			treeNode4.Text = "Outbox"
			treeNode5.ImageIndex = 1
			treeNode5.Name = ""
			treeNode5.SelectedImageIndex = 1
			treeNode5.Text = "Sent Items"
			treeNode6.ImageIndex = 0
			treeNode6.Name = ""
			treeNode6.SelectedImageIndex = 0
			treeNode6.Text = "Personal Folders"
			Me.treeView1.Nodes.AddRange(New TreeNode() { treeNode6})
			Me.treeView1.Scrollable = False
			Me.treeView1.SelectedImageIndex = 0
			Me.treeView1.Size = New Size(182, 223)
			Me.treeView1.Sorted = True
			Me.treeView1.TabIndex = 1
			' 
			' imageList1
			' 
			Me.imageList1.ImageStream = (CType(resources.GetObject("imageList1.ImageStream"), ImageListStreamer))
			Me.imageList1.TransparentColor = Color.Transparent
			Me.imageList1.Images.SetKeyName(0, "")
			Me.imageList1.Images.SetKeyName(1, "")
			' 
			' panelEx1
			' 
			Me.panelEx1.Dock = DockStyle.Top
			Me.panelEx1.Location = New Point(1, 1)
			Me.panelEx1.Name = "panelEx1"
			Me.panelEx1.Size = New Size(182, 20)
			Me.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
			Me.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
			Me.panelEx1.Style.BackgroundImagePosition = DevComponents.DotNetBar.eBackgroundImagePosition.Tile
			Me.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
			Me.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
			Me.panelEx1.Style.GradientAngle = 90
			Me.panelEx1.Style.MarginLeft = 4
			Me.panelEx1.TabIndex = 2
			Me.panelEx1.Text = "Mail Folders"
			' 
			' buttonItem1
			' 
			Me.buttonItem1.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
			Me.buttonItem1.Checked = True
			Me.buttonItem1.Image = (CType(resources.GetObject("buttonItem1.Image"), Image))
			Me.buttonItem1.Name = "buttonItem1"
			Me.buttonItem1.OptionGroup = "navBar"
			Me.buttonItem1.SubItemsExpandWidth = 11
			Me.buttonItem1.Text = "Mail"
			Me.buttonItem1.Tooltip = "Click to manage Mail"
			' 
			' navigationPanePanel2
			' 
			Me.navigationPanePanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2010
			Me.navigationPanePanel2.Dock = DockStyle.Fill
			Me.navigationPanePanel2.Location = New Point(0, 0)
			Me.navigationPanePanel2.Name = "navigationPanePanel2"
			Me.navigationPanePanel2.ParentItem = Me.buttonItem2
			Me.navigationPanePanel2.Size = New Size(184, 268)
			Me.navigationPanePanel2.Style.Alignment = StringAlignment.Center
			Me.navigationPanePanel2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
			Me.navigationPanePanel2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
			Me.navigationPanePanel2.Style.BackgroundImagePosition = DevComponents.DotNetBar.eBackgroundImagePosition.Tile
			Me.navigationPanePanel2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
			Me.navigationPanePanel2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
			Me.navigationPanePanel2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
			Me.navigationPanePanel2.Style.GradientAngle = 90
			Me.navigationPanePanel2.Style.WordWrap = True
			Me.navigationPanePanel2.StyleMouseDown.Alignment = StringAlignment.Center
			Me.navigationPanePanel2.StyleMouseDown.WordWrap = True
			Me.navigationPanePanel2.StyleMouseOver.Alignment = StringAlignment.Center
			Me.navigationPanePanel2.StyleMouseOver.WordWrap = True
			Me.navigationPanePanel2.TabIndex = 3
			Me.navigationPanePanel2.Text = "Drop your controls here and erase Text property"
			' 
			' buttonItem2
			' 
			Me.buttonItem2.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
			Me.buttonItem2.Image = (CType(resources.GetObject("buttonItem2.Image"), Image))
			Me.buttonItem2.Name = "buttonItem2"
			Me.buttonItem2.OptionGroup = "navBar"
			Me.buttonItem2.SubItemsExpandWidth = 11
			Me.buttonItem2.Text = "Calendar"
			Me.buttonItem2.Tooltip = "Click to view your Calendar"
			' 
			' navigationPanePanel3
			' 
			Me.navigationPanePanel3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2010
			Me.navigationPanePanel3.Dock = DockStyle.Fill
			Me.navigationPanePanel3.Location = New Point(0, 0)
			Me.navigationPanePanel3.Name = "navigationPanePanel3"
			Me.navigationPanePanel3.ParentItem = Me.buttonItem3
			Me.navigationPanePanel3.Size = New Size(184, 268)
			Me.navigationPanePanel3.Style.Alignment = StringAlignment.Center
			Me.navigationPanePanel3.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
			Me.navigationPanePanel3.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
			Me.navigationPanePanel3.Style.BackgroundImagePosition = DevComponents.DotNetBar.eBackgroundImagePosition.Tile
			Me.navigationPanePanel3.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
			Me.navigationPanePanel3.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
			Me.navigationPanePanel3.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
			Me.navigationPanePanel3.Style.GradientAngle = 90
			Me.navigationPanePanel3.Style.WordWrap = True
			Me.navigationPanePanel3.StyleMouseDown.Alignment = StringAlignment.Center
			Me.navigationPanePanel3.StyleMouseDown.WordWrap = True
			Me.navigationPanePanel3.StyleMouseOver.Alignment = StringAlignment.Center
			Me.navigationPanePanel3.StyleMouseOver.WordWrap = True
			Me.navigationPanePanel3.TabIndex = 4
			Me.navigationPanePanel3.Text = "Drop your controls here and erase Text property"
			' 
			' buttonItem3
			' 
			Me.buttonItem3.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
			Me.buttonItem3.Image = (CType(resources.GetObject("buttonItem3.Image"), Image))
			Me.buttonItem3.Name = "buttonItem3"
			Me.buttonItem3.OptionGroup = "navBar"
			Me.buttonItem3.SubItemsExpandWidth = 11
			Me.buttonItem3.Text = "Contacts"
			Me.buttonItem3.Tooltip = "Click to view your Contacts"
			' 
			' navigationPanePanel5
			' 
			Me.navigationPanePanel5.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2010
			Me.navigationPanePanel5.Dock = DockStyle.Fill
			Me.navigationPanePanel5.Location = New Point(0, 0)
			Me.navigationPanePanel5.Name = "navigationPanePanel5"
			Me.navigationPanePanel5.ParentItem = Me.buttonItem5
			Me.navigationPanePanel5.Size = New Size(184, 268)
			Me.navigationPanePanel5.Style.Alignment = StringAlignment.Center
			Me.navigationPanePanel5.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
			Me.navigationPanePanel5.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
			Me.navigationPanePanel5.Style.BackgroundImagePosition = DevComponents.DotNetBar.eBackgroundImagePosition.Tile
			Me.navigationPanePanel5.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
			Me.navigationPanePanel5.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
			Me.navigationPanePanel5.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
			Me.navigationPanePanel5.Style.GradientAngle = 90
			Me.navigationPanePanel5.Style.WordWrap = True
			Me.navigationPanePanel5.StyleMouseDown.Alignment = StringAlignment.Center
			Me.navigationPanePanel5.StyleMouseDown.WordWrap = True
			Me.navigationPanePanel5.StyleMouseOver.Alignment = StringAlignment.Center
			Me.navigationPanePanel5.StyleMouseOver.WordWrap = True
			Me.navigationPanePanel5.TabIndex = 6
			Me.navigationPanePanel5.Text = "Drop your controls here and erase Text property"
			' 
			' buttonItem5
			' 
			Me.buttonItem5.Image = (CType(resources.GetObject("buttonItem5.Image"), Image))
			Me.buttonItem5.ImageFixedSize = New Size(16, 16)
			Me.buttonItem5.Name = "buttonItem5"
			Me.buttonItem5.OptionGroup = "navBar"
			Me.buttonItem5.SubItemsExpandWidth = 11
			Me.buttonItem5.Text = "Notes"
			' 
			' navigationPanePanel4
			' 
			Me.navigationPanePanel4.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2010
			Me.navigationPanePanel4.Dock = DockStyle.Fill
			Me.navigationPanePanel4.Location = New Point(0, 0)
			Me.navigationPanePanel4.Name = "navigationPanePanel4"
			Me.navigationPanePanel4.ParentItem = Me.buttonItem4
			Me.navigationPanePanel4.Size = New Size(184, 268)
			Me.navigationPanePanel4.Style.Alignment = StringAlignment.Center
			Me.navigationPanePanel4.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
			Me.navigationPanePanel4.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
			Me.navigationPanePanel4.Style.BackgroundImagePosition = DevComponents.DotNetBar.eBackgroundImagePosition.Tile
			Me.navigationPanePanel4.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
			Me.navigationPanePanel4.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
			Me.navigationPanePanel4.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
			Me.navigationPanePanel4.Style.GradientAngle = 90
			Me.navigationPanePanel4.Style.WordWrap = True
			Me.navigationPanePanel4.StyleMouseDown.Alignment = StringAlignment.Center
			Me.navigationPanePanel4.StyleMouseDown.WordWrap = True
			Me.navigationPanePanel4.StyleMouseOver.Alignment = StringAlignment.Center
			Me.navigationPanePanel4.StyleMouseOver.WordWrap = True
			Me.navigationPanePanel4.TabIndex = 5
			Me.navigationPanePanel4.Text = "Drop your controls here and erase Text property"
			' 
			' buttonItem4
			' 
			Me.buttonItem4.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
			Me.buttonItem4.Image = (CType(resources.GetObject("buttonItem4.Image"), Image))
			Me.buttonItem4.Name = "buttonItem4"
			Me.buttonItem4.OptionGroup = "navBar"
			Me.buttonItem4.SubItemsExpandWidth = 11
			Me.buttonItem4.Text = "Tasks"
			' 
			' expandablePanel1
			' 
			Me.expandablePanel1.CanvasColor = SystemColors.Control
			Me.expandablePanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
			Me.expandablePanel1.Controls.Add(Me.textEvents)
			Me.expandablePanel1.Dock = DockStyle.Bottom
			Me.expandablePanel1.Location = New Point(184, 243)
			Me.expandablePanel1.Name = "expandablePanel1"
			Me.expandablePanel1.Size = New Size(379, 197)
			Me.expandablePanel1.Style.Alignment = StringAlignment.Center
			Me.expandablePanel1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
			Me.expandablePanel1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
			Me.expandablePanel1.Style.BackgroundImagePosition = DevComponents.DotNetBar.eBackgroundImagePosition.Tile
			Me.expandablePanel1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
			Me.expandablePanel1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
			Me.expandablePanel1.Style.GradientAngle = 90
			Me.expandablePanel1.TabIndex = 2
			Me.expandablePanel1.TitleStyle.Alignment = StringAlignment.Center
			Me.expandablePanel1.TitleStyle.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
			Me.expandablePanel1.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.RaisedInner
			Me.expandablePanel1.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
			Me.expandablePanel1.TitleStyle.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
			Me.expandablePanel1.TitleStyle.GradientAngle = 90
			Me.expandablePanel1.TitleText = "Navigation Pane Events"
			' 
			' textEvents
			' 
			Me.textEvents.BorderStyle = BorderStyle.None
			Me.textEvents.Dock = DockStyle.Fill
			Me.textEvents.Location = New Point(0, 26)
			Me.textEvents.Multiline = True
			Me.textEvents.Name = "textEvents"
			Me.textEvents.Size = New Size(379, 171)
			Me.textEvents.TabIndex = 1
			' 
			' styleManager1
			' 
			Me.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2010Blue
			Me.styleManager1.MetroColorParameters = New DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(Color.White, Color.FromArgb((CInt((CByte(255)))), (CInt((CByte(163)))), (CInt((CByte(26))))))
			' 
			' bar1
			' 
			Me.bar1.AntiAlias = True
			Me.bar1.Dock = DockStyle.Top
			Me.bar1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() { Me.buttonItem6, Me.checkBoxItem1})
			Me.bar1.Location = New Point(184, 0)
			Me.bar1.Name = "bar1"
			Me.bar1.Size = New Size(379, 25)
			Me.bar1.Stretch = True
			Me.bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
			Me.bar1.TabIndex = 3
			Me.bar1.TabStop = False
			Me.bar1.Text = "bar1"
			' 
			' buttonItem6
			' 
			Me.buttonItem6.Name = "buttonItem6"
			Me.buttonItem6.Text = "Toggle State"
'			Me.buttonItem6.Click += New System.EventHandler(Me.buttonItem6_Click)
			' 
			' checkBoxItem1
			' 
			Me.checkBoxItem1.Checked = True
			Me.checkBoxItem1.CheckState = CheckState.Checked
			Me.checkBoxItem1.Name = "checkBoxItem1"
			Me.checkBoxItem1.Text = "Allow Collapse"
'			Me.checkBoxItem1.CheckedChanged += New DevComponents.DotNetBar.CheckBoxChangeEventHandler(Me.checkBoxItem1_CheckedChanged)
			' 
			' Form1
			' 
			Me.AutoScaleBaseSize = New Size(5, 13)
			Me.ClientSize = New Size(563, 440)
			Me.Controls.Add(Me.bar1)
			Me.Controls.Add(Me.expandablePanel1)
			Me.Controls.Add(Me.navigationPane1)
			Me.DoubleBuffered = True
			Me.EnableGlass = False
			Me.Name = "Form1"
			Me.Text = "DotNetBar Navigation Pane Control"
'			Me.Load += New System.EventHandler(Me.Form1_Load)
'			Me.Closed += New System.EventHandler(Me.Form1_Closed)
			Me.navigationPane1.ResumeLayout(False)
			Me.navigationPanePanel1.ResumeLayout(False)
			Me.expandablePanel1.ResumeLayout(False)
			Me.expandablePanel1.PerformLayout()
			CType(Me.bar1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub
		#End Region

		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		<STAThread> _
		Shared Sub Main()
			Application.Run(New Form1())
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			' Load user layout file if it exists
			If Environment.UserName<>"" Then
				If System.IO.File.Exists(Environment.UserName &".xml") Then
					navigationPane1.LoadLayout(Environment.UserName &".xml")
				End If
			End If

			treeView1.ExpandAll()
		End Sub

		Private Sub Form1_Closed(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Closed
			' Save Navigation Pane Layout 
			If Environment.UserName<>"" Then
				Try
					navigationPane1.SaveLayout(Environment.UserName & ".xml")
				Catch e1 As UnauthorizedAccessException
					' Ignore the access exceptions...
				End Try
			End If
		End Sub

		Private Sub navigationPane1_BeforePanelPopup(ByVal sender As Object, ByVal e As DevComponents.DotNetBar.PanelPopupEventArgs) Handles navigationPane1.BeforePanelPopup
			textEvents.Text &=Date.Now.ToString() & " - BeforePanelPopup" & vbCrLf
		End Sub

		Private Sub navigationPane1_PanelChanging(ByVal sender As Object, ByVal e As DevComponents.DotNetBar.PanelChangingEventArgs) Handles navigationPane1.PanelChanging
			textEvents.Text &=Date.Now.ToString() & " - PanelChanging" & vbCrLf
		End Sub

		Private Sub navigationPane1_ItemClick(ByVal sender As Object, ByVal e As EventArgs) Handles navigationPane1.ItemClick
			textEvents.Text &=Date.Now.ToString() & " - ItemClick" & vbCrLf
		End Sub

		Private Sub navigationPane1_ExpandedChanging(ByVal sender As Object, ByVal e As DevComponents.DotNetBar.ExpandedChangeEventArgs) Handles navigationPane1.ExpandedChanging
			textEvents.Text &=Date.Now.ToString() & " - ExpandedChanging" & vbCrLf
		End Sub

		Private Sub navigationPane1_ExpandedChanged(ByVal sender As Object, ByVal e As DevComponents.DotNetBar.ExpandedChangeEventArgs) Handles navigationPane1.ExpandedChanged
			textEvents.Text &=Date.Now.ToString() & " - ExpandedChanged" & vbCrLf
		End Sub

		Private Sub buttonItem6_Click(ByVal sender As Object, ByVal e As EventArgs) Handles buttonItem6.Click
			navigationPane1.Expanded = Not navigationPane1.Expanded
		End Sub

		Private Sub checkBoxItem1_CheckedChanged(ByVal sender As Object, ByVal e As CheckBoxChangeEventArgs) Handles checkBoxItem1.CheckedChanged
			navigationPane1.CanCollapse = checkBoxItem1.Checked
		End Sub
	End Class
End Namespace
