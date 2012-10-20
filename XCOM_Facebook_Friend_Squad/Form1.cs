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
            var accessToken = "AAACEdEose0cBABA1GLZAg4rDqwsi61URcErdSRRZBzCfaV4nMAkU01EUwxpz2FtcbHg0wz9jzmXRCw2mZAQZCCnhE7ZA8uEEMe7cd1h9WewZDZD";
            var client = new FacebookClient(accessToken);
            dynamic result = client.Get("me", new { fields = "name,id,friends.name,friends.gender" });
            //dynamic me = client.Get("me.FriendList");
            //string myGender = me.gender;
            //string myName = me.name;
            //outputText.Text = myGender + "\n" + myName;
            //dynamic friendslist = me.FriendList;
            ListViewItem toAdd = new ListViewItem(result.friends.data[0].name);
            ListViewItem.ListViewSubItem temp = new ListViewItem.ListViewSubItem(toAdd, "test");
            ListViewItem.ListViewSubItem temp2 = new ListViewItem.ListViewSubItem(toAdd, "Blah");
            ListViewItem.ListViewSubItem[] temp3 = {temp,temp2);
            //toAdd.

            
            //ListViewItem.ListViewSubItem[] toSubAdd = new ListViewItem.ListViewSubItem[2];
            //toSubAdd[0] = result.friends.data[0].gender;
            //toSubAdd[1] = "Canada"; //result.friends.data[1].
            
            friendDetailsList.Items.Add(toAdd);

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
    }
}
