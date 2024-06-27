using Empresa.DB;
using Empresa.Models;
using System;
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
    public partial class ClientesForm : Form
    {
        public ClientesForm()
        {
            InitializeComponent();
        }

        private void ExibirGrid()
        {
            listaDataGridView.Visible = true;
            listaDataGridView.Dock = DockStyle.Fill;
            fichaPanel.Visible = false;
            novoButton.Visible = true;
            alterarButton.Visible = true;
            excluirButton.Visible = true;
            sairButton.Visible = true;
            confirmarAlterarButton.Visible = false;
            confirmarExcluirButton.Visible = false;
            confirmarIncluirButton.Visible = false;
            voltarButton.Visible = false;

            var db = new ClienteDb();
            listaDataGridView.DataSource = db.Listar();
        }

        private void ClientesForm_Load(object sender, EventArgs e)
        {
            ExibirGrid();

        }
    }
}
