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
                if (!(materias.Exists(x => x.Nome.Equals(materia.Nome))))
                {
                    materias.Add(materia);
                }
                else
                {
                    System.Console.WriteLine("Matéria já cadastrada");
                }
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

        public bool excluirMateria(string Nome)
        {
            bool retorno = false;
            if (this.materias.Exists(x => x.Nome.Equals(Nome)))
            {
                retorno = true;
                this.materias.Remove(this.materias.Find(x => x.Nome.Equals(Nome)));
            }

            return retorno;
        }

        public bool alterarMateria(Materia materia)
        {
            bool retorno = false;
            if (this.materias.Exists(x => x.Nome.Equals(materia.Nome)))
            {
                retorno = true;
                Materia materiaNew = (this.materias.Find(x => x.Nome.Equals(materia.Nome)));
                materiaNew.Nota1 = materia.Nota1;
                materiaNew.Nota2 = materia.Nota2;
            }

            return retorno;
        }
    }
}
