using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Empresa.Models;

namespace Empresa.DB
{
    public class ClienteDb
    {
        public void Incluir(Cliente cliente)
        {
            string sql = "INSERT INTO Cliente(Id, Nome, Email, Telefone) Values(@Id, @Nome, @Email, @Telefone)";
            var connection = new SqlConnection(Db.Conexao);
            var command = new SqlCommand(sql, connection);

            command.Parameters.AddWithValue("@Id", cliente.Id);
            command.Parameters.AddWithValue("@Nome", cliente.Nome);
            command.Parameters.AddWithValue("@Email", cliente.Email);
            command.Parameters.AddWithValue("@Telefone", cliente.Telefone);

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void Alterar(Cliente cliente)
        {
            string sql = "UPDATE Cliente SET Nome=@Nome, Email=@Email, Telefone=@Telefone WHERE Id=@Id";
            var connection = new SqlConnection(Db.Conexao);
            var command = new SqlCommand(sql, connection);

            command.Parameters.AddWithValue("@Id", cliente.Id);
            command.Parameters.AddWithValue("@Nome", cliente.Nome);
            command.Parameters.AddWithValue("@Email", cliente.Email);
            command.Parameters.AddWithValue("@Telefone", cliente.Telefone);

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void Excluir(int Id)
        {
            string sql = "DELETE Cliente WHERE Id=@Id";
            var connection = new SqlConnection(Db.Conexao);
            var command = new SqlCommand(sql, connection);

            command.Parameters.AddWithValue("@Id", Id);

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        public List<Cliente> Listar() 
        {
            string sql = "SELECT Id, Nome, Email, Telefone FROM Cliente";
            var connection = new SqlConnection(Db.Conexao);
            var command = new SqlCommand(sql, connection);

            List<Cliente> lista = new List<Cliente>();

            connection.Open();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            { 
                var cliente = new Cliente();

                cliente.Id = Convert.ToInt32(reader["Id"]);
                cliente.Nome = reader["Nome"].ToString();
                cliente.Email = reader["Email"].ToString();
                cliente.Telefone = reader["Telefone"].ToString();

                lista.Add(cliente);
            }
            reader.Close();
            connection.Close();
            return lista;
        }
    }
}
