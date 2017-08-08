Public Class EmployeeCard
    Inherits System.Windows.Forms.UserControl

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        m_ExpandedHeight = Me.Height
        Me.Height = labelTitle.Height
    End Sub

    'UserControl overrides dispose to clean up the component list.
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
    Friend WithEvents labelBlog As System.Windows.Forms.Label
    Friend WithEvents labelPhone As System.Windows.Forms.Label
    Friend WithEvents labelTitle As System.Windows.Forms.Label
    Friend WithEvents pictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents labelName As System.Windows.Forms.LinkLabel
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(EmployeeCard))
        Me.labelBlog = New System.Windows.Forms.Label
        Me.labelPhone = New System.Windows.Forms.Label
        Me.labelTitle = New System.Windows.Forms.Label
        Me.pictureBox1 = New System.Windows.Forms.PictureBox
        Me.labelName = New System.Windows.Forms.LinkLabel
        Me.SuspendLayout()
        '
        'labelBlog
        '
        Me.labelBlog.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.labelBlog.Location = New System.Drawing.Point(60, 64)
        Me.labelBlog.Name = "labelBlog"
        Me.labelBlog.Size = New System.Drawing.Size(107, 16)
        Me.labelBlog.TabIndex = 9
        Me.labelBlog.Text = "Blog"
        '
        'labelPhone
        '
        Me.labelPhone.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.labelPhone.Location = New System.Drawing.Point(60, 48)
        Me.labelPhone.Name = "labelPhone"
        Me.labelPhone.Size = New System.Drawing.Size(107, 16)
        Me.labelPhone.TabIndex = 8
        Me.labelPhone.Text = "Phone Nr"
        '
        'labelTitle
        '
        Me.labelTitle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.labelTitle.Location = New System.Drawing.Point(60, 32)
        Me.labelTitle.Name = "labelTitle"
        Me.labelTitle.Size = New System.Drawing.Size(107, 16)
        Me.labelTitle.TabIndex = 7
        Me.labelTitle.Text = "Title"
        '
        'pictureBox1
        '
        Me.pictureBox1.Image = CType(resources.GetObject("pictureBox1.Image"), System.Drawing.Image)
        Me.pictureBox1.Location = New System.Drawing.Point(-4, 24)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(64, 64)
        Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pictureBox1.TabIndex = 6
        Me.pictureBox1.TabStop = False
        '
        'labelName
        '
        Me.labelName.BackColor = System.Drawing.Color.WhiteSmoke
        Me.labelName.Dock = System.Windows.Forms.DockStyle.Top
        Me.labelName.Location = New System.Drawing.Point(0, 0)
        Me.labelName.Name = "labelName"
        Me.labelName.Size = New System.Drawing.Size(163, 18)
        Me.labelName.TabIndex = 5
        Me.labelName.TabStop = True
        Me.labelName.Text = "linkLabel1"
        '
        'EmployeeCard
        '
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.labelBlog)
        Me.Controls.Add(Me.labelPhone)
        Me.Controls.Add(Me.labelTitle)
        Me.Controls.Add(Me.pictureBox1)
        Me.Controls.Add(Me.labelName)
        Me.Name = "EmployeeCard"
        Me.Size = New System.Drawing.Size(163, 88)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim m_Expanded As Boolean = False
    Dim m_ExpandedHeight As Integer = 0

    Public Property EmployeeName() As String
        Get
            Return labelName.Text
        End Get
        Set(ByVal Value As String)
            labelName.Text = Value
        End Set
    End Property

    Public Property EmployeeTitle() As String
        Get
            Return labelTitle.Text
        End Get
        Set(ByVal Value As String)
            labelTitle.Text = Value
        End Set
    End Property

    Public Property EmployeePhone() As String
        Get
            Return labelPhone.Text
        End Get
        Set(ByVal Value As String)
            labelPhone.Text = Value
        End Set
    End Property

    Public Property EmployeeBlog() As String
        Get
            Return labelBlog.Text
        End Get
        Set(ByVal Value As String)
            labelBlog.Text = Value
        End Set
    End Property

    Public Property Expanded() As Boolean
        Get
            Return m_Expanded
        End Get
        Set(ByVal Value As Boolean)
            m_Expanded = Value
            Dim size As Size = Me.Size
            If TypeOf (Me.Parent) Is DevComponents.Tree.TreeGX Then
                size = CType(Me.Parent, DevComponents.Tree.TreeGX).GetLayoutRectangle(Me.Bounds).Size
            End If

            If (m_Expanded) Then
                size.Height = m_ExpandedHeight
            Else
                size.Height = labelTitle.Height
            End If
            Me.Size = size
        End Set
    End Property

    Private Sub labelName_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles labelName.Click
        Me.Expanded = Not Me.Expanded
    End Sub
End Class
