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
    Friend WithEvents panel1 As System.Windows.Forms.Panel
    Friend WithEvents comboLayoutType As System.Windows.Forms.ComboBox
    Friend WithEvents comboLayout As System.Windows.Forms.ComboBox
    Friend WithEvents treeGX1 As DevComponents.Tree.TreeGX
    Friend WithEvents node1 As DevComponents.Tree.Node
    Friend WithEvents node2 As DevComponents.Tree.Node
    Friend WithEvents node4 As DevComponents.Tree.Node
    Friend WithEvents node8 As DevComponents.Tree.Node
    Friend WithEvents node3 As DevComponents.Tree.Node
    Friend WithEvents node5 As DevComponents.Tree.Node
    Friend WithEvents node6 As DevComponents.Tree.Node
    Friend WithEvents node7 As DevComponents.Tree.Node
    Friend WithEvents node9 As DevComponents.Tree.Node
    Friend WithEvents nodeConnector2 As DevComponents.Tree.NodeConnector
    Friend WithEvents nodeStyle As DevComponents.Tree.ElementStyle
    Friend WithEvents nodeConnector1 As DevComponents.Tree.NodeConnector
    Friend WithEvents EmployeeCard2 As ControlHosting.EmployeeCard
    Friend WithEvents EmployeeCard3 As ControlHosting.EmployeeCard
    Friend WithEvents EmployeeCard4 As ControlHosting.EmployeeCard
    Friend WithEvents EmployeeCard5 As ControlHosting.EmployeeCard
    Friend WithEvents labelZoom As System.Windows.Forms.Label
    Friend WithEvents label1 As System.Windows.Forms.Label
    Friend WithEvents trackBar1 As System.Windows.Forms.TrackBar
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.panel1 = New System.Windows.Forms.Panel
        Me.comboLayoutType = New System.Windows.Forms.ComboBox
        Me.comboLayout = New System.Windows.Forms.ComboBox
        Me.treeGX1 = New DevComponents.Tree.TreeGX
        Me.EmployeeCard2 = New ControlHosting.EmployeeCard
        Me.EmployeeCard3 = New ControlHosting.EmployeeCard
        Me.EmployeeCard4 = New ControlHosting.EmployeeCard
        Me.EmployeeCard5 = New ControlHosting.EmployeeCard
        Me.node1 = New DevComponents.Tree.Node
        Me.node2 = New DevComponents.Tree.Node
        Me.node4 = New DevComponents.Tree.Node
        Me.node8 = New DevComponents.Tree.Node
        Me.node3 = New DevComponents.Tree.Node
        Me.node5 = New DevComponents.Tree.Node
        Me.node6 = New DevComponents.Tree.Node
        Me.node7 = New DevComponents.Tree.Node
        Me.node9 = New DevComponents.Tree.Node
        Me.nodeConnector2 = New DevComponents.Tree.NodeConnector
        Me.nodeStyle = New DevComponents.Tree.ElementStyle
        Me.nodeConnector1 = New DevComponents.Tree.NodeConnector
        Me.labelZoom = New System.Windows.Forms.Label
        Me.label1 = New System.Windows.Forms.Label
        Me.trackBar1 = New System.Windows.Forms.TrackBar
        Me.panel1.SuspendLayout()
        CType(Me.treeGX1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.trackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panel1
        '
        Me.panel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.panel1.Controls.Add(Me.labelZoom)
        Me.panel1.Controls.Add(Me.label1)
        Me.panel1.Controls.Add(Me.trackBar1)
        Me.panel1.Controls.Add(Me.comboLayoutType)
        Me.panel1.Controls.Add(Me.comboLayout)
        Me.panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel1.Location = New System.Drawing.Point(0, 0)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(680, 33)
        Me.panel1.TabIndex = 1
        '
        'comboLayoutType
        '
        Me.comboLayoutType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboLayoutType.Location = New System.Drawing.Point(192, 6)
        Me.comboLayoutType.Name = "comboLayoutType"
        Me.comboLayoutType.Size = New System.Drawing.Size(176, 21)
        Me.comboLayoutType.TabIndex = 3
        '
        'comboLayout
        '
        Me.comboLayout.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboLayout.Location = New System.Drawing.Point(5, 6)
        Me.comboLayout.Name = "comboLayout"
        Me.comboLayout.Size = New System.Drawing.Size(176, 21)
        Me.comboLayout.TabIndex = 2
        '
        'treeGX1
        '
        Me.treeGX1.AllowDrop = True
        Me.treeGX1.AutoScrollMinSize = New System.Drawing.Size(409, 132)
        Me.treeGX1.BackColor = System.Drawing.Color.White
        '
        'treeGX1.BackgroundStyle
        '
        Me.treeGX1.BackgroundStyle.BorderTop = DevComponents.Tree.eStyleBorderType.Dash
        Me.treeGX1.BackgroundStyle.BorderTopColor = System.Drawing.Color.CornflowerBlue
        Me.treeGX1.BackgroundStyle.BorderTopWidth = 1
        Me.treeGX1.CommandBackColorGradientAngle = 90
        Me.treeGX1.CommandMouseOverBackColor2SchemePart = DevComponents.Tree.eColorSchemePart.ItemHotBackground2
        Me.treeGX1.CommandMouseOverBackColorGradientAngle = 90
        Me.treeGX1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.treeGX1.ExpandLineColorSchemePart = DevComponents.Tree.eColorSchemePart.BarDockedBorder
        Me.treeGX1.Location = New System.Drawing.Point(0, 33)
        Me.treeGX1.Name = "treeGX1"
        Me.treeGX1.Nodes.AddRange(New DevComponents.Tree.Node() {Me.node1})
        Me.treeGX1.NodesConnector = Me.nodeConnector2
        Me.treeGX1.NodeStyle = Me.nodeStyle
        Me.treeGX1.PathSeparator = ";"
        Me.treeGX1.RootConnector = Me.nodeConnector1
        Me.treeGX1.Size = New System.Drawing.Size(680, 325)
        Me.treeGX1.Styles.Add(Me.nodeStyle)
        Me.treeGX1.SuspendPaint = False
        Me.treeGX1.TabIndex = 4
        Me.treeGX1.Text = "treeGX1"
        '
        'EmployeeCard2
        '
        Me.EmployeeCard2.BackColor = System.Drawing.Color.White
        Me.EmployeeCard2.EmployeeBlog = "Blog"
        Me.EmployeeCard2.EmployeeName = "Click to Expand"
        Me.EmployeeCard2.EmployeePhone = "Phone Nr"
        Me.EmployeeCard2.EmployeeTitle = "Title"
        Me.EmployeeCard2.Expanded = False
        Me.EmployeeCard2.Location = New System.Drawing.Point(358, 96)
        Me.EmployeeCard2.Name = "EmployeeCard2"
        Me.EmployeeCard2.Size = New System.Drawing.Size(112, 16)
        Me.EmployeeCard2.TabIndex = 4
        '
        'EmployeeCard3
        '
        Me.EmployeeCard3.BackColor = System.Drawing.Color.White
        Me.EmployeeCard3.EmployeeBlog = "Blog"
        Me.EmployeeCard3.EmployeeName = "Click to Expand"
        Me.EmployeeCard3.EmployeePhone = "Phone Nr"
        Me.EmployeeCard3.EmployeeTitle = "Title"
        Me.EmployeeCard3.Expanded = False
        Me.EmployeeCard3.Location = New System.Drawing.Point(514, 96)
        Me.EmployeeCard3.Name = "EmployeeCard3"
        Me.EmployeeCard3.Size = New System.Drawing.Size(103, 16)
        Me.EmployeeCard3.TabIndex = 4
        '
        'EmployeeCard4
        '
        Me.EmployeeCard4.BackColor = System.Drawing.Color.White
        Me.EmployeeCard4.EmployeeBlog = "Blog"
        Me.EmployeeCard4.EmployeeName = "Click to Expand"
        Me.EmployeeCard4.EmployeePhone = "Phone Nr"
        Me.EmployeeCard4.EmployeeTitle = "Title"
        Me.EmployeeCard4.Expanded = False
        Me.EmployeeCard4.Location = New System.Drawing.Point(441, 155)
        Me.EmployeeCard4.Name = "EmployeeCard4"
        Me.EmployeeCard4.Size = New System.Drawing.Size(97, 16)
        Me.EmployeeCard4.TabIndex = 4
        '
        'EmployeeCard5
        '
        Me.EmployeeCard5.BackColor = System.Drawing.Color.White
        Me.EmployeeCard5.EmployeeBlog = "Blog"
        Me.EmployeeCard5.EmployeeName = "Click to Expand"
        Me.EmployeeCard5.EmployeePhone = "Phone Nr"
        Me.EmployeeCard5.EmployeeTitle = "Title"
        Me.EmployeeCard5.Expanded = False
        Me.EmployeeCard5.Location = New System.Drawing.Point(441, 215)
        Me.EmployeeCard5.Name = "EmployeeCard5"
        Me.EmployeeCard5.Size = New System.Drawing.Size(87, 13)
        Me.EmployeeCard5.TabIndex = 4
        '
        'node1
        '
        Me.node1.CellPartLayout = DevComponents.Tree.eCellPartLayout.Default
        Me.node1.Expanded = True
        Me.node1.Name = "node1"
        Me.node1.Nodes.AddRange(New DevComponents.Tree.Node() {Me.node2, Me.node3, Me.node7, Me.node9})
        Me.node1.Text = "ACME Corp."
        '
        'node2
        '
        Me.node2.CellPartLayout = DevComponents.Tree.eCellPartLayout.Default
        Me.node2.Name = "node2"
        Me.node2.Nodes.AddRange(New DevComponents.Tree.Node() {Me.node4})
        Me.node2.Text = "Financial"
        '
        'node4
        '
        Me.node4.CellPartLayout = DevComponents.Tree.eCellPartLayout.Default
        Me.node4.Expanded = True
        Me.node4.HostedControl = Me.EmployeeCard2
        Me.node4.Name = "node4"
        Me.node4.Nodes.AddRange(New DevComponents.Tree.Node() {Me.node8})
        Me.node4.Text = "EmployeeCard"
        '
        'node8
        '
        Me.node8.CellPartLayout = DevComponents.Tree.eCellPartLayout.Default
        Me.node8.Expanded = True
        Me.node8.HostedControl = Me.EmployeeCard3
        Me.node8.Name = "node8"
        Me.node8.Text = "EmployeeCard"
        '
        'node3
        '
        Me.node3.CellPartLayout = DevComponents.Tree.eCellPartLayout.Default
        Me.node3.Name = "node3"
        Me.node3.Nodes.AddRange(New DevComponents.Tree.Node() {Me.node5, Me.node6})
        Me.node3.Text = "Executive"
        '
        'node5
        '
        Me.node5.CellPartLayout = DevComponents.Tree.eCellPartLayout.Default
        Me.node5.Expanded = True
        Me.node5.HostedControl = Me.EmployeeCard4
        Me.node5.Name = "node5"
        Me.node5.Text = "EmployeeCard"
        '
        'node6
        '
        Me.node6.CellPartLayout = DevComponents.Tree.eCellPartLayout.Default
        Me.node6.Expanded = True
        Me.node6.HostedControl = Me.EmployeeCard5
        Me.node6.Name = "node6"
        Me.node6.Text = "employeeCard3"
        '
        'node7
        '
        Me.node7.CellPartLayout = DevComponents.Tree.eCellPartLayout.Default
        Me.node7.Expanded = True
        Me.node7.Name = "node7"
        Me.node7.Text = "Human Resources"
        '
        'node9
        '
        Me.node9.CellPartLayout = DevComponents.Tree.eCellPartLayout.Default
        Me.node9.Expanded = True
        Me.node9.Name = "node9"
        Me.node9.Text = "Marketing"
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
        Me.nodeStyle.PaddingBottom = 5
        Me.nodeStyle.PaddingLeft = 5
        Me.nodeStyle.PaddingRight = 5
        Me.nodeStyle.PaddingTop = 5
        Me.nodeStyle.TextColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(128, Byte))
        '
        'nodeConnector1
        '
        Me.nodeConnector1.LineWidth = 5
        '
        'labelZoom
        '
        Me.labelZoom.Location = New System.Drawing.Point(402, 9)
        Me.labelZoom.Name = "labelZoom"
        Me.labelZoom.Size = New System.Drawing.Size(37, 15)
        Me.labelZoom.TabIndex = 6
        Me.labelZoom.Text = "100%"
        '
        'label1
        '
        Me.label1.Location = New System.Drawing.Point(367, 8)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(37, 15)
        Me.label1.TabIndex = 5
        Me.label1.Text = "Zoom: "
        '
        'trackBar1
        '
        Me.trackBar1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.trackBar1.AutoSize = False
        Me.trackBar1.LargeChange = 50
        Me.trackBar1.Location = New System.Drawing.Point(440, 5)
        Me.trackBar1.Maximum = 400
        Me.trackBar1.Minimum = 20
        Me.trackBar1.Name = "trackBar1"
        Me.trackBar1.Size = New System.Drawing.Size(237, 24)
        Me.trackBar1.SmallChange = 10
        Me.trackBar1.TabIndex = 4
        Me.trackBar1.TickStyle = System.Windows.Forms.TickStyle.None
        Me.trackBar1.Value = 100
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(680, 358)
        Me.Controls.Add(Me.treeGX1)
        Me.Controls.Add(Me.panel1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.panel1.ResumeLayout(False)
        CType(Me.treeGX1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.trackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    'Private Sub EmployeeCardResized(ByVal sender As Object, ByVal e As EventArgs) Handles employeeCard1.Resize, employeeCard2.Resize, employeeCard3.Resize, employeeCard4.Resize
    '    Dim node As DevComponents.Tree.Node = DevComponents.Tree.Utilites.FindNodeForControl(treeGX1, CType(sender, Control))
    '    If Not node Is Nothing Then
    '        node.SizeChanged = True
    '        treeGX1.RecalcLayout()
    '        treeGX1.Refresh()
    '    End If
    'End Sub

    Private Sub comboLayout_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles comboLayout.SelectedIndexChanged
        comboLayoutType.Items.Clear()

        If comboLayout.SelectedItem Is Nothing Then Exit Sub

        Dim layout As DevComponents.Tree.eNodeLayout = CType(System.Enum.Parse(GetType(DevComponents.Tree.eNodeLayout), comboLayout.SelectedItem.ToString()), DevComponents.Tree.eNodeLayout)

        If treeGX1.LayoutType <> Layout Then
            treeGX1.LayoutType = Layout
            treeGX1.RecalcLayout()
        End If

        If Layout = DevComponents.Tree.eNodeLayout.Map Then
            comboLayoutType.Items.AddRange(System.Enum.GetNames(GetType(DevComponents.Tree.eMapFlow)))
            comboLayoutType.SelectedItem = treeGX1.MapLayoutFlow.ToString()
        ElseIf Layout = DevComponents.Tree.eNodeLayout.Diagram Then
            comboLayoutType.Items.AddRange(System.Enum.GetNames(GetType(DevComponents.Tree.eDiagramFlow)))
            comboLayoutType.SelectedItem = treeGX1.DiagramLayoutFlow.ToString()
        End If
    End Sub

    Private Sub comboLayoutType_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles comboLayoutType.SelectedIndexChanged
        If comboLayoutType.SelectedItem Is Nothing Or comboLayout.SelectedItem Is Nothing Then Exit Sub

        Dim layout As DevComponents.Tree.eNodeLayout = CType(System.Enum.Parse(GetType(DevComponents.Tree.eNodeLayout), comboLayout.SelectedItem.ToString()), DevComponents.Tree.eNodeLayout)
        If layout = DevComponents.Tree.eNodeLayout.Map Then
            Dim mapFlow As DevComponents.Tree.eMapFlow = CType(System.Enum.Parse(GetType(DevComponents.Tree.eMapFlow), comboLayoutType.SelectedItem.ToString()), DevComponents.Tree.eMapFlow)
            If treeGX1.MapLayoutFlow <> mapFlow Then

                treeGX1.MapLayoutFlow = mapFlow
                treeGX1.RecalcLayout()
                treeGX1.Refresh()
            End If
        ElseIf layout = DevComponents.Tree.eNodeLayout.Diagram Then
            Dim diagramFlow As DevComponents.Tree.eDiagramFlow = CType(System.Enum.Parse(GetType(DevComponents.Tree.eDiagramFlow), comboLayoutType.SelectedItem.ToString()), DevComponents.Tree.eDiagramFlow)
            If treeGX1.DiagramLayoutFlow <> diagramFlow Then
                treeGX1.DiagramLayoutFlow = diagramFlow
                treeGX1.RecalcLayout()
                treeGX1.Refresh()
            End If
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Assign predefined color styles
        node9.Style = DevComponents.Tree.NodeStyles.Purple
        node7.Style = DevComponents.Tree.NodeStyles.Orange
        node2.Style = DevComponents.Tree.NodeStyles.Green
        node3.Style = DevComponents.Tree.NodeStyles.SilverMist

        comboLayout.Items.AddRange(System.Enum.GetNames(GetType(DevComponents.Tree.eNodeLayout)))
        comboLayout.SelectedItem = "Map"
    End Sub

    Private Sub trackBar1_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles trackBar1.ValueChanged
        treeGX1.Zoom = trackBar1.Value / 100
        labelZoom.Text = trackBar1.Value.ToString() + "%"
    End Sub
End Class
