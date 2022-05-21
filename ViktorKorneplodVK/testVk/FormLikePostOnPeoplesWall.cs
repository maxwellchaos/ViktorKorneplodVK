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

namespace testVk
{
    public partial class FormLikePostOnPeoplesWall : Form
    {
        public string access_token;
        public string owner_id;
        public FormLikePostOnPeoplesWall()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void FormLikePostOnPeoplesWall_Load(object sender, EventArgs e)
        {
            //labelAccesTok.Text = access_token;
        }
        private void buttonID_Click(object sender, EventArgs e)
        {
             //owner_id = textBoxID.Text;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int pos = textBoxID.Text.LastIndexOf("/");
            string skreenName = textBoxID.Text.Remove(0, pos + 1);

            WebClient CLIENT = new WebClient();
            string REQUEST = "https://api.vk.com/method/utils.resolveScreenName?screen_name=" + skreenName + "&" + access_token + "&v=5.131";
            string ANSWER = Encoding.UTF8.GetString(CLIENT.DownloadData(REQUEST));
            ResolveScreenName VKObject = JsonConvert.DeserializeObject<ResolveScreenName>(ANSWER);
            textBoxID.Text = VKObject.response.object_id.ToString();


            likesYN.Text = "ЛАЙКИ СТАВЯТСЯ";
            owner_id = textBoxID.Text;
            string request = "https://api.vk.com/method/wall.get?owner_id="+owner_id+"&" + access_token + "&v=5.131";
            WebClient client = new WebClient();
            string answer = Encoding.UTF8.GetString(client.DownloadData(request));
            //textBox1.Text = answer;

            WallPosts posts = JsonConvert.DeserializeObject<WallPosts>(answer);
                foreach (WallPosts.Item post in posts.response.items)
                {
                    string Request = "https://api.vk.com/method/wall.addLike?owner_id=" + owner_id + "&post_id=" + post.id.ToString() + "&" + access_token + "&v=5.131";
                    WebClient Client = new WebClient();
                    string Answer = Encoding.UTF8.GetString(Client.DownloadData(Request));
                    textBoxLike.Text = textBoxLike.Text + post.id.ToString() + Answer + "\r\n";

                    LikeForPost Likes = JsonConvert.DeserializeObject<LikeForPost>(Answer);
                    
                for (int i = 0; i < 300; i++) 
                {
                    Application.DoEvents();
                    System.Threading.Thread.Sleep(10);
                }
                }
            likesYN.Text = "ЛАЙКИ ПОСТАВЛЕНЫ";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
           
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void textBoxID_TextChanged(object sender, EventArgs e)
        {

        }

     
    }
}
