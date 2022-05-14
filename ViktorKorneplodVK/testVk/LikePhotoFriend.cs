using Newtonsoft.Json;
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
            WebClient client = new WebClient();
            string answer = Encoding.UTF8.GetString(client.DownloadData(
                   "https://api.vk.com/method/friends.get?"
                   + "fields=bdate&"
                   + access_token
                   + "&v=5.131"
                   ));
            friendList friends = JsonConvert.DeserializeObject<friendList>(answer);
            string getphoto = Encoding.UTF8.GetString(client.DownloadData(
                   "https://api.vk.com/method/photos.getAll?"
                   + "owner_id=56929156&"
                   + access_token
                   + "&v=5.131"
                   ));
            LikeAllPhoto photos = JsonConvert.DeserializeObject<LikeAllPhoto>(getphoto);
            foreach (friendList.Item friend in friends.response.items)
            {
                string[] subItems = new string[3];
                subItems[0] = friend.first_name + "" + friend.last_name;
                subItems[1] = friend.id.ToString();
                ListViewItem lvi = new ListViewItem(subItems);
                listView1.Items.Add(lvi);
            }
            foreach (LikeAllPhoto.Item photo in photos.response.items)
            { 

            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                label1.Text = listView1.SelectedItems[0].Text;

            }
        }
    }
}
