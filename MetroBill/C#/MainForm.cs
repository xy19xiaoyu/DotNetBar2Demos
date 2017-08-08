using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar.Metro;
using DevComponents.DotNetBar;
using System.Diagnostics;
using DevComponents.AdvTree;
using DevComponents.DotNetBar.Metro.ColorTables;

namespace MetroBill
{
    public partial class MainForm : MetroAppForm
    {
        StartControl _StartControl = null; // Start control displayed on startup
        MetroBillCommands _Commands = null; // All application commands
        public MainForm()
        {
            InitializeComponent();
            
            // Prepare commands
            _Commands = new MetroBillCommands();

            _Commands.ToggleStartControl = new Command(components);
            _Commands.ToggleStartControl.Executed += new EventHandler(ToggleStartControlExecuted);

            // Initialize Client related commands
            _Commands.ClientCommands.New = new Command(components); // We pass in components from Form so the command gets disposed automatically when form is disposed
            _Commands.ClientCommands.New.Executed += NewClientExecuted;
            _Commands.ClientCommands.Cancel = new Command(components);
            _Commands.ClientCommands.Cancel.Executed += CancelClientExecuted;
            _Commands.ClientCommands.Save = new Command(components);
            _Commands.ClientCommands.Save.Executed += SaveClientExecuted;
            // Invoice related commands
            _Commands.InvoiceCommands.New = new Command(components); // We pass in components from Form so the command gets disposed automatically when form is disposed
            _Commands.InvoiceCommands.New.Executed += NewInvoiceExecuted;
            _Commands.InvoiceCommands.Cancel = new Command(components);
            _Commands.InvoiceCommands.Cancel.Executed += CancelInvoiceExecuted;
            _Commands.InvoiceCommands.Save = new Command(components);
            _Commands.InvoiceCommands.Save.Executed += SaveInvoiceExecuted;
            // General commands
            _Commands.ChangeMetroTheme = new Command(components, new EventHandler(ChangeMetroThemeExecuted));
            _Commands.NotImplemented = new Command(components, new EventHandler(NotImplementedExecuted));
            _Commands.DevComponents = new Command(components, new EventHandler(DevComponentsExecuted));
            _Commands.GettingStartedCommand = new Command(components, new EventHandler(GettingStartedExecuted));

            this.SuspendLayout();
            _StartControl = new StartControl();
            _StartControl.Commands = _Commands;
            this.Controls.Add(_StartControl);
            _StartControl.BringToFront();
            _StartControl.SlideSide = DevComponents.DotNetBar.Controls.eSlideSide.Right;
            _StartControl.Click += new EventHandler(StartControl_Click);
            this.ResumeLayout(false);

            // Assign commands to toolbar buttons
            newInvoiceButton.Command = _Commands.InvoiceCommands.New;
            newClientButton.Command = _Commands.ClientCommands.New;

            // Add metro color themes
            MetroColorGeneratorParameters[] metroThemes = MetroColorGeneratorParameters.GetAllPredefinedThemes();
            foreach (MetroColorGeneratorParameters mt in metroThemes)
            {
                ButtonItem theme = new ButtonItem(mt.ThemeName, mt.ThemeName);
                theme.Command = _Commands.ChangeMetroTheme;
                theme.CommandParameter = mt;
                colorThemeButton.SubItems.Add(theme);
            }

            AddSampleData();
        }

        #region Command Execution
        
        private void GettingStartedExecuted(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.devcomponents.com/kb2/?p=1160");
        }
        private void NotImplementedExecuted(object sender, EventArgs e)
        {
            MessageBoxEx.Show(this, "Placeholder for real action. This command is not implemented.", "Metro Bill", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void DevComponentsExecuted(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.devcomponents.com/dotnetbar/");
        }

        private void ChangeMetroThemeExecuted(object sender, EventArgs e)
        {
            ICommandSource source = (ICommandSource)sender;
            MetroColorGeneratorParameters theme = (MetroColorGeneratorParameters)source.CommandParameter;
            StyleManager.MetroColorGeneratorParameters = theme;
        }

        private void ToggleStartControlExecuted(object sender, EventArgs e)
        {
            _StartControl.IsOpen = !_StartControl.IsOpen;
        }

        ClientControl _ClientControl = null;
        void NewClientExecuted(object sender, EventArgs e)
        {
            Debug.Assert(_ClientControl == null);
            _Commands.ClientCommands.New.Enabled = false; // Disable new client command to prevent re-entrancy
            _ClientControl = new ClientControl();
            _ClientControl.Commands = _Commands;
            this.ShowModalPanel(_ClientControl, DevComponents.DotNetBar.Controls.eSlideSide.Left);
            if (!_StartControl.Visible)
                _StartControl.SlideOutButtonVisible = false;
        }
        private void CancelClientExecuted(object sender, EventArgs e)
        {
            // Simply close client entry form "dialog"
            Debug.Assert(_ClientControl != null);
            CloseClientDialog();
        }
        private void CloseClientDialog()
        {
            if (!_StartControl.Visible)
                _StartControl.SlideOutButtonVisible = true;
            
            _Commands.ClientCommands.New.Enabled = true; // Enable new client command

            this.CloseModalPanel(_ClientControl, DevComponents.DotNetBar.Controls.eSlideSide.Left);
            _ClientControl.Commands = null;
            _ClientControl.Dispose();
            _ClientControl = null;
        }
        void SaveClientExecuted(object sender, EventArgs e)
        {
            // Here we would save new client to the storage of choice then close the "dialog"
            CloseClientDialog();
        }

        InvoiceControl _InvoiceControl = null;
        void NewInvoiceExecuted(object sender, EventArgs e)
        {
            Debug.Assert(_InvoiceControl == null);
            _Commands.InvoiceCommands.New.Enabled = false; // Disable new invoice command to prevent re-entrancy
            _InvoiceControl = new InvoiceControl();
            _InvoiceControl.Commands = _Commands;
            this.ShowModalPanel(_InvoiceControl, DevComponents.DotNetBar.Controls.eSlideSide.Left);
            if (!_StartControl.Visible)
                _StartControl.SlideOutButtonVisible = false;
        }
        private void CancelInvoiceExecuted(object sender, EventArgs e)
        {
            // Simply close invoice entry form "dialog"
            Debug.Assert(_InvoiceControl != null);
            CloseInvoiceDialog();
        }
        private void CloseInvoiceDialog()
        {
            if (!_StartControl.Visible)
                _StartControl.SlideOutButtonVisible = true;
            
            _Commands.InvoiceCommands.New.Enabled = true; // Enable new invoice command

            this.CloseModalPanel(_InvoiceControl, DevComponents.DotNetBar.Controls.eSlideSide.Left);
            _InvoiceControl.Commands = null;
            _InvoiceControl.Dispose();
            _InvoiceControl = null;
        }
        void SaveInvoiceExecuted(object sender, EventArgs e)
        {
            // Here we would save new invoice to the storage of choice then close the "dialog"
            CloseInvoiceDialog();
        }
        #endregion

        #region Sample Data Handling
        private void AddSampleData()
        {
            // Add sample clients
            advTree2.Nodes.Add(CreateClientRow("Acme Construction", "Berlin, Germany", 9090));
            advTree2.Nodes.Add(CreateClientRow("Micro Services Advantage", "Boston, USA", 7890));
            advTree2.Nodes.Add(CreateClientRow("Will E. Otty", "Seattle, USA", 5000));
            advTree2.Nodes.Add(CreateClientRow("Custom Development Services", "Detroit, USA", 11000));
            advTree2.Nodes.Add(CreateClientRow("CERT", "Sarajevo, B&H", 1500));
            advTree2.Nodes.Add(CreateClientRow("R Entertainment Inc.", "Los Angeles, USA", 15000));
            advTree2.Nodes.Add(CreateClientRow("Shift Enterprises", "San Francisco, USA", 12000));
            advTree2.Nodes.Add(CreateClientRow("Orange Corporation", "Boston, USA", 15000));
            advTree2.Nodes.Add(CreateClientRow("Cherry Inc", "Los Angeles, USA", 1000));
            advTree2.Nodes.Add(CreateClientRow("RoW Enterprise", "Los Angeles, USA", 1300));
            advTree2.Nodes.Add(CreateClientRow("24-7 Plumbing", "Bellevue, USA", 1000));

            // Add invoices
            advTree1.Nodes.Add(CreateInvoiceRow(DateTime.Today, "Will E. Otty", 1250, "Invoice1"));
            advTree1.Nodes.Add(CreateInvoiceRow(DateTime.Today.AddDays(-1), "Micro Service Advantage", 4500, "Invoice2"));
            advTree1.Nodes.Add(CreateInvoiceRow(DateTime.Today.AddDays(-10), "Acme Construction", 7500, "Invoice3"));
            advTree1.Nodes.Add(CreateInvoiceRow(DateTime.Today.AddDays(-12), "Custom Development Services", 500, "Invoice4"));
            advTree1.Nodes.Add(CreateInvoiceRow(DateTime.Today.AddDays(-14), "CERT", 1500, "Invoice5"));
            advTree1.Nodes.Add(CreateInvoiceRow(DateTime.Today.AddDays(-15), "R Entertainment Inc.", 1000, "Invoice6"));
            advTree1.Nodes.Add(CreateInvoiceRow(DateTime.Today.AddDays(-15), "Shift Enterprises", 1700, "Invoice7"));
            advTree1.Nodes.Add(CreateInvoiceRow(DateTime.Today.AddDays(-15), "Will E. Otty", 2250, "Invoice1"));
            advTree1.Nodes.Add(CreateInvoiceRow(DateTime.Today.AddDays(-16), "Micro Service Advantage", 2580, "Invoice2"));
            advTree1.Nodes.Add(CreateInvoiceRow(DateTime.Today.AddDays(-16), "Acme Construction", 7100, "Invoice3"));
            advTree1.Nodes.Add(CreateInvoiceRow(DateTime.Today.AddDays(-18), "Custom Development Services", 1500, "Invoice4"));
            advTree1.Nodes.Add(CreateInvoiceRow(DateTime.Today.AddDays(-19), "CERT", 1900, "Invoice5"));
            advTree1.Nodes.Add(CreateInvoiceRow(DateTime.Today.AddDays(-20), "R Entertainment Inc.", 1010, "Invoice6"));
            advTree1.Nodes.Add(CreateInvoiceRow(DateTime.Today.AddDays(-21), "Shift Enterprises", 1900, "Invoice7"));
        }
        private Node CreateClientRow(string clientName, string location, double totalInvoiced)
        {
            Node node = new Node(clientName);
            node.Cells.Add(new Cell(location));
            node.Cells.Add(new Cell(totalInvoiced.ToString("C")));
            return node;
        }
        private Node CreateInvoiceRow(DateTime date, string clientName, double invoiceAmount, string invoiceFileName)
        {
            Node node = new Node(date.ToShortDateString());
            node.Cells.Add(new Cell(clientName));
            node.Cells.Add(new Cell(invoiceAmount.ToString("C")));
            node.Tag = invoiceFileName;
            return node;
        }
        private void advTree1_AfterNodeSelect(object sender, AdvTreeNodeEventArgs e)
        {
            Node node = e.Node;
            if (!string.IsNullOrEmpty((string)node.Tag))
            {
                richTextBox1.Rtf = ResourceManager.GetString((string)node.Tag);
            }
            else
                richTextBox1.Text = "";
        }
        private static global::System.Resources.ResourceManager resourceMan;
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("MetroBill.Properties.Resources", typeof(MetroBill.Properties.Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        #endregion

        #region UI Code
        void StartControl_Click(object sender, EventArgs e)
        {
            _StartControl.IsOpen = false;
        }

        protected override void OnLoad(EventArgs e)
        {
            UpdateControlsSizeAndLocation();
            base.OnLoad(e);
        }

        private Rectangle GetStartControlBounds()
        {
            int captionHeight = metroShell1.MetroTabStrip.GetCaptionHeight() + 2;
            Thickness borderThickness = this.GetBorderThickness();
            return new Rectangle((int)borderThickness.Left, captionHeight, this.Width - (int)borderThickness.Horizontal, this.Height - captionHeight - 1);
        }
        private void UpdateControlsSizeAndLocation()
        {
            if (_StartControl != null)
            {
                if (!_StartControl.IsOpen)
                    _StartControl.OpenBounds = GetStartControlBounds();
                else
                    _StartControl.Bounds = GetStartControlBounds();
                if (!IsModalPanelDisplayed)
                    _StartControl.BringToFront();
            }
            metroToolbar1.Location = new Point((this.Width - metroToolbar1.Width) / 2, metroToolbar1.Parent.Height - metroToolbar1.Height - 1);
            metroToolbar2.Location = new Point((this.Width - metroToolbar2.Width) / 2, metroToolbar2.Parent.Height - metroToolbar2.Height - 1);
        }
        protected override void OnResize(EventArgs e)
        {
            UpdateControlsSizeAndLocation();
            base.OnResize(e);
        }

        private void metroAppButton1_ExpandChange(object sender, EventArgs e)
        {
            if (!_StartControl.Visible)
                _StartControl.SlideOutButtonVisible = !metroAppButton1.Expanded;
        }

        private void metroShell1_SettingsButtonClick(object sender, EventArgs e)
        {
            MessageBoxEx.Show(this, "MetroShell Settings Button Clicked", "Metro Bill", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void metroShell1_HelpButtonClick(object sender, EventArgs e)
        {
            MessageBoxEx.Show(this, "MetroShell Help Button Clicked", "Metro Bill", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void metroShell1_SelectedTabChanged(object sender, EventArgs e)
        {
            UpdateControlsSizeAndLocation();
        }
        #endregion

    }
}