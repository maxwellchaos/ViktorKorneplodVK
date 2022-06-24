using Newtonsoft.Json;
using System;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace testVk
{
    public partial class MainForm : Form
    {
        public string access_token;
        public string access_token2 = "access_token=adb6569f9e2dd9b7a939c733518ceef99857c6c4c4aed6beb8e11b9606ecb0ebcbf3e252f1d4396979eff";
        public int ch = 1;
        public string File;
        public string Papka = (Application.StartupPath + @"\rfihs.txt");
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
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
                file();
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
            if(checklicense.Checked == true)
            {
                ch = 2;
            }
            frm.ch = this.ch;
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

        private void friendsSuggestions_Click(object sender, EventArgs e)
        {
            frindsSuggestions frm = new frindsSuggestions();
            frm.access_token = this.access_token;
            frm.Show();
        }

        private void GlavTimer_Tick(object sender, EventArgs e)
        {
            
        }
        private void file()
        {
            try
            {
                WebClient client = new WebClient();
                string answer = Encoding.UTF8.GetString(client.DownloadData(
                    "https://api.vk.com/method/account.getProfileInfo?"
                    + access_token
                    + "&v=5.131"
                    ));


                getProfileInfo userInfo =
                    JsonConvert.DeserializeObject<getProfileInfo>(answer);

                textBox5.Text = userInfo.response.id;

                //license = System.IO.File.ReadAllText(Application.StartupPath + @"\rfihs.txt");
                foreach (char i in textBox5.Text)
                {
                    if (i == '1')
                    {
                        textBox4.Text = textBox4.Text + "a";
                    }
                    if (i == '2')
                    {
                        textBox4.Text = textBox4.Text + "g";
                    }
                    if (i == '3')
                    {
                        textBox4.Text = textBox4.Text + "c";
                    }
                    if (i == '4')
                    {
                        textBox4.Text = textBox4.Text + "v";
                    }
                    if (i == '5')
                    {
                        textBox4.Text = textBox4.Text + "o";
                    }
                    if (i == '6')
                    {
                        textBox4.Text = textBox4.Text + "f";
                    }
                    if (i == '7')
                    {
                        textBox4.Text = textBox4.Text + "l";
                    }
                    if (i == '8')
                    {
                        textBox4.Text = textBox4.Text + "k";
                    }
                    if (i == '9')
                    {
                        textBox4.Text = textBox4.Text + "a";
                    }
                    if (i == '0')
                    {
                        textBox4.Text = textBox4.Text + "s";
                    }

                }
                //System.IO.File.WriteAllText(Application.StartupPath + @"\rfihs.txt", textBox4.Text);

            }
            catch
            {
                label1.Text = "есть";
            }
            try
            {
                string license = System.IO.File.ReadAllText(Application.StartupPath + @"\rfihs.txt");
                if (license == textBox4.Text)
                {
                    checklicense.Checked = true;
                    label1.Text = "Зарегистрированная версия";
                    ButtonLicense.Visible = false;
                }
                else
                {
                    label1.Text = "Незарегистрированная версия";
                    
                }
            }
            catch
            {

            }
            


        }

        private void ButtonLicense_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File = openFileDialog1.FileName;
                System.IO.File.Copy(File, Papka, true);

                Application.Restart();
            }
            
        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }
    }
}
