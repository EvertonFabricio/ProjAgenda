using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
    internal class ListaTel
    {


        public Telefones Head { get; set; }
        public Telefones Tail { get; set; }

        public ListaTel()
        {
            Head = null;
            Tail = null;
        }

        public void insert(Telefones novo)
        {


            if (Head == null && Tail == null)
            {
                Head = novo;
                Tail = novo;
            }
            else
            {
                Tail.Next = novo;
            }
        }

        public void Print()
        {
            Telefones telefone = Head;

            Console.WriteLine(ToString());
            telefone = telefone.Next;
        }
    }
}
