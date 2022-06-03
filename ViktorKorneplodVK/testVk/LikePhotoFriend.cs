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
    public partial class LikePhotoFriend : Form
    {
        public LikePhotoFriend()
        {
            InitializeComponent();
        }

        public string access_token { get; internal set; }

        private void buttonfriend_Click(object sender, EventArgs e)
        {
            int pos = textBox1.Text.LastIndexOf("/");
            string screenName = textBox1.Text.Remove(0, pos + 1);

            WebClient client = new WebClient();
            string request = "https://api.vk.com/method/utils.resolveScreenName?screen_name="
                + screenName + "&"
                + access_token
                + "&v=5.131";
            string answer = Encoding.UTF8.GetString(client.DownloadData(request));

            ResolveScreenName VKObject = JsonConvert.DeserializeObject<ResolveScreenName>(answer);
             textBox1.Text = VKObject.response.object_id.ToString();

            string userid = VKObject.response.object_id.ToString();
            client = new WebClient();
            answer = Encoding.UTF8.GetString(client.DownloadData(
                   "https://api.vk.com/method/friends.get?"
                   + "user_id=" + textBox1.Text + "&"
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
            WebClient client = new WebClient();
            if (listView1.SelectedItems.Count > 0)
            {
                //textBox1PhotoFriend.Text = listView1.SelectedItems[2].Text;
                string request = "https://api.vk.com/method/photos.getAll?"
                 + "owner_id=" + listView1.SelectedItems[0].SubItems[1].Text + "&"
                 + access_token
                 + "&v=5.131";
                string getphoto = Encoding.UTF8.GetString(client.DownloadData(request));
                //string like = "https://api.vk.com/method/likes.add?"
                //+ "type=photo&"
                //+ "owner_id=56929156&"
                //+ "item_id=457242080&"
                //+ access_token
                //+ "&v=5.131";
                //string likes = Encoding.UTF8.GetString(client.DownloadData(like));
                LikeAllPhoto photos = JsonConvert.DeserializeObject<LikeAllPhoto>(getphoto);
                foreach (LikeAllPhoto.Item photo in photos.response.items)
                {
                    for (int i = 0; i < 100; i++)
                    {
                        Application.DoEvents();
                        Thread.Sleep(10);
                        Application.DoEvents();
                    }
                    string[] subItems = new string[3];
                    subItems[2] = photo.id.ToString();
                    ListViewItem lvi = new ListViewItem(subItems);
                    listView1.Items.Add(lvi);
                    
                    string like = "https://api.vk.com/method/likes.add?"
                    + "type=photo&"
                    + "owner_id=" + listView1.SelectedItems[0].SubItems[1].Text + "&"
                    + "item_id="+ photo.id.ToString() + "&"
                    + access_token
                    + "&v=5.131";
                    string likes = Encoding.UTF8.GetString(client.DownloadData(like));
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int pos = textBox1.Text.LastIndexOf("/");
            string screenName = textBox1.Text.Remove(0, pos + 1);

            WebClient client = new WebClient();
            string request = "https://api.vk.com/method/utils.resolveScreenName?screen_name="
                + screenName + "&"
                + access_token
                + "&v=5.131";
            string answer = Encoding.UTF8.GetString(client.DownloadData(request));

            ResolveScreenName VKObject = JsonConvert.DeserializeObject<ResolveScreenName>(answer);
            //label2.Text = VKObject.response.object_id.ToString();
        }
    }
}
