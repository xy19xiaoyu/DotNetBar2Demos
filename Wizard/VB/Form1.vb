Public Class Form1
    Inherits DevComponents.DotNetBar.Office2007Form

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
    Friend WithEvents Wizard1 As DevComponents.DotNetBar.Wizard
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents WizardWelcomePage As DevComponents.DotNetBar.WizardPage
    Friend WithEvents WizardProcessingPage As DevComponents.DotNetBar.WizardPage
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents WizardExePathChoicePage As DevComponents.DotNetBar.WizardPage
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents WizardFinish1Page As DevComponents.DotNetBar.WizardPage
    Friend WithEvents optionExecutionPath2 As System.Windows.Forms.RadioButton
    Friend WithEvents optionExecutionPath1 As System.Windows.Forms.RadioButton
    Friend WithEvents CheckPageSwitch As System.Windows.Forms.CheckBox
    Friend WithEvents WizardPage2 As DevComponents.DotNetBar.WizardPage
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents WizardSimpleValidationPage As DevComponents.DotNetBar.WizardPage
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
        Me.Wizard1 = New DevComponents.DotNetBar.Wizard()
        Me.WizardWelcomePage = New DevComponents.DotNetBar.WizardPage()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.WizardProcessingPage = New DevComponents.DotNetBar.WizardPage()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.WizardExePathChoicePage = New DevComponents.DotNetBar.WizardPage()
        Me.optionExecutionPath2 = New System.Windows.Forms.RadioButton()
        Me.optionExecutionPath1 = New System.Windows.Forms.RadioButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.WizardFinish1Page = New DevComponents.DotNetBar.WizardPage()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.WizardSimpleValidationPage = New DevComponents.DotNetBar.WizardPage()
        Me.CheckPageSwitch = New System.Windows.Forms.CheckBox()
        Me.WizardPage2 = New DevComponents.DotNetBar.WizardPage()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Wizard1.SuspendLayout()
        Me.WizardWelcomePage.SuspendLayout()
        Me.WizardProcessingPage.SuspendLayout()
        Me.WizardExePathChoicePage.SuspendLayout()
        Me.WizardFinish1Page.SuspendLayout()
        Me.WizardSimpleValidationPage.SuspendLayout()
        Me.WizardPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Wizard1
        '
        Me.Wizard1.BackColor = System.Drawing.Color.FromArgb(CType(205, Byte), CType(229, Byte), CType(253, Byte))
        Me.Wizard1.BackgroundImage = CType(resources.GetObject("Wizard1.BackgroundImage"), System.Drawing.Bitmap)
        Me.Wizard1.ButtonStyle = DevComponents.DotNetBar.eWizardStyle.Office2007
        Me.Wizard1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Wizard1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Wizard1.FinishButtonTabIndex = 3
        Me.Wizard1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Wizard1.FooterStyle
        '
        Me.Wizard1.FooterStyle.BackColor = System.Drawing.Color.Transparent
        Me.Wizard1.ForeColor = System.Drawing.Color.FromArgb(CType(15, Byte), CType(57, Byte), CType(129, Byte))
        Me.Wizard1.HeaderImageSize = New System.Drawing.Size(48, 48)
        '
        'Wizard1.HeaderStyle
        '
        Me.Wizard1.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(191, Byte), CType(215, Byte), CType(243, Byte))
        Me.Wizard1.HeaderStyle.BackColor2 = System.Drawing.Color.FromArgb(CType(219, Byte), CType(241, Byte), CType(254, Byte))
        Me.Wizard1.HeaderStyle.BackColorGradientAngle = 90
        Me.Wizard1.HeaderStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.Wizard1.HeaderStyle.BorderBottomColor = System.Drawing.Color.FromArgb(CType(121, Byte), CType(157, Byte), CType(182, Byte))
        Me.Wizard1.HeaderStyle.BorderBottomWidth = 1
        Me.Wizard1.Name = "Wizard1"
        Me.Wizard1.Size = New System.Drawing.Size(536, 368)
        Me.Wizard1.TabIndex = 0
        Me.Wizard1.WizardPages.AddRange(New DevComponents.DotNetBar.WizardPage() {Me.WizardWelcomePage, Me.WizardProcessingPage, Me.WizardExePathChoicePage, Me.WizardFinish1Page, Me.WizardSimpleValidationPage, Me.WizardPage2})
        '
        'WizardWelcomePage
        '
        Me.WizardWelcomePage.Anchor = (((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.WizardWelcomePage.AntiAlias = False
        Me.WizardWelcomePage.BackColor = System.Drawing.Color.Transparent
        Me.WizardWelcomePage.Controls.AddRange(New System.Windows.Forms.Control() {Me.Label1, Me.Label2, Me.Label3})
        Me.WizardWelcomePage.InteriorPage = False
        Me.WizardWelcomePage.Name = "WizardWelcomePage"
        Me.WizardWelcomePage.Size = New System.Drawing.Size(536, 322)
        Me.WizardWelcomePage.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.Anchor = ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 16.0!)
        Me.Label1.Location = New System.Drawing.Point(210, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(312, 66)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Welcome to the Wizard Control Sample Project"
        '
        'Label2
        '
        Me.Label2.Anchor = (((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(210, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(311, 190)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "This Welcome page was created automatically using Create Welcome Page command in " & _
        "design-time from Wizard control context menu or designer verbs. You can customiz" & _
        "e its appearance using the Style property on the WizardPage object."
        '
        'Label3
        '
        Me.Label3.Anchor = (System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left)
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(210, 299)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "To continue, click Next."
        '
        'WizardProcessingPage
        '
        Me.WizardProcessingPage.Anchor = (((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.WizardProcessingPage.AntiAlias = False
        Me.WizardProcessingPage.BackButtonEnabled = DevComponents.DotNetBar.eWizardButtonState.False
        Me.WizardProcessingPage.BackColor = System.Drawing.Color.Transparent
        Me.WizardProcessingPage.CancelButtonEnabled = DevComponents.DotNetBar.eWizardButtonState.False
        Me.WizardProcessingPage.Controls.AddRange(New System.Windows.Forms.Control() {Me.Label4, Me.ProgressBar1})
        Me.WizardProcessingPage.Location = New System.Drawing.Point(7, 72)
        Me.WizardProcessingPage.Name = "WizardProcessingPage"
        Me.WizardProcessingPage.NextButtonEnabled = DevComponents.DotNetBar.eWizardButtonState.False
        Me.WizardProcessingPage.PageDescription = "This page does some processing first and displays progress bar while it is doing " & _
        "the work"
        Me.WizardProcessingPage.PageTitle = "Processing Wizard Page "
        Me.WizardProcessingPage.Size = New System.Drawing.Size(522, 238)
        Me.WizardProcessingPage.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(64, 127)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(384, 16)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Please wait..."
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(64, 95)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(392, 24)
        Me.ProgressBar1.TabIndex = 0
        '
        'WizardExePathChoicePage
        '
        Me.WizardExePathChoicePage.Anchor = (((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.WizardExePathChoicePage.AntiAlias = False
        Me.WizardExePathChoicePage.BackColor = System.Drawing.Color.Transparent
        Me.WizardExePathChoicePage.Controls.AddRange(New System.Windows.Forms.Control() {Me.optionExecutionPath2, Me.optionExecutionPath1, Me.Label5})
        Me.WizardExePathChoicePage.Location = New System.Drawing.Point(7, 72)
        Me.WizardExePathChoicePage.Name = "WizardExePathChoicePage"
        Me.WizardExePathChoicePage.PageDescription = "Setup custom execution path for the Wizard"
        Me.WizardExePathChoicePage.PageTitle = "Custom Execution Path"
        Me.WizardExePathChoicePage.Size = New System.Drawing.Size(522, 238)
        Me.WizardExePathChoicePage.TabIndex = 9
        '
        'optionExecutionPath2
        '
        Me.optionExecutionPath2.Location = New System.Drawing.Point(56, 107)
        Me.optionExecutionPath2.Name = "optionExecutionPath2"
        Me.optionExecutionPath2.Size = New System.Drawing.Size(400, 24)
        Me.optionExecutionPath2.TabIndex = 2
        Me.optionExecutionPath2.Text = "Execution Path 2, has one more step and different finish page"
        '
        'optionExecutionPath1
        '
        Me.optionExecutionPath1.Checked = True
        Me.optionExecutionPath1.Location = New System.Drawing.Point(56, 72)
        Me.optionExecutionPath1.Name = "optionExecutionPath1"
        Me.optionExecutionPath1.Size = New System.Drawing.Size(408, 24)
        Me.optionExecutionPath1.TabIndex = 1
        Me.optionExecutionPath1.TabStop = True
        Me.optionExecutionPath1.Text = "Execution Path 1, ends up with the finish page after you click Next"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(32, 32)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(456, 32)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "You can have multiple wizard execution paths by manually switching page in Wizard" & _
        "PageChanging event"
        '
        'WizardFinish1Page
        '
        Me.WizardFinish1Page.Anchor = (((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.WizardFinish1Page.AntiAlias = False
        Me.WizardFinish1Page.BackColor = System.Drawing.Color.Transparent
        Me.WizardFinish1Page.Controls.AddRange(New System.Windows.Forms.Control() {Me.Label7, Me.Label6})
        Me.WizardFinish1Page.FinishButtonEnabled = DevComponents.DotNetBar.eWizardButtonState.True
        Me.WizardFinish1Page.InteriorPage = False
        Me.WizardFinish1Page.Name = "WizardFinish1Page"
        Me.WizardFinish1Page.Size = New System.Drawing.Size(536, 322)
        Me.WizardFinish1Page.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.Anchor = (System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left)
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(216, 296)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(152, 13)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "To close Wizard, click Finish."
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(16, 24)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(504, 32)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "This is Wizard Finish Page, execution Path #1"
        '
        'WizardSimpleValidationPage
        '
        Me.WizardSimpleValidationPage.Anchor = (((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.WizardSimpleValidationPage.AntiAlias = False
        Me.WizardSimpleValidationPage.BackColor = System.Drawing.Color.Transparent
        Me.WizardSimpleValidationPage.Controls.AddRange(New System.Windows.Forms.Control() {Me.CheckPageSwitch})
        Me.WizardSimpleValidationPage.Location = New System.Drawing.Point(7, 72)
        Me.WizardSimpleValidationPage.Name = "WizardSimpleValidationPage"
        Me.WizardSimpleValidationPage.NextButtonEnabled = DevComponents.DotNetBar.eWizardButtonState.False
        Me.WizardSimpleValidationPage.PageDescription = "Using just one line of code the execution path of Wizard can be changed and multi" & _
        "ple paths created"
        Me.WizardSimpleValidationPage.PageTitle = "Execution Path #2"
        Me.WizardSimpleValidationPage.Size = New System.Drawing.Size(522, 238)
        Me.WizardSimpleValidationPage.TabIndex = 11
        '
        'CheckPageSwitch
        '
        Me.CheckPageSwitch.Location = New System.Drawing.Point(56, 96)
        Me.CheckPageSwitch.Name = "CheckPageSwitch"
        Me.CheckPageSwitch.Size = New System.Drawing.Size(408, 16)
        Me.CheckPageSwitch.TabIndex = 0
        Me.CheckPageSwitch.Text = "Click this check box to enable switching to next page"
        '
        'WizardPage2
        '
        Me.WizardPage2.Anchor = (((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.WizardPage2.AntiAlias = False
        Me.WizardPage2.BackColor = System.Drawing.Color.Transparent
        Me.WizardPage2.Controls.AddRange(New System.Windows.Forms.Control() {Me.Label8, Me.Label9})
        Me.WizardPage2.InteriorPage = False
        Me.WizardPage2.Name = "WizardPage2"
        Me.WizardPage2.Size = New System.Drawing.Size(536, 322)
        Me.WizardPage2.TabIndex = 12
        '
        'Label8
        '
        Me.Label8.Anchor = (System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left)
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(216, 291)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(216, 13)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "To close Wizard, click Finish."
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(16, 19)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(504, 32)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "This is Wizard Finish Page, execution Path #2"
        '
        'Timer1
        '
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(194, Byte), CType(217, Byte), CType(247, Byte))
        Me.ClientSize = New System.Drawing.Size(536, 368)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.Wizard1})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "Sample Wizard"
        Me.Wizard1.ResumeLayout(False)
        Me.WizardWelcomePage.ResumeLayout(False)
        Me.WizardProcessingPage.ResumeLayout(False)
        Me.WizardExePathChoicePage.ResumeLayout(False)
        Me.WizardFinish1Page.ResumeLayout(False)
        Me.WizardSimpleValidationPage.ResumeLayout(False)
        Me.WizardPage2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Wizard1_CancelButtonClick(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Wizard1.CancelButtonClick
        If DevComponents.DotNetBar.MessageBoxEx.Show("Close Wizard?", "Wizard", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub Wizard1_FinishButtonClick(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Wizard1.FinishButtonClick
        ' Execute finish code for the wizard... We will just close the form
        Me.Close()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ProgressBar1.Value = ProgressBar1.Value + 5
        If ProgressBar1.Value >= 100 Then
            ' Disable timer
            Timer1.Enabled = False
            ' Allow user to click to next step
            WizardProcessingPage.NextButtonEnabled = DevComponents.DotNetBar.eWizardButtonState.Auto
            WizardProcessingPage.BackButtonEnabled = DevComponents.DotNetBar.eWizardButtonState.Auto
            WizardProcessingPage.FinishButtonEnabled = DevComponents.DotNetBar.eWizardButtonState.Auto
            WizardProcessingPage.CancelButtonEnabled = DevComponents.DotNetBar.eWizardButtonState.Auto

            Label4.Text = "Processing complete. Click Next to continue..."

            ProgressBar1.Value = 0
        End If
    End Sub

    Private Sub WizardProcessingPage_AfterPageDisplayed(ByVal sender As Object, ByVal e As DevComponents.DotNetBar.WizardPageChangeEventArgs) Handles WizardProcessingPage.AfterPageDisplayed
        ' Do not process anything if user is just stepping back
        If e.PageChangeSource = DevComponents.DotNetBar.eWizardPageChangeSource.NextButton Then
            Label4.Text = "Please Wait..."
            Timer1.Enabled = True
        End If
    End Sub

    Private Sub Wizard1_WizardPageChanging(ByVal sender As Object, ByVal e As DevComponents.DotNetBar.WizardCancelPageChangeEventArgs) Handles Wizard1.WizardPageChanging
        ' Using this event the flow of the Wizard can be changed...

        ' It is imporant to check which page was active so this is applied only after Next button is clicked on that page
        If e.OldPage Is WizardExePathChoicePage AndAlso e.PageChangeSource = DevComponents.DotNetBar.eWizardPageChangeSource.NextButton Then
            If optionExecutionPath2.Checked Then
                ' You can simply set the NewPage property to the next page you wish
                ' to display and that way change Wizard execution path...
                e.NewPage = WizardSimpleValidationPage
            End If
        End If
    End Sub

    Private Sub CheckPageSwitch_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckPageSwitch.CheckedChanged
        If CheckPageSwitch.Checked Then
            WizardSimpleValidationPage.NextButtonEnabled = DevComponents.DotNetBar.eWizardButtonState.Auto
        Else
            WizardSimpleValidationPage.NextButtonEnabled = DevComponents.DotNetBar.eWizardButtonState.False
        End If
    End Sub
End Class
