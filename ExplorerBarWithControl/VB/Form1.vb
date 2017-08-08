Imports DevComponents.DotNetBar
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
    Friend WithEvents ExplorerBar1 As DevComponents.DotNetBar.ExplorerBar
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.ExplorerBar1 = New DevComponents.DotNetBar.ExplorerBar()
        CType(Me.ExplorerBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ExplorerBar1
        '
        Me.ExplorerBar1.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolBar
        Me.ExplorerBar1.AnimationEnabled = False
        Me.ExplorerBar1.BackColor = System.Drawing.SystemColors.Control
        '
        'ExplorerBar1.BackStyle
        '
        Me.ExplorerBar1.BackStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.ExplorerBarBackground2
        Me.ExplorerBar1.BackStyle.BackColorGradientAngle = 90
        Me.ExplorerBar1.BackStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ExplorerBarBackground
        Me.ExplorerBar1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ExplorerBar1.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.ExplorerBar1.GroupImages = Nothing
        Me.ExplorerBar1.Images = Nothing
        Me.ExplorerBar1.Name = "ExplorerBar1"
        Me.ExplorerBar1.Size = New System.Drawing.Size(248, 366)
        Me.ExplorerBar1.StockStyle = DevComponents.DotNetBar.eExplorerBarStockStyle.SystemColors
        Me.ExplorerBar1.TabIndex = 0
        Me.ExplorerBar1.TabStop = False
        Me.ExplorerBar1.Text = "ExplorerBar1"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(248, 366)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.ExplorerBar1})
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.ExplorerBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim group As ExplorerBarGroupItem = New ExplorerBarGroupItem("group1", "Search")
        group.SetDefaultAppearance()
        ExplorerBar1.Groups.Add(group)

        Dim label As LabelItem = New LabelItem("searchLabel", "Search by any or all of the criteria below.")
        label.Stretch = True
        label.WordWrap = True
        label.Font = New Font(ExplorerBar1.Font, FontStyle.Bold)
        group.SubItems.Add(Label)

        label = New LabelItem("searchLabel1", "All or part of the file name:")
        label.Stretch = True
        label.WordWrap = True
        group.SubItems.Add(Label)

        ' Hosting Text Box on Explorer Bar
        Dim textItem As TextBoxItem = New TextBoxItem("txtFileName")
        textItem.Stretch = True
        group.SubItems.Add(textItem)

        ' Hosting Label on Explorer Bar
        label = New LabelItem("searchLabel2", "Look in:")
        label.Stretch = True
        label.WordWrap = True
        group.SubItems.Add(Label)

        ' Hosting Combo Box on Explorer Bar
        Dim combo As ComboBoxItem = New ComboBoxItem("cboLookIn")
        combo.Stretch = True
        Dim cboItem As DevComponents.Editors.ComboItem = New DevComponents.Editors.ComboItem()
        cboItem.Text = "My Computer"
        combo.Items.Add(cboItem)
        combo.SelectedIndex = 0
        group.SubItems.Add(combo)

        group.Expanded = True

        group = New ExplorerBarGroupItem("group2", "When was it modified?")
        group.SetDefaultAppearance()
        ExplorerBar1.Groups.Add(group)

        ' Hosting any .NET controls on Explorer Bar in this case RadioButton
        ' Don't remember Option
        Dim cont As ControlContainerItem = New ControlContainerItem("chk1", "Don't Remember")
        Dim option1 As RadioButton = New RadioButton()
        option1.Name = "chkDontRemember"
        option1.Text = "Don't Remember"
        option1.Font = New Font(ExplorerBar1.Font, FontStyle.Bold)
        option1.Checked = True
        option1.BackColor = Color.Transparent
        cont.Control = option1
        group.SubItems.Add(cont)

        ' Within last week
        cont = New ControlContainerItem("chk1", "Within last week")
        option1 = New RadioButton()
        option1.Name = "chkLastweek"
        option1.Text = "Within last week"
        option1.BackColor = Color.Transparent
        cont.Control = option1
        group.SubItems.Add(cont)

        ' Past month
        cont = New ControlContainerItem("chk1", "Past month")
        option1 = New RadioButton()
        option1.Name = "chkLastMonth"
        option1.Text = "Past month"
        option1.BackColor = Color.Transparent
        cont.Control = option1
        group.SubItems.Add(cont)

        ' Within the past year
        cont = New ControlContainerItem("chk1", "Within the past year")
        option1 = New RadioButton()
        option1.Name = "chkLastYear"
        option1.Text = "Within the past year"
        option1.BackColor = Color.Transparent
        cont.Control = option1
        group.SubItems.Add(cont)

        group = New ExplorerBarGroupItem("group3", "Additional Options")
        group.SetDefaultAppearance()
        ExplorerBar1.Groups.Add(group)
        group.Expanded = True

        ' Other Search Options
        Dim btn As ButtonItem = New ButtonItem("bSearchOptions", "Other search options")
        btn.HotFontUnderline = True
        btn.HotTrackingStyle = eHotTrackingStyle.None
        btn.Image = New Bitmap(Me.GetType(), "Options.png")
        btn.ImagePosition = eImagePosition.Left
        btn.ButtonStyle = eButtonStyle.ImageAndText
        btn.Cursor = Cursors.Hand
        group.SubItems.Add(btn)

        ' Change Preferences
        btn = New ButtonItem("bPreferences", "Change Preferences")
        btn.HotFontUnderline = True
        btn.HotTrackingStyle = eHotTrackingStyle.None
        btn.Image = New Bitmap(Me.GetType(), "Preferences.png")
        btn.ImagePosition = eImagePosition.Left
        btn.ButtonStyle = eButtonStyle.ImageAndText
        btn.Cursor = Cursors.Hand
        group.SubItems.Add(btn)

        ' Applies all layout changes and refreshes display
        ExplorerBar1.RecalcLayout()
    End Sub
End Class
