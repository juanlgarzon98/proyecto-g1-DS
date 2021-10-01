using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Ganaderia.App.Dominio;

namespace Ganaderia.App.Presentacion.Pages
{
    public class ListModel : PageModel
    {
        public List<Ganadero> Ganaderos { get; set; }
        public void OnGet()
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
        Ganaderos=new List<Ganadero>();
        Ganaderos.Add(ganadero);
        }
    }
}
