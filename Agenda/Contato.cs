using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
    internal class Contato
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public Contato Next { get; set; }
        public Telefones Telefone { get; set; }

        public Contato(string nome, string email, Telefones telefone)
        {
            Nome = nome;
            Email = email;
            Next = null;
            Telefone = telefone;
        }

        public override string ToString()
        {
            return $"Informações do Contato:\nContato: {Nome}\ne-mail: {Email}\nTelefone: {Telefone.ToString()}\n";  

        }
    }
}
