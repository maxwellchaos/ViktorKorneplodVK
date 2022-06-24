using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using Newtonsoft.Json;
using static testVk.posts;

namespace testVk
{
    public partial class frindsSuggestions : Form
    {
        public string access_token;

        public frindsSuggestions()
        {
            InitializeComponent();
        }

        private void frindsSuggestions_Load(object sender, EventArgs e)
        {

        }
        private void buttonFriends_Click(object sender, EventArgs e)
        {
            WebClient Client = new WebClient();
            string Request = "https://api.vk.com/method/friends.getSuggestions?Count=100" + "&fields=screen_name&" + access_token + "&v=5.131";
            string Answer = Encoding.UTF8.GetString(Client.DownloadData(Request));
            FriendRecomendation id = JsonConvert.DeserializeObject<FriendRecomendation>(Answer);

            for (int i=0;i<100;i=i+1)
            {
                string text = textBoxText.Text;
                WebClient WClient = new WebClient();
                string SRequest = "https://api.vk.com/method/friends.add?user_id=" + id.response.items[i].id + "&text=" + text + "&" + access_token + "&v=5.131";
                string SAnswer = Encoding.UTF8.GetString(Client.DownloadData(SRequest));
                labelFriends.Visible = true;
            }
            labelFriends.Text = "Добавил:)";
        }

        private void labelCount_Click(object sender, EventArgs e)
        {

        }
    }
}






