namespace XCOM_Facebook_Friend_Squad
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Canada", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("USA", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup3 = new System.Windows.Forms.ListViewGroup("Africa", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup4 = new System.Windows.Forms.ListViewGroup("Asia", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup5 = new System.Windows.Forms.ListViewGroup("Europe", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup6 = new System.Windows.Forms.ListViewGroup("North America", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup7 = new System.Windows.Forms.ListViewGroup("South America", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("Argentina", 0);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("Australia", 1);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "Canada",
            "Canada"}, 4);
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("Egypt", 6);
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("Nigeria", 17);
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem("South Africa", 22);
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem("China", 5);
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem("India", 10);
            System.Windows.Forms.ListViewItem listViewItem9 = new System.Windows.Forms.ListViewItem("Israel", 12);
            System.Windows.Forms.ListViewItem listViewItem10 = new System.Windows.Forms.ListViewItem("Japan", 14);
            System.Windows.Forms.ListViewItem listViewItem11 = new System.Windows.Forms.ListViewItem("Saudi Arabia", 20);
            System.Windows.Forms.ListViewItem listViewItem12 = new System.Windows.Forms.ListViewItem("South Korea", 23);
            System.Windows.Forms.ListViewItem listViewItem13 = new System.Windows.Forms.ListViewItem("Belgium", 2);
            System.Windows.Forms.ListViewItem listViewItem14 = new System.Windows.Forms.ListViewItem("France", 7);
            System.Windows.Forms.ListViewItem listViewItem15 = new System.Windows.Forms.ListViewItem("Germany", 8);
            System.Windows.Forms.ListViewItem listViewItem16 = new System.Windows.Forms.ListViewItem("Greece", 9);
            System.Windows.Forms.ListViewItem listViewItem17 = new System.Windows.Forms.ListViewItem("Ireland", 11);
            System.Windows.Forms.ListViewItem listViewItem18 = new System.Windows.Forms.ListViewItem("Italy", 13);
            System.Windows.Forms.ListViewItem listViewItem19 = new System.Windows.Forms.ListViewItem("Netherlands", 19);
            System.Windows.Forms.ListViewItem listViewItem20 = new System.Windows.Forms.ListViewItem("Norway", 18);
            System.Windows.Forms.ListViewItem listViewItem21 = new System.Windows.Forms.ListViewItem("Russia", 19);
            System.Windows.Forms.ListViewItem listViewItem22 = new System.Windows.Forms.ListViewItem("Scotland", 21);
            System.Windows.Forms.ListViewItem listViewItem23 = new System.Windows.Forms.ListViewItem("Spain", 24);
            System.Windows.Forms.ListViewItem listViewItem24 = new System.Windows.Forms.ListViewItem("Sweden", 25);
            System.Windows.Forms.ListViewItem listViewItem25 = new System.Windows.Forms.ListViewItem("UK", 26);
            System.Windows.Forms.ListViewItem listViewItem26 = new System.Windows.Forms.ListViewItem("Ukraine", 27);
            System.Windows.Forms.ListViewItem listViewItem27 = new System.Windows.Forms.ListViewItem("Mexico", 15);
            System.Windows.Forms.ListViewItem listViewItem28 = new System.Windows.Forms.ListViewItem("USA", 28);
            System.Windows.Forms.ListViewItem listViewItem29 = new System.Windows.Forms.ListViewItem("Brazil", 3);
            this.loginBtn = new System.Windows.Forms.Button();
            this.outputText = new System.Windows.Forms.Label();
            this.friendsList = new System.Windows.Forms.ListView();
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colGender = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSaveAll = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSelectAll = new System.Windows.Forms.Button();
            this.listFlags = new System.Windows.Forms.ListView();
            this.imglistFlags = new System.Windows.Forms.ImageList(this.components);
            this.btnSelectAllFlags = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loginBtn
            // 
            this.loginBtn.Location = new System.Drawing.Point(40, 12);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(91, 33);
            this.loginBtn.TabIndex = 3;
            this.loginBtn.Text = "Get Friends";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // outputText
            // 
            this.outputText.AutoSize = true;
            this.outputText.Location = new System.Drawing.Point(381, 51);
            this.outputText.Name = "outputText";
            this.outputText.Size = new System.Drawing.Size(236, 91);
            this.outputText.TabIndex = 4;
            this.outputText.Text = resources.GetString("outputText.Text");
            // 
            // friendsList
            // 
            this.friendsList.CheckBoxes = true;
            this.friendsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colName,
            this.colGender});
            this.friendsList.FullRowSelect = true;
            this.friendsList.GridLines = true;
            listViewGroup1.Header = "Canada";
            listViewGroup1.Name = "Canada";
            listViewGroup2.Header = "USA";
            listViewGroup2.Name = "USA";
            this.friendsList.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2});
            this.friendsList.Location = new System.Drawing.Point(40, 51);
            this.friendsList.Name = "friendsList";
            this.friendsList.Size = new System.Drawing.Size(335, 513);
            this.friendsList.TabIndex = 5;
            this.friendsList.UseCompatibleStateImageBehavior = false;
            this.friendsList.View = System.Windows.Forms.View.Details;
            // 
            // colName
            // 
            this.colName.Text = "Name";
            this.colName.Width = 195;
            // 
            // colGender
            // 
            this.colGender.Text = "Gender";
            this.colGender.Width = 78;
            // 
            // btnSaveAll
            // 
            this.btnSaveAll.Location = new System.Drawing.Point(381, 719);
            this.btnSaveAll.Name = "btnSaveAll";
            this.btnSaveAll.Size = new System.Drawing.Size(181, 23);
            this.btnSaveAll.TabIndex = 6;
            this.btnSaveAll.Text = "Save Selected Names";
            this.btnSaveAll.UseVisualStyleBackColor = true;
            this.btnSaveAll.Click += new System.EventHandler(this.btnSaveAll_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(686, 689);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "EMERGENCY EXIT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.Location = new System.Drawing.Point(40, 570);
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.Size = new System.Drawing.Size(75, 23);
            this.btnSelectAll.TabIndex = 9;
            this.btnSelectAll.Text = "Select All Soldiers";
            this.btnSelectAll.UseVisualStyleBackColor = true;
            this.btnSelectAll.Click += new System.EventHandler(this.btnSelectAll_Click);
            // 
            // listFlags
            // 
            this.listFlags.CheckBoxes = true;
            this.listFlags.GridLines = true;
            listViewGroup3.Header = "Africa";
            listViewGroup3.Name = "listgrpAfrica";
            listViewGroup4.Header = "Asia";
            listViewGroup4.Name = "listgrpAsia";
            listViewGroup5.Header = "Europe";
            listViewGroup5.Name = "listgrpEurope";
            listViewGroup6.Header = "North America";
            listViewGroup6.Name = "listgrpNorthAmerica";
            listViewGroup7.Header = "South America";
            listViewGroup7.Name = "listgrpSouthAmerica";
            this.listFlags.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup3,
            listViewGroup4,
            listViewGroup5,
            listViewGroup6,
            listViewGroup7});
            listViewItem1.Group = listViewGroup7;
            listViewItem1.StateImageIndex = 0;
            listViewItem2.Group = listViewGroup4;
            listViewItem2.StateImageIndex = 0;
            listViewItem3.Group = listViewGroup6;
            listViewItem3.StateImageIndex = 0;
            listViewItem4.Group = listViewGroup3;
            listViewItem4.StateImageIndex = 0;
            listViewItem5.Group = listViewGroup3;
            listViewItem5.StateImageIndex = 0;
            listViewItem6.Group = listViewGroup3;
            listViewItem6.StateImageIndex = 0;
            listViewItem7.Group = listViewGroup4;
            listViewItem7.StateImageIndex = 0;
            listViewItem8.Group = listViewGroup4;
            listViewItem8.StateImageIndex = 0;
            listViewItem9.Group = listViewGroup4;
            listViewItem9.StateImageIndex = 0;
            listViewItem10.Group = listViewGroup4;
            listViewItem10.StateImageIndex = 0;
            listViewItem11.Group = listViewGroup4;
            listViewItem11.StateImageIndex = 0;
            listViewItem12.Group = listViewGroup4;
            listViewItem12.StateImageIndex = 0;
            listViewItem13.Group = listViewGroup5;
            listViewItem13.StateImageIndex = 0;
            listViewItem14.Group = listViewGroup5;
            listViewItem14.StateImageIndex = 0;
            listViewItem15.Group = listViewGroup5;
            listViewItem15.StateImageIndex = 0;
            listViewItem16.Group = listViewGroup5;
            listViewItem16.StateImageIndex = 0;
            listViewItem17.Group = listViewGroup5;
            listViewItem17.StateImageIndex = 0;
            listViewItem18.Group = listViewGroup5;
            listViewItem18.StateImageIndex = 0;
            listViewItem19.Group = listViewGroup5;
            listViewItem19.StateImageIndex = 0;
            listViewItem20.Group = listViewGroup5;
            listViewItem20.StateImageIndex = 0;
            listViewItem21.Group = listViewGroup5;
            listViewItem21.StateImageIndex = 0;
            listViewItem22.Group = listViewGroup5;
            listViewItem22.StateImageIndex = 0;
            listViewItem23.Group = listViewGroup5;
            listViewItem23.StateImageIndex = 0;
            listViewItem24.Group = listViewGroup5;
            listViewItem24.StateImageIndex = 0;
            listViewItem25.Group = listViewGroup5;
            listViewItem25.StateImageIndex = 0;
            listViewItem26.Group = listViewGroup5;
            listViewItem26.StateImageIndex = 0;
            listViewItem27.Group = listViewGroup6;
            listViewItem27.StateImageIndex = 0;
            listViewItem28.Group = listViewGroup6;
            listViewItem28.StateImageIndex = 0;
            listViewItem29.Group = listViewGroup7;
            listViewItem29.StateImageIndex = 0;
            this.listFlags.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
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
            listViewItem19,
            listViewItem20,
            listViewItem21,
            listViewItem22,
            listViewItem23,
            listViewItem24,
            listViewItem25,
            listViewItem26,
            listViewItem27,
            listViewItem28,
            listViewItem29});
            this.listFlags.Location = new System.Drawing.Point(381, 145);
            this.listFlags.Name = "listFlags";
            this.listFlags.Size = new System.Drawing.Size(181, 419);
            this.listFlags.SmallImageList = this.imglistFlags;
            this.listFlags.TabIndex = 11;
            this.listFlags.UseCompatibleStateImageBehavior = false;
            this.listFlags.View = System.Windows.Forms.View.SmallIcon;
            // 
            // imglistFlags
            // 
            this.imglistFlags.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglistFlags.ImageStream")));
            this.imglistFlags.TransparentColor = System.Drawing.Color.Transparent;
            this.imglistFlags.Images.SetKeyName(0, "40px-Flag_of_Argentina_(bordered).png");
            this.imglistFlags.Images.SetKeyName(1, "40px-Flag_of_Australia.png");
            this.imglistFlags.Images.SetKeyName(2, "40px-Flag_of_Belgium.png");
            this.imglistFlags.Images.SetKeyName(3, "40px-Flag_of_Brazil.png");
            this.imglistFlags.Images.SetKeyName(4, "40px-Flag_of_Canada.png");
            this.imglistFlags.Images.SetKeyName(5, "40px-Flag_of_China.png");
            this.imglistFlags.Images.SetKeyName(6, "40px-Flag_of_Egypt.png");
            this.imglistFlags.Images.SetKeyName(7, "40px-Flag_of_France.png");
            this.imglistFlags.Images.SetKeyName(8, "40px-Flag_of_Germany.png");
            this.imglistFlags.Images.SetKeyName(9, "40px-Flag_of_Greece.png");
            this.imglistFlags.Images.SetKeyName(10, "40px-Flag_of_India.png");
            this.imglistFlags.Images.SetKeyName(11, "40px-Flag_of_Ireland.png");
            this.imglistFlags.Images.SetKeyName(12, "40px-Flag_of_Israel.png");
            this.imglistFlags.Images.SetKeyName(13, "40px-Flag_of_Italy.png");
            this.imglistFlags.Images.SetKeyName(14, "40px-Flag_of_Japan.png");
            this.imglistFlags.Images.SetKeyName(15, "40px-Flag_of_Mexico.png");
            this.imglistFlags.Images.SetKeyName(16, "40px-Flag_of_Netherlands.png");
            this.imglistFlags.Images.SetKeyName(17, "40px-Flag_of_Nigeria.png");
            this.imglistFlags.Images.SetKeyName(18, "40px-Flag_of_Norway.png");
            this.imglistFlags.Images.SetKeyName(19, "40px-Flag_of_Russia.png");
            this.imglistFlags.Images.SetKeyName(20, "40px-Flag_of_Saudi_Arabia.png");
            this.imglistFlags.Images.SetKeyName(21, "40px-Flag_of_Scotland.png");
            this.imglistFlags.Images.SetKeyName(22, "40px-Flag_of_South_Africa.png");
            this.imglistFlags.Images.SetKeyName(23, "40px-Flag_of_South_Korea.png");
            this.imglistFlags.Images.SetKeyName(24, "40px-Flag_of_Spain.png");
            this.imglistFlags.Images.SetKeyName(25, "40px-Flag_of_Sweden.png");
            this.imglistFlags.Images.SetKeyName(26, "40px-Flag_of_UK.png");
            this.imglistFlags.Images.SetKeyName(27, "40px-Flag_of_Ukraine.png");
            this.imglistFlags.Images.SetKeyName(28, "40px-Flag_of_USA.png");
            // 
            // btnSelectAllFlags
            // 
            this.btnSelectAllFlags.Location = new System.Drawing.Point(381, 570);
            this.btnSelectAllFlags.Name = "btnSelectAllFlags";
            this.btnSelectAllFlags.Size = new System.Drawing.Size(181, 23);
            this.btnSelectAllFlags.TabIndex = 12;
            this.btnSelectAllFlags.Text = "Select All Countries";
            this.btnSelectAllFlags.UseVisualStyleBackColor = true;
            this.btnSelectAllFlags.Click += new System.EventHandler(this.btnSelectAllFlags_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 754);
            this.Controls.Add(this.btnSelectAllFlags);
            this.Controls.Add(this.listFlags);
            this.Controls.Add(this.btnSelectAll);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSaveAll);
            this.Controls.Add(this.friendsList);
            this.Controls.Add(this.outputText);
            this.Controls.Add(this.loginBtn);
            this.Name = "MainWindow";
            this.Text = "X-COM: FRIENDS KNOWN";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Label outputText;
        private System.Windows.Forms.ListView friendsList;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colGender;
        private System.Windows.Forms.Button btnSaveAll;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSelectAll;
        private System.Windows.Forms.ListView listFlags;
        private System.Windows.Forms.ImageList imglistFlags;
        private System.Windows.Forms.Button btnSelectAllFlags;
    }
}

