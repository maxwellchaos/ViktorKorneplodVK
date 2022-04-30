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
            label1.Text = access_token;
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WebClient client = new WebClient();
            string answer = Encoding.UTF8.GetString(client.DownloadData(
                   "https://api.vk.com/method/friends.get?"
                   + "fields=bdate&"
                   + access_token
                   + "&v=5.131"
                   ));
            textBox1.Text = answer;
            friendList List = JsonConvert.DeserializeObject<friendList>(answer);
            textBox1.Text = List.response.bdate;
        }
    }
}
