﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            tabuadaListBox.Items.Clear();   

            int tabuada = Convert.ToInt32(tabuadaTextBox.Text);

            for (int i = 1; i <=10; i++)
            {
                tabuadaListBox.Items.Add(string.Format("{0} x {1} = {2}", tabuada, i, i * tabuada));
            }
        }
    }
}
