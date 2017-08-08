Imports System.ComponentModel
Imports System.Text
Imports DevComponents.DotNetBar.Metro
Imports DevComponents.DotNetBar
Imports DevComponents.AdvTree
Imports DevComponents.DotNetBar.Metro.ColorTables

Namespace MetroBill
	Partial Public Class MainForm
		Inherits MetroAppForm
		Private _StartControl As StartControl = Nothing ' Start control displayed on startup
		Private _Commands As MetroBillCommands = Nothing ' All application commands
		Public Sub New()
			InitializeComponent()

			' Prepare commands
			_Commands = New MetroBillCommands()

			_Commands.ToggleStartControl = New Command(components)
			AddHandler _Commands.ToggleStartControl.Executed, AddressOf ToggleStartControlExecuted

			' Initialize Client related commands
            _Commands.ClientCommands.[New] = New Command(components) ' We pass in components from Form so the command gets disposed automatically when form is disposed
            AddHandler _Commands.ClientCommands.[New].Executed, AddressOf NewClientExecuted
            _Commands.ClientCommands.Cancel = New Command(components)
            AddHandler _Commands.ClientCommands.Cancel.Executed, AddressOf CancelClientExecuted
            _Commands.ClientCommands.Save = New Command(components)
            AddHandler _Commands.ClientCommands.Save.Executed, AddressOf SaveClientExecuted
            ' Invoice related commands
            _Commands.InvoiceCommands.[New] = New Command(components) ' We pass in components from Form so the command gets disposed automatically when form is disposed
            AddHandler _Commands.InvoiceCommands.[New].Executed, AddressOf NewInvoiceExecuted
            _Commands.InvoiceCommands.Cancel = New Command(components)
            AddHandler _Commands.InvoiceCommands.Cancel.Executed, AddressOf CancelInvoiceExecuted
            _Commands.InvoiceCommands.Save = New Command(components)
            AddHandler _Commands.InvoiceCommands.Save.Executed, AddressOf SaveInvoiceExecuted
            ' General commands
            _Commands.ChangeMetroTheme = New Command(components, New EventHandler(AddressOf ChangeMetroThemeExecuted))
            _Commands.NotImplemented = New Command(components, New EventHandler(AddressOf NotImplementedExecuted))
            _Commands.DevComponents = New Command(components, New EventHandler(AddressOf DevComponentsExecuted))
            _Commands.GettingStartedCommand = New Command(components, New EventHandler(AddressOf GettingStartedExecuted))

            Me.SuspendLayout()
            _StartControl = New StartControl()
            _StartControl.Commands = _Commands
            Me.Controls.Add(_StartControl)
            _StartControl.BringToFront()
            _StartControl.SlideSide = DevComponents.DotNetBar.Controls.eSlideSide.Right
            AddHandler _StartControl.Click, AddressOf StartControl_Click
            Me.ResumeLayout(False)

            ' Assign commands to toolbar buttons
            newInvoiceButton.Command = _Commands.InvoiceCommands.[New]
            newClientButton.Command = _Commands.ClientCommands.[New]

            ' Add metro color themes
            Dim metroThemes() As MetroColorGeneratorParameters = MetroColorGeneratorParameters.GetAllPredefinedThemes()
            For Each mt As MetroColorGeneratorParameters In metroThemes
                Dim theme As New ButtonItem(mt.ThemeName, mt.ThemeName)
                theme.Command = _Commands.ChangeMetroTheme
                theme.CommandParameter = mt
                colorThemeButton.SubItems.Add(theme)
            Next mt

            AddSampleData()
        End Sub

#Region "Command Execution"

        Private Sub GettingStartedExecuted(ByVal sender As Object, ByVal e As EventArgs)
            Process.Start("http://www.devcomponents.com/kb2/?p=1160")
        End Sub
        Private Sub NotImplementedExecuted(ByVal sender As Object, ByVal e As EventArgs)
            MessageBoxEx.Show(Me, "Placeholder for real action. This command is not implemented.", "Metro Bill", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Sub
        Private Sub DevComponentsExecuted(ByVal sender As Object, ByVal e As EventArgs)
            Process.Start("http://www.devcomponents.com/dotnetbar/")
        End Sub

        Private Sub ChangeMetroThemeExecuted(ByVal sender As Object, ByVal e As EventArgs)
            Dim source As ICommandSource = CType(sender, ICommandSource)
            Dim theme As MetroColorGeneratorParameters = CType(source.CommandParameter, MetroColorGeneratorParameters)
            StyleManager.MetroColorGeneratorParameters = theme
        End Sub

        Private Sub ToggleStartControlExecuted(ByVal sender As Object, ByVal e As EventArgs)
            _StartControl.IsOpen = Not _StartControl.IsOpen
        End Sub

        Private _ClientControl As ClientControl = Nothing
        Private Sub NewClientExecuted(ByVal sender As Object, ByVal e As EventArgs)
            Debug.Assert(_ClientControl Is Nothing)
            _Commands.ClientCommands.[New].Enabled = False ' Disable new client command to prevent re-entrancy
            _ClientControl = New ClientControl()
            _ClientControl.Commands = _Commands
            Me.ShowModalPanel(_ClientControl, DevComponents.DotNetBar.Controls.eSlideSide.Left)
            If Not _StartControl.Visible Then
                _StartControl.SlideOutButtonVisible = False
            End If
        End Sub
        Private Sub CancelClientExecuted(ByVal sender As Object, ByVal e As EventArgs)
            ' Simply close client entry form "dialog"
            Debug.Assert(_ClientControl IsNot Nothing)
            CloseClientDialog()
        End Sub
        Private Sub CloseClientDialog()
            If Not _StartControl.Visible Then
                _StartControl.SlideOutButtonVisible = True
            End If

            _Commands.ClientCommands.[New].Enabled = True ' Enable new client command

            Me.CloseModalPanel(_ClientControl, DevComponents.DotNetBar.Controls.eSlideSide.Left)
            _ClientControl.Commands = Nothing
            _ClientControl.Dispose()
            _ClientControl = Nothing

        End Sub
        Private Sub SaveClientExecuted(ByVal sender As Object, ByVal e As EventArgs)
            ' Here we would save new client to the storage of choice then close the "dialog"
            CloseClientDialog()
        End Sub

        Private _InvoiceControl As InvoiceControl = Nothing
        Private Sub NewInvoiceExecuted(ByVal sender As Object, ByVal e As EventArgs)
            Debug.Assert(_InvoiceControl Is Nothing)
            _Commands.InvoiceCommands.[New].Enabled = False ' Disable new invoice command to prevent re-entrancy
            _InvoiceControl = New InvoiceControl()
            _InvoiceControl.Commands = _Commands
            Me.ShowModalPanel(_InvoiceControl, DevComponents.DotNetBar.Controls.eSlideSide.Left)
            If Not _StartControl.Visible Then
                _StartControl.SlideOutButtonVisible = False
            End If
        End Sub
        Private Sub CancelInvoiceExecuted(ByVal sender As Object, ByVal e As EventArgs)
            ' Simply close invoice entry form "dialog"
            Debug.Assert(_InvoiceControl IsNot Nothing)
            CloseInvoiceDialog()
        End Sub
        Private Sub CloseInvoiceDialog()
            If Not _StartControl.Visible Then
                _StartControl.SlideOutButtonVisible = True
            End If

            _Commands.InvoiceCommands.[New].Enabled = True ' Enable new invoice command

            Me.CloseModalPanel(_InvoiceControl, DevComponents.DotNetBar.Controls.eSlideSide.Left)
            _InvoiceControl.Commands = Nothing
            _InvoiceControl.Dispose()
            _InvoiceControl = Nothing
        End Sub
        Private Sub SaveInvoiceExecuted(ByVal sender As Object, ByVal e As EventArgs)
            ' Here we would save new invoice to the storage of choice then close the "dialog"
            CloseInvoiceDialog()
        End Sub
#End Region

		#Region "Sample Data Handling"
		Private Sub AddSampleData()
			' Add sample clients
			advTree2.Nodes.Add(CreateClientRow("Acme Construction", "Berlin, Germany", 9090))
			advTree2.Nodes.Add(CreateClientRow("Micro Services Advantage", "Boston, USA", 7890))
			advTree2.Nodes.Add(CreateClientRow("Will E. Otty", "Seattle, USA", 5000))
			advTree2.Nodes.Add(CreateClientRow("Custom Development Services", "Detroit, USA", 11000))
			advTree2.Nodes.Add(CreateClientRow("CERT", "Sarajevo, B&H", 1500))
			advTree2.Nodes.Add(CreateClientRow("R Entertainment Inc.", "Los Angeles, USA", 15000))
			advTree2.Nodes.Add(CreateClientRow("Shift Enterprises", "San Francisco, USA", 12000))
			advTree2.Nodes.Add(CreateClientRow("Orange Corporation", "Boston, USA", 15000))
			advTree2.Nodes.Add(CreateClientRow("Cherry Inc", "Los Angeles, USA", 1000))
			advTree2.Nodes.Add(CreateClientRow("RoW Enterprise", "Los Angeles, USA", 1300))
			advTree2.Nodes.Add(CreateClientRow("24-7 Plumbing", "Bellevue, USA", 1000))

			' Add invoices
			advTree1.Nodes.Add(CreateInvoiceRow(Date.Today, "Will E. Otty", 1250, "Invoice1"))
			advTree1.Nodes.Add(CreateInvoiceRow(Date.Today.AddDays(-1), "Micro Service Advantage", 4500, "Invoice2"))
			advTree1.Nodes.Add(CreateInvoiceRow(Date.Today.AddDays(-10), "Acme Construction", 7500, "Invoice3"))
			advTree1.Nodes.Add(CreateInvoiceRow(Date.Today.AddDays(-12), "Custom Development Services", 500, "Invoice4"))
			advTree1.Nodes.Add(CreateInvoiceRow(Date.Today.AddDays(-14), "CERT", 1500, "Invoice5"))
			advTree1.Nodes.Add(CreateInvoiceRow(Date.Today.AddDays(-15), "R Entertainment Inc.", 1000, "Invoice6"))
			advTree1.Nodes.Add(CreateInvoiceRow(Date.Today.AddDays(-15), "Shift Enterprises", 1700, "Invoice7"))
			advTree1.Nodes.Add(CreateInvoiceRow(Date.Today.AddDays(-15), "Will E. Otty", 2250, "Invoice1"))
			advTree1.Nodes.Add(CreateInvoiceRow(Date.Today.AddDays(-16), "Micro Service Advantage", 2580, "Invoice2"))
			advTree1.Nodes.Add(CreateInvoiceRow(Date.Today.AddDays(-16), "Acme Construction", 7100, "Invoice3"))
			advTree1.Nodes.Add(CreateInvoiceRow(Date.Today.AddDays(-18), "Custom Development Services", 1500, "Invoice4"))
			advTree1.Nodes.Add(CreateInvoiceRow(Date.Today.AddDays(-19), "CERT", 1900, "Invoice5"))
			advTree1.Nodes.Add(CreateInvoiceRow(Date.Today.AddDays(-20), "R Entertainment Inc.", 1010, "Invoice6"))
			advTree1.Nodes.Add(CreateInvoiceRow(Date.Today.AddDays(-21), "Shift Enterprises", 1900, "Invoice7"))
		End Sub
		Private Function CreateClientRow(ByVal clientName As String, ByVal location As String, ByVal totalInvoiced As Double) As Node
			Dim node As New Node(clientName)
			node.Cells.Add(New Cell(location))
			node.Cells.Add(New Cell(totalInvoiced.ToString("C")))
			Return node
		End Function
		Private Function CreateInvoiceRow(ByVal [date] As Date, ByVal clientName As String, ByVal invoiceAmount As Double, ByVal invoiceFileName As String) As Node
			Dim node As New Node([date].ToShortDateString())
			node.Cells.Add(New Cell(clientName))
			node.Cells.Add(New Cell(invoiceAmount.ToString("C")))
			node.Tag = invoiceFileName
			Return node
		End Function
		Private Sub advTree1_AfterNodeSelect(ByVal sender As Object, ByVal e As AdvTreeNodeEventArgs) Handles advTree1.AfterNodeSelect
			Dim node As Node = e.Node
			If Not String.IsNullOrEmpty(CStr(node.Tag)) Then
				richTextBox1.Rtf = ResourceManager.GetString(CStr(node.Tag))
			Else
				richTextBox1.Text = ""
			End If
		End Sub
		Private Shared resourceMan As Global.System.Resources.ResourceManager
		Friend Shared ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
			Get
				If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
					resourceMan = temp
				End If
				Return resourceMan
			End Get
		End Property
		#End Region

		#Region "UI Code"
		Private Sub StartControl_Click(ByVal sender As Object, ByVal e As EventArgs)
			_StartControl.IsOpen = False
		End Sub

		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			UpdateControlsSizeAndLocation()
			MyBase.OnLoad(e)
		End Sub

		Private Function GetStartControlBounds() As Rectangle
			Dim captionHeight As Integer = metroShell1.MetroTabStrip.GetCaptionHeight() + 2
			Dim borderThickness As Thickness = Me.GetBorderThickness()
			Return New Rectangle(CInt(Fix(borderThickness.Left)), captionHeight, Me.Width - CInt(Fix(borderThickness.Horizontal)), Me.Height - captionHeight - 1)
		End Function
		Private Sub UpdateControlsSizeAndLocation()
			If _StartControl IsNot Nothing Then
				If Not _StartControl.IsOpen Then
					_StartControl.OpenBounds = GetStartControlBounds()
				Else
					_StartControl.Bounds = GetStartControlBounds()
				End If
				If Not IsModalPanelDisplayed Then
					_StartControl.BringToFront()
				End If
			End If
			metroToolbar1.Location = New Point((Me.Width - metroToolbar1.Width) / 2, metroToolbar1.Parent.Height - metroToolbar1.Height - 1)
			metroToolbar2.Location = New Point((Me.Width - metroToolbar2.Width) / 2, metroToolbar2.Parent.Height - metroToolbar2.Height - 1)
		End Sub
		Protected Overrides Sub OnResize(ByVal e As EventArgs)
			UpdateControlsSizeAndLocation()
			MyBase.OnResize(e)
		End Sub

		Private Sub metroAppButton1_ExpandChange(ByVal sender As Object, ByVal e As EventArgs) Handles metroAppButton1.ExpandChange
			If Not _StartControl.Visible Then
				_StartControl.SlideOutButtonVisible = Not metroAppButton1.Expanded
			End If
		End Sub

		Private Sub metroShell1_SettingsButtonClick(ByVal sender As Object, ByVal e As EventArgs) Handles metroShell1.SettingsButtonClick
			MessageBoxEx.Show(Me, "MetroShell Settings Button Clicked", "Metro Bill", MessageBoxButtons.OK, MessageBoxIcon.Information)
		End Sub

		Private Sub metroShell1_HelpButtonClick(ByVal sender As Object, ByVal e As EventArgs) Handles metroShell1.HelpButtonClick
			MessageBoxEx.Show(Me, "MetroShell Help Button Clicked", "Metro Bill", MessageBoxButtons.OK, MessageBoxIcon.Information)
		End Sub

		Private Sub metroShell1_SelectedTabChanged(ByVal sender As Object, ByVal e As EventArgs) Handles metroShell1.SelectedTabChanged
			UpdateControlsSizeAndLocation()
		End Sub
		#End Region

	End Class
End Namespace