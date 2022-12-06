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
        int donoPet;
        string corPet;

        public string NomePet { get => nomePet; set => nomePet = value; }
        public string TipoPet { get => tipoPet; set => tipoPet = value; }
        public string RacaPet { get => racaPet; set => racaPet = value; }
        public string PortePet { get => portePet; set => portePet = value; }
        public int DonoPet { get => donoPet; set => donoPet = value; }
        public string CorPet { get => corPet; set => corPet = value; }
    }
}
