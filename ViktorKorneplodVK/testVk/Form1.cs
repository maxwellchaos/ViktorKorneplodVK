﻿using System;
using System.Net;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace testVk
{
    public partial class MainForm : Form
    {
        public string access_token;
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WebClient client = new WebClient();
            string answer = Encoding.UTF8.GetString(client.DownloadData(
                "https://api.vk.com/method/account.getProfileInfo?"
                +access_token
                +"&v=5.131"
                ));

            getProfileInfo userInfo = 
                JsonConvert.DeserializeObject<getProfileInfo>(answer);

            
            answer = Encoding.UTF8.GetString(client.DownloadData(
               "https://api.vk.com/method/users.get?user_ids=" 
               +userInfo.response.id  
               +"&fields=photo_50&"
               +access_token
               +"&v=5.131"
               ));

            getAvatar avatar = JsonConvert.DeserializeObject<getAvatar>(answer);

            LastNameLabel.Text = userInfo.response.last_name;
            AvatarPictureBox.Load(avatar.response[0].photo_50);
         
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            Application.DoEvents();
            string str;
            str = StartWebBrowser.Url.ToString();
            if (str.Contains("access_token"))
            {
                //удаление всего после &
                int AmpersandPos = str.IndexOf("&");

                access_token = str.Remove(AmpersandPos);
                //удаление всего перед #
                int SharpPos = access_token.IndexOf("#");

                access_token = access_token.Remove(0, SharpPos + 1);

                AccessTokenTextBox.Text = access_token;
                Application.DoEvents();
                WebClient client = new WebClient();
                string answer = Encoding.UTF8.GetString(client.DownloadData(
                    "https://api.vk.com/method/account.getProfileInfo?"
                    + access_token
                    + "&v=5.131"
                    ));


                getProfileInfo userInfo =
                    JsonConvert.DeserializeObject<getProfileInfo>(answer);


                answer = Encoding.UTF8.GetString(client.DownloadData(
                   "https://api.vk.com/method/users.get?user_ids="
                   + userInfo.response.id
                   + "&fields=photo_50&"
                   + access_token
                   + "&v=5.131"
                   ));

                getAvatar avatar = JsonConvert.DeserializeObject<getAvatar>(answer);

                LastNameLabel.Text = userInfo.response.last_name;
                FirstNameLabel.Text = userInfo.response.first_name;
                AvatarPictureBox.Load(avatar.response[0].photo_50);
                ViktorPictureBox.Visible = false;
                StartWebBrowser.Visible = false;
            }
            else
            {
                ViktorPictureBox.Visible = false;
                StartWebBrowser.BringToFront();
                StartWebBrowser.Dock = DockStyle.Fill;
            }

        }

        private void button1_Paint(object sender, PaintEventArgs e)
        {
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
        }

        private void button3_Click(object sender, EventArgs e)
        {
        
        }

        private void FantekriBotHelper_Click(object sender, EventArgs e)
        {
            FantekriFormHelper frm = new FantekriFormHelper();
            this.Hide();
            //frm.access_token = this.access_token;
            frm.ShowDialog();
            this.Show();
        }

        private void buttonPostOnStrangeWall_Click(object sender, EventArgs e)
        {
            //Вызов второрй формы
            FormCommentPostovSoob frm = new FormCommentPostovSoob();
            frm.access_token = this.access_token;
            frm.Show();
        }


        private void DeletingBannedBlockedFriends_Click(object sender, EventArgs e)
        {
            FormDeletingBannedBlockedFriends frm = new FormDeletingBannedBlockedFriends();
            frm.access_token = this.access_token;
            frm.Show();
        }

        private void LikePhotoFriend_Click(object sender, EventArgs e)
        {
            LikePhotoFriend lpf = new LikePhotoFriend();
            lpf.access_token = this.access_token;
            lpf.Show();
        }

        private void buttonLikePostOnPeoplesWall_Click(object sender, EventArgs e)
        {
            FormLikePostOnPeoplesWall frm = new FormLikePostOnPeoplesWall();
            frm.access_token = this.access_token;
            frm.Show();

            for (int i = 0; i < 300; i++)
            {
                Application.DoEvents();
                System.Threading.Thread.Sleep(10);
            }
        }
        private void FirstNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void Likebutton_Click(object sender, EventArgs e)
        {
            LikeForm frm = new LikeForm();
            frm.access_token = this.access_token;
            frm.Show();
            
        }

        private void LastNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ViktorPictureBox.Location = new System.Drawing.Point(0, 0);

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FormZayavkaFriend fzf = new FormZayavkaFriend();
            fzf.access_token = this.access_token;
            fzf.Show();
        }
    }
}
