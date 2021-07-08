using System.Collections.Generic;

namespace pooControledeNotas
{
    public class GerenciadorDeMaterias
    {
        public GerenciadorDeMaterias()
        {
            this.Estudante = new Aluno();
            this.materias = new List<Materia>();
        }

        public GerenciadorDeMaterias(string nome, string email)
        {
            this.Estudante = new Aluno(nome, email);
            this.materias = new List<Materia>();
        }
        public Aluno Estudante { get; set; }
        private List<Materia> materias;

        public List<Materia> Materias
        {
            get
            {
                return this.materias;
            }
        }

        public void cadastrarMateria(Materia materia)
        {
            try
            {
                materias.Add(materia);
            }
            catch (System.Exception)
            {
                throw new System.Exception("Erro ao cadastrar matéria");
            }
        }

        public void listarMaterias()
        {
            System.Console.WriteLine("***** Matérias *****");
            for (int i = 0; i < materias.Count; i++)
            {
                Materia m = materias[i];
                m.ExibirDados();
                System.Console.WriteLine("********");
            }
        }
    }
}
