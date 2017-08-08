<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits DevComponents.DotNetBar.Office2007Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.regularExpressionValidator2 = New DevComponents.DotNetBar.Validator.RegularExpressionValidator
        Me.linkLabel1 = New System.Windows.Forms.LinkLabel
        Me.compareValidator1 = New DevComponents.DotNetBar.Validator.CompareValidator
        Me.tbPassword = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.regularExpressionValidator1 = New DevComponents.DotNetBar.Validator.RegularExpressionValidator
        Me.superValidator1 = New DevComponents.DotNetBar.Validator.SuperValidator
        Me.errorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.highlighter1 = New DevComponents.DotNetBar.Validator.Highlighter
        Me.tbPasswordConfirm = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.textBoxX4 = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.textBoxX3 = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.textBoxX2 = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.requiredFieldValidator2 = New DevComponents.DotNetBar.Validator.RequiredFieldValidator("Last name is required.")
        Me.textBoxX1 = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.requiredFieldValidator1 = New DevComponents.DotNetBar.Validator.RequiredFieldValidator("First Name is required.")
        Me.buttonX2 = New DevComponents.DotNetBar.ButtonX
        Me.buttonX1 = New DevComponents.DotNetBar.ButtonX
        Me.labelX6 = New DevComponents.DotNetBar.LabelX
        Me.labelX5 = New DevComponents.DotNetBar.LabelX
        Me.labelX4 = New DevComponents.DotNetBar.LabelX
        Me.labelX3 = New DevComponents.DotNetBar.LabelX
        Me.labelX2 = New DevComponents.DotNetBar.LabelX
        Me.labelX1 = New DevComponents.DotNetBar.LabelX
        CType(Me.errorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'regularExpressionValidator2
        '
        Me.regularExpressionValidator2.EmptyValueIsValid = True
        Me.regularExpressionValidator2.ErrorMessage = "Please enter correct email address name@domain.com"
        Me.regularExpressionValidator2.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red
        Me.regularExpressionValidator2.ValidationExpression = "^([0-9a-zA-Z]([-\.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9" & _
            "})$"
        '
        'linkLabel1
        '
        Me.linkLabel1.AutoSize = True
        Me.linkLabel1.BackColor = System.Drawing.Color.Transparent
        Me.linkLabel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.linkLabel1.Location = New System.Drawing.Point(0, 221)
        Me.linkLabel1.Name = "linkLabel1"
        Me.linkLabel1.Padding = New System.Windows.Forms.Padding(0, 0, 0, 3)
        Me.linkLabel1.Size = New System.Drawing.Size(121, 16)
        Me.linkLabel1.TabIndex = 29
        Me.linkLabel1.TabStop = True
        Me.linkLabel1.Text = "All About SuperValidator"
        '
        'compareValidator1
        '
        Me.compareValidator1.ControlToCompare = Me.tbPassword
        Me.compareValidator1.ErrorMessage = "Confirmation password not the same as password."
        Me.compareValidator1.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red
        '
        'tbPassword
        '
        '
        '
        '
        Me.tbPassword.Border.Class = "TextBoxBorder"
        Me.tbPassword.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbPassword.Location = New System.Drawing.Point(69, 131)
        Me.tbPassword.Name = "tbPassword"
        Me.tbPassword.Size = New System.Drawing.Size(166, 20)
        Me.tbPassword.TabIndex = 24
        '
        'regularExpressionValidator1
        '
        Me.regularExpressionValidator1.EmptyValueIsValid = True
        Me.regularExpressionValidator1.ErrorMessage = "Please enter phone number in (555) 555-5555 format."
        Me.regularExpressionValidator1.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red
        Me.regularExpressionValidator1.ValidationExpression = "^[01]?[- .]?(\([2-9]\d{2}\)|[2-9]\d{2})[- .]?\d{3}[- .]?\d{4}$"
        '
        'superValidator1
        '
        Me.superValidator1.ContainerControl = Me
        Me.superValidator1.ErrorProvider = Me.errorProvider1
        Me.superValidator1.Highlighter = Me.highlighter1
        Me.superValidator1.ValidationType = DevComponents.DotNetBar.Validator.eValidationType.ValidatingEventPerControl
        '
        'errorProvider1
        '
        Me.errorProvider1.ContainerControl = Me
        Me.errorProvider1.Icon = CType(resources.GetObject("errorProvider1.Icon"), System.Drawing.Icon)
        '
        'highlighter1
        '
        Me.highlighter1.ContainerControl = Me
        '
        'tbPasswordConfirm
        '
        '
        '
        '
        Me.tbPasswordConfirm.Border.Class = "TextBoxBorder"
        Me.tbPasswordConfirm.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbPasswordConfirm.Location = New System.Drawing.Point(69, 154)
        Me.tbPasswordConfirm.Name = "tbPasswordConfirm"
        Me.tbPasswordConfirm.Size = New System.Drawing.Size(166, 20)
        Me.tbPasswordConfirm.TabIndex = 26
        Me.superValidator1.SetValidator1(Me.tbPasswordConfirm, Me.compareValidator1)
        '
        'textBoxX4
        '
        '
        '
        '
        Me.textBoxX4.Border.Class = "TextBoxBorder"
        Me.textBoxX4.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.textBoxX4.Location = New System.Drawing.Point(69, 95)
        Me.textBoxX4.Name = "textBoxX4"
        Me.textBoxX4.Size = New System.Drawing.Size(166, 20)
        Me.textBoxX4.TabIndex = 22
        Me.superValidator1.SetValidator1(Me.textBoxX4, Me.regularExpressionValidator2)
        '
        'textBoxX3
        '
        '
        '
        '
        Me.textBoxX3.Border.Class = "TextBoxBorder"
        Me.textBoxX3.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.textBoxX3.Location = New System.Drawing.Point(69, 67)
        Me.textBoxX3.Name = "textBoxX3"
        Me.textBoxX3.Size = New System.Drawing.Size(166, 20)
        Me.textBoxX3.TabIndex = 20
        Me.superValidator1.SetValidator1(Me.textBoxX3, Me.regularExpressionValidator1)
        '
        'textBoxX2
        '
        '
        '
        '
        Me.textBoxX2.Border.Class = "TextBoxBorder"
        Me.textBoxX2.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.textBoxX2.Location = New System.Drawing.Point(69, 38)
        Me.textBoxX2.Name = "textBoxX2"
        Me.textBoxX2.Size = New System.Drawing.Size(166, 20)
        Me.textBoxX2.TabIndex = 18
        Me.superValidator1.SetValidator1(Me.textBoxX2, Me.requiredFieldValidator2)
        '
        'requiredFieldValidator2
        '
        Me.requiredFieldValidator2.ErrorMessage = "Last name is required."
        Me.requiredFieldValidator2.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red
        '
        'textBoxX1
        '
        '
        '
        '
        Me.textBoxX1.Border.Class = "TextBoxBorder"
        Me.textBoxX1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.textBoxX1.Location = New System.Drawing.Point(69, 9)
        Me.textBoxX1.Name = "textBoxX1"
        Me.textBoxX1.Size = New System.Drawing.Size(166, 20)
        Me.textBoxX1.TabIndex = 16
        Me.superValidator1.SetValidator1(Me.textBoxX1, Me.requiredFieldValidator1)
        '
        'requiredFieldValidator1
        '
        Me.requiredFieldValidator1.ErrorMessage = "First Name is required."
        Me.requiredFieldValidator1.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red
        '
        'buttonX2
        '
        Me.buttonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.buttonX2.CausesValidation = False
        Me.buttonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.buttonX2.Location = New System.Drawing.Point(160, 193)
        Me.buttonX2.Name = "buttonX2"
        Me.buttonX2.Size = New System.Drawing.Size(75, 23)
        Me.buttonX2.TabIndex = 28
        Me.buttonX2.Text = "Cancel"
        '
        'buttonX1
        '
        Me.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.buttonX1.Location = New System.Drawing.Point(79, 193)
        Me.buttonX1.Name = "buttonX1"
        Me.buttonX1.Size = New System.Drawing.Size(75, 23)
        Me.buttonX1.TabIndex = 27
        Me.buttonX1.Text = "OK"
        '
        'labelX6
        '
        '
        '
        '
        Me.labelX6.BackgroundStyle.Class = ""
        Me.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.labelX6.Location = New System.Drawing.Point(1, 151)
        Me.labelX6.Name = "labelX6"
        Me.labelX6.Size = New System.Drawing.Size(62, 23)
        Me.labelX6.TabIndex = 25
        Me.labelX6.Text = "Confirm:"
        Me.labelX6.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'labelX5
        '
        '
        '
        '
        Me.labelX5.BackgroundStyle.Class = ""
        Me.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.labelX5.Location = New System.Drawing.Point(1, 128)
        Me.labelX5.Name = "labelX5"
        Me.labelX5.Size = New System.Drawing.Size(62, 23)
        Me.labelX5.TabIndex = 23
        Me.labelX5.Text = "Password:"
        Me.labelX5.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'labelX4
        '
        '
        '
        '
        Me.labelX4.BackgroundStyle.Class = ""
        Me.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.labelX4.Location = New System.Drawing.Point(1, 92)
        Me.labelX4.Name = "labelX4"
        Me.labelX4.Size = New System.Drawing.Size(62, 23)
        Me.labelX4.TabIndex = 21
        Me.labelX4.Text = "E-Mail:"
        Me.labelX4.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'labelX3
        '
        '
        '
        '
        Me.labelX3.BackgroundStyle.Class = ""
        Me.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.labelX3.Location = New System.Drawing.Point(1, 64)
        Me.labelX3.Name = "labelX3"
        Me.labelX3.Size = New System.Drawing.Size(62, 23)
        Me.labelX3.TabIndex = 19
        Me.labelX3.Text = "Phone:"
        Me.labelX3.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'labelX2
        '
        '
        '
        '
        Me.labelX2.BackgroundStyle.Class = ""
        Me.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.labelX2.Location = New System.Drawing.Point(1, 35)
        Me.labelX2.Name = "labelX2"
        Me.labelX2.Size = New System.Drawing.Size(62, 23)
        Me.labelX2.TabIndex = 17
        Me.labelX2.Text = "Last Name:"
        Me.labelX2.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'labelX1
        '
        '
        '
        '
        Me.labelX1.BackgroundStyle.Class = ""
        Me.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.labelX1.Location = New System.Drawing.Point(1, 6)
        Me.labelX1.Name = "labelX1"
        Me.labelX1.Size = New System.Drawing.Size(62, 23)
        Me.labelX1.TabIndex = 15
        Me.labelX1.Text = "First Name:"
        Me.labelX1.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(257, 237)
        Me.Controls.Add(Me.linkLabel1)
        Me.Controls.Add(Me.buttonX2)
        Me.Controls.Add(Me.buttonX1)
        Me.Controls.Add(Me.tbPasswordConfirm)
        Me.Controls.Add(Me.labelX6)
        Me.Controls.Add(Me.tbPassword)
        Me.Controls.Add(Me.labelX5)
        Me.Controls.Add(Me.textBoxX4)
        Me.Controls.Add(Me.labelX4)
        Me.Controls.Add(Me.textBoxX3)
        Me.Controls.Add(Me.textBoxX2)
        Me.Controls.Add(Me.textBoxX1)
        Me.Controls.Add(Me.labelX3)
        Me.Controls.Add(Me.labelX2)
        Me.Controls.Add(Me.labelX1)
        Me.DoubleBuffered = True
        Me.EnableGlass = False
        Me.Name = "Form1"
        Me.Text = "SuperValidator"
        CType(Me.errorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents regularExpressionValidator2 As DevComponents.DotNetBar.Validator.RegularExpressionValidator
    Private WithEvents linkLabel1 As System.Windows.Forms.LinkLabel
    Private WithEvents compareValidator1 As DevComponents.DotNetBar.Validator.CompareValidator
    Private WithEvents tbPassword As DevComponents.DotNetBar.Controls.TextBoxX
    Private WithEvents regularExpressionValidator1 As DevComponents.DotNetBar.Validator.RegularExpressionValidator
    Private WithEvents superValidator1 As DevComponents.DotNetBar.Validator.SuperValidator
    Private WithEvents buttonX2 As DevComponents.DotNetBar.ButtonX
    Private WithEvents buttonX1 As DevComponents.DotNetBar.ButtonX
    Private WithEvents tbPasswordConfirm As DevComponents.DotNetBar.Controls.TextBoxX
    Private WithEvents labelX6 As DevComponents.DotNetBar.LabelX
    Private WithEvents labelX5 As DevComponents.DotNetBar.LabelX
    Private WithEvents textBoxX4 As DevComponents.DotNetBar.Controls.TextBoxX
    Private WithEvents labelX4 As DevComponents.DotNetBar.LabelX
    Private WithEvents textBoxX3 As DevComponents.DotNetBar.Controls.TextBoxX
    Private WithEvents textBoxX2 As DevComponents.DotNetBar.Controls.TextBoxX
    Private WithEvents requiredFieldValidator2 As DevComponents.DotNetBar.Validator.RequiredFieldValidator
    Private WithEvents textBoxX1 As DevComponents.DotNetBar.Controls.TextBoxX
    Private WithEvents requiredFieldValidator1 As DevComponents.DotNetBar.Validator.RequiredFieldValidator
    Private WithEvents labelX3 As DevComponents.DotNetBar.LabelX
    Private WithEvents labelX2 As DevComponents.DotNetBar.LabelX
    Private WithEvents labelX1 As DevComponents.DotNetBar.LabelX
    Private WithEvents errorProvider1 As System.Windows.Forms.ErrorProvider
    Private WithEvents highlighter1 As DevComponents.DotNetBar.Validator.Highlighter

End Class
