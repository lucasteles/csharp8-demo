
namespace AsyncStreams
{
    using System.Collections.Generic;
    using System.IO;
    using System.Threading.Tasks;
    using static System.Console;


    class Program
    {
        static async Task Main()
        {

            //await AsyncDisposable();
            //await AsyncUsing();


            //await foreach (var item in CountLinesOfFile())
            foreach (var item in CountLinesOfFile())
            {
                WriteLine(item);
            }
        }

        //static async IAsyncEnumerable<int> CountLinesOfFile()
        static IEnumerable<int> CountLinesOfFile()
        {
            try
            {
                using var reader = new StreamReader(File.OpenRead("file.txt"));
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    //var line = await reader.ReadLineAsync();
                    yield return line.Length;
                }

            }
            finally
            {
                WriteLine("ACABOU!");
            }
        }


        //static async Task AsyncUsing()
        //{
        //    await using (var enumerator = CountLinesOfFile().GetAsyncEnumerator())
        //    {
        //        while (await enumerator.MoveNextAsync())
        //        {
        //            var item = enumerator.Current;
        //            WriteLine(item);
        //        }
        //    }
        //}

        //static async Task AsyncDisposable()
        //{
        //    var enumerator = CountLinesOfFile().GetAsyncEnumerator();
        //    try
        //    {
        //        while (await enumerator.MoveNextAsync())
        //        {
        //            var item = enumerator.Current;
        //            WriteLine(item);
        //        }
        //    }
        //    finally
        //    {
        //        await enumerator.DisposeAsync(); // omitted, along with the try/finally, if the enumerator doesn't expose DisposeAsync
        //    }
        //}

    }
}
