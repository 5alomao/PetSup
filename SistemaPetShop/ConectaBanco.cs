using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace SistemaPetShop
{
    internal class ConectaBanco
    {
        MySqlConnection conectaBD = new MySqlConnection("server=localhost;user id=root;password=;database=pet_shop");//conectando ao banco de dados
        public String mensagem; //criando variável mensagem

        public DataTable listaPets()
        {
            MySqlCommand cmd = new MySqlCommand("proc_listaPet", conectaBD);
            cmd.CommandType = CommandType.StoredProcedure; 
            try
            {
                conectaBD.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable tabela = new DataTable();
                da.Fill(tabela);
                return tabela;
            }
            catch (MySqlException e)
            {
                mensagem = "Erro:" + e.Message;
                return null;
            }
            finally
            {
                conectaBD.Close();
            }
        }
        public DataTable listaClientes()
        {
            MySqlCommand cmd = new MySqlCommand("proc_listaCliente", conectaBD);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                conectaBD.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable tabela = new DataTable();
                da.Fill(tabela);
                return tabela;
            }
            catch (MySqlException e)
            {
                mensagem = "Erro: " + e.Message;
                return null;
            }
            finally
            {
                conectaBD.Close();
            }
        }
        public bool insereCliente(Cliente c)
        {
            MySqlCommand cmd = new MySqlCommand("proc_insereCliente", conectaBD);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("nome", c.NomeCliente);
            cmd.Parameters.AddWithValue("cpf", c.CpfCliente);
            cmd.Parameters.AddWithValue("email", c.EmailCliente);
            cmd.Parameters.AddWithValue("telefone", c.TelefoneCliente);
            cmd.Parameters.AddWithValue("endereco", c.EnderecoCliente);
            try
            {
                conectaBD.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (MySqlException e)
            {
                mensagem = "Erro:" + e.Message;
                return false;
            }
            finally
            {
                conectaBD.Close();
            }
        }

    }
}
