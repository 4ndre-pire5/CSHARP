﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Empresa.UI.Windows
{
    public partial class principalForm : Form
    {
        public principalForm()
        {
            InitializeComponent();
        }

        private void novoClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClienteIncluirForm f = new ClienteIncluirForm();
            f.ShowDialog();
        }
    }
}
