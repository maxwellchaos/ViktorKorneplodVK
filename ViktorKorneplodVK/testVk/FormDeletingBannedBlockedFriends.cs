using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace testVk
{
    public partial class FormDeletingBannedBlockedFriends : Form
    {
        public string access_token;
        private object userInfo;

        public FormDeletingBannedBlockedFriends()
        {
            InitializeComponent();
        }

        private void FormDeletingBannedBlockedFriends_Load(object sender, EventArgs e)
        {
         
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
        // мои запросы https://api.vk.com/method/friends.get?fields=bdate&access_token=7d904d438e43e09168ababf069fba93c9c78c7483621c770a41a2035f9721d95ae14e2a9e286186ab5957&v=5.131
        https://api.vk.com/method/friends.delete&access_token=bb98347f29c98cb85c27b21865a0bf2a8e6c540db6b665373956aea2d0b2b5b118bf9ab67b5189b30aa4a&v=5.131
            textBox1.Text = "";
            WebClient client = new WebClient();
            string answer = Encoding.UTF8.GetString(client.DownloadData(
                   "https://api.vk.com/method/friends.get?"
                   + "fields=bdate&"
                   + access_token
                   + "&v=5.131"
                   ));
            //textBox1.Text = answer;
            friendList friends = JsonConvert.DeserializeObject<friendList>(answer);
            //textBox1.Text = List.response.bdate;

            foreach (friendList.Item friend in friends.response.items)
            {
                if (friend.deactivated != null)
                {
                    textBox1.Text = textBox1.Text + friend.first_name + " " + friend.id.ToString() + "\r\n";
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WebClient client = new WebClient();
            string answer = Encoding.UTF8.GetString(client.DownloadData(
                   "https://api.vk.com/method/friends.get?"
                   + "fields=bdate&"
                   + access_token
                   + "&v=5.131"
                   ));
            string delete = Encoding.UTF8.GetString(client.DownloadData(
                   "https://api.vk.com/method/friends.delete?"
                   + "user_id=44273152&"
                   + access_token
                   + "&v=5.131"
                   ));
            friendList friends = JsonConvert.DeserializeObject<friendList>(answer);
            int couner = 0;
            foreach (friendList.Item friend in friends.response.items)
            {
              textBox1.Text = textBox1.Text + friend.first_name + " " + friend.deactivated + "" + friend.id.ToString() + "\r\n";
              couner++;
              delete = Encoding.UTF8.GetString(client.DownloadData(
              "https://api.vk.com/method/friends.delete?"
              + "user_id&"
              + access_token
              + "&v=5.131"
              ));
                if (couner > 2)
                {
                    break;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            WebClient client = new WebClient();
            string answer = Encoding.UTF8.GetString(client.DownloadData(
                   "https://api.vk.com/method/friends.get?"
                   + "fields=bdate&"
                   + access_token
                   + "&v=5.131"
                   ));
            //textBox1.Text = answer;
            friendList friends = JsonConvert.DeserializeObject<friendList>(answer);
            //textBox1.Text = List.response.bdate;
            foreach (friendList.Item friend in friends.response.items)
            {
                if (friend.deactivated != null)
                {
                    textBox1.Text = textBox1.Text + friend.first_name + " " + friend.deactivated + "" + friend.id.ToString() + "\r\n";
                }
            }
        }
    }
}
