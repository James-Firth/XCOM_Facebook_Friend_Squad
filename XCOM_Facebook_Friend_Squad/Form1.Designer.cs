namespace XCOM_Facebook_Friend_Squad
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
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Canada", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("USA", System.Windows.Forms.HorizontalAlignment.Left);
            this.loginBtn = new System.Windows.Forms.Button();
            this.outputText = new System.Windows.Forms.Label();
            this.friendsList = new System.Windows.Forms.ListView();
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colGender = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // loginBtn
            // 
            this.loginBtn.Location = new System.Drawing.Point(213, 62);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(75, 23);
            this.loginBtn.TabIndex = 3;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // outputText
            // 
            this.outputText.AutoSize = true;
            this.outputText.Location = new System.Drawing.Point(65, 258);
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
            listViewGroup1.Header = "Canada";
            listViewGroup1.Name = "Canada";
            listViewGroup2.Header = "USA";
            listViewGroup2.Name = "USA";
            this.friendsList.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2});
            this.friendsList.Location = new System.Drawing.Point(213, 117);
            this.friendsList.Name = "friendsList";
            this.friendsList.Size = new System.Drawing.Size(413, 330);
            this.friendsList.TabIndex = 5;
            this.friendsList.UseCompatibleStateImageBehavior = false;
            this.friendsList.View = System.Windows.Forms.View.Details;
            // 
            // colName
            // 
            this.colName.Text = "Name";
            // 
            // colGender
            // 
            this.colGender.Text = "Gender";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 659);
            this.Controls.Add(this.friendsList);
            this.Controls.Add(this.outputText);
            this.Controls.Add(this.loginBtn);
            this.Name = "Form1";
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
    }
}

