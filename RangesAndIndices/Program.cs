namespace RangesAndIndices
{
    using System.Linq;
    using static System.Console;

    class Program
    {
        static void Main()
        {
            var array = Enumerable.Range(0, 20).ToArray();

            var i = 1;
            var valorNoIndiceI = array[i];
            var ultimoItem = array[^i];

            var (inicio, fim) = (2, 5);
            var slice = array[inicio..fim]; // final não inclusivo
            var sliceReverso = array[inicio..^fim];


            WriteLine($"Valor no índice: {valorNoIndiceI}");
            WriteLine($"Valor no fim: {ultimoItem}");
            WriteLine($"slice do {inicio} ao {fim}: {string.Join(",", slice)}");
            WriteLine($"slice reverso do {inicio} ao {fim}: {string.Join(",", sliceReverso)}");


            ReadKey();
        }
    }

}
