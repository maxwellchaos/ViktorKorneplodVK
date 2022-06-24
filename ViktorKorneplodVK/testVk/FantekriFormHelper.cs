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

    public partial class FantekriFormHelper : Form
    {
        public string message;
        public int one;
        public int two;
        public int ch = 1;


        //public string access_token = "access_token=823c822ff364b9ed48ec99c118b2b4a22d9ed79296ade35de85193c79d8e40514f2a7866482ce40f95089";
        public string access_token;
        
        Dictionary<int, int> statys = new Dictionary<int, int>();
        int stat = 1;

        public FantekriFormHelper()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //label1.Text = access_token;
            WebClient client = new WebClient();
            string request = "https://api.vk.com/method/messages.getConversations?"
                    + access_token
                    + "&v=5.131";
            string answer = Encoding.UTF8.GetString(client.DownloadData(request));

            //textBox1.Text = answer;
            Random rnd = new Random();

            messages_getConversations avatar = JsonConvert.DeserializeObject<messages_getConversations>(answer);

            messages_getConversations unanswered = JsonConvert.DeserializeObject<messages_getConversations>(answer);

            messages_getConversations last_message = JsonConvert.DeserializeObject<messages_getConversations>(answer);



            //textBox1.Text = unanswered.response.items[0].conversation.unanswered.ToString();
            foreach (messages_getConversations.Item conversation in unanswered.response.items)
            {
                //textBox1.Text = textBox1.Text + conversation.conversation.unanswered.ToString() + "\r\n";
                
                
                if (conversation.conversation.unanswered == true)
                {


                    if (conversation.last_message.text.Contains("Готов"))
                    {
                        message = Opros_1.Text;
                    }

                    if (GryppSoob.Text.Contains("Какой ваш уровень программирования"))
                    {
                        message = Opros_2.Text;
                        if (conversation.last_message.text.Contains("А"))
                        {
                            Otvet_1.Text = "Вам подойдут такие языки: C Sharp, ";
                        }
                        if (conversation.last_message.text.Contains("Б"))
                        {
                            Otvet_1.Text = "Вам подойдут такие языки: C Sharp, ";
                        }
                        if (conversation.last_message.text.Contains("В"))
                        {
                            Otvet_1.Text = "Вам подойдут такие языки: C++, ";
                        }
                        if (conversation.last_message.text.Contains("Г"))
                        {
                            Otvet_1.Text = "Вам подойдут такие языки: Java, ";
                        }

                    }




                    if (GryppSoob.Text.Contains("Для чего вам нужно писать программы"))
                    {
                        message = Opros_3.Text;
                        if (conversation.last_message.text.Contains("А"))
                        {
                            Otvet_2.Text = "C Sharp, ";
                        }
                        if (conversation.last_message.text.Contains("Б"))
                        {
                            Otvet_2.Text = "C Sharp, ";
                        }
                        if (conversation.last_message.text.Contains("В"))
                        {
                            Otvet_2.Text = "PHP или JavaScript, ";
                        }
                        if (conversation.last_message.text.Contains("Г"))
                        {
                            Otvet_2.Text = "1C, ";
                        }
                    }


                    if (GryppSoob.Text.Contains("Для кого вы хотитее писать программы"))
                    {
                        message = Otvet_1.Text + Otvet_2.Text + Otvet_3.Text;
                        if (conversation.last_message.text.Contains("А"))
                        {
                            Otvet_3.Text = "Java или Python";
                        }
                        if (conversation.last_message.text.Contains("Б"))
                        {
                            Otvet_3.Text = "C Sharp";
                        }
                    }
                    string request1 = "https://api.vk.com/method/messages.send?peer_id="
                   + conversation.last_message.peer_id
                   + "&random_id=" + rnd.Next().ToString() + "&"
                   + "message=" + message + "&"
                   + access_token
                   + "&v=5.131";
                    answer = Encoding.UTF8.GetString(client.DownloadData(request1));




                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            
        }

        private void GlavTimer_Tick(object sender, EventArgs e)
        {
            try
            {
                if (checklicense.Checked == false)
                {
                    two = two + 1;
                    if (two > 500)
                    {
                        GlavTimer.Enabled = false;
                    }
                }

                WebClient client = new WebClient();
                string request = "https://api.vk.com/method/messages.getConversations?"
                        + access_token
                        + "&v=5.131";
                string answer = Encoding.UTF8.GetString(client.DownloadData(request));

                messages_getConversations unanswered = JsonConvert.DeserializeObject<messages_getConversations>(answer);

                ////label1.Text = access_token;
                //WebClient client = new WebClient();
                //string request = "https://api.vk.com/method/messages.getConversations?"
                //        + access_token
                //        + "&v=5.131";
                //string answer = Encoding.UTF8.GetString(client.DownloadData(request));

                ////textBox1.Text = answer;
                Random rnd = new Random();

            
                //messages_getConversations unanswered = JsonConvert.DeserializeObject<messages_getConversations>(answer);



                //textBox1.Text = unanswered.response.items[0].conversation.unanswered.ToString();
                foreach (messages_getConversations.Item conversation in unanswered.response.items)
                {
                    //textBox1.Text = textBox1.Text + conversation.conversation.unanswered.ToString() + "\r\n";

                    string request1 = "https://api.vk.com/method/messages.getHistory?peer_id="
                                      + unanswered.response.items[0].last_message.peer_id + "&"
                                      + access_token
                                      + "&v=5.131";

                    answer = Encoding.UTF8.GetString(client.DownloadData(request1));
                    messages_getHistory Item = JsonConvert.DeserializeObject<messages_getHistory>(answer);

                    
                   int UserId=conversation.conversation.peer.id;
                   

                    
//System.IO.File.WriteAllText(Application.StartupPath + @"\rfihs.txt", textBox4.Text);
                    if (!statys.ContainsKey(UserId))
                    {
                        statys.Add(UserId, 1);
                    }


                    if (Item.response.items.Count > 1)
                    {
                        id.Text = Item.response.items[0].from_id.ToString();
                        id2.Text = Item.response.items[1].from_id.ToString();

                        if (id2.Text.Contains("-"))
                        {
                            GryppSoob.Text = Item.response.items[1].text;
                        }
                        else
                        {
                            PolzSoob.Text = Item.response.items[1].text;
                        }



                        if (id.Text.Contains("-"))
                        {
                            GryppSoob.Text = Item.response.items[0].text;
                        }
                        else
                        {
                            PolzSoob.Text = Item.response.items[0].text;
                        }
                    }
                    foreach (messages_getHistory.Item AllMessage in Item.response.items)
                    {
                        //int AllMessage1 = Item.response.items;
                        if (AllMessage.text.Contains("Добрый день"))
                        {
                            statys[UserId] = 3;
                        }
                    }

                    if (conversation.conversation.unanswered == true)
                    {

                        if (statys[UserId] == 3)
                        {
                            //if (GryppSoob.Lines[0].Contains(Opros_1.Lines[0]))
                            //{

                            if (conversation.last_message.text.ToUpper().Contains(Opros_1.Lines[1].ToUpper()))
                            {
                                message = OtvetNa1p_1.Text;
                            }
                            else if (conversation.last_message.text.ToUpper().Contains(Opros_1.Lines[2].ToUpper()))
                            {
                                message = OtvetNa2p_1.Text;
                            }
                            else if (conversation.last_message.text.ToUpper().Contains(Opros_1.Lines[3].ToUpper()))
                            {
                                message = OtvetNa3p_1.Text;
                            }
                            else if (conversation.last_message.text.ToUpper().Contains(Opros_1.Lines[4].ToUpper()))
                            {
                                message = OtvetNa4p_1.Text;
                            }
                            else if (conversation.last_message.text.ToUpper().Contains(Opros_1.Lines[5].ToUpper()))
                            {
                                message = OtvetNa1p_2.Text;
                            }

                            else
                            {
                                message = "Я вас не понял. Проверьте, корректно ли вы задали вопрос";
                            }

                            //if(Item.response.count)
                            //}
                        }
                        
                        




                        //if (GryppSoob.Lines[0].Contains(Opros_2.Lines[0]))
                        //{

                        //    if (conversation.last_message.text.Contains("А"))
                        //    {
                        //        Otvet_2.Text = OtvetNa1p_2.Text;
                        //    }
                        //    else if (conversation.last_message.text.Contains("Б"))
                        //    {
                        //        Otvet_2.Text = OtvetNa2p_2.Text;
                        //    }
                        //    else if (conversation.last_message.text.Contains("В"))
                        //    {
                        //        Otvet_2.Text = OtvetNa3p_2.Text;
                        //    }
                        //    else if (conversation.last_message.text.Contains("Г"))
                        //    {
                        //        Otvet_2.Text = OtvetNa4p_2.Text;
                        //    }
                        //    else
                        //    {
                        //        Otvet_2.Text = "Вы не правильно ответили на 2-ой вопрос ";
                        //    }
                        //    message = Opros_3.Text;
                        //}


                        //if (GryppSoob.Lines[0].Contains(Opros_3.Lines[0]))
                        //{

                        //    if (conversation.last_message.text.Contains("А"))
                        //    {
                        //        Otvet_3.Text = OtvetNa1p_3.Text;
                        //    }
                        //    else if (conversation.last_message.text.Contains("Б"))
                        //    {
                        //        Otvet_3.Text = OtvetNa2p_3.Text;
                        //    }
                        //    else
                        //    {
                        //        Otvet_3.Text = "Вы не правильно ответили на 3-ий вопрос ";
                        //    }
                        //    message = Otvet_1.Text + Otvet_2.Text + Otvet_3.Text;
                        //}

                        string request2 = "https://api.vk.com/method/messages.send?peer_id="
                       + conversation.last_message.peer_id
                       + "&random_id=" + rnd.Next().ToString() + "&"
                       + "message=" + message + "&"
                       + access_token
                       + "&v=5.131";
                        answer = Encoding.UTF8.GetString(client.DownloadData(request2));
                    }
                    if (statys[UserId] == 1)
                    {
                        statys[UserId] = 2;
                        message = Privet.Text;

                        string request2 = "https://api.vk.com/method/messages.send?peer_id="
                       + conversation.last_message.peer_id
                       + "&random_id=" + rnd.Next().ToString() + "&"
                       + "message=" + message + "&"
                       + access_token
                       + "&v=5.131";
                        answer = Encoding.UTF8.GetString(client.DownloadData(request2));
                    }
                    if (statys[UserId] == 2)

                    {
                        statys[UserId] = 3;
                        message = Opros_1.Text;
                        string request2 = "https://api.vk.com/method/messages.send?peer_id="
                       + conversation.last_message.peer_id
                       + "&random_id=" + rnd.Next().ToString() + "&"
                       + "message=" + message + "&"
                       + access_token
                       + "&v=5.131";
                        answer = Encoding.UTF8.GetString(client.DownloadData(request2));
                    }
                   
                   
                }


            }
            catch
            {
                label2.Text = "есть";
            }
            
        }

        private void FantekriFormHelper_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Privet = Privet.Text;
            Properties.Settings.Default.Opros_1 = Opros_1.Text;
            Properties.Settings.Default.Opros_2 = Opros_2.Text;
            Properties.Settings.Default.Opros_3 = Opros_3.Text;
            Properties.Settings.Default.Otvet_1 = Otvet_1.Text;
            Properties.Settings.Default.Otvet_2 = Otvet_2.Text;
            Properties.Settings.Default.Otvet_3 = Otvet_3.Text;
            Properties.Settings.Default.OtvetNa1p_1 = OtvetNa1p_1.Text;
            Properties.Settings.Default.OtvetNa2p_1 = OtvetNa2p_1.Text;
            Properties.Settings.Default.OtvetNa3p_1 = OtvetNa3p_1.Text;
            Properties.Settings.Default.OtvetNa4p_1 = OtvetNa4p_1.Text;
            Properties.Settings.Default.OtvetNa1p_2 = OtvetNa1p_2.Text;
            Properties.Settings.Default.OtvetNa2p_2 = OtvetNa2p_2.Text;
            Properties.Settings.Default.OtvetNa3p_2 = OtvetNa3p_2.Text;
            Properties.Settings.Default.OtvetNa4p_2 = OtvetNa4p_2.Text;
            Properties.Settings.Default.OtvetNa1p_3 = OtvetNa1p_2.Text;
            Properties.Settings.Default.OtvetNa2p_3 = OtvetNa2p_3.Text;
            Properties.Settings.Default.Groop = Groop.Text;
            Properties.Settings.Default.Save();
        }

        private void FantekriFormHelper_Load(object sender, EventArgs e)
        {
            file();
            if(ch == 2)
            {
                checklicense.Checked = true;
            }
            access_token = "access_token=" + Groop.Text;
            Privet.Text = Properties.Settings.Default.Privet;
            Opros_1.Text = Properties.Settings.Default.Opros_1;
            Opros_2.Text = Properties.Settings.Default.Opros_2;
            Opros_3.Text = Properties.Settings.Default.Opros_3;
            Otvet_1.Text = Properties.Settings.Default.Otvet_1;
            Otvet_2.Text = Properties.Settings.Default.Otvet_2;
            Otvet_3.Text = Properties.Settings.Default.Otvet_3;
            OtvetNa1p_1.Text = Properties.Settings.Default.OtvetNa1p_1;
            OtvetNa2p_1.Text = Properties.Settings.Default.OtvetNa2p_1;
            OtvetNa3p_1.Text = Properties.Settings.Default.OtvetNa3p_1;
            OtvetNa4p_1.Text = Properties.Settings.Default.OtvetNa4p_1;
            OtvetNa1p_2.Text = Properties.Settings.Default.OtvetNa1p_2;
            OtvetNa2p_2.Text = Properties.Settings.Default.OtvetNa2p_2;
            OtvetNa3p_2.Text = Properties.Settings.Default.OtvetNa3p_2;
            OtvetNa4p_2.Text = Properties.Settings.Default.OtvetNa4p_2;
            OtvetNa1p_2.Text = Properties.Settings.Default.OtvetNa1p_3;
            OtvetNa2p_3.Text = Properties.Settings.Default.OtvetNa2p_3;
            Groop.Text = Properties.Settings.Default.Groop;


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Privet.Visible = true;
            Opros_1.Visible = true;
            Opros_2.Visible = true;
            Opros_3.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            OtvetNa1p_1.Visible = true;
            OtvetNa2p_1.Visible = true;
            OtvetNa3p_1.Visible = true;
            OtvetNa4p_1.Visible = true;
            OtvetNa1p_2.Visible = true;
            OtvetNa2p_2.Visible = true;
            OtvetNa3p_2.Visible = true;
            OtvetNa4p_2.Visible = true;
            OtvetNa1p_3.Visible = true;
            OtvetNa2p_3.Visible = true;
            label9.Visible = true;
            label10.Visible = true;
            label11.Visible = true;
            label12.Visible = true;
            label13.Visible = true;
            label14.Visible = true;
            label15.Visible = true;
            label16.Visible = true;
            label17.Visible = true;
            label18.Visible = true;
            label19.Visible = true;
            label20.Visible = true;
            label21.Visible = true;
            label22.Visible = true;
            label23.Visible = true;
            Groop.Visible = true;




            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            Otvet_1.Visible = false;
            Otvet_2.Visible = false;
            Otvet_3.Visible = false;
            PolzSoob.Visible = false;
            GryppSoob.Visible = false;
            id.Visible = false;
            id2.Visible = false;
            label4.Visible = false;
            label1.Visible = false;
            label3.Visible = false;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Privet.Visible = false;
            Opros_1.Visible = false;
            Opros_2.Visible = false;
            Opros_3.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            OtvetNa1p_1.Visible = false;
            OtvetNa2p_1.Visible = false;
            OtvetNa3p_1.Visible = false;
            OtvetNa4p_1.Visible = false;
            OtvetNa1p_2.Visible = false;
            OtvetNa2p_2.Visible = false;
            OtvetNa3p_2.Visible = false;
            OtvetNa4p_2.Visible = false;
            OtvetNa1p_3.Visible = false;
            OtvetNa2p_3.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            label13.Visible = false;
            label14.Visible = false;
            label15.Visible = false;
            label16.Visible = false;
            label17.Visible = false;
            label18.Visible = false;
            label19.Visible = false;
            label20.Visible = false;
            label21.Visible = false;
            label22.Visible = false;
            label23.Visible = false;
            Groop.Visible = false;



            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            Otvet_1.Visible = true;
            Otvet_2.Visible = true;
            Otvet_3.Visible = true;
            PolzSoob.Visible = true;
            GryppSoob.Visible = true;
            id.Visible = true;
            id2.Visible = true;
            label4.Visible = true;
            label1.Visible = true;
            label3.Visible = true;

        }

       private void file()
        {
            //string license = System.IO.File.ReadAllText(Application.StartupPath + @"\rfihs.txt");
            //if (license == textBox4.Text)
            //{
            //    checklicense.Checked = true;
            //}
        }
    }
}
