Imports System.Collections
Imports System.ComponentModel
Imports DevComponents.DotNetBar
Imports DevComponents.DotNetBar.Rendering

Namespace Ribbonpad
	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Public Class frmMain
		Inherits DevComponents.DotNetBar.Office2007RibbonForm
		Private mdiClient1 As MdiClient
		Private openFileDialog1 As OpenFileDialog
		Private saveFileDialog1 As SaveFileDialog
		Private tabStrip1 As DevComponents.DotNetBar.TabStrip
		Private components As System.ComponentModel.IContainer
		Private m_Search As BalloonSearch=Nothing
		Private bar1 As DevComponents.DotNetBar.Bar
		Private labelStatus As DevComponents.DotNetBar.LabelItem
		Friend labelPosition As DevComponents.DotNetBar.LabelItem
		Private WithEvents ribbonControl1 As DevComponents.DotNetBar.RibbonControl
		Private ribbonTabItem1 As DevComponents.DotNetBar.RibbonTabItem
		Private ribbonPanel1 As DevComponents.DotNetBar.RibbonPanel
		Private buttonSave As DevComponents.DotNetBar.ButtonItem
		Private ribbonTabItem3 As DevComponents.DotNetBar.RibbonTabItem
		Private ribbonPanel3 As DevComponents.DotNetBar.RibbonPanel
		Private WithEvents ribbonBar1 As DevComponents.DotNetBar.RibbonBar
		Private WithEvents ribbonBar2 As DevComponents.DotNetBar.RibbonBar
		Private WithEvents ribbonBar3 As DevComponents.DotNetBar.RibbonBar
		Private WithEvents ribbonBar4 As DevComponents.DotNetBar.RibbonBar
		Private buttonPaste As DevComponents.DotNetBar.ButtonItem
		Private buttonCut As DevComponents.DotNetBar.ButtonItem
		Private itemContainer1 As DevComponents.DotNetBar.ItemContainer
		Private buttonCopy As DevComponents.DotNetBar.ButtonItem
		Private buttonUndo As DevComponents.DotNetBar.ButtonItem
		Private comboFont As DevComponents.DotNetBar.ComboBoxItem
		Private comboFontSize As DevComponents.DotNetBar.ComboBoxItem
		Private itemContainer2 As DevComponents.DotNetBar.ItemContainer
		Private itemContainer3 As DevComponents.DotNetBar.ItemContainer
		Private buttonFontItalic As DevComponents.DotNetBar.ButtonItem
		Private buttonFontUnderline As DevComponents.DotNetBar.ButtonItem
		Private buttonFontStrike As DevComponents.DotNetBar.ButtonItem
		Private buttonTextColor As DevComponents.DotNetBar.ColorPickerDropDown
		Private buttonAlignLeft As DevComponents.DotNetBar.ButtonItem
		Private buttonAlignCenter As DevComponents.DotNetBar.ButtonItem
		Private buttonAlignRight As DevComponents.DotNetBar.ButtonItem
		Private buttonAlignJustify As DevComponents.DotNetBar.ButtonItem
		Private buttonItem2 As DevComponents.DotNetBar.ButtonItem
		Private buttonItem3 As DevComponents.DotNetBar.ButtonItem
		Private buttonItem4 As DevComponents.DotNetBar.ButtonItem
		Private buttonItem5 As DevComponents.DotNetBar.ButtonItem
		Private itemContainer6 As DevComponents.DotNetBar.ItemContainer
		Private itemContainer7 As DevComponents.DotNetBar.ItemContainer
		Private itemContainer8 As DevComponents.DotNetBar.ItemContainer
		Private itemContainer4 As DevComponents.DotNetBar.ItemContainer
		Private buttonItem6 As DevComponents.DotNetBar.ButtonItem
		Private buttonItem7 As DevComponents.DotNetBar.ButtonItem
		Private WithEvents buttonFind As DevComponents.DotNetBar.ButtonItem
		Private itemContainer5 As DevComponents.DotNetBar.ItemContainer
		Private buttonReplace As DevComponents.DotNetBar.ButtonItem
		Private buttonGoto As DevComponents.DotNetBar.ButtonItem
		Private WithEvents ribbonBar5 As DevComponents.DotNetBar.RibbonBar
		Private buttonMargins As DevComponents.DotNetBar.ButtonItem
		Private buttonItem9 As DevComponents.DotNetBar.ButtonItem
		Private buttonItem10 As DevComponents.DotNetBar.ButtonItem
		Private buttonItem11 As DevComponents.DotNetBar.ButtonItem
		Private buttonNew As DevComponents.DotNetBar.ButtonItem
		Private buttonFontBold As DevComponents.DotNetBar.ButtonItem
		Private comboItem1 As DevComponents.Editors.ComboItem
		Private comboItem2 As DevComponents.Editors.ComboItem
		Private comboItem3 As DevComponents.Editors.ComboItem
		Private comboItem4 As DevComponents.Editors.ComboItem
		Private comboItem5 As DevComponents.Editors.ComboItem
		Private comboItem6 As DevComponents.Editors.ComboItem
		Private comboItem7 As DevComponents.Editors.ComboItem
		Private comboItem8 As DevComponents.Editors.ComboItem
		Private comboItem9 As DevComponents.Editors.ComboItem
		Private ribbonPanel2 As DevComponents.DotNetBar.RibbonPanel
		Private ribbonBar6 As DevComponents.DotNetBar.RibbonBar
		Private ribbonTabItemGroup1 As DevComponents.DotNetBar.RibbonTabItemGroup
		Private buttonItem1 As DevComponents.DotNetBar.ButtonItem
		Private buttonItem8 As DevComponents.DotNetBar.ButtonItem
		Private buttonItem12 As DevComponents.DotNetBar.ButtonItem
		Private ribbonTabContext As DevComponents.DotNetBar.RibbonTabItem
		Private buttonChangeStyle As DevComponents.DotNetBar.ButtonItem
		Private superTooltip1 As DevComponents.DotNetBar.SuperTooltip
		Private itemContainer9 As DevComponents.DotNetBar.ItemContainer
		Private buttonItem13 As DevComponents.DotNetBar.ButtonItem
		Private buttonItem14 As DevComponents.DotNetBar.ButtonItem
		Private buttonItem15 As DevComponents.DotNetBar.ButtonItem
		Private buttonItem16 As DevComponents.DotNetBar.ButtonItem
		Private buttonItem17 As DevComponents.DotNetBar.ButtonItem
		Private buttonStyleOffice2007Blue As DevComponents.DotNetBar.ButtonItem
		Private buttonStyleOffice2007Black As DevComponents.DotNetBar.ButtonItem
		Private buttonItem20 As DevComponents.DotNetBar.ButtonItem
		Private buttonItem21 As DevComponents.DotNetBar.ButtonItem
		Private buttonItem23 As DevComponents.DotNetBar.ButtonItem
		Private buttonItem24 As DevComponents.DotNetBar.ButtonItem
		Private buttonItem25 As DevComponents.DotNetBar.ButtonItem
		Private labelItem8 As DevComponents.DotNetBar.LabelItem
		Private buttonItem26 As DevComponents.DotNetBar.ButtonItem
		Private buttonItem27 As DevComponents.DotNetBar.ButtonItem
		Private buttonItem28 As DevComponents.DotNetBar.ButtonItem
		Private buttonItem29 As DevComponents.DotNetBar.ButtonItem
		Private WithEvents buttonFileSaveAs As DevComponents.DotNetBar.ButtonItem
		Private menuFileContainer As DevComponents.DotNetBar.ItemContainer
		Private menuFileTwoColumnContainer As DevComponents.DotNetBar.ItemContainer
		Private menuFileItems As DevComponents.DotNetBar.ItemContainer
		Private menuFileMRU As DevComponents.DotNetBar.ItemContainer
		Private menuFileBottomContainer As DevComponents.DotNetBar.ItemContainer
		Private buttonOptions As DevComponents.DotNetBar.ButtonItem
		Private buttonExit As DevComponents.DotNetBar.ButtonItem
		Private qatCustomizeItem1 As DevComponents.DotNetBar.QatCustomizeItem
		Private contextMenuBar1 As DevComponents.DotNetBar.ContextMenuBar
		Private bEditPopup As DevComponents.DotNetBar.ButtonItem
		Private bCut As DevComponents.DotNetBar.ButtonItem
		Private bCopy As DevComponents.DotNetBar.ButtonItem
		Private bPaste As DevComponents.DotNetBar.ButtonItem
		Private bSelectAll As DevComponents.DotNetBar.ButtonItem
		Private ribbonBar7 As DevComponents.DotNetBar.RibbonBar
		Private galleryContainer1 As DevComponents.DotNetBar.GalleryContainer
		Private buttonItem18 As DevComponents.DotNetBar.ButtonItem
		Private buttonItem19 As DevComponents.DotNetBar.ButtonItem
		Private buttonItem22 As DevComponents.DotNetBar.ButtonItem
		Private buttonItem30 As DevComponents.DotNetBar.ButtonItem
		Private buttonItem31 As DevComponents.DotNetBar.ButtonItem
		Private buttonItem32 As DevComponents.DotNetBar.ButtonItem
		Private buttonItem33 As DevComponents.DotNetBar.ButtonItem
		Private buttonItem34 As DevComponents.DotNetBar.ButtonItem
		Private buttonItem35 As DevComponents.DotNetBar.ButtonItem
		Private buttonItem36 As DevComponents.DotNetBar.ButtonItem
		Private buttonItem37 As DevComponents.DotNetBar.ButtonItem
		Private buttonItem38 As DevComponents.DotNetBar.ButtonItem
		Private buttonItem39 As DevComponents.DotNetBar.ButtonItem
		Private buttonItem40 As DevComponents.DotNetBar.ButtonItem
		Private buttonItem41 As DevComponents.DotNetBar.ButtonItem
		Private buttonItem42 As DevComponents.DotNetBar.ButtonItem
		Private buttonItem43 As DevComponents.DotNetBar.ButtonItem
		Private buttonItem44 As DevComponents.DotNetBar.ButtonItem
		Private buttonItem45 As DevComponents.DotNetBar.ButtonItem
		Private buttonItem46 As DevComponents.DotNetBar.ButtonItem
		Private buttonItem47 As DevComponents.DotNetBar.ButtonItem
		Private buttonItem48 As DevComponents.DotNetBar.ButtonItem
		Private buttonItem49 As DevComponents.DotNetBar.ButtonItem
		Private ribbonBar8 As DevComponents.DotNetBar.RibbonBar
		Private itemContainer10 As DevComponents.DotNetBar.ItemContainer
		Private itemContainer11 As DevComponents.DotNetBar.ItemContainer
		Private checkBoxItem1 As DevComponents.DotNetBar.CheckBoxItem
		Private checkBoxItem2 As DevComponents.DotNetBar.CheckBoxItem
		Private checkBoxItem3 As DevComponents.DotNetBar.CheckBoxItem
		Private checkBoxItem4 As DevComponents.DotNetBar.CheckBoxItem
		Private checkBoxItem5 As DevComponents.DotNetBar.CheckBoxItem
		Private checkBoxItem6 As DevComponents.DotNetBar.CheckBoxItem
		Private buttonItem50 As DevComponents.DotNetBar.ButtonItem
		Private buttonItem51 As DevComponents.DotNetBar.ButtonItem
		Private buttonItem52 As DevComponents.DotNetBar.ButtonItem
		Private WithEvents progressBarTimer As Timer
		Private progressBarItem1 As DevComponents.DotNetBar.ProgressBarItem
		Private buttonStyleOffice2007Silver As DevComponents.DotNetBar.ButtonItem
		Private WithEvents buttonStyleCustom As DevComponents.DotNetBar.ColorPickerDropDown
		Private buttonItem53 As DevComponents.DotNetBar.ButtonItem
		Private buttonItem54 As DevComponents.DotNetBar.ButtonItem
		Private buttonItem55 As DevComponents.DotNetBar.ButtonItem
		Private itemContainer12 As DevComponents.DotNetBar.ItemContainer
		Private labelItem1 As DevComponents.DotNetBar.LabelItem
		Private buttonItem56 As DevComponents.DotNetBar.ButtonItem
		Private buttonItem57 As DevComponents.DotNetBar.ButtonItem
		Private buttonItem58 As DevComponents.DotNetBar.ButtonItem
		Private buttonItem59 As DevComponents.DotNetBar.ButtonItem
		Private zoomSlider As DevComponents.DotNetBar.SliderItem
		Private itemContainer13 As DevComponents.DotNetBar.ItemContainer
		Private WithEvents AppCommandNew As Command
		Private WithEvents AppCommandOpen As Command
		Private WithEvents AppCommandSave As Command
		Private WithEvents AppCommandSaveAs As Command
		Private WithEvents AppCommandTheme As Command
		Private WithEvents AppCommandExit As Command
		Private buttonItem60 As DevComponents.DotNetBar.ButtonItem
		Private styleManager1 As DevComponents.DotNetBar.StyleManager
		Private buttonStyleOffice2010Silver As DevComponents.DotNetBar.ButtonItem
		Private buttonItem62 As DevComponents.DotNetBar.ButtonItem
		Private buttonStyleOffice2010Blue As ButtonItem
		Private buttonStyleOffice2010Black As ButtonItem
		Private superTabControl1 As SuperTabControl
		Private superTabControlPanel1 As SuperTabControlPanel
		Private superTabItem1 As SuperTabItem
		Private superTabControlPanel4 As SuperTabControlPanel
		Private superTabItem4 As SuperTabItem
		Private superTabControlPanel3 As SuperTabControlPanel
		Private superTabItem3 As SuperTabItem
		Private superTabControlPanel2 As SuperTabControlPanel
		Private superTabItem2 As SuperTabItem
		Private buttonItem61 As ButtonItem
		Private buttonItem63 As ButtonItem
		Private buttonItem64 As ButtonItem
		Private buttonItem65 As ButtonItem
		Private buttonItem66 As ButtonItem
		Private panelEx1 As PanelEx
		Private labelX1 As LabelX
		Private panelEx2 As PanelEx
		Private labelX2 As LabelX
		Private recentDocsItemPane As ItemPanel
		Private recentPlacesItemsPanel As ItemPanel
		Private labelX3 As LabelX
		Private itemPanel1 As ItemPanel
		Private buttonItem67 As ButtonItem
		Private buttonItem68 As ButtonItem
		Private buttonItem69 As ButtonItem
		Private buttonItem70 As ButtonItem
		Private buttonItem71 As ButtonItem
		Private buttonItem72 As ButtonItem
		Private labelX4 As LabelX
		Private buttonX1 As ButtonX
		Private panelEx3 As PanelEx
		Private labelX5 As LabelX
		Private integerInput1 As DevComponents.Editors.IntegerInput
		Private itemPanel2 As ItemPanel
		Private labelX6 As LabelX
		Private buttonItem73 As ButtonItem
		Private buttonItem74 As ButtonItem
		Private buttonItem75 As ButtonItem
		Private WithEvents AppCommandGoToUrl As Command
		Private buttonItem76 As ButtonItem
		Private buttonItem77 As ButtonItem
		Private switchButtonItem1 As SwitchButtonItem
		Private WithEvents RibbonStateCommand As Command
		Private buttonStyleVS2010 As ButtonItem
		Private buttonFile As DevComponents.DotNetBar.Office2007StartButton

		Public Sub New()
			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()

			AddHandler mdiClient1.ControlAdded, AddressOf MdiClientControlAddRemove
			AddHandler mdiClient1.ControlRemoved, AddressOf MdiClientControlAddRemove
			SetupBackstageContent()
		End Sub

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
				If components IsNot Nothing Then
					components.Dispose()
				End If
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"
		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
			Me.openFileDialog1 = New OpenFileDialog()
			Me.mdiClient1 = New MdiClient()
			Me.saveFileDialog1 = New SaveFileDialog()
			Me.tabStrip1 = New DevComponents.DotNetBar.TabStrip()
			Me.bar1 = New DevComponents.DotNetBar.Bar()
			Me.labelStatus = New DevComponents.DotNetBar.LabelItem()
			Me.itemContainer9 = New DevComponents.DotNetBar.ItemContainer()
			Me.buttonItem13 = New DevComponents.DotNetBar.ButtonItem()
			Me.buttonItem14 = New DevComponents.DotNetBar.ButtonItem()
			Me.buttonItem15 = New DevComponents.DotNetBar.ButtonItem()
			Me.buttonItem16 = New DevComponents.DotNetBar.ButtonItem()
			Me.buttonItem17 = New DevComponents.DotNetBar.ButtonItem()
			Me.progressBarItem1 = New DevComponents.DotNetBar.ProgressBarItem()
			Me.itemContainer13 = New DevComponents.DotNetBar.ItemContainer()
			Me.labelPosition = New DevComponents.DotNetBar.LabelItem()
			Me.zoomSlider = New DevComponents.DotNetBar.SliderItem()
			Me.ribbonControl1 = New DevComponents.DotNetBar.RibbonControl()
			Me.ribbonPanel1 = New DevComponents.DotNetBar.RibbonPanel()
			Me.ribbonBar7 = New DevComponents.DotNetBar.RibbonBar()
			Me.galleryContainer1 = New DevComponents.DotNetBar.GalleryContainer()
			Me.buttonItem47 = New DevComponents.DotNetBar.ButtonItem()
			Me.buttonItem48 = New DevComponents.DotNetBar.ButtonItem()
			Me.buttonItem49 = New DevComponents.DotNetBar.ButtonItem()
			Me.buttonItem18 = New DevComponents.DotNetBar.ButtonItem()
			Me.buttonItem19 = New DevComponents.DotNetBar.ButtonItem()
			Me.buttonItem22 = New DevComponents.DotNetBar.ButtonItem()
			Me.buttonItem30 = New DevComponents.DotNetBar.ButtonItem()
			Me.buttonItem31 = New DevComponents.DotNetBar.ButtonItem()
			Me.buttonItem32 = New DevComponents.DotNetBar.ButtonItem()
			Me.buttonItem33 = New DevComponents.DotNetBar.ButtonItem()
			Me.buttonItem34 = New DevComponents.DotNetBar.ButtonItem()
			Me.buttonItem35 = New DevComponents.DotNetBar.ButtonItem()
			Me.buttonItem36 = New DevComponents.DotNetBar.ButtonItem()
			Me.buttonItem37 = New DevComponents.DotNetBar.ButtonItem()
			Me.buttonItem38 = New DevComponents.DotNetBar.ButtonItem()
			Me.buttonItem39 = New DevComponents.DotNetBar.ButtonItem()
			Me.buttonItem40 = New DevComponents.DotNetBar.ButtonItem()
			Me.buttonItem41 = New DevComponents.DotNetBar.ButtonItem()
			Me.buttonItem42 = New DevComponents.DotNetBar.ButtonItem()
			Me.buttonItem43 = New DevComponents.DotNetBar.ButtonItem()
			Me.buttonItem44 = New DevComponents.DotNetBar.ButtonItem()
			Me.buttonItem45 = New DevComponents.DotNetBar.ButtonItem()
			Me.buttonItem46 = New DevComponents.DotNetBar.ButtonItem()
			Me.ribbonBar3 = New DevComponents.DotNetBar.RibbonBar()
			Me.itemContainer6 = New DevComponents.DotNetBar.ItemContainer()
			Me.itemContainer7 = New DevComponents.DotNetBar.ItemContainer()
			Me.buttonAlignLeft = New DevComponents.DotNetBar.ButtonItem()
			Me.buttonAlignCenter = New DevComponents.DotNetBar.ButtonItem()
			Me.buttonAlignRight = New DevComponents.DotNetBar.ButtonItem()
			Me.buttonAlignJustify = New DevComponents.DotNetBar.ButtonItem()
			Me.itemContainer8 = New DevComponents.DotNetBar.ItemContainer()
			Me.buttonItem2 = New DevComponents.DotNetBar.ButtonItem()
			Me.buttonItem3 = New DevComponents.DotNetBar.ButtonItem()
			Me.buttonItem4 = New DevComponents.DotNetBar.ButtonItem()
			Me.buttonItem5 = New DevComponents.DotNetBar.ButtonItem()
			Me.itemContainer4 = New DevComponents.DotNetBar.ItemContainer()
			Me.buttonItem6 = New DevComponents.DotNetBar.ButtonItem()
			Me.buttonItem7 = New DevComponents.DotNetBar.ButtonItem()
			Me.ribbonBar2 = New DevComponents.DotNetBar.RibbonBar()
			Me.itemContainer2 = New DevComponents.DotNetBar.ItemContainer()
			Me.comboFont = New DevComponents.DotNetBar.ComboBoxItem()
			Me.comboFontSize = New DevComponents.DotNetBar.ComboBoxItem()
			Me.comboItem1 = New DevComponents.Editors.ComboItem()
			Me.comboItem2 = New DevComponents.Editors.ComboItem()
			Me.comboItem3 = New DevComponents.Editors.ComboItem()
			Me.comboItem4 = New DevComponents.Editors.ComboItem()
			Me.comboItem5 = New DevComponents.Editors.ComboItem()
			Me.comboItem6 = New DevComponents.Editors.ComboItem()
			Me.comboItem7 = New DevComponents.Editors.ComboItem()
			Me.comboItem8 = New DevComponents.Editors.ComboItem()
			Me.comboItem9 = New DevComponents.Editors.ComboItem()
			Me.itemContainer3 = New DevComponents.DotNetBar.ItemContainer()
			Me.buttonFontBold = New DevComponents.DotNetBar.ButtonItem()
			Me.buttonFontItalic = New DevComponents.DotNetBar.ButtonItem()
			Me.buttonFontUnderline = New DevComponents.DotNetBar.ButtonItem()
			Me.buttonFontStrike = New DevComponents.DotNetBar.ButtonItem()
			Me.buttonTextColor = New DevComponents.DotNetBar.ColorPickerDropDown()
			Me.ribbonBar1 = New DevComponents.DotNetBar.RibbonBar()
			Me.buttonPaste = New DevComponents.DotNetBar.ButtonItem()
			Me.buttonItem53 = New DevComponents.DotNetBar.ButtonItem()
			Me.buttonItem54 = New DevComponents.DotNetBar.ButtonItem()
			Me.itemContainer1 = New DevComponents.DotNetBar.ItemContainer()
			Me.buttonCut = New DevComponents.DotNetBar.ButtonItem()
			Me.buttonCopy = New DevComponents.DotNetBar.ButtonItem()
			Me.buttonItem55 = New DevComponents.DotNetBar.ButtonItem()
			Me.ribbonPanel2 = New DevComponents.DotNetBar.RibbonPanel()
			Me.ribbonBar6 = New DevComponents.DotNetBar.RibbonBar()
			Me.buttonItem1 = New DevComponents.DotNetBar.ButtonItem()
			Me.buttonItem8 = New DevComponents.DotNetBar.ButtonItem()
			Me.buttonItem12 = New DevComponents.DotNetBar.ButtonItem()
			Me.ribbonPanel3 = New DevComponents.DotNetBar.RibbonPanel()
			Me.ribbonBar8 = New DevComponents.DotNetBar.RibbonBar()
			Me.itemContainer10 = New DevComponents.DotNetBar.ItemContainer()
			Me.checkBoxItem1 = New DevComponents.DotNetBar.CheckBoxItem()
			Me.checkBoxItem2 = New DevComponents.DotNetBar.CheckBoxItem()
			Me.checkBoxItem3 = New DevComponents.DotNetBar.CheckBoxItem()
			Me.itemContainer11 = New DevComponents.DotNetBar.ItemContainer()
			Me.checkBoxItem4 = New DevComponents.DotNetBar.CheckBoxItem()
			Me.checkBoxItem5 = New DevComponents.DotNetBar.CheckBoxItem()
			Me.checkBoxItem6 = New DevComponents.DotNetBar.CheckBoxItem()
			Me.ribbonBar4 = New DevComponents.DotNetBar.RibbonBar()
			Me.buttonFind = New DevComponents.DotNetBar.ButtonItem()
			Me.itemContainer5 = New DevComponents.DotNetBar.ItemContainer()
			Me.buttonReplace = New DevComponents.DotNetBar.ButtonItem()
			Me.buttonGoto = New DevComponents.DotNetBar.ButtonItem()
			Me.ribbonBar5 = New DevComponents.DotNetBar.RibbonBar()
			Me.buttonMargins = New DevComponents.DotNetBar.ButtonItem()
			Me.buttonItem9 = New DevComponents.DotNetBar.ButtonItem()
			Me.buttonItem50 = New DevComponents.DotNetBar.ButtonItem()
			Me.buttonItem51 = New DevComponents.DotNetBar.ButtonItem()
			Me.buttonItem52 = New DevComponents.DotNetBar.ButtonItem()
			Me.buttonItem10 = New DevComponents.DotNetBar.ButtonItem()
			Me.buttonItem11 = New DevComponents.DotNetBar.ButtonItem()
			Me.contextMenuBar1 = New DevComponents.DotNetBar.ContextMenuBar()
			Me.bEditPopup = New DevComponents.DotNetBar.ButtonItem()
			Me.bCut = New DevComponents.DotNetBar.ButtonItem()
			Me.bCopy = New DevComponents.DotNetBar.ButtonItem()
			Me.bPaste = New DevComponents.DotNetBar.ButtonItem()
			Me.bSelectAll = New DevComponents.DotNetBar.ButtonItem()
			Me.buttonFile = New DevComponents.DotNetBar.Office2007StartButton()
			Me.superTabControl1 = New DevComponents.DotNetBar.SuperTabControl()
			Me.superTabControlPanel1 = New DevComponents.DotNetBar.SuperTabControlPanel()
			Me.panelEx2 = New DevComponents.DotNetBar.PanelEx()
			Me.recentPlacesItemsPanel = New DevComponents.DotNetBar.ItemPanel()
			Me.labelX2 = New DevComponents.DotNetBar.LabelX()
			Me.panelEx1 = New DevComponents.DotNetBar.PanelEx()
			Me.recentDocsItemPane = New DevComponents.DotNetBar.ItemPanel()
			Me.labelX1 = New DevComponents.DotNetBar.LabelX()
			Me.superTabItem1 = New DevComponents.DotNetBar.SuperTabItem()
			Me.superTabControlPanel4 = New DevComponents.DotNetBar.SuperTabControlPanel()
			Me.itemPanel2 = New DevComponents.DotNetBar.ItemPanel()
			Me.buttonItem77 = New DevComponents.DotNetBar.ButtonItem()
			Me.AppCommandGoToUrl = New DevComponents.DotNetBar.Command(Me.components)
			Me.buttonItem73 = New DevComponents.DotNetBar.ButtonItem()
			Me.buttonItem74 = New DevComponents.DotNetBar.ButtonItem()
			Me.buttonItem75 = New DevComponents.DotNetBar.ButtonItem()
			Me.buttonItem76 = New DevComponents.DotNetBar.ButtonItem()
			Me.labelX6 = New DevComponents.DotNetBar.LabelX()
			Me.superTabItem4 = New DevComponents.DotNetBar.SuperTabItem()
			Me.superTabControlPanel2 = New DevComponents.DotNetBar.SuperTabControlPanel()
			Me.itemPanel1 = New DevComponents.DotNetBar.ItemPanel()
			Me.buttonItem67 = New DevComponents.DotNetBar.ButtonItem()
			Me.AppCommandNew = New DevComponents.DotNetBar.Command(Me.components)
			Me.buttonItem68 = New DevComponents.DotNetBar.ButtonItem()
			Me.buttonItem69 = New DevComponents.DotNetBar.ButtonItem()
			Me.buttonItem70 = New DevComponents.DotNetBar.ButtonItem()
			Me.buttonItem71 = New DevComponents.DotNetBar.ButtonItem()
			Me.buttonItem72 = New DevComponents.DotNetBar.ButtonItem()
			Me.labelX3 = New DevComponents.DotNetBar.LabelX()
			Me.superTabItem2 = New DevComponents.DotNetBar.SuperTabItem()
			Me.superTabControlPanel3 = New DevComponents.DotNetBar.SuperTabControlPanel()
			Me.panelEx3 = New DevComponents.DotNetBar.PanelEx()
			Me.labelX5 = New DevComponents.DotNetBar.LabelX()
			Me.integerInput1 = New DevComponents.Editors.IntegerInput()
			Me.labelX4 = New DevComponents.DotNetBar.LabelX()
			Me.buttonX1 = New DevComponents.DotNetBar.ButtonX()
			Me.superTabItem3 = New DevComponents.DotNetBar.SuperTabItem()
			Me.buttonItem61 = New DevComponents.DotNetBar.ButtonItem()
			Me.AppCommandSave = New DevComponents.DotNetBar.Command(Me.components)
			Me.buttonItem63 = New DevComponents.DotNetBar.ButtonItem()
			Me.AppCommandOpen = New DevComponents.DotNetBar.Command(Me.components)
			Me.buttonItem64 = New DevComponents.DotNetBar.ButtonItem()
			Me.buttonItem65 = New DevComponents.DotNetBar.ButtonItem()
			Me.buttonItem66 = New DevComponents.DotNetBar.ButtonItem()
			Me.AppCommandExit = New DevComponents.DotNetBar.Command(Me.components)
			Me.menuFileContainer = New DevComponents.DotNetBar.ItemContainer()
			Me.menuFileTwoColumnContainer = New DevComponents.DotNetBar.ItemContainer()
			Me.menuFileItems = New DevComponents.DotNetBar.ItemContainer()
			Me.buttonItem20 = New DevComponents.DotNetBar.ButtonItem()
			Me.buttonItem21 = New DevComponents.DotNetBar.ButtonItem()
			Me.buttonFileSaveAs = New DevComponents.DotNetBar.ButtonItem()
			Me.AppCommandSaveAs = New DevComponents.DotNetBar.Command(Me.components)
			Me.itemContainer12 = New DevComponents.DotNetBar.ItemContainer()
			Me.labelItem1 = New DevComponents.DotNetBar.LabelItem()
			Me.buttonItem56 = New DevComponents.DotNetBar.ButtonItem()
			Me.buttonItem57 = New DevComponents.DotNetBar.ButtonItem()
			Me.buttonItem58 = New DevComponents.DotNetBar.ButtonItem()
			Me.buttonItem59 = New DevComponents.DotNetBar.ButtonItem()
			Me.buttonItem23 = New DevComponents.DotNetBar.ButtonItem()
			Me.buttonItem24 = New DevComponents.DotNetBar.ButtonItem()
			Me.buttonItem25 = New DevComponents.DotNetBar.ButtonItem()
			Me.menuFileMRU = New DevComponents.DotNetBar.ItemContainer()
			Me.labelItem8 = New DevComponents.DotNetBar.LabelItem()
			Me.buttonItem26 = New DevComponents.DotNetBar.ButtonItem()
			Me.buttonItem27 = New DevComponents.DotNetBar.ButtonItem()
			Me.buttonItem28 = New DevComponents.DotNetBar.ButtonItem()
			Me.buttonItem29 = New DevComponents.DotNetBar.ButtonItem()
			Me.menuFileBottomContainer = New DevComponents.DotNetBar.ItemContainer()
			Me.buttonOptions = New DevComponents.DotNetBar.ButtonItem()
			Me.buttonExit = New DevComponents.DotNetBar.ButtonItem()
			Me.ribbonTabItem1 = New DevComponents.DotNetBar.RibbonTabItem()
			Me.ribbonTabItem3 = New DevComponents.DotNetBar.RibbonTabItem()
			Me.ribbonTabContext = New DevComponents.DotNetBar.RibbonTabItem()
			Me.ribbonTabItemGroup1 = New DevComponents.DotNetBar.RibbonTabItemGroup()
			Me.buttonChangeStyle = New DevComponents.DotNetBar.ButtonItem()
			Me.buttonStyleOffice2010Blue = New DevComponents.DotNetBar.ButtonItem()
			Me.AppCommandTheme = New DevComponents.DotNetBar.Command(Me.components)
			Me.buttonStyleOffice2010Silver = New DevComponents.DotNetBar.ButtonItem()
			Me.buttonStyleOffice2010Black = New DevComponents.DotNetBar.ButtonItem()
			Me.buttonStyleVS2010 = New DevComponents.DotNetBar.ButtonItem()
			Me.buttonItem62 = New DevComponents.DotNetBar.ButtonItem()
			Me.buttonStyleOffice2007Blue = New DevComponents.DotNetBar.ButtonItem()
			Me.buttonStyleOffice2007Black = New DevComponents.DotNetBar.ButtonItem()
			Me.buttonStyleOffice2007Silver = New DevComponents.DotNetBar.ButtonItem()
			Me.buttonItem60 = New DevComponents.DotNetBar.ButtonItem()
			Me.buttonStyleCustom = New DevComponents.DotNetBar.ColorPickerDropDown()
			Me.switchButtonItem1 = New DevComponents.DotNetBar.SwitchButtonItem()
			Me.RibbonStateCommand = New DevComponents.DotNetBar.Command(Me.components)
			Me.buttonNew = New DevComponents.DotNetBar.ButtonItem()
			Me.buttonSave = New DevComponents.DotNetBar.ButtonItem()
			Me.buttonUndo = New DevComponents.DotNetBar.ButtonItem()
			Me.qatCustomizeItem1 = New DevComponents.DotNetBar.QatCustomizeItem()
			Me.superTooltip1 = New DevComponents.DotNetBar.SuperTooltip()
			Me.progressBarTimer = New Timer(Me.components)
			Me.styleManager1 = New DevComponents.DotNetBar.StyleManager(Me.components)
			CType(Me.bar1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.ribbonControl1.SuspendLayout()
			Me.ribbonPanel1.SuspendLayout()
			Me.ribbonPanel2.SuspendLayout()
			Me.ribbonPanel3.SuspendLayout()
			CType(Me.contextMenuBar1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.superTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.superTabControl1.SuspendLayout()
			Me.superTabControlPanel1.SuspendLayout()
			Me.panelEx2.SuspendLayout()
			Me.panelEx1.SuspendLayout()
			Me.superTabControlPanel4.SuspendLayout()
			Me.superTabControlPanel2.SuspendLayout()
			Me.superTabControlPanel3.SuspendLayout()
			CType(Me.integerInput1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' openFileDialog1
			' 
			Me.openFileDialog1.DefaultExt = "*.rtf"
			Me.openFileDialog1.Filter = "Text Files (*.txt)|*.txt|RTF Files (*.rtf)|*.rtf|All Files(*.*)|*.*"
			Me.openFileDialog1.FilterIndex = 2
			Me.openFileDialog1.Title = "Open File"
			' 
			' mdiClient1
			' 
			Me.mdiClient1.BackgroundImage = (CType(resources.GetObject("mdiClient1.BackgroundImage"), Image))
			Me.mdiClient1.Dock = DockStyle.Fill
			Me.mdiClient1.Location = New Point(5, 176)
			Me.mdiClient1.Name = "mdiClient1"
			Me.mdiClient1.Size = New Size(766, 301)
			Me.mdiClient1.TabIndex = 5
			' 
			' saveFileDialog1
			' 
			Me.saveFileDialog1.DefaultExt = "*.rtf"
			Me.saveFileDialog1.FileName = "doc1"
			Me.saveFileDialog1.Filter = "Text Files (*.txt)|*.txt|RTF Files (*.rtf)|*.rtf|All Files(*.*)|*.*"
			Me.saveFileDialog1.FilterIndex = 2
			Me.saveFileDialog1.Title = "Save File"
			' 
			' tabStrip1
			' 
			Me.tabStrip1.AutoSelectAttachedControl = True
			Me.tabStrip1.CanReorderTabs = True
			Me.tabStrip1.CloseButtonOnTabsVisible = True
			Me.tabStrip1.CloseButtonVisible = False
			Me.tabStrip1.Dock = DockStyle.Top
			Me.tabStrip1.Location = New Point(5, 150)
			Me.tabStrip1.MdiForm = Me
			Me.tabStrip1.MdiTabbedDocuments = True
			Me.tabStrip1.Name = "tabStrip1"
			Me.tabStrip1.SelectedTab = Nothing
			Me.tabStrip1.SelectedTabFont = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, (CByte(0)))
			Me.tabStrip1.Size = New Size(766, 26)
			Me.tabStrip1.Style = DevComponents.DotNetBar.eTabStripStyle.Office2007Document
			Me.tabStrip1.TabAlignment = DevComponents.DotNetBar.eTabStripAlignment.Top
			Me.tabStrip1.TabIndex = 6
			Me.tabStrip1.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox
			Me.tabStrip1.Text = "tabStrip1"
			' 
			' bar1
			' 
			Me.bar1.AccessibleDescription = "DotNetBar Bar (bar1)"
			Me.bar1.AccessibleName = "DotNetBar Bar"
			Me.bar1.AccessibleRole = AccessibleRole.StatusBar
			Me.bar1.AntiAlias = True
			Me.bar1.BarType = DevComponents.DotNetBar.eBarType.StatusBar
			Me.bar1.Dock = DockStyle.Bottom
			Me.bar1.GrabHandleStyle = DevComponents.DotNetBar.eGrabHandleStyle.ResizeHandle
			Me.bar1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() { Me.labelStatus, Me.itemContainer9, Me.progressBarItem1, Me.itemContainer13})
			Me.bar1.ItemSpacing = 2
			Me.bar1.Location = New Point(5, 477)
			Me.bar1.Name = "bar1"
			Me.bar1.Size = New Size(766, 21)
			Me.bar1.Stretch = True
			Me.bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
			Me.bar1.TabIndex = 7
			Me.bar1.TabStop = False
			Me.bar1.Text = "barStatus"
			' 
			' labelStatus
			' 
			Me.labelStatus.Name = "labelStatus"
			Me.labelStatus.PaddingLeft = 2
			Me.labelStatus.PaddingRight = 2
			Me.labelStatus.SingleLineColor = Color.FromArgb((CInt((CByte(59)))), (CInt((CByte(97)))), (CInt((CByte(156)))))
			Me.labelStatus.Stretch = True
			' 
			' itemContainer9
			' 
			' 
			' 
			' 
			Me.itemContainer9.BackgroundStyle.Class = ""
			Me.itemContainer9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
			Me.itemContainer9.BeginGroup = True
			Me.itemContainer9.Name = "itemContainer9"
			Me.itemContainer9.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() { Me.buttonItem13, Me.buttonItem14, Me.buttonItem15, Me.buttonItem16, Me.buttonItem17})
			' 
			' buttonItem13
			' 
			Me.buttonItem13.Checked = True
			Me.buttonItem13.Image = (CType(resources.GetObject("buttonItem13.Image"), Image))
			Me.buttonItem13.ImagePaddingVertical = 9
			Me.buttonItem13.Name = "buttonItem13"
			Me.buttonItem13.OptionGroup = "statusGroup"
			Me.buttonItem13.Text = "Print Layout"
			Me.buttonItem13.Tooltip = "Print Layout"
			' 
			' buttonItem14
			' 
			Me.buttonItem14.Image = (CType(resources.GetObject("buttonItem14.Image"), Image))
			Me.buttonItem14.ImagePaddingVertical = 9
			Me.buttonItem14.Name = "buttonItem14"
			Me.buttonItem14.OptionGroup = "statusGroup"
			Me.buttonItem14.Text = "Web Layout"
			Me.buttonItem14.Tooltip = "Web Layout"
			' 
			' buttonItem15
			' 
			Me.buttonItem15.Image = (CType(resources.GetObject("buttonItem15.Image"), Image))
			Me.buttonItem15.ImagePaddingVertical = 9
			Me.buttonItem15.Name = "buttonItem15"
			Me.buttonItem15.OptionGroup = "statusGroup"
			Me.buttonItem15.Text = "Full Screen"
			Me.buttonItem15.Tooltip = "Full Screen Reading"
			' 
			' buttonItem16
			' 
			Me.buttonItem16.Image = (CType(resources.GetObject("buttonItem16.Image"), Image))
			Me.buttonItem16.ImagePaddingVertical = 9
			Me.buttonItem16.Name = "buttonItem16"
			Me.buttonItem16.OptionGroup = "statusGroup"
			Me.buttonItem16.Text = "Outline"
			Me.buttonItem16.Tooltip = "Outline"
			' 
			' buttonItem17
			' 
			Me.buttonItem17.Image = (CType(resources.GetObject("buttonItem17.Image"), Image))
			Me.buttonItem17.ImagePaddingVertical = 9
			Me.buttonItem17.Name = "buttonItem17"
			Me.buttonItem17.OptionGroup = "statusGroup"
			Me.buttonItem17.Text = "Draft"
			Me.buttonItem17.Tooltip = "Draft"
			' 
			' progressBarItem1
			' 
			' 
			' 
			' 
			Me.progressBarItem1.BackStyle.Class = ""
			Me.progressBarItem1.BackStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
			Me.progressBarItem1.ChunkGradientAngle = 0F
			Me.progressBarItem1.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways
			Me.progressBarItem1.Name = "progressBarItem1"
			Me.progressBarItem1.RecentlyUsed = False
			' 
			' itemContainer13
			' 
			' 
			' 
			' 
			Me.itemContainer13.BackgroundStyle.Class = "Office2007StatusBarBackground2"
			Me.itemContainer13.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
			Me.itemContainer13.Name = "itemContainer13"
			Me.itemContainer13.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() { Me.labelPosition, Me.zoomSlider})
			' 
			' labelPosition
			' 
			Me.labelPosition.Name = "labelPosition"
			Me.labelPosition.PaddingLeft = 2
			Me.labelPosition.PaddingRight = 2
			Me.labelPosition.SingleLineColor = Color.FromArgb((CInt((CByte(59)))), (CInt((CByte(97)))), (CInt((CByte(156)))))
			Me.labelPosition.Width = 100
			' 
			' zoomSlider
			' 
			Me.zoomSlider.Maximum = 200
			Me.zoomSlider.Name = "zoomSlider"
			Me.zoomSlider.Step = 5
			Me.zoomSlider.Text = "100%"
			Me.zoomSlider.Value = 100
			' 
			' ribbonControl1
			' 
			Me.ribbonControl1.BackColor = SystemColors.Control
			' 
			' 
			' 
			Me.ribbonControl1.BackgroundStyle.Class = ""
			Me.ribbonControl1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
			Me.ribbonControl1.CaptionVisible = True
			Me.ribbonControl1.Controls.Add(Me.ribbonPanel1)
			Me.ribbonControl1.Controls.Add(Me.ribbonPanel2)
			Me.ribbonControl1.Controls.Add(Me.ribbonPanel3)
			Me.ribbonControl1.Dock = DockStyle.Top
			Me.ribbonControl1.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, (CByte(0)))
			Me.ribbonControl1.GlobalContextMenuBar = Me.contextMenuBar1
			Me.ribbonControl1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() { Me.buttonFile, Me.ribbonTabItem1, Me.ribbonTabItem3, Me.ribbonTabContext, Me.buttonChangeStyle, Me.switchButtonItem1})
			Me.ribbonControl1.KeyTipsFont = New Font("Tahoma", 6.75F, FontStyle.Regular, GraphicsUnit.Point, (CByte(0)))
			Me.ribbonControl1.Location = New Point(5, 1)
			Me.ribbonControl1.MdiSystemItemVisible = False
			Me.ribbonControl1.Name = "ribbonControl1"
            Me.ribbonControl1.Padding = New System.Windows.Forms.Padding(0, 0, 0, 2)
            Me.ribbonControl1.QuickToolbarItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.buttonNew, Me.buttonSave, Me.buttonUndo, Me.qatCustomizeItem1})
            Me.ribbonControl1.Size = New Size(766, 149)
            Me.ribbonControl1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.ribbonControl1.SystemText.MaximizeRibbonText = "&Maximize the Ribbon"
            Me.ribbonControl1.SystemText.MinimizeRibbonText = "Mi&nimize the Ribbon"
            Me.ribbonControl1.SystemText.QatAddItemText = "&Add to Quick Access Toolbar"
            Me.ribbonControl1.SystemText.QatCustomizeMenuLabel = "<b>Customize Quick Access Toolbar</b>"
            Me.ribbonControl1.SystemText.QatCustomizeText = "&Customize Quick Access Toolbar..."
            Me.ribbonControl1.SystemText.QatDialogAddButton = "&Add >>"
            Me.ribbonControl1.SystemText.QatDialogCancelButton = "Cancel"
            Me.ribbonControl1.SystemText.QatDialogCaption = "Customize Quick Access Toolbar"
            Me.ribbonControl1.SystemText.QatDialogCategoriesLabel = "&Choose commands from:"
            Me.ribbonControl1.SystemText.QatDialogOkButton = "OK"
            Me.ribbonControl1.SystemText.QatDialogPlacementCheckbox = "&Place Quick Access Toolbar below the Ribbon"
            Me.ribbonControl1.SystemText.QatDialogRemoveButton = "&Remove"
            Me.ribbonControl1.SystemText.QatPlaceAboveRibbonText = "&Place Quick Access Toolbar above the Ribbon"
            Me.ribbonControl1.SystemText.QatPlaceBelowRibbonText = "&Place Quick Access Toolbar below the Ribbon"
            Me.ribbonControl1.SystemText.QatRemoveItemText = "&Remove from Quick Access Toolbar"
            Me.ribbonControl1.TabGroupHeight = 14
            Me.ribbonControl1.TabGroups.AddRange(New DevComponents.DotNetBar.RibbonTabItemGroup() {Me.ribbonTabItemGroup1})
            Me.ribbonControl1.TabGroupsVisible = True
            Me.ribbonControl1.TabIndex = 8
            '			Me.ribbonControl1.TitleTextMarkupLinkClick += New DevComponents.DotNetBar.MarkupLinkClickEventHandler(Me.ribbonControl1_TitleTextMarkupLinkClick)
            '			Me.ribbonControl1.BeforeRibbonPanelPopupClose += New DevComponents.DotNetBar.RibbonPopupCloseEventHandler(Me.ribbonControl1_BeforeRibbonPanelPopupClose)
            ' 
            ' ribbonPanel1
            ' 
            Me.ribbonPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.ribbonPanel1.Controls.Add(Me.ribbonBar7)
            Me.ribbonPanel1.Controls.Add(Me.ribbonBar3)
            Me.ribbonPanel1.Controls.Add(Me.ribbonBar2)
            Me.ribbonPanel1.Controls.Add(Me.ribbonBar1)
            Me.ribbonPanel1.Dock = DockStyle.Fill
            Me.ribbonPanel1.Location = New Point(0, 54)
            Me.ribbonPanel1.Name = "ribbonPanel1"
            Me.ribbonPanel1.Padding = New System.Windows.Forms.Padding(3, 0, 3, 3)
            Me.ribbonPanel1.Size = New Size(766, 93)
            ' 
            ' 
            ' 
            Me.ribbonPanel1.Style.Class = ""
            Me.ribbonPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square
            ' 
            ' 
            ' 
            Me.ribbonPanel1.StyleMouseDown.Class = ""
            Me.ribbonPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
            ' 
            ' 
            ' 
            Me.ribbonPanel1.StyleMouseOver.Class = ""
            Me.ribbonPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.ribbonPanel1.TabIndex = 1
            ' 
            ' ribbonBar7
            ' 
            Me.ribbonBar7.AutoOverflowEnabled = True
            ' 
            ' 
            ' 
            Me.ribbonBar7.BackgroundMouseOverStyle.Class = ""
            Me.ribbonBar7.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            ' 
            ' 
            ' 
            Me.ribbonBar7.BackgroundStyle.Class = ""
            Me.ribbonBar7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.ribbonBar7.ContainerControlProcessDialogKey = True
            Me.ribbonBar7.DialogLauncherVisible = True
            Me.ribbonBar7.Dock = DockStyle.Left
            Me.ribbonBar7.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.galleryContainer1})
            Me.ribbonBar7.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical
            Me.ribbonBar7.Location = New Point(415, 0)
            Me.ribbonBar7.Name = "ribbonBar7"
            Me.ribbonBar7.Size = New Size(328, 90)
            Me.ribbonBar7.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.ribbonBar7.TabIndex = 3
            Me.ribbonBar7.Text = "Templates"
            ' 
            ' 
            ' 
            Me.ribbonBar7.TitleStyle.Class = ""
            Me.ribbonBar7.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            ' 
            ' 
            ' 
            Me.ribbonBar7.TitleStyleMouseOver.Class = ""
            Me.ribbonBar7.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.ribbonBar7.VerticalItemAlignment = DevComponents.DotNetBar.eVerticalItemsAlignment.Middle
            ' 
            ' galleryContainer1
            ' 
            ' 
            ' 
            ' 
            Me.galleryContainer1.BackgroundStyle.Class = "RibbonGalleryContainer"
            Me.galleryContainer1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.galleryContainer1.DefaultSize = New Size(200, 58)
            Me.galleryContainer1.MinimumSize = New Size(58, 58)
            Me.galleryContainer1.Name = "galleryContainer1"
            Me.galleryContainer1.PopupGalleryItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.buttonItem47, Me.buttonItem48, Me.buttonItem49})
            Me.galleryContainer1.StretchGallery = True
            Me.galleryContainer1.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.buttonItem18, Me.buttonItem19, Me.buttonItem22, Me.buttonItem30, Me.buttonItem31, Me.buttonItem32, Me.buttonItem33, Me.buttonItem34, Me.buttonItem35, Me.buttonItem36, Me.buttonItem37, Me.buttonItem38, Me.buttonItem39, Me.buttonItem40, Me.buttonItem41, Me.buttonItem42, Me.buttonItem43, Me.buttonItem44, Me.buttonItem45, Me.buttonItem46})
            ' 
            ' buttonItem47
            ' 
            Me.buttonItem47.BeginGroup = True
            Me.buttonItem47.Image = (CType(resources.GetObject("buttonItem47.Image"), Image))
            Me.buttonItem47.Name = "buttonItem47"
            Me.buttonItem47.Text = "Search for Templates Online..."
            ' 
            ' buttonItem48
            ' 
            Me.buttonItem48.Image = (CType(resources.GetObject("buttonItem48.Image"), Image))
            Me.buttonItem48.Name = "buttonItem48"
            Me.buttonItem48.Text = "Browse for Templates..."
            ' 
            ' buttonItem49
            ' 
            Me.buttonItem49.Image = (CType(resources.GetObject("buttonItem49.Image"), Image))
            Me.buttonItem49.Name = "buttonItem49"
            Me.buttonItem49.Text = "Save Current Template..."
            ' 
            ' buttonItem18
            ' 
            Me.buttonItem18.Image = (CType(resources.GetObject("buttonItem18.Image"), Image))
            Me.buttonItem18.Name = "buttonItem18"
            Me.buttonItem18.Text = "Apex"
            Me.buttonItem18.Tooltip = "Apex"
            ' 
            ' buttonItem19
            ' 
            Me.buttonItem19.Image = (CType(resources.GetObject("buttonItem19.Image"), Image))
            Me.buttonItem19.Name = "buttonItem19"
            Me.buttonItem19.Text = "Aspect"
            Me.buttonItem19.Tooltip = "Aspect"
            ' 
            ' buttonItem22
            ' 
            Me.buttonItem22.Image = (CType(resources.GetObject("buttonItem22.Image"), Image))
            Me.buttonItem22.Name = "buttonItem22"
            Me.buttonItem22.Text = "Concourse"
            Me.buttonItem22.Tooltip = "Concourse"
            ' 
            ' buttonItem30
            ' 
            Me.buttonItem30.Image = (CType(resources.GetObject("buttonItem30.Image"), Image))
            Me.buttonItem30.Name = "buttonItem30"
            Me.buttonItem30.Text = "Currency"
            Me.buttonItem30.Tooltip = "Currency"
            ' 
            ' buttonItem31
            ' 
            Me.buttonItem31.Image = (CType(resources.GetObject("buttonItem31.Image"), Image))
            Me.buttonItem31.Name = "buttonItem31"
            Me.buttonItem31.Text = "Deluxe"
            Me.buttonItem31.Tooltip = "Deluxe"
            ' 
            ' buttonItem32
            ' 
            Me.buttonItem32.Image = (CType(resources.GetObject("buttonItem32.Image"), Image))
            Me.buttonItem32.Name = "buttonItem32"
            Me.buttonItem32.Text = "Equity"
            Me.buttonItem32.Tooltip = "Equity"
            ' 
            ' buttonItem33
            ' 
            Me.buttonItem33.Image = (CType(resources.GetObject("buttonItem33.Image"), Image))
            Me.buttonItem33.Name = "buttonItem33"
            Me.buttonItem33.Text = "Flow"
            Me.buttonItem33.Tooltip = "Flow"
            ' 
            ' buttonItem34
            ' 
            Me.buttonItem34.Image = (CType(resources.GetObject("buttonItem34.Image"), Image))
            Me.buttonItem34.Name = "buttonItem34"
            Me.buttonItem34.Text = "Foundry"
            Me.buttonItem34.Tooltip = "Foundry"
            ' 
            ' buttonItem35
            ' 
            Me.buttonItem35.Image = (CType(resources.GetObject("buttonItem35.Image"), Image))
            Me.buttonItem35.Name = "buttonItem35"
            Me.buttonItem35.Text = "Median"
            Me.buttonItem35.Tooltip = "Median"
            ' 
            ' buttonItem36
            ' 
            Me.buttonItem36.Image = (CType(resources.GetObject("buttonItem36.Image"), Image))
            Me.buttonItem36.Name = "buttonItem36"
            Me.buttonItem36.Text = "Metro"
            Me.buttonItem36.Tooltip = "Metro"
            ' 
            ' buttonItem37
            ' 
            Me.buttonItem37.Image = (CType(resources.GetObject("buttonItem37.Image"), Image))
            Me.buttonItem37.Name = "buttonItem37"
            Me.buttonItem37.Text = "Office"
            Me.buttonItem37.Tooltip = "Office"
            ' 
            ' buttonItem38
            ' 
            Me.buttonItem38.Image = (CType(resources.GetObject("buttonItem38.Image"), Image))
            Me.buttonItem38.Name = "buttonItem38"
            Me.buttonItem38.Text = "Opulent"
            Me.buttonItem38.Tooltip = "Opulent"
            ' 
            ' buttonItem39
            ' 
            Me.buttonItem39.Image = (CType(resources.GetObject("buttonItem39.Image"), Image))
            Me.buttonItem39.Name = "buttonItem39"
            Me.buttonItem39.Text = "Oriel"
            Me.buttonItem39.Tooltip = "Oriel"
            ' 
            ' buttonItem40
            ' 
            Me.buttonItem40.Image = (CType(resources.GetObject("buttonItem40.Image"), Image))
            Me.buttonItem40.Name = "buttonItem40"
            Me.buttonItem40.Text = "Origin"
            Me.buttonItem40.Tooltip = "Origin"
            ' 
            ' buttonItem41
            ' 
            Me.buttonItem41.Image = (CType(resources.GetObject("buttonItem41.Image"), Image))
            Me.buttonItem41.Name = "buttonItem41"
            Me.buttonItem41.Text = "Civic"
            Me.buttonItem41.Tooltip = "Civic"
            ' 
            ' buttonItem42
            ' 
            Me.buttonItem42.Image = (CType(resources.GetObject("buttonItem42.Image"), Image))
            Me.buttonItem42.Name = "buttonItem42"
            Me.buttonItem42.Text = "Solstice"
            Me.buttonItem42.Tooltip = "Solstice"
            ' 
            ' buttonItem43
            ' 
            Me.buttonItem43.Image = (CType(resources.GetObject("buttonItem43.Image"), Image))
            Me.buttonItem43.Name = "buttonItem43"
            Me.buttonItem43.Text = "Technic"
            Me.buttonItem43.Tooltip = "Technic"
            ' 
            ' buttonItem44
            ' 
            Me.buttonItem44.Image = (CType(resources.GetObject("buttonItem44.Image"), Image))
            Me.buttonItem44.Name = "buttonItem44"
            Me.buttonItem44.Text = "Trek"
            Me.buttonItem44.Tooltip = "Trek"
            ' 
            ' buttonItem45
            ' 
            Me.buttonItem45.Image = (CType(resources.GetObject("buttonItem45.Image"), Image))
            Me.buttonItem45.Name = "buttonItem45"
            Me.buttonItem45.Text = "Urban"
            Me.buttonItem45.Tooltip = "Urban"
            ' 
            ' buttonItem46
            ' 
            Me.buttonItem46.Image = (CType(resources.GetObject("buttonItem46.Image"), Image))
            Me.buttonItem46.Name = "buttonItem46"
            Me.buttonItem46.Text = "Verve"
            Me.buttonItem46.Tooltip = "Verve"
            ' 
            ' ribbonBar3
            ' 
            Me.ribbonBar3.AutoOverflowEnabled = True
            ' 
            ' 
            ' 
            Me.ribbonBar3.BackgroundMouseOverStyle.Class = ""
            Me.ribbonBar3.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            ' 
            ' 
            ' 
            Me.ribbonBar3.BackgroundStyle.Class = ""
            Me.ribbonBar3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.ribbonBar3.ContainerControlProcessDialogKey = True
            Me.ribbonBar3.DialogLauncherVisible = True
            Me.ribbonBar3.Dock = DockStyle.Left
            Me.ribbonBar3.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.itemContainer6, Me.itemContainer4})
            Me.ribbonBar3.Location = New Point(231, 0)
            Me.ribbonBar3.Name = "ribbonBar3"
            Me.ribbonBar3.Size = New Size(184, 90)
            Me.ribbonBar3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.superTooltip1.SetSuperTooltip(Me.ribbonBar3, New DevComponents.DotNetBar.SuperTooltipInfo("SuperTooltip for Dialog Launcher Button", "", "Assigning the Super Tooltip to the Ribbon Bar control will display it when mouse " & "hovers over the Dialog Launcher button.", Nothing, Nothing, DevComponents.DotNetBar.eTooltipColor.Gray))
            Me.ribbonBar3.TabIndex = 2
            Me.ribbonBar3.Text = "&Paragraph"
            ' 
            ' 
            ' 
            Me.ribbonBar3.TitleStyle.Class = ""
            Me.ribbonBar3.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            ' 
            ' 
            ' 
            Me.ribbonBar3.TitleStyleMouseOver.Class = ""
            Me.ribbonBar3.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.ribbonBar3.VerticalItemAlignment = DevComponents.DotNetBar.eVerticalItemsAlignment.Middle
            '			Me.ribbonBar3.LaunchDialog += New System.EventHandler(Me.LaunchRibbonDialog)
            ' 
            ' itemContainer6
            ' 
            ' 
            ' 
            ' 
            Me.itemContainer6.BackgroundStyle.Class = ""
            Me.itemContainer6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.itemContainer6.ItemSpacing = 3
            Me.itemContainer6.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical
            Me.itemContainer6.Name = "itemContainer6"
            Me.itemContainer6.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.itemContainer7, Me.itemContainer8})
            Me.itemContainer6.VerticalItemAlignment = DevComponents.DotNetBar.eVerticalItemsAlignment.Middle
            ' 
            ' itemContainer7
            ' 
            ' 
            ' 
            ' 
            Me.itemContainer7.BackgroundStyle.Class = ""
            Me.itemContainer7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.itemContainer7.BeginGroup = True
            Me.itemContainer7.Name = "itemContainer7"
            Me.itemContainer7.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.buttonAlignLeft, Me.buttonAlignCenter, Me.buttonAlignRight, Me.buttonAlignJustify})
            ' 
            ' buttonAlignLeft
            ' 
            Me.buttonAlignLeft.Enabled = False
            Me.buttonAlignLeft.Image = (CType(resources.GetObject("buttonAlignLeft.Image"), Image))
            Me.buttonAlignLeft.Name = "buttonAlignLeft"
            Me.buttonAlignLeft.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlL)
            Me.superTooltip1.SetSuperTooltip(Me.buttonAlignLeft, New DevComponents.DotNetBar.SuperTooltipInfo("Align Left (Ctrl+L)", "", "Align text to left.", Nothing, Nothing, DevComponents.DotNetBar.eTooltipColor.Gray))
            Me.buttonAlignLeft.Text = "Align &Left"
            ' 
            ' buttonAlignCenter
            ' 
            Me.buttonAlignCenter.Enabled = False
            Me.buttonAlignCenter.Image = (CType(resources.GetObject("buttonAlignCenter.Image"), Image))
            Me.buttonAlignCenter.Name = "buttonAlignCenter"
            Me.buttonAlignCenter.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlE)
            Me.superTooltip1.SetSuperTooltip(Me.buttonAlignCenter, New DevComponents.DotNetBar.SuperTooltipInfo("Center (Ctrl+E)", "", "Center text.", Nothing, Nothing, DevComponents.DotNetBar.eTooltipColor.Gray))
            Me.buttonAlignCenter.Text = "Align &Center"
            ' 
            ' buttonAlignRight
            ' 
            Me.buttonAlignRight.Enabled = False
            Me.buttonAlignRight.Image = (CType(resources.GetObject("buttonAlignRight.Image"), Image))
            Me.buttonAlignRight.Name = "buttonAlignRight"
            Me.buttonAlignRight.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlR)
            Me.superTooltip1.SetSuperTooltip(Me.buttonAlignRight, New DevComponents.DotNetBar.SuperTooltipInfo("Align Right (Ctrl+R)", "", "Align text to the right.", Nothing, Nothing, DevComponents.DotNetBar.eTooltipColor.Gray))
            Me.buttonAlignRight.Text = "Align &Right"
            ' 
            ' buttonAlignJustify
            ' 
            Me.buttonAlignJustify.Enabled = False
            Me.buttonAlignJustify.Image = (CType(resources.GetObject("buttonAlignJustify.Image"), Image))
            Me.buttonAlignJustify.Name = "buttonAlignJustify"
            Me.buttonAlignJustify.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlJ)
            Me.superTooltip1.SetSuperTooltip(Me.buttonAlignJustify, New DevComponents.DotNetBar.SuperTooltipInfo("Justify (Ctrl+J)", "", "Align text to both the left and right margins, adding extra space between words a" & "s necessary." & vbCrLf & vbCrLf & "This creates a clean look along the left and right side of the p" & "age.", Nothing, Nothing, DevComponents.DotNetBar.eTooltipColor.Gray))
            Me.buttonAlignJustify.Text = "&Justify"
            ' 
            ' itemContainer8
            ' 
            ' 
            ' 
            ' 
            Me.itemContainer8.BackgroundStyle.Class = ""
            Me.itemContainer8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.itemContainer8.BeginGroup = True
            Me.itemContainer8.Name = "itemContainer8"
            Me.itemContainer8.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.buttonItem2, Me.buttonItem3, Me.buttonItem4, Me.buttonItem5})
            ' 
            ' buttonItem2
            ' 
            Me.buttonItem2.Image = (CType(resources.GetObject("buttonItem2.Image"), Image))
            Me.buttonItem2.Name = "buttonItem2"
            Me.superTooltip1.SetSuperTooltip(Me.buttonItem2, New DevComponents.DotNetBar.SuperTooltipInfo("Numbering", "", "Add numbering to the text.", Nothing, Nothing, DevComponents.DotNetBar.eTooltipColor.Gray))
            Me.buttonItem2.Text = "&Numbered Bullets"
            ' 
            ' buttonItem3
            ' 
            Me.buttonItem3.Image = (CType(resources.GetObject("buttonItem3.Image"), Image))
            Me.buttonItem3.Name = "buttonItem3"
            Me.superTooltip1.SetSuperTooltip(Me.buttonItem3, New DevComponents.DotNetBar.SuperTooltipInfo("Bullets", "", "Add bullets to the text.", Nothing, Nothing, DevComponents.DotNetBar.eTooltipColor.Gray))
            Me.buttonItem3.Text = "&Bullets"
            ' 
            ' buttonItem4
            ' 
            Me.buttonItem4.Image = (CType(resources.GetObject("buttonItem4.Image"), Image))
            Me.buttonItem4.Name = "buttonItem4"
            Me.superTooltip1.SetSuperTooltip(Me.buttonItem4, New DevComponents.DotNetBar.SuperTooltipInfo("Increase Indent", "", "Change the indentation of text.", Nothing, Nothing, DevComponents.DotNetBar.eTooltipColor.Gray))
            Me.buttonItem4.Text = "&Indent"
            ' 
            ' buttonItem5
            ' 
            Me.buttonItem5.Image = (CType(resources.GetObject("buttonItem5.Image"), Image))
            Me.buttonItem5.Name = "buttonItem5"
            Me.superTooltip1.SetSuperTooltip(Me.buttonItem5, New DevComponents.DotNetBar.SuperTooltipInfo("Decrease Indent", "", "Change the indentation of text.", Nothing, Nothing, DevComponents.DotNetBar.eTooltipColor.Gray))
            Me.buttonItem5.Text = "&Outdent"
            ' 
            ' itemContainer4
            ' 
            ' 
            ' 
            ' 
            Me.itemContainer4.BackgroundStyle.Class = ""
            Me.itemContainer4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.itemContainer4.ItemSpacing = 3
            Me.itemContainer4.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical
            Me.itemContainer4.Name = "itemContainer4"
            Me.itemContainer4.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.buttonItem6, Me.buttonItem7})
            Me.itemContainer4.VerticalItemAlignment = DevComponents.DotNetBar.eVerticalItemsAlignment.Middle
            ' 
            ' buttonItem6
            ' 
            Me.buttonItem6.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
            Me.buttonItem6.Image = (CType(resources.GetObject("buttonItem6.Image"), Image))
            Me.buttonItem6.Name = "buttonItem6"
            Me.superTooltip1.SetSuperTooltip(Me.buttonItem6, New DevComponents.DotNetBar.SuperTooltipInfo("Borders", "", "Change borders of the selected text." & vbCrLf & vbCrLf & "This feature has not been implemented yet" & ".", Nothing, Nothing, DevComponents.DotNetBar.eTooltipColor.Gray))
            Me.buttonItem6.Text = "&Borders"
            ' 
            ' buttonItem7
            ' 
            Me.buttonItem7.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
            Me.buttonItem7.Image = (CType(resources.GetObject("buttonItem7.Image"), Image))
            Me.buttonItem7.Name = "buttonItem7"
            Me.superTooltip1.SetSuperTooltip(Me.buttonItem7, New DevComponents.DotNetBar.SuperTooltipInfo("Shading", "", "Changes shading of selected text." & vbCrLf & vbCrLf & "This feature has not been implemented yet.", Nothing, Nothing, DevComponents.DotNetBar.eTooltipColor.Gray))
            Me.buttonItem7.Text = "&Shading"
            ' 
            ' ribbonBar2
            ' 
            Me.ribbonBar2.AutoOverflowEnabled = True
            ' 
            ' 
            ' 
            Me.ribbonBar2.BackgroundMouseOverStyle.Class = ""
            Me.ribbonBar2.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            ' 
            ' 
            ' 
            Me.ribbonBar2.BackgroundStyle.Class = ""
            Me.ribbonBar2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.ribbonBar2.ContainerControlProcessDialogKey = True
            Me.ribbonBar2.DialogLauncherVisible = True
            Me.ribbonBar2.Dock = DockStyle.Left
            Me.ribbonBar2.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.itemContainer2, Me.itemContainer3})
            Me.ribbonBar2.ItemSpacing = 5
            Me.ribbonBar2.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical
            Me.ribbonBar2.Location = New Point(76, 0)
            Me.ribbonBar2.Name = "ribbonBar2"
            Me.ribbonBar2.ResizeItemsToFit = False
            Me.ribbonBar2.Size = New Size(155, 90)
            Me.ribbonBar2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.superTooltip1.SetSuperTooltip(Me.ribbonBar2, New DevComponents.DotNetBar.SuperTooltipInfo("SuperTooltip for Dialog Launcher Button", "", "Assigning the Super Tooltip to the Ribbon Bar control will display it when mouse " & "hovers over the Dialog Launcher button.", Nothing, Nothing, DevComponents.DotNetBar.eTooltipColor.Gray))
            Me.ribbonBar2.TabIndex = 1
            Me.ribbonBar2.Text = "F&ont"
            ' 
            ' 
            ' 
            Me.ribbonBar2.TitleStyle.Class = ""
            Me.ribbonBar2.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            ' 
            ' 
            ' 
            Me.ribbonBar2.TitleStyleMouseOver.Class = ""
            Me.ribbonBar2.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.ribbonBar2.VerticalItemAlignment = DevComponents.DotNetBar.eVerticalItemsAlignment.Middle
            '			Me.ribbonBar2.PopupContainerUnload += New System.EventHandler(Me.UnloadPopup)
            '			Me.ribbonBar2.LaunchDialog += New System.EventHandler(Me.LaunchRibbonDialog)
            ' 
            ' itemContainer2
            ' 
            ' 
            ' 
            ' 
            Me.itemContainer2.BackgroundStyle.Class = ""
            Me.itemContainer2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.itemContainer2.Name = "itemContainer2"
            Me.itemContainer2.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.comboFont, Me.comboFontSize})
            ' 
            ' comboFont
            ' 
            Me.comboFont.ComboWidth = 96
            Me.comboFont.DropDownHeight = 106
            Me.comboFont.DropDownWidth = 242
            Me.comboFont.Enabled = False
            Me.comboFont.FontCombo = True
            Me.comboFont.ItemHeight = 14
            Me.comboFont.Name = "comboFont"
            Me.superTooltip1.SetSuperTooltip(Me.comboFont, New DevComponents.DotNetBar.SuperTooltipInfo("Font", "", "Change the font face.", Nothing, Nothing, DevComponents.DotNetBar.eTooltipColor.Gray))
            ' 
            ' comboFontSize
            ' 
            Me.comboFontSize.ComboWidth = 40
            Me.comboFontSize.DropDownHeight = 106
            Me.comboFontSize.Enabled = False
            Me.comboFontSize.ItemHeight = 14
            Me.comboFontSize.Items.AddRange(New Object() {Me.comboItem1, Me.comboItem2, Me.comboItem3, Me.comboItem4, Me.comboItem5, Me.comboItem6, Me.comboItem7, Me.comboItem8, Me.comboItem9})
            Me.comboFontSize.Name = "comboFontSize"
            ' 
            ' comboItem1
            ' 
            Me.comboItem1.Text = "6"
            ' 
            ' comboItem2
            ' 
            Me.comboItem2.Text = "7"
            ' 
            ' comboItem3
            ' 
            Me.comboItem3.Text = "8"
            ' 
            ' comboItem4
            ' 
            Me.comboItem4.Text = "9"
            ' 
            ' comboItem5
            ' 
            Me.comboItem5.Text = "10"
            ' 
            ' comboItem6
            ' 
            Me.comboItem6.Text = "11"
            ' 
            ' comboItem7
            ' 
            Me.comboItem7.Text = "12"
            ' 
            ' comboItem8
            ' 
            Me.comboItem8.Text = "13"
            ' 
            ' comboItem9
            ' 
            Me.comboItem9.Text = "14"
            ' 
            ' itemContainer3
            ' 
            ' 
            ' 
            ' 
            Me.itemContainer3.BackgroundStyle.Class = ""
            Me.itemContainer3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.itemContainer3.BeginGroup = True
            Me.itemContainer3.Name = "itemContainer3"
            Me.itemContainer3.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.buttonFontBold, Me.buttonFontItalic, Me.buttonFontUnderline, Me.buttonFontStrike, Me.buttonTextColor})
            ' 
            ' buttonFontBold
            ' 
            Me.buttonFontBold.Enabled = False
            Me.buttonFontBold.Image = (CType(resources.GetObject("buttonFontBold.Image"), Image))
            Me.buttonFontBold.Name = "buttonFontBold"
            Me.buttonFontBold.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlB)
            Me.superTooltip1.SetSuperTooltip(Me.buttonFontBold, New DevComponents.DotNetBar.SuperTooltipInfo("Bold (Ctrl+B)", "", "Make selected text bold", Nothing, Nothing, DevComponents.DotNetBar.eTooltipColor.Gray))
            Me.buttonFontBold.Text = "&Bold"
            ' 
            ' buttonFontItalic
            ' 
            Me.buttonFontItalic.Enabled = False
            Me.buttonFontItalic.Image = (CType(resources.GetObject("buttonFontItalic.Image"), Image))
            Me.buttonFontItalic.Name = "buttonFontItalic"
            Me.buttonFontItalic.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlI)
            Me.superTooltip1.SetSuperTooltip(Me.buttonFontItalic, New DevComponents.DotNetBar.SuperTooltipInfo("Italic (Ctrl+I)", "", "Italicize the selected text.", Nothing, Nothing, DevComponents.DotNetBar.eTooltipColor.Gray))
            Me.buttonFontItalic.Text = "&Italic"
            ' 
            ' buttonFontUnderline
            ' 
            Me.buttonFontUnderline.Enabled = False
            Me.buttonFontUnderline.Image = (CType(resources.GetObject("buttonFontUnderline.Image"), Image))
            Me.buttonFontUnderline.Name = "buttonFontUnderline"
            Me.buttonFontUnderline.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlU)
            Me.superTooltip1.SetSuperTooltip(Me.buttonFontUnderline, New DevComponents.DotNetBar.SuperTooltipInfo("Underline (Ctrl+U)", "", "Underline the selected text.", Nothing, Nothing, DevComponents.DotNetBar.eTooltipColor.Gray))
            Me.buttonFontUnderline.Text = "&Underline"
            ' 
            ' buttonFontStrike
            ' 
            Me.buttonFontStrike.Enabled = False
            Me.buttonFontStrike.Image = (CType(resources.GetObject("buttonFontStrike.Image"), Image))
            Me.buttonFontStrike.Name = "buttonFontStrike"
            Me.superTooltip1.SetSuperTooltip(Me.buttonFontStrike, New DevComponents.DotNetBar.SuperTooltipInfo("Strikethrough", "", "Draw a line through the middle of the selected text.", Nothing, Nothing, DevComponents.DotNetBar.eTooltipColor.Gray))
            Me.buttonFontStrike.Text = "&Strike"
            ' 
            ' buttonTextColor
            ' 
            Me.buttonTextColor.Enabled = False
            Me.buttonTextColor.Image = (CType(resources.GetObject("buttonTextColor.Image"), Image))
            Me.buttonTextColor.Name = "buttonTextColor"
            Me.buttonTextColor.SelectedColorImageRectangle = New Rectangle(0, 13, 16, 3)
            Me.superTooltip1.SetSuperTooltip(Me.buttonTextColor, New DevComponents.DotNetBar.SuperTooltipInfo("Text Color", "", "Change the selected text color.", Nothing, Nothing, DevComponents.DotNetBar.eTooltipColor.Gray))
            Me.buttonTextColor.Text = "Text &Color"
            ' 
            ' ribbonBar1
            ' 
            Me.ribbonBar1.AutoOverflowEnabled = True
            ' 
            ' 
            ' 
            Me.ribbonBar1.BackgroundMouseOverStyle.Class = ""
            Me.ribbonBar1.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            ' 
            ' 
            ' 
            Me.ribbonBar1.BackgroundStyle.Class = ""
            Me.ribbonBar1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.ribbonBar1.ContainerControlProcessDialogKey = True
            Me.ribbonBar1.DialogLauncherVisible = True
            Me.ribbonBar1.Dock = DockStyle.Left
            Me.ribbonBar1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.buttonPaste, Me.itemContainer1})
            Me.ribbonBar1.Location = New Point(3, 0)
            Me.ribbonBar1.Name = "ribbonBar1"
            Me.ribbonBar1.Size = New Size(73, 90)
            Me.ribbonBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.superTooltip1.SetSuperTooltip(Me.ribbonBar1, New DevComponents.DotNetBar.SuperTooltipInfo("SuperTooltip for Dialog Launcher", "", "Assigning the Super Tooltip to the Ribbon Bar control will display it when mouse " & "hovers over the Dialog Launcher button.", Nothing, Nothing, DevComponents.DotNetBar.eTooltipColor.Gray))
            Me.ribbonBar1.TabIndex = 0
            Me.ribbonBar1.Text = "&Clipboard"
            ' 
            ' 
            ' 
            Me.ribbonBar1.TitleStyle.Class = ""
            Me.ribbonBar1.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            ' 
            ' 
            ' 
            Me.ribbonBar1.TitleStyleMouseOver.Class = ""
            Me.ribbonBar1.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
            '			Me.ribbonBar1.LaunchDialog += New System.EventHandler(Me.LaunchRibbonDialog)
            ' 
            ' buttonPaste
            ' 
            Me.buttonPaste.Image = (CType(resources.GetObject("buttonPaste.Image"), Image))
            Me.buttonPaste.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
            Me.buttonPaste.Name = "buttonPaste"
            Me.buttonPaste.SplitButton = True
            Me.buttonPaste.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.buttonItem53, Me.buttonItem54})
            Me.superTooltip1.SetSuperTooltip(Me.buttonPaste, New DevComponents.DotNetBar.SuperTooltipInfo("Paste (Ctrl+V)", "", "Paste text from clipboard.", Nothing, Nothing, DevComponents.DotNetBar.eTooltipColor.Gray))
            Me.buttonPaste.Text = "&Paste"
            ' 
            ' buttonItem53
            ' 
            Me.buttonItem53.Enabled = False
            Me.buttonItem53.Image = (CType(resources.GetObject("buttonItem53.Image"), Image))
            Me.buttonItem53.Name = "buttonItem53"
            Me.buttonItem53.Text = "&Paste"
            ' 
            ' buttonItem54
            ' 
            Me.buttonItem54.Image = (CType(resources.GetObject("buttonItem54.Image"), Image))
            Me.buttonItem54.Name = "buttonItem54"
            Me.buttonItem54.Text = "Paste &Special..."
            ' 
            ' itemContainer1
            ' 
            ' 
            ' 
            ' 
            Me.itemContainer1.BackgroundStyle.Class = ""
            Me.itemContainer1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.itemContainer1.ItemSpacing = 0
            Me.itemContainer1.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical
            Me.itemContainer1.Name = "itemContainer1"
            Me.itemContainer1.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.buttonCut, Me.buttonCopy, Me.buttonItem55})
            ' 
            ' buttonCut
            ' 
            Me.buttonCut.Enabled = False
            Me.buttonCut.Image = (CType(resources.GetObject("buttonCut.Image"), Image))
            Me.buttonCut.Name = "buttonCut"
            Me.superTooltip1.SetSuperTooltip(Me.buttonCut, New DevComponents.DotNetBar.SuperTooltipInfo("Cut (Ctrl+X)", "", "Removes selected text and copies it to clipboard.", Nothing, Nothing, DevComponents.DotNetBar.eTooltipColor.Gray))
            Me.buttonCut.Text = "Cu&t"
            ' 
            ' buttonCopy
            ' 
            Me.buttonCopy.Enabled = False
            Me.buttonCopy.Image = (CType(resources.GetObject("buttonCopy.Image"), Image))
            Me.buttonCopy.Name = "buttonCopy"
            Me.superTooltip1.SetSuperTooltip(Me.buttonCopy, New DevComponents.DotNetBar.SuperTooltipInfo("Copy (Ctrl+C)", "", "Copy selected text to clipboard.", Nothing, Nothing, DevComponents.DotNetBar.eTooltipColor.Gray))
            Me.buttonCopy.Text = "&Copy"
            ' 
            ' buttonItem55
            ' 
            Me.buttonItem55.Image = (CType(resources.GetObject("buttonItem55.Image"), Image))
            Me.buttonItem55.Name = "buttonItem55"
            Me.superTooltip1.SetSuperTooltip(Me.buttonItem55, New DevComponents.DotNetBar.SuperTooltipInfo("Format Painter", "This command is not implemented", "Copy formatting from one place and apply it to another.", Nothing, Nothing, DevComponents.DotNetBar.eTooltipColor.Gray))
            Me.buttonItem55.Text = "Format Painter"
            ' 
            ' ribbonPanel2
            ' 
            Me.ribbonPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.ribbonPanel2.Controls.Add(Me.ribbonBar6)
            Me.ribbonPanel2.Dock = DockStyle.Fill
            Me.ribbonPanel2.Location = New Point(0, 54)
            Me.ribbonPanel2.Name = "ribbonPanel2"
            Me.ribbonPanel2.Padding = New System.Windows.Forms.Padding(3, 0, 3, 3)
            Me.ribbonPanel2.Size = New Size(766, 93)
            ' 
            ' 
            ' 
            Me.ribbonPanel2.Style.Class = ""
            Me.ribbonPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square
            ' 
            ' 
            ' 
            Me.ribbonPanel2.StyleMouseDown.Class = ""
            Me.ribbonPanel2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
            ' 
            ' 
            ' 
            Me.ribbonPanel2.StyleMouseOver.Class = ""
            Me.ribbonPanel2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.ribbonPanel2.TabIndex = 4
            Me.ribbonPanel2.Visible = False
            ' 
            ' ribbonBar6
            ' 
            Me.ribbonBar6.AutoOverflowEnabled = True
            ' 
            ' 
            ' 
            Me.ribbonBar6.BackgroundMouseOverStyle.Class = ""
            Me.ribbonBar6.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            ' 
            ' 
            ' 
            Me.ribbonBar6.BackgroundStyle.Class = ""
            Me.ribbonBar6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.ribbonBar6.ContainerControlProcessDialogKey = True
            Me.ribbonBar6.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.buttonItem1, Me.buttonItem8, Me.buttonItem12})
            Me.ribbonBar6.Location = New Point(3, 0)
            Me.ribbonBar6.Name = "ribbonBar6"
            Me.ribbonBar6.Size = New Size(337, 87)
            Me.ribbonBar6.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.ribbonBar6.TabIndex = 0
            Me.ribbonBar6.Text = "Contextual Ribbon"
            ' 
            ' 
            ' 
            Me.ribbonBar6.TitleStyle.Class = ""
            Me.ribbonBar6.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            ' 
            ' 
            ' 
            Me.ribbonBar6.TitleStyleMouseOver.Class = ""
            Me.ribbonBar6.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
            ' 
            ' buttonItem1
            ' 
            Me.buttonItem1.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
            Me.buttonItem1.Image = (CType(resources.GetObject("buttonItem1.Image"), Image))
            Me.buttonItem1.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
            Me.buttonItem1.Name = "buttonItem1"
            Me.buttonItem1.RibbonWordWrap = False
            Me.buttonItem1.Text = "Command 1"
            ' 
            ' buttonItem8
            ' 
            Me.buttonItem8.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
            Me.buttonItem8.Image = (CType(resources.GetObject("buttonItem8.Image"), Image))
            Me.buttonItem8.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
            Me.buttonItem8.Name = "buttonItem8"
            Me.buttonItem8.RibbonWordWrap = False
            Me.buttonItem8.Text = "Command 2"
            ' 
            ' buttonItem12
            ' 
            Me.buttonItem12.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
            Me.buttonItem12.Image = (CType(resources.GetObject("buttonItem12.Image"), Image))
            Me.buttonItem12.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
            Me.buttonItem12.Name = "buttonItem12"
            Me.buttonItem12.RibbonWordWrap = False
            Me.buttonItem12.Text = "Command 3"
            ' 
            ' ribbonPanel3
            ' 
            Me.ribbonPanel3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.ribbonPanel3.Controls.Add(Me.ribbonBar8)
            Me.ribbonPanel3.Controls.Add(Me.ribbonBar4)
            Me.ribbonPanel3.Controls.Add(Me.ribbonBar5)
            Me.ribbonPanel3.Dock = DockStyle.Fill
            Me.ribbonPanel3.Location = New Point(0, 54)
            Me.ribbonPanel3.Name = "ribbonPanel3"
            Me.ribbonPanel3.Padding = New System.Windows.Forms.Padding(3, 0, 3, 3)
            Me.ribbonPanel3.Size = New Size(766, 93)
            ' 
            ' 
            ' 
            Me.ribbonPanel3.Style.Class = ""
            Me.ribbonPanel3.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square
            ' 
            ' 
            ' 
            Me.ribbonPanel3.StyleMouseDown.Class = ""
            Me.ribbonPanel3.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
            ' 
            ' 
            ' 
            Me.ribbonPanel3.StyleMouseOver.Class = ""
            Me.ribbonPanel3.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.ribbonPanel3.TabIndex = 3
            Me.ribbonPanel3.Visible = False
            ' 
            ' ribbonBar8
            ' 
            Me.ribbonBar8.AutoOverflowEnabled = True
            ' 
            ' 
            ' 
            Me.ribbonBar8.BackgroundMouseOverStyle.Class = ""
            Me.ribbonBar8.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            ' 
            ' 
            ' 
            Me.ribbonBar8.BackgroundStyle.Class = ""
            Me.ribbonBar8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.ribbonBar8.ContainerControlProcessDialogKey = True
            Me.ribbonBar8.Dock = DockStyle.Left
            Me.ribbonBar8.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.itemContainer10, Me.itemContainer11})
            Me.ribbonBar8.ItemSpacing = 4
            Me.ribbonBar8.Location = New Point(466, 0)
            Me.ribbonBar8.Name = "ribbonBar8"
            Me.ribbonBar8.Size = New Size(200, 90)
            Me.ribbonBar8.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.ribbonBar8.TabIndex = 4
            Me.ribbonBar8.Text = "Options"
            ' 
            ' 
            ' 
            Me.ribbonBar8.TitleStyle.Class = ""
            Me.ribbonBar8.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            ' 
            ' 
            ' 
            Me.ribbonBar8.TitleStyleMouseOver.Class = ""
            Me.ribbonBar8.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
            ' 
            ' itemContainer10
            ' 
            ' 
            ' 
            ' 
            Me.itemContainer10.BackgroundStyle.Class = ""
            Me.itemContainer10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.itemContainer10.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical
            Me.itemContainer10.Name = "itemContainer10"
            Me.itemContainer10.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.checkBoxItem1, Me.checkBoxItem2, Me.checkBoxItem3})
            ' 
            ' checkBoxItem1
            ' 
            Me.checkBoxItem1.Checked = True
            Me.checkBoxItem1.CheckState = CheckState.Indeterminate
            Me.checkBoxItem1.Name = "checkBoxItem1"
            Me.checkBoxItem1.Text = "Header"
            Me.checkBoxItem1.ThreeState = True
            ' 
            ' checkBoxItem2
            ' 
            Me.checkBoxItem2.Name = "checkBoxItem2"
            Me.checkBoxItem2.Text = "Footer"
            ' 
            ' checkBoxItem3
            ' 
            Me.checkBoxItem3.Checked = True
            Me.checkBoxItem3.CheckState = CheckState.Checked
            Me.checkBoxItem3.Name = "checkBoxItem3"
            Me.checkBoxItem3.Text = "Margins"
            ' 
            ' itemContainer11
            ' 
            ' 
            ' 
            ' 
            Me.itemContainer11.BackgroundStyle.Class = ""
            Me.itemContainer11.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.itemContainer11.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical
            Me.itemContainer11.Name = "itemContainer11"
            Me.itemContainer11.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.checkBoxItem4, Me.checkBoxItem5, Me.checkBoxItem6})
            ' 
            ' checkBoxItem4
            ' 
            Me.checkBoxItem4.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton
            Me.checkBoxItem4.Name = "checkBoxItem4"
            Me.checkBoxItem4.Text = "Horizontal Layout"
            ' 
            ' checkBoxItem5
            ' 
            Me.checkBoxItem5.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton
            Me.checkBoxItem5.Name = "checkBoxItem5"
            Me.checkBoxItem5.Text = "Vertical Layout"
            ' 
            ' checkBoxItem6
            ' 
            Me.checkBoxItem6.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton
            Me.checkBoxItem6.Checked = True
            Me.checkBoxItem6.CheckState = CheckState.Checked
            Me.checkBoxItem6.Name = "checkBoxItem6"
            Me.checkBoxItem6.Text = "Automatic Layout"
            ' 
            ' ribbonBar4
            ' 
            Me.ribbonBar4.AutoOverflowEnabled = True
            ' 
            ' 
            ' 
            Me.ribbonBar4.BackgroundMouseOverStyle.Class = ""
            Me.ribbonBar4.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            ' 
            ' 
            ' 
            Me.ribbonBar4.BackgroundStyle.Class = ""
            Me.ribbonBar4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.ribbonBar4.ContainerControlProcessDialogKey = True
            Me.ribbonBar4.DialogLauncherVisible = True
            Me.ribbonBar4.Dock = DockStyle.Left
            Me.ribbonBar4.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.buttonFind, Me.itemContainer5})
            Me.ribbonBar4.Location = New Point(322, 0)
            Me.ribbonBar4.Name = "ribbonBar4"
            Me.ribbonBar4.Size = New Size(144, 90)
            Me.ribbonBar4.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.superTooltip1.SetSuperTooltip(Me.ribbonBar4, New DevComponents.DotNetBar.SuperTooltipInfo("SuperTooltip for Dialog Launcher Button", "", "Assigning the Super Tooltip to the Ribbon Bar control will display it when mouse " & "hovers over the Dialog Launcher button.", Nothing, Nothing, DevComponents.DotNetBar.eTooltipColor.Gray))
            Me.ribbonBar4.TabIndex = 3
            Me.ribbonBar4.Text = "Fi&nd"
            ' 
            ' 
            ' 
            Me.ribbonBar4.TitleStyle.Class = ""
            Me.ribbonBar4.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            ' 
            ' 
            ' 
            Me.ribbonBar4.TitleStyleMouseOver.Class = ""
            Me.ribbonBar4.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
            '			Me.ribbonBar4.LaunchDialog += New System.EventHandler(Me.LaunchRibbonDialog)
            ' 
            ' buttonFind
            ' 
            Me.buttonFind.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
            Me.buttonFind.Enabled = False
            Me.buttonFind.Image = (CType(resources.GetObject("buttonFind.Image"), Image))
            Me.buttonFind.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
            Me.buttonFind.Name = "buttonFind"
            Me.buttonFind.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlF)
            Me.superTooltip1.SetSuperTooltip(Me.buttonFind, New DevComponents.DotNetBar.SuperTooltipInfo("Find (Ctrl+F)", "", "Find text in document.", Nothing, Nothing, DevComponents.DotNetBar.eTooltipColor.Gray))
            Me.buttonFind.Text = "&Find"
            '			Me.buttonFind.Click += New System.EventHandler(Me.buttonFind_Click)
            ' 
            ' itemContainer5
            ' 
            ' 
            ' 
            ' 
            Me.itemContainer5.BackgroundStyle.Class = ""
            Me.itemContainer5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.itemContainer5.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical
            Me.itemContainer5.Name = "itemContainer5"
            Me.itemContainer5.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.buttonReplace, Me.buttonGoto})
            ' 
            ' buttonReplace
            ' 
            Me.buttonReplace.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
            Me.buttonReplace.Enabled = False
            Me.buttonReplace.Image = (CType(resources.GetObject("buttonReplace.Image"), Image))
            Me.buttonReplace.Name = "buttonReplace"
            Me.superTooltip1.SetSuperTooltip(Me.buttonReplace, New DevComponents.DotNetBar.SuperTooltipInfo("Replace", "", "Find and replace the text in document." & vbCrLf & vbCrLf & "This feature has not been implemented y" & "et.", Nothing, Nothing, DevComponents.DotNetBar.eTooltipColor.Gray))
            Me.buttonReplace.Text = "&Replace"
            ' 
            ' buttonGoto
            ' 
            Me.buttonGoto.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
            Me.buttonGoto.Enabled = False
            Me.buttonGoto.Image = (CType(resources.GetObject("buttonGoto.Image"), Image))
            Me.buttonGoto.Name = "buttonGoto"
            Me.superTooltip1.SetSuperTooltip(Me.buttonGoto, New DevComponents.DotNetBar.SuperTooltipInfo("Go to line", "", "Go to specified line number in current document." & vbCrLf & vbCrLf & "This feature has not been imp" & "lemented yet.", Nothing, Nothing, DevComponents.DotNetBar.eTooltipColor.Gray))
            Me.buttonGoto.Text = "&Goto"
            ' 
            ' ribbonBar5
            ' 
            Me.ribbonBar5.AutoOverflowEnabled = True
            ' 
            ' 
            ' 
            Me.ribbonBar5.BackgroundMouseOverStyle.Class = ""
            Me.ribbonBar5.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            ' 
            ' 
            ' 
            Me.ribbonBar5.BackgroundStyle.Class = ""
            Me.ribbonBar5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.ribbonBar5.ContainerControlProcessDialogKey = True
            Me.ribbonBar5.DialogLauncherVisible = True
            Me.ribbonBar5.Dock = DockStyle.Left
            Me.ribbonBar5.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.buttonMargins, Me.buttonItem9, Me.buttonItem10, Me.buttonItem11})
            Me.ribbonBar5.Location = New Point(3, 0)
            Me.ribbonBar5.Name = "ribbonBar5"
            Me.ribbonBar5.Size = New Size(319, 90)
            Me.ribbonBar5.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.ribbonBar5.TabIndex = 1
            Me.ribbonBar5.Text = "Page Setup"
            ' 
            ' 
            ' 
            Me.ribbonBar5.TitleStyle.Class = ""
            Me.ribbonBar5.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            ' 
            ' 
            ' 
            Me.ribbonBar5.TitleStyleMouseOver.Class = ""
            Me.ribbonBar5.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
            '			Me.ribbonBar5.LaunchDialog += New System.EventHandler(Me.LaunchRibbonDialog)
            ' 
            ' buttonMargins
            ' 
            Me.buttonMargins.Image = (CType(resources.GetObject("buttonMargins.Image"), Image))
            Me.buttonMargins.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
            Me.buttonMargins.Name = "buttonMargins"
            Me.buttonMargins.Text = "Margins"
            ' 
            ' buttonItem9
            ' 
            Me.buttonItem9.AutoExpandOnClick = True
            Me.buttonItem9.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
            Me.buttonItem9.Image = (CType(resources.GetObject("buttonItem9.Image"), Image))
            Me.buttonItem9.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
            Me.buttonItem9.Name = "buttonItem9"
            Me.buttonItem9.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.buttonItem50, Me.buttonItem51, Me.buttonItem52})
            Me.buttonItem9.Text = "Orientation <expand/>"
            ' 
            ' buttonItem50
            ' 
            Me.buttonItem50.Checked = True
            Me.buttonItem50.Name = "buttonItem50"
            Me.buttonItem50.OptionGroup = "orientation"
            Me.buttonItem50.Text = "Auto"
            ' 
            ' buttonItem51
            ' 
            Me.buttonItem51.Name = "buttonItem51"
            Me.buttonItem51.OptionGroup = "orientation"
            Me.buttonItem51.Text = "Horizontal"
            ' 
            ' buttonItem52
            ' 
            Me.buttonItem52.Name = "buttonItem52"
            Me.buttonItem52.OptionGroup = "orientation"
            Me.buttonItem52.Text = "Vertical"
            ' 
            ' buttonItem10
            ' 
            Me.buttonItem10.Image = (CType(resources.GetObject("buttonItem10.Image"), Image))
            Me.buttonItem10.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
            Me.buttonItem10.Name = "buttonItem10"
            Me.buttonItem10.Text = "Size"
            ' 
            ' buttonItem11
            ' 
            Me.buttonItem11.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
            Me.buttonItem11.Image = (CType(resources.GetObject("buttonItem11.Image"), Image))
            Me.buttonItem11.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
            Me.buttonItem11.Name = "buttonItem11"
            Me.buttonItem11.Text = "Print Area"
            ' 
            ' contextMenuBar1
            ' 
            Me.contextMenuBar1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.bEditPopup})
            Me.contextMenuBar1.Location = New Point(352, 309)
            Me.contextMenuBar1.Name = "contextMenuBar1"
            Me.contextMenuBar1.Size = New Size(150, 25)
            Me.contextMenuBar1.Stretch = True
            Me.contextMenuBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.contextMenuBar1.TabIndex = 13
            Me.contextMenuBar1.TabStop = False
            ' 
            ' bEditPopup
            ' 
            Me.bEditPopup.AutoExpandOnClick = True
            Me.bEditPopup.GlobalName = "bEditPopup"
            Me.bEditPopup.Name = "bEditPopup"
            Me.bEditPopup.PopupAnimation = DevComponents.DotNetBar.ePopupAnimation.SystemDefault
            Me.bEditPopup.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.bCut, Me.bCopy, Me.bPaste, Me.bSelectAll})
            Me.bEditPopup.Text = "bEditPopup"
            ' 
            ' bCut
            ' 
            Me.bCut.BeginGroup = True
            Me.bCut.GlobalName = "bCut"
            Me.bCut.ImageIndex = 5
            Me.bCut.Name = "bCut"
            Me.bCut.PopupAnimation = DevComponents.DotNetBar.ePopupAnimation.SystemDefault
            Me.bCut.Text = "Cu&t"
            ' 
            ' bCopy
            ' 
            Me.bCopy.GlobalName = "bCopy"
            Me.bCopy.ImageIndex = 4
            Me.bCopy.Name = "bCopy"
            Me.bCopy.PopupAnimation = DevComponents.DotNetBar.ePopupAnimation.SystemDefault
            Me.bCopy.Text = "&Copy"
            ' 
            ' bPaste
            ' 
            Me.bPaste.GlobalName = "bPaste"
            Me.bPaste.ImageIndex = 12
            Me.bPaste.Name = "bPaste"
            Me.bPaste.PopupAnimation = DevComponents.DotNetBar.ePopupAnimation.SystemDefault
            Me.bPaste.Text = "&Paste"
            ' 
            ' bSelectAll
            ' 
            Me.bSelectAll.BeginGroup = True
            Me.bSelectAll.GlobalName = "bSelectAll"
            Me.bSelectAll.Name = "bSelectAll"
            Me.bSelectAll.PopupAnimation = DevComponents.DotNetBar.ePopupAnimation.SystemDefault
            Me.bSelectAll.Text = "Select &All"
            ' 
            ' buttonFile
            ' 
            Me.buttonFile.AutoExpandOnClick = True
            Me.buttonFile.BackstageTab = Me.superTabControl1
            Me.buttonFile.CanCustomize = False
            Me.buttonFile.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.Image
            Me.buttonFile.Image = (CType(resources.GetObject("buttonFile.Image"), Image))
            Me.buttonFile.ImageFixedSize = New Size(16, 16)
            Me.buttonFile.ImagePaddingHorizontal = 0
            Me.buttonFile.ImagePaddingVertical = 0
            Me.buttonFile.Name = "buttonFile"
            Me.buttonFile.ShowSubItems = False
            Me.buttonFile.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.menuFileContainer})
            Me.buttonFile.Text = "&File"
            ' 
            ' superTabControl1
            ' 
            Me.superTabControl1.Anchor = (CType((((AnchorStyles.Top Or AnchorStyles.Bottom) Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
            ' 
            ' 
            ' 
            ' 
            ' 
            ' 
            Me.superTabControl1.ControlBox.CloseBox.Name = ""
            ' 
            ' 
            ' 
            Me.superTabControl1.ControlBox.MenuBox.Name = ""
            Me.superTabControl1.ControlBox.Name = ""
            Me.superTabControl1.ControlBox.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.superTabControl1.ControlBox.MenuBox, Me.superTabControl1.ControlBox.CloseBox})
            Me.superTabControl1.ControlBox.Visible = False
            Me.superTabControl1.Controls.Add(Me.superTabControlPanel1)
            Me.superTabControl1.Controls.Add(Me.superTabControlPanel4)
            Me.superTabControl1.Controls.Add(Me.superTabControlPanel2)
            Me.superTabControl1.Controls.Add(Me.superTabControlPanel3)
            Me.superTabControl1.ItemPadding.Left = 6
            Me.superTabControl1.ItemPadding.Right = 4
            Me.superTabControl1.ItemPadding.Top = 4
            Me.superTabControl1.Location = New Point(5, 54)
            Me.superTabControl1.Name = "superTabControl1"
            Me.superTabControl1.ReorderTabsEnabled = False
            Me.superTabControl1.SelectedTabFont = New Font("Segoe UI", 9.75F)
            Me.superTabControl1.SelectedTabIndex = 0
            Me.superTabControl1.Size = New Size(766, 441)
            Me.superTabControl1.TabAlignment = DevComponents.DotNetBar.eTabStripAlignment.Left
            Me.superTabControl1.TabFont = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, (CByte(0)))
            Me.superTabControl1.TabHorizontalSpacing = 16
            Me.superTabControl1.TabIndex = 14
            Me.superTabControl1.Tabs.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.buttonItem61, Me.buttonItem63, Me.buttonItem64, Me.superTabItem1, Me.superTabItem2, Me.superTabItem3, Me.superTabItem4, Me.buttonItem65, Me.buttonItem66})
            Me.superTabControl1.TabStyle = DevComponents.DotNetBar.eSuperTabStyle.Office2010BackstageBlue
            Me.superTabControl1.TabVerticalSpacing = 8
            ' 
            ' superTabControlPanel1
            ' 
            Me.superTabControlPanel1.BackgroundImage = (CType(resources.GetObject("superTabControlPanel1.BackgroundImage"), Image))
            Me.superTabControlPanel1.BackgroundImagePosition = DevComponents.DotNetBar.eStyleBackgroundImage.BottomRight
            Me.superTabControlPanel1.Controls.Add(Me.panelEx2)
            Me.superTabControlPanel1.Controls.Add(Me.panelEx1)
            Me.superTabControlPanel1.Dock = DockStyle.Fill
            Me.superTabControlPanel1.Location = New Point(95, 0)
            Me.superTabControlPanel1.Name = "superTabControlPanel1"
            Me.superTabControlPanel1.Size = New Size(671, 441)
            Me.superTabControlPanel1.TabIndex = 1
            Me.superTabControlPanel1.TabItem = Me.superTabItem1
            ' 
            ' panelEx2
            ' 
            Me.panelEx2.CanvasColor = SystemColors.Control
            Me.panelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.panelEx2.Controls.Add(Me.recentPlacesItemsPanel)
            Me.panelEx2.Controls.Add(Me.labelX2)
            Me.panelEx2.Dock = DockStyle.Fill
            Me.panelEx2.Location = New Point(314, 0)
            Me.panelEx2.Name = "panelEx2"
            Me.panelEx2.Padding = New System.Windows.Forms.Padding(12)
            Me.panelEx2.Size = New Size(357, 441)
            Me.panelEx2.Style.Alignment = StringAlignment.Center
            Me.panelEx2.Style.BackColor1.Color = Color.Transparent
            Me.panelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
            Me.panelEx2.Style.BorderSide = DevComponents.DotNetBar.eBorderSide.Right
            Me.panelEx2.Style.GradientAngle = 90
            Me.panelEx2.TabIndex = 1
            Me.panelEx2.Text = "panelEx2"
            ' 
            ' recentPlacesItemsPanel
            ' 
            Me.recentPlacesItemsPanel.AutoScroll = True
            ' 
            ' 
            ' 
            Me.recentPlacesItemsPanel.BackgroundStyle.BackColor = Color.FromArgb((CInt((CByte(175)))), (CInt((CByte(255)))), (CInt((CByte(255)))), (CInt((CByte(255)))))
            Me.recentPlacesItemsPanel.BackgroundStyle.Class = ""
            Me.recentPlacesItemsPanel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.recentPlacesItemsPanel.ContainerControlProcessDialogKey = True
            Me.recentPlacesItemsPanel.Dock = DockStyle.Fill
            Me.recentPlacesItemsPanel.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical
            Me.recentPlacesItemsPanel.Location = New Point(12, 35)
            Me.recentPlacesItemsPanel.Name = "recentPlacesItemsPanel"
            Me.recentPlacesItemsPanel.Size = New Size(333, 394)
            Me.recentPlacesItemsPanel.TabIndex = 2
            ' 
            ' labelX2
            ' 
            ' 
            ' 
            ' 
            Me.labelX2.BackgroundStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Dash
            Me.labelX2.BackgroundStyle.BorderBottomColor = Color.Gray
            Me.labelX2.BackgroundStyle.BorderBottomWidth = 1
            Me.labelX2.BackgroundStyle.Class = ""
            Me.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.labelX2.Dock = DockStyle.Top
            Me.labelX2.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, (CByte(0)))
            Me.labelX2.ForeColor = Color.DimGray
            Me.labelX2.Location = New Point(12, 12)
            Me.labelX2.Name = "labelX2"
            Me.labelX2.Size = New Size(333, 23)
            Me.labelX2.TabIndex = 0
            Me.labelX2.Text = "Recent Places"
            ' 
            ' panelEx1
            ' 
            Me.panelEx1.CanvasColor = SystemColors.Control
            Me.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.panelEx1.Controls.Add(Me.recentDocsItemPane)
            Me.panelEx1.Controls.Add(Me.labelX1)
            Me.panelEx1.Dock = DockStyle.Left
            Me.panelEx1.Location = New Point(0, 0)
            Me.panelEx1.Name = "panelEx1"
            Me.panelEx1.Padding = New System.Windows.Forms.Padding(12)
            Me.panelEx1.Size = New Size(314, 441)
            Me.panelEx1.Style.Alignment = StringAlignment.Center
            Me.panelEx1.Style.BackColor1.Color = Color.Transparent
            Me.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
            Me.panelEx1.Style.BorderSide = DevComponents.DotNetBar.eBorderSide.Right
            Me.panelEx1.Style.GradientAngle = 90
            Me.panelEx1.TabIndex = 0
            Me.panelEx1.Text = "panelEx1"
            ' 
            ' recentDocsItemPane
            ' 
            Me.recentDocsItemPane.AutoScroll = True
            ' 
            ' 
            ' 
            Me.recentDocsItemPane.BackgroundStyle.BackColor = Color.FromArgb((CInt((CByte(255)))), (CInt((CByte(255)))), (CInt((CByte(255)))))
            Me.recentDocsItemPane.BackgroundStyle.Class = ""
            Me.recentDocsItemPane.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.recentDocsItemPane.ContainerControlProcessDialogKey = True
            Me.recentDocsItemPane.Dock = DockStyle.Fill
            Me.recentDocsItemPane.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical
            Me.recentDocsItemPane.Location = New Point(12, 35)
            Me.recentDocsItemPane.Name = "recentDocsItemPane"
            Me.recentDocsItemPane.Size = New Size(290, 394)
            Me.recentDocsItemPane.TabIndex = 1
            ' 
            ' labelX1
            ' 
            ' 
            ' 
            ' 
            Me.labelX1.BackgroundStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Dash
            Me.labelX1.BackgroundStyle.BorderBottomColor = Color.Gray
            Me.labelX1.BackgroundStyle.BorderBottomWidth = 1
            Me.labelX1.BackgroundStyle.Class = ""
            Me.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.labelX1.Dock = DockStyle.Top
            Me.labelX1.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, (CByte(0)))
            Me.labelX1.ForeColor = Color.DimGray
            Me.labelX1.Location = New Point(12, 12)
            Me.labelX1.Name = "labelX1"
            Me.labelX1.Size = New Size(290, 23)
            Me.labelX1.TabIndex = 0
            Me.labelX1.Text = "Recent Documents"
            ' 
            ' superTabItem1
            ' 
            Me.superTabItem1.AttachedControl = Me.superTabControlPanel1
            Me.superTabItem1.GlobalItem = False
            Me.superTabItem1.KeyTips = "R"
            Me.superTabItem1.Name = "superTabItem1"
            Me.superTabItem1.Text = "Recent"
            ' 
            ' superTabControlPanel4
            ' 
            Me.superTabControlPanel4.BackgroundImage = (CType(resources.GetObject("superTabControlPanel4.BackgroundImage"), Image))
            Me.superTabControlPanel4.BackgroundImagePosition = DevComponents.DotNetBar.eStyleBackgroundImage.BottomRight
            Me.superTabControlPanel4.Controls.Add(Me.itemPanel2)
            Me.superTabControlPanel4.Controls.Add(Me.labelX6)
            Me.superTabControlPanel4.Dock = DockStyle.Fill
            Me.superTabControlPanel4.Location = New Point(95, 0)
            Me.superTabControlPanel4.Name = "superTabControlPanel4"
            Me.superTabControlPanel4.Padding = New System.Windows.Forms.Padding(12)
            Me.superTabControlPanel4.Size = New Size(671, 441)
            Me.superTabControlPanel4.TabIndex = 4
            Me.superTabControlPanel4.TabItem = Me.superTabItem4
            ' 
            ' itemPanel2
            ' 
            Me.itemPanel2.AutoScroll = True
            Me.itemPanel2.BackColor = Color.Transparent
            ' 
            ' 
            ' 
            Me.itemPanel2.BackgroundStyle.BackColor = Color.FromArgb((CInt((CByte(175)))), (CInt((CByte(255)))), (CInt((CByte(255)))), (CInt((CByte(255)))))
            Me.itemPanel2.BackgroundStyle.Class = ""
            Me.itemPanel2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.itemPanel2.ContainerControlProcessDialogKey = True
            Me.itemPanel2.Dock = DockStyle.Fill
            Me.itemPanel2.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.buttonItem77, Me.buttonItem73, Me.buttonItem74, Me.buttonItem75, Me.buttonItem76})
            Me.itemPanel2.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical
            Me.itemPanel2.Location = New Point(12, 35)
            Me.itemPanel2.Name = "itemPanel2"
            Me.itemPanel2.Size = New Size(647, 394)
            Me.itemPanel2.TabIndex = 3
            ' 
            ' buttonItem77
            ' 
            Me.buttonItem77.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
            Me.buttonItem77.Command = Me.AppCommandGoToUrl
            Me.buttonItem77.CommandParameter = "http://www.devcomponents.com/kb/questions.php?questionid=127"
            Me.buttonItem77.ForeColor = Color.Black
            Me.buttonItem77.Image = (CType(resources.GetObject("buttonItem77.Image"), Image))
            Me.buttonItem77.Name = "buttonItem77"
            Me.buttonItem77.Text = "Backstage<br/>" & vbCrLf & "<font color=""Gray"">How to build Office 2010 style Backstage with " & "DotNetBar</font>"
            ' 
            ' AppCommandGoToUrl
            ' 
            Me.AppCommandGoToUrl.Name = "AppCommandGoToUrl"
            '			Me.AppCommandGoToUrl.Executed += New System.EventHandler(Me.AppCommandGoToUrl_Executed)
            ' 
            ' buttonItem73
            ' 
            Me.buttonItem73.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
            Me.buttonItem73.Command = Me.AppCommandGoToUrl
            Me.buttonItem73.CommandParameter = "http://www.devcomponents.com/kb/"
            Me.buttonItem73.ForeColor = Color.Black
            Me.buttonItem73.Image = (CType(resources.GetObject("buttonItem73.Image"), Image))
            Me.buttonItem73.Name = "buttonItem73"
            Me.buttonItem73.Text = "DotNetBar Knowledge Base<br/>" & vbCrLf & "<font color=""Gray"">Browse our online Knowledge Bas" & "e.</font>"
            ' 
            ' buttonItem74
            ' 
            Me.buttonItem74.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
            Me.buttonItem74.Command = Me.AppCommandGoToUrl
            Me.buttonItem74.CommandParameter = "http://www.devcomponents.com/dotnetbar/movies.aspx"
            Me.buttonItem74.ForeColor = Color.Black
            Me.buttonItem74.Image = (CType(resources.GetObject("buttonItem74.Image"), Image))
            Me.buttonItem74.Name = "buttonItem74"
            Me.buttonItem74.Text = "Movie Tutorials<br/>" & vbCrLf & "<font color=""Gray"">Watch getting started online movie tutor" & "ials</font>"
            ' 
            ' buttonItem75
            ' 
            Me.buttonItem75.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
            Me.buttonItem75.Command = Me.AppCommandGoToUrl
            Me.buttonItem75.CommandParameter = "http://www.devcomponents.com/support.aspx"
            Me.buttonItem75.ForeColor = Color.Black
            Me.buttonItem75.Image = (CType(resources.GetObject("buttonItem75.Image"), Image))
            Me.buttonItem75.Name = "buttonItem75"
            Me.buttonItem75.Text = "Contact Us<br/>" & vbCrLf & "<font color=""Gray"">Let us know if you need help or how we can ma" & "ke DotNetBar even better.</font>"
            ' 
            ' buttonItem76
            ' 
            Me.buttonItem76.BeginGroup = True
            Me.buttonItem76.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
            Me.buttonItem76.Command = Me.AppCommandGoToUrl
            Me.buttonItem76.CommandParameter = "http://www.devcomponents.com/dotnetbar/applicationgallery/"
            Me.buttonItem76.ForeColor = Color.Black
            Me.buttonItem76.Image = (CType(resources.GetObject("buttonItem76.Image"), Image))
            Me.buttonItem76.Name = "buttonItem76"
            Me.buttonItem76.Text = "Application Gallery<br/>" & vbCrLf & "<font color=""Gray"">See how other developers are using D" & "otNetBar in our application gallery</font>"
            ' 
            ' labelX6
            ' 
            ' 
            ' 
            ' 
            Me.labelX6.BackgroundStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Dash
            Me.labelX6.BackgroundStyle.BorderBottomColor = Color.Gray
            Me.labelX6.BackgroundStyle.BorderBottomWidth = 1
            Me.labelX6.BackgroundStyle.Class = ""
            Me.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.labelX6.Dock = DockStyle.Top
            Me.labelX6.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, (CByte(0)))
            Me.labelX6.ForeColor = Color.DimGray
            Me.labelX6.Location = New Point(12, 12)
            Me.labelX6.Name = "labelX6"
            Me.labelX6.Size = New Size(647, 23)
            Me.labelX6.TabIndex = 2
            Me.labelX6.Text = "Support"
            ' 
            ' superTabItem4
            ' 
            Me.superTabItem4.AttachedControl = Me.superTabControlPanel4
            Me.superTabItem4.GlobalItem = False
            Me.superTabItem4.KeyTips = "H"
            Me.superTabItem4.Name = "superTabItem4"
            Me.superTabItem4.Text = "Help"
            ' 
            ' superTabControlPanel2
            ' 
            Me.superTabControlPanel2.BackgroundImage = (CType(resources.GetObject("superTabControlPanel2.BackgroundImage"), Image))
            Me.superTabControlPanel2.BackgroundImagePosition = DevComponents.DotNetBar.eStyleBackgroundImage.BottomRight
            Me.superTabControlPanel2.Controls.Add(Me.itemPanel1)
            Me.superTabControlPanel2.Controls.Add(Me.labelX3)
            Me.superTabControlPanel2.Dock = DockStyle.Fill
            Me.superTabControlPanel2.Location = New Point(95, 0)
            Me.superTabControlPanel2.Name = "superTabControlPanel2"
            Me.superTabControlPanel2.Padding = New System.Windows.Forms.Padding(12)
			Me.superTabControlPanel2.Size = New Size(671, 441)
			Me.superTabControlPanel2.TabIndex = 2
			Me.superTabControlPanel2.TabItem = Me.superTabItem2
			' 
			' itemPanel1
			' 
			Me.itemPanel1.AutoScroll = True
			Me.itemPanel1.BackColor = Color.Transparent
			' 
			' 
			' 
			Me.itemPanel1.BackgroundStyle.BackColor = Color.FromArgb((CInt((CByte(175)))), (CInt((CByte(255)))), (CInt((CByte(255)))), (CInt((CByte(255)))))
			Me.itemPanel1.BackgroundStyle.Class = ""
			Me.itemPanel1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
			Me.itemPanel1.ContainerControlProcessDialogKey = True
			Me.itemPanel1.Dock = DockStyle.Fill
			Me.itemPanel1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() { Me.buttonItem67, Me.buttonItem68, Me.buttonItem69, Me.buttonItem70, Me.buttonItem71, Me.buttonItem72})
			Me.itemPanel1.Location = New Point(12, 35)
			Me.itemPanel1.MultiLine = True
			Me.itemPanel1.Name = "itemPanel1"
			Me.itemPanel1.Size = New Size(647, 394)
			Me.itemPanel1.TabIndex = 3
			' 
			' buttonItem67
			' 
			Me.buttonItem67.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
			Me.buttonItem67.Command = Me.AppCommandNew
			Me.buttonItem67.ForeColor = Color.Black
			Me.buttonItem67.Image = (CType(resources.GetObject("buttonItem67.Image"), Image))
			Me.buttonItem67.ImagePaddingVertical = 12
			Me.buttonItem67.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
			Me.buttonItem67.Name = "buttonItem67"
			Me.buttonItem67.Text = "<span align=""center"">Blank<br/>document</span>"
			' 
			' AppCommandNew
			' 
			Me.AppCommandNew.Name = "AppCommandNew"
'			Me.AppCommandNew.Executed += New System.EventHandler(Me.AppCommandNew_Executed)
			' 
			' buttonItem68
			' 
			Me.buttonItem68.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
			Me.buttonItem68.ForeColor = Color.Black
			Me.buttonItem68.Image = (CType(resources.GetObject("buttonItem68.Image"), Image))
			Me.buttonItem68.ImagePaddingVertical = 12
			Me.buttonItem68.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
			Me.buttonItem68.Name = "buttonItem68"
			Me.buttonItem68.Text = "Blog post"
			' 
			' buttonItem69
			' 
			Me.buttonItem69.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
			Me.buttonItem69.ForeColor = Color.Black
			Me.buttonItem69.Image = (CType(resources.GetObject("buttonItem69.Image"), Image))
			Me.buttonItem69.ImagePaddingHorizontal = 12
			Me.buttonItem69.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
			Me.buttonItem69.Name = "buttonItem69"
			Me.buttonItem69.Text = "<span align=""center"">Recent<br/>templates</span>"
			' 
			' buttonItem70
			' 
			Me.buttonItem70.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
			Me.buttonItem70.ForeColor = Color.Black
			Me.buttonItem70.Image = (CType(resources.GetObject("buttonItem70.Image"), Image))
			Me.buttonItem70.ImagePaddingHorizontal = 12
			Me.buttonItem70.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
			Me.buttonItem70.Name = "buttonItem70"
			Me.buttonItem70.Text = "<span align=""center"">Sample<br/>templates</span>"
			' 
			' buttonItem71
			' 
			Me.buttonItem71.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
			Me.buttonItem71.ForeColor = Color.Black
			Me.buttonItem71.Image = (CType(resources.GetObject("buttonItem71.Image"), Image))
			Me.buttonItem71.ImagePaddingHorizontal = 12
			Me.buttonItem71.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
			Me.buttonItem71.Name = "buttonItem71"
			Me.buttonItem71.Text = "My templates"
			' 
			' buttonItem72
			' 
			Me.buttonItem72.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
			Me.buttonItem72.ForeColor = Color.Black
			Me.buttonItem72.Image = (CType(resources.GetObject("buttonItem72.Image"), Image))
			Me.buttonItem72.ImagePaddingHorizontal = 12
			Me.buttonItem72.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
			Me.buttonItem72.Name = "buttonItem72"
			Me.buttonItem72.Text = "<span align=""center"">New from<br/>existing</span>"
			' 
			' labelX3
			' 
			' 
			' 
			' 
			Me.labelX3.BackgroundStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Dash
			Me.labelX3.BackgroundStyle.BorderBottomColor = Color.Gray
			Me.labelX3.BackgroundStyle.BorderBottomWidth = 1
			Me.labelX3.BackgroundStyle.Class = ""
			Me.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
			Me.labelX3.Dock = DockStyle.Top
			Me.labelX3.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, (CByte(0)))
			Me.labelX3.ForeColor = Color.DimGray
			Me.labelX3.Location = New Point(12, 12)
			Me.labelX3.Name = "labelX3"
			Me.labelX3.Size = New Size(647, 23)
			Me.labelX3.TabIndex = 1
			Me.labelX3.Text = "Available Templates"
			' 
			' superTabItem2
			' 
			Me.superTabItem2.AttachedControl = Me.superTabControlPanel2
			Me.superTabItem2.GlobalItem = False
			Me.superTabItem2.KeyTips = "N"
			Me.superTabItem2.Name = "superTabItem2"
			Me.superTabItem2.Text = "New"
			' 
			' superTabControlPanel3
			' 
			Me.superTabControlPanel3.BackgroundImagePosition = DevComponents.DotNetBar.eStyleBackgroundImage.BottomRight
			Me.superTabControlPanel3.Controls.Add(Me.panelEx3)
			Me.superTabControlPanel3.Controls.Add(Me.labelX5)
			Me.superTabControlPanel3.Controls.Add(Me.integerInput1)
			Me.superTabControlPanel3.Controls.Add(Me.labelX4)
			Me.superTabControlPanel3.Controls.Add(Me.buttonX1)
			Me.superTabControlPanel3.Dock = DockStyle.Fill
			Me.superTabControlPanel3.Location = New Point(95, 0)
			Me.superTabControlPanel3.Name = "superTabControlPanel3"
			Me.superTabControlPanel3.Size = New Size(671, 441)
			Me.superTabControlPanel3.TabIndex = 3
			Me.superTabControlPanel3.TabItem = Me.superTabItem3
			' 
			' panelEx3
			' 
			Me.panelEx3.Anchor = (CType((((AnchorStyles.Top Or AnchorStyles.Bottom) Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
			Me.panelEx3.CanvasColor = SystemColors.Control
			Me.panelEx3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
			Me.panelEx3.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, (CByte(0)))
			Me.panelEx3.Location = New Point(292, 4)
			Me.panelEx3.Name = "panelEx3"
			Me.panelEx3.Size = New Size(376, 434)
			Me.panelEx3.Style.Alignment = StringAlignment.Center
			Me.panelEx3.Style.BackColor1.Color = Color.White
			Me.panelEx3.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
			Me.panelEx3.Style.BorderColor.Color = Color.Silver
			Me.panelEx3.Style.BorderSide = DevComponents.DotNetBar.eBorderSide.Left
			Me.panelEx3.Style.ForeColor.Color = Color.Gray
			Me.panelEx3.Style.GradientAngle = 90
			Me.panelEx3.TabIndex = 5
			Me.panelEx3.Text = "Print Preview Goes Here..."
			' 
			' labelX5
			' 
			' 
			' 
			' 
			Me.labelX5.BackgroundStyle.Class = ""
			Me.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
			Me.labelX5.ForeColor = Color.Black
			Me.labelX5.Location = New Point(143, 54)
			Me.labelX5.Name = "labelX5"
			Me.labelX5.Size = New Size(48, 19)
			Me.labelX5.TabIndex = 4
			Me.labelX5.Text = "Copies:"
			' 
			' integerInput1
			' 
			' 
			' 
			' 
			Me.integerInput1.BackgroundStyle.Class = "DateTimeInputBackground"
			Me.integerInput1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
			Me.integerInput1.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
			Me.integerInput1.Location = New Point(198, 53)
			Me.integerInput1.Name = "integerInput1"
			Me.integerInput1.ShowUpDown = True
			Me.integerInput1.Size = New Size(66, 20)
			Me.integerInput1.TabIndex = 3
			Me.integerInput1.Value = 1
			' 
			' labelX4
			' 
			' 
			' 
			' 
			Me.labelX4.BackgroundStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Dash
			Me.labelX4.BackgroundStyle.BorderBottomColor = Color.Gray
			Me.labelX4.BackgroundStyle.BorderBottomWidth = 1
			Me.labelX4.BackgroundStyle.Class = ""
			Me.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
			Me.labelX4.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, (CByte(0)))
			Me.labelX4.ForeColor = Color.DimGray
			Me.labelX4.Location = New Point(144, 16)
			Me.labelX4.Name = "labelX4"
			Me.labelX4.Size = New Size(120, 23)
			Me.labelX4.TabIndex = 2
			Me.labelX4.Text = "Print"
			' 
			' buttonX1
			' 
			Me.buttonX1.AccessibleRole = AccessibleRole.PushButton
			Me.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground
			Me.buttonX1.ForeColor = Color.Black
			Me.buttonX1.Image = (CType(resources.GetObject("buttonX1.Image"), Image))
			Me.buttonX1.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
			Me.buttonX1.Location = New Point(21, 21)
			Me.buttonX1.Name = "buttonX1"
			Me.buttonX1.Size = New Size(109, 101)
			Me.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
			Me.buttonX1.TabIndex = 0
			Me.buttonX1.Text = "Print"
			' 
			' superTabItem3
			' 
			Me.superTabItem3.AttachedControl = Me.superTabControlPanel3
			Me.superTabItem3.GlobalItem = False
			Me.superTabItem3.KeyTips = "P"
			Me.superTabItem3.Name = "superTabItem3"
			Me.superTabItem3.Text = "Print"
			' 
			' buttonItem61
			' 
			Me.buttonItem61.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
			Me.buttonItem61.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue
			Me.buttonItem61.Command = Me.AppCommandSave
			Me.buttonItem61.Image = (CType(resources.GetObject("buttonItem61.Image"), Image))
			Me.buttonItem61.ImagePaddingHorizontal = 18
			Me.buttonItem61.ImagePaddingVertical = 10
			Me.buttonItem61.KeyTips = "S"
			Me.buttonItem61.Name = "buttonItem61"
			Me.buttonItem61.Stretch = True
			Me.buttonItem61.Text = "Save"
			' 
			' AppCommandSave
			' 
			Me.AppCommandSave.Name = "AppCommandSave"
'			Me.AppCommandSave.Executed += New System.EventHandler(Me.AppCommandSave_Executed)
			' 
			' buttonItem63
			' 
			Me.buttonItem63.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
			Me.buttonItem63.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue
			Me.buttonItem63.Command = Me.AppCommandOpen
			Me.buttonItem63.Image = (CType(resources.GetObject("buttonItem63.Image"), Image))
			Me.buttonItem63.ImagePaddingHorizontal = 18
			Me.buttonItem63.ImagePaddingVertical = 10
			Me.buttonItem63.KeyTips = "O"
			Me.buttonItem63.Name = "buttonItem63"
			Me.buttonItem63.Stretch = True
			Me.buttonItem63.Text = "Open"
			' 
			' AppCommandOpen
			' 
			Me.AppCommandOpen.Name = "AppCommandOpen"
'			Me.AppCommandOpen.Executed += New System.EventHandler(Me.AppCommandOpen_Executed)
			' 
			' buttonItem64
			' 
			Me.buttonItem64.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
			Me.buttonItem64.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue
			Me.buttonItem64.Image = (CType(resources.GetObject("buttonItem64.Image"), Image))
			Me.buttonItem64.ImagePaddingHorizontal = 18
			Me.buttonItem64.ImagePaddingVertical = 10
			Me.buttonItem64.KeyTips = "C"
			Me.buttonItem64.Name = "buttonItem64"
			Me.buttonItem64.Stretch = True
			Me.buttonItem64.Text = "Close"
			' 
			' buttonItem65
			' 
			Me.buttonItem65.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
			Me.buttonItem65.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue
			Me.buttonItem65.Image = (CType(resources.GetObject("buttonItem65.Image"), Image))
			Me.buttonItem65.ImagePaddingHorizontal = 18
			Me.buttonItem65.ImagePaddingVertical = 10
			Me.buttonItem65.KeyTips = "T"
			Me.buttonItem65.Name = "buttonItem65"
			Me.buttonItem65.Stretch = True
			Me.buttonItem65.Text = "Options"
			' 
			' buttonItem66
			' 
			Me.buttonItem66.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
			Me.buttonItem66.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue
			Me.buttonItem66.Command = Me.AppCommandExit
			Me.buttonItem66.Image = (CType(resources.GetObject("buttonItem66.Image"), Image))
			Me.buttonItem66.ImagePaddingHorizontal = 18
			Me.buttonItem66.ImagePaddingVertical = 10
			Me.buttonItem66.KeyTips = "X"
			Me.buttonItem66.Name = "buttonItem66"
			Me.buttonItem66.Stretch = True
			Me.buttonItem66.Text = "Exit"
			' 
			' AppCommandExit
			' 
			Me.AppCommandExit.Name = "AppCommandExit"
'			Me.AppCommandExit.Executed += New System.EventHandler(Me.AppCommandExit_Executed)
			' 
			' menuFileContainer
			' 
			' 
			' 
			' 
			Me.menuFileContainer.BackgroundStyle.Class = "RibbonFileMenuContainer"
			Me.menuFileContainer.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
			Me.menuFileContainer.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical
			Me.menuFileContainer.Name = "menuFileContainer"
			Me.menuFileContainer.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() { Me.menuFileTwoColumnContainer, Me.menuFileBottomContainer})
			' 
			' menuFileTwoColumnContainer
			' 
			' 
			' 
			' 
			Me.menuFileTwoColumnContainer.BackgroundStyle.Class = "RibbonFileMenuTwoColumnContainer"
			Me.menuFileTwoColumnContainer.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
			Me.menuFileTwoColumnContainer.BackgroundStyle.PaddingBottom = 2
			Me.menuFileTwoColumnContainer.BackgroundStyle.PaddingLeft = 2
			Me.menuFileTwoColumnContainer.BackgroundStyle.PaddingRight = 2
			Me.menuFileTwoColumnContainer.BackgroundStyle.PaddingTop = 2
			Me.menuFileTwoColumnContainer.ItemSpacing = 0
			Me.menuFileTwoColumnContainer.Name = "menuFileTwoColumnContainer"
			Me.menuFileTwoColumnContainer.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() { Me.menuFileItems, Me.menuFileMRU})
			' 
			' menuFileItems
			' 
			' 
			' 
			' 
			Me.menuFileItems.BackgroundStyle.Class = "RibbonFileMenuColumnOneContainer"
			Me.menuFileItems.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
			Me.menuFileItems.ItemSpacing = 5
			Me.menuFileItems.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical
			Me.menuFileItems.MinimumSize = New Size(120, 0)
			Me.menuFileItems.Name = "menuFileItems"
			Me.menuFileItems.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() { Me.buttonItem20, Me.buttonItem21, Me.buttonFileSaveAs, Me.buttonItem23, Me.buttonItem24, Me.buttonItem25})
			' 
			' buttonItem20
			' 
			Me.buttonItem20.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
			Me.buttonItem20.Command = Me.AppCommandNew
			Me.buttonItem20.Image = (CType(resources.GetObject("buttonItem20.Image"), Image))
			Me.buttonItem20.ImageSmall = (CType(resources.GetObject("buttonItem20.ImageSmall"), Image))
			Me.buttonItem20.Name = "buttonItem20"
			Me.buttonItem20.SubItemsExpandWidth = 24
			Me.buttonItem20.Text = "&New"
			' 
			' buttonItem21
			' 
			Me.buttonItem21.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
			Me.buttonItem21.Command = Me.AppCommandOpen
			Me.buttonItem21.Image = (CType(resources.GetObject("buttonItem21.Image"), Image))
			Me.buttonItem21.Name = "buttonItem21"
			Me.buttonItem21.SubItemsExpandWidth = 24
			Me.buttonItem21.Text = "&Open..."
			' 
			' buttonFileSaveAs
			' 
			Me.buttonFileSaveAs.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
			Me.buttonFileSaveAs.Command = Me.AppCommandSaveAs
			Me.buttonFileSaveAs.Image = (CType(resources.GetObject("buttonFileSaveAs.Image"), Image))
			Me.buttonFileSaveAs.ImageSmall = (CType(resources.GetObject("buttonFileSaveAs.ImageSmall"), Image))
			Me.buttonFileSaveAs.Name = "buttonFileSaveAs"
			Me.buttonFileSaveAs.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() { Me.itemContainer12})
			Me.buttonFileSaveAs.SubItemsExpandWidth = 24
			Me.buttonFileSaveAs.Text = "&Save As..."
'			Me.buttonFileSaveAs.ExpandChange += New System.EventHandler(Me.buttonFileSaveAs_ExpandChange)
			' 
			' AppCommandSaveAs
			' 
			Me.AppCommandSaveAs.Name = "AppCommandSaveAs"
'			Me.AppCommandSaveAs.Executed += New System.EventHandler(Me.AppCommandSaveAs_Executed)
			' 
			' itemContainer12
			' 
			' 
			' 
			' 
			Me.itemContainer12.BackgroundStyle.Class = ""
			Me.itemContainer12.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
			Me.itemContainer12.ItemSpacing = 4
			Me.itemContainer12.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical
			Me.itemContainer12.MinimumSize = New Size(210, 256)
			Me.itemContainer12.Name = "itemContainer12"
			Me.itemContainer12.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() { Me.labelItem1, Me.buttonItem56, Me.buttonItem57, Me.buttonItem58, Me.buttonItem59})
			' 
			' labelItem1
			' 
			Me.labelItem1.BackColor = Color.FromArgb((CInt((CByte(235)))), (CInt((CByte(235)))), (CInt((CByte(235)))))
			Me.labelItem1.BorderSide = DevComponents.DotNetBar.eBorderSide.Bottom
			Me.labelItem1.BorderType = DevComponents.DotNetBar.eBorderType.Etched
			Me.labelItem1.Name = "labelItem1"
			Me.labelItem1.PaddingBottom = 5
			Me.labelItem1.PaddingLeft = 5
			Me.labelItem1.PaddingRight = 5
			Me.labelItem1.PaddingTop = 5
			Me.labelItem1.Text = "<b>Save a copy of the document</b>"
			' 
			' buttonItem56
			' 
			Me.buttonItem56.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
			Me.buttonItem56.Image = (CType(resources.GetObject("buttonItem56.Image"), Image))
			Me.buttonItem56.Name = "buttonItem56"
			Me.buttonItem56.Text = "<b>&Rich Text Document</b>" & vbCrLf & "<div padding=""0,0,4,0"" width=""170"">Save the document " & "in the default file format.</div>"
			' 
			' buttonItem57
			' 
			Me.buttonItem57.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
			Me.buttonItem57.Image = (CType(resources.GetObject("buttonItem57.Image"), Image))
			Me.buttonItem57.Name = "buttonItem57"
			Me.buttonItem57.Text = "<b>Document &Template</b>" & vbCrLf & "<div padding=""0,0,4,0"" width=""170"">Save as a template " & "that can be used to format future documents.</div>"
			' 
			' buttonItem58
			' 
			Me.buttonItem58.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
			Me.buttonItem58.Image = (CType(resources.GetObject("buttonItem58.Image"), Image))
			Me.buttonItem58.Name = "buttonItem58"
			Me.buttonItem58.Text = "<b>&Find add-ins for other formats</b>" & vbCrLf & "<div padding=""0,0,4,0"" width=""180"">Learn " & "about add-ins to save to other formats such as PDF or XPS.</div>"
			' 
			' buttonItem59
			' 
			Me.buttonItem59.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
			Me.buttonItem59.Image = (CType(resources.GetObject("buttonItem59.Image"), Image))
			Me.buttonItem59.Name = "buttonItem59"
			Me.buttonItem59.Text = "<b>&Other Formats</b>" & vbCrLf & "<div padding=""0,0,4,0"" width=""170"">Open the Save As dialog" & " box to select from all possible file types.</div>"
			' 
			' buttonItem23
			' 
			Me.buttonItem23.BeginGroup = True
			Me.buttonItem23.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
			Me.buttonItem23.Image = (CType(resources.GetObject("buttonItem23.Image"), Image))
			Me.buttonItem23.Name = "buttonItem23"
			Me.buttonItem23.SubItemsExpandWidth = 24
			Me.buttonItem23.Text = "S&hare..."
			' 
			' buttonItem24
			' 
			Me.buttonItem24.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
			Me.buttonItem24.Image = (CType(resources.GetObject("buttonItem24.Image"), Image))
			Me.buttonItem24.Name = "buttonItem24"
			Me.buttonItem24.SubItemsExpandWidth = 24
			Me.buttonItem24.Text = "&Print..."
			' 
			' buttonItem25
			' 
			Me.buttonItem25.BeginGroup = True
			Me.buttonItem25.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
			Me.buttonItem25.Image = (CType(resources.GetObject("buttonItem25.Image"), Image))
			Me.buttonItem25.Name = "buttonItem25"
			Me.buttonItem25.SubItemsExpandWidth = 24
			Me.buttonItem25.Text = "&Close"
			' 
			' menuFileMRU
			' 
			' 
			' 
			' 
			Me.menuFileMRU.BackgroundStyle.Class = "RibbonFileMenuColumnTwoContainer"
			Me.menuFileMRU.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
			Me.menuFileMRU.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical
			Me.menuFileMRU.MinimumSize = New Size(225, 0)
			Me.menuFileMRU.Name = "menuFileMRU"
			Me.menuFileMRU.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() { Me.labelItem8, Me.buttonItem26, Me.buttonItem27, Me.buttonItem28, Me.buttonItem29})
			' 
			' labelItem8
			' 
			Me.labelItem8.BorderSide = DevComponents.DotNetBar.eBorderSide.Bottom
			Me.labelItem8.BorderType = DevComponents.DotNetBar.eBorderType.Etched
			Me.labelItem8.Name = "labelItem8"
			Me.labelItem8.PaddingBottom = 2
			Me.labelItem8.PaddingTop = 2
			Me.labelItem8.Stretch = True
			Me.labelItem8.Text = "Recent Documents"
			' 
			' buttonItem26
			' 
			Me.buttonItem26.Name = "buttonItem26"
			Me.buttonItem26.Text = "&1. Short News 5-7.rtf"
			' 
			' buttonItem27
			' 
			Me.buttonItem27.Name = "buttonItem27"
			Me.buttonItem27.Text = "&2. Prospect Email.rtf"
			' 
			' buttonItem28
			' 
			Me.buttonItem28.Name = "buttonItem28"
			Me.buttonItem28.Text = "&3. Customer Email.rtf"
			' 
			' buttonItem29
			' 
			Me.buttonItem29.Name = "buttonItem29"
			Me.buttonItem29.Text = "&4. example.rtf"
			' 
			' menuFileBottomContainer
			' 
			' 
			' 
			' 
			Me.menuFileBottomContainer.BackgroundStyle.Class = "RibbonFileMenuBottomContainer"
			Me.menuFileBottomContainer.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
			Me.menuFileBottomContainer.HorizontalItemAlignment = DevComponents.DotNetBar.eHorizontalItemsAlignment.Right
			Me.menuFileBottomContainer.Name = "menuFileBottomContainer"
			Me.menuFileBottomContainer.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() { Me.buttonOptions, Me.buttonExit})
			' 
			' buttonOptions
			' 
			Me.buttonOptions.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
			Me.buttonOptions.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
			Me.buttonOptions.Image = (CType(resources.GetObject("buttonOptions.Image"), Image))
			Me.buttonOptions.Name = "buttonOptions"
			Me.buttonOptions.SubItemsExpandWidth = 24
			Me.buttonOptions.Text = "RibbonPad Opt&ions"
			' 
			' buttonExit
			' 
			Me.buttonExit.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
			Me.buttonExit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
			Me.buttonExit.Command = Me.AppCommandExit
			Me.buttonExit.Image = (CType(resources.GetObject("buttonExit.Image"), Image))
			Me.buttonExit.Name = "buttonExit"
			Me.buttonExit.SubItemsExpandWidth = 24
			Me.buttonExit.Text = "E&xit RibbonPad"
			' 
			' ribbonTabItem1
			' 
			Me.ribbonTabItem1.Checked = True
			Me.ribbonTabItem1.Name = "ribbonTabItem1"
			Me.ribbonTabItem1.Panel = Me.ribbonPanel1
			Me.ribbonTabItem1.Text = "&Write"
			' 
			' ribbonTabItem3
			' 
			Me.ribbonTabItem3.Name = "ribbonTabItem3"
			Me.ribbonTabItem3.Panel = Me.ribbonPanel3
			Me.ribbonTabItem3.Text = "Page &Layout"
			' 
			' ribbonTabContext
			' 
			Me.ribbonTabContext.ColorTable = DevComponents.DotNetBar.eRibbonTabColor.Orange
			Me.ribbonTabContext.Group = Me.ribbonTabItemGroup1
			Me.ribbonTabContext.Name = "ribbonTabContext"
			Me.ribbonTabContext.Panel = Me.ribbonPanel2
			Me.ribbonTabContext.Text = "Context &Tab"
			Me.ribbonTabContext.Visible = False
			' 
			' ribbonTabItemGroup1
			' 
			Me.ribbonTabItemGroup1.Color = DevComponents.DotNetBar.eRibbonTabGroupColor.Orange
			Me.ribbonTabItemGroup1.GroupTitle = "Tab Group"
			Me.ribbonTabItemGroup1.Name = "ribbonTabItemGroup1"
			' 
			' 
			' 
			Me.ribbonTabItemGroup1.Style.BackColor = Color.FromArgb((CInt((CByte(240)))), (CInt((CByte(158)))), (CInt((CByte(159)))))
			Me.ribbonTabItemGroup1.Style.BackColor2 = Color.FromArgb((CInt((CByte(249)))), (CInt((CByte(225)))), (CInt((CByte(226)))))
			Me.ribbonTabItemGroup1.Style.BackColorGradientAngle = 90
			Me.ribbonTabItemGroup1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
			Me.ribbonTabItemGroup1.Style.BorderBottomWidth = 1
			Me.ribbonTabItemGroup1.Style.BorderColor = Color.FromArgb((CInt((CByte(154)))), (CInt((CByte(58)))), (CInt((CByte(59)))))
			Me.ribbonTabItemGroup1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
			Me.ribbonTabItemGroup1.Style.BorderLeftWidth = 1
			Me.ribbonTabItemGroup1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
			Me.ribbonTabItemGroup1.Style.BorderRightWidth = 1
			Me.ribbonTabItemGroup1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
			Me.ribbonTabItemGroup1.Style.BorderTopWidth = 1
			Me.ribbonTabItemGroup1.Style.Class = ""
			Me.ribbonTabItemGroup1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square
			Me.ribbonTabItemGroup1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
			Me.ribbonTabItemGroup1.Style.TextColor = Color.Black
			Me.ribbonTabItemGroup1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
			' 
			' buttonChangeStyle
			' 
			Me.buttonChangeStyle.AutoExpandOnClick = True
			Me.buttonChangeStyle.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Far
			Me.buttonChangeStyle.Name = "buttonChangeStyle"
			Me.buttonChangeStyle.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() { Me.buttonStyleOffice2010Blue, Me.buttonStyleOffice2010Silver, Me.buttonStyleOffice2010Black, Me.buttonStyleVS2010, Me.buttonItem62, Me.buttonStyleOffice2007Blue, Me.buttonStyleOffice2007Black, Me.buttonStyleOffice2007Silver, Me.buttonItem60, Me.buttonStyleCustom})
			Me.superTooltip1.SetSuperTooltip(Me.buttonChangeStyle, New DevComponents.DotNetBar.SuperTooltipInfo("Change the style", "", "Change the style of all DotNetBar User Interface elements.", Nothing, Nothing, DevComponents.DotNetBar.eTooltipColor.Gray))
			Me.buttonChangeStyle.Text = "Style"
			' 
			' buttonStyleOffice2010Blue
			' 
			Me.buttonStyleOffice2010Blue.Command = Me.AppCommandTheme
			Me.buttonStyleOffice2010Blue.CommandParameter = "Office2010Blue"
			Me.buttonStyleOffice2010Blue.Name = "buttonStyleOffice2010Blue"
			Me.buttonStyleOffice2010Blue.OptionGroup = "style"
			Me.buttonStyleOffice2010Blue.Text = "Office 2010 Blue"
			' 
			' AppCommandTheme
			' 
			Me.AppCommandTheme.Name = "AppCommandTheme"
'			Me.AppCommandTheme.Executed += New System.EventHandler(Me.AppCommandTheme_Executed)
			' 
			' buttonStyleOffice2010Silver
			' 
			Me.buttonStyleOffice2010Silver.Command = Me.AppCommandTheme
			Me.buttonStyleOffice2010Silver.CommandParameter = "Office2010Silver"
			Me.buttonStyleOffice2010Silver.Name = "buttonStyleOffice2010Silver"
			Me.buttonStyleOffice2010Silver.OptionGroup = "style"
			Me.buttonStyleOffice2010Silver.Text = "Office 2010 <font color=""Silver""><b>Silver</b></font>"
			' 
			' buttonStyleOffice2010Black
			' 
			Me.buttonStyleOffice2010Black.Command = Me.AppCommandTheme
			Me.buttonStyleOffice2010Black.CommandParameter = "Office2010Black"
			Me.buttonStyleOffice2010Black.Name = "buttonStyleOffice2010Black"
			Me.buttonStyleOffice2010Black.OptionGroup = "style"
			Me.buttonStyleOffice2010Black.Text = "Office 2010 Black"
			' 
			' buttonStyleVS2010
			' 
			Me.buttonStyleVS2010.Checked = True
			Me.buttonStyleVS2010.Command = Me.AppCommandTheme
			Me.buttonStyleVS2010.CommandParameter = "VisualStudio2010Blue"
			Me.buttonStyleVS2010.Name = "buttonStyleVS2010"
			Me.buttonStyleVS2010.OptionGroup = "style"
			Me.buttonStyleVS2010.Text = "Visual Studio 2010"
			' 
			' buttonItem62
			' 
			Me.buttonItem62.Command = Me.AppCommandTheme
			Me.buttonItem62.CommandParameter = "Windows7Blue"
			Me.buttonItem62.Name = "buttonItem62"
			Me.buttonItem62.OptionGroup = "style"
			Me.buttonItem62.Text = "Windows 7"
			' 
			' buttonStyleOffice2007Blue
			' 
			Me.buttonStyleOffice2007Blue.Command = Me.AppCommandTheme
			Me.buttonStyleOffice2007Blue.CommandParameter = "Office2007Blue"
			Me.buttonStyleOffice2007Blue.Name = "buttonStyleOffice2007Blue"
			Me.buttonStyleOffice2007Blue.OptionGroup = "style"
			Me.buttonStyleOffice2007Blue.Text = "Office 2007 <font color=""Blue""><b>Blue</b></font>"
			' 
			' buttonStyleOffice2007Black
			' 
			Me.buttonStyleOffice2007Black.Command = Me.AppCommandTheme
			Me.buttonStyleOffice2007Black.CommandParameter = "Office2007Black"
			Me.buttonStyleOffice2007Black.Name = "buttonStyleOffice2007Black"
			Me.buttonStyleOffice2007Black.OptionGroup = "style"
			Me.buttonStyleOffice2007Black.Text = "Office 2007 <font color=""black""><b>Black</b></font>"
			' 
			' buttonStyleOffice2007Silver
			' 
			Me.buttonStyleOffice2007Silver.Command = Me.AppCommandTheme
			Me.buttonStyleOffice2007Silver.CommandParameter = "Office2007Silver"
			Me.buttonStyleOffice2007Silver.Name = "buttonStyleOffice2007Silver"
			Me.buttonStyleOffice2007Silver.OptionGroup = "style"
			Me.buttonStyleOffice2007Silver.Text = "Office 2007 <font color=""Silver""><b>Silver</b></font>"
			' 
			' buttonItem60
			' 
			Me.buttonItem60.Command = Me.AppCommandTheme
			Me.buttonItem60.CommandParameter = "Office2007VistaGlass"
			Me.buttonItem60.Name = "buttonItem60"
			Me.buttonItem60.OptionGroup = "style"
			Me.buttonItem60.Text = "Vista Glass"
			' 
			' buttonStyleCustom
			' 
			Me.buttonStyleCustom.BeginGroup = True
			Me.buttonStyleCustom.Command = Me.AppCommandTheme
			Me.buttonStyleCustom.Name = "buttonStyleCustom"
			Me.buttonStyleCustom.Text = "Custom scheme"
			Me.buttonStyleCustom.Tooltip = "Custom color scheme is created based on currently selected color table. Try selec" & "ting Silver or Blue color table and then creating custom color scheme."
'			Me.buttonStyleCustom.ColorPreview += New DevComponents.DotNetBar.ColorPreviewEventHandler(Me.buttonStyleCustom_ColorPreview)
'			Me.buttonStyleCustom.SelectedColorChanged += New System.EventHandler(Me.buttonStyleCustom_SelectedColorChanged)
'			Me.buttonStyleCustom.ExpandChange += New System.EventHandler(Me.buttonStyleCustom_ExpandChange)
			' 
			' switchButtonItem1
			' 
			Me.switchButtonItem1.ButtonHeight = 20
			Me.switchButtonItem1.ButtonWidth = 62
			Me.switchButtonItem1.Command = Me.RibbonStateCommand
			Me.switchButtonItem1.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Far
			Me.switchButtonItem1.Margin.Bottom = 2
			Me.switchButtonItem1.Margin.Left = 4
			Me.switchButtonItem1.Name = "switchButtonItem1"
			Me.switchButtonItem1.OffText = "MAX"
			Me.switchButtonItem1.OnText = "MIN"
			Me.switchButtonItem1.Tooltip = "Minimizes/Maximizes the Ribbon"
			' 
			' RibbonStateCommand
			' 
			Me.RibbonStateCommand.Name = "RibbonStateCommand"
'			Me.RibbonStateCommand.Executed += New System.EventHandler(Me.RibbonStateCommand_Executed)
			' 
			' buttonNew
			' 
			Me.buttonNew.Command = Me.AppCommandNew
			Me.buttonNew.Image = (CType(resources.GetObject("buttonNew.Image"), Image))
			Me.buttonNew.Name = "buttonNew"
			Me.buttonNew.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlN)
			Me.buttonNew.Text = "New Document"
			' 
			' buttonSave
			' 
			Me.buttonSave.Command = Me.AppCommandSave
			Me.buttonSave.Enabled = False
			Me.buttonSave.Image = (CType(resources.GetObject("buttonSave.Image"), Image))
			Me.buttonSave.Name = "buttonSave"
			Me.buttonSave.Text = "buttonItem2"
			' 
			' buttonUndo
			' 
			Me.buttonUndo.Enabled = False
			Me.buttonUndo.Image = (CType(resources.GetObject("buttonUndo.Image"), Image))
			Me.buttonUndo.Name = "buttonUndo"
			Me.buttonUndo.Text = "Undo"
			' 
			' qatCustomizeItem1
			' 
			Me.qatCustomizeItem1.Name = "qatCustomizeItem1"
			' 
			' superTooltip1
			' 
			Me.superTooltip1.DefaultFont = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, (CByte(0)))
			Me.superTooltip1.MinimumTooltipSize = New Size(150, 50)
			' 
			' progressBarTimer
			' 
			Me.progressBarTimer.Enabled = True
			Me.progressBarTimer.Interval = 800
'			Me.progressBarTimer.Tick += New System.EventHandler(Me.progressBarTimer_Tick)
			' 
			' styleManager1
			' 
			Me.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.VisualStudio2010Blue
			' 
			' frmMain
			' 
			Me.AutoScaleMode = AutoScaleMode.None
			Me.BackColor = Color.FromArgb((CInt((CByte(255)))), (CInt((CByte(255)))), (CInt((CByte(255)))))
			Me.ClientSize = New Size(776, 500)
			Me.Controls.Add(Me.superTabControl1)
			Me.Controls.Add(Me.contextMenuBar1)
			Me.Controls.Add(Me.tabStrip1)
			Me.Controls.Add(Me.ribbonControl1)
			Me.Controls.Add(Me.bar1)
			Me.Controls.Add(Me.mdiClient1)
			Me.IsMdiContainer = True
			Me.Name = "frmMain"
			Me.Text = "DotNetBar RibbonPad Sample"
'			Me.Load += New System.EventHandler(Me.frmMain_Load)
'			Me.MdiChildActivate += New System.EventHandler(Me.MdiChildActivated)
'			Me.Closing += New System.ComponentModel.CancelEventHandler(Me.frmMain_Closing)
'			Me.Move += New System.EventHandler(Me.frmMain_Move)
			CType(Me.bar1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ribbonControl1.ResumeLayout(False)
			Me.ribbonControl1.PerformLayout()
			Me.ribbonPanel1.ResumeLayout(False)
			Me.ribbonPanel2.ResumeLayout(False)
			Me.ribbonPanel3.ResumeLayout(False)
			CType(Me.contextMenuBar1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.superTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.superTabControl1.ResumeLayout(False)
			Me.superTabControlPanel1.ResumeLayout(False)
			Me.panelEx2.ResumeLayout(False)
			Me.panelEx1.ResumeLayout(False)
			Me.superTabControlPanel4.ResumeLayout(False)
			Me.superTabControlPanel2.ResumeLayout(False)
			Me.superTabControlPanel3.ResumeLayout(False)
			CType(Me.integerInput1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub
		#End Region

		#Region "AppCreation"
		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		<STAThread> _
		Shared Sub Main()
			Application.Run(New frmMain())
		End Sub
		#End Region

		Public Sub EditContextMenu()
			bEditPopup.Displayed=False
			bEditPopup.PopupMenu(Control.MousePosition)
		End Sub

		''' <summary>
		''' Verifies current context and enables/disables menu items...
		''' </summary>
		Private Sub EnableFileItems()
			' Accessing items through the Items collection and setting the properties on them
			' will propagate certain properties to all items with the same name...
			If Me.ActiveMdiChild Is Nothing Then
				AppCommandSave.Enabled=False
				AppCommandSaveAs.Enabled = False
			Else
				AppCommandSave.Enabled = True
				AppCommandSaveAs.Enabled = True
				If TypeOf Me.ActiveMdiChild Is frmDocument Then
					CType(Me.ActiveMdiChild, frmDocument).FormActivated()
				End If
			End If
		End Sub

		Private Sub MdiChildActivated(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.MdiChildActivate
			EnableFileItems()
			UpdateTitle()
			BindDocumentCommands()
		End Sub

		Friend Sub SaveDocument(ByVal doc As frmDocument)
			If doc.FileName="" Then
				If saveFileDialog1.ShowDialog()<>DialogResult.OK Then
					Return
				End If
				If saveFileDialog1.FileName="" Then
					Return
				End If
				doc.FileName=saveFileDialog1.FileName
			End If
			If doc.FileName<>"" Then
				doc.SaveFile()
			End If
		End Sub

		Private Sub UnloadPopup(ByVal sender As Object, ByVal e As EventArgs) Handles ribbonBar2.PopupContainerUnload
			Dim item As ButtonItem=TryCast(sender, ButtonItem)
			If item.Name="bTabColor" Then
				Dim container As DevComponents.DotNetBar.PopupContainerControl=TryCast(item.PopupContainerControl, PopupContainerControl)
				Dim clr As ColorPicker=TryCast(container.Controls(0), ColorPicker)
				If clr.SelectedColor<>Color.Empty Then
					tabStrip1.ColorScheme.TabBackground=ControlPaint.LightLight(clr.SelectedColor)
					tabStrip1.ColorScheme.TabBackground2=clr.SelectedColor
					tabStrip1.Refresh()
				End If
				' Close popup menu, since it is not closed when Popup Container is closed...
				item.Parent.Expanded=False
			End If
		End Sub

		Private Sub TaskPaneShowAtStartup(ByVal sender As Object, ByVal e As EventArgs)
			MessageBoxEx.Show("This item is here for demonstration purposes only and code should be added to save the state of it.")
		End Sub

		Private Sub dotNetBarManager1_MouseEnter(ByVal sender As Object, ByVal e As EventArgs)
			' Sync Status-bar with the item tooltip...
			Dim item As BaseItem=TryCast(sender, BaseItem)
			If item Is Nothing Then
				Return
			End If
			labelStatus.Text=item.Tooltip
		End Sub

		Private Sub dotNetBarManager1_MouseLeave(ByVal sender As Object, ByVal e As EventArgs)
			labelStatus.Text=""
		End Sub

		Private Sub frmMain_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			' Create the list of frequently used commands for the QAT Customize menu
			ribbonControl1.QatFrequentCommands.Add(buttonItem20)
			ribbonControl1.QatFrequentCommands.Add(buttonItem21)
			ribbonControl1.QatFrequentCommands.Add(buttonItem24)
			ribbonControl1.QatFrequentCommands.Add(buttonItem25)

			EnableFileItems()

			AppCommandNew.Execute()

			' Load Quick Access Toolbar layout if one is saved from last session...
			Dim key As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("Software\DevComponents\Ribbon")
			If key IsNot Nothing Then
				Try
					Dim layout As String = key.GetValue("RibbonPadCSLayout","").ToString()
					If layout<>"" AndAlso layout IsNot Nothing Then
						ribbonControl1.QatLayout = layout
					End If
				Finally
					key.Close()
				End Try
			End If
			UpdateTitle()

			' Pulse the Application Button
			buttonFile.Pulse(11)
		End Sub

		Private Sub frmMain_Move(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Move
			Me.CloseSearch()
		End Sub

		Private Sub CloseSearch()
			If m_Search IsNot Nothing Then
				m_Search.Close()
				m_Search.Dispose()
				m_Search=Nothing
			End If
		End Sub

		Public Sub SearchActiveDocument(ByVal text As String)
			Dim activedocument As frmDocument=TryCast(Me.ActiveMdiChild, frmDocument)
			If activedocument IsNot Nothing Then
				buttonFind.CommandParameter = text
				activedocument.CommandFind.Execute(buttonFind)
			End If
		End Sub

		Private Sub LaunchRibbonDialog(ByVal sender As Object, ByVal e As EventArgs) Handles ribbonBar3.LaunchDialog, ribbonBar2.LaunchDialog, ribbonBar1.LaunchDialog, ribbonBar4.LaunchDialog, ribbonBar5.LaunchDialog
			MessageBoxEx.Show("Start <i>Ribbon Dialog</i> with more options here...","Ribbon Demo",MessageBoxButtons.OK,MessageBoxIcon.Information)
		End Sub

		Private Sub buttonFind_Click(ByVal sender As Object, ByVal e As EventArgs) Handles buttonFind.Click
			If m_Search Is Nothing OrElse m_Search.IsDisposed Then
				m_Search = New BalloonSearch()
				m_Search.Owner=Me
				m_Search.Show(TryCast(sender, BaseItem),True)
			End If
		End Sub

		Private Sub MdiClientControlAddRemove(ByVal sender As Object, ByVal e As ControlEventArgs)
			If Me.MdiChildren.Length>0 Then
				If Not ribbonTabContext.Visible Then
					ribbonTabContext.Visible=True
					ribbonControl1.RecalcLayout()
				End If
			Else
				If ribbonTabContext.Visible Then
					If ribbonTabContext.Checked Then
						ribbonTabItem1.Checked=True
					End If
					ribbonTabContext.Visible=False
					ribbonControl1.RecalcLayout()
				End If
			End If
		End Sub

		Private Sub frmMain_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
			' Save Quick Access Toolbar layout if it has changed...
			If ribbonControl1.QatLayoutChanged Then
				Dim key As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("Software\DevComponents\Ribbon")
				Try
					key.SetValue("RibbonPadCSLayout", ribbonControl1.QatLayout)
				Finally
					key.Close()
				End Try
			End If
		End Sub

		Private Sub progressBarTimer_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles progressBarTimer.Tick
			If progressBarItem1.Value>=progressBarItem1.Maximum Then
				progressBarTimer.Stop()
				progressBarItem1.Value = 50
			Else
				progressBarItem1.Value+=4
			End If
		End Sub

		Private Sub ribbonControl1_BeforeRibbonPanelPopupClose(ByVal sender As Object, ByVal e As DevComponents.DotNetBar.RibbonPopupCloseEventArgs) Handles ribbonControl1.BeforeRibbonPanelPopupClose
			' Don't close ribbon tab menu if Find button is clicked since it display the balloon popup
			If e.Source Is buttonFind Then
				e.Cancel = True
			End If
		End Sub

		#Region "Automatic Color Scheme creation based on the selected color table"
		Private m_ColorSelected As Boolean = False
		Private m_BaseStyle As eStyle = eStyle.Office2010Silver
		Private Sub buttonStyleCustom_ExpandChange(ByVal sender As Object, ByVal e As EventArgs) Handles buttonStyleCustom.ExpandChange
			If buttonStyleCustom.Expanded Then
				' Remember the starting color scheme to apply if no color is selected during live-preview
				m_ColorSelected = False
				m_BaseStyle = StyleManager.Style
			Else
				If Not m_ColorSelected Then
					StyleManager.ChangeStyle(m_BaseStyle, Color.Empty)
				End If
			End If
		End Sub

		Private Sub buttonStyleCustom_ColorPreview(ByVal sender As Object, ByVal e As DevComponents.DotNetBar.ColorPreviewEventArgs) Handles buttonStyleCustom.ColorPreview
			StyleManager.ColorTint = e.Color
		End Sub

		Private Sub buttonStyleCustom_SelectedColorChanged(ByVal sender As Object, ByVal e As EventArgs) Handles buttonStyleCustom.SelectedColorChanged
			m_ColorSelected = True ' Indicate that color was selected for buttonStyleCustom_ExpandChange method
			buttonStyleCustom.CommandParameter = buttonStyleCustom.SelectedColor
		End Sub
		#End Region

		Private Sub buttonFileSaveAs_ExpandChange(ByVal sender As Object, ByVal e As EventArgs) Handles buttonFileSaveAs.ExpandChange
			' Position the Save As sub menu on top of the recent files box
			If buttonFileSaveAs.Expanded Then
				buttonFileSaveAs.PopupLocation = menuFileMRU.DisplayRectangle.Location
			End If
		End Sub

		''' <summary>
		''' Updates the title displayed on Ribbon using the rich text markup
		''' </summary>
		Private Sub UpdateTitle()
			Dim t As String = ""
			If Me.ActiveMdiChild IsNot Nothing Then
				' Note the usage of SysCaptionTextExtra for as the value of color attribute.
				' It specifies the system color that changes based on selected color table.
				t &="<font color=""SysCaptionTextExtra"">" & Me.ActiveMdiChild.Text & "</font> "
			End If
			t &= "<b>RibbonPad</b>"
			t &=" <b><a name=""tip""><font color=""SysCaptionTextExtra"">?</font></a></b>"
			ribbonControl1.TitleText = t
		End Sub

		Private Sub ribbonControl1_TitleTextMarkupLinkClick(ByVal sender As Object, ByVal e As DevComponents.DotNetBar.MarkupLinkClickEventArgs) Handles ribbonControl1.TitleTextMarkupLinkClick
			MessageBoxEx.Show("TitleText property on Ribbon fully supports our text-markup as demonstrated here. However, try keeping things simpler in title bar, perhaps using hyperlinks is pushing it too far ;-) <br/><br/>See <b>UpdateTitle()</b> method in source for details.", "RibbonControl.TitleText property tip")
		End Sub

		#Region "Commands Implementation"
		Private Sub BindDocumentCommands()
			Dim document As frmDocument = TryCast(Me.ActiveMdiChild, frmDocument)
			If document Is Nothing Then
				' Note that when Command is set to null the button will be automatically 
				' disabled if it had command associated previously
				buttonCopy.Command = Nothing
				buttonCut.Command = Nothing
				buttonPaste.Command = Nothing
				buttonUndo.Command = Nothing
				buttonAlignCenter.Command = Nothing
				buttonAlignLeft.Command = Nothing
				buttonAlignRight.Command = Nothing
				buttonFind.Command = Nothing
				comboFont.Command = Nothing
				buttonFontBold.Command = Nothing
				buttonFontItalic.Command = Nothing
				comboFontSize.Command = Nothing
				buttonFontStrike.Command = Nothing
				buttonFontUnderline.Command = Nothing
				buttonTextColor.Command = Nothing
				zoomSlider.Command = Nothing
				labelStatus.Command = Nothing
				bCopy.Command = Nothing
				bCut.Command = Nothing
				bPaste.Command = Nothing
			Else
				buttonCopy.Command = document.CommandCopy
				bCopy.Command = document.CommandCopy
				buttonCut.Command = document.CommandCut
				bCut.Command = document.CommandCut
				buttonPaste.Command = document.CommandPaste
				bPaste.Command = document.CommandPaste
				buttonUndo.Command = document.CommandUndo
				buttonAlignCenter.Command = document.CommandAlignCenter
				buttonAlignLeft.Command = document.CommandAlignLeft
				buttonAlignRight.Command = document.CommandAlignRight
				buttonFind.Command = document.CommandFind
				comboFont.Command = document.CommandFont
				buttonFontBold.Command = document.CommandFontBold
				buttonFontItalic.Command = document.CommandFontItalic
				comboFontSize.Command = document.CommandFontSize
				buttonFontStrike.Command = document.CommandFontStrike
				buttonFontUnderline.Command = document.CommandFontUnderline
				buttonTextColor.Command = document.CommandTextColor
				zoomSlider.Command = document.CommandZoom
				labelStatus.Command = document.CommandStatus
			End If
		End Sub

		Private Sub AppCommandNew_Executed(ByVal sender As Object, ByVal e As EventArgs) Handles AppCommandNew.Executed
			' Close Application Menu
			buttonFile.Expanded = False

			Dim doc As New frmDocument()
			doc.Text = "New Document " & (Me.MdiChildren.Length + 1)
			doc.MdiParent = Me
			doc.WindowState = FormWindowState.Maximized
			doc.Show()
			doc.Update()
		End Sub

		Private Sub AppCommandOpen_Executed(ByVal sender As Object, ByVal e As EventArgs) Handles AppCommandOpen.Executed
			' Close Application Menu
			buttonFile.Expanded = False

			openFileDialog1.FileName = ""
			openFileDialog1.ShowDialog()
			If openFileDialog1.FileName = "" Then
				Return
			End If
			Dim doc As New frmDocument()
			doc.Text = openFileDialog1.FileName
			doc.MdiParent = Me
			doc.Show()
			doc.OpenFile(openFileDialog1.FileName)
		End Sub

		Private Sub AppCommandSave_Executed(ByVal sender As Object, ByVal e As EventArgs) Handles AppCommandSave.Executed
			' Close Application Menu
			buttonFile.Expanded = False

			Dim doc As frmDocument = TryCast(Me.ActiveMdiChild, frmDocument)
			If doc Is Nothing OrElse (Not doc.DocumentChanged) Then
				Return
			End If
			SaveDocument(doc)
		End Sub

		Private Sub AppCommandSaveAs_Executed(ByVal sender As Object, ByVal e As EventArgs) Handles AppCommandSaveAs.Executed
			' Close Application Menu
			buttonFile.Expanded = False

			If Me.ActiveMdiChild Is Nothing Then
				Return
			End If

			' Close menu popup if needed since File Dialogs can interfer with it
			If TypeOf sender Is BaseItem Then
				BaseItem.CollapseAll(TryCast(sender, BaseItem))
			End If

			Dim doc As frmDocument = TryCast(Me.ActiveMdiChild, frmDocument)
			If doc Is Nothing OrElse (Not doc.DocumentChanged) Then
				Return
			End If
			If doc.FileName = "" Then
				SaveDocument(doc)
				Return
			End If

			saveFileDialog1.ShowDialog()
			If saveFileDialog1.ShowDialog() <> DialogResult.OK Then
				Return
			End If
			If saveFileDialog1.FileName = "" Then
				Return
			End If
			doc.FileName = saveFileDialog1.FileName
			doc.SaveFile()
		End Sub

		Private Sub AppCommandTheme_Executed(ByVal sender As Object, ByVal e As EventArgs) Handles AppCommandTheme.Executed
			Dim source As ICommandSource = TryCast(sender, ICommandSource)
			If TypeOf source.CommandParameter Is String Then
				Dim style As eStyle = CType(System.Enum.Parse(GetType(eStyle), source.CommandParameter.ToString()), eStyle)
				' Using StyleManager change the style and color tinting
				StyleManager.ChangeStyle(style, Color.Empty)
				If style = eStyle.Office2007Black OrElse style = eStyle.Office2007Blue OrElse style = eStyle.Office2007Silver OrElse style = eStyle.Office2007VistaGlass Then
					buttonFile.BackstageTabEnabled = False
				Else
					buttonFile.BackstageTabEnabled = True
				End If
			ElseIf TypeOf source.CommandParameter Is Color Then
				StyleManager.ColorTint = CType(source.CommandParameter, Color)
			End If
		End Sub

		Private Sub AppCommandExit_Executed(ByVal sender As Object, ByVal e As EventArgs) Handles AppCommandExit.Executed
			Me.Close()
		End Sub

		Private Sub AppCommandGoToUrl_Executed(ByVal sender As Object, ByVal e As EventArgs) Handles AppCommandGoToUrl.Executed
			' Close Application Menu
			buttonFile.Expanded = False
			Dim source As ICommandSource = TryCast(sender, ICommandSource)
			If TypeOf source.CommandParameter Is String Then
				Dim url As String = CStr(source.CommandParameter)
				Process.Start(url)
			Else
				MessageBoxEx.Show("This command must have CommandParameter set to the URL you want to navigate to.")
			End If
		End Sub

		Private Sub RibbonStateCommand_Executed(ByVal sender As Object, ByVal e As EventArgs) Handles RibbonStateCommand.Executed
			ribbonControl1.Expanded = RibbonStateCommand.Checked
			RibbonStateCommand.Checked = Not RibbonStateCommand.Checked
		End Sub
		#End Region

		#Region "Backstage Application Menu Content Setup"
		Private Sub SetupBackstageContent()
			SetupRecentTab()
		End Sub
		Private Sub SetupRecentTab()
			recentDocsItemPane.Items.Clear()
			Dim mruFiles() As MruItem = GetMruFiles()
			For Each item As MruItem In mruFiles
				recentDocsItemPane.Items.Add(CreateMruFileView(item))
			Next item

			recentPlacesItemsPanel.Items.Clear()
			Dim mruPlaces() As MruItem = GetMruPlaces()
			For Each item As MruItem In mruPlaces
				recentPlacesItemsPanel.Items.Add(CreateMruPlaceView(item))
			Next item
		End Sub

		Private Function CreateMruPlaceView(ByVal item As MruItem) As BaseItem
			Dim container As New ItemDockContainer()
			container.LastChildFill = True
			' Create Pin Button
			Dim pinButton As New ButtonItem()
			pinButton.ImagePaddingHorizontal = 6
			pinButton.Image = My.Resources.Unpinned
			container.SetDock(pinButton, eItemDock.Right) ' Position pin button on right side
			container.SubItems.Add(pinButton)
			' Create button with file name and folder
			Dim fileButton As New ButtonItem()
			fileButton.ForeColor = Color.Black
			fileButton.ButtonStyle = eButtonStyle.ImageAndText
			fileButton.ImagePosition = eImagePosition.Left
			fileButton.Text = item.FileName & "<br/><font color=""Gray"">" & item.Folder & "</font>"
			fileButton.Image = My.Resources.OpenExistingPlace
			container.SubItems.Add(fileButton)

			Return container
		End Function

		Private Function CreateMruFileView(ByVal item As MruItem) As BaseItem
			Dim container As New ItemDockContainer()
			container.LastChildFill = True
			' Create Pin Button
			Dim pinButton As New ButtonItem()
			pinButton.ImagePaddingHorizontal = 6
			pinButton.Image = My.Resources.Unpinned
			container.SetDock(pinButton, eItemDock.Right) ' Position pin button on right side
			container.SubItems.Add(pinButton)
			' Create button with file name and folder
			Dim fileButton As New ButtonItem()
			fileButton.ForeColor = Color.Black
			fileButton.ButtonStyle = eButtonStyle.ImageAndText
			fileButton.ImagePosition = eImagePosition.Left
			fileButton.Text = item.FileName & "<br/><font color=""Gray"">" & item.Folder & "</font>"
			fileButton.Image = My.Resources.Document
			container.SubItems.Add(fileButton)

			Return container
		End Function

		Private Function GetMruPlaces() As MruItem()
			Return New MruItem(2) { New MruItem("Documents","\\fileserver\Documents"), New MruItem("My Documents","c:\My Documents"), New MruItem("Transfer","\\droboshare\drobo\Transfer") }
		End Function
		Private Function GetMruFiles() As MruItem()
			Return New MruItem(9) { New MruItem("Services Invoice 108.rtf","\\fileserver\Documents"), New MruItem("Services Invoice 109.rtf","\\fileserver\Documents"), New MruItem("Sales Report.rtf","\\fileserver\Documents"), New MruItem("Marketing Draft.rtf","c:\My Documents"), New MruItem("Compensation Report.rtf","c:\My Documents"), New MruItem("Jim Review.rtf","c:\My Documents"), New MruItem("Kathy Review.rtf","c:\My Documents"), New MruItem("Invoice10201.rtf","c:\My Documents"), New MruItem("Invoice10202.rtf","c:\My Documents"), New MruItem("Invoice10203.rtf","c:\My Documents") }
		End Function

		Private Class MruItem
			Public Sub New(ByVal fileName As String, ByVal folder As String)
				Me.FileName = fileName
				Me.Folder = folder
			End Sub
			Public FileName As String
			Public Folder As String
		End Class
		#End Region

	End Class
End Namespace

