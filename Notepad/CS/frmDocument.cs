using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace Notepad
{
	/// <summary>
	/// Summary description for frmDocument.
	/// </summary>
	public class frmDocument : System.Windows.Forms.Form
	{
		#region Private/Public variables
		private System.Windows.Forms.RichTextBox rtfText;
		public bool DocumentChanged=false;
		public string FileName="";
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
		#endregion

		#region Constructor, Dispose
		public frmDocument()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}
		#endregion

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.rtfText = new System.Windows.Forms.RichTextBox();
			this.SuspendLayout();
			// 
			// rtfText
			// 
			this.rtfText.Anchor = (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.rtfText.HideSelection = false;
			this.rtfText.Name = "rtfText";
			this.rtfText.Size = new System.Drawing.Size(127, 86);
			this.rtfText.TabIndex = 0;
			this.rtfText.Text = "";
			this.rtfText.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
			this.rtfText.TextChanged += new System.EventHandler(this.rtfText_TextChanged);
			this.rtfText.SelectionChanged += new System.EventHandler(this.TextSelectionChanged);
			// 
			// frmDocument
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(127, 83);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.rtfText});
			this.Name = "frmDocument";
			this.Text = "frmDocument";
			this.Closing += new System.ComponentModel.CancelEventHandler(this.FormClosing);
			this.Closed += new System.EventHandler(this.FormClosed);
			this.VisibleChanged += new System.EventHandler(this.FormVisibleChanged);
			this.Activated += new System.EventHandler(this.FormActivated);
			this.Deactivate += new System.EventHandler(this.FormDeactivated);
			this.ResumeLayout(false);

		}
		#endregion

		#region Document Command handling
		private void OnMouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if(e.Button!=MouseButtons.Right)
				return;

			frmMain mdi=this.ParentForm as frmMain;
            mdi.EditContextMenu();
		}

		private void TextSelectionChanged(object sender, System.EventArgs e)
		{
			EnableSelectionItems();
		}

		private void UpdateStatusBar()
		{
			frmMain mdi=this.ParentForm as frmMain;
			mdi.labelPosition.Text="Ln "+(rtfText.GetLineFromCharIndex(rtfText.SelectionStart)+1)+"\tCh "+rtfText.SelectionStart;
		}

		private void EnableSelectionItems()
		{
			frmMain mdi=this.ParentForm as frmMain;

			UpdateStatusBar();

			if(rtfText.SelectionLength==0)
			{
				mdi.bCut.Enabled=false;
				mdi.bCopy.Enabled=false;
				mdi.bDelete.Enabled=false;
			}
			else
			{
				mdi.bCut.Enabled=true;
				mdi.bCopy.Enabled=true;
				mdi.bDelete.Enabled=true;
				
			}
			mdi.bBold.Checked=rtfText.SelectionFont.Bold;
			mdi.bItalic.Checked=rtfText.SelectionFont.Italic;
			mdi.bUnderline.Checked=rtfText.SelectionFont.Underline;
			mdi.bStrikethrough.Checked=rtfText.SelectionFont.Strikeout;

			mdi.bAlignLeft.Checked=(rtfText.SelectionAlignment==HorizontalAlignment.Left);
			mdi.bAlignRight.Checked=(rtfText.SelectionAlignment==HorizontalAlignment.Right);
			mdi.bAlignCenter.Checked=(rtfText.SelectionAlignment==HorizontalAlignment.Center);
		}

		private void FormActivated(object sender, System.EventArgs e)
		{
			EnableDocMenuItems();
			UpdateStatusBar();
		}

		private void EnableDocMenuItems()
		{
			if(!this.Visible)
				return;

			frmMain m=this.ParentForm as frmMain;

			// Disabled Edit items
			m.bPaste.Enabled=true;
			m.bSelectAll.Enabled=true;
			m.Find.Enabled=true;
			m.bFindNext.Enabled=true;
			m.bReplace.Enabled=true;

			// Disable Format items
			m.bAlignLeft.Enabled=true;
			m.bAlignRight.Enabled=true;
			m.bAlignCenter.Enabled=true;

			m.bBold.Enabled=true;
			m.bItalic.Enabled=true;
			m.bUnderline.Enabled=true;
			m.bStrikethrough.Enabled=true;

			m.bTextColor.Enabled=true;

			EnableSelectionItems();
		}

		private void FormDeactivated(object sender, System.EventArgs e)
		{
			DisableDocMenuItems();
		}

		private void FormVisibleChanged(object sender, System.EventArgs e)
		{
			if(this.Visible)
				EnableDocMenuItems();
			else
				DisableDocMenuItems();
		}

		private void DisableDocMenuItems()
		{
			frmMain m=this.ParentForm as frmMain;

			// Disabled Edit items
			m.bCut.Enabled=false;
			m.bCopy.Enabled=false;
			m.bPaste.Enabled=false;
			m.bDelete.Enabled=false;
			m.bSelectAll.Enabled=false;
			m.Find.Enabled=false;
			m.bFindNext.Enabled=false;
			m.bReplace.Enabled=false;

			// Disable Format items
			m.bBold.Enabled=false;
			m.bItalic.Enabled=false;
			m.bUnderline.Enabled=false;
			m.bStrikethrough.Enabled=false;
			m.bAlignLeft.Enabled=false;
			m.bAlignRight.Enabled=false;
			m.bAlignCenter.Enabled=false;
			m.bTextColor.Enabled=false;
		}

		/// <summary>
		/// Process Menu/Toolbar commands
		/// </summary>
		/// <param name="cmd">Command string</param>
		public void ExecuteCommand(string cmd, object data)
		{
			switch(cmd)
			{
				// Edit Menu
				case "bUndo":
					rtfText.Undo();
					break;
				case "bCut":
					rtfText.Cut();
					break;
				case "bCopy":
					rtfText.Copy();
					break;
				case "bPaste":
					rtfText.Paste();
					break;
				case "bDelete":
					rtfText.SelectedText="";
					break;
				case "bSelectAll":
					rtfText.SelectAll();
					break;
				case "bFindNext":
					MessageBox.Show("Not implemented yet.");
					break;
				case "bReplace":
					MessageBox.Show("Not implemented yet.");
					break;
					// Format menu
				case "bBold":
				{
					if(rtfText.SelectionFont.Bold)
						rtfText.SelectionFont=new Font(rtfText.SelectionFont,(rtfText.SelectionFont.Style & ~(rtfText.SelectionFont.Style & FontStyle.Bold)));
					else
						rtfText.SelectionFont=new Font(rtfText.SelectionFont,(rtfText.SelectionFont.Style | FontStyle.Bold));
					break;
				}
				case "bItalic":
				{
					if(rtfText.SelectionFont.Italic)
						rtfText.SelectionFont=new Font(rtfText.SelectionFont,(rtfText.SelectionFont.Style & ~(rtfText.SelectionFont.Style & FontStyle.Italic)));
					else
						rtfText.SelectionFont=new Font(rtfText.SelectionFont,(rtfText.SelectionFont.Style | FontStyle.Italic));
					break;
				}
				case "bUnderline":
				{
					if(rtfText.SelectionFont.Underline)
						rtfText.SelectionFont=new Font(rtfText.SelectionFont,(rtfText.SelectionFont.Style & ~(rtfText.SelectionFont.Style & FontStyle.Underline)));
					else
						rtfText.SelectionFont=new Font(rtfText.SelectionFont,(rtfText.SelectionFont.Style | FontStyle.Underline));
					break;
				}
				case "bStrikethrough":
					if(rtfText.SelectionFont.Strikeout)
						rtfText.SelectionFont=new Font(rtfText.SelectionFont,(rtfText.SelectionFont.Style & ~(rtfText.SelectionFont.Style & FontStyle.Strikeout)));
					else
						rtfText.SelectionFont=new Font(rtfText.SelectionFont,(rtfText.SelectionFont.Style | FontStyle.Strikeout));
					break;
				case "bAlignLeft":
					rtfText.SelectionAlignment=HorizontalAlignment.Left;
					break;
				case "bAlignCenter":
					rtfText.SelectionAlignment=HorizontalAlignment.Center;
					break;
				case "bAlignRight":
					rtfText.SelectionAlignment=HorizontalAlignment.Right;
					break;
				case "bTextColor":
				{
					if(data!=null && data is Color)
						rtfText.SelectionColor=(Color)data;
					break;
				}
				case "Find":
				{
					if(data!=null)
					{
						string searchText=data.ToString();
						rtfText.Find(searchText,rtfText.SelectionStart+rtfText.SelectionLength,RichTextBoxFinds.None);
					}
					break;
				}
			}
			DocumentChanged=true;
			EnableSelectionItems();
		}

		private void rtfText_TextChanged(object sender, System.EventArgs e)
		{
			DocumentChanged=true;
		}
		#endregion

		#region Document File handling
		public void OpenFile(string filename)
		{
			if(filename.Substring(filename.Length-4,4).ToLower()==".txt")
				rtfText.LoadFile(filename,RichTextBoxStreamType.PlainText);
			else
                rtfText.LoadFile(filename,RichTextBoxStreamType.RichText);
			this.FileName=filename;
			DocumentChanged=false;
		}

		public void SaveFile()
		{
			if(this.FileName.Substring(this.FileName.Length-4,4).ToLower()==".txt")
				rtfText.SaveFile(this.FileName,RichTextBoxStreamType.PlainText);
			else
				rtfText.SaveFile(this.FileName,RichTextBoxStreamType.RichText);
            
			DocumentChanged=false;
		}

		private void FormClosed(object sender, System.EventArgs e)
		{
			frmMain mdi=this.ParentForm as frmMain;
			mdi.labelPosition.Text="";
			DisableDocMenuItems();
		}

		private void FormClosing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			if(this.DocumentChanged)
			{
				System.Windows.Forms.DialogResult dlg=MessageBox.Show(this,"Document '"+this.FileName+"' has changed. Save changes?","Notepad",MessageBoxButtons.YesNoCancel);
				if(dlg==System.Windows.Forms.DialogResult.Cancel)
				{
					e.Cancel=true;
				}
				else if(dlg==System.Windows.Forms.DialogResult.Yes)
				{
					if(this.FileName=="")
						((frmMain)this.MdiParent).SaveDocument(this);
					if(this.FileName!="")
						SaveFile();
				}
			}
		}
		#endregion
	}
}
