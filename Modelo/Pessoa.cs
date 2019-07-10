namespace Dominio
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
    }

    public class Aluno : Pessoa
    {
        public decimal Nota { get; set; }
    }

    public class Professor : Pessoa
    {
        public string Materia { get; set; }
        public bool MeioPeriodo { get; set; }
    }
}
