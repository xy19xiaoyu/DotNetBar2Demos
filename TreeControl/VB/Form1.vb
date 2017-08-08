Imports DevComponents.DotNetBar
Imports DevComponents.AdvTree

Public Class Form1

    Dim _RightAlignFileSizeStyle As DevComponents.DotNetBar.ElementStyle

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        SetupTileView()

        'TODO: This line of code loads data into the 'CustomersDataSet.Customers' table. You can move, or remove it, as needed.
        Me.CustomersTableAdapter.Fill(Me.CustomersDataSet.Customers)
        ' This way you can disable the automatic horizontal scrolling on tree control
        DevComponents.AdvTree.AdvTreeSettings.SelectedScrollIntoViewHorizontal = False

        Dim drives As IO.DriveInfo() = IO.DriveInfo.GetDrives()
        ' Disables tree layout and display updates to optimize update
        advTree1.BeginUpdate()
        For Each di As IO.DriveInfo In drives
            If di.DriveType = IO.DriveType.Fixed Then
                Dim node As DevComponents.AdvTree.Node = New DevComponents.AdvTree.Node
                node.Tag = di
                node.Text = di.Name.Replace("\", "")
                node.Image = Global.TreeControl.My.Resources.Resources.Harddrive
                node.Cells.Add(New DevComponents.AdvTree.Cell("Local Disk"))
                node.Cells.Add(New DevComponents.AdvTree.Cell())
                advTree1.Nodes.Add(node)
                ' We will load drive content on demand
                node.ExpandVisibility = DevComponents.AdvTree.eNodeExpandVisibility.Visible
            End If
        Next
        ' Enable tree layout and display updates, performs any pending layout and display updates
        advTree1.EndUpdate()
        _RightAlignFileSizeStyle = New DevComponents.DotNetBar.ElementStyle()
        _RightAlignFileSizeStyle.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Far
    End Sub

    Private Sub SetupTileView()
        advTree6.Nodes.Clear()
        advTree6.View = eView.Tile

        ' Define group node style
        Dim groupStyle As New ElementStyle()
        groupStyle.TextColor = Color.Navy
        groupStyle.Font = New Font(advTree6.Font.FontFamily, 9.5F)
        groupStyle.Name = "groupstyle"
        advTree6.Styles.Add(groupStyle)

        ' Define sub-item style, simply to make text gray
        Dim subItemStyle As New ElementStyle()
        subItemStyle.TextColor = Color.Gray
        subItemStyle.Name = "subitemstyle"
        advTree6.Styles.Add(subItemStyle)

        Dim groupNode As New Node("Today (1)", groupStyle)
        groupNode.Expanded = True
        advTree6.Nodes.Add(groupNode)
        groupNode.Nodes.Add(CreateChildNode("Documents", "File folder", Global.TreeControl.My.Resources.Resources.Folder, subItemStyle))

        groupNode = New Node("Last week (3)", groupStyle)
        groupNode.Expanded = True
        advTree6.Nodes.Add(groupNode)
        groupNode.Nodes.Add(CreateChildNode("New Folder", "File folder", Global.TreeControl.My.Resources.Resources.Folder2, subItemStyle))
        groupNode.Nodes.Add(CreateChildNode("Vacation 2010", "File folder", Global.TreeControl.My.Resources.Resources.Folder3, subItemStyle))
        groupNode.Nodes.Add(CreateChildNode("AdvTree mockup", "Drawing file", Global.TreeControl.My.Resources.Resources.Drawing, subItemStyle))

        groupNode = New Node("Earlier this year (2)", groupStyle)
        groupNode.Expanded = True
        advTree6.Nodes.Add(groupNode)
        groupNode.Nodes.Add(CreateChildNode("Testcode", "File folder", Global.TreeControl.My.Resources.Resources.Folder2, subItemStyle))
        groupNode.Nodes.Add(CreateChildNode("Help", "File folder", Global.TreeControl.My.Resources.Resources.Folder, subItemStyle))
        groupNode.Nodes.Add(CreateChildNode("Images Backup.zip", "Compressed (zipped) folder", Global.TreeControl.My.Resources.Resources.Zip, subItemStyle))
        groupNode.Nodes.Add(CreateChildNode("Music", "Library", Global.TreeControl.My.Resources.Resources.Folder4, subItemStyle))
        groupNode.Nodes.Add(CreateChildNode("Winter 2009", "File folder", Global.TreeControl.My.Resources.Resources.Folder3, subItemStyle))


        '************************************************
        ' Setup data-bound tree with auto-grouping
        '************************************************

        ' Country group style
        groupStyle = New ElementStyle()
        groupStyle.TextColor = Color.SlateGray
        groupStyle.Font = New Font(advTree6.Font.FontFamily, 9.0F, FontStyle.Bold)
        groupStyle.Name = "groupstyle"
        advTree7.Styles.Add(groupStyle)
        ' Style for contact name
        subItemStyle = New ElementStyle()
        subItemStyle.TextColor = Color.SlateGray
        subItemStyle.Name = "subitemstyle"
        advTree7.Styles.Add(subItemStyle)
        ' Style for phone cell
        subItemStyle = New ElementStyle()
        subItemStyle.TextColor = Color.Maroon
        subItemStyle.Name = "subitemphone"
        advTree7.Styles.Add(subItemStyle)

        Dim customers As New List(Of Customer)()
        customers.AddRange(New Customer() {New Customer("Alfreds Futterkiste", "Maria Anders", "Germany", "030-0074321"), New Customer("Ana Trujillo Emparedados y helados", "Ana Trujillo", "Mexico", "(5) 555-4729"), New Customer("Antonio Moreno Taquería", "Antonio Moreno", "Mexico", "(5) 555-3932"), New Customer("Around the Horn", "Thomas Hardy", "UK", "(171) 555-7788"), New Customer("Blauer See Delikatessen", "Hanna Moos", "Germany", "0621-08460"), New Customer("Berglunds snabbköp", "Christina Berglund", "Sweden", "0921-12 34 65"), _
         New Customer("Folk och fä HB", "Maria Larsson", "Sweden", "0695-34 67 21"), New Customer("Consolidated Holdings", "Elizabeth Brown", "UK", "(171) 555-2282"), New Customer("Du monde entier", "Janine Labrune", "France", "40.67.88.88"), New Customer("Eastern Connection", "Ann Devon", "UK", "(171) 555-0297"), New Customer("Ernst Handel", "Roland Mendel", "Austria", "7675-3425"), New Customer("Familia Arquibaldo", "Aria Cruz", "Brazil", "(11) 555-9857"), _
         New Customer("Frankenversand", "Peter Franken", "Germany", "089-0877310")})
        AddHandler advTree7.GroupNodeCreated, AddressOf AdvTree7GroupNodeCreated
        AddHandler advTree7.DataNodeCreated, AddressOf AdvTree7DataNodeCreated
        advTree7.TileSize = New Size(200, 48)
        advTree7.GroupingMembers = "Country"
        advTree7.DisplayMembers = "Company,Contact,Phone"
        advTree7.DataSource = customers
    End Sub

    Private Sub AdvTree7DataNodeCreated(ByVal sender As Object, ByVal e As DevComponents.DotNetBar.Controls.DataNodeEventArgs)
        e.Node.Cells(1).StyleNormal = advTree7.Styles("subitemstyle")
        e.Node.Cells(2).StyleNormal = advTree7.Styles("subitemphone")
    End Sub
    Private Sub AdvTree7GroupNodeCreated(ByVal sender As Object, ByVal e As DevComponents.DotNetBar.Controls.DataNodeEventArgs)
        e.Node.Style = advTree7.Styles("groupstyle")
    End Sub

    Private Function CreateChildNode(ByVal nodeText As String, ByVal subText As String, ByVal image As Image, ByVal subItemStyle As ElementStyle) As Node
        Dim childNode As New Node(nodeText)
        childNode.Image = image
        childNode.Cells.Add(New Cell(subText, subItemStyle))
        Return childNode
    End Function

    Private Sub advTree1_BeforeExpand(ByVal sender As Object, ByVal e As DevComponents.AdvTree.AdvTreeNodeCancelEventArgs) Handles advTree1.BeforeExpand
        Dim parent As DevComponents.AdvTree.Node = e.Node
        If parent.Nodes.Count > 0 Then Exit Sub

        If TypeOf (parent.Tag) Is IO.DriveInfo Then
            advTree1.BeginUpdate()
            Dim driveInfo As IO.DriveInfo = CType(parent.Tag, IO.DriveInfo)
            LoadDirectories(parent, driveInfo.RootDirectory)
            parent.ExpandVisibility = DevComponents.AdvTree.eNodeExpandVisibility.Auto
            advTree1.EndUpdate(True)

        ElseIf TypeOf (parent.Tag) Is IO.DirectoryInfo Then
            LoadDirectories(parent, parent.Tag)
        End If
    End Sub

    Private Sub LoadDirectories(ByVal parent As DevComponents.AdvTree.Node, ByVal directoryInfo As IO.DirectoryInfo)
        Dim directories As IO.DirectoryInfo() = directoryInfo.GetDirectories()
        For Each dir As IO.DirectoryInfo In directories
            If (dir.Attributes & IO.FileAttributes.Hidden) <> IO.FileAttributes.Hidden Then
                Dim node As DevComponents.AdvTree.Node = New DevComponents.AdvTree.Node()
                node.Tag = dir
                node.Text = dir.Name
                node.Image = Global.TreeControl.My.Resources.Resources.FolderClosed
                node.ImageExpanded = Global.TreeControl.My.Resources.Resources.FolderOpen
                node.Cells.Add(New DevComponents.AdvTree.Cell("Local Folder"))
                node.Cells.Add(New DevComponents.AdvTree.Cell())
                node.ExpandVisibility = DevComponents.AdvTree.eNodeExpandVisibility.Visible
                parent.Nodes.Add(node)
            End If
        Next

        Dim files As IO.FileInfo() = directoryInfo.GetFiles()
        For Each file As IO.FileInfo In files
            Dim node As DevComponents.AdvTree.Node = New DevComponents.AdvTree.Node()
            node.Text = file.Name
            node.Image = Global.TreeControl.My.Resources.Resources.Document
            node.Cells.Add(New DevComponents.AdvTree.Cell("File"))
            Dim cell As DevComponents.AdvTree.Cell = New DevComponents.AdvTree.Cell(file.Length.ToString("N0"))
            cell.StyleNormal = _RightAlignFileSizeStyle
            node.Cells.Add(cell)
            parent.Nodes.Add(node)
        Next
    End Sub
End Class

#Region "Customer Class"
Friend Class Customer
    Public Sub New(ByVal company As String, ByVal contact As String, ByVal country As String, ByVal phone As String)
        Me.Company = company
        Me.Contact = contact
        Me.Country = country
        Me.Phone = phone
    End Sub
    Private _Company As String
    Public Property Company() As String
        Get
            Return _Company
        End Get
        Set(ByVal value As String)
            _Company = value
        End Set
    End Property
    Private _Contact As String
    Public Property Contact() As String
        Get
            Return _Contact
        End Get
        Set(ByVal value As String)
            _Contact = value
        End Set
    End Property
    Private _Country As String
    Public Property Country() As String
        Get
            Return _Country
        End Get
        Set(ByVal value As String)
            _Country = value
        End Set
    End Property
    Private _Phone As String
    Public Property Phone() As String
        Get
            Return _Phone
        End Get
        Set(ByVal value As String)
            _Phone = value
        End Set
    End Property
End Class
#End Region

