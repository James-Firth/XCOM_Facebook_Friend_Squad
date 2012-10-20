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
            System.Windows.Forms.ListViewGroup listViewGroup3 = new System.Windows.Forms.ListViewGroup("Canada", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup4 = new System.Windows.Forms.ListViewGroup("USA", System.Windows.Forms.HorizontalAlignment.Left);
            this.loginBtn = new System.Windows.Forms.Button();
            this.outputText = new System.Windows.Forms.Label();
            this.friendsList = new System.Windows.Forms.ListView();
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colGender = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSaveAll = new System.Windows.Forms.Button();
            this.btnSaveSome = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
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
            this.outputText.Location = new System.Drawing.Point(402, 139);
            this.outputText.Name = "outputText";
            this.outputText.Size = new System.Drawing.Size(83, 13);
            this.outputText.TabIndex = 4;
            this.outputText.Text = "TEST OUTPUT";
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
            this.btnSaveAll.Location = new System.Drawing.Point(40, 584);
            this.btnSaveAll.Name = "btnSaveAll";
            this.btnSaveAll.Size = new System.Drawing.Size(152, 33);
            this.btnSaveAll.TabIndex = 6;
            this.btnSaveAll.Text = "Save All Friends as Soldiers";
            this.btnSaveAll.UseVisualStyleBackColor = true;
            this.btnSaveAll.Click += new System.EventHandler(this.btnSaveAll_Click);
            // 
            // btnSaveSome
            // 
            this.btnSaveSome.Location = new System.Drawing.Point(216, 584);
            this.btnSaveSome.Name = "btnSaveSome";
            this.btnSaveSome.Size = new System.Drawing.Size(200, 33);
            this.btnSaveSome.TabIndex = 7;
            this.btnSaveSome.Text = "Save Checked Friends as Soldiers";
            this.btnSaveSome.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(423, 593);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 629);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSaveSome);
            this.Controls.Add(this.btnSaveAll);
            this.Controls.Add(this.friendsList);
            this.Controls.Add(this.outputText);
            this.Controls.Add(this.loginBtn);
            this.FormClosing += this.MainWindow_FormClosing;
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
        private System.Windows.Forms.Button btnSaveSome;
        private System.Windows.Forms.Button button1;
    }
}

