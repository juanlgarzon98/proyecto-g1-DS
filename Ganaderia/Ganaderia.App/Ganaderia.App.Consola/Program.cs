using System;
using Ganaderia.App.Dominio;
using Ganaderia.App.Persistencia;

namespace Ganaderia.App.Consola
{
    class Program
    {
        private static IRepositorioGanadero _repositorioGanadero = new RepositorioGanadero(new Persistencia.AppContext()); 
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            AddGanadero();
        }

        private static void AddGanadero()
        {
            var ganadero = new Ganadero
            {
                Nombres = "Sergio",
                Apellidos = "Moreno",
                NumeroTelefono = "3148596562",
                Correo = "sergiomintic@mintic.edu.co",
                Contrasena = "123456",
                Latitud = 4554,
                Longitud = 5454
            };

            _repositorioGanadero.AddGanadero(ganadero);


        }
        
    }
}
