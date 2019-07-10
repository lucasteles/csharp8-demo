
namespace StaticLocalFunction
{
    using static System.Console;
    class Program
    {
        static void Main(string[] args)
        {
            var dependencia1 = 1;
            var dependencia2 = "ola mundo";

            ProcessamentoComLog(dependencia1, dependencia2);
            Processamento();
            ReadKey();
        }

        static void ProcessamentoComLog(int dependencia1, string dependencia2)
        {

            void log(string message) => WriteLine($"{dependencia1}:{dependencia2}={message}");

            log("aqui 1");

            log("aqui 2");

            dependencia1 = 2;

            log("aqui 3");

        }

        static void Processamento()
        {
            var numero = 1;
            static string utilSomenteAqui(string message) => $"Esta é a mensagem: {message}";

            utilSomenteAqui("Foo");
            utilSomenteAqui("Bar");

        }
    }
}
