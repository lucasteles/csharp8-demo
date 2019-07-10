
namespace PropertyPatterns
{
    using Dominio;
    using static System.Console;

    class Program
    {
        static void Main(string[] args)
        {
            var pessoa = new Pessoa { Nome = "Jose", Idade = 29 };

            WriteLine(QuemSou(pessoa));
            WriteLine(Condicional(pessoa));
        }

        static string QuemSou(Pessoa pessoa) =>
            pessoa switch
            {
                { Nome: "Jose", Idade: 19 } => "Sou Jose tenho 19 anos",
                { Nome: "João" } => "Sou João",
                { Nome: "Maria" } => "Sou Maria",
                _ => "Não sou conhecido",
            };

        static string Condicional(Pessoa obj) =>
           obj switch
           {
               Pessoa p when p.Nome == "Lucas" => "F# é melhor!",
               Pessoa p when p.Nome == "João" || p.Nome == "Maria" => "Nome comum",
               Aluno a when a.Nota > 6 => "Passou de ano",
               Professor _ => "You shall not pass",
               _ => "Nada a declarar"
           };
    }
}
