using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using Newtonsoft.Json;

namespace testVk
{
    public partial class FormCommentPostovSoob : Form
    {
        public string access_token;
        public string IDTextBox;
        public int errors;
        public int success;
        //Если false- Не ленцинзионная версия
        //Если true- ЛЕЦЕНЦИЯ
        public bool Licensed;

        Random rnd = new Random();
        public FormCommentPostovSoob()
        {
            InitializeComponent();
        }
        private void FormCommentPostovSoob_Load(object sender, EventArgs e)
        {
            //показать access_token
            labelAccessTok.Text = access_token;
        }
        private void buttonCreateComment_Click(object sender, EventArgs e)
        {
            labelOtprava.Visible = true;
            progressBarOjidaniya.Visible = true;
            if (textBoxInfoPosts.Text == "")
            {
                labelOiOi.Visible = true;
            }
            WebClient client = new WebClient();
            for (int i = 0; i < textBoxInfoPosts.Lines.Length; i++)
            {
                progressBarOjidaniya.Maximum = 100;
                labelTextPoiska.Text = textBoxInfoPosts.Lines[i];
                if (IDtextBoxPoisckID.Text == "")
                {

                }
                else
                {
                    try
                    {
                        string request = "https://api.vk.com/method/wall.search?owners_only=1&owner_id=-"
                                + textBoxInfoPosts.Lines[i]
                                + "&query="
                                + IDtextBoxPoisckID.Text
                                + "&" + access_token + "&v=5.131";
                        string answer = Encoding.UTF8.GetString(client.DownloadData(request));
                        WallPostsInfo infoPosts = JsonConvert.DeserializeObject<WallPostsInfo>(answer);
                        progressBarOjidaniya.Value = i;
                        Thread.Sleep(100);
                        foreach (WallPostsInfo.Item Post in infoPosts.response.items)
                        {
                            buttonCreateComment.Enabled = false;
                            if (Post.post_type != "post")
                            {
                                continue;
                            }

                            Random rnd = new Random();
                            int number;
                            number = rnd.Next(3);
                            ////////////////////////////////////////////////////////////////////////////////////////////////////////////
                            if (Licensed == true)
                            {
                                if (number != 1)
                                {
                                    int wait = 26000;
                                    for (int j = 0; j < wait / 10; j++)
                                    {
                                        Application.DoEvents();
                                        Thread.Sleep(10);
                                    }
                                }
                                else
                                {
                                    int wait = 9000;
                                    for (int j = 0; j < wait / 10; j++)
                                    {
                                        Application.DoEvents();
                                        Thread.Sleep(10);
                                    }
                                }
                                number = rnd.Next(3);
                                if (number != 1)
                                {
                                    int wait = 15000;
                                    for (int j = 0; j < wait / 10; j++)
                                    {
                                        Application.DoEvents();
                                        Thread.Sleep(10);
                                    }
                                }
                                else
                                {
                                    int wait = 7000;
                                    for (int j = 0; j < wait / 10; j++)
                                    {
                                        Application.DoEvents();
                                        Thread.Sleep(10);
                                    }
                                }
                            }
                            ///////////////////////////////////////////////////////////////////////////////////////////////////////
                            else
                            {
                                if (number != 1)
                                {
                                    int wait = 35000;
                                    for (int j = 0; j < wait / 10; j++)
                                    {
                                        Application.DoEvents();
                                        Thread.Sleep(10);
                                    }
                                }
                                else
                                {
                                    int wait = 23000;
                                    for (int j = 0; j < wait / 10; j++)
                                    {
                                        Application.DoEvents();
                                        Thread.Sleep(10);
                                    }
                                }

                                number = rnd.Next(3);
                                if (number != 1)
                                {
                                    int wait = 28000;
                                    for (int j = 0; j < wait / 10; j++)
                                    {
                                        Application.DoEvents();
                                        Thread.Sleep(10);
                                    }
                                }
                                else
                                {
                                    int wait = 21000;
                                    for (int j = 0; j < wait / 10; j++)
                                    {
                                        Application.DoEvents();
                                        Thread.Sleep(10);
                                    }
                                }
                            }
                            request = "https://api.vk.com/method/wall.createComment?owner_id=-"
                          + textBoxInfoPosts.Lines[i]
                          + "&post_id="
                          + Post.id
                          + "&message="
                          + textBoxCreateComment.Text + "&"
                          + access_token
                          + "&v=5.131";
                            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                            //показ капчи
                            answer = Encoding.UTF8.GetString(client.DownloadData(request));
                            if (answer.Contains("Captcha needed"))
                            {
                                panelOsnovaVsego.Visible = false;
                                //показать капчу
                                ComPostSoobCaptcha captchaOiOi =
                                JsonConvert.DeserializeObject<ComPostSoobCaptcha>(answer);

                                pictureBoxOiOiCaptcha.Load(captchaOiOi.error.captcha_img);
                                panelOiOiCaptcha.BringToFront();
                                textBoxOiOiCaptcha.Text = "";

                                //Это цикл ожидания ввода капчи и нажатия кнопки
                                for (; panelOsnovaVsego.Visible == false;)
                                {
                                    Thread.Sleep(30);
                                    Application.DoEvents();
                                }
                                //Пользователь ввел капчу и нажал кнопку
                                request = "https://api.vk.com/method/wall.createComment?owner_id=-"
                                + textBoxInfoPosts.Lines[i]
                                + "&post_id="
                                + Post.id
                                + "&message="
                                + textBoxCreateComment.Text + "&"
                                + "captcha_sid=" + captchaOiOi.error.captcha_sid
                                + "captcha_key=" + textBoxOiOiCaptcha.Text
                                + access_token
                                + "&v=5.131";
                                answer = Encoding.UTF8.GetString(client.DownloadData(request));

                                panelOiOiCaptcha.SendToBack();
                                //закрытие каптчи
                            }
                            else
                            {

                            }

                            if (answer.Contains("error"))
                            {
                                errors = errors + 1;
                                textBoxErrorAnsw.Text = textBoxErrorAnsw.Text + answer;
                            }
                            else
                            {
                                success = success + 1;
                            }

                            ErrorAndSuccessLabel.Text = "Оставлено комментариев/ошибок:"
                                + "\r\n"
                                + success.ToString()
                                + "/"
                                + errors.ToString();
                            Application.DoEvents();
                        }
                    }
                    catch (Exception)
                    {
                        //вывод сообщения об ошибке, если нужно
                    }
                }
            }
            progressBarOjidaniya.Value = progressBarOjidaniya.Maximum;
            if (progressBarOjidaniya.Value == progressBarOjidaniya.Maximum)
            {
                labelOtprava.Visible = false;
                progressBarOjidaniya.Visible = false;
                buttonCreateComment.Enabled = true;
                buttonGroupsSearch.Enabled = true;
                textBoxInfoPosts.Text = "";
            }
        }

        private void buttonGroupsSearch_Click(object sender, EventArgs e)
        {
            int count;
            if (Licensed == true)
            {
                count = 100;
                labelBetaVersions.Visible = false;
            }
            else
            {
                count = 2;
                labelBetaVersions.Visible = true;
            }
                labelOiOi.Visible = false;
                WebClient client = new WebClient();
                string request = "https://api.vk.com/method/groups.search?owner_id="
                    + IDTextBox
                    + "&count=" + count.ToString()
                    + "&q="
                    + IDtextBoxPoisckID.Text + "&"
                    + access_token + "&v=5.131";
                string answer = Encoding.UTF8.GetString(client.DownloadData(request));

                answer = Encoding.UTF8.GetString(client.DownloadData(request));
                GroupsSearch gropsInfo = JsonConvert.DeserializeObject<GroupsSearch>(answer);
            
            if (IDtextBoxPoisckID.Text == "")
            {

            }
            else
            {
                foreach (GroupsSearch.Item Post in gropsInfo.response.items)
                {
                    IDTextBox = textBoxInfoPosts.Text;
                    textBoxInfoPosts.Text = textBoxInfoPosts.Text + Post.id.ToString() + "\r\n";
                }
            }
            textBoxInfoPosts.Text = textBoxInfoPosts.Text.Remove(textBoxInfoPosts.Text.Length - 4);
            buttonGroupsSearch.Enabled = false;
        }
        private void buttonGGWPCaptcha_Click(object sender, EventArgs e)
        {
            panelOsnovaVsego.Visible = true;
        }
    }
}
