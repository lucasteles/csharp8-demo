namespace TuplePatterns
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            Console.WriteLine(Saudar("Lucas", "Teles", "Agostinho"));
            Console.WriteLine(FizzBuzz(20).Aggregate((acc, n) => $"{acc}, {n}"));
        }

        static string Saudar(string nome, string nomeDoMeio, string sobrenome) =>
            (nome, nomeDoMeio, sobrenome) switch
            {
                (string f, string m, string l) => $"{f} {m[0]}. {l}",
                (string f, null    , string l) => $"{f} {l}",
                (string f, string m, null)     => $"{f} {m}",
                (string f, null    , null)     => $"{f}",
                (null    , string m, string l) => $"Sr/Sra {m[0]}. {l}",
                (null    , null    , string l) => $"Sr/Sra {l}",
                (null    , string m, null)     => $"Sr/Sra {m}",
                (null    , null    , null)     => "Alguém",
            };

        static IEnumerable<string> FizzBuzz(int qtd) =>
            Enumerable.Range(1, qtd)
            .Select(n => (n % 3, n % 5) switch
            {
                (0, 0) => "FizzBuzz",
                (0, _) => "Fizz",
                (_, 0) => "Buzz",
                (_, _) => n.ToString(),
            });
    }
}
