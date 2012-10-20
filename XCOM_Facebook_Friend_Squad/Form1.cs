using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Facebook;

namespace XCOM_Facebook_Friend_Squad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            var accessToken = "AAACEdEose0cBABTv1aRG2HZCVeeCXZCmZAE2xEPZCsesFelhiRSKyKdxC8nSytoT2ZBAH5YlGxwMHjcZC4ToOk9pC3jnV6vIPBZA6EFZBd0ugQZDZD";
            var client = new FacebookClient(accessToken);
            dynamic result = client.Get("me", new { fields = "name,id,friends.name,friends.gender" });

            
            //dynamic me = client.Get("me.FriendList");
            //string myGender = me.gender;
            //string myName = me.name;
            //outputText.Text = myGender + "\n" + myName;
            //dynamic friendslist = me.FriendList;

            ListViewItem toAdd = new ListViewItem(result.friends.data[0].name);
            friendsList.Items.Add(toAdd);
            friendsList.Items[0].SubItems.Add(result.friends.data[0].gender);
            friendsList.Items[0].Group = friendsList.Groups[1];
            

            
            //ListViewItem.ListViewSubItem[] toSubAdd = new ListViewItem.ListViewSubItem[2];
            //toSubAdd[0] = result.friends.data[0].gender;
            //toSubAdd[1] = "Canada"; //result.friends.data[1].
            
            
            

           // string output = "";
           // while (output != null)
           // {
            //    ListViewItem toAdd = new ListViewItem(result.friends.data[0].
           //     friendDetailsList.Items.Add(
          //  }
            //outputText.Text = result.friends.data.length();
        }

        private void outputText_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("http://google.ca");
            }
            catch { }
        }
    }
}
