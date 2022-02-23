using System;

namespace Agenda
{
    internal class Program
    {
        public static int Menu()
        {
            bool flag = true;
            string choice;
            int op = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("\n >>>> AGENDA DE CONTATOS <<<<\n ");
                Console.WriteLine(" 1 - Inserir Contato");
                Console.WriteLine(" 2 - Buscar Contato");
                Console.WriteLine(" 3 - Imprimir Agenda");
                Console.WriteLine(" 4 - Editar Contato");
                Console.WriteLine(" 5 - Remover Contato");
                Console.WriteLine(" 6 - Sair\n");
                Console.Write("\n Escolha: ");
                choice = Console.ReadLine();
                int.TryParse(choice, out op);

                if ((op < 1) || (op > 6))
                {
                    Console.WriteLine("Opcao Invalida");
                    Console.WriteLine("Pressione ENTER para voltar...");
                    Console.ReadKey();
                }
                else
                {
                    flag = false;
                }
            } while (flag);

            return op;
        }

        public static Contato InserirContato()
        {
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("E-mail: ");
            string email = Console.ReadLine();
            Console.Write("Tipo (celular, comercial, residencial...): ");
            string tipo = Console.ReadLine();
            Console.Write("DDD: ");
            string ddd = Console.ReadLine();
            Console.Write("Numero: ");
            string tel = Console.ReadLine();

            return new Contato(nome, email, new Telefones(tipo, ddd, tel));

        }

        static void Main(string[] args)
        {
            Lista lista = new Lista();

            bool flag = true;
            int op = Menu();

            do
            { 
                switch (op)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("\n Inserir Contato \n");
                        lista.insert(InserirContato());
                        op = Menu();
                        break;

                    case 2:
                        Console.WriteLine("\n Buscar Contato \n");
                        Console.ReadKey();
                        op = Menu();
                        break;
                    case 3:
                        Console.WriteLine("\n Imprimir Agenda \n");
                        lista.print();
                        Console.ReadKey();
                        op = Menu();
                        break;
                    case 4:
                        Console.WriteLine("\n Editar Contato \n");
                        Console.ReadKey();
                        op = Menu();
                        break;
                    case 5:
                        Console.WriteLine("\n Remover Contato \n");
                        Console.ReadKey();
                        break;
                    case 6:
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Opcao Invalida");
                        Console.WriteLine("Pressione ENTER para voltar...");
                        Console.ReadKey();
                        break;
                }
            } while (flag);

            Console.Clear();
            Console.WriteLine("\n >>>>>> Obrigado por usar nosso sistema. <<<<<<<\n");

        }
    }
}

