namespace SwitchExpression
{
    class Program
    {
        enum Semana
        {
            Segunda = 2,
            Terca,
            Quarta,
            Quinta,
            Sexta,
            Sabado,
            Domingo
        }

        static void Main()
        {


        }

        static string SwitchVelho(Semana semana)
        {
            switch (semana)
            {
                case Semana.Segunda:
                    return "Segunda";

                case Semana.Terca:
                    return "Terça";

                case Semana.Quarta:
                    return "Quarta";

                case Semana.Quinta:
                    return "Quinta";

                case Semana.Sexta:
                    return "Sexta";

                case Semana.Sabado:
                    return "Sábado";

                case Semana.Domingo:
                    return "Domingo";

                default:
                    return "";
            };

        }


        static string SwitchNovo(Semana semana)
        {
            var retorno = semana switch
            {
                Semana.Segunda => "Segunda",
                Semana.Terca => "Terça",
                Semana.Quarta => "Quarta",
                Semana.Quinta => "Quinta",
                Semana.Sexta => "Sexta",
                Semana.Sabado => "Sábado",
                Semana.Domingo => "Domingo",
                _ => "",
            };

            return retorno;
        }


    }
}
