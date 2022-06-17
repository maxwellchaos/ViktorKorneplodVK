using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testVk
{
    public partial class FormZayavkaFriend : Form
    {
        internal string access_token;
        private int couner;

        public FormZayavkaFriend()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WebClient client = new WebClient();
            string answer = Encoding.UTF8.GetString(client.DownloadData(
                  "https://api.vk.com/method/friends.get?"
                 // + "user_id=" + textBox1.Text + "&"
                  + "fields=bdate&"
                  + access_token
                  + "&v=5.131"
                  ));
            friendList friends = JsonConvert.DeserializeObject<friendList>(answer);
            foreach (friendList.Item friend in friends.response.items)
            {
                string[] subItems = new string[3];
                subItems[0] = friend.first_name + "" + friend.last_name;
                subItems[1] = friend.id.ToString();
                ListViewItem lvi = new ListViewItem(subItems);
                listView1.Items.Add(lvi);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                return;
            }
            button2.Enabled = true;

            WebClient client = new WebClient();



            string answer = Encoding.UTF8.GetString(client.DownloadData(
                  "https://api.vk.com/method/friends.get?"
                  + "user_id=" + listView1.SelectedItems[0].SubItems[1].Text + "&"
                  + "count=100&"
                  + "fields=bdate&"
                  + access_token
                  + "&v=5.131"
                  ));
            friendList friends = JsonConvert.DeserializeObject<friendList>(answer);
            string ids = "";
            foreach (friendList.Item friend in friends.response.items)
            {
                if (friend.deactivated == null)
                {
                    ids = ids + friend.id + ",";
                }
            }
            string friend_st = "https://api.vk.com/method/friends.areFriends?"
              + "user_ids=" + ids + "&"
              + access_token
              + "&v=5.131";
            string frst = Encoding.UTF8.GetString(client.DownloadData(friend_st));
            FriendStatus status = JsonConvert.DeserializeObject<FriendStatus>(frst);

            foreach (FriendStatus.Response friend in status.response)
            {
                if (friend.friend_status == 0)
                {
                    textBox1.Text = textBox1.Text + friend.user_id.ToString() + "\r\n";
                    //textBox2.Text = textBox2.Text + friend.first_name + friend.last_name + friend.id.ToString() + "\r\n";
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                WebClient client = new WebClient();
                string friend_st = "https://api.vk.com/method/friends.areFriends?"
                    + "user_ids=" + textBox1.Lines[i] + "&"
                    + access_token
                    + "&v=5.131";
                string frst = Encoding.UTF8.GetString(client.DownloadData(friend_st));
                FriendStatus status = JsonConvert.DeserializeObject<FriendStatus>(frst);
                if (status.response[0].friend_status == 0)
                {
                    string request =
                        "https://api.vk.com/method/friends.add?"
                        + "user_id=" + textBox1.Lines[i] + "&"
                        + access_token
                        + "&v=5.131";
                    string answer = Encoding.UTF8.GetString(client.DownloadData(request));
                    ZayavkaFriend zayavka = JsonConvert.DeserializeObject<ZayavkaFriend>(answer);
                }
            }
        }

        private void FormZayavkaFriend_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
