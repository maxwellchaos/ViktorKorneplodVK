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
    public partial class LikeForm : Form
    {
        int error = 0;
        int success = 0;
        public string access_token;
        public LikeForm()
        {
            InitializeComponent();
        }

        private void LikeForm_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string groupName = textBox3.Text;
            int pos = textBox3.Text.LastIndexOf("/");
            string screenName = textBox3.Text.Remove(0, pos + 1);
            string GroupId;
            WebClient client;
            string answer;
            string request;
            if (!screenName.Contains("-"))
            {
                client = new WebClient();
                request = "https://api.vk.com/method/utils.resolveScreenName?screen_name=" + screenName + "&" + access_token + "&v=5.131";
                 answer = Encoding.UTF8.GetString(client.DownloadData(request));

                groupName name = JsonConvert.DeserializeObject<groupName>(answer);
                GroupId = "-"+name.response.object_id.ToString();

            }
            else
            { GroupId = screenName; }
            success = 0;
            error = 0;

             client = new WebClient();
             request = "https://api.vk.com/method/wall.get?" + "owner_id="+ GroupId + "&"
                + access_token
                + "&v=5.131";
             answer = Encoding.UTF8.GetString(client.DownloadData(request));
            posts wallget = JsonConvert.DeserializeObject<posts>(answer);
            progressBar1.Value = 0;
            foreach (posts.Item wall in wallget.response.items)
            {
                Application.DoEvents();
                textBox1.Text = textBox1.Text + wall.text + " " + wall.id.ToString() + "\r\n";
                request = "https://api.vk.com/method/likes.add?type=post&"
                    //вставить owner_id!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
                + "owner_id=" + GroupId + "&"  
                + "item_id=" + wall.id.ToString() + "&"
                + access_token
                + "&v=5.131"; 
                 answer = Encoding.UTF8.GetString(client.DownloadData(request));
                progressBar1.Value = progressBar1.Value + 5;
                
                for(int j = 0; j < 100; j++)
                {
                    Thread.Sleep(10);
                    Application.DoEvents();
                }
               if(answer.Contains("error"))
                {
                    error = error + 1;
                }
               else
                {
                    success = success + 1;
                    
                }
               label1.Text = "оставлено лайков/ошибок: "+ success.ToString() +"/" + error.ToString();
            }
            progressBar1.Value = 100;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
