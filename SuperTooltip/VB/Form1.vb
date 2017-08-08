Public Class Form1
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents superTooltip1 As DevComponents.DotNetBar.SuperTooltip
    Friend WithEvents buttonItem1 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents buttonItem2 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents tooltipDisplayDelay As System.Windows.Forms.Timer
    Friend WithEvents panelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents treeView1 As System.Windows.Forms.TreeView
    Friend WithEvents label2 As System.Windows.Forms.Label
    Friend WithEvents bar1 As DevComponents.DotNetBar.Bar
    Friend WithEvents button1 As System.Windows.Forms.Button
    Friend WithEvents label1 As System.Windows.Forms.Label
    Friend WithEvents textBox1 As System.Windows.Forms.TextBox
    Friend WithEvents superTooltipWithLink As DevComponents.DotNetBar.SuperTooltip
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
        Me.superTooltip1 = New DevComponents.DotNetBar.SuperTooltip()
        Me.buttonItem1 = New DevComponents.DotNetBar.ButtonItem()
        Me.buttonItem2 = New DevComponents.DotNetBar.ButtonItem()
        Me.button1 = New System.Windows.Forms.Button()
        Me.textBox1 = New System.Windows.Forms.TextBox()
        Me.tooltipDisplayDelay = New System.Windows.Forms.Timer(Me.components)
        Me.panelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.treeView1 = New System.Windows.Forms.TreeView()
        Me.label2 = New System.Windows.Forms.Label()
        Me.bar1 = New DevComponents.DotNetBar.Bar()
        Me.label1 = New System.Windows.Forms.Label()
        Me.superTooltipWithLink = New DevComponents.DotNetBar.SuperTooltip()
        Me.panelEx1.SuspendLayout()
        CType(Me.bar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'superTooltip1
        '
        '
        'buttonItem1
        '
        Me.buttonItem1.Name = "buttonItem1"
        Me.superTooltip1.SetSuperTooltip(Me.buttonItem1, New DevComponents.DotNetBar.SuperTooltipInfo("Super Tooltips for DotNetBar items", "", "Standard DotNetBar items can have Super Tooltips assigned as well." & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "- RibbonBar" & _
        " Control" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "- Stand-alone Bar control" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "- Side-bar Control" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "- Explorer-Bar Control" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "- PanelEx Control" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "- NavigationPane Control", Nothing, Nothing, DevComponents.DotNetBar.eTooltipColor.Red, True, False, New System.Drawing.Size(0, 0)))
        Me.buttonItem1.Text = "Open"
        '
        'buttonItem2
        '
        Me.buttonItem2.Name = "buttonItem2"
        Me.superTooltip1.SetSuperTooltip(Me.buttonItem2, New DevComponents.DotNetBar.SuperTooltipInfo("18 predefined color schemes", "", "18 predefined colors are available for Super Tooltips." & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "Default Gray color is s" & _
        "ame as color scheme used in Office 12", Nothing, Nothing, DevComponents.DotNetBar.eTooltipColor.Teal, True, False, New System.Drawing.Size(0, 0)))
        Me.buttonItem2.Text = "Print"
        '
        'button1
        '
        Me.button1.Location = New System.Drawing.Point(8, 56)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(96, 40)
        Me.superTooltip1.SetSuperTooltip(Me.button1, New DevComponents.DotNetBar.SuperTooltipInfo("Preview dialog box before opening", "", "Screenshot of your dialog box can be used as body image to preview dialog box so " & _
        "user can see what is behind the button without clicking it.", CType(resources.GetObject("button1.SuperTooltip"), System.Drawing.Bitmap), Nothing, DevComponents.DotNetBar.eTooltipColor.Office2003))
        Me.button1.TabIndex = 2
        Me.button1.Text = "Place mouse cursor here"
        '
        'textBox1
        '
        Me.textBox1.Location = New System.Drawing.Point(8, 24)
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(152, 20)
        Me.superTooltipWithLink.SetSuperTooltip(Me.textBox1, New DevComponents.DotNetBar.SuperTooltipInfo("Text Box Tooltip Header", "<a href=""TextBoxMoreInfo"">Press F1 key to get more information</a>", "Super Tooltips can have multiple lines of text." & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "To better explain functionalit" & _
        "y certain command provides.", Nothing, CType(resources.GetObject("textBox1.SuperTooltip"), System.Drawing.Bitmap), DevComponents.DotNetBar.eTooltipColor.Gray))
        Me.textBox1.TabIndex = 0
        Me.textBox1.Text = "Place mouse cursor here"
        '
        'tooltipDisplayDelay
        '
        Me.tooltipDisplayDelay.Interval = 1000
        '
        'panelEx1
        '
        Me.panelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.panelEx1.Controls.AddRange(New System.Windows.Forms.Control() {Me.treeView1, Me.label2, Me.bar1, Me.button1, Me.label1, Me.textBox1})
        Me.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelEx1.Name = "panelEx1"
        Me.panelEx1.Size = New System.Drawing.Size(464, 286)
        Me.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.panelEx1.Style.BackColor1.Color = System.Drawing.SystemColors.ControlLightLight
        Me.panelEx1.Style.BackColor2.Color = System.Drawing.SystemColors.Control
        Me.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.panelEx1.Style.GradientAngle = 90
        Me.panelEx1.TabIndex = 7
        '
        'treeView1
        '
        Me.treeView1.ImageIndex = -1
        Me.treeView1.Location = New System.Drawing.Point(72, 144)
        Me.treeView1.Name = "treeView1"
        Me.treeView1.Nodes.AddRange(New System.Windows.Forms.TreeNode() {New System.Windows.Forms.TreeNode("Root Node 1", New System.Windows.Forms.TreeNode() {New System.Windows.Forms.TreeNode("Child Node 1"), New System.Windows.Forms.TreeNode("Child Node 2")}), New System.Windows.Forms.TreeNode("Another Sample root node", New System.Windows.Forms.TreeNode() {New System.Windows.Forms.TreeNode("Node4"), New System.Windows.Forms.TreeNode("Node5")})})
        Me.treeView1.SelectedImageIndex = -1
        Me.treeView1.Size = New System.Drawing.Size(320, 128)
        Me.treeView1.TabIndex = 3
        '
        'label2
        '
        Me.label2.Location = New System.Drawing.Point(72, 112)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(312, 32)
        Me.label2.TabIndex = 5
        Me.label2.Text = "Super Tooltip extensibility interface allows you to provide tooltips for any type" & _
        " of object even nodes"
        Me.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'bar1
        '
        Me.bar1.DockSide = DevComponents.DotNetBar.eDockSide.Document
        Me.bar1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.buttonItem1, Me.buttonItem2})
        Me.bar1.Location = New System.Drawing.Point(192, 24)
        Me.bar1.Name = "bar1"
        Me.bar1.Size = New System.Drawing.Size(184, 25)
        Me.bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.bar1.TabIndex = 4
        Me.bar1.TabStop = False
        Me.bar1.Text = "bar1"
        '
        'label1
        '
        Me.label1.Location = New System.Drawing.Point(8, 8)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(160, 16)
        Me.label1.TabIndex = 1
        Me.label1.Text = "Works with any .NET Control"
        '
        'superTooltipWithLink
        '
        Me.superTooltipWithLink.AntiAlias = False
        Me.superTooltipWithLink.DefaultFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.superTooltipWithLink.DelayTooltipHideDuration = 1000
        Me.superTooltipWithLink.PositionBelowControl = False
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(464, 286)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.panelEx1})
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.panelEx1.ResumeLayout(False)
        CType(Me.bar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Load SuperTooltip information for each node...
        Dim node As TreeNode = treeView1.Nodes(0)
        Do While Not (node Is Nothing)
            ' Creates wrapper to provide SuperTooltip control access to the node object
            Dim sp As NodeSuperTooltipProvider = New NodeSuperTooltipProvider(node)
            node.Tag = sp
            ' Assign the wrapper to SuperTooltip control together with information
            ' about what to display on Super Tooltip for this node.
            superTooltip1.SetSuperTooltip(sp, _
              New DevComponents.DotNetBar.SuperTooltipInfo("Header text for " + node.Text, "", _
              "Additional body text for this node. \n\r" + node.Text, _
              Nothing, Nothing, DevComponents.DotNetBar.eTooltipColor.Lemon))

            ' Must expand node to get to the child nodes via NextVisibleNode
            node.Expand()
            node = node.NextVisibleNode
        Loop
    End Sub

    Dim m_LastMouseOverNode As TreeNode

    Private Sub treeView1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles treeView1.MouseMove
        Dim nodeAt As TreeNode = treeView1.GetNodeAt(e.X, e.Y)
        If Not nodeAt Is m_LastMouseOverNode Then
            HideNodeTooltip()
            If Not nodeAt Is Nothing Then
                m_LastMouseOverNode = nodeAt
                ' Delayed display
                tooltipDisplayDelay.Start()
            End If
        End If
    End Sub

    Private Sub ShowNodeTooltip(ByVal node As TreeNode)
        If node Is Nothing Then Exit Sub

        Dim sp As NodeSuperTooltipProvider = CType(node.Tag, NodeSuperTooltipProvider)
        sp.Show()
        m_LastMouseOverNode = node
    End Sub


    Private Sub treeView1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles treeView1.MouseLeave
        ' Hide tooltip when mouse leaves tree control
        HideNodeTooltip()
        tooltipDisplayDelay.Stop()
    End Sub

    Private Sub HideNodeTooltip()
        If Not m_LastMouseOverNode Is Nothing Then
            Dim sp As NodeSuperTooltipProvider = CType(m_LastMouseOverNode.Tag, NodeSuperTooltipProvider)
            sp.Hide()
            m_LastMouseOverNode = Nothing
        End If
    End Sub


    Private Sub tooltipDisplayDelay_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles tooltipDisplayDelay.Tick
        tooltipDisplayDelay.Stop()
        If Not m_LastMouseOverNode Is Nothing Then
            ShowNodeTooltip(m_LastMouseOverNode)
        End If
    End Sub


    Private Sub treeView1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles treeView1.MouseDown
        ' Hide tooltip if any is visible...
        HideNodeTooltip()
    End Sub

    Private Sub superTooltipWithLink_MarkupLinkClick(ByVal sender As Object, ByVal e As DevComponents.DotNetBar.MarkupLinkClickEventArgs) Handles superTooltipWithLink.MarkupLinkClick
        MessageBox.Show("Markup Link Clicked. href = " + e.HRef)
    End Sub
End Class


