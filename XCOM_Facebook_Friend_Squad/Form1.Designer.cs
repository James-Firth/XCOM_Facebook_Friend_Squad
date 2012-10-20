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
            this.label1 = new System.Windows.Forms.Label();
            this.loginText = new System.Windows.Forms.TextBox();
            this.pwdText = new System.Windows.Forms.TextBox();
            this.loginBtn = new System.Windows.Forms.Button();
            this.outputText = new System.Windows.Forms.Label();
            this.friendDetailsList = new System.Windows.Forms.ListView();
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colGender = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCountry = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "LOGIN:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // loginText
            // 
            this.loginText.Location = new System.Drawing.Point(193, 79);
            this.loginText.Name = "loginText";
            this.loginText.Size = new System.Drawing.Size(186, 20);
            this.loginText.TabIndex = 1;
            // 
            // pwdText
            // 
            this.pwdText.Location = new System.Drawing.Point(193, 116);
            this.pwdText.Name = "pwdText";
            this.pwdText.Size = new System.Drawing.Size(186, 20);
            this.pwdText.TabIndex = 2;
            // 
            // loginBtn
            // 
            this.loginBtn.Location = new System.Drawing.Point(193, 172);
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
            this.outputText.Location = new System.Drawing.Point(130, 262);
            this.outputText.Name = "outputText";
            this.outputText.Size = new System.Drawing.Size(30, 13);
            this.outputText.TabIndex = 4;
            this.outputText.Text = "LIST";
            this.outputText.Click += new System.EventHandler(this.outputText_Click);
            // 
            // friendDetailsList
            // 
            this.friendDetailsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colName,
            this.colGender,
            this.colCountry});
            this.friendDetailsList.Location = new System.Drawing.Point(258, 214);
            this.friendDetailsList.Name = "friendDetailsList";
            this.friendDetailsList.Size = new System.Drawing.Size(413, 330);
            this.friendDetailsList.TabIndex = 5;
            this.friendDetailsList.UseCompatibleStateImageBehavior = false;
            this.friendDetailsList.View = System.Windows.Forms.View.Details;
            // 
            // colName
            // 
            this.colName.Text = "Name";
            // 
            // colGender
            // 
            this.colGender.Text = "Gender";
            // 
            // colCountry
            // 
            this.colCountry.Text = "Country";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(294, 172);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 659);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.friendDetailsList);
            this.Controls.Add(this.outputText);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.pwdText);
            this.Controls.Add(this.loginText);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox loginText;
        private System.Windows.Forms.TextBox pwdText;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Label outputText;
        private System.Windows.Forms.ListView friendDetailsList;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colGender;
        private System.Windows.Forms.ColumnHeader colCountry;
        private System.Windows.Forms.Button button1;
    }
}

