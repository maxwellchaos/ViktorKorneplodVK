using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testVk
{
    public partial class FormPostOnStrangeWall : Form
    {
        public string access_token;
        public FormPostOnStrangeWall()
        {
            InitializeComponent();
        }

        private void FormPostOnStrangeWall_Load(object sender, EventArgs e)
        {
            //показать access_token
            label1.Text = access_token;
        }
    }
}
