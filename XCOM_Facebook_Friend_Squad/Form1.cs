﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Facebook;
using System.IO;

namespace XCOM_Facebook_Friend_Squad
{
    public partial class MainWindow : Form
    {
        private string accessToken;
        private LoginForm parent;

        public MainWindow(string givenAccessToken, LoginForm parent) //Grabs access token and creates
        {
            this.accessToken = givenAccessToken;
            this.parent = parent;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            //Catches any errors with OAuth
            try
            {
                var client = new FacebookClient(accessToken); //creates client based off token
                dynamic result = client.Get("me", new { fields = "name,id,friends.name,friends.gender" }); //grabs tons of data
                dynamic myFriendsList = result.friends.data; //grabs friend data
                int i = 0;
                foreach (dynamic friend in myFriendsList) //loops through all friends
                {
                    ListViewItem toAdd = new ListViewItem(friend.name); //Adds their name and gender...
                    friendsList.Items.Add(toAdd);
                    string gender = friend.gender;
                    friendsList.Items[i].SubItems.Add(gender);
                    friendsList.Items[i].Group = friendsList.Groups[0];//... to the Canada group (need to update)
                    i++;
                }
            }
            catch (Facebook.FacebookOAuthException) //Catches error, displays msg and allows user to fix.
            {
                if (MessageBox.Show("Authentication Failed! Would you like to try re-entering your access token??", "Authentication Error", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // user clicked yes
                    parent.Show();
                    parent.ClearInput();
                    this.Hide();
                }
                else
                {
                    // user clicked no
                }
            }

            
            
            /*
            for (int i=0; i < myFriendsList.data.Count; i++)
            {
                ListViewItem toAdd = new ListViewItem(myFriendsList.data[i].name);
                friendsList.Items.Add(toAdd);
                friendsList.Items[i].SubItems.Add(myFriendsList.data[i].gender);
                friendsList.Items[i].Group = friendsList.Groups[0];
            }
             * */
            
            //dynamic me = client.Get("me.FriendList");
            //string myGender = me.gender;
            //string myName = me.name;
            //outputText.Text = myGender + "\n" + myName;
            //dynamic friendslist = me.FriendList;

            
            

            
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

        private void btnSaveAll_Click(object sender, EventArgs e)
        {

            //Check if the .txt file exists
            string selectnames = "";

            foreach (ListViewItem friend in friendsList.Items)
            {
                if (friend.Checked == true)
                {
                    friend.Name = "CHECKED!";
                    selectnames = selectnames + friend.Name;
                }

            }
            //Check if the orig is saved as .orig
            //If so replace the current .txt
            
            //Check if the file we want to replace exists.
            if (System.IO.File.Exists("C:\\Users\\James\\Documents\\Visual Studio 2012\\Projects\\XCOM_Facebook_Friend_Squad\\Resource Files\\newFile.txt"))
            {
                //Then check if there's a backup made
                if (System.IO.File.Exists("C:\\Users\\James\\Documents\\Visual Studio 2012\\Projects\\XCOM_Facebook_Friend_Squad\\Resource Files\\\newFile.txt.orig") == false)
                {
                    //If the backup doesn't exist create it
                    System.IO.File.Move("C:\\Users\\James\\Documents\\Visual Studio 2012\\Projects\\XCOM_Facebook_Friend_Squad\\Resource Files\\newFile.txt", "C:\\Users\\James\\Documents\\Visual Studio 2012\\Projects\\XCOM_Facebook_Friend_Squad\\Resource Files\\newFile.txt.orig");
                    
                }

                //Then we move on to save either way
                TextWriter tw = new StreamWriter("C:\\Users\\James\\Documents\\Visual Studio 2012\\Projects\\XCOM_Facebook_Friend_Squad\\Resource Files\\newFile.txt");
                tw.WriteLine(selectnames);
                tw.Close();


                //Code to use for replacing and what not
                //Copies
                //System.IO.File.Move("C:\\Users\\James\\Documents\\Visual Studio 2012\\Projects\\XCOM_Facebook_Friend_Squad\\newFile.txt", "C:\\Users\\James\\Documents\\Visual Studio 2012\\Projects\\XCOM_Facebook_Friend_Squad\\testFile.txt.orig");
                //makes new
                //System.IO.File.Create("C:\\Users\\James\\Documents\\Visual Studio 2012\\Projects\\XCOM_Facebook_Friend_Squad\\newFile.txt");
            }
            else
            {
                //If it does not we can either create it or stop (prompt user!)
                
            }


            //
        }

        //Closes entire program when this window is closed.
        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            parent.Close();
            this.Close();
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            parent.Close();
            this.Close();
            //Application.Exit();
        }

        private void btnSelectAll_Click(object sender, EventArgs e)
        {

            if (btnSelectAll.Text.Equals("Select All Soldiers"))
            {
                btnSelectAll.Text = "Deselect All Soldiers";
                foreach (ListViewItem friend in friendsList.Items)
                {
                    friend.Checked = true;
                }
            }
            else
            {
                btnSelectAll.Text = "Select All Soldiers";
                foreach (ListViewItem friend in friendsList.Items)
                {
                    friend.Checked = false;
                }
            }
        }

        private void btnSelectAllFlags_Click(object sender, EventArgs e)
        {
            if (btnSelectAllFlags.Text.Equals("Select All Countries"))
            {
                btnSelectAllFlags.Text = "Deselect All Countries";
                foreach (ListViewItem flag in listFlags.Items)
                {
                    flag.Checked = true;
                }
            }
            else
            {
                btnSelectAllFlags.Text = "Select All Countries";
                foreach (ListViewItem flag in listFlags.Items)
                {
                    flag.Checked = false;
                }
            }
        }

    }
}
