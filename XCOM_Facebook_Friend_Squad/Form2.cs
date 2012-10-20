using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XCOM_Facebook_Friend_Squad
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Goes to the Graph API Explorer
            try
            {
                System.Diagnostics.Process.Start("https://developers.facebook.com/tools/explorer?method=GET&path=596462119%3Ffields%3Did%2Cname%2Chometown%2Cfriends.name%2Cfriends.gender%2Cfriends.location");
            }
            catch { }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void authBtn_Click(object sender, EventArgs e)
        {
            if (accessTokenTxtBox.Text == "" || accessTokenTxtBox.Text == null)
            {
                MessageBox.Show("You did not enter an Access Token!", "Access Token Error",
MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Form1 mainForm = new Form1();
                mainForm.Show();
                this.Hide();
            }
        }
    }
}
