using System;

namespace pooControledeNotas
{
    public class Aluno : InterfaceAluno
    {
        public Aluno()
        {
            this.Nome = "";
            this.Email = "";
        }

        public Aluno(string nome, string email)
        {
            this.Nome = nome;
            this.Email = email;
        }

        private string nome;
        public string Nome
        {
            get { return this.nome; }
            set { this.nome = value.ToUpper(); }
        }

        private string email;
        public string Email
        {
            get { return this.email; }
            set { this.email = value.ToUpper(); }
        }

        public void ExibirDados()
        {
            Console.WriteLine("Dados do Aluno");
            Console.WriteLine("Nome: " + this.Nome);
            Console.WriteLine("Dados do Aluno: " + this.Email);
        }
    }
}
