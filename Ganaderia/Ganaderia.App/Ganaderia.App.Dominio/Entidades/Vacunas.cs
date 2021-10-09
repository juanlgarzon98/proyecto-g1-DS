using  System;
namespace Ganaderia.App.Dominio
{
    public class Vacunas
    {
        public int Id {get; set;}
        public string Nombre {get; set;}
        public string Lote {get; set;}
        public DateTime FechaVencimiento {get; set;}
        public string Laboratorio {get; set;}
    }
}