using System;
using Ganaderia.App.Dominio;
using Ganaderia.App.Persistencia;

namespace Ganaderia.App.Consola
{
    class Program
    {
        private static IRepositorioGanadero _repositorioGanadero = new RepositorioGanadero(new Persistencia.AppContext());
        private static IRepositorioEjemplares _repositorioEjemplares = new RepositorioEjemplares(new Persistencia.AppContext()); 
        private static IRepositorioFinca _repositorioFinca = new RepositorioFinca(new Persistencia.AppContext()); 
        private static IRepositorioHistoriaClinica _repositorioHistoriaClinica = new RepositorioHistoriaClinica(new Persistencia.AppContext()); 
        private static IRepositorioPersona _repositorioPersona = new RepositorioPersona(new Persistencia.AppContext()); 
        private static IRepositorioSolicitud _repositorioSolucitud = new RepositorioSolicitud(new Persistencia.AppContext()); 
        private static IRepositorioVacunas _repositorioVacunas = new RepositorioVacunas(new Persistencia.AppContext()); 
        private static IRepositorioVeterinario _repositorioVeterinario = new RepositorioVeterinario(new Persistencia.AppContext()); 
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
        private static void AddVeterinario()
        {
            var veterinario = new Veterinario
            {
                Nombres = "Juan",
                Apellidos = "Cuadrado",
                NumeroTelefono = "311511111",
                Correo = "juancuadrado@mintic.edu.co",
                Contrasena = "98765",
                TargetaProfesional = 2131,
                Especialidad = "asd"
            };

            _repositorioVeterinario.AddVeterinario(veterinario);


        }

    }
}
