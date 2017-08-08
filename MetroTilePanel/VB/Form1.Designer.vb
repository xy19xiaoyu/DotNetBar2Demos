Namespace MetroTilePanel
	Partial Public Class Form1
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

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
            Dim metroTileFrame1 As DevComponents.DotNetBar.Metro.MetroTileFrame
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
            Me.metroTilePanel1 = New DevComponents.DotNetBar.Metro.MetroTilePanel
            Me.itemContainer1 = New DevComponents.DotNetBar.ItemContainer
            Me.metroTileItem1 = New DevComponents.DotNetBar.Metro.MetroTileItem
            Me.metroTileItem2 = New DevComponents.DotNetBar.Metro.MetroTileItem
            Me.metroTileItem3 = New DevComponents.DotNetBar.Metro.MetroTileItem
            Me.metroTileItem9 = New DevComponents.DotNetBar.Metro.MetroTileItem
            Me.metroTileItem10 = New DevComponents.DotNetBar.Metro.MetroTileItem
            Me.metroTileItem11 = New DevComponents.DotNetBar.Metro.MetroTileItem
            Me.metroTileItem4 = New DevComponents.DotNetBar.Metro.MetroTileItem
            Me.metroTileItem12 = New DevComponents.DotNetBar.Metro.MetroTileItem
            Me.itemContainer2 = New DevComponents.DotNetBar.ItemContainer
            Me.metroTileItem13 = New DevComponents.DotNetBar.Metro.MetroTileItem
            Me.metroTileItem5 = New DevComponents.DotNetBar.Metro.MetroTileItem
            Me.metroTileItem6 = New DevComponents.DotNetBar.Metro.MetroTileItem
            metroTileFrame1 = New DevComponents.DotNetBar.Metro.MetroTileFrame
            Me.SuspendLayout()
            '
            'metroTileFrame1
            '
            metroTileFrame1.Image = Global.My.Resources.Resources.BreakingNews
            metroTileFrame1.ImageIndent = New System.Drawing.Point(4, 0)
            metroTileFrame1.ImageTextAlignment = System.Drawing.ContentAlignment.MiddleLeft
            metroTileFrame1.Text = "Try rearranging the tiles using drag and drop!"
            metroTileFrame1.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.DarkBlue
            '
            '
            '
            metroTileFrame1.TileStyle.Class = ""
            metroTileFrame1.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            '
            'metroTilePanel1
            '
            '
            '
            '
            Me.metroTilePanel1.BackgroundStyle.BackgroundImage = Global.My.Resources.Resources.GreenBack
            Me.metroTilePanel1.BackgroundStyle.BackgroundImagePosition = DevComponents.DotNetBar.eStyleBackgroundImage.TopLeft
            Me.metroTilePanel1.BackgroundStyle.Class = "MetroTilePanel"
            Me.metroTilePanel1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.metroTilePanel1.ContainerControlProcessDialogKey = True
            Me.metroTilePanel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.metroTilePanel1.EnableDragDrop = True
            Me.metroTilePanel1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.metroTilePanel1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.itemContainer1, Me.itemContainer2})
            Me.metroTilePanel1.Location = New System.Drawing.Point(0, 0)
            Me.metroTilePanel1.Name = "metroTilePanel1"
            Me.metroTilePanel1.Size = New System.Drawing.Size(725, 451)
            Me.metroTilePanel1.TabIndex = 0
            Me.metroTilePanel1.Text = "metroTilePanel1"
            '
            'itemContainer1
            '
            '
            '
            '
            Me.itemContainer1.BackgroundStyle.Class = ""
            Me.itemContainer1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.itemContainer1.ItemSpacing = 8
            Me.itemContainer1.MultiLine = True
            Me.itemContainer1.Name = "itemContainer1"
            Me.itemContainer1.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.metroTileItem1, Me.metroTileItem2, Me.metroTileItem3, Me.metroTileItem9, Me.metroTileItem10, Me.metroTileItem11, Me.metroTileItem4, Me.metroTileItem12})
            '
            'metroTileItem1
            '
            Me.metroTileItem1.Image = CType(resources.GetObject("metroTileItem1.Image"), System.Drawing.Image)
            Me.metroTileItem1.ImageIndent = New System.Drawing.Point(0, -6)
            Me.metroTileItem1.ImageTextAlignment = System.Drawing.ContentAlignment.MiddleCenter
            Me.metroTileItem1.Name = "metroTileItem1"
            Me.metroTileItem1.Text = "Internet Explorer"
            Me.metroTileItem1.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Azure
            Me.metroTileItem1.TileSize = New System.Drawing.Size(120, 120)
            '
            '
            '
            Me.metroTileItem1.TileStyle.Class = ""
            Me.metroTileItem1.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.metroTileItem1.TileStyle.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
            '
            'metroTileItem2
            '
            Me.metroTileItem2.Image = Global.My.Resources.Resources.ShoppingBag
            Me.metroTileItem2.ImageIndent = New System.Drawing.Point(0, -6)
            Me.metroTileItem2.ImageTextAlignment = System.Drawing.ContentAlignment.MiddleCenter
            Me.metroTileItem2.Name = "metroTileItem2"
            Me.metroTileItem2.Text = "Store"
            Me.metroTileItem2.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.RedOrange
            Me.metroTileItem2.TileSize = New System.Drawing.Size(120, 120)
            '
            '
            '
            Me.metroTileItem2.TileStyle.Class = ""
            Me.metroTileItem2.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.metroTileItem2.TileStyle.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
            '
            'metroTileItem3
            '
            Me.metroTileItem3.Image = Global.My.Resources.Resources.News
            Me.metroTileItem3.ImageIndent = New System.Drawing.Point(32, 0)
            Me.metroTileItem3.ImageTextAlignment = System.Drawing.ContentAlignment.MiddleLeft
            Me.metroTileItem3.Name = "metroTileItem3"
            Me.metroTileItem3.Text = "News"
            Me.metroTileItem3.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Orange
            Me.metroTileItem3.TileSize = New System.Drawing.Size(248, 120)
            '
            '
            '
            Me.metroTileItem3.TileStyle.Class = ""
            Me.metroTileItem3.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            '
            'metroTileItem9
            '
            Me.metroTileItem9.Image = Global.My.Resources.Resources.Computer
            Me.metroTileItem9.ImageIndent = New System.Drawing.Point(4, -6)
            Me.metroTileItem9.ImageTextAlignment = System.Drawing.ContentAlignment.BottomLeft
            Me.metroTileItem9.Name = "metroTileItem9"
            Me.metroTileItem9.Text = "<br/><font size=""+2"">Computer</font>"
            Me.metroTileItem9.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.DarkGreen
            Me.metroTileItem9.TileSize = New System.Drawing.Size(120, 120)
            '
            '
            '
            Me.metroTileItem9.TileStyle.Class = ""
            Me.metroTileItem9.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            '
            'metroTileItem10
            '
            Me.metroTileItem10.Image = Global.My.Resources.Resources.Computer
            Me.metroTileItem10.ImageIndent = New System.Drawing.Point(4, -6)
            Me.metroTileItem10.ImageTextAlignment = System.Drawing.ContentAlignment.BottomLeft
            Me.metroTileItem10.Name = "metroTileItem10"
            Me.metroTileItem10.Text = "<br/><font size=""+2"">Windows Explorer</font>"
            Me.metroTileItem10.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.DarkGreen
            Me.metroTileItem10.TileSize = New System.Drawing.Size(120, 120)
            '
            '
            '
            Me.metroTileItem10.TileStyle.Class = ""
            Me.metroTileItem10.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            '
            'metroTileItem11
            '
            Me.metroTileItem11.Image = Global.My.Resources.Resources.ControlPanel
            Me.metroTileItem11.ImageIndent = New System.Drawing.Point(0, -6)
            Me.metroTileItem11.ImageTextAlignment = System.Drawing.ContentAlignment.MiddleCenter
            Me.metroTileItem11.Name = "metroTileItem11"
            Me.metroTileItem11.Text = "Control Panel"
            Me.metroTileItem11.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Azure
            Me.metroTileItem11.TileSize = New System.Drawing.Size(120, 120)
            '
            '
            '
            Me.metroTileItem11.TileStyle.Class = ""
            Me.metroTileItem11.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.metroTileItem11.TileStyle.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
            '
            'metroTileItem4
            '
            Me.metroTileItem4.AutoRotateFramesInterval = 4000
            Me.metroTileItem4.Frames.Add(metroTileFrame1)
            Me.metroTileItem4.Image = Global.My.Resources.Resources.BreakingNews
            Me.metroTileItem4.ImageIndent = New System.Drawing.Point(4, 0)
            Me.metroTileItem4.ImageTextAlignment = System.Drawing.ContentAlignment.MiddleLeft
            Me.metroTileItem4.Name = "metroTileItem4"
            Me.metroTileItem4.Text = "This tile holds rotating news content. Check out Frames collection."
            Me.metroTileItem4.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.DarkBlue
            Me.metroTileItem4.TileSize = New System.Drawing.Size(248, 120)
            '
            '
            '
            Me.metroTileItem4.TileStyle.Class = ""
            Me.metroTileItem4.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            '
            'metroTileItem12
            '
            Me.metroTileItem12.ImageIndent = New System.Drawing.Point(32, 0)
            Me.metroTileItem12.Name = "metroTileItem12"
            Me.metroTileItem12.Text = "Desktop"
            Me.metroTileItem12.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Orange
            Me.metroTileItem12.TileSize = New System.Drawing.Size(248, 120)
            '
            '
            '
            Me.metroTileItem12.TileStyle.BackgroundImage = Global.My.Resources.Resources.WinDesktop
            Me.metroTileItem12.TileStyle.BackgroundImagePosition = DevComponents.DotNetBar.eStyleBackgroundImage.TopLeft
            Me.metroTileItem12.TileStyle.Class = ""
            Me.metroTileItem12.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.metroTileItem12.TileStyle.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
            '
            'itemContainer2
            '
            '
            '
            '
            Me.itemContainer2.BackgroundStyle.Class = ""
            Me.itemContainer2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.itemContainer2.ItemSpacing = 8
            Me.itemContainer2.MultiLine = True
            Me.itemContainer2.Name = "itemContainer2"
            Me.itemContainer2.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.metroTileItem13, Me.metroTileItem5, Me.metroTileItem6})
            '
            'metroTileItem13
            '
            Me.metroTileItem13.Image = Global.My.Resources.Resources.CommandPrompt
            Me.metroTileItem13.ImageIndent = New System.Drawing.Point(4, -6)
            Me.metroTileItem13.ImageTextAlignment = System.Drawing.ContentAlignment.BottomLeft
            Me.metroTileItem13.Name = "metroTileItem13"
            Me.metroTileItem13.Text = "Developer Command Prompt"
            Me.metroTileItem13.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.DarkGreen
            Me.metroTileItem13.TileSize = New System.Drawing.Size(120, 120)
            '
            '
            '
            Me.metroTileItem13.TileStyle.Class = ""
            Me.metroTileItem13.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            '
            'metroTileItem5
            '
            Me.metroTileItem5.Image = Global.My.Resources.Resources.Debug
            Me.metroTileItem5.ImageIndent = New System.Drawing.Point(4, -6)
            Me.metroTileItem5.ImageTextAlignment = System.Drawing.ContentAlignment.BottomLeft
            Me.metroTileItem5.Name = "metroTileItem5"
            Me.metroTileItem5.Text = "Remote Debugger"
            Me.metroTileItem5.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.DarkGreen
            Me.metroTileItem5.TileSize = New System.Drawing.Size(120, 120)
            '
            '
            '
            Me.metroTileItem5.TileStyle.Class = ""
            Me.metroTileItem5.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            '
            'metroTileItem6
            '
            Me.metroTileItem6.Image = Global.My.Resources.Resources.Remote
            Me.metroTileItem6.ImageIndent = New System.Drawing.Point(0, 8)
            Me.metroTileItem6.ImageTextAlignment = System.Drawing.ContentAlignment.TopCenter
            Me.metroTileItem6.Name = "metroTileItem6"
            Me.metroTileItem6.Text = "Remote Desktop"
            Me.metroTileItem6.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Olive
            Me.metroTileItem6.TileSize = New System.Drawing.Size(120, 120)
            '
            '
            '
            Me.metroTileItem6.TileStyle.Class = ""
            Me.metroTileItem6.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            '
            'Form1
            '
            Me.ClientSize = New System.Drawing.Size(725, 451)
            Me.Controls.Add(Me.metroTilePanel1)
            Me.DoubleBuffered = True
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "Form1"
            Me.ShowIcon = False
            Me.ResumeLayout(False)

        End Sub

		#End Region

		Private metroTilePanel1 As DevComponents.DotNetBar.Metro.MetroTilePanel
		Private itemContainer1 As DevComponents.DotNetBar.ItemContainer
		Private metroTileItem1 As DevComponents.DotNetBar.Metro.MetroTileItem
		Private metroTileItem2 As DevComponents.DotNetBar.Metro.MetroTileItem
		Private metroTileItem3 As DevComponents.DotNetBar.Metro.MetroTileItem
		Private itemContainer2 As DevComponents.DotNetBar.ItemContainer
		Private metroTileItem9 As DevComponents.DotNetBar.Metro.MetroTileItem
		Private metroTileItem10 As DevComponents.DotNetBar.Metro.MetroTileItem
		Private metroTileItem11 As DevComponents.DotNetBar.Metro.MetroTileItem
		Private metroTileItem4 As DevComponents.DotNetBar.Metro.MetroTileItem
		Private metroTileItem12 As DevComponents.DotNetBar.Metro.MetroTileItem
		Private metroTileItem13 As DevComponents.DotNetBar.Metro.MetroTileItem
		Private metroTileItem5 As DevComponents.DotNetBar.Metro.MetroTileItem
		Private metroTileItem6 As DevComponents.DotNetBar.Metro.MetroTileItem
	End Class
End Namespace

