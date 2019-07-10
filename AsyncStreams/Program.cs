
namespace AsyncStreams
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using static System.Console;


    class Program
    {
        static async Task Main()
        {

            await AsyncDisposable();


            await AsyncUsing();


            await foreach (var item in MyIterator())
            {
                WriteLine(item);
            }
        }

        
        static async IAsyncEnumerable<int> MyIterator()
        {
            try
            {
                for (int i = 0; i < 100; i++)
                {
                    await Task.Delay(1000);
                    yield return i;
                }
            }
            finally
            {
                await Task.Delay(200);
                WriteLine("finally");
            }
        }


        static async Task AsyncUsing()
        {
            await using (var enumerator = MyIterator().GetAsyncEnumerator())
            {
                while (await enumerator.MoveNextAsync())
                {
                    var item = enumerator.Current;
                    WriteLine(item);
                }
            }
        }

        static async Task AsyncDisposable()
        {
            var enumerator = MyIterator().GetAsyncEnumerator();
            try
            {
                while (await enumerator.MoveNextAsync())
                {
                    var item = enumerator.Current;
                    WriteLine(item);
                }
            }
            finally
            {
                await enumerator.DisposeAsync(); // omitted, along with the try/finally, if the enumerator doesn't expose DisposeAsync
            }
        }

    }
}
