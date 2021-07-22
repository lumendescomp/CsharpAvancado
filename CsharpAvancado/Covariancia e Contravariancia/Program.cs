using System;

namespace Covariancia_e_Contravariancia
{
    class Program
    {
        static void Main(string[] args)
        {
            //As estruturas que suportam a aplicação dos conceitos de covariância e contravariância são as interfaces e delegates genéricos.
            ManipuladorFTP<Nivel1> ftp = new ManipuladorFTP<Nivel1>();
            ftp.Armazenar(new Nivel1());
            ftp.Armazenar(new Nivel2());
            ftp.Armazenar(new Nivel3());
            Console.WriteLine(ftp.Recuperar(0));
            Console.WriteLine(ftp.Recuperar(1));
            Console.WriteLine(ftp.Recuperar(2));

            IArmazenador<Nivel2> armazenador = ftp;
            armazenador.Armazenar(new Nivel2());
            armazenador.Armazenar(new Nivel3());

            IRecuperador<Nivel1> recuperador = ftp;
            Console.WriteLine(recuperador.Recuperar(0));
            Console.WriteLine(recuperador.Recuperar(1));
            Console.WriteLine(recuperador.Recuperar(2));
            Console.WriteLine(recuperador.Recuperar(3));
            Console.WriteLine(recuperador.Recuperar(4));
            Console.ReadLine();
        }
    }
}
