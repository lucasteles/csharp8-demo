namespace DefaultInterfaceMethods
{
    using static System.Console;

    class Program
    {
        interface IA
        {
            void M()
            {
                WriteLine("IA.M");
            }
        }

        class B : IA { } // OK

        static void Main(string[] args)
        {
            IA i = new B();
            i.M(); // prints "IA.M"

            //new B().M(); // error
        }

    }
}
