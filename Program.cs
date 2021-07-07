using System;

namespace pooControledeNotas
{
    class Program
    {
        static void Main(string[] args)
        {
            int op = 0;
            // Materia m1 = new Materia("Matematica", 5, 7, 5);
            // m1.ExibirDados();

            Console.WriteLine("Controle de matérias");
            while (op != 5)
            {
                op = ExibirMenu();
                switch (op)
                {
                    case 1:
                        Console.ReadKey();
                        break;

                    case 2:
                        Console.ReadKey();
                        break;

                    case 3:
                        Console.ReadKey();
                        break;

                    case 4:
                        Console.ReadKey();
                        break;
                }
            }
        }

        static int ExibirMenu()
        {
            int op = 0;
            try
            {
                while (op < 1 || op > 5)
                {
                    Console.WriteLine("1 - Exibir materias");
                    Console.WriteLine("2 - Cadastrar Matérias");
                    Console.WriteLine("3 - Alterar dados das materias");
                    Console.WriteLine("4 - Excluir dados das materias");
                    Console.WriteLine("5 - Sair do sistema");
                    Console.Write("Opcao: ");
                    op = Convert.ToInt32(Console.ReadLine());
                }
            }
            catch
            {
                op = 0;
            }
            return op;
        }
    }
}
