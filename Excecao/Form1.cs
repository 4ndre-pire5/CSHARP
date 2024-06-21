using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Excecao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                decimal valorCompra = Convert.ToDecimal(textBox1.Text);
                if (valorCompra < 0)
                {
                    throw new ApplicationException("Não é permitido números negativos.");
                }
                valorCompraLabel.Text = valorCompra.ToString("c");
            }
            catch (FormatException)
            {
                MessageBox.Show("Valor de compra inválido");
            }
            catch (OverflowException)
            {
                MessageBox.Show("Número muito grande");
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
