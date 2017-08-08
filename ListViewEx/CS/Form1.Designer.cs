namespace ListViewEx
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "Austria",
            "83,870",
            "8,192,880",
            "Vienna"}, 1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "Belgium",
            "30,528",
            "10,379,067",
            "Brussels"}, 2);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "Cyprus",
            "3,571",
            "784,301",
            "Nicosia"}, 3);
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem(new string[] {
            "Czech Republic",
            "30,450",
            "10,235,455",
            "Prague"}, 4);
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem(new string[] {
            "Denmark",
            "16,639",
            "5,450,661",
            "Copenhagen"}, 5);
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem(new string[] {
            "Estonia",
            "17,462\t",
            "1,324,333",
            "Tallinn"}, 6);
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem(new string[] {
            "Finland",
            "130,558",
            "5,231,372",
            "Helsinki"}, 7);
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem(new string[] {
            "France",
            "211,208",
            "60,876,136",
            "Paris"}, 8);
            System.Windows.Forms.ListViewItem listViewItem9 = new System.Windows.Forms.ListViewItem(new string[] {
            "Germany",
            "137,846",
            "82,422,299",
            "Berlin"}, 9);
            System.Windows.Forms.ListViewItem listViewItem10 = new System.Windows.Forms.ListViewItem(new string[] {
            "Greece",
            "50,942",
            "10,688,058",
            "Athens"}, 10);
            System.Windows.Forms.ListViewItem listViewItem11 = new System.Windows.Forms.ListViewItem(new string[] {
            "Hungary",
            "35,919",
            "9,981,334",
            "Budapest"}, 11);
            System.Windows.Forms.ListViewItem listViewItem12 = new System.Windows.Forms.ListViewItem(new string[] {
            "Ireland",
            "27,135\t",
            "4,062,235",
            "Dublin"}, 12);
            System.Windows.Forms.ListViewItem listViewItem13 = new System.Windows.Forms.ListViewItem(new string[] {
            "Italy",
            "116,305",
            "58,133,509",
            "Rome"}, 13);
            System.Windows.Forms.ListViewItem listViewItem14 = new System.Windows.Forms.ListViewItem(new string[] {
            "Latvia",
            "24,938",
            "2,274,735",
            "Riga"}, 14);
            System.Windows.Forms.ListViewItem listViewItem15 = new System.Windows.Forms.ListViewItem(new string[] {
            "Lithuania",
            "25,174",
            "3,585,906",
            "Vilnius"}, 15);
            System.Windows.Forms.ListViewItem listViewItem16 = new System.Windows.Forms.ListViewItem(new string[] {
            "Luxembourg",
            "998",
            "474,413",
            "Luxembourg"}, 16);
            System.Windows.Forms.ListViewItem listViewItem17 = new System.Windows.Forms.ListViewItem(new string[] {
            "Malta",
            "122",
            "400,214",
            "Valletta"}, 17);
            System.Windows.Forms.ListViewItem listViewItem18 = new System.Windows.Forms.ListViewItem(new string[] {
            "Netherlands",
            "16,033\t",
            "16,491,461",
            "Amsterdam"}, 18);
            System.Windows.Forms.ListViewItem listViewItem19 = new System.Windows.Forms.ListViewItem(new string[] {
            "United Kingdom",
            "94,525\t",
            "60,609,153",
            "London"}, 25);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listViewEx1 = new DevComponents.DotNetBar.Controls.ListViewEx();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.SuspendLayout();
            // 
            // listViewEx1
            // 
            // 
            // 
            // 
            this.listViewEx1.Border.Class = "ListViewBorder";
            this.listViewEx1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listViewEx1.FullRowSelect = true;
            this.listViewEx1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5,
            listViewItem6,
            listViewItem7,
            listViewItem8,
            listViewItem9,
            listViewItem10,
            listViewItem11,
            listViewItem12,
            listViewItem13,
            listViewItem14,
            listViewItem15,
            listViewItem16,
            listViewItem17,
            listViewItem18,
            listViewItem19});
            this.listViewEx1.Location = new System.Drawing.Point(6, 8);
            this.listViewEx1.Name = "listViewEx1";
            this.listViewEx1.Size = new System.Drawing.Size(418, 258);
            this.listViewEx1.SmallImageList = this.imageList1;
            this.listViewEx1.TabIndex = 0;
            this.listViewEx1.UseCompatibleStateImageBehavior = false;
            this.listViewEx1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Country";
            this.columnHeader1.Width = 124;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Area (km²)";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader2.Width = 86;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Population";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader3.Width = 86;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Capital";
            this.columnHeader4.Width = 96;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "EC.ico");
            this.imageList1.Images.SetKeyName(1, "FLGAUSTA.ICO");
            this.imageList1.Images.SetKeyName(2, "FLGBELG.ICO");
            this.imageList1.Images.SetKeyName(3, "FLGCYPR.ico");
            this.imageList1.Images.SetKeyName(4, "FLGCZECH.ico");
            this.imageList1.Images.SetKeyName(5, "FLGDEN.ICO");
            this.imageList1.Images.SetKeyName(6, "FLGEST.ico");
            this.imageList1.Images.SetKeyName(7, "FLGFIN.ICO");
            this.imageList1.Images.SetKeyName(8, "FLGFRAN.ICO");
            this.imageList1.Images.SetKeyName(9, "FLGGERM.ICO");
            this.imageList1.Images.SetKeyName(10, "FLGGREEC.ico");
            this.imageList1.Images.SetKeyName(11, "FLGHUNG.ico");
            this.imageList1.Images.SetKeyName(12, "FLGIREL.ICO");
            this.imageList1.Images.SetKeyName(13, "FLGITALY.ICO");
            this.imageList1.Images.SetKeyName(14, "FLGLATV.ico");
            this.imageList1.Images.SetKeyName(15, "FLGLITH.ico");
            this.imageList1.Images.SetKeyName(16, "FLGLUX.ICO");
            this.imageList1.Images.SetKeyName(17, "FLGMALTA.ico");
            this.imageList1.Images.SetKeyName(18, "FLGNETH.ICO");
            this.imageList1.Images.SetKeyName(19, "FLGPOL.ico");
            this.imageList1.Images.SetKeyName(20, "FLGPORT.ICO");
            this.imageList1.Images.SetKeyName(21, "FLGSLK.ico");
            this.imageList1.Images.SetKeyName(22, "FLGSLO.ico");
            this.imageList1.Images.SetKeyName(23, "FLGSPAIN.ICO");
            this.imageList1.Images.SetKeyName(24, "FLGSWED.ICO");
            this.imageList1.Images.SetKeyName(25, "FLGUK.ICO");
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.Location = new System.Drawing.Point(345, 274);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(78, 24);
            this.buttonX1.TabIndex = 1;
            this.buttonX1.Text = "&Close";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 303);
            this.Controls.Add(this.buttonX1);
            this.Controls.Add(this.listViewEx1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "ListViewEx Sample";
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.ListViewEx listViewEx1;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}

