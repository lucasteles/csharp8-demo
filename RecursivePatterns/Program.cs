
namespace RecursivePatterns
{
    using Dominio;
    using System;

    //using SomePessoa = Program.Some<Dominio.Pessoa>;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

        }


        class Point2D
        {
            public int X { get; set; }
            public int Y { get; set; }

            public void Deconstruct(out int x, out int y)
            {
                x = X;
                y = Y;
            }
        }

        class Point3D : Point2D
        {
            public int Z { get; set; }
            public void Deconstruct(out int x, out int y, out int z)
            {
                x = X;
                y = Y;
                z = Z;
            }
        }


        string ShowPoint(Point2D point) =>
            point switch
            {
                Point2D { X: var x, Y: 0 } => $"{x} para y=0",
                Point2D (int x, 1) => $"{x} para y=1",
                Point3D { X: var x, Y: var y, Z: 1 } => $"x={x}, y={y} para z = 1",
                Point3D (int x, int y, int z) => $"x={x}, y={y}, z={z}",
                _ => "",
            };


        public abstract class Option<T> { }
        public class None<T> : Option<T> { }
        public class Some<T> : Option<T> {
            public T Value { get; }
            public Some(T value) => Value = value;

            public void Deconstruct(out T value) => value = Value;
        }

        public string ShowOptions()
        {
            Option<Pessoa> talvezPessoa =
                new Some<Pessoa>(new Pessoa { Nome = "Lucas", Idade = 18 })
                //new None<Pessoa>()
                ;

            if (talvezPessoa is None<Pessoa>)
                return "Não é ninguém";


            if (talvezPessoa is Some<Pessoa> somePessoa)
            {
                var pessoa = somePessoa.Value;

                if (pessoa.Idade == 18)
                    return pessoa.Nome;
            }

            return "ué";

        }

        static string ObterNomeSeTiver18Anos(Option<Pessoa> talvezPessoa) =>
            talvezPessoa switch
            {
                None<Pessoa> _ => "Não é ninguém",

                Some<Pessoa> somePessoa when somePessoa.Value.Idade > 18 => somePessoa.Value.Nome,

                //Some<Pessoa> { Value: var p  } when p.Idade == 18 => p.Nome,
                //SomePessoa { Value: var p } when p.Idade == 18 => p.Nome,
                //SomePessoa { Value: { Nome: var nome, Idade: 18 } } => nome,

                //Some<Pessoa> (var pessoa) when pessoa.Idade == 18 => pessoa.Nome,
                //Some<Pessoa> ({ Idade: 18, Nome: var nome }) => nome,

                _ => "ué",
            };


    }
}
