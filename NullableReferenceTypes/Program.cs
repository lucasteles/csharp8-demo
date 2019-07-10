//#nullable enable
namespace NullableReferenceTypes
{
    using static System.Console;

    class Program
    {
        bool ÉNulo( string texto) => texto == null;

        static void Main()
        {
            void PrintarTamanho(string texto )
            {
                WriteLine(texto.Length);
            }

            PrintarTamanho(null);


            var pessoa = new Pessoa("Lucas");
            WriteLine(@$"Tamanho do nome: {pessoa.TamanhoDoNome}");
            WriteLine($@"Tamanho do nome: {pessoa.TamanhoDoNome}");
        }

    }

    class Pessoa
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }

        public int TamanhoDoNome => Nome.Length + Sobrenome.Length;

        public Pessoa(string nome)
        {
            Nome = nome;
            Sobrenome = null;
        }
    }

}
