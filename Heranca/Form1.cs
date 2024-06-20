using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Heranca
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Aluno aluno = new Aluno();
            aluno.Matricula = "20205/2018";
            aluno.Nome = "José da Silva";
            aluno.Email = "josedasilva@teste.com.br";

            Funcionario funcionario = new Funcionario();
            funcionario.Nome = "Maria da Silva";
            funcionario.Email = "mariadasilva@teste.com.br";
            funcionario.Cargo = "Secretária";
            funcionario.Salario = 2540;

            listBox1.Items.Add(aluno.Matricula);
            listBox1.Items.Add(aluno.Nome);
            listBox1.Items.Add(aluno.Email);
            listBox1.Items.Add("-----------------");
            listBox1.Items.Add(funcionario.Nome);
            listBox1.Items.Add(funcionario.Email);
            listBox1.Items.Add(funcionario.Cargo);
            listBox1.Items.Add(funcionario.Salario);
            listBox1.Items.Add("-----------------");
        }

        private void EnviarEmail(CadastroBase dados)
        {
            string mensagem = string.Format("Enviando email para {0}", dados.Nome);
            listBox1.Items.Add(mensagem);   
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CadastroBase a = new Aluno();
            a.Nome = "Joaquim";

            CadastroBase b = new Funcionario();
            b.Nome = "Antonio";

            EnviarEmail(a);
            EnviarEmail(b);

        }
    }
}
