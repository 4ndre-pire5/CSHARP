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

namespace VisualizadorImagens
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] arquivos = Directory.GetFiles(@"c:\windows\web\wallpaper", "*.jpg", SearchOption.AllDirectories);
            imagemListBox.Items.AddRange(arquivos);
        }

        private void imagemListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBox.ImageLocation = imagemListBox.Text;
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void favoritosButton_Click(object sender, EventArgs e)
        {
            favoritosListBox.Items.Add(imagemListBox.Text);
        }

        private void favoritosListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBox.ImageLocation = favoritosListBox.Text;
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
        }

    }
}
