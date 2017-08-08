Namespace MetroBill
	Partial Public Class StartControl
		''' <summary> 
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary> 
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Component Designer generated code"

		''' <summary> 
		''' Required method for Designer support - do not modify 
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Me.labelX1 = New DevComponents.DotNetBar.LabelX()
			Me.helpTile = New DevComponents.DotNetBar.Metro.MetroTileItem()
			Me.devCoTile = New DevComponents.DotNetBar.Metro.MetroTileItem()
			Me.ytdTile = New DevComponents.DotNetBar.Metro.MetroTileItem()
			Me.unpaidTile = New DevComponents.DotNetBar.Metro.MetroTileItem()
			Me.itemPanel1 = New DevComponents.DotNetBar.ItemPanel()
			Me.itemContainer1 = New DevComponents.DotNetBar.ItemContainer()
			Me.newInvoiceTile = New DevComponents.DotNetBar.Metro.MetroTileItem()
			Me.newClientTile = New DevComponents.DotNetBar.Metro.MetroTileItem()
			Me.salesTile = New DevComponents.DotNetBar.Metro.MetroTileItem()
			Me.reportTile = New DevComponents.DotNetBar.Metro.MetroTileItem()
			Me.appViewTile = New DevComponents.DotNetBar.Metro.MetroTileItem()
			Me.labelX2 = New DevComponents.DotNetBar.LabelX()
			Me.pictureBox1 = New PictureBox()
			Me.chartUpdateTimer = New Timer(Me.components)
			CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' labelX1
			' 
			' 
			' 
			' 
			Me.labelX1.BackgroundStyle.Class = ""
			Me.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
			Me.labelX1.Font = New Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, (CByte(0)))
			Me.labelX1.Location = New Point(3, 3)
			Me.labelX1.Name = "labelX1"
			Me.labelX1.Size = New Size(289, 40)
			Me.labelX1.TabIndex = 2
			Me.labelX1.Text = "ACME Inc. Billing"
			' 
			' helpTile
			' 
			Me.helpTile.Image = My.Resources.Help
			Me.helpTile.Name = "helpTile"
			Me.helpTile.Text = "<font size=""+4"">Get started</font><br/>Knowledge base<br/>article on how to use<b" & "r/>DotNetBar Metro<br/> controls"
			Me.helpTile.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Blue
			' 
			' 
			' 
			Me.helpTile.TileStyle.BackColor = Color.FromArgb((CInt((CByte(76)))), (CInt((CByte(102)))), (CInt((CByte(168)))))
			Me.helpTile.TileStyle.BackColor2 = Color.FromArgb((CInt((CByte(91)))), (CInt((CByte(120)))), (CInt((CByte(190)))))
			Me.helpTile.TileStyle.BackColorGradientAngle = 45
			Me.helpTile.TileStyle.Class = ""
			Me.helpTile.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
			Me.helpTile.TileStyle.PaddingBottom = 4
			Me.helpTile.TileStyle.PaddingLeft = 4
			Me.helpTile.TileStyle.PaddingRight = 4
			Me.helpTile.TileStyle.PaddingTop = 4
			Me.helpTile.TileStyle.TextColor = Color.White
			Me.helpTile.TitleText = "Help"
			' 
			' devCoTile
			' 
			Me.devCoTile.Image = My.Resources.Web
			Me.devCoTile.Name = "devCoTile"
			Me.devCoTile.Text = "<font size=""+4"">DotNetBar<br/>web-site</font>"
			Me.devCoTile.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.RedViolet
			' 
			' 
			' 
			Me.devCoTile.TileStyle.BackColor = Color.FromArgb((CInt((CByte(115)))), (CInt((CByte(0)))), (CInt((CByte(70)))))
			Me.devCoTile.TileStyle.BackColor2 = Color.FromArgb((CInt((CByte(102)))), (CInt((CByte(0)))), (CInt((CByte(61)))))
			Me.devCoTile.TileStyle.BackColorGradientAngle = 45
			Me.devCoTile.TileStyle.Class = ""
			Me.devCoTile.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
			Me.devCoTile.TileStyle.PaddingBottom = 4
			Me.devCoTile.TileStyle.PaddingLeft = 4
			Me.devCoTile.TileStyle.PaddingRight = 4
			Me.devCoTile.TileStyle.PaddingTop = 4
			Me.devCoTile.TileStyle.TextColor = Color.White
			Me.devCoTile.TitleText = "DevComponents"
			' 
			' ytdTile
			' 
			Me.ytdTile.Image = My.Resources.TableReportt
			Me.ytdTile.Name = "ytdTile"
			Me.ytdTile.Text = "<font size=""+4"">Year to date<br/>earnings</font>"
			Me.ytdTile.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Magenta
			' 
			' 
			' 
			Me.ytdTile.TileStyle.BackColor = Color.FromArgb((CInt((CByte(118)))), (CInt((CByte(85)))), (CInt((CByte(148)))))
			Me.ytdTile.TileStyle.BackColor2 = Color.FromArgb((CInt((CByte(133)))), (CInt((CByte(98)))), (CInt((CByte(185)))))
			Me.ytdTile.TileStyle.BackColorGradientAngle = 45
			Me.ytdTile.TileStyle.Class = ""
			Me.ytdTile.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
			Me.ytdTile.TileStyle.PaddingBottom = 4
			Me.ytdTile.TileStyle.PaddingLeft = 4
			Me.ytdTile.TileStyle.PaddingRight = 4
			Me.ytdTile.TileStyle.PaddingTop = 4
			Me.ytdTile.TileStyle.TextColor = Color.White
			Me.ytdTile.TitleText = "Reports"
			' 
			' unpaidTile
			' 
			Me.unpaidTile.Image = My.Resources.Unpaid
			Me.unpaidTile.Name = "unpaidTile"
			Me.unpaidTile.Text = "<font size=""+4"">Unpaid<br/>invoices</font>"
			Me.unpaidTile.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.RedOrange
			' 
			' 
			' 
			Me.unpaidTile.TileStyle.BackColor = Color.FromArgb((CInt((CByte(201)))), (CInt((CByte(60)))), (CInt((CByte(0)))))
			Me.unpaidTile.TileStyle.BackColor2 = Color.FromArgb((CInt((CByte(189)))), (CInt((CByte(57)))), (CInt((CByte(0)))))
			Me.unpaidTile.TileStyle.BackColorGradientAngle = 45
			Me.unpaidTile.TileStyle.Class = ""
			Me.unpaidTile.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
			Me.unpaidTile.TileStyle.PaddingBottom = 4
			Me.unpaidTile.TileStyle.PaddingLeft = 4
			Me.unpaidTile.TileStyle.PaddingRight = 4
			Me.unpaidTile.TileStyle.PaddingTop = 4
			Me.unpaidTile.TileStyle.TextColor = Color.White
			Me.unpaidTile.TitleText = "Invoices"
			' 
			' itemPanel1
			' 
			Me.itemPanel1.AutoScroll = True
			' 
			' 
			' 
			Me.itemPanel1.BackgroundStyle.Class = ""
			Me.itemPanel1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
			Me.itemPanel1.ContainerControlProcessDialogKey = True
			Me.itemPanel1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() { Me.itemContainer1})
			Me.itemPanel1.Location = New Point(3, 61)
			Me.itemPanel1.Name = "itemPanel1"
			Me.itemPanel1.Size = New Size(572, 295)
			Me.itemPanel1.TabIndex = 3
			Me.itemPanel1.Text = "itemPanel1"
			' 
			' itemContainer1
			' 
			' 
			' 
			' 
			Me.itemContainer1.BackgroundStyle.Class = ""
			Me.itemContainer1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
			Me.itemContainer1.ItemSpacing = 6
			Me.itemContainer1.MinimumSize = New Size(560, 290)
			Me.itemContainer1.MultiLine = True
			Me.itemContainer1.Name = "itemContainer1"
			Me.itemContainer1.ResizeItemsToFit = False
			Me.itemContainer1.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() { Me.newInvoiceTile, Me.newClientTile, Me.salesTile, Me.reportTile, Me.unpaidTile, Me.ytdTile, Me.helpTile, Me.devCoTile, Me.appViewTile})
			' 
			' newInvoiceTile
			' 
			Me.newInvoiceTile.Image = My.Resources.Invoice
			Me.newInvoiceTile.Name = "newInvoiceTile"
			Me.newInvoiceTile.Text = "<font size=""+4"">Create new<br/>invoice</font>"
			Me.newInvoiceTile.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Default
			' 
			' 
			' 
			Me.newInvoiceTile.TileStyle.BackColor = Color.FromArgb((CInt((CByte(36)))), (CInt((CByte(83)))), (CInt((CByte(117)))))
			Me.newInvoiceTile.TileStyle.BackColor2 = Color.FromArgb((CInt((CByte(48)))), (CInt((CByte(103)))), (CInt((CByte(155)))))
			Me.newInvoiceTile.TileStyle.BackColorGradientAngle = 45
			Me.newInvoiceTile.TileStyle.Class = ""
			Me.newInvoiceTile.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
			Me.newInvoiceTile.TileStyle.PaddingBottom = 4
			Me.newInvoiceTile.TileStyle.PaddingLeft = 4
			Me.newInvoiceTile.TileStyle.PaddingRight = 4
			Me.newInvoiceTile.TileStyle.PaddingTop = 4
			Me.newInvoiceTile.TileStyle.TextColor = Color.White
			Me.newInvoiceTile.TitleText = "Invoices"
			' 
			' newClientTile
			' 
			Me.newClientTile.Image = My.Resources.contact
			Me.newClientTile.Name = "newClientTile"
			Me.newClientTile.Text = "<font size=""+4"">Add new<br/>client</font>"
			Me.newClientTile.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Green
			' 
			' 
			' 
			Me.newClientTile.TileStyle.BackColor = Color.FromArgb((CInt((CByte(125)))), (CInt((CByte(151)))), (CInt((CByte(42)))))
			Me.newClientTile.TileStyle.BackColor2 = Color.FromArgb((CInt((CByte(152)))), (CInt((CByte(177)))), (CInt((CByte(51)))))
			Me.newClientTile.TileStyle.BackColorGradientAngle = 45
			Me.newClientTile.TileStyle.Class = ""
			Me.newClientTile.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
			Me.newClientTile.TileStyle.PaddingBottom = 4
			Me.newClientTile.TileStyle.PaddingLeft = 4
			Me.newClientTile.TileStyle.PaddingRight = 4
			Me.newClientTile.TileStyle.PaddingTop = 4
			Me.newClientTile.TileStyle.TextColor = Color.White
			Me.newClientTile.TitleText = "Clients"
			' 
			' salesTile
			' 
			Me.salesTile.Name = "salesTile"
			Me.salesTile.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Coffee
			' 
			' 
			' 
			Me.salesTile.TileStyle.BackColor = Color.FromArgb((CInt((CByte(115)))), (CInt((CByte(76)))), (CInt((CByte(41)))))
			Me.salesTile.TileStyle.BackColor2 = Color.FromArgb((CInt((CByte(102)))), (CInt((CByte(67)))), (CInt((CByte(37)))))
			Me.salesTile.TileStyle.BackColorGradientAngle = 45
			Me.salesTile.TileStyle.Class = ""
			Me.salesTile.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
			Me.salesTile.TileStyle.PaddingBottom = 4
			Me.salesTile.TileStyle.PaddingLeft = 4
			Me.salesTile.TileStyle.PaddingRight = 4
			Me.salesTile.TileStyle.PaddingTop = 4
			Me.salesTile.TileStyle.TextColor = Color.White
			Me.salesTile.TitleText = "Sales"
			' 
			' reportTile
			' 
			Me.reportTile.Image = My.Resources.Charts
			Me.reportTile.Name = "reportTile"
			Me.reportTile.Text = "<font size=""+4"">Financial<br/>reports</font>"
			Me.reportTile.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Orange
			' 
			' 
			' 
			Me.reportTile.TileStyle.BackColor = Color.FromArgb((CInt((CByte(223)))), (CInt((CByte(131)))), (CInt((CByte(0)))))
			Me.reportTile.TileStyle.BackColor2 = Color.FromArgb((CInt((CByte(232)))), (CInt((CByte(136)))), (CInt((CByte(0)))))
			Me.reportTile.TileStyle.BackColorGradientAngle = 45
			Me.reportTile.TileStyle.Class = ""
			Me.reportTile.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
			Me.reportTile.TileStyle.PaddingBottom = 4
			Me.reportTile.TileStyle.PaddingLeft = 4
			Me.reportTile.TileStyle.PaddingRight = 4
			Me.reportTile.TileStyle.PaddingTop = 4
			Me.reportTile.TileStyle.TextColor = Color.White
			Me.reportTile.TitleText = "Reports"
			' 
			' appViewTile
			' 
			Me.appViewTile.Image = My.Resources.Details
			Me.appViewTile.Name = "appViewTile"
			Me.appViewTile.Text = "<font size=""+4"">Switch to<br/>app view</font>"
			Me.appViewTile.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.PlumWashed
			' 
			' 
			' 
			Me.appViewTile.TileStyle.BackColor = Color.FromArgb((CInt((CByte(64)))), (CInt((CByte(55)))), (CInt((CByte(76)))))
			Me.appViewTile.TileStyle.BackColor2 = Color.FromArgb((CInt((CByte(54)))), (CInt((CByte(46)))), (CInt((CByte(64)))))
			Me.appViewTile.TileStyle.BackColorGradientAngle = 45
			Me.appViewTile.TileStyle.Class = ""
			Me.appViewTile.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
			Me.appViewTile.TileStyle.PaddingBottom = 4
			Me.appViewTile.TileStyle.PaddingLeft = 4
			Me.appViewTile.TileStyle.PaddingRight = 4
			Me.appViewTile.TileStyle.PaddingTop = 4
			Me.appViewTile.TileStyle.TextColor = Color.White
			Me.appViewTile.TitleText = "Application"
			' 
			' labelX2
			' 
			Me.labelX2.Anchor = (CType((AnchorStyles.Top Or AnchorStyles.Right), AnchorStyles))
			' 
			' 
			' 
			Me.labelX2.BackgroundStyle.Class = ""
			Me.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
			Me.labelX2.Location = New Point(549, 7)
			Me.labelX2.Name = "labelX2"
			Me.labelX2.Size = New Size(60, 47)
			Me.labelX2.TabIndex = 4
			Me.labelX2.Text = "<div align=""right""><font size=""+4"">Wile</font><br/>E. Coyote</div>"
			' 
			' pictureBox1
			' 
			Me.pictureBox1.Anchor = (CType((AnchorStyles.Top Or AnchorStyles.Right), AnchorStyles))
			Me.pictureBox1.BackgroundImage = My.Resources.Person
			Me.pictureBox1.BackgroundImageLayout = ImageLayout.Zoom
			Me.pictureBox1.Location = New Point(615, 14)
			Me.pictureBox1.Name = "pictureBox1"
			Me.pictureBox1.Size = New Size(44, 33)
			Me.pictureBox1.TabIndex = 5
			Me.pictureBox1.TabStop = False
			' 
			' chartUpdateTimer
			' 
			Me.chartUpdateTimer.Enabled = True
			Me.chartUpdateTimer.Interval = 10000
'			Me.chartUpdateTimer.Tick += New System.EventHandler(Me.chartUpdateTimer_Tick)
			' 
			' StartControl
			' 
			Me.Controls.Add(Me.labelX1)
			Me.Controls.Add(Me.pictureBox1)
			Me.Controls.Add(Me.labelX2)
			Me.Controls.Add(Me.itemPanel1)
			Me.Font = New Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, (CByte(0)))
			Me.Name = "StartControl"
			Me.Size = New Size(667, 361)
			CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private labelX1 As DevComponents.DotNetBar.LabelX
		Private helpTile As DevComponents.DotNetBar.Metro.MetroTileItem
		Private devCoTile As DevComponents.DotNetBar.Metro.MetroTileItem
		Private appViewTile As DevComponents.DotNetBar.Metro.MetroTileItem
		Private newClientTile As DevComponents.DotNetBar.Metro.MetroTileItem
		Private ytdTile As DevComponents.DotNetBar.Metro.MetroTileItem
		Private unpaidTile As DevComponents.DotNetBar.Metro.MetroTileItem
		Private itemPanel1 As DevComponents.DotNetBar.ItemPanel
		Private itemContainer1 As DevComponents.DotNetBar.ItemContainer
		Private newInvoiceTile As DevComponents.DotNetBar.Metro.MetroTileItem
		Private salesTile As DevComponents.DotNetBar.Metro.MetroTileItem
		Private reportTile As DevComponents.DotNetBar.Metro.MetroTileItem
		Private labelX2 As DevComponents.DotNetBar.LabelX
		Private pictureBox1 As PictureBox
		Private WithEvents chartUpdateTimer As Timer
	End Class
End Namespace
