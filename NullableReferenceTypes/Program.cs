//#nullable enable
namespace NullableReferenceTypes
{
    using static System.Console;

    class Program
    {
        static void Main(string[] args)
        {
            var pessoa = new Pessoa("Lucas");

            WriteLine(@$"Tamanho do nome: {pessoa.TamanhoDoNome()}");
            WriteLine($@"Tamanho do nome: {pessoa.TamanhoDoNome()}");
        }
    }

    class Pessoa
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }

        public int TamanhoDoNome()
        {
            return Nome.Length + Sobrenome.Length;
        }

        public Pessoa(string nome)
        {
            Nome = nome;
            Sobrenome = null;
        }
    }

}
