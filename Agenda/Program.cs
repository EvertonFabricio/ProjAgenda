using System;

namespace Agenda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ListaCont lista = new ListaCont();
            ListaTel newtel = new ListaTel();

            do
            {
                Console.WriteLine(">>>>Agenda de Contatos<<<<\nDigite a opção Desejada:");
                Console.WriteLine("\n1 - Inserir contato\n2 - Localizar contato\n3 - Editar contato\n4 - Remover contato\n5 - Imprimir contatos\n0 - Sair\n");

                string menu = Console.ReadLine();
                Console.Clear();
                switch (menu)
                {
                    case "1":

                        //lista.Insert(new Contato("Everton", "e@e", new Telefones("1", "1", "1")));
                        //lista.Insert(new Contato("Roberta", "r@r", new Telefones("2", "2", "2")));
                        //lista.Insert(new Contato("Fabricio", "f@f", new Telefones("3", "3", "3")));
                        //lista.Insert(new Contato("Ana", "a@a", new Telefones("4", "4", "4")));
                        //lista.Insert(new Contato("Zebra", "z@z", new Telefones("5", "5", "5")));
                        //lista.Insert(new Contato("Barbara", "z@z", new Telefones("5", "5", "5")));

                        //Console.WriteLine("\n\n");
                        //lista.Print();

                        Console.WriteLine("Digite o nome do contato: ");
                        string nome = Console.ReadLine();
                        Console.WriteLine("\nDigite o email do contato: ");
                        string email = Console.ReadLine();
                        Console.WriteLine("\nDigite o telefone do contato: ");
                        Console.Write("DDD: ");
                        string ddd = Console.ReadLine();
                        Console.Write("Telefone: ");
                        string telef = Console.ReadLine();
                        Console.Write("Tipo: ");
                        string tipo = Console.ReadLine();
                        Telefones t1 = new Telefones(tipo, ddd, telef);
                        newtel.insert(t1);

                        do
                        {
                            Console.WriteLine("Deseja inserir outro contato?\nS - sim\nN - não");
                            string choice = Console.ReadLine().ToLower();

                            switch (choice)
                            {
                                case "s":
                                    Console.Write("DDD: ");
                                    ddd = Console.ReadLine();
                                    Console.Write("Telefone: ");
                                    telef = Console.ReadLine();
                                    Console.Write("Tipo: ");
                                    tipo = Console.ReadLine();
                                    t1 = new Telefones(tipo, ddd, telef);
                                    break;

                                case "n":
                                    lista.Insert(new Contato(nome, email, t1));
                                    Console.Clear();
                                    break;

                                default:
                                    Console.WriteLine("Opção invalida. Tente novamente.");
                                    break;
                            }
                            if (choice == "n")
                                break;
                        } while (true);
                        break;

                    case "2":
                        //buscar
                        break;

                    case "3":
                        //Edita
                        break;

                    case "4":
                        //remove
                        break;

                    case "5":
                        lista.Print();
                        break;

                    case "0":
                        //sair
                        break;

                    default:
                        Console.WriteLine("Opção invalida. Tente novamente.");
                        Console.Clear();
                        break;
                }
                if (menu == "0")
                    break;

            } while (true);
        }
    }
}

