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
using Newtonsoft.Json;
using System.Threading;

namespace testVk
{
    public partial class FormCommentPostovSoob : Form
    {
        public string access_token;
        public string IDTextBox;
        public int errors;
        public int success;
        public FormCommentPostovSoob()
        {
            InitializeComponent();
        }

        private void FormCommentPostovSoob_Load(object sender, EventArgs e)
        {
            //показать access_token
            labelAccessTok.Text = access_token;
            //
        }

        private void buttonInfoGet_Click(object sender, EventArgs e)
        {

            }

        private void buttonCreateComment_Click(object sender, EventArgs e)
        {
            WebClient client = new WebClient();
            for (int i = 0; i < textBoxInfoPosts.Lines.Length; i++)
            {
                label2.Text = textBoxInfoPosts.Lines[i];
                if (IDtextBoxPoisckID.Text == "")
                {

                }
                else
                {
                    string request = "https://api.vk.com/method/wall.search?owners_only=1&owner_id=-"
                                + textBoxInfoPosts.Lines[i]    //IDTextBox
                                + "&query="
                                + IDtextBoxPoisckID.Text + "&"
                                + access_token + "&v=5.131";
                    string answer = Encoding.UTF8.GetString(client.DownloadData(request));
                    WallPostsInfo infoPosts = JsonConvert.DeserializeObject<WallPostsInfo>(answer);
                    foreach (WallPostsInfo.Item Post in infoPosts.response.items)
                    {
                        if(Post.post_type != "post")
                        {
                            continue;
                        }
                        try
                        {
                            Application.DoEvents();
                            Thread.Sleep(180000);

                            request = "https://api.vk.com/method/wall.createComment?owner_id=-"
                           + textBoxInfoPosts.Lines[i]
                           + "&post_id="
                           + Post.id
                           + "&message="
                           + textBoxCreateComment.Text + "&"
                           + access_token
                           + "&v=5.131";

                            answer = Encoding.UTF8.GetString(client.DownloadData(request));

                            if(answer.Contains("error"))
                            {
                                errors = errors + 1;
                            }
                            else
                            {
                                success = success = + 1;
                            }
                            ErrorAndSuccessLabel.Text = "Оставлено комментариев/ошибок: "
                                + success.ToString()
                                + "/"
                                + errors.ToString();
                            Application.DoEvents();

                            CreateComment CommCreat = JsonConvert.DeserializeObject<CreateComment>(answer);

                            if (textBoxCreateComment.Text == "")
                            {
                             
                            }
                            else
                            {
                                foreach (CreateComment.Response comm in CommCreat.response.parents_stack)
                                {
                                    textBoxCreateComment.Text = textBoxCreateComment.Text + comm.comment_id.ToString() + "\r\n";
                                }
                            }
                        }
                        catch (Exception)
                        {
                            //вывод сообщения об ошибке, если нужно
                        }
                    }
                }
            }
        }

        private void textBoxCreateComment_TextChanged(object sender, EventArgs e)
        {

        }

        private void IDtextBoxPoisckID_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonGroupsSearch_Click(object sender, EventArgs e)
        {
            WebClient client = new WebClient();
            string request = "https://api.vk.com/method/groups.search?owner_id="
                + IDTextBox
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

        }

        private void textBoxSetSearchValue_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelAccessTok_Click(object sender, EventArgs e)
        {

        }
    }
}
