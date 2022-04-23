using System;
using System.Net;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace testVk
{
    public partial class MainForm : Form
    {
        string access_token;
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

        private void LastNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void KommentPostovSoobButton_Click(object sender, EventArgs e)
        {
            //Вызов KommentPostovSoobForm(Комментарии к постам сообщества)
            KommentPostovSoobForm frm = new KommentPostovSoobForm();
            frm.access_token = this.access_token;
            frm.Show();
        }
    }
}
