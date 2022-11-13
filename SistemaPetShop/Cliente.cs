using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPetShop
{
    internal class Cliente
    {
        string nomeCliente;
        string emailCliente;
        string cpfCliente;
        string telefoneCliente;
        string enderecoCliente;

        public string NomeCliente { get => nomeCliente; set => nomeCliente = value; }
        public string EmailCliente { get => emailCliente; set => emailCliente = value; }
        public string CpfCliente { get => cpfCliente; set => cpfCliente = value; }
        public string TelefoneCliente { get => telefoneCliente; set => telefoneCliente = value; }
        public string EnderecoCliente { get => enderecoCliente; set => enderecoCliente = value; }
    }
}
