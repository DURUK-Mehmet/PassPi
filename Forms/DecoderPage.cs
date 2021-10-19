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

namespace PassPi.Forms
{
    public partial class DecoderPage : Form
    {
        public DecoderPage()
        {
            InitializeComponent();
        }
        Methods.Methods methods = new Methods.Methods();
        OpenFileDialog file = new OpenFileDialog();

        private void BtnDec_Click(object sender, EventArgs e)
        {

        }
        public string DosyadanOku(string dosya_yolu)
        {
            FileStream fs = new FileStream(dosya_yolu, FileMode.Open, FileAccess.Read);
            //Bir file stream nesnesi oluşturuyoruz. 1.parametre dosya yolunu,
            //2.parametre dosyanın açılacağını,
            //3.parametre dosyaya erişimin veri okumak için olacağını gösterir.
            StreamReader sw = new StreamReader(fs);
            //Okuma işlemi için bir StreamReader nesnesi oluşturduk.
            string yazi = sw.ReadLine();
            //Satır satır okuma işlemini gerçekleştirdik ve ekrana yazdırdık
            //Son satır okunduktan sonra okuma işlemini bitirdik
            sw.Close();
            fs.Close();
            //İşimiz bitince kullandığımız nesneleri iade ettik.
            return yazi;
        }

        private void TxtTake_Click(object sender, EventArgs e)
        {
            file.ShowDialog();
            string dosya_yolu = file.FileName;
            TxtIn.Text = DosyadanOku(dosya_yolu);
        }
    }
}
