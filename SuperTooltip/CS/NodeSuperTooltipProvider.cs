using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace SuperTooltip
{
	/// <summary>
	/// Wrapper so SuperTooltips can be displayed for node objects.
	/// </summary>
	public class NodeSuperTooltipProvider : Component, DevComponents.DotNetBar.ISuperTooltipInfoProvider
	{
		private TreeNode m_Node=null;

		/// <summary>
		/// Creates new instance of the object.
		/// </summary>
		/// <param name="node">Node to provide tooltip information for</param>
		public NodeSuperTooltipProvider(TreeNode node)
		{
			m_Node=node;
		}

		/// <summary>
		/// Call this method to show tooltip for given node.
		/// </summary>
		public void Show()
		{
			if(this.DisplayTooltip!=null)
				DisplayTooltip(this,new EventArgs());
		}

		/// <summary>
		/// Call this method to hide tooltip for given node.
		/// </summary>
		public void Hide()
		{
			if(this.HideTooltip!=null)
				this.HideTooltip(this,new EventArgs());
		}

		#region ISuperTooltipInfoProvider Members

		/// <summary>
		/// Returns screen coordinates of object.
		/// </summary>
		public System.Drawing.Rectangle ComponentRectangle
		{
			get
			{
				Rectangle r=m_Node.Bounds;
				r.Location=m_Node.TreeView.PointToScreen(r.Location);
				return r;
			}
		}

		public event EventHandler DisplayTooltip;
		public event EventHandler HideTooltip;

		#endregion
	}
}
