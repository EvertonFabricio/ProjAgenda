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
        public Telefones Prev { get; set; }

        public Telefones(string tipo, string ddd, string numero)
        {
            Tipo = tipo;
            DDD = ddd;
            Numero = numero;
            Next = null;
            Prev = null;
        }
        public override string ToString()
        {
            return $"{Tipo}: ({DDD}) {Numero}.";
        }

    }
}
