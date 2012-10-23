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
            System.Windows.Forms.ListViewGroup listViewGroup3 = new System.Windows.Forms.ListViewGroup("Canada", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup4 = new System.Windows.Forms.ListViewGroup("USA", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("Argentina", 2);
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("Australia", 1);
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem(new string[] {
            "Canada",
            "Canada"}, 0);
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
            this.outputText.Click += new System.EventHandler(this.outputText_Click);
            // 
            // friendsList
            // 
            this.friendsList.CheckBoxes = true;
            this.friendsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colName,
            this.colGender});
            this.friendsList.FullRowSelect = true;
            this.friendsList.GridLines = true;
            listViewGroup3.Header = "Canada";
            listViewGroup3.Name = "Canada";
            listViewGroup4.Header = "USA";
            listViewGroup4.Name = "USA";
            this.friendsList.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup3,
            listViewGroup4});
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
            this.btnSaveAll.Location = new System.Drawing.Point(223, 570);
            this.btnSaveAll.Name = "btnSaveAll";
            this.btnSaveAll.Size = new System.Drawing.Size(152, 23);
            this.btnSaveAll.TabIndex = 6;
            this.btnSaveAll.Text = "Save Selected Names";
            this.btnSaveAll.UseVisualStyleBackColor = true;
            this.btnSaveAll.Click += new System.EventHandler(this.btnSaveAll_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(574, 603);
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
            this.btnSelectAll.Text = "Select All";
            this.btnSelectAll.UseVisualStyleBackColor = true;
            this.btnSelectAll.Click += new System.EventHandler(this.btnSelectAll_Click);
            // 
            // listFlags
            // 
            this.listFlags.CheckBoxes = true;
            this.listFlags.GridLines = true;
            listViewItem4.StateImageIndex = 0;
            listViewItem5.StateImageIndex = 0;
            listViewItem6.StateImageIndex = 0;
            this.listFlags.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem4,
            listViewItem5,
            listViewItem6});
            this.listFlags.Location = new System.Drawing.Point(381, 145);
            this.listFlags.Name = "listFlags";
            this.listFlags.Size = new System.Drawing.Size(137, 232);
            this.listFlags.SmallImageList = this.imglistFlags;
            this.listFlags.TabIndex = 11;
            this.listFlags.UseCompatibleStateImageBehavior = false;
            this.listFlags.View = System.Windows.Forms.View.List;
            // 
            // imglistFlags
            // 
            this.imglistFlags.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglistFlags.ImageStream")));
            this.imglistFlags.TransparentColor = System.Drawing.Color.Transparent;
            this.imglistFlags.Images.SetKeyName(0, "Canada");
            this.imglistFlags.Images.SetKeyName(1, "Australia");
            this.imglistFlags.Images.SetKeyName(2, "Argentina");
            // 
            // btnSelectAllFlags
            // 
            this.btnSelectAllFlags.Location = new System.Drawing.Point(381, 383);
            this.btnSelectAllFlags.Name = "btnSelectAllFlags";
            this.btnSelectAllFlags.Size = new System.Drawing.Size(137, 23);
            this.btnSelectAllFlags.TabIndex = 12;
            this.btnSelectAllFlags.Text = "Select All Countries";
            this.btnSelectAllFlags.UseVisualStyleBackColor = true;
            this.btnSelectAllFlags.Click += new System.EventHandler(this.btnSelectAllFlags_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 629);
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

