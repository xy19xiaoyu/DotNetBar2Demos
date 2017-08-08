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
    Friend WithEvents balloonTipFocus As DevComponents.DotNetBar.BalloonTip
    Friend WithEvents timer1 As System.Windows.Forms.Timer
    Friend WithEvents balloonTipHover As DevComponents.DotNetBar.BalloonTip
    Friend WithEvents button2 As System.Windows.Forms.Button
    Friend WithEvents groupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents button1 As System.Windows.Forms.Button
    Friend WithEvents textBox3 As System.Windows.Forms.TextBox
    Friend WithEvents label3 As System.Windows.Forms.Label
    Friend WithEvents textBox2 As System.Windows.Forms.TextBox
    Friend WithEvents label2 As System.Windows.Forms.Label
    Friend WithEvents textBox1 As System.Windows.Forms.TextBox
    Friend WithEvents label1 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
        Me.balloonTipFocus = New DevComponents.DotNetBar.BalloonTip()
        Me.textBox3 = New System.Windows.Forms.TextBox()
        Me.textBox2 = New System.Windows.Forms.TextBox()
        Me.textBox1 = New System.Windows.Forms.TextBox()
        Me.timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.balloonTipHover = New DevComponents.DotNetBar.BalloonTip()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.button1 = New System.Windows.Forms.Button()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.button2 = New System.Windows.Forms.Button()
        Me.groupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'balloonTipFocus
        '
        Me.balloonTipFocus.AutoCloseTimeOut = 3
        Me.balloonTipFocus.CaptionImage = CType(resources.GetObject("balloonTipFocus.CaptionImage"), System.Drawing.Bitmap)
        Me.balloonTipFocus.Enabled = False
        Me.balloonTipFocus.ShowBalloonOnFocus = True
        '
        'textBox3
        '
        Me.balloonTipFocus.SetBalloonCaption(Me.textBox3, "Balloon Information displayed on focus")
        Me.balloonTipFocus.SetBalloonText(Me.textBox3, "Enter email address of contact person, required.")
        Me.textBox3.Location = New System.Drawing.Point(16, 136)
        Me.textBox3.Name = "textBox3"
        Me.textBox3.Size = New System.Drawing.Size(176, 20)
        Me.textBox3.TabIndex = 7
        Me.textBox3.Text = ""
        '
        'textBox2
        '
        Me.balloonTipFocus.SetBalloonCaption(Me.textBox2, "Balloon Information displayed on focus")
        Me.balloonTipFocus.SetBalloonText(Me.textBox2, "Enter last name of contact person, required.")
        Me.textBox2.Location = New System.Drawing.Point(16, 88)
        Me.textBox2.Name = "textBox2"
        Me.textBox2.Size = New System.Drawing.Size(176, 20)
        Me.textBox2.TabIndex = 5
        Me.textBox2.Text = ""
        '
        'textBox1
        '
        Me.balloonTipFocus.SetBalloonCaption(Me.textBox1, "Balloon Information displayed on focus")
        Me.balloonTipFocus.SetBalloonText(Me.textBox1, "Enter first name of contact person, required.")
        Me.textBox1.Location = New System.Drawing.Point(16, 40)
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(176, 20)
        Me.textBox1.TabIndex = 3
        Me.textBox1.Text = ""
        '
        'timer1
        '
        Me.timer1.Enabled = True
        Me.timer1.Interval = 1000
        '
        'balloonTipHover
        '
        Me.balloonTipHover.AutoCloseTimeOut = 4
        Me.balloonTipHover.CaptionImage = CType(resources.GetObject("balloonTipHover.CaptionImage"), System.Drawing.Bitmap)
        Me.balloonTipHover.Enabled = False
        Me.balloonTipHover.ShowCloseButton = False
        '
        'groupBox1
        '
        Me.balloonTipHover.SetBalloonCaption(Me.groupBox1, "Custom Positioned Balloon Information")
        Me.balloonTipHover.SetBalloonText(Me.groupBox1, "All controls in this group will display the Balloon tip once they gain input focu" & _
        "s. Simply tab through the controls or set the focus using the mouse to display m" & _
        "ore information about control that has focus.")
        Me.groupBox1.Controls.AddRange(New System.Windows.Forms.Control() {Me.button1, Me.textBox3, Me.label3, Me.textBox2, Me.label2, Me.textBox1, Me.label1})
        Me.groupBox1.Location = New System.Drawing.Point(42, 9)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(208, 208)
        Me.groupBox1.TabIndex = 6
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Balloon Tip Test Area"
        '
        'button1
        '
        Me.balloonTipHover.SetBalloonCaption(Me.button1, "Balloon information displayed on mouse hover")
        Me.balloonTipHover.SetBalloonText(Me.button1, "Click to save the data entered on this page.")
        Me.button1.Location = New System.Drawing.Point(16, 168)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(80, 24)
        Me.button1.TabIndex = 8
        Me.button1.Text = "Save"
        '
        'label3
        '
        Me.label3.Location = New System.Drawing.Point(16, 120)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(100, 16)
        Me.label3.TabIndex = 6
        Me.label3.Text = "E-Mail Address:"
        '
        'label2
        '
        Me.label2.Location = New System.Drawing.Point(16, 72)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(100, 16)
        Me.label2.TabIndex = 4
        Me.label2.Text = "Last Name:"
        '
        'label1
        '
        Me.label1.Location = New System.Drawing.Point(16, 24)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(100, 16)
        Me.label1.TabIndex = 2
        Me.label1.Text = "First Name:"
        '
        'button2
        '
        Me.button2.Location = New System.Drawing.Point(42, 225)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(112, 32)
        Me.button2.TabIndex = 7
        Me.button2.Text = "Enable Balloons"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(292, 266)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.button2, Me.groupBox1})
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Balloon and BalloonTip Sample"
        Me.groupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim m_AlertOnLoad As DevComponents.DotNetBar.Balloon

    Private Sub button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button2.Click
        balloonTipFocus.Enabled = True
        balloonTipHover.Enabled = True

        Dim b As DevComponents.DotNetBar.Balloon = New DevComponents.DotNetBar.Balloon()
        b.Style = eBallonStyle.Alert
        b.CaptionImage = CType(balloonTipFocus.CaptionImage.Clone(), Image)
        b.CaptionText = "Balloon Status Information"
        b.Text = "Balloons are now enabled for Balloon Tip Test area. Hover mouse over the area and set the focus to any control."
        b.AlertAnimation = eAlertAnimation.TopToBottom
        b.AutoResize()
        b.AutoClose = True
        b.AutoCloseTimeOut = 4
        b.Owner = Me
        b.Show(button2, False)
    End Sub

    Private Sub timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timer1.Tick
        timer1.Stop()
        timer1.Enabled = False
        ShowLoadAlert()
    End Sub

    Private Sub ShowLoadAlert()
        m_AlertOnLoad = New AlertCustom()
        Dim r As Rectangle = Screen.GetWorkingArea(Me)
        m_AlertOnLoad.Location = New Point(r.Right - m_AlertOnLoad.Width, r.Bottom - m_AlertOnLoad.Height)
        m_AlertOnLoad.AutoClose = True
        m_AlertOnLoad.AutoCloseTimeOut = 15
        m_AlertOnLoad.AlertAnimation = eAlertAnimation.BottomToTop
        m_AlertOnLoad.AlertAnimationDuration = 300
        m_AlertOnLoad.Show(False)
    End Sub

    Private Sub balloonTipHover_BalloonDisplaying(ByVal sender As Object, ByVal e As System.EventArgs) Handles balloonTipHover.BalloonDisplaying
        ' BalloonTriggerControl property returns control that invoked balloon
        If balloonTipHover.BalloonTriggerControl Is groupBox1 Then
            ' BalloonControl is already prepared Balloon control that is just about to be displayed
            ' Setting BalloonControl to null will cancel balloon display
            Dim p As Point = Control.MousePosition
            ' Adjust cursor position so cursor is below tip
            p.Offset(-balloonTipHover.BalloonControl.TipOffset, balloonTipHover.BalloonControl.TipLength + 4)
            balloonTipHover.BalloonControl.Location = p
        End If
    End Sub
End Class
