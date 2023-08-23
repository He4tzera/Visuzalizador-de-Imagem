using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Visualizador_de_Imagem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] arquivos = Directory.GetFiles(@"C:\Windows\Web\Wallpaper", "*.jpg", SearchOption.AllDirectories);
            imagensListBox.Items.AddRange(arquivos);
        }

        private void addFav_Click(object sender, EventArgs e)
        {
            favListBox.Items.Add(imagensListBox.Text);
        }

        private void imagensListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = imagensListBox.Text;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void removeFav_Click(object sender, EventArgs e)
        {
            favListBox.Items.Remove(imagensListBox.Text);
        }
    }
}
