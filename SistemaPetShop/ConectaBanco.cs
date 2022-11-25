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
            cmd.Parameters.AddWithValue("bairro", c.BairroCliente);
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

        public bool inserePet(Pet p)
        {
            MySqlCommand cmd = new MySqlCommand("proc_inserePet", conectaBD);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("nome", p.NomePet);
            cmd.Parameters.AddWithValue("raca", p.RacaPet);
            cmd.Parameters.AddWithValue("porte", p.PortePet);
            cmd.Parameters.AddWithValue("tipo", p.TipoPet);
            cmd.Parameters.AddWithValue("cor", p.CorPet);
            cmd.Parameters.AddWithValue("codCli", p.DonoPet);
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

        public bool deletaCliente(int codCliente)
        {
            MySqlCommand cmd = new MySqlCommand("proc_deletaCliente", conectaBD);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("codCli", codCliente);
            try
            {
                conectaBD.Open();
                cmd.ExecuteNonQuery(); // executa o comando
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
        }// fim deleta Cliente

        public bool alteraCliente(Cliente c, int codCliente)
        {
            MySqlCommand cmd = new MySqlCommand("proc_alteraCliente", conectaBD);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("codCli", codCliente);
            cmd.Parameters.AddWithValue("nome", c.NomeCliente);
            cmd.Parameters.AddWithValue("cpf", c.CpfCliente);
            cmd.Parameters.AddWithValue("email", c.EmailCliente);
            cmd.Parameters.AddWithValue("telefone", c.TelefoneCliente);
            cmd.Parameters.AddWithValue("endereco", c.EnderecoCliente);
            cmd.Parameters.AddWithValue("bairro", c.BairroCliente);
            try
            {
                conectaBD.Open();
                cmd.ExecuteNonQuery(); // executa o comando
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
        }// fim altera cliente

        public bool deletaPet(int codPet)
        {
            MySqlCommand cmd = new MySqlCommand("proc_deletaPet", conectaBD);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("codP", codPet);
            try
            {
                conectaBD.Open();
                cmd.ExecuteNonQuery(); // executa o comando
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
        }// fim deleta Pet

        public bool alteraPet(Pet p, int codPet)
        {
            MySqlCommand cmd = new MySqlCommand("proc_alteraPet", conectaBD);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("codP", codPet);
            cmd.Parameters.AddWithValue("nome", p.NomePet);
            cmd.Parameters.AddWithValue("tipo", p.TipoPet);
            cmd.Parameters.AddWithValue("cor", p.CorPet);
            cmd.Parameters.AddWithValue("raca", p.RacaPet);
            cmd.Parameters.AddWithValue("porte", p.PortePet);
            cmd.Parameters.AddWithValue("codCli", p.DonoPet);
            try
            {
                conectaBD.Open();
                cmd.ExecuteNonQuery(); // executa o comando
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
        }// fim altera cliente

    }
}
