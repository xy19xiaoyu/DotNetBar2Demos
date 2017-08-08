using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace Ribbonpad
{
	/// <summary>
	/// Summary description for frmDocument.
	/// </summary>
	public class frmDocument : DevComponents.DotNetBar.Office2007Form
	{
		public System.Windows.Forms.RichTextBox rtfText;
		public bool DocumentChanged=false;
		public string FileName = "";
		public Command CommandUndo;
		public Command CommandCut;
		public Command CommandCopy;
		public Command CommandPaste;
		public Command CommandDelete;
		private Command CommandSelectAll;
		private Command CommandFindNext;
		private Command CommandReplace;
		public Command CommandStatus;
		public Command CommandFontBold;
		public Command CommandFontItalic;
		public Command CommandFontUnderline;
		public Command CommandFontStrike;
		public Command CommandAlignLeft;
		public Command CommandAlignCenter;
		public Command CommandAlignRight;
		public Command CommandTextColor;
		public Command CommandFind;
		public Command CommandFont;
		public Command CommandFontSize;
		public Command CommandZoom;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

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

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.rtfText = new System.Windows.Forms.RichTextBox();
			this.CommandUndo = new DevComponents.DotNetBar.Command();
			this.CommandCut = new DevComponents.DotNetBar.Command();
			this.CommandCopy = new DevComponents.DotNetBar.Command();
			this.CommandPaste = new DevComponents.DotNetBar.Command();
			this.CommandDelete = new DevComponents.DotNetBar.Command();
			this.CommandSelectAll = new DevComponents.DotNetBar.Command();
			this.CommandFindNext = new DevComponents.DotNetBar.Command();
			this.CommandReplace = new DevComponents.DotNetBar.Command();
			this.CommandStatus = new DevComponents.DotNetBar.Command();
			this.CommandFontBold = new DevComponents.DotNetBar.Command();
			this.CommandFontItalic = new DevComponents.DotNetBar.Command();
			this.CommandFontUnderline = new DevComponents.DotNetBar.Command();
			this.CommandFontStrike = new DevComponents.DotNetBar.Command();
			this.CommandAlignLeft = new DevComponents.DotNetBar.Command();
			this.CommandAlignCenter = new DevComponents.DotNetBar.Command();
			this.CommandAlignRight = new DevComponents.DotNetBar.Command();
			this.CommandTextColor = new DevComponents.DotNetBar.Command();
			this.CommandFind = new DevComponents.DotNetBar.Command();
			this.CommandFont = new DevComponents.DotNetBar.Command();
			this.CommandFontSize = new DevComponents.DotNetBar.Command();
			this.CommandZoom = new DevComponents.DotNetBar.Command();
			this.SuspendLayout();
			// 
			// rtfText
			// 
			this.rtfText.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.rtfText.Dock = System.Windows.Forms.DockStyle.Fill;
			this.rtfText.HideSelection = false;
			this.rtfText.Name = "rtfText";
			this.rtfText.Size = new System.Drawing.Size(124, 87);
			this.rtfText.TabIndex = 0;
			this.rtfText.Text = "";
			this.rtfText.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
			this.rtfText.TextChanged += new System.EventHandler(this.rtfText_TextChanged);
			this.rtfText.SelectionChanged += new System.EventHandler(this.TextSelectionChanged);
			// 
			// CommandUndo
			// 
			this.CommandUndo.Executed += new System.EventHandler(this.CommandUndo_Executed);
			// 
			// CommandCut
			// 
			this.CommandCut.Executed += new System.EventHandler(this.CommandCut_Executed);
			// 
			// CommandCopy
			// 
			this.CommandCopy.Executed += new System.EventHandler(this.CommandCopy_Executed);
			// 
			// CommandPaste
			// 
			this.CommandPaste.Executed += new System.EventHandler(this.CommandPaste_Executed);
			// 
			// CommandDelete
			// 
			this.CommandDelete.Executed += new System.EventHandler(this.CommandDelete_Executed);
			// 
			// CommandSelectAll
			// 
			this.CommandSelectAll.Executed += new System.EventHandler(this.CommandSelectAll_Executed);
			// 
			// CommandFindNext
			// 
			this.CommandFindNext.Executed += new System.EventHandler(this.CommandFindNext_Executed);
			// 
			// CommandReplace
			// 
			this.CommandReplace.Executed += new System.EventHandler(this.CommandReplace_Executed);
			// 
			// CommandFontBold
			// 
			this.CommandFontBold.Executed += new System.EventHandler(this.CommandFontBold_Executed);
			// 
			// CommandFontItalic
			// 
			this.CommandFontItalic.Executed += new System.EventHandler(this.CommandFontItalic_Executed);
			// 
			// CommandFontUnderline
			// 
			this.CommandFontUnderline.Executed += new System.EventHandler(this.CommandFontUnderline_Executed);
			// 
			// CommandFontStrike
			// 
			this.CommandFontStrike.Executed += new System.EventHandler(this.CommandFontStrike_Executed);
			// 
			// CommandAlignLeft
			// 
			this.CommandAlignLeft.Executed += new System.EventHandler(this.CommandAlignLeft_Executed);
			// 
			// CommandAlignCenter
			// 
			this.CommandAlignCenter.Executed += new System.EventHandler(this.CommandAlignCenter_Executed);
			// 
			// CommandAlignRight
			// 
			this.CommandAlignRight.Executed += new System.EventHandler(this.CommandAlignRight_Executed);
			// 
			// CommandTextColor
			// 
			this.CommandTextColor.Executed += new System.EventHandler(this.CommandTextColor_Executed);
			// 
			// CommandFind
			// 
			this.CommandFind.Executed += new System.EventHandler(this.CommandFind_Executed);
			// 
			// CommandFont
			// 
			this.CommandFont.Executed += new System.EventHandler(this.CommandFont_Executed);
			// 
			// CommandFontSize
			// 
			this.CommandFontSize.Executed += new System.EventHandler(this.CommandFontSize_Executed);
			// 
			// CommandZoom
			// 
			this.CommandZoom.Executed += new System.EventHandler(this.CommandZoom_Executed);
			// 
			// frmDocument
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(125)), ((System.Byte)(125)), ((System.Byte)(125)));
			this.ClientSize = new System.Drawing.Size(124, 87);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.rtfText});
			this.Name = "frmDocument";
			this.Text = "frmDocument";
			this.Closing += new System.ComponentModel.CancelEventHandler(this.FormClosing);
			this.Closed += new System.EventHandler(this.FormClosed);
			this.ResumeLayout(false);

		}
		#endregion

		private void OnMouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if(e.Button!=MouseButtons.Right)
				return;

			frmMain mdi=this.ParentForm as frmMain;
			mdi.EditContextMenu();
		}

		private void TextSelectionChanged(object sender, System.EventArgs e)
		{
			UpdateSelectionCommandsState();
		}

		private void UpdateStatusBar()
		{
			//frmMain mdi=this.ParentForm as frmMain;
			CommandStatus.Text = "Ln " + (rtfText.GetLineFromCharIndex(rtfText.SelectionStart) + 1) + "\tCh " + rtfText.SelectionStart;
			//mdi.labelPosition.Text="Ln "+(rtfText.GetLineFromCharIndex(rtfText.SelectionStart)+1)+"\tCh "+rtfText.SelectionStart;
		}

		private void UpdateSelectionCommandsState()
		{
			UpdateStatusBar();

			CommandCut.Enabled = rtfText.SelectionLength > 0;
			CommandCopy.Enabled = rtfText.SelectionLength > 0;
			CommandDelete.Enabled = rtfText.SelectionLength > 0;

			CommandFontBold.Checked = rtfText.SelectionFont.Bold;
			CommandFontItalic.Checked = rtfText.SelectionFont.Italic;
			CommandFontUnderline.Checked = rtfText.SelectionFont.Underline;
			CommandFontStrike.Checked = rtfText.SelectionFont.Strikeout;
			if (rtfText.SelectionFont != null)
				CommandFont.Text = rtfText.SelectionFont.Name;
			else
				CommandFont.Text = "";
			CommandFontSize.Text = ((int)rtfText.SelectionFont.Size).ToString();
			
			CommandAlignLeft.Checked=(rtfText.SelectionAlignment==HorizontalAlignment.Left);
			CommandAlignRight.Checked=(rtfText.SelectionAlignment==HorizontalAlignment.Right);
			CommandAlignCenter.Checked=(rtfText.SelectionAlignment==HorizontalAlignment.Center);
		}

		public void FormActivated()
		{
			EnableDocMenuItems();
			UpdateStatusBar();
		}

		private void EnableDocMenuItems()
		{
			if(!this.Visible)
				return;

			// Enable Edit Commands
			CommandPaste.Enabled = true;
			CommandSelectAll.Enabled = true;
			CommandFind.Enabled = true;
			CommandFindNext.Enabled = true;
			CommandReplace.Enabled = true;

			// Enable Format Commands
			CommandAlignLeft.Enabled = true;
			CommandAlignRight.Enabled = true;
			CommandAlignCenter.Enabled = true;

			CommandFontBold.Enabled = true;
			CommandFontItalic.Enabled = true;
			CommandFontUnderline.Enabled = true;
			CommandFontStrike.Enabled = true;

			CommandTextColor.Enabled = true;

			CommandFontSize.Enabled = true;
			CommandFont.Enabled = true;

			// Update zoom value
			int val = (int)(rtfText.ZoomFactor * 100);
			CommandZoom.Text = val.ToString() + "%";
			if (val < 100)
				val = (int)((float)val * 100 / 75 - 25);
			else if (val > 100)
				val = (int)((val + 100) * 100f / 400 - 100);
			CommandZoom.SetValue("Value", val);

			UpdateSelectionCommandsState();
		}

		public void FormDeactivated()
		{
			DisableDocMenuItems();
		}

		private void DisableDocMenuItems()
		{
			CommandCut.Enabled=false;
			CommandCopy.Enabled=false;
			CommandPaste.Enabled=false;
			CommandDelete.Enabled=false;
			CommandSelectAll.Enabled=false;
			CommandFind.Enabled=false;
			CommandFindNext.Enabled=false;
			CommandReplace.Enabled=false;

			// Disable Format items
			CommandFontBold.Enabled=false;
			CommandFontItalic.Enabled = false;
			CommandFontUnderline.Enabled = false;
			CommandFontStrike.Enabled = false;
			CommandAlignLeft.Enabled = false;
			CommandAlignRight.Enabled=false;
			CommandAlignCenter.Enabled=false;
			CommandTextColor.Enabled=false;

			CommandFontSize.Enabled=false;
			CommandFont.Enabled=false;
		}

		

		private void rtfText_TextChanged(object sender, System.EventArgs e)
		{
			DocumentChanged=true;
		}

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
			FormDeactivated();
		}

		private void FormClosing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			if(this.DocumentChanged)
			{
				System.Windows.Forms.DialogResult dlg=MessageBoxEx.Show(this,"Document '"+this.FileName+"' has changed. Save changes?","Notepad",MessageBoxButtons.YesNoCancel);
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

		private void CommandUndo_Executed(object sender, EventArgs e)
		{
			rtfText.Undo();
			CommandExecuted();
		}

		private void CommandCut_Executed(object sender, EventArgs e)
		{
			rtfText.Cut();
			CommandExecuted();
		}

		private void CommandCopy_Executed(object sender, EventArgs e)
		{
			rtfText.Copy();
			CommandExecuted();
		}

		private void CommandPaste_Executed(object sender, EventArgs e)
		{
			rtfText.Paste();
			CommandExecuted();
		}

		private void CommandDelete_Executed(object sender, EventArgs e)
		{
			rtfText.SelectedText = "";
			CommandExecuted();
		}

		private void CommandSelectAll_Executed(object sender, EventArgs e)
		{
			rtfText.SelectAll();
			CommandExecuted();
		}

		private void CommandFindNext_Executed(object sender, EventArgs e)
		{
			MessageBoxEx.Show("Not implemented yet.");
			CommandExecuted();
		}

		private void CommandReplace_Executed(object sender, EventArgs e)
		{
			MessageBoxEx.Show("Not implemented yet.");
			CommandExecuted();
		}

		private void CommandFontBold_Executed(object sender, EventArgs e)
		{
			if (rtfText.SelectionFont.Bold)
				rtfText.SelectionFont = new Font(rtfText.SelectionFont, (rtfText.SelectionFont.Style & ~(rtfText.SelectionFont.Style & FontStyle.Bold)));
			else
				rtfText.SelectionFont = new Font(rtfText.SelectionFont, (rtfText.SelectionFont.Style | FontStyle.Bold));
			CommandExecuted();
		}

		private void CommandFontItalic_Executed(object sender, EventArgs e)
		{
			if (rtfText.SelectionFont.Italic)
				rtfText.SelectionFont = new Font(rtfText.SelectionFont, (rtfText.SelectionFont.Style & ~(rtfText.SelectionFont.Style & FontStyle.Italic)));
			else
				rtfText.SelectionFont = new Font(rtfText.SelectionFont, (rtfText.SelectionFont.Style | FontStyle.Italic));
			CommandExecuted();
		}

		private void CommandFontUnderline_Executed(object sender, EventArgs e)
		{
			if (rtfText.SelectionFont.Underline)
				rtfText.SelectionFont = new Font(rtfText.SelectionFont, (rtfText.SelectionFont.Style & ~(rtfText.SelectionFont.Style & FontStyle.Underline)));
			else
				rtfText.SelectionFont = new Font(rtfText.SelectionFont, (rtfText.SelectionFont.Style | FontStyle.Underline));
			CommandExecuted();
		}

		private void CommandFontStrike_Executed(object sender, EventArgs e)
		{
			if (rtfText.SelectionFont.Strikeout)
				rtfText.SelectionFont = new Font(rtfText.SelectionFont, (rtfText.SelectionFont.Style & ~(rtfText.SelectionFont.Style & FontStyle.Strikeout)));
			else
				rtfText.SelectionFont = new Font(rtfText.SelectionFont, (rtfText.SelectionFont.Style | FontStyle.Strikeout));
			CommandExecuted();
		}

		private void CommandAlignLeft_Executed(object sender, EventArgs e)
		{
			rtfText.SelectionAlignment = HorizontalAlignment.Left;
			CommandExecuted();
		}

		private void CommandAlignCenter_Executed(object sender, EventArgs e)
		{
			rtfText.SelectionAlignment = HorizontalAlignment.Center;
			CommandExecuted();
		}

		private void CommandAlignRight_Executed(object sender, EventArgs e)
		{
			rtfText.SelectionAlignment = HorizontalAlignment.Right;
			CommandExecuted();
		}

		private void CommandTextColor_Executed(object sender, EventArgs e)
		{
			if (sender is ColorPickerDropDown)
				rtfText.SelectionColor = ((ColorPickerDropDown)sender).SelectedColor;
			CommandExecuted();
		}

		private void CommandFind_Executed(object sender, EventArgs e)
		{
			ICommandSource source = sender as ICommandSource;
			if (source!=null && source.CommandParameter is string)
			{
				string searchText = source.CommandParameter.ToString();
				rtfText.Find(searchText, rtfText.SelectionStart + rtfText.SelectionLength, RichTextBoxFinds.None);
			}
			CommandExecuted();
		}

		private void CommandFont_Executed(object sender, EventArgs e)
		{
			ComboBoxItem combo = sender as ComboBoxItem;
			if (combo != null && combo.SelectedItem != null)
			{
				try
				{
					Font font = new Font(combo.SelectedItem.ToString(), rtfText.SelectionFont.Size);
					rtfText.SelectionFont = font;
				}
				catch { }
			}
			CommandExecuted();
		}

		private void CommandFontSize_Executed(object sender, EventArgs e)
		{
			ComboBoxItem combo = sender as ComboBoxItem;
			if (combo != null && combo.SelectedItem != null)
			{
				Font font = new Font(rtfText.SelectionFont.FontFamily, int.Parse(combo.SelectedItem.ToString()));
				rtfText.SelectionFont = font;
			}
			CommandExecuted();
		}

		private void CommandExecuted()
		{
			DocumentChanged = true;
			UpdateSelectionCommandsState();
		}

		private void CommandZoom_Executed(object sender, EventArgs e)
		{
			SliderItem zoomSlider = sender as SliderItem;
			if (zoomSlider == null) return;

			int val = zoomSlider.Value;
			if (val < 100)
				val = (int)((float)val / 100 * 75 + 25);
			else
				val = (int)((val - 100) / 100f * 400 + 100);

			rtfText.ZoomFactor = val / 100f;
			CommandZoom.Text = val.ToString() + "%";
		}
	}
}
