using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
    internal class ListaCont
    {
        public Contato Head { get; set; }
        public Contato Tail { get; set; }

        public ListaCont()
        {
            Head = null;
            Tail = null;
        }

        public bool Empt()
        {
            if (Head == null && Tail == null)
                return true;
            else
                return false;
        }
        public void Print()
        {
            if (Empt())
            {
                Console.WriteLine("Não existem contatos para serem exibidos. Pressione ENTER para continuar...");
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                Contato aux = Head;
                do
                {
                    Console.WriteLine(aux.ToString());
                    aux = aux.Next;
                    Console.WriteLine("Pressine ENTER para ver o próximo contato...");
                    Console.ReadKey();
                } while (aux != null);

                Console.WriteLine("Fim dos contatos. Pressione ENTER para continuar...");
                Console.ReadKey();
                Console.Clear();
            }
        }
        public void Insert(Contato novo)
        {
            if (Empt())
            {
                Head = novo;
                Tail = novo;
                Console.WriteLine("Contato inserido com sucesso!");
            }
            else
            {
                Contato aux1 = Head;
                Contato aux2 = Head;

                StringComparer comparer = StringComparer.CurrentCultureIgnoreCase;

                do
                {
                    if (comparer.Compare(novo.Nome, Head.Nome) <= 0)
                    {
                        novo.Next = Head;
                        Head = novo;
                        aux1 = null;
                        Console.WriteLine("Contato inserido com sucesso!");
                    }
                    else if (comparer.Compare(novo.Nome, Tail.Nome) >= 0)
                    {
                        Tail.Next = novo;
                        Tail = novo;
                        aux1 = null;
                        Console.WriteLine("Contato inserido com sucesso!");
                    }
                    else
                    {
                        aux1 = Head;
                        aux2 = aux1;
                        aux1 = aux1.Next;

                        if (comparer.Compare(aux1.Nome, novo.Nome) >= 0)
                        {
                            novo.Next = aux1;
                            aux2.Next = novo;
                            aux1 = null;
                            Console.WriteLine("Contato inserido com sucesso!");
                        }
                    }
                } while (aux1 != null);

            }

        }
    }
}
