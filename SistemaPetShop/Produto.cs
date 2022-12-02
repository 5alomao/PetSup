using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPetShop
{
    internal class Produto
    {
        string nomeProduto;
        string precoCusto;
        string precoVenda;
        int marcaProduto;
        int categoriaProduto;
        string qntEstoque;

        public string NomeProduto { get => nomeProduto; set => nomeProduto = value; }
        public string PrecoCusto { get => precoCusto; set => precoCusto = value; }
        public string PrecoVenda { get => precoVenda; set => precoVenda = value; }
        public int MarcaProduto { get => marcaProduto; set => marcaProduto = value; }
        public int CategoriaProduto { get => categoriaProduto; set => categoriaProduto = value; }
        public string QntEstoque { get => qntEstoque; set => qntEstoque = value; }
    }
}
