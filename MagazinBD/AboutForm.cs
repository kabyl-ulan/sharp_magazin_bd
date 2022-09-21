using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MessagingToolkit.QRCode.Codec;
using MessagingToolkit.QRCode.Codec.Data;

namespace MagazinBD
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
            string qrtext = "https://www.instagram.com/kabyl_ulan/";
            QRCodeEncoder encoder = new QRCodeEncoder(); ////создаем объект класса QRCodeEncoder
            Bitmap qrcode = encoder.Encode(qrtext); ////кодируем слово, полученное из TextBox'a (qrtext) в переменную qrcode. класса Bitmap(класс, который используется для работы с изображениями)
            pictureBox1.Image = qrcode as Image; //// pictureBox выводит qrcode как изображение.
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
