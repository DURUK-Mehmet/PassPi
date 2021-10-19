using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PassPi;

namespace PassPi.Forms
{
    public partial class PasswordingPage : Form
    {
        Methods.Methods methods = new Methods.Methods();
        OpenFileDialog file = new OpenFileDialog();

        public PasswordingPage()
        {
            InitializeComponent();
        }

        
        public void BtnPass_Click(object sender, EventArgs e)
        {
            string txt = TxtIn.ToString();
            string[] worlds=txt.Split(' ');
            methods.send(worlds);

        }
        private void TxtGive_Click(object sender, EventArgs e)
        {
            file.ShowDialog();
            string dosya_yolu = file.FileName;
            FileStream fs = new FileStream(dosya_yolu, FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine(methods.simple);
            sw.Close();
        }
    }
}
