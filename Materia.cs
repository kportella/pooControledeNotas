using System;

namespace pooControledeNotas
{
    public class Materia : ModeloMateria
    {
        public Materia()
        {
            this.Nome = "";
            this.Nota1 = 0;
            this.Nota2 = 0;
            this.MediaAprovacao = 5;
        }

        public Materia(string nome, double nota1, double nota2, double mediaAprovacao)
        {
            this.Nome = nome;
            this.Nota1 = nota1;
            this.Nota2 = nota2;
        }
        public double MediaAprovacao { get; set; }
        public double Media
        {
            get
            {
                return (this.Nota1 + this.Nota2) / 2;
            }
        }
        public override void ExibirDados()
        {
            Console.WriteLine("Materia: " + this.Nome);
            Console.WriteLine("1 Nota: " + this.Nota1);
            Console.WriteLine("2 Nota: " + this.Nota2);
            Console.WriteLine("Media: " + this.Media);
            Console.WriteLine("Media para aprovação: " + this.MediaAprovacao);
            Console.WriteLine("Status da matéria: " + this.StatusMateria());
        }

        public string StatusMateria()
        {
            if (this.Media >= this.MediaAprovacao)
            {
                return "Aluno aprovado na matéria";
            }
            return "Aluno não aprovado na matéria";
        }
    }
}
