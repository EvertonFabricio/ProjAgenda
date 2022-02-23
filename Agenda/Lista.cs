using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
    internal class Lista
    {
        public Contato Head { get; set; }
        public Contato Tail { get; set; }

        public Lista()
        {
            Head = null;
            Tail = null;
        }

        public bool empty()
        {
            if (Head == null)
                return true;
            else
                return false;
        }
        public void print()
        {
            Contato aux = Head;
            do
            {
                Console.WriteLine(aux.ToString());
                aux = aux.Next;

            } while (aux != null);
        }
        public void insert(Contato novo)
        {
            if (empty())
            {
                Head = novo;
                Tail = novo;
                Console.WriteLine("Contato inserido com sucesso!");
            }
            else
            {
                novo.Prev = Tail;
                Tail.Next = novo;
                Tail = novo;
                Console.WriteLine("Contato inserido com sucesso!");
            }

        }
        public void ordenar()
        {
            if (empty())
                Console.WriteLine("Não existem contatos para ser ordenado.");
            else
            {
                for (Contato aux = Head; aux != null; aux = aux.Next)
                {
                    for (Contato aux2 = aux.Next; aux2 != null; aux2 = aux2.Next)
                    {
                        if (string.Compare(aux.Nome, aux2.Nome) > 0)
                        {
                            aux.Next = aux2.Next;
                            aux.Prev = aux2;
                            aux2.Prev = aux.Prev;
                            aux2.Next = aux;
                        }
                    }
                }










            }





        }
    }
}
