namespace pooControledeNotas
{
    abstract public class ModeloMateria
    {
        public string Nome { get; set; }
        public double Nota1 { get; set; }
        public double Nota2 { get; set; }

        abstract public void ExibirDados();
    }
}
