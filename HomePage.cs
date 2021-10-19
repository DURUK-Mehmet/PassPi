using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PassPi.Forms;

namespace PassPi
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void BtnPass_Click(object sender, EventArgs e)
        {
            PasswordingPage passwordingPage = new PasswordingPage();
            passwordingPage.Show();
        }

        private void BtnDec_Click(object sender, EventArgs e)
        {
            DecoderPage decoderPage = new DecoderPage();
            decoderPage.Show();
        }
    }
}
