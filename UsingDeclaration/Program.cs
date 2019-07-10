
namespace UsingDeclaration
{
    using System.Collections.Generic;
    using System.IO;

    class Program
    {
        static void Main()
        {
            var lst = new [] { "Ola mundo", "Foo", "C#8" };
            Antigo(lst);
        }

        static void Antigo(IEnumerable<string> lines)
        {
            using (var file = new StreamWriter("linhas.txt"))
            {
                foreach (var line in lines)
                    file.WriteLine(line);
            }
        } 

        static void Novo(IEnumerable<string> lines)
        {
            using var file = new StreamWriter("linhas2.txt");

            foreach (var line in lines)
                file.WriteLine(line);
        }
    }
}
