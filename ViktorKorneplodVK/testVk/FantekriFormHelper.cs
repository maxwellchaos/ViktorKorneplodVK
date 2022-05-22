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


        public string access_token = "access_token=823c822ff364b9ed48ec99c118b2b4a22d9ed79296ade35de85193c79d8e40514f2a7866482ce40f95089";
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

                message = Privet.Text;
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
                WebClient client = new WebClient();
                string request = "https://api.vk.com/method/messages.getConversations?"
                        + access_token
                        + "&v=5.131";
                string answer = Encoding.UTF8.GetString(client.DownloadData(request));

                messages_getConversations unanswered = JsonConvert.DeserializeObject<messages_getConversations>(answer);
                //getHistory
                string request1 = "https://api.vk.com/method/messages.getHistory?peer_id="
                                      + unanswered.response.items[0].last_message.peer_id + "&"
                                      + access_token
                                      + "&v=5.131";
                answer = Encoding.UTF8.GetString(client.DownloadData(request1));
                messages_getHistory Item = JsonConvert.DeserializeObject<messages_getHistory>(answer);
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

                //try - попытаться выполнить
                //{

                //}
                //catch - если ошибка, то сделать это
                //{

                //}















                ////label1.Text = access_token;
                //WebClient client = new WebClient();
                //string request = "https://api.vk.com/method/messages.getConversations?"
                //        + access_token
                //        + "&v=5.131";
                //string answer = Encoding.UTF8.GetString(client.DownloadData(request));

                ////textBox1.Text = answer;
                Random rnd = new Random();

                messages_getConversations avatar = JsonConvert.DeserializeObject<messages_getConversations>(answer);

                //messages_getConversations unanswered = JsonConvert.DeserializeObject<messages_getConversations>(answer);

                messages_getConversations last_message = JsonConvert.DeserializeObject<messages_getConversations>(answer);



                //textBox1.Text = unanswered.response.items[0].conversation.unanswered.ToString();
                foreach (messages_getConversations.Item conversation in unanswered.response.items)
                {
                    //textBox1.Text = textBox1.Text + conversation.conversation.unanswered.ToString() + "\r\n";

                    message = Privet.Text;
                    if (conversation.conversation.unanswered == true)
                    {


                        if (conversation.last_message.text.Contains("Готов"))
                        {
                            message = Opros_1.Text;
                        }

                        if (GryppSoob.Text.Contains(Opros_1.Text))
                        {

                            if (conversation.last_message.text.Contains("А"))
                            {
                                Otvet_1.Text = OtvetNa1p_1.Text;
                            }
                            else if (conversation.last_message.text.Contains("Б"))
                            {
                                Otvet_1.Text = OtvetNa2p_1.Text;
                            }
                            else if (conversation.last_message.text.Contains("В"))
                            {
                                Otvet_1.Text = OtvetNa3p_1.Text;
                            }
                            else if (conversation.last_message.text.Contains("Г"))
                            {
                                Otvet_1.Text = OtvetNa4p_1.Text;
                            }
                            else
                            {
                                Otvet_1.Text = "Вы не правильно ответили на 1-ый вопрос ";
                            }
                            message = Opros_2.Text;
                        }




                        if (GryppSoob.Text.Contains(Opros_2.Text))
                        {

                            if (conversation.last_message.text.Contains("А"))
                            {
                                Otvet_2.Text = OtvetNa1p_2.Text;
                            }
                            else if (conversation.last_message.text.Contains("Б"))
                            {
                                Otvet_2.Text = OtvetNa2p_2.Text;
                            }
                            else if (conversation.last_message.text.Contains("В"))
                            {
                                Otvet_2.Text = OtvetNa3p_2.Text;
                            }
                            else if (conversation.last_message.text.Contains("Г"))
                            {
                                Otvet_2.Text = OtvetNa4p_2.Text;
                            }
                            else
                            {
                                Otvet_2.Text = "Вы не правильно ответили на 2-ой вопрос ";
                            }
                            message = Opros_3.Text;
                        }


                        if (GryppSoob.Text.Contains(Opros_2.Text))
                        {

                            if (conversation.last_message.text.Contains("А"))
                            {
                                Otvet_3.Text = OtvetNa1p_3.Text;
                            }
                            else if (conversation.last_message.text.Contains("Б"))
                            {
                                Otvet_3.Text = OtvetNa2p_3.Text;
                            }
                            else
                            {
                                Otvet_3.Text = "Вы не правильно ответили на 3-ий вопрос ";
                            }
                            message = Otvet_1.Text + Otvet_2.Text + Otvet_3.Text;
                        }

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
    }
}
