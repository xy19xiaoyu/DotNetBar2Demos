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
    Friend WithEvents nodeConnector2 As DevComponents.Tree.NodeConnector
    Friend WithEvents nodeStyle As DevComponents.Tree.ElementStyle
    Friend WithEvents nodeConnector1 As DevComponents.Tree.NodeConnector
    Friend WithEvents styleClass As DevComponents.Tree.ElementStyle
    Friend WithEvents panel1 As System.Windows.Forms.Panel
    Friend WithEvents labelZoom As System.Windows.Forms.Label
    Friend WithEvents label1 As System.Windows.Forms.Label
    Friend WithEvents trackBar1 As System.Windows.Forms.TrackBar
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.treeGX1 = New DevComponents.Tree.TreeGX
        Me.node1 = New DevComponents.Tree.Node
        Me.nodeConnector2 = New DevComponents.Tree.NodeConnector
        Me.nodeStyle = New DevComponents.Tree.ElementStyle
        Me.nodeConnector1 = New DevComponents.Tree.NodeConnector
        Me.styleClass = New DevComponents.Tree.ElementStyle
        Me.panel1 = New System.Windows.Forms.Panel
        Me.labelZoom = New System.Windows.Forms.Label
        Me.label1 = New System.Windows.Forms.Label
        Me.trackBar1 = New System.Windows.Forms.TrackBar
        CType(Me.treeGX1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel1.SuspendLayout()
        CType(Me.trackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'treeGX1
        '
        Me.treeGX1.AllowDrop = True
        Me.treeGX1.AutoScrollMinSize = New System.Drawing.Size(44, 22)
        '
        'treeGX1.BackgroundStyle
        '
        Me.treeGX1.BackgroundStyle.BackColor2 = System.Drawing.Color.White
        Me.treeGX1.BackgroundStyle.BackColorGradientAngle = 90
        Me.treeGX1.BackgroundStyle.BackColorSchemePart = DevComponents.Tree.eColorSchemePart.MenuBackground
        Me.treeGX1.CommandBackColorGradientAngle = 90
        Me.treeGX1.CommandMouseOverBackColor2SchemePart = DevComponents.Tree.eColorSchemePart.ItemHotBackground2
        Me.treeGX1.CommandMouseOverBackColorGradientAngle = 90
        Me.treeGX1.DiagramLayoutFlow = DevComponents.Tree.eDiagramFlow.TopToBottom
        Me.treeGX1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.treeGX1.ExpandLineColorSchemePart = DevComponents.Tree.eColorSchemePart.BarDockedBorder
        Me.treeGX1.Location = New System.Drawing.Point(0, 32)
        Me.treeGX1.MapLayoutFlow = DevComponents.Tree.eMapFlow.BottomToTop
        Me.treeGX1.Name = "treeGX1"
        Me.treeGX1.Nodes.AddRange(New DevComponents.Tree.Node() {Me.node1})
        Me.treeGX1.NodesConnector = Me.nodeConnector2
        Me.treeGX1.NodeStyle = Me.nodeStyle
        Me.treeGX1.NodeVerticalSpacing = 8
        Me.treeGX1.PathSeparator = ";"
        Me.treeGX1.RootConnector = Me.nodeConnector1
        Me.treeGX1.Size = New System.Drawing.Size(472, 310)
        Me.treeGX1.Styles.Add(Me.nodeStyle)
        Me.treeGX1.Styles.Add(Me.styleClass)
        Me.treeGX1.SuspendPaint = False
        Me.treeGX1.TabIndex = 1
        Me.treeGX1.Text = "treeGX1"
        '
        'node1
        '
        Me.node1.CellPartLayout = DevComponents.Tree.eCellPartLayout.Default
        Me.node1.Expanded = True
        Me.node1.Name = "node1"
        Me.node1.Text = "node1"
        '
        'nodeConnector2
        '
        Me.nodeConnector2.LineWidth = 5
        '
        'nodeStyle
        '
        Me.nodeStyle.BackColor2SchemePart = DevComponents.Tree.eColorSchemePart.BarBackground2
        Me.nodeStyle.BackColorGradientAngle = 90
        Me.nodeStyle.BackColorSchemePart = DevComponents.Tree.eColorSchemePart.BarBackground
        Me.nodeStyle.BorderBottom = DevComponents.Tree.eStyleBorderType.Solid
        Me.nodeStyle.BorderBottomWidth = 1
        Me.nodeStyle.BorderColorSchemePart = DevComponents.Tree.eColorSchemePart.BarDockedBorder
        Me.nodeStyle.BorderLeft = DevComponents.Tree.eStyleBorderType.Solid
        Me.nodeStyle.BorderLeftWidth = 1
        Me.nodeStyle.BorderRight = DevComponents.Tree.eStyleBorderType.Solid
        Me.nodeStyle.BorderRightWidth = 1
        Me.nodeStyle.BorderTop = DevComponents.Tree.eStyleBorderType.Solid
        Me.nodeStyle.BorderTopWidth = 1
        Me.nodeStyle.CornerDiameter = 4
        Me.nodeStyle.CornerType = DevComponents.Tree.eCornerType.Rounded
        Me.nodeStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nodeStyle.Name = "nodeStyle"
        Me.nodeStyle.PaddingBottom = 4
        Me.nodeStyle.PaddingLeft = 4
        Me.nodeStyle.PaddingRight = 4
        Me.nodeStyle.PaddingTop = 4
        Me.nodeStyle.TextColor = System.Drawing.SystemColors.ControlText
        '
        'nodeConnector1
        '
        Me.nodeConnector1.LineWidth = 5
        '
        'styleClass
        '
        Me.styleClass.BackColor2SchemePart = DevComponents.Tree.eColorSchemePart.ItemHotBackground2
        Me.styleClass.BackColorGradientAngle = 90
        Me.styleClass.BackColorSchemePart = DevComponents.Tree.eColorSchemePart.ItemHotBackground
        Me.styleClass.BorderBottom = DevComponents.Tree.eStyleBorderType.Solid
        Me.styleClass.BorderBottomWidth = 1
        Me.styleClass.BorderColorSchemePart = DevComponents.Tree.eColorSchemePart.ItemHotBorder
        Me.styleClass.BorderLeft = DevComponents.Tree.eStyleBorderType.Solid
        Me.styleClass.BorderLeftWidth = 1
        Me.styleClass.BorderRight = DevComponents.Tree.eStyleBorderType.Solid
        Me.styleClass.BorderRightWidth = 1
        Me.styleClass.BorderTop = DevComponents.Tree.eStyleBorderType.Solid
        Me.styleClass.BorderTopWidth = 1
        Me.styleClass.CornerDiameter = 4
        Me.styleClass.CornerType = DevComponents.Tree.eCornerType.Rounded
        Me.styleClass.Name = "styleClass"
        Me.styleClass.PaddingBottom = 4
        Me.styleClass.PaddingLeft = 4
        Me.styleClass.PaddingRight = 4
        Me.styleClass.PaddingTop = 4
        Me.styleClass.TextColorSchemePart = DevComponents.Tree.eColorSchemePart.ItemHotText
        '
        'panel1
        '
        Me.panel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.panel1.Controls.Add(Me.labelZoom)
        Me.panel1.Controls.Add(Me.label1)
        Me.panel1.Controls.Add(Me.trackBar1)
        Me.panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel1.Location = New System.Drawing.Point(0, 0)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(472, 32)
        Me.panel1.TabIndex = 2
        '
        'labelZoom
        '
        Me.labelZoom.Location = New System.Drawing.Point(178, 8)
        Me.labelZoom.Name = "labelZoom"
        Me.labelZoom.Size = New System.Drawing.Size(37, 15)
        Me.labelZoom.TabIndex = 2
        Me.labelZoom.Text = "100%"
        '
        'label1
        '
        Me.label1.Location = New System.Drawing.Point(143, 7)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(37, 15)
        Me.label1.TabIndex = 1
        Me.label1.Text = "Zoom: "
        '
        'trackBar1
        '
        Me.trackBar1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.trackBar1.AutoSize = False
        Me.trackBar1.LargeChange = 50
        Me.trackBar1.Location = New System.Drawing.Point(216, 4)
        Me.trackBar1.Maximum = 400
        Me.trackBar1.Minimum = 30
        Me.trackBar1.Name = "trackBar1"
        Me.trackBar1.Size = New System.Drawing.Size(252, 24)
        Me.trackBar1.SmallChange = 10
        Me.trackBar1.TabIndex = 0
        Me.trackBar1.TickStyle = System.Windows.Forms.TickStyle.None
        Me.trackBar1.Value = 100
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(472, 342)
        Me.Controls.Add(Me.treeGX1)
        Me.Controls.Add(Me.panel1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.treeGX1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel1.ResumeLayout(False)
        CType(Me.trackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadMainClass(GetType(DevComponents.Tree.TreeGX))
    End Sub

    Private m_EnumeratedTypes As Hashtable

    Private Sub LoadMainClass(ByVal rootType As Type)

        m_EnumeratedTypes = New Hashtable
        treeGX1.BeginUpdate()
        treeGX1.Nodes.Clear()
        Try
            Dim node As DevComponents.Tree.Node = New DevComponents.Tree.Node
            node.Text = GetTypeName(rootType)
            node.Expanded = True
            m_EnumeratedTypes.Add(GetTypeName(rootType), "")
            treeGX1.Nodes.Add(node)
            Dim usedClasses As Type() = GetUsedClasses(rootType)
            LoadClasses(usedClasses, node)

        Finally
            treeGX1.EndUpdate()
        End Try
        m_EnumeratedTypes.Clear()

    End Sub

    Private Function GetTypeName(ByVal type As Type) As String
        Return type.Name
    End Function

    Private Sub LoadClasses(ByVal classes As Type(), ByVal parentNode As DevComponents.Tree.Node)
        If classes.Length = 0 Then Exit Sub

        ' Load Classes first and mark them with class appearance style
        Dim t As Type
        For Each t In classes
            If t.IsClass Then
                Dim node As DevComponents.Tree.Node = New DevComponents.Tree.Node
                node.Text = GetTypeName(t)
                node.Style = styleClass
                parentNode.Nodes.Add(node)
                Dim usedClasses As Type() = GetUsedClasses(t)
                LoadClasses(usedClasses, node)
            End If
        Next

        ' Load non class types and let them have default style
        For Each t In classes
            If Not t.IsClass Then
                Dim node As DevComponents.Tree.Node = New DevComponents.Tree.Node
                node.Text = GetTypeName(t)
                parentNode.Nodes.Add(node)
                Dim usedClasses As Type() = GetUsedClasses(t)
                LoadClasses(usedClasses, node)
            End If
        Next
    End Sub

    Private Function GetUsedClasses(ByVal rootType As Type) As Type()
        Dim properties As System.Reflection.PropertyInfo() = rootType.GetProperties()
        Dim usedClasses As ArrayList = New ArrayList
        Dim prop As System.Reflection.PropertyInfo

        For Each prop In properties
            If prop.PropertyType.Namespace.IndexOf("DevComponents") >= 0 And Not m_EnumeratedTypes.ContainsKey(GetTypeName(prop.PropertyType)) Then
                usedClasses.Add(prop.PropertyType)
                m_EnumeratedTypes.Add(GetTypeName(prop.PropertyType), "")
            End If
        Next
        Return usedClasses.ToArray(GetType(Type))
    End Function

    Private Sub trackBar1_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles trackBar1.ValueChanged
        treeGX1.Zoom = trackBar1.Value / 100
        labelZoom.Text = trackBar1.Value.ToString() + "%"
    End Sub
End Class
