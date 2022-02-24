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
            if (Head == null && Tail == null)
                return true;
            else
                return false;
        }
        public void print()
        {
            if (empty())
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










        //public void ordenar()
        //{
        //    if (empty())
        //        Console.WriteLine("Não existem contatos para ser ordenado.");
        //    else
        //    {
        //        for (Contato sort1 = Head; sort1 != null; sort1 = sort1.Next)
        //        {
        //            for (Contato sort2 = sort1.Next; sort2 != null; sort2 = sort2.Next)
        //            {
        //                if (string.Compare(sort1.Nome, sort2.Nome) > 0)
        //                {
        //                    string nome, email;
        //                    Telefones telefone;

        //                    nome = sort1.Nome;
        //                    email = sort1.Email;
        //                    telefone = sort1.Telefone;

        //                    sort1.Nome = sort2.Nome;
        //                    sort1.Email = sort2.Email;
        //                    sort1.Telefone = sort2.Telefone;

        //                    sort2.Nome = nome;
        //                    sort2.Email = email;
        //                    sort2.Telefone = telefone;
        //                }
        //            }
        //        }
        //    }
        //}
    }
}
