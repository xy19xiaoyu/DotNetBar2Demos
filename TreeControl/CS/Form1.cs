using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using System.IO;
using DevComponents.AdvTree;

namespace TreeControl
{
    public partial class Form1 : Office2007Form
    {
        public Form1()
        {
            InitializeComponent();
            // This way you can disable the automatic horizontal scrolling on tree control
            AdvTreeSettings.SelectedScrollIntoViewHorizontal = false;
        }

        #region File Tree 
        private ElementStyle _RightAlignFileSizeStyle = null;
        private void Form1_Load(object sender, EventArgs e)
        {
            SetupTileView();

            // TODO: This line of code loads data into the 'customersDataSet.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.customersDataSet.Customers);
            DriveInfo[] drives = DriveInfo.GetDrives();
            // Disables tree layout and display updates to optimize update
            advTree1.BeginUpdate();
            foreach (DriveInfo driveInfo in drives)
            {
                if (driveInfo.DriveType != DriveType.Fixed) continue;
                Node node = new Node();
                node.Tag = driveInfo;
                node.Text = driveInfo.Name.Replace(@"\","");
                node.Image = global::TreeControl.Properties.Resources.Harddrive;
                node.Cells.Add(new Cell("Local Disk"));
                node.Cells.Add(new Cell());
                advTree1.Nodes.Add(node);
                // We will load drive content on demand
                node.ExpandVisibility = eNodeExpandVisibility.Visible;
            }
            // Enable tree layout and display updates, performs any pending layout and display updates
            advTree1.EndUpdate();
            _RightAlignFileSizeStyle = new ElementStyle();
            _RightAlignFileSizeStyle.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Far;
        }

        private void SetupTileView()
        {
            advTree6.Nodes.Clear();
            advTree6.View = eView.Tile;

            // Define group node style
            ElementStyle groupStyle = new ElementStyle();
            groupStyle.TextColor = Color.Navy;
            groupStyle.Font = new Font(advTree6.Font.FontFamily, 9.5f);
            groupStyle.Name = "groupstyle";
            advTree6.Styles.Add(groupStyle);

            // Define sub-item style, simply to make text gray
            ElementStyle subItemStyle = new ElementStyle();
            subItemStyle.TextColor = Color.Gray;
            subItemStyle.Name = "subitemstyle";
            advTree6.Styles.Add(subItemStyle);

            Node groupNode = new Node("Today (1)", groupStyle);
            groupNode.Expanded = true;
            advTree6.Nodes.Add(groupNode);
            groupNode.Nodes.Add(CreateChildNode("Documents", "File folder", global::TreeControl.Properties.Resources.Folder, subItemStyle));

            groupNode = new Node("Last week (3)", groupStyle);
            groupNode.Expanded = true;
            advTree6.Nodes.Add(groupNode);
            groupNode.Nodes.Add(CreateChildNode("New Folder", "File folder", global::TreeControl.Properties.Resources.Folder2, subItemStyle));
            groupNode.Nodes.Add(CreateChildNode("Vacation 2010", "File folder", global::TreeControl.Properties.Resources.Folder3, subItemStyle));
            groupNode.Nodes.Add(CreateChildNode("AdvTree mockup", "Drawing file", global::TreeControl.Properties.Resources.Drawing, subItemStyle));

            groupNode = new Node("Earlier this year (2)", groupStyle);
            groupNode.Expanded = true;
            advTree6.Nodes.Add(groupNode);
            groupNode.Nodes.Add(CreateChildNode("Testcode", "File folder", global::TreeControl.Properties.Resources.Folder2, subItemStyle));
            groupNode.Nodes.Add(CreateChildNode("Help", "File folder", global::TreeControl.Properties.Resources.Folder, subItemStyle));
            groupNode.Nodes.Add(CreateChildNode("Images Backup.zip", "Compressed (zipped) folder", global::TreeControl.Properties.Resources.Zip, subItemStyle));
            groupNode.Nodes.Add(CreateChildNode("Music", "Library", global::TreeControl.Properties.Resources.Folder4, subItemStyle));
            groupNode.Nodes.Add(CreateChildNode("Winter 2009", "File folder", global::TreeControl.Properties.Resources.Folder3, subItemStyle));


            //************************************************
            // Setup data-bound tree with auto-grouping
            //************************************************

            // Country group style
            groupStyle = new ElementStyle();
            groupStyle.TextColor = Color.SlateGray;
            groupStyle.Font = new Font(advTree6.Font.FontFamily, 9f, FontStyle.Bold);
            groupStyle.Name = "groupstyle";
            advTree7.Styles.Add(groupStyle);
            // Style for contact name
            subItemStyle = new ElementStyle();
            subItemStyle.TextColor = Color.SlateGray;
            subItemStyle.Name = "subitemstyle";
            advTree7.Styles.Add(subItemStyle);
            // Style for phone cell
            subItemStyle = new ElementStyle();
            subItemStyle.TextColor = Color.Maroon;
            subItemStyle.Name = "subitemphone";
            advTree7.Styles.Add(subItemStyle);

            List<Customer> customers = new List<Customer>();
            customers.AddRange(new Customer[]
                {
                    new Customer("Alfreds Futterkiste", "Maria Anders", "Germany", "030-0074321"),
                    new Customer("Ana Trujillo Emparedados y helados", "Ana Trujillo", "Mexico", "(5) 555-4729"),
                    new Customer("Antonio Moreno Taquería", "Antonio Moreno", "Mexico", "(5) 555-3932"),
                    new Customer("Around the Horn", "Thomas Hardy", "UK", "(171) 555-7788"),
                    new Customer("Blauer See Delikatessen", "Hanna Moos", "Germany", "0621-08460"),
                    new Customer("Berglunds snabbköp","Christina Berglund","Sweden","0921-12 34 65"),
                    new Customer("Folk och fä HB","Maria Larsson","Sweden","0695-34 67 21"),
                    new Customer("Consolidated Holdings","Elizabeth Brown","UK","(171) 555-2282"),
                    new Customer("Du monde entier","Janine Labrune","France","40.67.88.88"),
                    new Customer("Eastern Connection","Ann Devon","UK","(171) 555-0297"),
                    new Customer("Ernst Handel","Roland Mendel","Austria","7675-3425"),
                    new Customer("Familia Arquibaldo","Aria Cruz","Brazil","(11) 555-9857"),
                    new Customer("Frankenversand","Peter Franken","Germany","089-0877310")
                });
            advTree7.GroupNodeCreated += new DevComponents.DotNetBar.Controls.DataNodeEventHandler(AdvTree7GroupNodeCreated);
            advTree7.DataNodeCreated += new DevComponents.DotNetBar.Controls.DataNodeEventHandler(AdvTree7DataNodeCreated);
            advTree7.TileSize = new Size(200, 48);
            advTree7.GroupingMembers = "Country";
            advTree7.DisplayMembers = "Company,Contact,Phone";
            advTree7.DataSource = customers;
        }

        void AdvTree7DataNodeCreated(object sender, DevComponents.DotNetBar.Controls.DataNodeEventArgs e)
        {
            e.Node.Cells[1].StyleNormal = advTree7.Styles["subitemstyle"];
            e.Node.Cells[2].StyleNormal = advTree7.Styles["subitemphone"];
        }
        void AdvTree7GroupNodeCreated(object sender, DevComponents.DotNetBar.Controls.DataNodeEventArgs e)
        {
            e.Node.Style = advTree7.Styles["groupstyle"];
        }

        private Node CreateChildNode(string nodeText, string subText, Image image, ElementStyle subItemStyle)
        {
            Node childNode = new Node(nodeText);
            childNode.Image = image;
            childNode.Cells.Add(new Cell(subText, subItemStyle));
            return childNode;
        }

        private void advTree1_BeforeExpand(object sender, AdvTreeNodeCancelEventArgs e)
        {
            Node parent = e.Node;
            if (parent.Nodes.Count > 0) return;

            if (parent.Tag is DriveInfo)
            {
                advTree1.BeginUpdate();
                DriveInfo driveInfo = (DriveInfo)parent.Tag;
                LoadDirectories(parent, driveInfo.RootDirectory);
                parent.ExpandVisibility = eNodeExpandVisibility.Auto;
                advTree1.EndUpdate(true);
            }
            else if (parent.Tag is DirectoryInfo)
            {
                LoadDirectories(parent, (DirectoryInfo)parent.Tag);
            }
        }

        private void LoadDirectories(Node parent, DirectoryInfo directoryInfo)
        {
            DirectoryInfo[] directories = directoryInfo.GetDirectories();
            foreach (DirectoryInfo dir in directories)
            {
                if ((dir.Attributes & FileAttributes.Hidden) == FileAttributes.Hidden) continue;
                Node node = new Node();
                node.Tag = dir;
                node.Text = dir.Name;
                node.Image = global::TreeControl.Properties.Resources.FolderClosed;
                node.ImageExpanded = global::TreeControl.Properties.Resources.FolderOpen;
                node.Cells.Add(new Cell("Local Folder"));
                node.Cells.Add(new Cell());
                node.ExpandVisibility = eNodeExpandVisibility.Visible;
                parent.Nodes.Add(node);
            }

            FileInfo[] files = directoryInfo.GetFiles();
            foreach (FileInfo file in files)
            {
                Node node = new Node();
                node.Text = file.Name;
                node.Image = global::TreeControl.Properties.Resources.Document;
                node.Cells.Add(new Cell("File"));
                Cell cell = new Cell(file.Length.ToString("N0"));
                cell.StyleNormal = _RightAlignFileSizeStyle;
                node.Cells.Add(cell);

                parent.Nodes.Add(node);
            }
        }
        #endregion

        private void advTree3_MarkupLinkClick(object sender, DevComponents.AdvTree.MarkupLinkClickEventArgs e)
        {
            MessageBoxEx.Show("Markup link clicked...", "AdvTree Control");
        }
    }

    #region Customer Class
    internal class Customer
    {
        /// <summary>
        /// Initializes a new instance of the Customer class.
        /// </summary>
        /// <param name="company"></param>
        /// <param name="contact"></param>
        /// <param name="country"></param>
        /// <param name="phone"></param>
        public Customer(string company, string contact, string country, string phone)
        {
            Company = company;
            Contact = contact;
            Country = country;
            Phone = phone;
        }
        private string _Company;
        public string Company
        {
            get { return _Company; }
            set
            {
                _Company = value;
            }
        }
        private string _Contact;
        public string Contact
        {
            get { return _Contact; }
            set
            {
                _Contact = value;
            }
        }
        private string _Country;
        public string Country
        {
            get { return _Country; }
            set
            {
                _Country = value;
            }
        }
        private string _Phone;
        public string Phone
        {
            get { return _Phone; }
            set
            {
                _Phone = value;
            }
        }
    }
    #endregion
}