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

        public bool insereMarca(Marca m)
        {
            MySqlCommand cmd = new MySqlCommand("proc_insereMarca", conectaBD);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("nome", m.NomeMarca);
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
        public bool insereCategoria(Categoria cat)
        {
            MySqlCommand cmd = new MySqlCommand("proc_insereCategoria", conectaBD);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("nome", cat.NomeCategoria);
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

        public bool deletaMarca(int codMarca)
        {
            MySqlCommand cmd = new MySqlCommand("proc_deletaMarca", conectaBD);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("codMar", codMarca);
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
        }

        public bool deletaProduto(int codProd)
        {
            MySqlCommand cmd = new MySqlCommand("proc_deletaProduto", conectaBD);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("codProd", codProd);
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
        }
        public bool deletaCategoria(int codCategoria)
        {
            MySqlCommand cmd = new MySqlCommand("proc_deletaCategoria", conectaBD);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("codCat", codCategoria);
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
        }

        public bool alteraMarca(Marca m, int codMarca)
        {
            MySqlCommand cmd = new MySqlCommand("proc_alteraMarca", conectaBD);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("codMar", codMarca);
            cmd.Parameters.AddWithValue("nome", m.NomeMarca);
            
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
        }
        public bool alteraCategoria(Categoria cat, int codCategoria)
        {
            MySqlCommand cmd = new MySqlCommand("proc_alteraCategoria", conectaBD);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("codCat", codCategoria);
            cmd.Parameters.AddWithValue("nome", cat.NomeCategoria);

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
        }
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

        public bool insereUsuarios(Usuario u)
        {
            MySqlCommand cmd = new MySqlCommand("proc_insereUser", conectaBD);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("nomeU", u.NomeUser);
            cmd.Parameters.AddWithValue("senhaU", u.SenhaUser);
            cmd.Parameters.AddWithValue("emailU", u.EmailUser);

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
        public bool verifica(string user, string pass)
        {
            string senhaHash = Hash.makeHash(pass);
            MySqlCommand cmd = new MySqlCommand("proc_consultaLogin", conectaBD);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("nomeU", user);
            cmd.Parameters.AddWithValue("senhaU", senhaHash);
            try
            {
                conectaBD.Open();//abrindo a conexão;
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();// tabela virtual
                da.Fill(ds); //passando os valores consultados para o DataSet
                if (ds.Tables[0].Rows.Count > 0) // verifica se houve retorno
                    return true;
                else
                    return false;

            }
            catch (MySqlException er)
            {
                mensagem = "Erro" + er.Message;
                return false;
            }
            finally
            {
                conectaBD.Close();
            }
        }
        public bool insereProdutos(Produto pr)
        {
            MySqlCommand cmd = new MySqlCommand("proc_insereProduto", conectaBD);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("nome", pr.NomeProduto);
            cmd.Parameters.AddWithValue("codCat", pr.CategoriaProduto);
            cmd.Parameters.AddWithValue("codMar", pr.MarcaProduto);
            cmd.Parameters.AddWithValue("precoC", pr.PrecoCusto);
            cmd.Parameters.AddWithValue("precoV", pr.PrecoVenda);
            cmd.Parameters.AddWithValue("estoque", pr.QntEstoque);

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
        public bool alteraProdutos(Produto pr, int codProd)
        {
            MySqlCommand cmd = new MySqlCommand("proc_alteraProduto", conectaBD);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("codProd",codProd);
            cmd.Parameters.AddWithValue("nome", pr.NomeProduto);
            cmd.Parameters.AddWithValue("codCat", pr.CategoriaProduto);
            cmd.Parameters.AddWithValue("codMar", pr.MarcaProduto);
            cmd.Parameters.AddWithValue("precoC", pr.PrecoCusto);
            cmd.Parameters.AddWithValue("precoV", pr.PrecoVenda);
            cmd.Parameters.AddWithValue("estoque", pr.QntEstoque);

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
        public DataTable listaCategorias()
        {
            // comentario
            MySqlCommand cmd = new MySqlCommand("proc_listaCategoria", conectaBD);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                conectaBD.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable tabela = new DataTable();
                da.Fill(tabela);
                return tabela;
            }// fim try
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

        public DataTable listaMarcas()
        {
            // comentario
            MySqlCommand cmd = new MySqlCommand("proc_listaMarca", conectaBD);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                conectaBD.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable tabela = new DataTable();
                da.Fill(tabela);
                return tabela;
            }// fim try
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
        public DataTable listaProdutos()
        {
            // comentario
            MySqlCommand cmd = new MySqlCommand("proc_listaProduto", conectaBD);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                conectaBD.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable tabela = new DataTable();
                da.Fill(tabela);
                return tabela;
            }// fim try
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
    }
}
