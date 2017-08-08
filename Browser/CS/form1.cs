using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using DevComponents.DotNetBar;

namespace Browser
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.ComponentModel.IContainer components;
		private bool m_RecordRecentlyUsed=false;
		private AxSHDocVw.AxWebBrowser axWebBrowser1;
		private DevComponents.DotNetBar.DotNetBarManager dotNetBarManager1;
		private DevComponents.DotNetBar.DockSite barLeftDockSite;
		private DevComponents.DotNetBar.DockSite barRightDockSite;
		private DevComponents.DotNetBar.DockSite barTopDockSite;
		private DevComponents.DotNetBar.DockSite barBottomDockSite;
		private DevComponents.DotNetBar.DockSite dockSite1;
		private DevComponents.DotNetBar.DockSite dockSite2;
		private DevComponents.DotNetBar.DockSite dockSite3;
		private DevComponents.DotNetBar.DockSite dockSite4;
		private DevComponents.DotNetBar.Bar barMenu;
		private DevComponents.DotNetBar.ButtonItem bFile;
		private DevComponents.DotNetBar.ButtonItem bOpen;
		private DevComponents.DotNetBar.ButtonItem bPrint;
		private DevComponents.DotNetBar.ButtonItem bExit;
		private DevComponents.DotNetBar.ButtonItem bFavorites;
		private DevComponents.DotNetBar.ButtonItem bAddToFavorites;
		private DevComponents.DotNetBar.Bar bar3;
		private DevComponents.DotNetBar.ButtonItem bBack;
		private DevComponents.DotNetBar.ButtonItem bForward;
		private DevComponents.DotNetBar.ButtonItem bStop;
		private DevComponents.DotNetBar.ButtonItem bRefresh;
		private DevComponents.DotNetBar.ButtonItem bSearch;
		private DevComponents.DotNetBar.ButtonItem bHome;
		private DevComponents.DotNetBar.ButtonItem buttonItem1;
		private DevComponents.DotNetBar.ButtonItem buttonItem2;
		private DevComponents.DotNetBar.Bar barLocation;
		private DevComponents.DotNetBar.ComboBoxItem bAddress;
		private DevComponents.DotNetBar.ButtonItem bGo;
		private ButtonItem m_FavoriteContext=null;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
			object o=null;
			axWebBrowser1.Navigate("http://www.devcomponents.com/dotnetbar",ref o,ref o,ref o, ref o);
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form1));
			this.axWebBrowser1 = new AxSHDocVw.AxWebBrowser();
			this.dotNetBarManager1 = new DevComponents.DotNetBar.DotNetBarManager(this.components);
			this.barBottomDockSite = new DevComponents.DotNetBar.DockSite();
			this.barLeftDockSite = new DevComponents.DotNetBar.DockSite();
			this.barRightDockSite = new DevComponents.DotNetBar.DockSite();
			this.dockSite4 = new DevComponents.DotNetBar.DockSite();
			this.dockSite1 = new DevComponents.DotNetBar.DockSite();
			this.dockSite2 = new DevComponents.DotNetBar.DockSite();
			this.dockSite3 = new DevComponents.DotNetBar.DockSite();
			this.barMenu = new DevComponents.DotNetBar.Bar();
			this.bFile = new DevComponents.DotNetBar.ButtonItem();
			this.bOpen = new DevComponents.DotNetBar.ButtonItem();
			this.bPrint = new DevComponents.DotNetBar.ButtonItem();
			this.bExit = new DevComponents.DotNetBar.ButtonItem();
			this.bFavorites = new DevComponents.DotNetBar.ButtonItem();
			this.bAddToFavorites = new DevComponents.DotNetBar.ButtonItem();
			this.bar3 = new DevComponents.DotNetBar.Bar();
			this.bBack = new DevComponents.DotNetBar.ButtonItem();
			this.bForward = new DevComponents.DotNetBar.ButtonItem();
			this.bStop = new DevComponents.DotNetBar.ButtonItem();
			this.bRefresh = new DevComponents.DotNetBar.ButtonItem();
			this.bSearch = new DevComponents.DotNetBar.ButtonItem();
			this.bHome = new DevComponents.DotNetBar.ButtonItem();
			this.buttonItem1 = new DevComponents.DotNetBar.ButtonItem();
			this.buttonItem2 = new DevComponents.DotNetBar.ButtonItem();
			this.barLocation = new DevComponents.DotNetBar.Bar();
			this.bAddress = new DevComponents.DotNetBar.ComboBoxItem();
			this.bGo = new DevComponents.DotNetBar.ButtonItem();
			this.barTopDockSite = new DevComponents.DotNetBar.DockSite();
			((System.ComponentModel.ISupportInitialize)(this.axWebBrowser1)).BeginInit();
			this.dockSite3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.barMenu)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bar3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.barLocation)).BeginInit();
			this.SuspendLayout();
			// 
			// axWebBrowser1
			// 
			this.axWebBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.axWebBrowser1.Enabled = true;
			this.axWebBrowser1.Location = new System.Drawing.Point(0, 87);
			this.axWebBrowser1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWebBrowser1.OcxState")));
			this.axWebBrowser1.Size = new System.Drawing.Size(472, 243);
			this.axWebBrowser1.TabIndex = 4;
			this.axWebBrowser1.NavigateError += new AxSHDocVw.DWebBrowserEvents2_NavigateErrorEventHandler(this.WebNavigateError);
			this.axWebBrowser1.DocumentComplete += new AxSHDocVw.DWebBrowserEvents2_DocumentCompleteEventHandler(this.WebDocumentComplete);
			// 
			// dotNetBarManager1
			// 
			this.dotNetBarManager1.BottomDockSite = this.barBottomDockSite;
			this.dotNetBarManager1.DefinitionName = "";
			this.dotNetBarManager1.LeftDockSite = this.barLeftDockSite;
			this.dotNetBarManager1.ParentForm = this;
			this.dotNetBarManager1.RightDockSite = this.barRightDockSite;
			this.dotNetBarManager1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
			this.dotNetBarManager1.ToolbarBottomDockSite = this.dockSite4;
			this.dotNetBarManager1.ToolbarLeftDockSite = this.dockSite1;
			this.dotNetBarManager1.ToolbarRightDockSite = this.dockSite2;
			this.dotNetBarManager1.ToolbarTopDockSite = this.dockSite3;
			this.dotNetBarManager1.TopDockSite = this.barTopDockSite;
			this.dotNetBarManager1.ItemClick += new System.EventHandler(this.BarItemClick);
			this.dotNetBarManager1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ItemMouseDown);
			// 
			// barBottomDockSite
			// 
			this.barBottomDockSite.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
			this.barBottomDockSite.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.barBottomDockSite.DocumentDockContainer = new DevComponents.DotNetBar.DocumentDockContainer();
			this.barBottomDockSite.Location = new System.Drawing.Point(0, 330);
			this.barBottomDockSite.Name = "barBottomDockSite";
			this.barBottomDockSite.Size = new System.Drawing.Size(472, 0);
			this.barBottomDockSite.TabIndex = 8;
			this.barBottomDockSite.TabStop = false;
			// 
			// barLeftDockSite
			// 
			this.barLeftDockSite.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
			this.barLeftDockSite.Dock = System.Windows.Forms.DockStyle.Left;
			this.barLeftDockSite.DocumentDockContainer = new DevComponents.DotNetBar.DocumentDockContainer();
			this.barLeftDockSite.Location = new System.Drawing.Point(0, 87);
			this.barLeftDockSite.Name = "barLeftDockSite";
			this.barLeftDockSite.Size = new System.Drawing.Size(0, 243);
			this.barLeftDockSite.TabIndex = 5;
			this.barLeftDockSite.TabStop = false;
			// 
			// barRightDockSite
			// 
			this.barRightDockSite.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
			this.barRightDockSite.Dock = System.Windows.Forms.DockStyle.Right;
			this.barRightDockSite.DocumentDockContainer = new DevComponents.DotNetBar.DocumentDockContainer();
			this.barRightDockSite.Location = new System.Drawing.Point(472, 87);
			this.barRightDockSite.Name = "barRightDockSite";
			this.barRightDockSite.Size = new System.Drawing.Size(0, 243);
			this.barRightDockSite.TabIndex = 6;
			this.barRightDockSite.TabStop = false;
			// 
			// dockSite4
			// 
			this.dockSite4.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
			this.dockSite4.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.dockSite4.Location = new System.Drawing.Point(0, 330);
			this.dockSite4.Name = "dockSite4";
			this.dockSite4.Size = new System.Drawing.Size(472, 0);
			this.dockSite4.TabIndex = 12;
			this.dockSite4.TabStop = false;
			// 
			// dockSite1
			// 
			this.dockSite1.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
			this.dockSite1.Dock = System.Windows.Forms.DockStyle.Left;
			this.dockSite1.Location = new System.Drawing.Point(0, 87);
			this.dockSite1.Name = "dockSite1";
			this.dockSite1.Size = new System.Drawing.Size(0, 243);
			this.dockSite1.TabIndex = 9;
			this.dockSite1.TabStop = false;
			// 
			// dockSite2
			// 
			this.dockSite2.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
			this.dockSite2.Dock = System.Windows.Forms.DockStyle.Right;
			this.dockSite2.Location = new System.Drawing.Point(472, 87);
			this.dockSite2.Name = "dockSite2";
			this.dockSite2.Size = new System.Drawing.Size(0, 243);
			this.dockSite2.TabIndex = 10;
			this.dockSite2.TabStop = false;
			// 
			// dockSite3
			// 
			this.dockSite3.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
			this.dockSite3.Controls.AddRange(new System.Windows.Forms.Control[] {
																					this.barMenu,
																					this.bar3,
																					this.barLocation});
			this.dockSite3.Dock = System.Windows.Forms.DockStyle.Top;
			this.dockSite3.Name = "dockSite3";
			this.dockSite3.Size = new System.Drawing.Size(472, 87);
			this.dockSite3.TabIndex = 11;
			this.dockSite3.TabStop = false;
			// 
			// barMenu
			// 
			this.barMenu.AccessibleDescription = "DotNetBar Bar (barMenu)";
			this.barMenu.AccessibleName = "DotNetBar Bar";
			this.barMenu.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
			this.barMenu.DockSide = DevComponents.DotNetBar.eDockSide.Top;
			this.barMenu.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
																				   this.bFile,
																				   this.bFavorites});
			this.barMenu.MenuBar = true;
			this.barMenu.Name = "barMenu";
			this.barMenu.Size = new System.Drawing.Size(472, 24);
			this.barMenu.Stretch = true;
			this.barMenu.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
			this.barMenu.TabIndex = 0;
			this.barMenu.TabStop = false;
			this.barMenu.Text = "Main Menu";
			// 
			// bFile
			// 
			this.bFile.GlobalName = "bFile";
			this.bFile.Name = "bFile";
			this.bFile.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
																					this.bOpen,
																					this.bPrint,
																					this.bExit});
			this.bFile.Text = "&File";
			// 
			// bOpen
			// 
			this.bOpen.GlobalName = "bOpen";
			this.bOpen.Name = "bOpen";
			this.bOpen.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlO);
			this.bOpen.Text = "&Open...";
			// 
			// bPrint
			// 
			this.bPrint.BeginGroup = true;
			this.bPrint.GlobalName = "bPrint";
			this.bPrint.Name = "bPrint";
			this.bPrint.Text = "&Print";
			// 
			// bExit
			// 
			this.bExit.BeginGroup = true;
			this.bExit.GlobalName = "bExit";
			this.bExit.Name = "bExit";
			this.bExit.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlX);
			this.bExit.Text = "E&xit";
			// 
			// bFavorites
			// 
			this.bFavorites.GlobalName = "bFavorites";
			this.bFavorites.Name = "bFavorites";
			this.bFavorites.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
																						 this.bAddToFavorites});
			this.bFavorites.Text = "F&avorites";
			// 
			// bAddToFavorites
			// 
			this.bAddToFavorites.GlobalName = "bAddToFavorites";
			this.bAddToFavorites.Name = "bAddToFavorites";
			this.bAddToFavorites.Text = "&Add to Favorites...";
			// 
			// bar3
			// 
			this.bar3.AccessibleDescription = "DotNetBar Bar (bar3)";
			this.bar3.AccessibleName = "DotNetBar Bar";
			this.bar3.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolBar;
			this.bar3.DockLine = 1;
			this.bar3.DockSide = DevComponents.DotNetBar.eDockSide.Top;
			this.bar3.GrabHandleStyle = DevComponents.DotNetBar.eGrabHandleStyle.Office2003;
			this.bar3.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
																				this.bBack,
																				this.bForward,
																				this.bStop,
																				this.bRefresh,
																				this.bSearch,
																				this.bHome,
																				this.buttonItem1,
																				this.buttonItem2});
			this.bar3.Location = new System.Drawing.Point(0, 25);
			this.bar3.Name = "bar3";
			this.bar3.Size = new System.Drawing.Size(472, 33);
			this.bar3.Stretch = true;
			this.bar3.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
			this.bar3.TabIndex = 1;
			this.bar3.TabStop = false;
			this.bar3.Text = "Navigation";
			// 
			// bBack
			// 
			this.bBack.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.bBack.GlobalName = "bBack";
			this.bBack.Image = ((System.Drawing.Bitmap)(resources.GetObject("bBack.Image")));
			this.bBack.Name = "bBack";
			this.bBack.Text = "&Back";
			// 
			// bForward
			// 
			this.bForward.GlobalName = "bForward";
			this.bForward.Image = ((System.Drawing.Bitmap)(resources.GetObject("bForward.Image")));
			this.bForward.Name = "bForward";
			this.bForward.Text = "&Forward";
			// 
			// bStop
			// 
			this.bStop.GlobalName = "bStop";
			this.bStop.Image = ((System.Drawing.Bitmap)(resources.GetObject("bStop.Image")));
			this.bStop.Name = "bStop";
			this.bStop.Text = "&Stop";
			// 
			// bRefresh
			// 
			this.bRefresh.GlobalName = "bRefresh";
			this.bRefresh.Image = ((System.Drawing.Bitmap)(resources.GetObject("bRefresh.Image")));
			this.bRefresh.Name = "bRefresh";
			this.bRefresh.Text = "&Refresh";
			// 
			// bSearch
			// 
			this.bSearch.BeginGroup = true;
			this.bSearch.GlobalName = "bSearch";
			this.bSearch.Image = ((System.Drawing.Bitmap)(resources.GetObject("bSearch.Image")));
			this.bSearch.Name = "bSearch";
			this.bSearch.Text = "&Search";
			// 
			// bHome
			// 
			this.bHome.GlobalName = "bHome";
			this.bHome.Image = ((System.Drawing.Bitmap)(resources.GetObject("bHome.Image")));
			this.bHome.Name = "bHome";
			this.bHome.Text = "&Home";
			// 
			// buttonItem1
			// 
			this.buttonItem1.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.buttonItem1.GlobalName = "bFavorites";
			this.buttonItem1.Image = ((System.Drawing.Bitmap)(resources.GetObject("buttonItem1.Image")));
			this.buttonItem1.Name = "buttonItem1";
			this.buttonItem1.Text = "&Favorites";
			// 
			// buttonItem2
			// 
			this.buttonItem2.BeginGroup = true;
			this.buttonItem2.GlobalName = "bPrint";
			this.buttonItem2.Image = ((System.Drawing.Bitmap)(resources.GetObject("buttonItem2.Image")));
			this.buttonItem2.Name = "buttonItem2";
			this.buttonItem2.Text = "&Print";
			// 
			// barLocation
			// 
			this.barLocation.AccessibleDescription = "DotNetBar Bar (barLocation)";
			this.barLocation.AccessibleName = "DotNetBar Bar";
			this.barLocation.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolBar;
			this.barLocation.CanDockLeft = false;
			this.barLocation.CanDockRight = false;
			this.barLocation.DockLine = 2;
			this.barLocation.DockSide = DevComponents.DotNetBar.eDockSide.Top;
			this.barLocation.GrabHandleStyle = DevComponents.DotNetBar.eGrabHandleStyle.Office2003;
			this.barLocation.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
																					   this.bAddress,
																					   this.bGo});
			this.barLocation.Location = new System.Drawing.Point(0, 59);
			this.barLocation.Name = "barLocation";
			this.barLocation.Size = new System.Drawing.Size(472, 27);
			this.barLocation.Stretch = true;
			this.barLocation.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
			this.barLocation.TabIndex = 2;
			this.barLocation.TabStop = false;
			this.barLocation.Text = "Location";
			// 
			// bAddress
			// 
			this.bAddress.ComboWidth = 128;
			this.bAddress.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
			this.bAddress.GlobalName = "bAddress";
			this.bAddress.ItemHeight = 14;
			this.bAddress.Name = "bAddress";
			this.bAddress.Stretch = true;
			// 
			// bGo
			// 
			this.bGo.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.bGo.GlobalName = "bGo";
			this.bGo.Image = ((System.Drawing.Bitmap)(resources.GetObject("bGo.Image")));
			this.bGo.Name = "bGo";
			this.bGo.Text = "Go";
			// 
			// barTopDockSite
			// 
			this.barTopDockSite.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
			this.barTopDockSite.Dock = System.Windows.Forms.DockStyle.Top;
			this.barTopDockSite.DocumentDockContainer = new DevComponents.DotNetBar.DocumentDockContainer();
			this.barTopDockSite.Location = new System.Drawing.Point(0, 87);
			this.barTopDockSite.Name = "barTopDockSite";
			this.barTopDockSite.Size = new System.Drawing.Size(472, 0);
			this.barTopDockSite.TabIndex = 7;
			this.barTopDockSite.TabStop = false;
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(472, 330);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.axWebBrowser1,
																		  this.barLeftDockSite,
																		  this.barRightDockSite,
																		  this.barTopDockSite,
																		  this.barBottomDockSite,
																		  this.dockSite1,
																		  this.dockSite2,
																		  this.dockSite3,
																		  this.dockSite4});
			this.Name = "Form1";
			this.Text = "DotNetBar Explorer";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.Form1_Load);
			this.Closed += new System.EventHandler(this.Form1_Closed);
			((System.ComponentModel.ISupportInitialize)(this.axWebBrowser1)).EndInit();
			this.dockSite3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.barMenu)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bar3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.barLocation)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

		private void SaveSettings()
		{
			string user=System.Windows.Forms.SystemInformation.UserDomainName;
			if(user=="")
				user="default";
			user+=".xml";
			string file=Application.StartupPath;
			if(!file.EndsWith("\\"))
				file+="\\";
			file+=user;
			dotNetBarManager1.SaveLayout(file);
		}

		private void Form1_Load(object sender, System.EventArgs e)
		{
			// Load custom user toolbar if avail.
			string user=System.Windows.Forms.SystemInformation.UserDomainName;
			if(user=="")
				user="default";
			user+=".xml";
			string file=Application.StartupPath;
			if(!file.EndsWith("\\"))
				file+="\\";
			file+=user;
			if(System.IO.File.Exists(file))
			{
				dotNetBarManager1.LoadLayout(file);
			}

			// Hook-up ComboBox Events
            bAddress.ComboBoxEx.KeyDown+=new KeyEventHandler(this.ComboKeyDown);
			bAddress.ComboBoxEx.SelectedIndexChanged+=new EventHandler(this.ComboSelectionChanged);
		}
		private void ComboKeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode==Keys.Enter)
			{
				DevComponents.DotNetBar.Controls.ComboBoxEx cbo=sender as DevComponents.DotNetBar.Controls.ComboBoxEx;
				// Remember in combo box
				m_RecordRecentlyUsed=true;
				// Try to navigate to that location
				object o=null;
				axWebBrowser1.Navigate(cbo.Text,ref o,ref o,ref o, ref o);
			}
		}

		private void ComboSelectionChanged(object sender, EventArgs e)
		{
			Navigate();
		}

		private void BarItemClick(object sender, EventArgs e)
		{
			BaseItem item=sender as BaseItem;
			if(item==null)
				return;
			if(item.Category=="Shortcut")
			{
				object o=null;
				axWebBrowser1.Navigate(item.Tag.ToString(),ref o,ref o,ref o, ref o);
				return;
			}

			switch(item.Name)
			{
				case "bGo":
				{
					m_RecordRecentlyUsed=true;
					Navigate();
					break;
				}
				case "bExit":
					this.Close();
					break;
				case "bOpen":
				{
					
					break;
				}
				case "bBack":
				{
					try
					{
						axWebBrowser1.GoBack();
					}
					catch(Exception){}
					break;
				}
				case "bForward":
				{
					try
					{
						axWebBrowser1.GoForward();
					}
					catch(Exception){}
					break;
				}
				case "bStop":
					axWebBrowser1.Stop();
					break;
				case "bRefresh":
				{
					object o=null;
					axWebBrowser1.Refresh2(ref o);
					break;
				}
				case "bSearch":
					axWebBrowser1.GoSearch();
					break;
				case "bHome":
					axWebBrowser1.GoHome();
					break;
				case "bPrint":
					SendKeys.Send("^p");
					break;
				case "bAddToFavorites":
					AddToFavorites();
					break;
				case "bOpenShortcut":
				{
					object o=null;
					axWebBrowser1.Navigate(((BaseItem)item.Parent.Tag).Tag.ToString(),ref o,ref o,ref o, ref o);
					// Close the Favorites pop-up menu
                    ((BaseItem)item.Parent.Tag).Parent.Expanded=false;                    
					break;
				}
				case "bDeleteShortcut":
				{
					BaseItem shortcut=(BaseItem)item.Parent.Tag;
					shortcut.Parent.Expanded=false;
					if(MessageBox.Show("Are you sure you want to remove shortcut?","Browser",MessageBoxButtons.YesNo)==DialogResult.Yes)
					{
						shortcut.Parent.SubItems.Remove(shortcut);
					}
					break;
				}
				case "bEditShortcut":
				{
                    BaseItem shortcut=(BaseItem)item.Parent.Tag;
					shortcut.Parent.Expanded=false;
					shortcut.Parent.Parent.AutoExpand=false;
					ShortcutEdit edit=new ShortcutEdit();
					edit.txtName.Text=shortcut.Text;
					edit.txtURL.Text=shortcut.Tag.ToString();
					edit.ShowDialog();
					if(edit.DialogResult==DialogResult.OK && edit.txtName.Text!="")
					{
                        shortcut.Text=edit.txtName.Text;
                        shortcut.Tag=edit.txtURL.Text;
					}
					edit.Dispose();
					edit=null;
					break;
				}
				default:
					Console.WriteLine("Item Click: "+item.Name);
					break;
			}
		}

		private void Navigate()
		{
			object o=null;
			axWebBrowser1.Navigate(bAddress.ControlText,ref o,ref o,ref o, ref o);
		}

		private void WebNavigateError(object sender, AxSHDocVw.DWebBrowserEvents2_NavigateErrorEvent e)
		{
			m_RecordRecentlyUsed=false;
		}

		private void WebDocumentComplete(object sender, AxSHDocVw.DWebBrowserEvents2_DocumentCompleteEvent e)
		{
			bAddress.ControlText=e.uRL.ToString();
			if(m_RecordRecentlyUsed)
			{
				bAddress.Items.Add(e.uRL.ToString());
				m_RecordRecentlyUsed=false;
			}
		}

		private void Form1_Closed(object sender, System.EventArgs e)
		{
			SaveSettings();
		}

		private void AddToFavorites()
		{
			if(axWebBrowser1.LocationURL=="")
				return;
			Bar bar=barMenu;
			BaseItem objFavorites=bFavorites;
			ButtonItem objLink=null;
			if(objFavorites.SubItems.Count>1)
			{
				// Check for duplicate links
				for(int i=1;i<objFavorites.SubItems.Count;i++)
				{
					BaseItem objTmp=objFavorites.SubItems[i];
					if(objTmp.Tag.ToString()==axWebBrowser1.LocationURL.ToLower())
					{
						if(MessageBox.Show("The name you have entered for the shortcut already exists on your Favorites menu. Would you like to overwrite it?","DotNetBar Browser Sample",MessageBoxButtons.YesNo)==DialogResult.No)
							return;
						objLink=objTmp as ButtonItem;
						break;
					}
				}
			}

			if(objLink==null)
			{
				objLink=new ButtonItem();
				objLink.Category="Shortcut";
				objLink.Text=axWebBrowser1.LocationName;
				if(objFavorites.SubItems.Count==1)
					objLink.BeginGroup=true;
				objFavorites.SubItems.Add(objLink);
			}
			objLink.Tag=axWebBrowser1.LocationURL.ToLower();
		}

		private void ItemMouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if(e.Button!=MouseButtons.Right)
				return;
			BaseItem item=sender as BaseItem;
			if(item==null || item.Category!="Shortcut")
				return;
			// Show context menu for regular menu item...
			m_FavoriteContext=new ButtonItem();
			// Remember the item that this context menu is working with
			m_FavoriteContext.Tag=item;
			ButtonItem context=new ButtonItem("bOpenShortcut");
			context.Text="Open";
			m_FavoriteContext.SubItems.Add(context);
			context=new ButtonItem("bEditShortcut");
			context.Text="Edit Shortcut";
			context.BeginGroup=true;
			m_FavoriteContext.SubItems.Add(context);
			context=new ButtonItem("bDeleteShortcut");
			context.Text="Delete";
			m_FavoriteContext.SubItems.Add(context);
			// Order of following commands is important so Favorites popup menu stays open
			// If RegisterPopup is called before PopupMenu the Favorites menu will be closed
			m_FavoriteContext.PopupMenu(Control.MousePosition);
			dotNetBarManager1.RegisterPopup(m_FavoriteContext);
		}
		
	}
}
