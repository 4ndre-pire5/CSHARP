using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADONET
{
    public partial class Form1 : Form
    {
        private SqlConnection connection = new SqlConnection();

        public Form1()
        {
            InitializeComponent();
        }

        private void Mensagem(string msg)
        {
            listBox1.Items.Add(msg);
        }

        public void CriarConexao()
        {
            connection.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;
                                            Initial Catalog=EmpresaDb;
                                            Integrated Security=True";
        }

        private void conectarButton_Click(object sender, EventArgs e)
        {
            // SQL Server
            //  SqlConnection
            //      ConnectionString
            //      Open()
            //      Close()
            // SqlCommand
            // SqlDataReader

            CriarConexao();

            connection.Open();
            Mensagem("Conexão Aberta");

            connection.Close();
            Mensagem("Conexão Fechada");
        }

        private void selectButton_Click(object sender, EventArgs e)
        {
            CriarConexao();

            var command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "SELECT Nome FROM Cliente";

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                string nome = reader["Nome"].ToString();
                Mensagem(nome);
            }

            reader.Close();
            connection.Close();

        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            CriarConexao();

            var command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "INSERT INTO Cliente(Id, Nome, Email, Telefone) Values(@Id, @Nome, @Email, @Telefone)";
            command.Parameters.AddWithValue("@Id", 2);
            command.Parameters.AddWithValue("@Nome", "Andre Figueiredo");
            command.Parameters.AddWithValue("@Email", "andre_fig@teste.com");
            command.Parameters.AddWithValue("@Telefone", "(11) 98765-4321");

            connection.Open();
            Mensagem("Conexão Aberta");

            command.ExecuteNonQuery();
            Mensagem("Registro Incluído");

            connection.Close();
            Mensagem("Conexão Fechada");

        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            CriarConexao();

            var command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "UPDATE Cliente SET Nome=@Nome WHERE Id=@Id";
            command.Parameters.AddWithValue("@Id", 2);
            command.Parameters.AddWithValue("@Nome", "Andre Alterado Figueiredo");

            connection.Open();

            command.ExecuteNonQuery();
            Mensagem("Registro Alterado");

            connection.Close();


        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            CriarConexao();

            var command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "DELETE Cliente WHERE Id=@Id";
            command.Parameters.AddWithValue("@Id", 2);

            connection.Open();

            command.ExecuteNonQuery();
            Mensagem("Registro Excluído");

            connection.Close();

        }
    }
}
