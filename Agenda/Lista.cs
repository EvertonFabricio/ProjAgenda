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

        public void insert(Contato novo)
        {
            if (empty())
            {
                Head = Tail = novo;
                
                Console.WriteLine("Contato inserido com sucesso!");
            }
            else
            {

                ordenar(novo);

                Console.WriteLine("Contato inserido com sucesso!");
            }

        }

        public void ordenar(Contato aux)
        {
            Contato aux1 = Head, aux2 = Head;

            StringComparer comparer = StringComparer.CurrentCultureIgnoreCase;

            do
            {
                if (comparer.Compare(aux.Nome, Head.Nome) <= 0)
                {
                    aux.Next = Head;
                    Head = aux;
                    aux1 = null;
                }
                else if (comparer.Compare(aux.Nome, Tail.Nome) >= 0)
                {
                    Tail.Next = aux;
                    Tail = aux;
                    aux1 = null;
                }
                else
                {
                    if (comparer.Compare(aux1.Nome, aux.Nome) <= 0)
                    {
                        if (aux1 == aux2)
                        {
                            if (aux1 == aux2)
                            {
                                aux1 = aux1.Next;
                            }
                            else
                            {
                                aux2 = aux1;
                                aux1 = aux1.Next;
                            }
                        }
                    }
                    else
                    {
                        aux.Next = aux1;
                        aux2.Next = aux;
                        aux1 = null;
                    }
                }
            } while (aux1 != null);

            aux1 = null;
            aux2 = null;

            /*for (Contato aux = Head; aux != null; aux = aux.Next)
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
            }*/
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

        public bool empty()
        {
            if ((Head == null) && (Tail == null))
                return true;
            else
                return false;
        }

    }
}
