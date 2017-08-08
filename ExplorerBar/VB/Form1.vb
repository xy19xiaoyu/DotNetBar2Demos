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
    Friend WithEvents bContacts As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents bCalendar As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents explorerBarGroupItem2 As DevComponents.DotNetBar.ExplorerBarGroupItem
    Friend WithEvents bNewMessage As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents bNewAppointment As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents bNewMeeting As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents bNewNote As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents bTasks As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents bInbox As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents imagesGroup As System.Windows.Forms.ImageList
    Friend WithEvents explorerBar1 As DevComponents.DotNetBar.ExplorerBar
    Friend WithEvents explorerBarGroupItem1 As DevComponents.DotNetBar.ExplorerBarGroupItem
    Friend WithEvents bToday As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents imagesItems As System.Windows.Forms.ImageList
    Friend WithEvents panel1 As System.Windows.Forms.Panel
    Friend WithEvents label1 As System.Windows.Forms.Label
    Friend WithEvents propertyGrid1 As System.Windows.Forms.PropertyGrid
    Friend WithEvents splitter1 As System.Windows.Forms.Splitter
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
        Me.bContacts = New DevComponents.DotNetBar.ButtonItem()
        Me.bCalendar = New DevComponents.DotNetBar.ButtonItem()
        Me.explorerBarGroupItem2 = New DevComponents.DotNetBar.ExplorerBarGroupItem()
        Me.bNewMessage = New DevComponents.DotNetBar.ButtonItem()
        Me.bNewAppointment = New DevComponents.DotNetBar.ButtonItem()
        Me.bNewMeeting = New DevComponents.DotNetBar.ButtonItem()
        Me.bNewNote = New DevComponents.DotNetBar.ButtonItem()
        Me.bTasks = New DevComponents.DotNetBar.ButtonItem()
        Me.bInbox = New DevComponents.DotNetBar.ButtonItem()
        Me.imagesGroup = New System.Windows.Forms.ImageList(Me.components)
        Me.explorerBar1 = New DevComponents.DotNetBar.ExplorerBar()
        Me.explorerBarGroupItem1 = New DevComponents.DotNetBar.ExplorerBarGroupItem()
        Me.bToday = New DevComponents.DotNetBar.ButtonItem()
        Me.imagesItems = New System.Windows.Forms.ImageList(Me.components)
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.propertyGrid1 = New System.Windows.Forms.PropertyGrid()
        Me.label1 = New System.Windows.Forms.Label()
        Me.splitter1 = New System.Windows.Forms.Splitter()
        CType(Me.explorerBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'bContacts
        '
        Me.bContacts.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.bContacts.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bContacts.ForeColor = System.Drawing.Color.FromArgb(CType(33, Byte), CType(93, Byte), CType(198, Byte))
        Me.bContacts.HotFontUnderline = True
        Me.bContacts.HotForeColor = System.Drawing.Color.FromArgb(CType(66, Byte), CType(142, Byte), CType(255, Byte))
        Me.bContacts.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.None
        Me.bContacts.ImageIndex = 3
        Me.bContacts.Name = "bContacts"
        Me.bContacts.Text = "Contacts"
        '
        'bCalendar
        '
        Me.bCalendar.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.bCalendar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bCalendar.ForeColor = System.Drawing.Color.FromArgb(CType(33, Byte), CType(93, Byte), CType(198, Byte))
        Me.bCalendar.HotFontUnderline = True
        Me.bCalendar.HotForeColor = System.Drawing.Color.FromArgb(CType(66, Byte), CType(142, Byte), CType(255, Byte))
        Me.bCalendar.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.None
        Me.bCalendar.ImageIndex = 2
        Me.bCalendar.Name = "bCalendar"
        Me.bCalendar.Text = "Calendar"
        '
        'explorerBarGroupItem2
        '
        '
        'explorerBarGroupItem2.BackStyle
        '
        Me.explorerBarGroupItem2.BackStyle.BackColor = System.Drawing.Color.FromArgb(CType(214, Byte), CType(223, Byte), CType(247, Byte))
        Me.explorerBarGroupItem2.BackStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.explorerBarGroupItem2.BackStyle.BorderBottomWidth = 1
        Me.explorerBarGroupItem2.BackStyle.BorderColor = System.Drawing.Color.White
        Me.explorerBarGroupItem2.BackStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.explorerBarGroupItem2.BackStyle.BorderLeftWidth = 1
        Me.explorerBarGroupItem2.BackStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.explorerBarGroupItem2.BackStyle.BorderRightWidth = 1
        Me.explorerBarGroupItem2.Cursor = System.Windows.Forms.Cursors.Default
        Me.explorerBarGroupItem2.Expanded = True
        Me.explorerBarGroupItem2.Name = "explorerBarGroupItem2"
        Me.explorerBarGroupItem2.StockStyle = DevComponents.DotNetBar.eExplorerBarStockStyle.SystemColors
        Me.explorerBarGroupItem2.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.bNewMessage, Me.bNewAppointment, Me.bNewMeeting, Me.bNewNote})
        Me.explorerBarGroupItem2.Text = "Tasks"
        '
        'explorerBarGroupItem2.TitleHotStyle
        '
        Me.explorerBarGroupItem2.TitleHotStyle.BackColor = System.Drawing.Color.White
        Me.explorerBarGroupItem2.TitleHotStyle.BackColor2 = System.Drawing.Color.FromArgb(CType(199, Byte), CType(211, Byte), CType(247, Byte))
        Me.explorerBarGroupItem2.TitleHotStyle.CornerDiameter = 3
        Me.explorerBarGroupItem2.TitleHotStyle.CornerTypeTopLeft = DevComponents.DotNetBar.eCornerType.Rounded
        Me.explorerBarGroupItem2.TitleHotStyle.CornerTypeTopRight = DevComponents.DotNetBar.eCornerType.Rounded
        Me.explorerBarGroupItem2.TitleHotStyle.TextColor = System.Drawing.Color.FromArgb(CType(66, Byte), CType(142, Byte), CType(255, Byte))
        '
        'explorerBarGroupItem2.TitleStyle
        '
        Me.explorerBarGroupItem2.TitleStyle.BackColor = System.Drawing.Color.White
        Me.explorerBarGroupItem2.TitleStyle.BackColor2 = System.Drawing.Color.FromArgb(CType(199, Byte), CType(211, Byte), CType(247, Byte))
        Me.explorerBarGroupItem2.TitleStyle.CornerDiameter = 3
        Me.explorerBarGroupItem2.TitleStyle.CornerTypeTopLeft = DevComponents.DotNetBar.eCornerType.Rounded
        Me.explorerBarGroupItem2.TitleStyle.CornerTypeTopRight = DevComponents.DotNetBar.eCornerType.Rounded
        Me.explorerBarGroupItem2.TitleStyle.TextColor = System.Drawing.Color.FromArgb(CType(33, Byte), CType(93, Byte), CType(198, Byte))
        '
        'bNewMessage
        '
        Me.bNewMessage.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.bNewMessage.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bNewMessage.ForeColor = System.Drawing.Color.FromArgb(CType(33, Byte), CType(93, Byte), CType(198, Byte))
        Me.bNewMessage.HotFontUnderline = True
        Me.bNewMessage.HotForeColor = System.Drawing.Color.FromArgb(CType(66, Byte), CType(142, Byte), CType(255, Byte))
        Me.bNewMessage.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.None
        Me.bNewMessage.ImageIndex = 6
        Me.bNewMessage.Name = "bNewMessage"
        Me.bNewMessage.Text = "New Mail Message"
        '
        'bNewAppointment
        '
        Me.bNewAppointment.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.bNewAppointment.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bNewAppointment.ForeColor = System.Drawing.Color.FromArgb(CType(33, Byte), CType(93, Byte), CType(198, Byte))
        Me.bNewAppointment.HotFontUnderline = True
        Me.bNewAppointment.HotForeColor = System.Drawing.Color.FromArgb(CType(66, Byte), CType(142, Byte), CType(255, Byte))
        Me.bNewAppointment.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.None
        Me.bNewAppointment.ImageIndex = 5
        Me.bNewAppointment.Name = "bNewAppointment"
        Me.bNewAppointment.Text = "New Appointment"
        '
        'bNewMeeting
        '
        Me.bNewMeeting.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.bNewMeeting.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bNewMeeting.ForeColor = System.Drawing.Color.FromArgb(CType(33, Byte), CType(93, Byte), CType(198, Byte))
        Me.bNewMeeting.HotFontUnderline = True
        Me.bNewMeeting.HotForeColor = System.Drawing.Color.FromArgb(CType(66, Byte), CType(142, Byte), CType(255, Byte))
        Me.bNewMeeting.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.None
        Me.bNewMeeting.ImageIndex = 7
        Me.bNewMeeting.Name = "bNewMeeting"
        Me.bNewMeeting.Text = "New Meeting Request"
        '
        'bNewNote
        '
        Me.bNewNote.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.bNewNote.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bNewNote.ForeColor = System.Drawing.Color.FromArgb(CType(33, Byte), CType(93, Byte), CType(198, Byte))
        Me.bNewNote.HotFontUnderline = True
        Me.bNewNote.HotForeColor = System.Drawing.Color.FromArgb(CType(66, Byte), CType(142, Byte), CType(255, Byte))
        Me.bNewNote.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.None
        Me.bNewNote.ImageIndex = 8
        Me.bNewNote.Name = "bNewNote"
        Me.bNewNote.Text = "New Note"
        '
        'bTasks
        '
        Me.bTasks.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.bTasks.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bTasks.ForeColor = System.Drawing.Color.FromArgb(CType(33, Byte), CType(93, Byte), CType(198, Byte))
        Me.bTasks.HotFontUnderline = True
        Me.bTasks.HotForeColor = System.Drawing.Color.FromArgb(CType(66, Byte), CType(142, Byte), CType(255, Byte))
        Me.bTasks.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.None
        Me.bTasks.ImageIndex = 4
        Me.bTasks.Name = "bTasks"
        Me.bTasks.Text = "Tasks"
        '
        'bInbox
        '
        Me.bInbox.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.bInbox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bInbox.ForeColor = System.Drawing.Color.FromArgb(CType(33, Byte), CType(93, Byte), CType(198, Byte))
        Me.bInbox.HotFontUnderline = True
        Me.bInbox.HotForeColor = System.Drawing.Color.FromArgb(CType(66, Byte), CType(142, Byte), CType(255, Byte))
        Me.bInbox.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.None
        Me.bInbox.ImageIndex = 1
        Me.bInbox.Name = "bInbox"
        Me.bInbox.Text = "Inbox"
        '
        'imagesGroup
        '
        Me.imagesGroup.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.imagesGroup.ImageSize = New System.Drawing.Size(24, 24)
        Me.imagesGroup.ImageStream = CType(resources.GetObject("imagesGroup.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imagesGroup.TransparentColor = System.Drawing.Color.Transparent
        '
        'explorerBar1
        '
        Me.explorerBar1.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolBar
        Me.explorerBar1.BackColor = System.Drawing.SystemColors.Control
        '
        'explorerBar1.BackStyle
        '
        Me.explorerBar1.BackStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.ExplorerBarBackground2
        Me.explorerBar1.BackStyle.BackColorGradientAngle = 90
        Me.explorerBar1.BackStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ExplorerBarBackground
        Me.explorerBar1.Dock = System.Windows.Forms.DockStyle.Left
        Me.explorerBar1.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.explorerBar1.GroupImages = Me.imagesGroup
        Me.explorerBar1.Groups.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.explorerBarGroupItem1, Me.explorerBarGroupItem2})
        Me.explorerBar1.Images = Me.imagesItems
        Me.explorerBar1.Name = "explorerBar1"
        Me.explorerBar1.Size = New System.Drawing.Size(168, 310)
        Me.explorerBar1.StockStyle = DevComponents.DotNetBar.eExplorerBarStockStyle.SystemColors
        Me.explorerBar1.TabIndex = 4
        Me.explorerBar1.TabStop = False
        Me.explorerBar1.Text = "explorerBar1"
        Me.explorerBar1.ThemeAware = True
        '
        'explorerBarGroupItem1
        '
        '
        'explorerBarGroupItem1.BackStyle
        '
        Me.explorerBarGroupItem1.BackStyle.BackColor = System.Drawing.Color.FromArgb(CType(239, Byte), CType(243, Byte), CType(255, Byte))
        Me.explorerBarGroupItem1.BackStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.explorerBarGroupItem1.BackStyle.BorderBottomWidth = 1
        Me.explorerBarGroupItem1.BackStyle.BorderColor = System.Drawing.Color.White
        Me.explorerBarGroupItem1.BackStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.explorerBarGroupItem1.BackStyle.BorderLeftWidth = 1
        Me.explorerBarGroupItem1.BackStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.explorerBarGroupItem1.BackStyle.BorderRightWidth = 1
        Me.explorerBarGroupItem1.Cursor = System.Windows.Forms.Cursors.Default
        Me.explorerBarGroupItem1.Expanded = True
        Me.explorerBarGroupItem1.Image = CType(resources.GetObject("explorerBarGroupItem1.Image"), System.Drawing.Bitmap)
        Me.explorerBarGroupItem1.Name = "explorerBarGroupItem1"
        Me.explorerBarGroupItem1.StockStyle = DevComponents.DotNetBar.eExplorerBarStockStyle.SystemColors
        Me.explorerBarGroupItem1.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.bToday, Me.bInbox, Me.bCalendar, Me.bContacts, Me.bTasks})
        Me.explorerBarGroupItem1.Text = "Shortcuts"
        '
        'explorerBarGroupItem1.TitleHotStyle
        '
        Me.explorerBarGroupItem1.TitleHotStyle.BackColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(73, Byte), CType(181, Byte))
        Me.explorerBarGroupItem1.TitleHotStyle.BackColor2 = System.Drawing.Color.FromArgb(CType(41, Byte), CType(93, Byte), CType(206, Byte))
        Me.explorerBarGroupItem1.TitleHotStyle.CornerDiameter = 3
        Me.explorerBarGroupItem1.TitleHotStyle.CornerTypeTopLeft = DevComponents.DotNetBar.eCornerType.Rounded
        Me.explorerBarGroupItem1.TitleHotStyle.CornerTypeTopRight = DevComponents.DotNetBar.eCornerType.Rounded
        Me.explorerBarGroupItem1.TitleHotStyle.TextColor = System.Drawing.Color.FromArgb(CType(66, Byte), CType(142, Byte), CType(255, Byte))
        '
        'explorerBarGroupItem1.TitleStyle
        '
        Me.explorerBarGroupItem1.TitleStyle.BackColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(73, Byte), CType(181, Byte))
        Me.explorerBarGroupItem1.TitleStyle.BackColor2 = System.Drawing.Color.FromArgb(CType(41, Byte), CType(93, Byte), CType(206, Byte))
        Me.explorerBarGroupItem1.TitleStyle.CornerDiameter = 3
        Me.explorerBarGroupItem1.TitleStyle.CornerTypeTopLeft = DevComponents.DotNetBar.eCornerType.Rounded
        Me.explorerBarGroupItem1.TitleStyle.CornerTypeTopRight = DevComponents.DotNetBar.eCornerType.Rounded
        Me.explorerBarGroupItem1.TitleStyle.TextColor = System.Drawing.Color.White
        Me.explorerBarGroupItem1.XPSpecialGroup = True
        '
        'bToday
        '
        Me.bToday.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.bToday.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bToday.ForeColor = System.Drawing.Color.FromArgb(CType(33, Byte), CType(93, Byte), CType(198, Byte))
        Me.bToday.HotFontUnderline = True
        Me.bToday.HotForeColor = System.Drawing.Color.FromArgb(CType(66, Byte), CType(142, Byte), CType(255, Byte))
        Me.bToday.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.None
        Me.bToday.ImageIndex = 0
        Me.bToday.Name = "bToday"
        Me.bToday.Text = "Today"
        '
        'imagesItems
        '
        Me.imagesItems.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.imagesItems.ImageSize = New System.Drawing.Size(16, 16)
        Me.imagesItems.ImageStream = CType(resources.GetObject("imagesItems.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imagesItems.TransparentColor = System.Drawing.Color.Magenta
        '
        'panel1
        '
        Me.panel1.Controls.AddRange(New System.Windows.Forms.Control() {Me.propertyGrid1, Me.label1})
        Me.panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel1.Location = New System.Drawing.Point(168, 0)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(352, 310)
        Me.panel1.TabIndex = 6
        '
        'propertyGrid1
        '
        Me.propertyGrid1.CommandsVisibleIfAvailable = True
        Me.propertyGrid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.propertyGrid1.LargeButtons = False
        Me.propertyGrid1.LineColor = System.Drawing.SystemColors.ScrollBar
        Me.propertyGrid1.Location = New System.Drawing.Point(0, 32)
        Me.propertyGrid1.Name = "propertyGrid1"
        Me.propertyGrid1.Size = New System.Drawing.Size(352, 278)
        Me.propertyGrid1.TabIndex = 2
        Me.propertyGrid1.Text = "propertyGrid1"
        Me.propertyGrid1.ViewBackColor = System.Drawing.SystemColors.Window
        Me.propertyGrid1.ViewForeColor = System.Drawing.SystemColors.WindowText
        '
        'label1
        '
        Me.label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(352, 32)
        Me.label1.TabIndex = 3
        Me.label1.Text = "Click on Explorer Bar item to view its properties"
        Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'splitter1
        '
        Me.splitter1.BackColor = System.Drawing.Color.RoyalBlue
        Me.splitter1.Location = New System.Drawing.Point(168, 0)
        Me.splitter1.Name = "splitter1"
        Me.splitter1.Size = New System.Drawing.Size(3, 310)
        Me.splitter1.TabIndex = 5
        Me.splitter1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(520, 310)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.splitter1, Me.panel1, Me.explorerBar1})
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.explorerBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub splitter1_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles splitter1.MouseEnter
        splitter1.BackColor = Color.MidnightBlue
    End Sub

    Private Sub splitter1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles splitter1.MouseLeave
        splitter1.BackColor = Color.RoyalBlue
    End Sub

    Private Sub explorerBar1_ItemClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles explorerBar1.ItemClick
        If TypeOf sender Is DevComponents.DotNetBar.BaseItem Then
            propertyGrid1.SelectedObject = sender
        Else
            propertyGrid1.SelectedObject = Nothing
        End If
    End Sub

    Private Sub propertyGrid1_PropertyValueChanged(ByVal s As Object, ByVal e As System.Windows.Forms.PropertyValueChangedEventArgs) Handles propertyGrid1.PropertyValueChanged
        explorerBar1.RecalcLayout()
    End Sub
End Class
