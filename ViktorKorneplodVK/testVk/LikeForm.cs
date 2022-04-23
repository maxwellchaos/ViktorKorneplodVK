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
    public partial class LikeForm : Form
    {
        public string access_token;
        public LikeForm()
        {
            InitializeComponent();
        }

        private void LikeForm_Load(object sender, EventArgs e)
        {
            label1.Text = access_token;
        }
    }
}
