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
    Friend WithEvents treeGX1 As DevComponents.Tree.TreeGX
    Friend WithEvents node1 As DevComponents.Tree.Node
    Friend WithEvents nodeCustomRender As DevComponents.Tree.Node
    Friend WithEvents node3 As DevComponents.Tree.Node
    Friend WithEvents nodeConnector2 As DevComponents.Tree.NodeConnector
    Friend WithEvents elementStyle1 As DevComponents.Tree.ElementStyle
    Friend WithEvents nodeConnector1 As DevComponents.Tree.NodeConnector
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.treeGX1 = New DevComponents.Tree.TreeGX
        Me.node1 = New DevComponents.Tree.Node
        Me.nodeCustomRender = New DevComponents.Tree.Node
        Me.node3 = New DevComponents.Tree.Node
        Me.nodeConnector2 = New DevComponents.Tree.NodeConnector
        Me.elementStyle1 = New DevComponents.Tree.ElementStyle
        Me.nodeConnector1 = New DevComponents.Tree.NodeConnector
        CType(Me.treeGX1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'treeGX1
        '
        Me.treeGX1.AllowDrop = True
        Me.treeGX1.AutoScrollMinSize = New System.Drawing.Size(44, 22)
        '
        'treeGX1.BackgroundStyle
        '
        Me.treeGX1.BackgroundStyle.BackColor2SchemePart = DevComponents.Tree.eColorSchemePart.BarBackground2
        Me.treeGX1.BackgroundStyle.BackColorGradientAngle = 90
        Me.treeGX1.BackgroundStyle.BackColorSchemePart = DevComponents.Tree.eColorSchemePart.BarBackground
        Me.treeGX1.CommandBackColorGradientAngle = 90
        Me.treeGX1.CommandMouseOverBackColor2SchemePart = DevComponents.Tree.eColorSchemePart.ItemHotBackground2
        Me.treeGX1.CommandMouseOverBackColorGradientAngle = 90
        Me.treeGX1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.treeGX1.ExpandLineColorSchemePart = DevComponents.Tree.eColorSchemePart.BarDockedBorder
        Me.treeGX1.Location = New System.Drawing.Point(0, 0)
        Me.treeGX1.Name = "treeGX1"
        Me.treeGX1.Nodes.AddRange(New DevComponents.Tree.Node() {Me.node1})
        Me.treeGX1.NodesConnector = Me.nodeConnector2
        Me.treeGX1.NodeStyle = Me.elementStyle1
        Me.treeGX1.PathSeparator = ";"
        Me.treeGX1.RootConnector = Me.nodeConnector1
        Me.treeGX1.Size = New System.Drawing.Size(320, 262)
        Me.treeGX1.Styles.Add(Me.elementStyle1)
        Me.treeGX1.SuspendPaint = False
        Me.treeGX1.TabIndex = 1
        Me.treeGX1.Text = "treeGX1"
        '
        'node1
        '
        Me.node1.CellPartLayout = DevComponents.Tree.eCellPartLayout.Default
        Me.node1.Expanded = True
        Me.node1.Name = "node1"
        Me.node1.Nodes.AddRange(New DevComponents.Tree.Node() {Me.nodeCustomRender, Me.node3})
        Me.node1.Text = "node1"
        '
        'nodeCustomRender
        '
        Me.nodeCustomRender.CellPartLayout = DevComponents.Tree.eCellPartLayout.Default
        Me.nodeCustomRender.Expanded = True
        Me.nodeCustomRender.Name = "nodeCustomRender"
        Me.nodeCustomRender.Text = "Custom Rendered Node"
        '
        'node3
        '
        Me.node3.CellPartLayout = DevComponents.Tree.eCellPartLayout.Default
        Me.node3.Expanded = True
        Me.node3.Name = "node3"
        Me.node3.Text = "node3"
        '
        'nodeConnector2
        '
        Me.nodeConnector2.LineWidth = 5
        '
        'elementStyle1
        '
        Me.elementStyle1.BackColor2SchemePart = DevComponents.Tree.eColorSchemePart.BarBackground2
        Me.elementStyle1.BackColorGradientAngle = 90
        Me.elementStyle1.BackColorSchemePart = DevComponents.Tree.eColorSchemePart.BarBackground
        Me.elementStyle1.BorderBottom = DevComponents.Tree.eStyleBorderType.Solid
        Me.elementStyle1.BorderBottomWidth = 1
        Me.elementStyle1.BorderColorSchemePart = DevComponents.Tree.eColorSchemePart.BarDockedBorder
        Me.elementStyle1.BorderLeft = DevComponents.Tree.eStyleBorderType.Solid
        Me.elementStyle1.BorderLeftWidth = 1
        Me.elementStyle1.BorderRight = DevComponents.Tree.eStyleBorderType.Solid
        Me.elementStyle1.BorderRightWidth = 1
        Me.elementStyle1.BorderTop = DevComponents.Tree.eStyleBorderType.Solid
        Me.elementStyle1.BorderTopWidth = 1
        Me.elementStyle1.CornerDiameter = 4
        Me.elementStyle1.CornerType = DevComponents.Tree.eCornerType.Rounded
        Me.elementStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.elementStyle1.Name = "elementStyle1"
        Me.elementStyle1.PaddingBottom = 3
        Me.elementStyle1.PaddingLeft = 3
        Me.elementStyle1.PaddingRight = 3
        Me.elementStyle1.PaddingTop = 3
        Me.elementStyle1.TextColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(128, Byte))
        '
        'nodeConnector1
        '
        Me.nodeConnector1.LineWidth = 5
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(320, 262)
        Me.Controls.Add(Me.treeGX1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.treeGX1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Indicate that custom rendering will be used for this node
        nodeCustomRender.RenderMode = DevComponents.Tree.eNodeRenderMode.Custom
        ' Assign renderer, renderers can be reused i.e. assigned to more than one node
        Dim renderer As RedNodeRenderer = New RedNodeRenderer
        nodeCustomRender.NodeRenderer = renderer
    End Sub
End Class
