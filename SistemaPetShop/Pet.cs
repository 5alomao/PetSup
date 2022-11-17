using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPetShop
{
    internal class Pet
    {
        string nomePet;
        string tipoPet;
        string racaPet;
        string portePet;
        string donoPet;

        public string NomePet { get => nomePet; set => nomePet = value; }
        public string TipoPet { get => tipoPet; set => tipoPet = value; }
        public string RacaPet { get => racaPet; set => racaPet = value; }
        public string PortePet { get => portePet; set => portePet = value; }
        public string DonoPet { get => donoPet; set => donoPet = value; }
    }
}
