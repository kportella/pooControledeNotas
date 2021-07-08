using System;

namespace pooControledeNotas
{
    class Program
    {
        static void Main(string[] args)
        {
            int op = 0;
            string NomeMateria = "";
            double n1 = 0, n2 = 0, mo = 5;
            Materia materia;
            GerenciadorDeMaterias gerenciador = new GerenciadorDeMaterias("Danilo", "danilo@email.com");
            Console.WriteLine("Controle de matérias");
            while (op != 5)
            {
                Console.WriteLine("Controle de matérias");
                gerenciador.Estudante.ExibirDados();
                op = ExibirMenu();
                Console.Clear();
                switch (op)
                {
                    case 1:
                        gerenciador.listarMaterias();
                        Console.ReadKey();
                        break;

                    case 2:
                        Console.WriteLine("Cadastro de materias");
                        Console.Write("Materia: ");
                        NomeMateria = Console.ReadLine();
                        Console.Write("1 Nota: ");
                        n1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("2 Nota: ");
                        n2 = Convert.ToDouble(Console.ReadLine());

                        materia = new Materia(NomeMateria, n1, n2, mo);
                        gerenciador.cadastrarMateria(materia);
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
