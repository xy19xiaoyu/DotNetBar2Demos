using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Rendering;

namespace Ribbonpad
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class frmMain : DevComponents.DotNetBar.Office2007RibbonForm
	{
		private System.Windows.Forms.MdiClient mdiClient1;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private DevComponents.DotNetBar.TabStrip tabStrip1;
		private System.ComponentModel.IContainer components;
		private BalloonSearch m_Search=null;
		private DevComponents.DotNetBar.Bar bar1;
		private DevComponents.DotNetBar.LabelItem labelStatus;
		internal DevComponents.DotNetBar.LabelItem labelPosition;
		private DevComponents.DotNetBar.RibbonControl ribbonControl1;
		private DevComponents.DotNetBar.RibbonTabItem ribbonTabItem1;
		private DevComponents.DotNetBar.RibbonPanel ribbonPanel1;
		private DevComponents.DotNetBar.ButtonItem buttonSave;
		private DevComponents.DotNetBar.RibbonTabItem ribbonTabItem3;
		private DevComponents.DotNetBar.RibbonPanel ribbonPanel3;
		private DevComponents.DotNetBar.RibbonBar ribbonBar1;
		private DevComponents.DotNetBar.RibbonBar ribbonBar2;
		private DevComponents.DotNetBar.RibbonBar ribbonBar3;
		private DevComponents.DotNetBar.RibbonBar ribbonBar4;
		private DevComponents.DotNetBar.ButtonItem buttonPaste;
		private DevComponents.DotNetBar.ButtonItem buttonCut;
		private DevComponents.DotNetBar.ItemContainer itemContainer1;
		private DevComponents.DotNetBar.ButtonItem buttonCopy;
		private DevComponents.DotNetBar.ButtonItem buttonUndo;
		private DevComponents.DotNetBar.ComboBoxItem comboFont;
		private DevComponents.DotNetBar.ComboBoxItem comboFontSize;
		private DevComponents.DotNetBar.ItemContainer itemContainer2;
		private DevComponents.DotNetBar.ItemContainer itemContainer3;
		private DevComponents.DotNetBar.ButtonItem buttonFontItalic;
		private DevComponents.DotNetBar.ButtonItem buttonFontUnderline;
		private DevComponents.DotNetBar.ButtonItem buttonFontStrike;
		private DevComponents.DotNetBar.ColorPickerDropDown buttonTextColor;
		private DevComponents.DotNetBar.ButtonItem buttonAlignLeft;
		private DevComponents.DotNetBar.ButtonItem buttonAlignCenter;
		private DevComponents.DotNetBar.ButtonItem buttonAlignRight;
		private DevComponents.DotNetBar.ButtonItem buttonAlignJustify;
		private DevComponents.DotNetBar.ButtonItem buttonItem2;
		private DevComponents.DotNetBar.ButtonItem buttonItem3;
		private DevComponents.DotNetBar.ButtonItem buttonItem4;
		private DevComponents.DotNetBar.ButtonItem buttonItem5;
		private DevComponents.DotNetBar.ItemContainer itemContainer6;
		private DevComponents.DotNetBar.ItemContainer itemContainer7;
		private DevComponents.DotNetBar.ItemContainer itemContainer8;
		private DevComponents.DotNetBar.ItemContainer itemContainer4;
		private DevComponents.DotNetBar.ButtonItem buttonItem6;
		private DevComponents.DotNetBar.ButtonItem buttonItem7;
		private DevComponents.DotNetBar.ButtonItem buttonFind;
		private DevComponents.DotNetBar.ItemContainer itemContainer5;
		private DevComponents.DotNetBar.ButtonItem buttonReplace;
		private DevComponents.DotNetBar.ButtonItem buttonGoto;
		private DevComponents.DotNetBar.RibbonBar ribbonBar5;
		private DevComponents.DotNetBar.ButtonItem buttonMargins;
		private DevComponents.DotNetBar.ButtonItem buttonItem9;
		private DevComponents.DotNetBar.ButtonItem buttonItem10;
		private DevComponents.DotNetBar.ButtonItem buttonItem11;
		private DevComponents.DotNetBar.ButtonItem buttonNew;
		private DevComponents.DotNetBar.ButtonItem buttonFontBold;
		private DevComponents.Editors.ComboItem comboItem1;
		private DevComponents.Editors.ComboItem comboItem2;
		private DevComponents.Editors.ComboItem comboItem3;
		private DevComponents.Editors.ComboItem comboItem4;
		private DevComponents.Editors.ComboItem comboItem5;
		private DevComponents.Editors.ComboItem comboItem6;
		private DevComponents.Editors.ComboItem comboItem7;
		private DevComponents.Editors.ComboItem comboItem8;
		private DevComponents.Editors.ComboItem comboItem9;
		private DevComponents.DotNetBar.RibbonPanel ribbonPanel2;
		private DevComponents.DotNetBar.RibbonBar ribbonBar6;
		private DevComponents.DotNetBar.RibbonTabItemGroup ribbonTabItemGroup1;
		private DevComponents.DotNetBar.ButtonItem buttonItem1;
		private DevComponents.DotNetBar.ButtonItem buttonItem8;
		private DevComponents.DotNetBar.ButtonItem buttonItem12;
		private DevComponents.DotNetBar.RibbonTabItem ribbonTabContext;
		private DevComponents.DotNetBar.ButtonItem buttonChangeStyle;
		private DevComponents.DotNetBar.SuperTooltip superTooltip1;
		private DevComponents.DotNetBar.ItemContainer itemContainer9;
		private DevComponents.DotNetBar.ButtonItem buttonItem13;
		private DevComponents.DotNetBar.ButtonItem buttonItem14;
		private DevComponents.DotNetBar.ButtonItem buttonItem15;
		private DevComponents.DotNetBar.ButtonItem buttonItem16;
		private DevComponents.DotNetBar.ButtonItem buttonItem17;
		private DevComponents.DotNetBar.ButtonItem buttonStyleOffice2007Blue;
		private DevComponents.DotNetBar.ButtonItem buttonStyleOffice2007Black;
		private DevComponents.DotNetBar.ButtonItem buttonItem20;
		private DevComponents.DotNetBar.ButtonItem buttonItem21;
		private DevComponents.DotNetBar.ButtonItem buttonItem23;
		private DevComponents.DotNetBar.ButtonItem buttonItem24;
		private DevComponents.DotNetBar.ButtonItem buttonItem25;
		private DevComponents.DotNetBar.LabelItem labelItem8;
		private DevComponents.DotNetBar.ButtonItem buttonItem26;
		private DevComponents.DotNetBar.ButtonItem buttonItem27;
		private DevComponents.DotNetBar.ButtonItem buttonItem28;
		private DevComponents.DotNetBar.ButtonItem buttonItem29;
		private DevComponents.DotNetBar.ButtonItem buttonFileSaveAs;
		private DevComponents.DotNetBar.ItemContainer menuFileContainer;
		private DevComponents.DotNetBar.ItemContainer menuFileTwoColumnContainer;
		private DevComponents.DotNetBar.ItemContainer menuFileItems;
		private DevComponents.DotNetBar.ItemContainer menuFileMRU;
		private DevComponents.DotNetBar.ItemContainer menuFileBottomContainer;
		private DevComponents.DotNetBar.ButtonItem buttonOptions;
		private DevComponents.DotNetBar.ButtonItem buttonExit;
		private DevComponents.DotNetBar.QatCustomizeItem qatCustomizeItem1;
		private DevComponents.DotNetBar.ContextMenuBar contextMenuBar1;
		private DevComponents.DotNetBar.ButtonItem bEditPopup;
		private DevComponents.DotNetBar.ButtonItem bCut;
		private DevComponents.DotNetBar.ButtonItem bCopy;
		private DevComponents.DotNetBar.ButtonItem bPaste;
		private DevComponents.DotNetBar.ButtonItem bSelectAll;
		private DevComponents.DotNetBar.RibbonBar ribbonBar7;
		private DevComponents.DotNetBar.GalleryContainer galleryContainer1;
		private DevComponents.DotNetBar.ButtonItem buttonItem18;
		private DevComponents.DotNetBar.ButtonItem buttonItem19;
		private DevComponents.DotNetBar.ButtonItem buttonItem22;
		private DevComponents.DotNetBar.ButtonItem buttonItem30;
		private DevComponents.DotNetBar.ButtonItem buttonItem31;
		private DevComponents.DotNetBar.ButtonItem buttonItem32;
		private DevComponents.DotNetBar.ButtonItem buttonItem33;
		private DevComponents.DotNetBar.ButtonItem buttonItem34;
		private DevComponents.DotNetBar.ButtonItem buttonItem35;
		private DevComponents.DotNetBar.ButtonItem buttonItem36;
		private DevComponents.DotNetBar.ButtonItem buttonItem37;
		private DevComponents.DotNetBar.ButtonItem buttonItem38;
		private DevComponents.DotNetBar.ButtonItem buttonItem39;
		private DevComponents.DotNetBar.ButtonItem buttonItem40;
		private DevComponents.DotNetBar.ButtonItem buttonItem41;
		private DevComponents.DotNetBar.ButtonItem buttonItem42;
		private DevComponents.DotNetBar.ButtonItem buttonItem43;
		private DevComponents.DotNetBar.ButtonItem buttonItem44;
		private DevComponents.DotNetBar.ButtonItem buttonItem45;
		private DevComponents.DotNetBar.ButtonItem buttonItem46;
		private DevComponents.DotNetBar.ButtonItem buttonItem47;
		private DevComponents.DotNetBar.ButtonItem buttonItem48;
		private DevComponents.DotNetBar.ButtonItem buttonItem49;
		private DevComponents.DotNetBar.RibbonBar ribbonBar8;
		private DevComponents.DotNetBar.ItemContainer itemContainer10;
		private DevComponents.DotNetBar.ItemContainer itemContainer11;
		private DevComponents.DotNetBar.CheckBoxItem checkBoxItem1;
		private DevComponents.DotNetBar.CheckBoxItem checkBoxItem2;
		private DevComponents.DotNetBar.CheckBoxItem checkBoxItem3;
		private DevComponents.DotNetBar.CheckBoxItem checkBoxItem4;
		private DevComponents.DotNetBar.CheckBoxItem checkBoxItem5;
		private DevComponents.DotNetBar.CheckBoxItem checkBoxItem6;
		private DevComponents.DotNetBar.ButtonItem buttonItem50;
		private DevComponents.DotNetBar.ButtonItem buttonItem51;
		private DevComponents.DotNetBar.ButtonItem buttonItem52;
		private System.Windows.Forms.Timer progressBarTimer;
		private DevComponents.DotNetBar.ProgressBarItem progressBarItem1;
		private DevComponents.DotNetBar.ButtonItem buttonStyleOffice2007Silver;
		private DevComponents.DotNetBar.ColorPickerDropDown buttonStyleCustom;
		private DevComponents.DotNetBar.ButtonItem buttonItem53;
		private DevComponents.DotNetBar.ButtonItem buttonItem54;
		private DevComponents.DotNetBar.ButtonItem buttonItem55;
		private DevComponents.DotNetBar.ItemContainer itemContainer12;
		private DevComponents.DotNetBar.LabelItem labelItem1;
		private DevComponents.DotNetBar.ButtonItem buttonItem56;
		private DevComponents.DotNetBar.ButtonItem buttonItem57;
		private DevComponents.DotNetBar.ButtonItem buttonItem58;
		private DevComponents.DotNetBar.ButtonItem buttonItem59;
		private DevComponents.DotNetBar.SliderItem zoomSlider;
		private DevComponents.DotNetBar.ItemContainer itemContainer13;
		private Command AppCommandNew;
		private Command AppCommandOpen;
		private Command AppCommandSave;
		private Command AppCommandSaveAs;
		private Command AppCommandTheme;
		private Command AppCommandExit;
		private DevComponents.DotNetBar.ButtonItem buttonItem60;
		private DevComponents.DotNetBar.StyleManager styleManager1;
		private DevComponents.DotNetBar.ButtonItem buttonStyleOffice2010Silver;
		private DevComponents.DotNetBar.ButtonItem buttonItem62;
        private ButtonItem buttonStyleOffice2010Blue;
        private ButtonItem buttonStyleOffice2010Black;
        private SuperTabControl superTabControl1;
        private SuperTabControlPanel superTabControlPanel1;
        private SuperTabItem superTabItem1;
        private SuperTabControlPanel superTabControlPanel4;
        private SuperTabItem superTabItem4;
        private SuperTabControlPanel superTabControlPanel3;
        private SuperTabItem superTabItem3;
        private SuperTabControlPanel superTabControlPanel2;
        private SuperTabItem superTabItem2;
        private ButtonItem buttonItem61;
        private ButtonItem buttonItem63;
        private ButtonItem buttonItem64;
        private ButtonItem buttonItem65;
        private ButtonItem buttonItem66;
        private PanelEx panelEx1;
        private LabelX labelX1;
        private PanelEx panelEx2;
        private LabelX labelX2;
        private ItemPanel recentDocsItemPane;
        private ItemPanel recentPlacesItemsPanel;
        private LabelX labelX3;
        private ItemPanel itemPanel1;
        private ButtonItem buttonItem67;
        private ButtonItem buttonItem68;
        private ButtonItem buttonItem69;
        private ButtonItem buttonItem70;
        private ButtonItem buttonItem71;
        private ButtonItem buttonItem72;
        private LabelX labelX4;
        private ButtonX buttonX1;
        private PanelEx panelEx3;
        private LabelX labelX5;
        private DevComponents.Editors.IntegerInput integerInput1;
        private ItemPanel itemPanel2;
        private LabelX labelX6;
        private ButtonItem buttonItem73;
        private ButtonItem buttonItem74;
        private ButtonItem buttonItem75;
        private Command AppCommandGoToUrl;
        private ButtonItem buttonItem76;
        private ButtonItem buttonItem77;
        private SwitchButtonItem switchButtonItem1;
        private Command RibbonStateCommand;
        private ButtonItem buttonStyleVS2010;
		private DevComponents.DotNetBar.Office2007StartButton buttonFile;

		public frmMain()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			mdiClient1.ControlAdded+=new ControlEventHandler(MdiClientControlAddRemove);
			mdiClient1.ControlRemoved+=new ControlEventHandler(MdiClientControlAddRemove);
            SetupBackstageContent();
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.mdiClient1 = new System.Windows.Forms.MdiClient();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tabStrip1 = new DevComponents.DotNetBar.TabStrip();
            this.bar1 = new DevComponents.DotNetBar.Bar();
            this.labelStatus = new DevComponents.DotNetBar.LabelItem();
            this.itemContainer9 = new DevComponents.DotNetBar.ItemContainer();
            this.buttonItem13 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem14 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem15 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem16 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem17 = new DevComponents.DotNetBar.ButtonItem();
            this.progressBarItem1 = new DevComponents.DotNetBar.ProgressBarItem();
            this.itemContainer13 = new DevComponents.DotNetBar.ItemContainer();
            this.labelPosition = new DevComponents.DotNetBar.LabelItem();
            this.zoomSlider = new DevComponents.DotNetBar.SliderItem();
            this.ribbonControl1 = new DevComponents.DotNetBar.RibbonControl();
            this.ribbonPanel1 = new DevComponents.DotNetBar.RibbonPanel();
            this.ribbonBar7 = new DevComponents.DotNetBar.RibbonBar();
            this.galleryContainer1 = new DevComponents.DotNetBar.GalleryContainer();
            this.buttonItem47 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem48 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem49 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem18 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem19 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem22 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem30 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem31 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem32 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem33 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem34 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem35 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem36 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem37 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem38 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem39 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem40 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem41 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem42 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem43 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem44 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem45 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem46 = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonBar3 = new DevComponents.DotNetBar.RibbonBar();
            this.itemContainer6 = new DevComponents.DotNetBar.ItemContainer();
            this.itemContainer7 = new DevComponents.DotNetBar.ItemContainer();
            this.buttonAlignLeft = new DevComponents.DotNetBar.ButtonItem();
            this.buttonAlignCenter = new DevComponents.DotNetBar.ButtonItem();
            this.buttonAlignRight = new DevComponents.DotNetBar.ButtonItem();
            this.buttonAlignJustify = new DevComponents.DotNetBar.ButtonItem();
            this.itemContainer8 = new DevComponents.DotNetBar.ItemContainer();
            this.buttonItem2 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem3 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem4 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem5 = new DevComponents.DotNetBar.ButtonItem();
            this.itemContainer4 = new DevComponents.DotNetBar.ItemContainer();
            this.buttonItem6 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem7 = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonBar2 = new DevComponents.DotNetBar.RibbonBar();
            this.itemContainer2 = new DevComponents.DotNetBar.ItemContainer();
            this.comboFont = new DevComponents.DotNetBar.ComboBoxItem();
            this.comboFontSize = new DevComponents.DotNetBar.ComboBoxItem();
            this.comboItem1 = new DevComponents.Editors.ComboItem();
            this.comboItem2 = new DevComponents.Editors.ComboItem();
            this.comboItem3 = new DevComponents.Editors.ComboItem();
            this.comboItem4 = new DevComponents.Editors.ComboItem();
            this.comboItem5 = new DevComponents.Editors.ComboItem();
            this.comboItem6 = new DevComponents.Editors.ComboItem();
            this.comboItem7 = new DevComponents.Editors.ComboItem();
            this.comboItem8 = new DevComponents.Editors.ComboItem();
            this.comboItem9 = new DevComponents.Editors.ComboItem();
            this.itemContainer3 = new DevComponents.DotNetBar.ItemContainer();
            this.buttonFontBold = new DevComponents.DotNetBar.ButtonItem();
            this.buttonFontItalic = new DevComponents.DotNetBar.ButtonItem();
            this.buttonFontUnderline = new DevComponents.DotNetBar.ButtonItem();
            this.buttonFontStrike = new DevComponents.DotNetBar.ButtonItem();
            this.buttonTextColor = new DevComponents.DotNetBar.ColorPickerDropDown();
            this.ribbonBar1 = new DevComponents.DotNetBar.RibbonBar();
            this.buttonPaste = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem53 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem54 = new DevComponents.DotNetBar.ButtonItem();
            this.itemContainer1 = new DevComponents.DotNetBar.ItemContainer();
            this.buttonCut = new DevComponents.DotNetBar.ButtonItem();
            this.buttonCopy = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem55 = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonPanel2 = new DevComponents.DotNetBar.RibbonPanel();
            this.ribbonBar6 = new DevComponents.DotNetBar.RibbonBar();
            this.buttonItem1 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem8 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem12 = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonPanel3 = new DevComponents.DotNetBar.RibbonPanel();
            this.ribbonBar8 = new DevComponents.DotNetBar.RibbonBar();
            this.itemContainer10 = new DevComponents.DotNetBar.ItemContainer();
            this.checkBoxItem1 = new DevComponents.DotNetBar.CheckBoxItem();
            this.checkBoxItem2 = new DevComponents.DotNetBar.CheckBoxItem();
            this.checkBoxItem3 = new DevComponents.DotNetBar.CheckBoxItem();
            this.itemContainer11 = new DevComponents.DotNetBar.ItemContainer();
            this.checkBoxItem4 = new DevComponents.DotNetBar.CheckBoxItem();
            this.checkBoxItem5 = new DevComponents.DotNetBar.CheckBoxItem();
            this.checkBoxItem6 = new DevComponents.DotNetBar.CheckBoxItem();
            this.ribbonBar4 = new DevComponents.DotNetBar.RibbonBar();
            this.buttonFind = new DevComponents.DotNetBar.ButtonItem();
            this.itemContainer5 = new DevComponents.DotNetBar.ItemContainer();
            this.buttonReplace = new DevComponents.DotNetBar.ButtonItem();
            this.buttonGoto = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonBar5 = new DevComponents.DotNetBar.RibbonBar();
            this.buttonMargins = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem9 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem50 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem51 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem52 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem10 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem11 = new DevComponents.DotNetBar.ButtonItem();
            this.contextMenuBar1 = new DevComponents.DotNetBar.ContextMenuBar();
            this.bEditPopup = new DevComponents.DotNetBar.ButtonItem();
            this.bCut = new DevComponents.DotNetBar.ButtonItem();
            this.bCopy = new DevComponents.DotNetBar.ButtonItem();
            this.bPaste = new DevComponents.DotNetBar.ButtonItem();
            this.bSelectAll = new DevComponents.DotNetBar.ButtonItem();
            this.buttonFile = new DevComponents.DotNetBar.Office2007StartButton();
            this.superTabControl1 = new DevComponents.DotNetBar.SuperTabControl();
            this.superTabControlPanel1 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.panelEx2 = new DevComponents.DotNetBar.PanelEx();
            this.recentPlacesItemsPanel = new DevComponents.DotNetBar.ItemPanel();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.recentDocsItemPane = new DevComponents.DotNetBar.ItemPanel();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.superTabItem1 = new DevComponents.DotNetBar.SuperTabItem();
            this.superTabControlPanel4 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.itemPanel2 = new DevComponents.DotNetBar.ItemPanel();
            this.buttonItem77 = new DevComponents.DotNetBar.ButtonItem();
            this.AppCommandGoToUrl = new DevComponents.DotNetBar.Command(this.components);
            this.buttonItem73 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem74 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem75 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem76 = new DevComponents.DotNetBar.ButtonItem();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.superTabItem4 = new DevComponents.DotNetBar.SuperTabItem();
            this.superTabControlPanel2 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.itemPanel1 = new DevComponents.DotNetBar.ItemPanel();
            this.buttonItem67 = new DevComponents.DotNetBar.ButtonItem();
            this.AppCommandNew = new DevComponents.DotNetBar.Command(this.components);
            this.buttonItem68 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem69 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem70 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem71 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem72 = new DevComponents.DotNetBar.ButtonItem();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.superTabItem2 = new DevComponents.DotNetBar.SuperTabItem();
            this.superTabControlPanel3 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.panelEx3 = new DevComponents.DotNetBar.PanelEx();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.integerInput1 = new DevComponents.Editors.IntegerInput();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.superTabItem3 = new DevComponents.DotNetBar.SuperTabItem();
            this.buttonItem61 = new DevComponents.DotNetBar.ButtonItem();
            this.AppCommandSave = new DevComponents.DotNetBar.Command(this.components);
            this.buttonItem63 = new DevComponents.DotNetBar.ButtonItem();
            this.AppCommandOpen = new DevComponents.DotNetBar.Command(this.components);
            this.buttonItem64 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem65 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem66 = new DevComponents.DotNetBar.ButtonItem();
            this.AppCommandExit = new DevComponents.DotNetBar.Command(this.components);
            this.menuFileContainer = new DevComponents.DotNetBar.ItemContainer();
            this.menuFileTwoColumnContainer = new DevComponents.DotNetBar.ItemContainer();
            this.menuFileItems = new DevComponents.DotNetBar.ItemContainer();
            this.buttonItem20 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem21 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonFileSaveAs = new DevComponents.DotNetBar.ButtonItem();
            this.AppCommandSaveAs = new DevComponents.DotNetBar.Command(this.components);
            this.itemContainer12 = new DevComponents.DotNetBar.ItemContainer();
            this.labelItem1 = new DevComponents.DotNetBar.LabelItem();
            this.buttonItem56 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem57 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem58 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem59 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem23 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem24 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem25 = new DevComponents.DotNetBar.ButtonItem();
            this.menuFileMRU = new DevComponents.DotNetBar.ItemContainer();
            this.labelItem8 = new DevComponents.DotNetBar.LabelItem();
            this.buttonItem26 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem27 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem28 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem29 = new DevComponents.DotNetBar.ButtonItem();
            this.menuFileBottomContainer = new DevComponents.DotNetBar.ItemContainer();
            this.buttonOptions = new DevComponents.DotNetBar.ButtonItem();
            this.buttonExit = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonTabItem1 = new DevComponents.DotNetBar.RibbonTabItem();
            this.ribbonTabItem3 = new DevComponents.DotNetBar.RibbonTabItem();
            this.ribbonTabContext = new DevComponents.DotNetBar.RibbonTabItem();
            this.ribbonTabItemGroup1 = new DevComponents.DotNetBar.RibbonTabItemGroup();
            this.buttonChangeStyle = new DevComponents.DotNetBar.ButtonItem();
            this.buttonStyleOffice2010Blue = new DevComponents.DotNetBar.ButtonItem();
            this.AppCommandTheme = new DevComponents.DotNetBar.Command(this.components);
            this.buttonStyleOffice2010Silver = new DevComponents.DotNetBar.ButtonItem();
            this.buttonStyleOffice2010Black = new DevComponents.DotNetBar.ButtonItem();
            this.buttonStyleVS2010 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem62 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonStyleOffice2007Blue = new DevComponents.DotNetBar.ButtonItem();
            this.buttonStyleOffice2007Black = new DevComponents.DotNetBar.ButtonItem();
            this.buttonStyleOffice2007Silver = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem60 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonStyleCustom = new DevComponents.DotNetBar.ColorPickerDropDown();
            this.switchButtonItem1 = new DevComponents.DotNetBar.SwitchButtonItem();
            this.RibbonStateCommand = new DevComponents.DotNetBar.Command(this.components);
            this.buttonNew = new DevComponents.DotNetBar.ButtonItem();
            this.buttonSave = new DevComponents.DotNetBar.ButtonItem();
            this.buttonUndo = new DevComponents.DotNetBar.ButtonItem();
            this.qatCustomizeItem1 = new DevComponents.DotNetBar.QatCustomizeItem();
            this.superTooltip1 = new DevComponents.DotNetBar.SuperTooltip();
            this.progressBarTimer = new System.Windows.Forms.Timer(this.components);
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).BeginInit();
            this.ribbonControl1.SuspendLayout();
            this.ribbonPanel1.SuspendLayout();
            this.ribbonPanel2.SuspendLayout();
            this.ribbonPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contextMenuBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.superTabControl1)).BeginInit();
            this.superTabControl1.SuspendLayout();
            this.superTabControlPanel1.SuspendLayout();
            this.panelEx2.SuspendLayout();
            this.panelEx1.SuspendLayout();
            this.superTabControlPanel4.SuspendLayout();
            this.superTabControlPanel2.SuspendLayout();
            this.superTabControlPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.integerInput1)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "*.rtf";
            this.openFileDialog1.Filter = "Text Files (*.txt)|*.txt|RTF Files (*.rtf)|*.rtf|All Files(*.*)|*.*";
            this.openFileDialog1.FilterIndex = 2;
            this.openFileDialog1.Title = "Open File";
            // 
            // mdiClient1
            // 
            this.mdiClient1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mdiClient1.BackgroundImage")));
            this.mdiClient1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mdiClient1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mdiClient1.Location = new System.Drawing.Point(5, 176);
            this.mdiClient1.Name = "mdiClient1";
            this.mdiClient1.Size = new System.Drawing.Size(766, 301);
            this.mdiClient1.TabIndex = 5;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "*.rtf";
            this.saveFileDialog1.FileName = "doc1";
            this.saveFileDialog1.Filter = "Text Files (*.txt)|*.txt|RTF Files (*.rtf)|*.rtf|All Files(*.*)|*.*";
            this.saveFileDialog1.FilterIndex = 2;
            this.saveFileDialog1.Title = "Save File";
            // 
            // tabStrip1
            // 
            this.tabStrip1.AutoSelectAttachedControl = true;
            this.tabStrip1.CanReorderTabs = true;
            this.tabStrip1.CloseButtonOnTabsVisible = true;
            this.tabStrip1.CloseButtonVisible = false;
            this.tabStrip1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabStrip1.Location = new System.Drawing.Point(5, 150);
            this.tabStrip1.MdiForm = this;
            this.tabStrip1.MdiTabbedDocuments = true;
            this.tabStrip1.Name = "tabStrip1";
            this.tabStrip1.SelectedTab = null;
            this.tabStrip1.SelectedTabFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabStrip1.Size = new System.Drawing.Size(766, 26);
            this.tabStrip1.Style = DevComponents.DotNetBar.eTabStripStyle.Office2007Document;
            this.tabStrip1.TabAlignment = DevComponents.DotNetBar.eTabStripAlignment.Top;
            this.tabStrip1.TabIndex = 6;
            this.tabStrip1.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox;
            this.tabStrip1.Text = "tabStrip1";
            // 
            // bar1
            // 
            this.bar1.AccessibleDescription = "DotNetBar Bar (bar1)";
            this.bar1.AccessibleName = "DotNetBar Bar";
            this.bar1.AccessibleRole = System.Windows.Forms.AccessibleRole.StatusBar;
            this.bar1.AntiAlias = true;
            this.bar1.BarType = DevComponents.DotNetBar.eBarType.StatusBar;
            this.bar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bar1.GrabHandleStyle = DevComponents.DotNetBar.eGrabHandleStyle.ResizeHandle;
            this.bar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.labelStatus,
            this.itemContainer9,
            this.progressBarItem1,
            this.itemContainer13});
            this.bar1.ItemSpacing = 2;
            this.bar1.Location = new System.Drawing.Point(5, 477);
            this.bar1.Name = "bar1";
            this.bar1.Size = new System.Drawing.Size(766, 21);
            this.bar1.Stretch = true;
            this.bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.bar1.TabIndex = 7;
            this.bar1.TabStop = false;
            this.bar1.Text = "barStatus";
            // 
            // labelStatus
            // 
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.PaddingLeft = 2;
            this.labelStatus.PaddingRight = 2;
            this.labelStatus.SingleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.labelStatus.Stretch = true;
            // 
            // itemContainer9
            // 
            // 
            // 
            // 
            this.itemContainer9.BackgroundStyle.Class = "";
            this.itemContainer9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer9.BeginGroup = true;
            this.itemContainer9.Name = "itemContainer9";
            this.itemContainer9.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem13,
            this.buttonItem14,
            this.buttonItem15,
            this.buttonItem16,
            this.buttonItem17});
            // 
            // buttonItem13
            // 
            this.buttonItem13.Checked = true;
            this.buttonItem13.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem13.Image")));
            this.buttonItem13.ImagePaddingVertical = 9;
            this.buttonItem13.Name = "buttonItem13";
            this.buttonItem13.OptionGroup = "statusGroup";
            this.buttonItem13.Text = "Print Layout";
            this.buttonItem13.Tooltip = "Print Layout";
            // 
            // buttonItem14
            // 
            this.buttonItem14.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem14.Image")));
            this.buttonItem14.ImagePaddingVertical = 9;
            this.buttonItem14.Name = "buttonItem14";
            this.buttonItem14.OptionGroup = "statusGroup";
            this.buttonItem14.Text = "Web Layout";
            this.buttonItem14.Tooltip = "Web Layout";
            // 
            // buttonItem15
            // 
            this.buttonItem15.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem15.Image")));
            this.buttonItem15.ImagePaddingVertical = 9;
            this.buttonItem15.Name = "buttonItem15";
            this.buttonItem15.OptionGroup = "statusGroup";
            this.buttonItem15.Text = "Full Screen";
            this.buttonItem15.Tooltip = "Full Screen Reading";
            // 
            // buttonItem16
            // 
            this.buttonItem16.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem16.Image")));
            this.buttonItem16.ImagePaddingVertical = 9;
            this.buttonItem16.Name = "buttonItem16";
            this.buttonItem16.OptionGroup = "statusGroup";
            this.buttonItem16.Text = "Outline";
            this.buttonItem16.Tooltip = "Outline";
            // 
            // buttonItem17
            // 
            this.buttonItem17.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem17.Image")));
            this.buttonItem17.ImagePaddingVertical = 9;
            this.buttonItem17.Name = "buttonItem17";
            this.buttonItem17.OptionGroup = "statusGroup";
            this.buttonItem17.Text = "Draft";
            this.buttonItem17.Tooltip = "Draft";
            // 
            // progressBarItem1
            // 
            // 
            // 
            // 
            this.progressBarItem1.BackStyle.Class = "";
            this.progressBarItem1.BackStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.progressBarItem1.ChunkGradientAngle = 0F;
            this.progressBarItem1.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways;
            this.progressBarItem1.Name = "progressBarItem1";
            this.progressBarItem1.RecentlyUsed = false;
            // 
            // itemContainer13
            // 
            // 
            // 
            // 
            this.itemContainer13.BackgroundStyle.Class = "Office2007StatusBarBackground2";
            this.itemContainer13.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer13.Name = "itemContainer13";
            this.itemContainer13.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.labelPosition,
            this.zoomSlider});
            // 
            // labelPosition
            // 
            this.labelPosition.Name = "labelPosition";
            this.labelPosition.PaddingLeft = 2;
            this.labelPosition.PaddingRight = 2;
            this.labelPosition.SingleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.labelPosition.Width = 100;
            // 
            // zoomSlider
            // 
            this.zoomSlider.Maximum = 200;
            this.zoomSlider.Name = "zoomSlider";
            this.zoomSlider.Step = 5;
            this.zoomSlider.Text = "100%";
            this.zoomSlider.Value = 100;
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.BackColor = System.Drawing.SystemColors.Control;
            // 
            // 
            // 
            this.ribbonControl1.BackgroundStyle.Class = "";
            this.ribbonControl1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonControl1.CaptionVisible = true;
            this.ribbonControl1.Controls.Add(this.ribbonPanel1);
            this.ribbonControl1.Controls.Add(this.ribbonPanel2);
            this.ribbonControl1.Controls.Add(this.ribbonPanel3);
            this.ribbonControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ribbonControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ribbonControl1.GlobalContextMenuBar = this.contextMenuBar1;
            this.ribbonControl1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonFile,
            this.ribbonTabItem1,
            this.ribbonTabItem3,
            this.ribbonTabContext,
            this.buttonChangeStyle,
            this.switchButtonItem1});
            this.ribbonControl1.KeyTipsFont = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ribbonControl1.Location = new System.Drawing.Point(5, 1);
            this.ribbonControl1.MdiSystemItemVisible = false;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.ribbonControl1.QuickToolbarItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonNew,
            this.buttonSave,
            this.buttonUndo,
            this.qatCustomizeItem1});
            this.ribbonControl1.Size = new System.Drawing.Size(766, 149);
            this.ribbonControl1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonControl1.SystemText.MaximizeRibbonText = "&Maximize the Ribbon";
            this.ribbonControl1.SystemText.MinimizeRibbonText = "Mi&nimize the Ribbon";
            this.ribbonControl1.SystemText.QatAddItemText = "&Add to Quick Access Toolbar";
            this.ribbonControl1.SystemText.QatCustomizeMenuLabel = "<b>Customize Quick Access Toolbar</b>";
            this.ribbonControl1.SystemText.QatCustomizeText = "&Customize Quick Access Toolbar...";
            this.ribbonControl1.SystemText.QatDialogAddButton = "&Add >>";
            this.ribbonControl1.SystemText.QatDialogCancelButton = "Cancel";
            this.ribbonControl1.SystemText.QatDialogCaption = "Customize Quick Access Toolbar";
            this.ribbonControl1.SystemText.QatDialogCategoriesLabel = "&Choose commands from:";
            this.ribbonControl1.SystemText.QatDialogOkButton = "OK";
            this.ribbonControl1.SystemText.QatDialogPlacementCheckbox = "&Place Quick Access Toolbar below the Ribbon";
            this.ribbonControl1.SystemText.QatDialogRemoveButton = "&Remove";
            this.ribbonControl1.SystemText.QatPlaceAboveRibbonText = "&Place Quick Access Toolbar above the Ribbon";
            this.ribbonControl1.SystemText.QatPlaceBelowRibbonText = "&Place Quick Access Toolbar below the Ribbon";
            this.ribbonControl1.SystemText.QatRemoveItemText = "&Remove from Quick Access Toolbar";
            this.ribbonControl1.TabGroupHeight = 14;
            this.ribbonControl1.TabGroups.AddRange(new DevComponents.DotNetBar.RibbonTabItemGroup[] {
            this.ribbonTabItemGroup1});
            this.ribbonControl1.TabGroupsVisible = true;
            this.ribbonControl1.TabIndex = 8;
            this.ribbonControl1.TitleTextMarkupLinkClick += new DevComponents.DotNetBar.MarkupLinkClickEventHandler(this.ribbonControl1_TitleTextMarkupLinkClick);
            this.ribbonControl1.BeforeRibbonPanelPopupClose += new DevComponents.DotNetBar.RibbonPopupCloseEventHandler(this.ribbonControl1_BeforeRibbonPanelPopupClose);
            // 
            // ribbonPanel1
            // 
            this.ribbonPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonPanel1.Controls.Add(this.ribbonBar7);
            this.ribbonPanel1.Controls.Add(this.ribbonBar3);
            this.ribbonPanel1.Controls.Add(this.ribbonBar2);
            this.ribbonPanel1.Controls.Add(this.ribbonBar1);
            this.ribbonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonPanel1.Location = new System.Drawing.Point(0, 54);
            this.ribbonPanel1.Name = "ribbonPanel1";
            this.ribbonPanel1.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ribbonPanel1.Size = new System.Drawing.Size(766, 93);
            // 
            // 
            // 
            this.ribbonPanel1.Style.Class = "";
            this.ribbonPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel1.StyleMouseDown.Class = "";
            this.ribbonPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel1.StyleMouseOver.Class = "";
            this.ribbonPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonPanel1.TabIndex = 1;
            // 
            // ribbonBar7
            // 
            this.ribbonBar7.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBar7.BackgroundMouseOverStyle.Class = "";
            this.ribbonBar7.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar7.BackgroundStyle.Class = "";
            this.ribbonBar7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar7.ContainerControlProcessDialogKey = true;
            this.ribbonBar7.DialogLauncherVisible = true;
            this.ribbonBar7.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBar7.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.galleryContainer1});
            this.ribbonBar7.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.ribbonBar7.Location = new System.Drawing.Point(415, 0);
            this.ribbonBar7.Name = "ribbonBar7";
            this.ribbonBar7.Size = new System.Drawing.Size(328, 90);
            this.ribbonBar7.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBar7.TabIndex = 3;
            this.ribbonBar7.Text = "Templates";
            // 
            // 
            // 
            this.ribbonBar7.TitleStyle.Class = "";
            this.ribbonBar7.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar7.TitleStyleMouseOver.Class = "";
            this.ribbonBar7.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar7.VerticalItemAlignment = DevComponents.DotNetBar.eVerticalItemsAlignment.Middle;
            // 
            // galleryContainer1
            // 
            // 
            // 
            // 
            this.galleryContainer1.BackgroundStyle.Class = "RibbonGalleryContainer";
            this.galleryContainer1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.galleryContainer1.DefaultSize = new System.Drawing.Size(200, 58);
            this.galleryContainer1.MinimumSize = new System.Drawing.Size(58, 58);
            this.galleryContainer1.Name = "galleryContainer1";
            this.galleryContainer1.PopupGalleryItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem47,
            this.buttonItem48,
            this.buttonItem49});
            this.galleryContainer1.StretchGallery = true;
            this.galleryContainer1.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem18,
            this.buttonItem19,
            this.buttonItem22,
            this.buttonItem30,
            this.buttonItem31,
            this.buttonItem32,
            this.buttonItem33,
            this.buttonItem34,
            this.buttonItem35,
            this.buttonItem36,
            this.buttonItem37,
            this.buttonItem38,
            this.buttonItem39,
            this.buttonItem40,
            this.buttonItem41,
            this.buttonItem42,
            this.buttonItem43,
            this.buttonItem44,
            this.buttonItem45,
            this.buttonItem46});
            // 
            // buttonItem47
            // 
            this.buttonItem47.BeginGroup = true;
            this.buttonItem47.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem47.Image")));
            this.buttonItem47.Name = "buttonItem47";
            this.buttonItem47.Text = "Search for Templates Online...";
            // 
            // buttonItem48
            // 
            this.buttonItem48.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem48.Image")));
            this.buttonItem48.Name = "buttonItem48";
            this.buttonItem48.Text = "Browse for Templates...";
            // 
            // buttonItem49
            // 
            this.buttonItem49.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem49.Image")));
            this.buttonItem49.Name = "buttonItem49";
            this.buttonItem49.Text = "Save Current Template...";
            // 
            // buttonItem18
            // 
            this.buttonItem18.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem18.Image")));
            this.buttonItem18.Name = "buttonItem18";
            this.buttonItem18.Text = "Apex";
            this.buttonItem18.Tooltip = "Apex";
            // 
            // buttonItem19
            // 
            this.buttonItem19.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem19.Image")));
            this.buttonItem19.Name = "buttonItem19";
            this.buttonItem19.Text = "Aspect";
            this.buttonItem19.Tooltip = "Aspect";
            // 
            // buttonItem22
            // 
            this.buttonItem22.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem22.Image")));
            this.buttonItem22.Name = "buttonItem22";
            this.buttonItem22.Text = "Concourse";
            this.buttonItem22.Tooltip = "Concourse";
            // 
            // buttonItem30
            // 
            this.buttonItem30.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem30.Image")));
            this.buttonItem30.Name = "buttonItem30";
            this.buttonItem30.Text = "Currency";
            this.buttonItem30.Tooltip = "Currency";
            // 
            // buttonItem31
            // 
            this.buttonItem31.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem31.Image")));
            this.buttonItem31.Name = "buttonItem31";
            this.buttonItem31.Text = "Deluxe";
            this.buttonItem31.Tooltip = "Deluxe";
            // 
            // buttonItem32
            // 
            this.buttonItem32.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem32.Image")));
            this.buttonItem32.Name = "buttonItem32";
            this.buttonItem32.Text = "Equity";
            this.buttonItem32.Tooltip = "Equity";
            // 
            // buttonItem33
            // 
            this.buttonItem33.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem33.Image")));
            this.buttonItem33.Name = "buttonItem33";
            this.buttonItem33.Text = "Flow";
            this.buttonItem33.Tooltip = "Flow";
            // 
            // buttonItem34
            // 
            this.buttonItem34.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem34.Image")));
            this.buttonItem34.Name = "buttonItem34";
            this.buttonItem34.Text = "Foundry";
            this.buttonItem34.Tooltip = "Foundry";
            // 
            // buttonItem35
            // 
            this.buttonItem35.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem35.Image")));
            this.buttonItem35.Name = "buttonItem35";
            this.buttonItem35.Text = "Median";
            this.buttonItem35.Tooltip = "Median";
            // 
            // buttonItem36
            // 
            this.buttonItem36.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem36.Image")));
            this.buttonItem36.Name = "buttonItem36";
            this.buttonItem36.Text = "Metro";
            this.buttonItem36.Tooltip = "Metro";
            // 
            // buttonItem37
            // 
            this.buttonItem37.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem37.Image")));
            this.buttonItem37.Name = "buttonItem37";
            this.buttonItem37.Text = "Office";
            this.buttonItem37.Tooltip = "Office";
            // 
            // buttonItem38
            // 
            this.buttonItem38.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem38.Image")));
            this.buttonItem38.Name = "buttonItem38";
            this.buttonItem38.Text = "Opulent";
            this.buttonItem38.Tooltip = "Opulent";
            // 
            // buttonItem39
            // 
            this.buttonItem39.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem39.Image")));
            this.buttonItem39.Name = "buttonItem39";
            this.buttonItem39.Text = "Oriel";
            this.buttonItem39.Tooltip = "Oriel";
            // 
            // buttonItem40
            // 
            this.buttonItem40.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem40.Image")));
            this.buttonItem40.Name = "buttonItem40";
            this.buttonItem40.Text = "Origin";
            this.buttonItem40.Tooltip = "Origin";
            // 
            // buttonItem41
            // 
            this.buttonItem41.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem41.Image")));
            this.buttonItem41.Name = "buttonItem41";
            this.buttonItem41.Text = "Civic";
            this.buttonItem41.Tooltip = "Civic";
            // 
            // buttonItem42
            // 
            this.buttonItem42.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem42.Image")));
            this.buttonItem42.Name = "buttonItem42";
            this.buttonItem42.Text = "Solstice";
            this.buttonItem42.Tooltip = "Solstice";
            // 
            // buttonItem43
            // 
            this.buttonItem43.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem43.Image")));
            this.buttonItem43.Name = "buttonItem43";
            this.buttonItem43.Text = "Technic";
            this.buttonItem43.Tooltip = "Technic";
            // 
            // buttonItem44
            // 
            this.buttonItem44.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem44.Image")));
            this.buttonItem44.Name = "buttonItem44";
            this.buttonItem44.Text = "Trek";
            this.buttonItem44.Tooltip = "Trek";
            // 
            // buttonItem45
            // 
            this.buttonItem45.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem45.Image")));
            this.buttonItem45.Name = "buttonItem45";
            this.buttonItem45.Text = "Urban";
            this.buttonItem45.Tooltip = "Urban";
            // 
            // buttonItem46
            // 
            this.buttonItem46.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem46.Image")));
            this.buttonItem46.Name = "buttonItem46";
            this.buttonItem46.Text = "Verve";
            this.buttonItem46.Tooltip = "Verve";
            // 
            // ribbonBar3
            // 
            this.ribbonBar3.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBar3.BackgroundMouseOverStyle.Class = "";
            this.ribbonBar3.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar3.BackgroundStyle.Class = "";
            this.ribbonBar3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar3.ContainerControlProcessDialogKey = true;
            this.ribbonBar3.DialogLauncherVisible = true;
            this.ribbonBar3.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBar3.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.itemContainer6,
            this.itemContainer4});
            this.ribbonBar3.Location = new System.Drawing.Point(231, 0);
            this.ribbonBar3.Name = "ribbonBar3";
            this.ribbonBar3.Size = new System.Drawing.Size(184, 90);
            this.ribbonBar3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.superTooltip1.SetSuperTooltip(this.ribbonBar3, new DevComponents.DotNetBar.SuperTooltipInfo("SuperTooltip for Dialog Launcher Button", "", "Assigning the Super Tooltip to the Ribbon Bar control will display it when mouse " +
                        "hovers over the Dialog Launcher button.", null, null, DevComponents.DotNetBar.eTooltipColor.Gray));
            this.ribbonBar3.TabIndex = 2;
            this.ribbonBar3.Text = "&Paragraph";
            // 
            // 
            // 
            this.ribbonBar3.TitleStyle.Class = "";
            this.ribbonBar3.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar3.TitleStyleMouseOver.Class = "";
            this.ribbonBar3.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar3.VerticalItemAlignment = DevComponents.DotNetBar.eVerticalItemsAlignment.Middle;
            this.ribbonBar3.LaunchDialog += new System.EventHandler(this.LaunchRibbonDialog);
            // 
            // itemContainer6
            // 
            // 
            // 
            // 
            this.itemContainer6.BackgroundStyle.Class = "";
            this.itemContainer6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer6.ItemSpacing = 3;
            this.itemContainer6.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.itemContainer6.Name = "itemContainer6";
            this.itemContainer6.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.itemContainer7,
            this.itemContainer8});
            this.itemContainer6.VerticalItemAlignment = DevComponents.DotNetBar.eVerticalItemsAlignment.Middle;
            // 
            // itemContainer7
            // 
            // 
            // 
            // 
            this.itemContainer7.BackgroundStyle.Class = "";
            this.itemContainer7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer7.BeginGroup = true;
            this.itemContainer7.Name = "itemContainer7";
            this.itemContainer7.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonAlignLeft,
            this.buttonAlignCenter,
            this.buttonAlignRight,
            this.buttonAlignJustify});
            // 
            // buttonAlignLeft
            // 
            this.buttonAlignLeft.Enabled = false;
            this.buttonAlignLeft.Image = ((System.Drawing.Image)(resources.GetObject("buttonAlignLeft.Image")));
            this.buttonAlignLeft.Name = "buttonAlignLeft";
            this.buttonAlignLeft.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlL);
            this.superTooltip1.SetSuperTooltip(this.buttonAlignLeft, new DevComponents.DotNetBar.SuperTooltipInfo("Align Left (Ctrl+L)", "", "Align text to left.", null, null, DevComponents.DotNetBar.eTooltipColor.Gray));
            this.buttonAlignLeft.Text = "Align &Left";
            // 
            // buttonAlignCenter
            // 
            this.buttonAlignCenter.Enabled = false;
            this.buttonAlignCenter.Image = ((System.Drawing.Image)(resources.GetObject("buttonAlignCenter.Image")));
            this.buttonAlignCenter.Name = "buttonAlignCenter";
            this.buttonAlignCenter.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlE);
            this.superTooltip1.SetSuperTooltip(this.buttonAlignCenter, new DevComponents.DotNetBar.SuperTooltipInfo("Center (Ctrl+E)", "", "Center text.", null, null, DevComponents.DotNetBar.eTooltipColor.Gray));
            this.buttonAlignCenter.Text = "Align &Center";
            // 
            // buttonAlignRight
            // 
            this.buttonAlignRight.Enabled = false;
            this.buttonAlignRight.Image = ((System.Drawing.Image)(resources.GetObject("buttonAlignRight.Image")));
            this.buttonAlignRight.Name = "buttonAlignRight";
            this.buttonAlignRight.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlR);
            this.superTooltip1.SetSuperTooltip(this.buttonAlignRight, new DevComponents.DotNetBar.SuperTooltipInfo("Align Right (Ctrl+R)", "", "Align text to the right.", null, null, DevComponents.DotNetBar.eTooltipColor.Gray));
            this.buttonAlignRight.Text = "Align &Right";
            // 
            // buttonAlignJustify
            // 
            this.buttonAlignJustify.Enabled = false;
            this.buttonAlignJustify.Image = ((System.Drawing.Image)(resources.GetObject("buttonAlignJustify.Image")));
            this.buttonAlignJustify.Name = "buttonAlignJustify";
            this.buttonAlignJustify.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlJ);
            this.superTooltip1.SetSuperTooltip(this.buttonAlignJustify, new DevComponents.DotNetBar.SuperTooltipInfo("Justify (Ctrl+J)", "", "Align text to both the left and right margins, adding extra space between words a" +
                        "s necessary.\r\n\r\nThis creates a clean look along the left and right side of the p" +
                        "age.", null, null, DevComponents.DotNetBar.eTooltipColor.Gray));
            this.buttonAlignJustify.Text = "&Justify";
            // 
            // itemContainer8
            // 
            // 
            // 
            // 
            this.itemContainer8.BackgroundStyle.Class = "";
            this.itemContainer8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer8.BeginGroup = true;
            this.itemContainer8.Name = "itemContainer8";
            this.itemContainer8.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem2,
            this.buttonItem3,
            this.buttonItem4,
            this.buttonItem5});
            // 
            // buttonItem2
            // 
            this.buttonItem2.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem2.Image")));
            this.buttonItem2.Name = "buttonItem2";
            this.superTooltip1.SetSuperTooltip(this.buttonItem2, new DevComponents.DotNetBar.SuperTooltipInfo("Numbering", "", "Add numbering to the text.", null, null, DevComponents.DotNetBar.eTooltipColor.Gray));
            this.buttonItem2.Text = "&Numbered Bullets";
            // 
            // buttonItem3
            // 
            this.buttonItem3.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem3.Image")));
            this.buttonItem3.Name = "buttonItem3";
            this.superTooltip1.SetSuperTooltip(this.buttonItem3, new DevComponents.DotNetBar.SuperTooltipInfo("Bullets", "", "Add bullets to the text.", null, null, DevComponents.DotNetBar.eTooltipColor.Gray));
            this.buttonItem3.Text = "&Bullets";
            // 
            // buttonItem4
            // 
            this.buttonItem4.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem4.Image")));
            this.buttonItem4.Name = "buttonItem4";
            this.superTooltip1.SetSuperTooltip(this.buttonItem4, new DevComponents.DotNetBar.SuperTooltipInfo("Increase Indent", "", "Change the indentation of text.", null, null, DevComponents.DotNetBar.eTooltipColor.Gray));
            this.buttonItem4.Text = "&Indent";
            // 
            // buttonItem5
            // 
            this.buttonItem5.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem5.Image")));
            this.buttonItem5.Name = "buttonItem5";
            this.superTooltip1.SetSuperTooltip(this.buttonItem5, new DevComponents.DotNetBar.SuperTooltipInfo("Decrease Indent", "", "Change the indentation of text.", null, null, DevComponents.DotNetBar.eTooltipColor.Gray));
            this.buttonItem5.Text = "&Outdent";
            // 
            // itemContainer4
            // 
            // 
            // 
            // 
            this.itemContainer4.BackgroundStyle.Class = "";
            this.itemContainer4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer4.ItemSpacing = 3;
            this.itemContainer4.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.itemContainer4.Name = "itemContainer4";
            this.itemContainer4.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem6,
            this.buttonItem7});
            this.itemContainer4.VerticalItemAlignment = DevComponents.DotNetBar.eVerticalItemsAlignment.Middle;
            // 
            // buttonItem6
            // 
            this.buttonItem6.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem6.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem6.Image")));
            this.buttonItem6.Name = "buttonItem6";
            this.superTooltip1.SetSuperTooltip(this.buttonItem6, new DevComponents.DotNetBar.SuperTooltipInfo("Borders", "", "Change borders of the selected text.\r\n\r\nThis feature has not been implemented yet" +
                        ".", null, null, DevComponents.DotNetBar.eTooltipColor.Gray));
            this.buttonItem6.Text = "&Borders";
            // 
            // buttonItem7
            // 
            this.buttonItem7.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem7.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem7.Image")));
            this.buttonItem7.Name = "buttonItem7";
            this.superTooltip1.SetSuperTooltip(this.buttonItem7, new DevComponents.DotNetBar.SuperTooltipInfo("Shading", "", "Changes shading of selected text.\r\n\r\nThis feature has not been implemented yet.", null, null, DevComponents.DotNetBar.eTooltipColor.Gray));
            this.buttonItem7.Text = "&Shading";
            // 
            // ribbonBar2
            // 
            this.ribbonBar2.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBar2.BackgroundMouseOverStyle.Class = "";
            this.ribbonBar2.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar2.BackgroundStyle.Class = "";
            this.ribbonBar2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar2.ContainerControlProcessDialogKey = true;
            this.ribbonBar2.DialogLauncherVisible = true;
            this.ribbonBar2.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBar2.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.itemContainer2,
            this.itemContainer3});
            this.ribbonBar2.ItemSpacing = 5;
            this.ribbonBar2.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.ribbonBar2.Location = new System.Drawing.Point(76, 0);
            this.ribbonBar2.Name = "ribbonBar2";
            this.ribbonBar2.ResizeItemsToFit = false;
            this.ribbonBar2.Size = new System.Drawing.Size(155, 90);
            this.ribbonBar2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.superTooltip1.SetSuperTooltip(this.ribbonBar2, new DevComponents.DotNetBar.SuperTooltipInfo("SuperTooltip for Dialog Launcher Button", "", "Assigning the Super Tooltip to the Ribbon Bar control will display it when mouse " +
                        "hovers over the Dialog Launcher button.", null, null, DevComponents.DotNetBar.eTooltipColor.Gray));
            this.ribbonBar2.TabIndex = 1;
            this.ribbonBar2.Text = "F&ont";
            // 
            // 
            // 
            this.ribbonBar2.TitleStyle.Class = "";
            this.ribbonBar2.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar2.TitleStyleMouseOver.Class = "";
            this.ribbonBar2.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar2.VerticalItemAlignment = DevComponents.DotNetBar.eVerticalItemsAlignment.Middle;
            this.ribbonBar2.PopupContainerUnload += new System.EventHandler(this.UnloadPopup);
            this.ribbonBar2.LaunchDialog += new System.EventHandler(this.LaunchRibbonDialog);
            // 
            // itemContainer2
            // 
            // 
            // 
            // 
            this.itemContainer2.BackgroundStyle.Class = "";
            this.itemContainer2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer2.Name = "itemContainer2";
            this.itemContainer2.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.comboFont,
            this.comboFontSize});
            // 
            // comboFont
            // 
            this.comboFont.ComboWidth = 96;
            this.comboFont.DropDownHeight = 106;
            this.comboFont.DropDownWidth = 242;
            this.comboFont.Enabled = false;
            this.comboFont.FontCombo = true;
            this.comboFont.ItemHeight = 14;
            this.comboFont.Name = "comboFont";
            this.superTooltip1.SetSuperTooltip(this.comboFont, new DevComponents.DotNetBar.SuperTooltipInfo("Font", "", "Change the font face.", null, null, DevComponents.DotNetBar.eTooltipColor.Gray));
            // 
            // comboFontSize
            // 
            this.comboFontSize.ComboWidth = 40;
            this.comboFontSize.DropDownHeight = 106;
            this.comboFontSize.Enabled = false;
            this.comboFontSize.ItemHeight = 14;
            this.comboFontSize.Items.AddRange(new object[] {
            this.comboItem1,
            this.comboItem2,
            this.comboItem3,
            this.comboItem4,
            this.comboItem5,
            this.comboItem6,
            this.comboItem7,
            this.comboItem8,
            this.comboItem9});
            this.comboFontSize.Name = "comboFontSize";
            // 
            // comboItem1
            // 
            this.comboItem1.Text = "6";
            // 
            // comboItem2
            // 
            this.comboItem2.Text = "7";
            // 
            // comboItem3
            // 
            this.comboItem3.Text = "8";
            // 
            // comboItem4
            // 
            this.comboItem4.Text = "9";
            // 
            // comboItem5
            // 
            this.comboItem5.Text = "10";
            // 
            // comboItem6
            // 
            this.comboItem6.Text = "11";
            // 
            // comboItem7
            // 
            this.comboItem7.Text = "12";
            // 
            // comboItem8
            // 
            this.comboItem8.Text = "13";
            // 
            // comboItem9
            // 
            this.comboItem9.Text = "14";
            // 
            // itemContainer3
            // 
            // 
            // 
            // 
            this.itemContainer3.BackgroundStyle.Class = "";
            this.itemContainer3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer3.BeginGroup = true;
            this.itemContainer3.Name = "itemContainer3";
            this.itemContainer3.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonFontBold,
            this.buttonFontItalic,
            this.buttonFontUnderline,
            this.buttonFontStrike,
            this.buttonTextColor});
            // 
            // buttonFontBold
            // 
            this.buttonFontBold.Enabled = false;
            this.buttonFontBold.Image = ((System.Drawing.Image)(resources.GetObject("buttonFontBold.Image")));
            this.buttonFontBold.Name = "buttonFontBold";
            this.buttonFontBold.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlB);
            this.superTooltip1.SetSuperTooltip(this.buttonFontBold, new DevComponents.DotNetBar.SuperTooltipInfo("Bold (Ctrl+B)", "", "Make selected text bold", null, null, DevComponents.DotNetBar.eTooltipColor.Gray));
            this.buttonFontBold.Text = "&Bold";
            // 
            // buttonFontItalic
            // 
            this.buttonFontItalic.Enabled = false;
            this.buttonFontItalic.Image = ((System.Drawing.Image)(resources.GetObject("buttonFontItalic.Image")));
            this.buttonFontItalic.Name = "buttonFontItalic";
            this.buttonFontItalic.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlI);
            this.superTooltip1.SetSuperTooltip(this.buttonFontItalic, new DevComponents.DotNetBar.SuperTooltipInfo("Italic (Ctrl+I)", "", "Italicize the selected text.", null, null, DevComponents.DotNetBar.eTooltipColor.Gray));
            this.buttonFontItalic.Text = "&Italic";
            // 
            // buttonFontUnderline
            // 
            this.buttonFontUnderline.Enabled = false;
            this.buttonFontUnderline.Image = ((System.Drawing.Image)(resources.GetObject("buttonFontUnderline.Image")));
            this.buttonFontUnderline.Name = "buttonFontUnderline";
            this.buttonFontUnderline.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlU);
            this.superTooltip1.SetSuperTooltip(this.buttonFontUnderline, new DevComponents.DotNetBar.SuperTooltipInfo("Underline (Ctrl+U)", "", "Underline the selected text.", null, null, DevComponents.DotNetBar.eTooltipColor.Gray));
            this.buttonFontUnderline.Text = "&Underline";
            // 
            // buttonFontStrike
            // 
            this.buttonFontStrike.Enabled = false;
            this.buttonFontStrike.Image = ((System.Drawing.Image)(resources.GetObject("buttonFontStrike.Image")));
            this.buttonFontStrike.Name = "buttonFontStrike";
            this.superTooltip1.SetSuperTooltip(this.buttonFontStrike, new DevComponents.DotNetBar.SuperTooltipInfo("Strikethrough", "", "Draw a line through the middle of the selected text.", null, null, DevComponents.DotNetBar.eTooltipColor.Gray));
            this.buttonFontStrike.Text = "&Strike";
            // 
            // buttonTextColor
            // 
            this.buttonTextColor.Enabled = false;
            this.buttonTextColor.Image = ((System.Drawing.Image)(resources.GetObject("buttonTextColor.Image")));
            this.buttonTextColor.Name = "buttonTextColor";
            this.buttonTextColor.SelectedColorImageRectangle = new System.Drawing.Rectangle(0, 13, 16, 3);
            this.superTooltip1.SetSuperTooltip(this.buttonTextColor, new DevComponents.DotNetBar.SuperTooltipInfo("Text Color", "", "Change the selected text color.", null, null, DevComponents.DotNetBar.eTooltipColor.Gray));
            this.buttonTextColor.Text = "Text &Color";
            // 
            // ribbonBar1
            // 
            this.ribbonBar1.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBar1.BackgroundMouseOverStyle.Class = "";
            this.ribbonBar1.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar1.BackgroundStyle.Class = "";
            this.ribbonBar1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar1.ContainerControlProcessDialogKey = true;
            this.ribbonBar1.DialogLauncherVisible = true;
            this.ribbonBar1.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonPaste,
            this.itemContainer1});
            this.ribbonBar1.Location = new System.Drawing.Point(3, 0);
            this.ribbonBar1.Name = "ribbonBar1";
            this.ribbonBar1.Size = new System.Drawing.Size(73, 90);
            this.ribbonBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.superTooltip1.SetSuperTooltip(this.ribbonBar1, new DevComponents.DotNetBar.SuperTooltipInfo("SuperTooltip for Dialog Launcher", "", "Assigning the Super Tooltip to the Ribbon Bar control will display it when mouse " +
                        "hovers over the Dialog Launcher button.", null, null, DevComponents.DotNetBar.eTooltipColor.Gray));
            this.ribbonBar1.TabIndex = 0;
            this.ribbonBar1.Text = "&Clipboard";
            // 
            // 
            // 
            this.ribbonBar1.TitleStyle.Class = "";
            this.ribbonBar1.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar1.TitleStyleMouseOver.Class = "";
            this.ribbonBar1.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar1.LaunchDialog += new System.EventHandler(this.LaunchRibbonDialog);
            // 
            // buttonPaste
            // 
            this.buttonPaste.Image = ((System.Drawing.Image)(resources.GetObject("buttonPaste.Image")));
            this.buttonPaste.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonPaste.Name = "buttonPaste";
            this.buttonPaste.SplitButton = true;
            this.buttonPaste.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem53,
            this.buttonItem54});
            this.superTooltip1.SetSuperTooltip(this.buttonPaste, new DevComponents.DotNetBar.SuperTooltipInfo("Paste (Ctrl+V)", "", "Paste text from clipboard.", null, null, DevComponents.DotNetBar.eTooltipColor.Gray));
            this.buttonPaste.Text = "&Paste";
            // 
            // buttonItem53
            // 
            this.buttonItem53.Enabled = false;
            this.buttonItem53.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem53.Image")));
            this.buttonItem53.Name = "buttonItem53";
            this.buttonItem53.Text = "&Paste";
            // 
            // buttonItem54
            // 
            this.buttonItem54.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem54.Image")));
            this.buttonItem54.Name = "buttonItem54";
            this.buttonItem54.Text = "Paste &Special...";
            // 
            // itemContainer1
            // 
            // 
            // 
            // 
            this.itemContainer1.BackgroundStyle.Class = "";
            this.itemContainer1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer1.ItemSpacing = 0;
            this.itemContainer1.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.itemContainer1.Name = "itemContainer1";
            this.itemContainer1.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonCut,
            this.buttonCopy,
            this.buttonItem55});
            // 
            // buttonCut
            // 
            this.buttonCut.Enabled = false;
            this.buttonCut.Image = ((System.Drawing.Image)(resources.GetObject("buttonCut.Image")));
            this.buttonCut.Name = "buttonCut";
            this.superTooltip1.SetSuperTooltip(this.buttonCut, new DevComponents.DotNetBar.SuperTooltipInfo("Cut (Ctrl+X)", "", "Removes selected text and copies it to clipboard.", null, null, DevComponents.DotNetBar.eTooltipColor.Gray));
            this.buttonCut.Text = "Cu&t";
            // 
            // buttonCopy
            // 
            this.buttonCopy.Enabled = false;
            this.buttonCopy.Image = ((System.Drawing.Image)(resources.GetObject("buttonCopy.Image")));
            this.buttonCopy.Name = "buttonCopy";
            this.superTooltip1.SetSuperTooltip(this.buttonCopy, new DevComponents.DotNetBar.SuperTooltipInfo("Copy (Ctrl+C)", "", "Copy selected text to clipboard.", null, null, DevComponents.DotNetBar.eTooltipColor.Gray));
            this.buttonCopy.Text = "&Copy";
            // 
            // buttonItem55
            // 
            this.buttonItem55.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem55.Image")));
            this.buttonItem55.Name = "buttonItem55";
            this.superTooltip1.SetSuperTooltip(this.buttonItem55, new DevComponents.DotNetBar.SuperTooltipInfo("Format Painter", "This command is not implemented", "Copy formatting from one place and apply it to another.", null, null, DevComponents.DotNetBar.eTooltipColor.Gray));
            this.buttonItem55.Text = "Format Painter";
            // 
            // ribbonPanel2
            // 
            this.ribbonPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonPanel2.Controls.Add(this.ribbonBar6);
            this.ribbonPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonPanel2.Location = new System.Drawing.Point(0, 54);
            this.ribbonPanel2.Name = "ribbonPanel2";
            this.ribbonPanel2.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ribbonPanel2.Size = new System.Drawing.Size(766, 93);
            // 
            // 
            // 
            this.ribbonPanel2.Style.Class = "";
            this.ribbonPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel2.StyleMouseDown.Class = "";
            this.ribbonPanel2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel2.StyleMouseOver.Class = "";
            this.ribbonPanel2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonPanel2.TabIndex = 4;
            this.ribbonPanel2.Visible = false;
            // 
            // ribbonBar6
            // 
            this.ribbonBar6.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBar6.BackgroundMouseOverStyle.Class = "";
            this.ribbonBar6.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar6.BackgroundStyle.Class = "";
            this.ribbonBar6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar6.ContainerControlProcessDialogKey = true;
            this.ribbonBar6.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem1,
            this.buttonItem8,
            this.buttonItem12});
            this.ribbonBar6.Location = new System.Drawing.Point(3, 0);
            this.ribbonBar6.Name = "ribbonBar6";
            this.ribbonBar6.Size = new System.Drawing.Size(337, 87);
            this.ribbonBar6.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBar6.TabIndex = 0;
            this.ribbonBar6.Text = "Contextual Ribbon";
            // 
            // 
            // 
            this.ribbonBar6.TitleStyle.Class = "";
            this.ribbonBar6.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar6.TitleStyleMouseOver.Class = "";
            this.ribbonBar6.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // buttonItem1
            // 
            this.buttonItem1.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem1.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem1.Image")));
            this.buttonItem1.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItem1.Name = "buttonItem1";
            this.buttonItem1.RibbonWordWrap = false;
            this.buttonItem1.Text = "Command 1";
            // 
            // buttonItem8
            // 
            this.buttonItem8.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem8.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem8.Image")));
            this.buttonItem8.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItem8.Name = "buttonItem8";
            this.buttonItem8.RibbonWordWrap = false;
            this.buttonItem8.Text = "Command 2";
            // 
            // buttonItem12
            // 
            this.buttonItem12.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem12.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem12.Image")));
            this.buttonItem12.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItem12.Name = "buttonItem12";
            this.buttonItem12.RibbonWordWrap = false;
            this.buttonItem12.Text = "Command 3";
            // 
            // ribbonPanel3
            // 
            this.ribbonPanel3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonPanel3.Controls.Add(this.ribbonBar8);
            this.ribbonPanel3.Controls.Add(this.ribbonBar4);
            this.ribbonPanel3.Controls.Add(this.ribbonBar5);
            this.ribbonPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonPanel3.Location = new System.Drawing.Point(0, 54);
            this.ribbonPanel3.Name = "ribbonPanel3";
            this.ribbonPanel3.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ribbonPanel3.Size = new System.Drawing.Size(766, 93);
            // 
            // 
            // 
            this.ribbonPanel3.Style.Class = "";
            this.ribbonPanel3.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel3.StyleMouseDown.Class = "";
            this.ribbonPanel3.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel3.StyleMouseOver.Class = "";
            this.ribbonPanel3.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonPanel3.TabIndex = 3;
            this.ribbonPanel3.Visible = false;
            // 
            // ribbonBar8
            // 
            this.ribbonBar8.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBar8.BackgroundMouseOverStyle.Class = "";
            this.ribbonBar8.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar8.BackgroundStyle.Class = "";
            this.ribbonBar8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar8.ContainerControlProcessDialogKey = true;
            this.ribbonBar8.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBar8.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.itemContainer10,
            this.itemContainer11});
            this.ribbonBar8.ItemSpacing = 4;
            this.ribbonBar8.Location = new System.Drawing.Point(466, 0);
            this.ribbonBar8.Name = "ribbonBar8";
            this.ribbonBar8.Size = new System.Drawing.Size(200, 90);
            this.ribbonBar8.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBar8.TabIndex = 4;
            this.ribbonBar8.Text = "Options";
            // 
            // 
            // 
            this.ribbonBar8.TitleStyle.Class = "";
            this.ribbonBar8.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar8.TitleStyleMouseOver.Class = "";
            this.ribbonBar8.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // itemContainer10
            // 
            // 
            // 
            // 
            this.itemContainer10.BackgroundStyle.Class = "";
            this.itemContainer10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer10.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.itemContainer10.Name = "itemContainer10";
            this.itemContainer10.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.checkBoxItem1,
            this.checkBoxItem2,
            this.checkBoxItem3});
            // 
            // checkBoxItem1
            // 
            this.checkBoxItem1.Checked = true;
            this.checkBoxItem1.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.checkBoxItem1.Name = "checkBoxItem1";
            this.checkBoxItem1.Text = "Header";
            this.checkBoxItem1.ThreeState = true;
            // 
            // checkBoxItem2
            // 
            this.checkBoxItem2.Name = "checkBoxItem2";
            this.checkBoxItem2.Text = "Footer";
            // 
            // checkBoxItem3
            // 
            this.checkBoxItem3.Checked = true;
            this.checkBoxItem3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxItem3.Name = "checkBoxItem3";
            this.checkBoxItem3.Text = "Margins";
            // 
            // itemContainer11
            // 
            // 
            // 
            // 
            this.itemContainer11.BackgroundStyle.Class = "";
            this.itemContainer11.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer11.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.itemContainer11.Name = "itemContainer11";
            this.itemContainer11.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.checkBoxItem4,
            this.checkBoxItem5,
            this.checkBoxItem6});
            // 
            // checkBoxItem4
            // 
            this.checkBoxItem4.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton;
            this.checkBoxItem4.Name = "checkBoxItem4";
            this.checkBoxItem4.Text = "Horizontal Layout";
            // 
            // checkBoxItem5
            // 
            this.checkBoxItem5.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton;
            this.checkBoxItem5.Name = "checkBoxItem5";
            this.checkBoxItem5.Text = "Vertical Layout";
            // 
            // checkBoxItem6
            // 
            this.checkBoxItem6.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton;
            this.checkBoxItem6.Checked = true;
            this.checkBoxItem6.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxItem6.Name = "checkBoxItem6";
            this.checkBoxItem6.Text = "Automatic Layout";
            // 
            // ribbonBar4
            // 
            this.ribbonBar4.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBar4.BackgroundMouseOverStyle.Class = "";
            this.ribbonBar4.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar4.BackgroundStyle.Class = "";
            this.ribbonBar4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar4.ContainerControlProcessDialogKey = true;
            this.ribbonBar4.DialogLauncherVisible = true;
            this.ribbonBar4.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBar4.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonFind,
            this.itemContainer5});
            this.ribbonBar4.Location = new System.Drawing.Point(322, 0);
            this.ribbonBar4.Name = "ribbonBar4";
            this.ribbonBar4.Size = new System.Drawing.Size(144, 90);
            this.ribbonBar4.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.superTooltip1.SetSuperTooltip(this.ribbonBar4, new DevComponents.DotNetBar.SuperTooltipInfo("SuperTooltip for Dialog Launcher Button", "", "Assigning the Super Tooltip to the Ribbon Bar control will display it when mouse " +
                        "hovers over the Dialog Launcher button.", null, null, DevComponents.DotNetBar.eTooltipColor.Gray));
            this.ribbonBar4.TabIndex = 3;
            this.ribbonBar4.Text = "Fi&nd";
            // 
            // 
            // 
            this.ribbonBar4.TitleStyle.Class = "";
            this.ribbonBar4.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar4.TitleStyleMouseOver.Class = "";
            this.ribbonBar4.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar4.LaunchDialog += new System.EventHandler(this.LaunchRibbonDialog);
            // 
            // buttonFind
            // 
            this.buttonFind.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonFind.Enabled = false;
            this.buttonFind.Image = ((System.Drawing.Image)(resources.GetObject("buttonFind.Image")));
            this.buttonFind.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlF);
            this.superTooltip1.SetSuperTooltip(this.buttonFind, new DevComponents.DotNetBar.SuperTooltipInfo("Find (Ctrl+F)", "", "Find text in document.", null, null, DevComponents.DotNetBar.eTooltipColor.Gray));
            this.buttonFind.Text = "&Find";
            this.buttonFind.Click += new System.EventHandler(this.buttonFind_Click);
            // 
            // itemContainer5
            // 
            // 
            // 
            // 
            this.itemContainer5.BackgroundStyle.Class = "";
            this.itemContainer5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer5.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.itemContainer5.Name = "itemContainer5";
            this.itemContainer5.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonReplace,
            this.buttonGoto});
            // 
            // buttonReplace
            // 
            this.buttonReplace.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonReplace.Enabled = false;
            this.buttonReplace.Image = ((System.Drawing.Image)(resources.GetObject("buttonReplace.Image")));
            this.buttonReplace.Name = "buttonReplace";
            this.superTooltip1.SetSuperTooltip(this.buttonReplace, new DevComponents.DotNetBar.SuperTooltipInfo("Replace", "", "Find and replace the text in document.\r\n\r\nThis feature has not been implemented y" +
                        "et.", null, null, DevComponents.DotNetBar.eTooltipColor.Gray));
            this.buttonReplace.Text = "&Replace";
            // 
            // buttonGoto
            // 
            this.buttonGoto.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonGoto.Enabled = false;
            this.buttonGoto.Image = ((System.Drawing.Image)(resources.GetObject("buttonGoto.Image")));
            this.buttonGoto.Name = "buttonGoto";
            this.superTooltip1.SetSuperTooltip(this.buttonGoto, new DevComponents.DotNetBar.SuperTooltipInfo("Go to line", "", "Go to specified line number in current document.\r\n\r\nThis feature has not been imp" +
                        "lemented yet.", null, null, DevComponents.DotNetBar.eTooltipColor.Gray));
            this.buttonGoto.Text = "&Goto";
            // 
            // ribbonBar5
            // 
            this.ribbonBar5.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBar5.BackgroundMouseOverStyle.Class = "";
            this.ribbonBar5.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar5.BackgroundStyle.Class = "";
            this.ribbonBar5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar5.ContainerControlProcessDialogKey = true;
            this.ribbonBar5.DialogLauncherVisible = true;
            this.ribbonBar5.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBar5.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonMargins,
            this.buttonItem9,
            this.buttonItem10,
            this.buttonItem11});
            this.ribbonBar5.Location = new System.Drawing.Point(3, 0);
            this.ribbonBar5.Name = "ribbonBar5";
            this.ribbonBar5.Size = new System.Drawing.Size(319, 90);
            this.ribbonBar5.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBar5.TabIndex = 1;
            this.ribbonBar5.Text = "Page Setup";
            // 
            // 
            // 
            this.ribbonBar5.TitleStyle.Class = "";
            this.ribbonBar5.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar5.TitleStyleMouseOver.Class = "";
            this.ribbonBar5.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar5.LaunchDialog += new System.EventHandler(this.LaunchRibbonDialog);
            // 
            // buttonMargins
            // 
            this.buttonMargins.Image = ((System.Drawing.Image)(resources.GetObject("buttonMargins.Image")));
            this.buttonMargins.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonMargins.Name = "buttonMargins";
            this.buttonMargins.Text = "Margins";
            // 
            // buttonItem9
            // 
            this.buttonItem9.AutoExpandOnClick = true;
            this.buttonItem9.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem9.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem9.Image")));
            this.buttonItem9.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItem9.Name = "buttonItem9";
            this.buttonItem9.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem50,
            this.buttonItem51,
            this.buttonItem52});
            this.buttonItem9.Text = "Orientation <expand/>";
            // 
            // buttonItem50
            // 
            this.buttonItem50.Checked = true;
            this.buttonItem50.Name = "buttonItem50";
            this.buttonItem50.OptionGroup = "orientation";
            this.buttonItem50.Text = "Auto";
            // 
            // buttonItem51
            // 
            this.buttonItem51.Name = "buttonItem51";
            this.buttonItem51.OptionGroup = "orientation";
            this.buttonItem51.Text = "Horizontal";
            // 
            // buttonItem52
            // 
            this.buttonItem52.Name = "buttonItem52";
            this.buttonItem52.OptionGroup = "orientation";
            this.buttonItem52.Text = "Vertical";
            // 
            // buttonItem10
            // 
            this.buttonItem10.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem10.Image")));
            this.buttonItem10.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItem10.Name = "buttonItem10";
            this.buttonItem10.Text = "Size";
            // 
            // buttonItem11
            // 
            this.buttonItem11.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem11.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem11.Image")));
            this.buttonItem11.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItem11.Name = "buttonItem11";
            this.buttonItem11.Text = "Print Area";
            // 
            // contextMenuBar1
            // 
            this.contextMenuBar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuBar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.bEditPopup});
            this.contextMenuBar1.Location = new System.Drawing.Point(352, 309);
            this.contextMenuBar1.Name = "contextMenuBar1";
            this.contextMenuBar1.Size = new System.Drawing.Size(150, 25);
            this.contextMenuBar1.Stretch = true;
            this.contextMenuBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.contextMenuBar1.TabIndex = 13;
            this.contextMenuBar1.TabStop = false;
            // 
            // bEditPopup
            // 
            this.bEditPopup.AutoExpandOnClick = true;
            this.bEditPopup.GlobalName = "bEditPopup";
            this.bEditPopup.Name = "bEditPopup";
            this.bEditPopup.PopupAnimation = DevComponents.DotNetBar.ePopupAnimation.SystemDefault;
            this.bEditPopup.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.bCut,
            this.bCopy,
            this.bPaste,
            this.bSelectAll});
            this.bEditPopup.Text = "bEditPopup";
            // 
            // bCut
            // 
            this.bCut.BeginGroup = true;
            this.bCut.GlobalName = "bCut";
            this.bCut.ImageIndex = 5;
            this.bCut.Name = "bCut";
            this.bCut.PopupAnimation = DevComponents.DotNetBar.ePopupAnimation.SystemDefault;
            this.bCut.Text = "Cu&t";
            // 
            // bCopy
            // 
            this.bCopy.GlobalName = "bCopy";
            this.bCopy.ImageIndex = 4;
            this.bCopy.Name = "bCopy";
            this.bCopy.PopupAnimation = DevComponents.DotNetBar.ePopupAnimation.SystemDefault;
            this.bCopy.Text = "&Copy";
            // 
            // bPaste
            // 
            this.bPaste.GlobalName = "bPaste";
            this.bPaste.ImageIndex = 12;
            this.bPaste.Name = "bPaste";
            this.bPaste.PopupAnimation = DevComponents.DotNetBar.ePopupAnimation.SystemDefault;
            this.bPaste.Text = "&Paste";
            // 
            // bSelectAll
            // 
            this.bSelectAll.BeginGroup = true;
            this.bSelectAll.GlobalName = "bSelectAll";
            this.bSelectAll.Name = "bSelectAll";
            this.bSelectAll.PopupAnimation = DevComponents.DotNetBar.ePopupAnimation.SystemDefault;
            this.bSelectAll.Text = "Select &All";
            // 
            // buttonFile
            // 
            this.buttonFile.AutoExpandOnClick = true;
            this.buttonFile.BackstageTab = this.superTabControl1;
            this.buttonFile.CanCustomize = false;
            this.buttonFile.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.Image;
            this.buttonFile.Image = ((System.Drawing.Image)(resources.GetObject("buttonFile.Image")));
            this.buttonFile.ImageFixedSize = new System.Drawing.Size(16, 16);
            this.buttonFile.ImagePaddingHorizontal = 0;
            this.buttonFile.ImagePaddingVertical = 0;
            this.buttonFile.Name = "buttonFile";
            this.buttonFile.ShowSubItems = false;
            this.buttonFile.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.menuFileContainer});
            this.buttonFile.Text = "&File";
            // 
            // superTabControl1
            // 
            this.superTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            // 
            // 
            // 
            this.superTabControl1.ControlBox.CloseBox.Name = "";
            // 
            // 
            // 
            this.superTabControl1.ControlBox.MenuBox.Name = "";
            this.superTabControl1.ControlBox.Name = "";
            this.superTabControl1.ControlBox.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.superTabControl1.ControlBox.MenuBox,
            this.superTabControl1.ControlBox.CloseBox});
            this.superTabControl1.ControlBox.Visible = false;
            this.superTabControl1.Controls.Add(this.superTabControlPanel1);
            this.superTabControl1.Controls.Add(this.superTabControlPanel4);
            this.superTabControl1.Controls.Add(this.superTabControlPanel2);
            this.superTabControl1.Controls.Add(this.superTabControlPanel3);
            this.superTabControl1.ItemPadding.Left = 6;
            this.superTabControl1.ItemPadding.Right = 4;
            this.superTabControl1.ItemPadding.Top = 4;
            this.superTabControl1.Location = new System.Drawing.Point(5, 54);
            this.superTabControl1.Name = "superTabControl1";
            this.superTabControl1.ReorderTabsEnabled = false;
            this.superTabControl1.SelectedTabFont = new System.Drawing.Font("Segoe UI", 9.75F);
            this.superTabControl1.SelectedTabIndex = 0;
            this.superTabControl1.Size = new System.Drawing.Size(766, 441);
            this.superTabControl1.TabAlignment = DevComponents.DotNetBar.eTabStripAlignment.Left;
            this.superTabControl1.TabFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.superTabControl1.TabHorizontalSpacing = 16;
            this.superTabControl1.TabIndex = 14;
            this.superTabControl1.Tabs.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem61,
            this.buttonItem63,
            this.buttonItem64,
            this.superTabItem1,
            this.superTabItem2,
            this.superTabItem3,
            this.superTabItem4,
            this.buttonItem65,
            this.buttonItem66});
            this.superTabControl1.TabStyle = DevComponents.DotNetBar.eSuperTabStyle.Office2010BackstageBlue;
            this.superTabControl1.TabVerticalSpacing = 8;
            // 
            // superTabControlPanel1
            // 
            this.superTabControlPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("superTabControlPanel1.BackgroundImage")));
            this.superTabControlPanel1.BackgroundImagePosition = DevComponents.DotNetBar.eStyleBackgroundImage.BottomRight;
            this.superTabControlPanel1.Controls.Add(this.panelEx2);
            this.superTabControlPanel1.Controls.Add(this.panelEx1);
            this.superTabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanel1.Location = new System.Drawing.Point(95, 0);
            this.superTabControlPanel1.Name = "superTabControlPanel1";
            this.superTabControlPanel1.Size = new System.Drawing.Size(671, 441);
            this.superTabControlPanel1.TabIndex = 1;
            this.superTabControlPanel1.TabItem = this.superTabItem1;
            // 
            // panelEx2
            // 
            this.panelEx2.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx2.Controls.Add(this.recentPlacesItemsPanel);
            this.panelEx2.Controls.Add(this.labelX2);
            this.panelEx2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx2.Location = new System.Drawing.Point(314, 0);
            this.panelEx2.Name = "panelEx2";
            this.panelEx2.Padding = new System.Windows.Forms.Padding(12);
            this.panelEx2.Size = new System.Drawing.Size(357, 441);
            this.panelEx2.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx2.Style.BackColor1.Color = System.Drawing.Color.Transparent;
            this.panelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx2.Style.BorderSide = DevComponents.DotNetBar.eBorderSide.Right;
            this.panelEx2.Style.GradientAngle = 90;
            this.panelEx2.TabIndex = 1;
            this.panelEx2.Text = "panelEx2";
            // 
            // recentPlacesItemsPanel
            // 
            this.recentPlacesItemsPanel.AutoScroll = true;
            // 
            // 
            // 
            this.recentPlacesItemsPanel.BackgroundStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.recentPlacesItemsPanel.BackgroundStyle.Class = "";
            this.recentPlacesItemsPanel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.recentPlacesItemsPanel.ContainerControlProcessDialogKey = true;
            this.recentPlacesItemsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.recentPlacesItemsPanel.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.recentPlacesItemsPanel.Location = new System.Drawing.Point(12, 35);
            this.recentPlacesItemsPanel.Name = "recentPlacesItemsPanel";
            this.recentPlacesItemsPanel.Size = new System.Drawing.Size(333, 394);
            this.recentPlacesItemsPanel.TabIndex = 2;
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Dash;
            this.labelX2.BackgroundStyle.BorderBottomColor = System.Drawing.Color.Gray;
            this.labelX2.BackgroundStyle.BorderBottomWidth = 1;
            this.labelX2.BackgroundStyle.Class = "";
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelX2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.ForeColor = System.Drawing.Color.DimGray;
            this.labelX2.Location = new System.Drawing.Point(12, 12);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(333, 23);
            this.labelX2.TabIndex = 0;
            this.labelX2.Text = "Recent Places";
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.recentDocsItemPane);
            this.panelEx1.Controls.Add(this.labelX1);
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Padding = new System.Windows.Forms.Padding(12);
            this.panelEx1.Size = new System.Drawing.Size(314, 441);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.Color = System.Drawing.Color.Transparent;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderSide = DevComponents.DotNetBar.eBorderSide.Right;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 0;
            this.panelEx1.Text = "panelEx1";
            // 
            // recentDocsItemPane
            // 
            this.recentDocsItemPane.AutoScroll = true;
            // 
            // 
            // 
            this.recentDocsItemPane.BackgroundStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.recentDocsItemPane.BackgroundStyle.Class = "";
            this.recentDocsItemPane.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.recentDocsItemPane.ContainerControlProcessDialogKey = true;
            this.recentDocsItemPane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.recentDocsItemPane.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.recentDocsItemPane.Location = new System.Drawing.Point(12, 35);
            this.recentDocsItemPane.Name = "recentDocsItemPane";
            this.recentDocsItemPane.Size = new System.Drawing.Size(290, 394);
            this.recentDocsItemPane.TabIndex = 1;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Dash;
            this.labelX1.BackgroundStyle.BorderBottomColor = System.Drawing.Color.Gray;
            this.labelX1.BackgroundStyle.BorderBottomWidth = 1;
            this.labelX1.BackgroundStyle.Class = "";
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelX1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.ForeColor = System.Drawing.Color.DimGray;
            this.labelX1.Location = new System.Drawing.Point(12, 12);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(290, 23);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Recent Documents";
            // 
            // superTabItem1
            // 
            this.superTabItem1.AttachedControl = this.superTabControlPanel1;
            this.superTabItem1.GlobalItem = false;
            this.superTabItem1.KeyTips = "R";
            this.superTabItem1.Name = "superTabItem1";
            this.superTabItem1.Text = "Recent";
            // 
            // superTabControlPanel4
            // 
            this.superTabControlPanel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("superTabControlPanel4.BackgroundImage")));
            this.superTabControlPanel4.BackgroundImagePosition = DevComponents.DotNetBar.eStyleBackgroundImage.BottomRight;
            this.superTabControlPanel4.Controls.Add(this.itemPanel2);
            this.superTabControlPanel4.Controls.Add(this.labelX6);
            this.superTabControlPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanel4.Location = new System.Drawing.Point(95, 0);
            this.superTabControlPanel4.Name = "superTabControlPanel4";
            this.superTabControlPanel4.Padding = new System.Windows.Forms.Padding(12);
            this.superTabControlPanel4.Size = new System.Drawing.Size(671, 441);
            this.superTabControlPanel4.TabIndex = 4;
            this.superTabControlPanel4.TabItem = this.superTabItem4;
            // 
            // itemPanel2
            // 
            this.itemPanel2.AutoScroll = true;
            this.itemPanel2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.itemPanel2.BackgroundStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.itemPanel2.BackgroundStyle.Class = "";
            this.itemPanel2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemPanel2.ContainerControlProcessDialogKey = true;
            this.itemPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemPanel2.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem77,
            this.buttonItem73,
            this.buttonItem74,
            this.buttonItem75,
            this.buttonItem76});
            this.itemPanel2.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.itemPanel2.Location = new System.Drawing.Point(12, 35);
            this.itemPanel2.Name = "itemPanel2";
            this.itemPanel2.Size = new System.Drawing.Size(647, 394);
            this.itemPanel2.TabIndex = 3;
            // 
            // buttonItem77
            // 
            this.buttonItem77.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem77.Command = this.AppCommandGoToUrl;
            this.buttonItem77.CommandParameter = "http://www.devcomponents.com/kb/questions.php?questionid=127";
            this.buttonItem77.ForeColor = System.Drawing.Color.Black;
            this.buttonItem77.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem77.Image")));
            this.buttonItem77.Name = "buttonItem77";
            this.buttonItem77.Text = "Backstage<br/>\r\n<font color=\"Gray\">How to build Office 2010 style Backstage with " +
                "DotNetBar</font>";
            // 
            // AppCommandGoToUrl
            // 
            this.AppCommandGoToUrl.Name = "AppCommandGoToUrl";
            this.AppCommandGoToUrl.Executed += new System.EventHandler(this.AppCommandGoToUrl_Executed);
            // 
            // buttonItem73
            // 
            this.buttonItem73.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem73.Command = this.AppCommandGoToUrl;
            this.buttonItem73.CommandParameter = "http://www.devcomponents.com/kb/";
            this.buttonItem73.ForeColor = System.Drawing.Color.Black;
            this.buttonItem73.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem73.Image")));
            this.buttonItem73.Name = "buttonItem73";
            this.buttonItem73.Text = "DotNetBar Knowledge Base<br/>\r\n<font color=\"Gray\">Browse our online Knowledge Bas" +
                "e.</font>";
            // 
            // buttonItem74
            // 
            this.buttonItem74.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem74.Command = this.AppCommandGoToUrl;
            this.buttonItem74.CommandParameter = "http://www.devcomponents.com/dotnetbar/movies.aspx";
            this.buttonItem74.ForeColor = System.Drawing.Color.Black;
            this.buttonItem74.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem74.Image")));
            this.buttonItem74.Name = "buttonItem74";
            this.buttonItem74.Text = "Movie Tutorials<br/>\r\n<font color=\"Gray\">Watch getting started online movie tutor" +
                "ials</font>";
            // 
            // buttonItem75
            // 
            this.buttonItem75.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem75.Command = this.AppCommandGoToUrl;
            this.buttonItem75.CommandParameter = "http://www.devcomponents.com/support.aspx";
            this.buttonItem75.ForeColor = System.Drawing.Color.Black;
            this.buttonItem75.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem75.Image")));
            this.buttonItem75.Name = "buttonItem75";
            this.buttonItem75.Text = "Contact Us<br/>\r\n<font color=\"Gray\">Let us know if you need help or how we can ma" +
                "ke DotNetBar even better.</font>";
            // 
            // buttonItem76
            // 
            this.buttonItem76.BeginGroup = true;
            this.buttonItem76.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem76.Command = this.AppCommandGoToUrl;
            this.buttonItem76.CommandParameter = "http://www.devcomponents.com/dotnetbar/applicationgallery/";
            this.buttonItem76.ForeColor = System.Drawing.Color.Black;
            this.buttonItem76.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem76.Image")));
            this.buttonItem76.Name = "buttonItem76";
            this.buttonItem76.Text = "Application Gallery<br/>\r\n<font color=\"Gray\">See how other developers are using D" +
                "otNetBar in our application gallery</font>";
            // 
            // labelX6
            // 
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Dash;
            this.labelX6.BackgroundStyle.BorderBottomColor = System.Drawing.Color.Gray;
            this.labelX6.BackgroundStyle.BorderBottomWidth = 1;
            this.labelX6.BackgroundStyle.Class = "";
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelX6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX6.ForeColor = System.Drawing.Color.DimGray;
            this.labelX6.Location = new System.Drawing.Point(12, 12);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(647, 23);
            this.labelX6.TabIndex = 2;
            this.labelX6.Text = "Support";
            // 
            // superTabItem4
            // 
            this.superTabItem4.AttachedControl = this.superTabControlPanel4;
            this.superTabItem4.GlobalItem = false;
            this.superTabItem4.KeyTips = "H";
            this.superTabItem4.Name = "superTabItem4";
            this.superTabItem4.Text = "Help";
            // 
            // superTabControlPanel2
            // 
            this.superTabControlPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("superTabControlPanel2.BackgroundImage")));
            this.superTabControlPanel2.BackgroundImagePosition = DevComponents.DotNetBar.eStyleBackgroundImage.BottomRight;
            this.superTabControlPanel2.Controls.Add(this.itemPanel1);
            this.superTabControlPanel2.Controls.Add(this.labelX3);
            this.superTabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanel2.Location = new System.Drawing.Point(95, 0);
            this.superTabControlPanel2.Name = "superTabControlPanel2";
            this.superTabControlPanel2.Padding = new System.Windows.Forms.Padding(12);
            this.superTabControlPanel2.Size = new System.Drawing.Size(671, 441);
            this.superTabControlPanel2.TabIndex = 2;
            this.superTabControlPanel2.TabItem = this.superTabItem2;
            // 
            // itemPanel1
            // 
            this.itemPanel1.AutoScroll = true;
            this.itemPanel1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.itemPanel1.BackgroundStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.itemPanel1.BackgroundStyle.Class = "";
            this.itemPanel1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemPanel1.ContainerControlProcessDialogKey = true;
            this.itemPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemPanel1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem67,
            this.buttonItem68,
            this.buttonItem69,
            this.buttonItem70,
            this.buttonItem71,
            this.buttonItem72});
            this.itemPanel1.Location = new System.Drawing.Point(12, 35);
            this.itemPanel1.MultiLine = true;
            this.itemPanel1.Name = "itemPanel1";
            this.itemPanel1.Size = new System.Drawing.Size(647, 394);
            this.itemPanel1.TabIndex = 3;
            // 
            // buttonItem67
            // 
            this.buttonItem67.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem67.Command = this.AppCommandNew;
            this.buttonItem67.ForeColor = System.Drawing.Color.Black;
            this.buttonItem67.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem67.Image")));
            this.buttonItem67.ImagePaddingVertical = 12;
            this.buttonItem67.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItem67.Name = "buttonItem67";
            this.buttonItem67.Text = "<span align=\"center\">Blank<br/>document</span>";
            // 
            // AppCommandNew
            // 
            this.AppCommandNew.Name = "AppCommandNew";
            this.AppCommandNew.Executed += new System.EventHandler(this.AppCommandNew_Executed);
            // 
            // buttonItem68
            // 
            this.buttonItem68.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem68.ForeColor = System.Drawing.Color.Black;
            this.buttonItem68.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem68.Image")));
            this.buttonItem68.ImagePaddingVertical = 12;
            this.buttonItem68.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItem68.Name = "buttonItem68";
            this.buttonItem68.Text = "Blog post";
            // 
            // buttonItem69
            // 
            this.buttonItem69.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem69.ForeColor = System.Drawing.Color.Black;
            this.buttonItem69.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem69.Image")));
            this.buttonItem69.ImagePaddingHorizontal = 12;
            this.buttonItem69.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItem69.Name = "buttonItem69";
            this.buttonItem69.Text = "<span align=\"center\">Recent<br/>templates</span>";
            // 
            // buttonItem70
            // 
            this.buttonItem70.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem70.ForeColor = System.Drawing.Color.Black;
            this.buttonItem70.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem70.Image")));
            this.buttonItem70.ImagePaddingHorizontal = 12;
            this.buttonItem70.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItem70.Name = "buttonItem70";
            this.buttonItem70.Text = "<span align=\"center\">Sample<br/>templates</span>";
            // 
            // buttonItem71
            // 
            this.buttonItem71.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem71.ForeColor = System.Drawing.Color.Black;
            this.buttonItem71.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem71.Image")));
            this.buttonItem71.ImagePaddingHorizontal = 12;
            this.buttonItem71.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItem71.Name = "buttonItem71";
            this.buttonItem71.Text = "My templates";
            // 
            // buttonItem72
            // 
            this.buttonItem72.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem72.ForeColor = System.Drawing.Color.Black;
            this.buttonItem72.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem72.Image")));
            this.buttonItem72.ImagePaddingHorizontal = 12;
            this.buttonItem72.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItem72.Name = "buttonItem72";
            this.buttonItem72.Text = "<span align=\"center\">New from<br/>existing</span>";
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Dash;
            this.labelX3.BackgroundStyle.BorderBottomColor = System.Drawing.Color.Gray;
            this.labelX3.BackgroundStyle.BorderBottomWidth = 1;
            this.labelX3.BackgroundStyle.Class = "";
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelX3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX3.ForeColor = System.Drawing.Color.DimGray;
            this.labelX3.Location = new System.Drawing.Point(12, 12);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(647, 23);
            this.labelX3.TabIndex = 1;
            this.labelX3.Text = "Available Templates";
            // 
            // superTabItem2
            // 
            this.superTabItem2.AttachedControl = this.superTabControlPanel2;
            this.superTabItem2.GlobalItem = false;
            this.superTabItem2.KeyTips = "N";
            this.superTabItem2.Name = "superTabItem2";
            this.superTabItem2.Text = "New";
            // 
            // superTabControlPanel3
            // 
            this.superTabControlPanel3.BackgroundImagePosition = DevComponents.DotNetBar.eStyleBackgroundImage.BottomRight;
            this.superTabControlPanel3.Controls.Add(this.panelEx3);
            this.superTabControlPanel3.Controls.Add(this.labelX5);
            this.superTabControlPanel3.Controls.Add(this.integerInput1);
            this.superTabControlPanel3.Controls.Add(this.labelX4);
            this.superTabControlPanel3.Controls.Add(this.buttonX1);
            this.superTabControlPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanel3.Location = new System.Drawing.Point(95, 0);
            this.superTabControlPanel3.Name = "superTabControlPanel3";
            this.superTabControlPanel3.Size = new System.Drawing.Size(671, 441);
            this.superTabControlPanel3.TabIndex = 3;
            this.superTabControlPanel3.TabItem = this.superTabItem3;
            // 
            // panelEx3
            // 
            this.panelEx3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panelEx3.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelEx3.Location = new System.Drawing.Point(292, 4);
            this.panelEx3.Name = "panelEx3";
            this.panelEx3.Size = new System.Drawing.Size(376, 434);
            this.panelEx3.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx3.Style.BackColor1.Color = System.Drawing.Color.White;
            this.panelEx3.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx3.Style.BorderColor.Color = System.Drawing.Color.Silver;
            this.panelEx3.Style.BorderSide = DevComponents.DotNetBar.eBorderSide.Left;
            this.panelEx3.Style.ForeColor.Color = System.Drawing.Color.Gray;
            this.panelEx3.Style.GradientAngle = 90;
            this.panelEx3.TabIndex = 5;
            this.panelEx3.Text = "Print Preview Goes Here...";
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.Class = "";
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.ForeColor = System.Drawing.Color.Black;
            this.labelX5.Location = new System.Drawing.Point(143, 54);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(48, 19);
            this.labelX5.TabIndex = 4;
            this.labelX5.Text = "Copies:";
            // 
            // integerInput1
            // 
            // 
            // 
            // 
            this.integerInput1.BackgroundStyle.Class = "DateTimeInputBackground";
            this.integerInput1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.integerInput1.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.integerInput1.Location = new System.Drawing.Point(198, 53);
            this.integerInput1.Name = "integerInput1";
            this.integerInput1.ShowUpDown = true;
            this.integerInput1.Size = new System.Drawing.Size(66, 22);
            this.integerInput1.TabIndex = 3;
            this.integerInput1.Value = 1;
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Dash;
            this.labelX4.BackgroundStyle.BorderBottomColor = System.Drawing.Color.Gray;
            this.labelX4.BackgroundStyle.BorderBottomWidth = 1;
            this.labelX4.BackgroundStyle.Class = "";
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX4.ForeColor = System.Drawing.Color.DimGray;
            this.labelX4.Location = new System.Drawing.Point(144, 16);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(120, 23);
            this.labelX4.TabIndex = 2;
            this.labelX4.Text = "Print";
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.buttonX1.Image = ((System.Drawing.Image)(resources.GetObject("buttonX1.Image")));
            this.buttonX1.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonX1.Location = new System.Drawing.Point(21, 21);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(109, 101);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.TabIndex = 0;
            this.buttonX1.Text = "Print";
            // 
            // superTabItem3
            // 
            this.superTabItem3.AttachedControl = this.superTabControlPanel3;
            this.superTabItem3.GlobalItem = false;
            this.superTabItem3.KeyTips = "P";
            this.superTabItem3.Name = "superTabItem3";
            this.superTabItem3.Text = "Print";
            // 
            // buttonItem61
            // 
            this.buttonItem61.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem61.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.buttonItem61.Command = this.AppCommandSave;
            this.buttonItem61.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem61.Image")));
            this.buttonItem61.ImagePaddingHorizontal = 18;
            this.buttonItem61.ImagePaddingVertical = 10;
            this.buttonItem61.KeyTips = "S";
            this.buttonItem61.Name = "buttonItem61";
            this.buttonItem61.Stretch = true;
            this.buttonItem61.Text = "Save";
            // 
            // AppCommandSave
            // 
            this.AppCommandSave.Name = "AppCommandSave";
            this.AppCommandSave.Executed += new System.EventHandler(this.AppCommandSave_Executed);
            // 
            // buttonItem63
            // 
            this.buttonItem63.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem63.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.buttonItem63.Command = this.AppCommandOpen;
            this.buttonItem63.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem63.Image")));
            this.buttonItem63.ImagePaddingHorizontal = 18;
            this.buttonItem63.ImagePaddingVertical = 10;
            this.buttonItem63.KeyTips = "O";
            this.buttonItem63.Name = "buttonItem63";
            this.buttonItem63.Stretch = true;
            this.buttonItem63.Text = "Open";
            // 
            // AppCommandOpen
            // 
            this.AppCommandOpen.Name = "AppCommandOpen";
            this.AppCommandOpen.Executed += new System.EventHandler(this.AppCommandOpen_Executed);
            // 
            // buttonItem64
            // 
            this.buttonItem64.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem64.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.buttonItem64.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem64.Image")));
            this.buttonItem64.ImagePaddingHorizontal = 18;
            this.buttonItem64.ImagePaddingVertical = 10;
            this.buttonItem64.KeyTips = "C";
            this.buttonItem64.Name = "buttonItem64";
            this.buttonItem64.Stretch = true;
            this.buttonItem64.Text = "Close";
            // 
            // buttonItem65
            // 
            this.buttonItem65.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem65.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.buttonItem65.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem65.Image")));
            this.buttonItem65.ImagePaddingHorizontal = 18;
            this.buttonItem65.ImagePaddingVertical = 10;
            this.buttonItem65.KeyTips = "T";
            this.buttonItem65.Name = "buttonItem65";
            this.buttonItem65.Stretch = true;
            this.buttonItem65.Text = "Options";
            // 
            // buttonItem66
            // 
            this.buttonItem66.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem66.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.buttonItem66.Command = this.AppCommandExit;
            this.buttonItem66.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem66.Image")));
            this.buttonItem66.ImagePaddingHorizontal = 18;
            this.buttonItem66.ImagePaddingVertical = 10;
            this.buttonItem66.KeyTips = "X";
            this.buttonItem66.Name = "buttonItem66";
            this.buttonItem66.Stretch = true;
            this.buttonItem66.Text = "Exit";
            // 
            // AppCommandExit
            // 
            this.AppCommandExit.Name = "AppCommandExit";
            this.AppCommandExit.Executed += new System.EventHandler(this.AppCommandExit_Executed);
            // 
            // menuFileContainer
            // 
            // 
            // 
            // 
            this.menuFileContainer.BackgroundStyle.Class = "RibbonFileMenuContainer";
            this.menuFileContainer.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.menuFileContainer.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.menuFileContainer.Name = "menuFileContainer";
            this.menuFileContainer.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.menuFileTwoColumnContainer,
            this.menuFileBottomContainer});
            // 
            // menuFileTwoColumnContainer
            // 
            // 
            // 
            // 
            this.menuFileTwoColumnContainer.BackgroundStyle.Class = "RibbonFileMenuTwoColumnContainer";
            this.menuFileTwoColumnContainer.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.menuFileTwoColumnContainer.BackgroundStyle.PaddingBottom = 2;
            this.menuFileTwoColumnContainer.BackgroundStyle.PaddingLeft = 2;
            this.menuFileTwoColumnContainer.BackgroundStyle.PaddingRight = 2;
            this.menuFileTwoColumnContainer.BackgroundStyle.PaddingTop = 2;
            this.menuFileTwoColumnContainer.ItemSpacing = 0;
            this.menuFileTwoColumnContainer.Name = "menuFileTwoColumnContainer";
            this.menuFileTwoColumnContainer.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.menuFileItems,
            this.menuFileMRU});
            // 
            // menuFileItems
            // 
            // 
            // 
            // 
            this.menuFileItems.BackgroundStyle.Class = "RibbonFileMenuColumnOneContainer";
            this.menuFileItems.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.menuFileItems.ItemSpacing = 5;
            this.menuFileItems.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.menuFileItems.MinimumSize = new System.Drawing.Size(120, 0);
            this.menuFileItems.Name = "menuFileItems";
            this.menuFileItems.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem20,
            this.buttonItem21,
            this.buttonFileSaveAs,
            this.buttonItem23,
            this.buttonItem24,
            this.buttonItem25});
            // 
            // buttonItem20
            // 
            this.buttonItem20.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem20.Command = this.AppCommandNew;
            this.buttonItem20.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem20.Image")));
            this.buttonItem20.ImageSmall = ((System.Drawing.Image)(resources.GetObject("buttonItem20.ImageSmall")));
            this.buttonItem20.Name = "buttonItem20";
            this.buttonItem20.SubItemsExpandWidth = 24;
            this.buttonItem20.Text = "&New";
            // 
            // buttonItem21
            // 
            this.buttonItem21.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem21.Command = this.AppCommandOpen;
            this.buttonItem21.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem21.Image")));
            this.buttonItem21.Name = "buttonItem21";
            this.buttonItem21.SubItemsExpandWidth = 24;
            this.buttonItem21.Text = "&Open...";
            // 
            // buttonFileSaveAs
            // 
            this.buttonFileSaveAs.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonFileSaveAs.Command = this.AppCommandSaveAs;
            this.buttonFileSaveAs.Image = ((System.Drawing.Image)(resources.GetObject("buttonFileSaveAs.Image")));
            this.buttonFileSaveAs.ImageSmall = ((System.Drawing.Image)(resources.GetObject("buttonFileSaveAs.ImageSmall")));
            this.buttonFileSaveAs.Name = "buttonFileSaveAs";
            this.buttonFileSaveAs.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.itemContainer12});
            this.buttonFileSaveAs.SubItemsExpandWidth = 24;
            this.buttonFileSaveAs.Text = "&Save As...";
            this.buttonFileSaveAs.ExpandChange += new System.EventHandler(this.buttonFileSaveAs_ExpandChange);
            // 
            // AppCommandSaveAs
            // 
            this.AppCommandSaveAs.Name = "AppCommandSaveAs";
            this.AppCommandSaveAs.Executed += new System.EventHandler(this.AppCommandSaveAs_Executed);
            // 
            // itemContainer12
            // 
            // 
            // 
            // 
            this.itemContainer12.BackgroundStyle.Class = "";
            this.itemContainer12.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer12.ItemSpacing = 4;
            this.itemContainer12.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.itemContainer12.MinimumSize = new System.Drawing.Size(210, 256);
            this.itemContainer12.Name = "itemContainer12";
            this.itemContainer12.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.labelItem1,
            this.buttonItem56,
            this.buttonItem57,
            this.buttonItem58,
            this.buttonItem59});
            // 
            // labelItem1
            // 
            this.labelItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.labelItem1.BorderSide = DevComponents.DotNetBar.eBorderSide.Bottom;
            this.labelItem1.BorderType = DevComponents.DotNetBar.eBorderType.Etched;
            this.labelItem1.Name = "labelItem1";
            this.labelItem1.PaddingBottom = 5;
            this.labelItem1.PaddingLeft = 5;
            this.labelItem1.PaddingRight = 5;
            this.labelItem1.PaddingTop = 5;
            this.labelItem1.Text = "<b>Save a copy of the document</b>";
            // 
            // buttonItem56
            // 
            this.buttonItem56.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem56.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem56.Image")));
            this.buttonItem56.Name = "buttonItem56";
            this.buttonItem56.Text = "<b>&Rich Text Document</b>\r\n<div padding=\"0,0,4,0\" width=\"170\">Save the document " +
                "in the default file format.</div>";
            // 
            // buttonItem57
            // 
            this.buttonItem57.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem57.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem57.Image")));
            this.buttonItem57.Name = "buttonItem57";
            this.buttonItem57.Text = "<b>Document &Template</b>\r\n<div padding=\"0,0,4,0\" width=\"170\">Save as a template " +
                "that can be used to format future documents.</div>";
            // 
            // buttonItem58
            // 
            this.buttonItem58.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem58.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem58.Image")));
            this.buttonItem58.Name = "buttonItem58";
            this.buttonItem58.Text = "<b>&Find add-ins for other formats</b>\r\n<div padding=\"0,0,4,0\" width=\"180\">Learn " +
                "about add-ins to save to other formats such as PDF or XPS.</div>";
            // 
            // buttonItem59
            // 
            this.buttonItem59.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem59.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem59.Image")));
            this.buttonItem59.Name = "buttonItem59";
            this.buttonItem59.Text = "<b>&Other Formats</b>\r\n<div padding=\"0,0,4,0\" width=\"170\">Open the Save As dialog" +
                " box to select from all possible file types.</div>";
            // 
            // buttonItem23
            // 
            this.buttonItem23.BeginGroup = true;
            this.buttonItem23.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem23.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem23.Image")));
            this.buttonItem23.Name = "buttonItem23";
            this.buttonItem23.SubItemsExpandWidth = 24;
            this.buttonItem23.Text = "S&hare...";
            // 
            // buttonItem24
            // 
            this.buttonItem24.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem24.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem24.Image")));
            this.buttonItem24.Name = "buttonItem24";
            this.buttonItem24.SubItemsExpandWidth = 24;
            this.buttonItem24.Text = "&Print...";
            // 
            // buttonItem25
            // 
            this.buttonItem25.BeginGroup = true;
            this.buttonItem25.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem25.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem25.Image")));
            this.buttonItem25.Name = "buttonItem25";
            this.buttonItem25.SubItemsExpandWidth = 24;
            this.buttonItem25.Text = "&Close";
            // 
            // menuFileMRU
            // 
            // 
            // 
            // 
            this.menuFileMRU.BackgroundStyle.Class = "RibbonFileMenuColumnTwoContainer";
            this.menuFileMRU.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.menuFileMRU.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.menuFileMRU.MinimumSize = new System.Drawing.Size(225, 0);
            this.menuFileMRU.Name = "menuFileMRU";
            this.menuFileMRU.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.labelItem8,
            this.buttonItem26,
            this.buttonItem27,
            this.buttonItem28,
            this.buttonItem29});
            // 
            // labelItem8
            // 
            this.labelItem8.BorderSide = DevComponents.DotNetBar.eBorderSide.Bottom;
            this.labelItem8.BorderType = DevComponents.DotNetBar.eBorderType.Etched;
            this.labelItem8.Name = "labelItem8";
            this.labelItem8.PaddingBottom = 2;
            this.labelItem8.PaddingTop = 2;
            this.labelItem8.Stretch = true;
            this.labelItem8.Text = "Recent Documents";
            // 
            // buttonItem26
            // 
            this.buttonItem26.Name = "buttonItem26";
            this.buttonItem26.Text = "&1. Short News 5-7.rtf";
            // 
            // buttonItem27
            // 
            this.buttonItem27.Name = "buttonItem27";
            this.buttonItem27.Text = "&2. Prospect Email.rtf";
            // 
            // buttonItem28
            // 
            this.buttonItem28.Name = "buttonItem28";
            this.buttonItem28.Text = "&3. Customer Email.rtf";
            // 
            // buttonItem29
            // 
            this.buttonItem29.Name = "buttonItem29";
            this.buttonItem29.Text = "&4. example.rtf";
            // 
            // menuFileBottomContainer
            // 
            // 
            // 
            // 
            this.menuFileBottomContainer.BackgroundStyle.Class = "RibbonFileMenuBottomContainer";
            this.menuFileBottomContainer.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.menuFileBottomContainer.HorizontalItemAlignment = DevComponents.DotNetBar.eHorizontalItemsAlignment.Right;
            this.menuFileBottomContainer.Name = "menuFileBottomContainer";
            this.menuFileBottomContainer.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonOptions,
            this.buttonExit});
            // 
            // buttonOptions
            // 
            this.buttonOptions.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonOptions.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonOptions.Image = ((System.Drawing.Image)(resources.GetObject("buttonOptions.Image")));
            this.buttonOptions.Name = "buttonOptions";
            this.buttonOptions.SubItemsExpandWidth = 24;
            this.buttonOptions.Text = "RibbonPad Opt&ions";
            // 
            // buttonExit
            // 
            this.buttonExit.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonExit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonExit.Command = this.AppCommandExit;
            this.buttonExit.Image = ((System.Drawing.Image)(resources.GetObject("buttonExit.Image")));
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.SubItemsExpandWidth = 24;
            this.buttonExit.Text = "E&xit RibbonPad";
            // 
            // ribbonTabItem1
            // 
            this.ribbonTabItem1.Checked = true;
            this.ribbonTabItem1.Name = "ribbonTabItem1";
            this.ribbonTabItem1.Panel = this.ribbonPanel1;
            this.ribbonTabItem1.Text = "&Write";
            // 
            // ribbonTabItem3
            // 
            this.ribbonTabItem3.Name = "ribbonTabItem3";
            this.ribbonTabItem3.Panel = this.ribbonPanel3;
            this.ribbonTabItem3.Text = "Page &Layout";
            // 
            // ribbonTabContext
            // 
            this.ribbonTabContext.ColorTable = DevComponents.DotNetBar.eRibbonTabColor.Orange;
            this.ribbonTabContext.Group = this.ribbonTabItemGroup1;
            this.ribbonTabContext.Name = "ribbonTabContext";
            this.ribbonTabContext.Panel = this.ribbonPanel2;
            this.ribbonTabContext.Text = "Context &Tab";
            this.ribbonTabContext.Visible = false;
            // 
            // ribbonTabItemGroup1
            // 
            this.ribbonTabItemGroup1.Color = DevComponents.DotNetBar.eRibbonTabGroupColor.Orange;
            this.ribbonTabItemGroup1.GroupTitle = "Tab Group";
            this.ribbonTabItemGroup1.Name = "ribbonTabItemGroup1";
            // 
            // 
            // 
            this.ribbonTabItemGroup1.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(158)))), ((int)(((byte)(159)))));
            this.ribbonTabItemGroup1.Style.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(225)))), ((int)(((byte)(226)))));
            this.ribbonTabItemGroup1.Style.BackColorGradientAngle = 90;
            this.ribbonTabItemGroup1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.ribbonTabItemGroup1.Style.BorderBottomWidth = 1;
            this.ribbonTabItemGroup1.Style.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(58)))), ((int)(((byte)(59)))));
            this.ribbonTabItemGroup1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.ribbonTabItemGroup1.Style.BorderLeftWidth = 1;
            this.ribbonTabItemGroup1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.ribbonTabItemGroup1.Style.BorderRightWidth = 1;
            this.ribbonTabItemGroup1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.ribbonTabItemGroup1.Style.BorderTopWidth = 1;
            this.ribbonTabItemGroup1.Style.Class = "";
            this.ribbonTabItemGroup1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonTabItemGroup1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.ribbonTabItemGroup1.Style.TextColor = System.Drawing.Color.Black;
            this.ribbonTabItemGroup1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // buttonChangeStyle
            // 
            this.buttonChangeStyle.AutoExpandOnClick = true;
            this.buttonChangeStyle.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Far;
            this.buttonChangeStyle.Name = "buttonChangeStyle";
            this.buttonChangeStyle.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonStyleOffice2010Blue,
            this.buttonStyleOffice2010Silver,
            this.buttonStyleOffice2010Black,
            this.buttonStyleVS2010,
            this.buttonItem62,
            this.buttonStyleOffice2007Blue,
            this.buttonStyleOffice2007Black,
            this.buttonStyleOffice2007Silver,
            this.buttonItem60,
            this.buttonStyleCustom});
            this.superTooltip1.SetSuperTooltip(this.buttonChangeStyle, new DevComponents.DotNetBar.SuperTooltipInfo("Change the style", "", "Change the style of all DotNetBar User Interface elements.", null, null, DevComponents.DotNetBar.eTooltipColor.Gray));
            this.buttonChangeStyle.Text = "Style";
            // 
            // buttonStyleOffice2010Blue
            // 
            this.buttonStyleOffice2010Blue.Command = this.AppCommandTheme;
            this.buttonStyleOffice2010Blue.CommandParameter = "Office2010Blue";
            this.buttonStyleOffice2010Blue.Name = "buttonStyleOffice2010Blue";
            this.buttonStyleOffice2010Blue.OptionGroup = "style";
            this.buttonStyleOffice2010Blue.Text = "Office 2010 Blue";
            // 
            // AppCommandTheme
            // 
            this.AppCommandTheme.Name = "AppCommandTheme";
            this.AppCommandTheme.Executed += new System.EventHandler(this.AppCommandTheme_Executed);
            // 
            // buttonStyleOffice2010Silver
            // 
            this.buttonStyleOffice2010Silver.Command = this.AppCommandTheme;
            this.buttonStyleOffice2010Silver.CommandParameter = "Office2010Silver";
            this.buttonStyleOffice2010Silver.Name = "buttonStyleOffice2010Silver";
            this.buttonStyleOffice2010Silver.OptionGroup = "style";
            this.buttonStyleOffice2010Silver.Text = "Office 2010 <font color=\"Silver\"><b>Silver</b></font>";
            // 
            // buttonStyleOffice2010Black
            // 
            this.buttonStyleOffice2010Black.Command = this.AppCommandTheme;
            this.buttonStyleOffice2010Black.CommandParameter = "Office2010Black";
            this.buttonStyleOffice2010Black.Name = "buttonStyleOffice2010Black";
            this.buttonStyleOffice2010Black.OptionGroup = "style";
            this.buttonStyleOffice2010Black.Text = "Office 2010 Black";
            // 
            // buttonStyleVS2010
            // 
            this.buttonStyleVS2010.Checked = true;
            this.buttonStyleVS2010.Command = this.AppCommandTheme;
            this.buttonStyleVS2010.CommandParameter = "VisualStudio2010Blue";
            this.buttonStyleVS2010.Name = "buttonStyleVS2010";
            this.buttonStyleVS2010.OptionGroup = "style";
            this.buttonStyleVS2010.Text = "Visual Studio 2010";
            // 
            // buttonItem62
            // 
            this.buttonItem62.Command = this.AppCommandTheme;
            this.buttonItem62.CommandParameter = "Windows7Blue";
            this.buttonItem62.Name = "buttonItem62";
            this.buttonItem62.OptionGroup = "style";
            this.buttonItem62.Text = "Windows 7";
            // 
            // buttonStyleOffice2007Blue
            // 
            this.buttonStyleOffice2007Blue.Command = this.AppCommandTheme;
            this.buttonStyleOffice2007Blue.CommandParameter = "Office2007Blue";
            this.buttonStyleOffice2007Blue.Name = "buttonStyleOffice2007Blue";
            this.buttonStyleOffice2007Blue.OptionGroup = "style";
            this.buttonStyleOffice2007Blue.Text = "Office 2007 <font color=\"Blue\"><b>Blue</b></font>";
            // 
            // buttonStyleOffice2007Black
            // 
            this.buttonStyleOffice2007Black.Command = this.AppCommandTheme;
            this.buttonStyleOffice2007Black.CommandParameter = "Office2007Black";
            this.buttonStyleOffice2007Black.Name = "buttonStyleOffice2007Black";
            this.buttonStyleOffice2007Black.OptionGroup = "style";
            this.buttonStyleOffice2007Black.Text = "Office 2007 <font color=\"black\"><b>Black</b></font>";
            // 
            // buttonStyleOffice2007Silver
            // 
            this.buttonStyleOffice2007Silver.Command = this.AppCommandTheme;
            this.buttonStyleOffice2007Silver.CommandParameter = "Office2007Silver";
            this.buttonStyleOffice2007Silver.Name = "buttonStyleOffice2007Silver";
            this.buttonStyleOffice2007Silver.OptionGroup = "style";
            this.buttonStyleOffice2007Silver.Text = "Office 2007 <font color=\"Silver\"><b>Silver</b></font>";
            // 
            // buttonItem60
            // 
            this.buttonItem60.Command = this.AppCommandTheme;
            this.buttonItem60.CommandParameter = "Office2007VistaGlass";
            this.buttonItem60.Name = "buttonItem60";
            this.buttonItem60.OptionGroup = "style";
            this.buttonItem60.Text = "Vista Glass";
            // 
            // buttonStyleCustom
            // 
            this.buttonStyleCustom.BeginGroup = true;
            this.buttonStyleCustom.Command = this.AppCommandTheme;
            this.buttonStyleCustom.Name = "buttonStyleCustom";
            this.buttonStyleCustom.Text = "Custom scheme";
            this.buttonStyleCustom.Tooltip = "Custom color scheme is created based on currently selected color table. Try selec" +
                "ting Silver or Blue color table and then creating custom color scheme.";
            this.buttonStyleCustom.ColorPreview += new DevComponents.DotNetBar.ColorPreviewEventHandler(this.buttonStyleCustom_ColorPreview);
            this.buttonStyleCustom.SelectedColorChanged += new System.EventHandler(this.buttonStyleCustom_SelectedColorChanged);
            this.buttonStyleCustom.ExpandChange += new System.EventHandler(this.buttonStyleCustom_ExpandChange);
            // 
            // switchButtonItem1
            // 
            this.switchButtonItem1.ButtonHeight = 20;
            this.switchButtonItem1.ButtonWidth = 62;
            this.switchButtonItem1.Command = this.RibbonStateCommand;
            this.switchButtonItem1.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Far;
            this.switchButtonItem1.Margin.Bottom = 2;
            this.switchButtonItem1.Margin.Left = 4;
            this.switchButtonItem1.Name = "switchButtonItem1";
            this.switchButtonItem1.OffText = "MAX";
            this.switchButtonItem1.OnText = "MIN";
            this.switchButtonItem1.Tooltip = "Minimizes/Maximizes the Ribbon";
            // 
            // RibbonStateCommand
            // 
            this.RibbonStateCommand.Name = "RibbonStateCommand";
            this.RibbonStateCommand.Executed += new System.EventHandler(this.RibbonStateCommand_Executed);
            // 
            // buttonNew
            // 
            this.buttonNew.Command = this.AppCommandNew;
            this.buttonNew.Image = ((System.Drawing.Image)(resources.GetObject("buttonNew.Image")));
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlN);
            this.buttonNew.Text = "New Document";
            // 
            // buttonSave
            // 
            this.buttonSave.Command = this.AppCommandSave;
            this.buttonSave.Enabled = false;
            this.buttonSave.Image = ((System.Drawing.Image)(resources.GetObject("buttonSave.Image")));
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Text = "buttonItem2";
            // 
            // buttonUndo
            // 
            this.buttonUndo.Enabled = false;
            this.buttonUndo.Image = ((System.Drawing.Image)(resources.GetObject("buttonUndo.Image")));
            this.buttonUndo.Name = "buttonUndo";
            this.buttonUndo.Text = "Undo";
            // 
            // qatCustomizeItem1
            // 
            this.qatCustomizeItem1.Name = "qatCustomizeItem1";
            // 
            // superTooltip1
            // 
            this.superTooltip1.DefaultFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.superTooltip1.MinimumTooltipSize = new System.Drawing.Size(150, 50);
            // 
            // progressBarTimer
            // 
            this.progressBarTimer.Enabled = true;
            this.progressBarTimer.Interval = 800;
            this.progressBarTimer.Tick += new System.EventHandler(this.progressBarTimer_Tick);
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.VisualStudio2010Blue;
            this.styleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(163)))), ((int)(((byte)(26))))));
            // 
            // frmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(776, 500);
            this.Controls.Add(this.superTabControl1);
            this.Controls.Add(this.contextMenuBar1);
            this.Controls.Add(this.tabStrip1);
            this.Controls.Add(this.ribbonControl1);
            this.Controls.Add(this.bar1);
            this.Controls.Add(this.mdiClient1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.Text = "RibbonPad";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.MdiChildActivate += new System.EventHandler(this.MdiChildActivated);
            this.Closing += new System.ComponentModel.CancelEventHandler(this.frmMain_Closing);
            this.Move += new System.EventHandler(this.frmMain_Move);
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).EndInit();
            this.ribbonControl1.ResumeLayout(false);
            this.ribbonControl1.PerformLayout();
            this.ribbonPanel1.ResumeLayout(false);
            this.ribbonPanel2.ResumeLayout(false);
            this.ribbonPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.contextMenuBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.superTabControl1)).EndInit();
            this.superTabControl1.ResumeLayout(false);
            this.superTabControlPanel1.ResumeLayout(false);
            this.panelEx2.ResumeLayout(false);
            this.panelEx1.ResumeLayout(false);
            this.superTabControlPanel4.ResumeLayout(false);
            this.superTabControlPanel2.ResumeLayout(false);
            this.superTabControlPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.integerInput1)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		#region AppCreation
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new frmMain());
		}
		#endregion

		public void EditContextMenu()
		{
			bEditPopup.Displayed=false;
			bEditPopup.PopupMenu(Control.MousePosition);
		}

		/// <summary>
		/// Verifies current context and enables/disables menu items...
		/// </summary>
		private void EnableFileItems()
		{
			// Accessing items through the Items collection and setting the properties on them
			// will propagate certain properties to all items with the same name...
			if(this.ActiveMdiChild==null)
			{
				AppCommandSave.Enabled=false;
				AppCommandSaveAs.Enabled = false;
			}
			else
			{
				AppCommandSave.Enabled = true;
				AppCommandSaveAs.Enabled = true;
				if(this.ActiveMdiChild is frmDocument)
					((frmDocument)this.ActiveMdiChild).FormActivated();
			}
		}

		private void MdiChildActivated(object sender, System.EventArgs e)
		{
			EnableFileItems();
			UpdateTitle();
			BindDocumentCommands();
		}

		internal void SaveDocument(frmDocument doc)
		{
			if(doc.FileName=="")
			{
				if(saveFileDialog1.ShowDialog()!=DialogResult.OK)
					return;
				if(saveFileDialog1.FileName=="")
					return;
				doc.FileName=saveFileDialog1.FileName;
			}
			if(doc.FileName!="")
				doc.SaveFile();
		}

		private void UnloadPopup(object sender, System.EventArgs e)
		{
			ButtonItem item=sender as ButtonItem;
			if(item.Name=="bTabColor")
			{
				DevComponents.DotNetBar.PopupContainerControl container=item.PopupContainerControl as PopupContainerControl;
				ColorPicker clr=container.Controls[0] as ColorPicker;
				if(clr.SelectedColor!=Color.Empty)
				{
					tabStrip1.ColorScheme.TabBackground=ControlPaint.LightLight(clr.SelectedColor);
					tabStrip1.ColorScheme.TabBackground2=clr.SelectedColor;
					tabStrip1.Refresh();
				}
				// Close popup menu, since it is not closed when Popup Container is closed...
				item.Parent.Expanded=false;
			}
		}

		private void TaskPaneShowAtStartup(object sender, EventArgs e)
		{
			MessageBoxEx.Show("This item is here for demonstration purposes only and code should be added to save the state of it.");
		}

		private void dotNetBarManager1_MouseEnter(object sender, System.EventArgs e)
		{
			// Sync Status-bar with the item tooltip...
			BaseItem item=sender as BaseItem;
			if(item==null)
				return;
			labelStatus.Text=item.Tooltip;
		}

		private void dotNetBarManager1_MouseLeave(object sender, System.EventArgs e)
		{
			labelStatus.Text="";		
		}

		private void frmMain_Load(object sender, System.EventArgs e)
		{
			// Create the list of frequently used commands for the QAT Customize menu
			ribbonControl1.QatFrequentCommands.Add(buttonItem20);
			ribbonControl1.QatFrequentCommands.Add(buttonItem21);
			ribbonControl1.QatFrequentCommands.Add(buttonItem24);
			ribbonControl1.QatFrequentCommands.Add(buttonItem25);

			EnableFileItems();

			AppCommandNew.Execute();

			// Load Quick Access Toolbar layout if one is saved from last session...
			Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(@"Software\DevComponents\Ribbon");
			if(key!=null)
			{
				try
				{
					string layout = key.GetValue("RibbonPadCSLayout","").ToString();
					if(layout!="" && layout!=null)
						ribbonControl1.QatLayout = layout;
				}
				finally
				{
					key.Close();
				}
			}
			UpdateTitle();

			// Pulse the Application Button
			buttonFile.Pulse(11);
		}

		private void frmMain_Move(object sender, System.EventArgs e)
		{
			this.CloseSearch();
		}

		private void CloseSearch()
		{
			if(m_Search!=null)
			{
				m_Search.Close();
				m_Search.Dispose();
				m_Search=null;
			}
		}

		public void SearchActiveDocument(string text)
		{
			frmDocument activedocument=this.ActiveMdiChild as frmDocument;
			if (activedocument != null)
			{
				buttonFind.CommandParameter = text;
				activedocument.CommandFind.Execute(buttonFind);
			}
		}

		private void LaunchRibbonDialog(object sender, System.EventArgs e)
		{
			MessageBoxEx.Show("Start <i>Ribbon Dialog</i> with more options here...","Ribbon Demo",MessageBoxButtons.OK,MessageBoxIcon.Information);
		}

		private void buttonFind_Click(object sender, System.EventArgs e)
		{
			if(m_Search==null || m_Search.IsDisposed)
			{
				m_Search=new BalloonSearch();
				m_Search.Owner=this;
				m_Search.Show(sender as BaseItem,true);
			}
		}

		private void MdiClientControlAddRemove(object sender, ControlEventArgs e)
		{
			if(this.MdiChildren.Length>0)
			{
				if(!ribbonTabContext.Visible)
				{
					ribbonTabContext.Visible=true;
					ribbonControl1.RecalcLayout();
				}
			}
			else
			{
				if(ribbonTabContext.Visible)
				{
					if(ribbonTabContext.Checked)
						ribbonTabItem1.Checked=true;
					ribbonTabContext.Visible=false;
					ribbonControl1.RecalcLayout();
				}
			}
		}

		private void frmMain_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			// Save Quick Access Toolbar layout if it has changed...
			if(ribbonControl1.QatLayoutChanged)
			{
				Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(@"Software\DevComponents\Ribbon");
				try
				{
					key.SetValue("RibbonPadCSLayout", ribbonControl1.QatLayout);
				}
				finally
				{
					key.Close();
				}
			}
		}

		private void progressBarTimer_Tick(object sender, System.EventArgs e)
		{
			if(progressBarItem1.Value>=progressBarItem1.Maximum)
			{
				progressBarTimer.Stop();
				progressBarItem1.Value = 50;
			}
			else
				progressBarItem1.Value+=4;
		}

		private void ribbonControl1_BeforeRibbonPanelPopupClose(object sender, DevComponents.DotNetBar.RibbonPopupCloseEventArgs e)
		{
			// Don't close ribbon tab menu if Find button is clicked since it display the balloon popup
			if(e.Source == buttonFind)
				e.Cancel = true;
		}

		#region Automatic Color Scheme creation based on the selected color table
		private bool m_ColorSelected = false;
		private eStyle m_BaseStyle = eStyle.Office2010Silver;
		private void buttonStyleCustom_ExpandChange(object sender, System.EventArgs e)
		{
			if (buttonStyleCustom.Expanded)
			{
				// Remember the starting color scheme to apply if no color is selected during live-preview
				m_ColorSelected = false;
				m_BaseStyle = StyleManager.Style;
			}
			else
			{
				if (!m_ColorSelected)
				{
					StyleManager.ChangeStyle(m_BaseStyle, Color.Empty);
				}
			}
		}

		private void buttonStyleCustom_ColorPreview(object sender, DevComponents.DotNetBar.ColorPreviewEventArgs e)
		{
			StyleManager.ColorTint = e.Color;
		}

		private void buttonStyleCustom_SelectedColorChanged(object sender, System.EventArgs e)
		{
			m_ColorSelected = true; // Indicate that color was selected for buttonStyleCustom_ExpandChange method
			buttonStyleCustom.CommandParameter = buttonStyleCustom.SelectedColor;
		}
		#endregion

		private void buttonFileSaveAs_ExpandChange(object sender, System.EventArgs e)
		{
			// Position the Save As sub menu on top of the recent files box
			if(buttonFileSaveAs.Expanded)
			{
				buttonFileSaveAs.PopupLocation = menuFileMRU.DisplayRectangle.Location;
			}
		}

		/// <summary>
		/// Updates the title displayed on Ribbon using the rich text markup
		/// </summary>
		private void UpdateTitle()
		{
			string t = "";
			if(this.ActiveMdiChild!=null)
			{
				// Note the usage of SysCaptionTextExtra for as the value of color attribute.
				// It specifies the system color that changes based on selected color table.
				t+="<font color=\"SysCaptionTextExtra\">" + this.ActiveMdiChild.Text + "</font> ";
			}
			t+= "<b>RibbonPad</b>";
			t+=" <b><a name=\"tip\"><font color=\"SysCaptionTextExtra\">?</font></a></b>";
			//ribbonControl1.TitleText = t;
		}

		private void ribbonControl1_TitleTextMarkupLinkClick(object sender, DevComponents.DotNetBar.MarkupLinkClickEventArgs e)
		{
			MessageBoxEx.Show("TitleText property on Ribbon fully supports our text-markup as demonstrated here. However, try keeping things simpler in title bar, perhaps using hyperlinks is pushing it too far ;-) <br/><br/>See <b>UpdateTitle()</b> method in source for details.", "RibbonControl.TitleText property tip");
		}

        #region Commands Implementation
		private void BindDocumentCommands()
		{
			frmDocument document = this.ActiveMdiChild as frmDocument;
			if (document == null)
			{
				// Note that when Command is set to null the button will be automatically 
				// disabled if it had command associated previously
				buttonCopy.Command = null;
				buttonCut.Command = null;
				buttonPaste.Command = null;
				buttonUndo.Command = null;
				buttonAlignCenter.Command = null;
				buttonAlignLeft.Command = null;
				buttonAlignRight.Command = null;
				buttonFind.Command = null;
				comboFont.Command = null;
				buttonFontBold.Command = null;
				buttonFontItalic.Command = null;
				comboFontSize.Command = null;
				buttonFontStrike.Command = null;
				buttonFontUnderline.Command = null;
				buttonTextColor.Command = null;
				zoomSlider.Command = null;
				labelStatus.Command = null;
				bCopy.Command = null;
				bCut.Command = null;
				bPaste.Command = null;
			}
			else
			{
				buttonCopy.Command = document.CommandCopy;
				bCopy.Command = document.CommandCopy;
				buttonCut.Command = document.CommandCut;
				bCut.Command = document.CommandCut;
				buttonPaste.Command = document.CommandPaste;
				bPaste.Command = document.CommandPaste;
				buttonUndo.Command = document.CommandUndo;
				buttonAlignCenter.Command = document.CommandAlignCenter;
				buttonAlignLeft.Command = document.CommandAlignLeft;
				buttonAlignRight.Command = document.CommandAlignRight;
				buttonFind.Command = document.CommandFind;
				comboFont.Command = document.CommandFont;
				buttonFontBold.Command = document.CommandFontBold;
				buttonFontItalic.Command = document.CommandFontItalic;
				comboFontSize.Command = document.CommandFontSize;
				buttonFontStrike.Command = document.CommandFontStrike;
				buttonFontUnderline.Command = document.CommandFontUnderline;
				buttonTextColor.Command = document.CommandTextColor;
				zoomSlider.Command = document.CommandZoom;
				labelStatus.Command = document.CommandStatus;
			}
		}

		private void AppCommandNew_Executed(object sender, EventArgs e)
		{
            // Close Application Menu
            buttonFile.Expanded = false;

			frmDocument doc = new frmDocument();
			doc.Text = "New Document " + (this.MdiChildren.Length + 1);
			doc.MdiParent = this;
			doc.WindowState = FormWindowState.Maximized;
			doc.Show();
			doc.Update();
		}

		private void AppCommandOpen_Executed(object sender, EventArgs e)
		{
            // Close Application Menu
            buttonFile.Expanded = false;

			openFileDialog1.FileName = "";
			openFileDialog1.ShowDialog();
			if (openFileDialog1.FileName == "")
				return;
			frmDocument doc = new frmDocument();
			doc.Text = openFileDialog1.FileName;
			doc.MdiParent = this;
			doc.Show();
			doc.OpenFile(openFileDialog1.FileName);
		}

		private void AppCommandSave_Executed(object sender, EventArgs e)
		{
            // Close Application Menu
            buttonFile.Expanded = false;

			frmDocument doc = this.ActiveMdiChild as frmDocument;
			if (doc == null || !doc.DocumentChanged)
				return;
			SaveDocument(doc);
		}

		private void AppCommandSaveAs_Executed(object sender, EventArgs e)
		{
            // Close Application Menu
            buttonFile.Expanded = false;

			if (this.ActiveMdiChild == null)
				return;

			// Close menu popup if needed since File Dialogs can interfer with it
			if(sender is BaseItem)
				BaseItem.CollapseAll(sender as BaseItem);

			frmDocument doc = this.ActiveMdiChild as frmDocument;
			if (doc == null || !doc.DocumentChanged)
				return;
			if (doc.FileName == "")
			{
				SaveDocument(doc);
				return;
			}

			saveFileDialog1.ShowDialog();
			if (saveFileDialog1.ShowDialog() != DialogResult.OK)
				return;
			if (saveFileDialog1.FileName == "")
				return;
			doc.FileName = saveFileDialog1.FileName;
			doc.SaveFile();
		}

		private void AppCommandTheme_Executed(object sender, EventArgs e)
		{
			ICommandSource source = sender as ICommandSource;
			if (source.CommandParameter is string)
			{
				eStyle style = (eStyle)Enum.Parse(typeof(eStyle), source.CommandParameter.ToString());
				// Using StyleManager change the style and color tinting
				StyleManager.ChangeStyle(style, Color.Empty);
                if (style == eStyle.Office2007Black || style == eStyle.Office2007Blue || style == eStyle.Office2007Silver || style == eStyle.Office2007VistaGlass)
                    buttonFile.BackstageTabEnabled = false;
                else
                    buttonFile.BackstageTabEnabled = true;
			}
			else if (source.CommandParameter is Color)
			{
				StyleManager.ColorTint = (Color)source.CommandParameter;
			}
		}

		private void AppCommandExit_Executed(object sender, EventArgs e)
		{
			this.Close();
		}

        private void AppCommandGoToUrl_Executed(object sender, EventArgs e)
        {
            // Close Application Menu
            buttonFile.Expanded = false;
            ICommandSource source = sender as ICommandSource;
            if (source.CommandParameter is string)
            {
                string url = (string)source.CommandParameter;
                System.Diagnostics.Process.Start(url);
            }
            else
                MessageBoxEx.Show("This command must have CommandParameter set to the URL you want to navigate to.");
        }

        private void RibbonStateCommand_Executed(object sender, EventArgs e)
        {
            ribbonControl1.Expanded = RibbonStateCommand.Checked;
            RibbonStateCommand.Checked = !RibbonStateCommand.Checked;
        }
        #endregion

        #region Backstage Application Menu Content Setup
        private void SetupBackstageContent()
        {
            SetupRecentTab();
        }
        private void SetupRecentTab()
        {
            recentDocsItemPane.Items.Clear();
            MruItem[] mruFiles = GetMruFiles();
            foreach (MruItem item in mruFiles)
            {
                recentDocsItemPane.Items.Add(CreateMruFileView(item));
            }

            recentPlacesItemsPanel.Items.Clear();
            MruItem[] mruPlaces = GetMruPlaces();
            foreach (MruItem item in mruPlaces)
            {
                recentPlacesItemsPanel.Items.Add(CreateMruPlaceView(item));
            }
        }

        private BaseItem CreateMruPlaceView(MruItem item)
        {
            ItemDockContainer container = new ItemDockContainer();
            container.LastChildFill = true;
            // Create Pin Button
            ButtonItem pinButton = new ButtonItem();
            pinButton.ImagePaddingHorizontal = 6;
            pinButton.Image = global::Ribbonpad.Properties.Resources.Unpinned;
            container.SetDock(pinButton, eItemDock.Right); // Position pin button on right side
            container.SubItems.Add(pinButton);
            // Create button with file name and folder
            ButtonItem fileButton = new ButtonItem();
            fileButton.ForeColor = Color.Black;
            fileButton.ButtonStyle = eButtonStyle.ImageAndText;
            fileButton.ImagePosition = eImagePosition.Left;
            fileButton.Text = item.FileName + "<br/><font color=\"Gray\">" + item.Folder + "</font>";
            fileButton.Image = global::Ribbonpad.Properties.Resources.OpenExistingPlace;
            container.SubItems.Add(fileButton);

            return container;
        }

        private BaseItem CreateMruFileView(MruItem item)
        {
            ItemDockContainer container = new ItemDockContainer();
            container.LastChildFill = true;
            // Create Pin Button
            ButtonItem pinButton = new ButtonItem();
            pinButton.ImagePaddingHorizontal = 6;
            pinButton.Image = global::Ribbonpad.Properties.Resources.Unpinned;
            container.SetDock(pinButton, eItemDock.Right); // Position pin button on right side
            container.SubItems.Add(pinButton);
            // Create button with file name and folder
            ButtonItem fileButton = new ButtonItem();
            fileButton.ForeColor = Color.Black;
            fileButton.ButtonStyle = eButtonStyle.ImageAndText;
            fileButton.ImagePosition = eImagePosition.Left;
            fileButton.Text = item.FileName + "<br/><font color=\"Gray\">" + item.Folder + "</font>";
            fileButton.Image = global::Ribbonpad.Properties.Resources.Document;
            container.SubItems.Add(fileButton);

            return container;
        }

        private MruItem[] GetMruPlaces()
        {
            return new MruItem[3] {
                new MruItem("Documents",@"\\fileserver\Documents"),
                new MruItem("My Documents",@"c:\My Documents"),
                new MruItem("Transfer",@"\\droboshare\drobo\Transfer")
            };
        }
        private MruItem[] GetMruFiles()
        {
            return new MruItem[10] {
                new MruItem("Services Invoice 108.rtf",@"\\fileserver\Documents"),
                new MruItem("Services Invoice 109.rtf",@"\\fileserver\Documents"),
                new MruItem("Sales Report.rtf",@"\\fileserver\Documents"),
                new MruItem("Marketing Draft.rtf",@"c:\My Documents"),
                new MruItem("Compensation Report.rtf",@"c:\My Documents"),
                new MruItem("Jim Review.rtf",@"c:\My Documents"),
                new MruItem("Kathy Review.rtf",@"c:\My Documents"),
                new MruItem("Invoice10201.rtf",@"c:\My Documents"),
                new MruItem("Invoice10202.rtf",@"c:\My Documents"),
                new MruItem("Invoice10203.rtf",@"c:\My Documents")
            };
        }

        private class MruItem
        {
            public MruItem(string fileName, string folder)
            {
                FileName = fileName;
                Folder = folder;
            }
            public string FileName;
            public string Folder;
        }
        #endregion
        
	}
}

