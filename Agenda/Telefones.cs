using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
    internal class Telefones
    {
        public string Tipo { get; set; }
        public string DDD { get; set; }
        public string Numero { get; set; }
        public Telefones Next { get; set; }

        public Telefones(string tipo, string dDD, string numero)
        {
            Tipo = tipo;
            DDD = dDD;
            Numero = numero;
            Next = null;
        }
        public override string ToString()
        {

            return $"{Tipo}: ({DDD}) {Numero}.";
        }

    }
}
