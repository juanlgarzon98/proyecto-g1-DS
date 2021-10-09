using  System;
using System.Collections.Generic;

namespace Ganaderia.App.Dominio
{
    public class Ejemplares
    {
        public int Id {get; set;}
        public string Raza {get; set;}
        public DateTime FechaIngreso {get; set;}
        public string Peso {get; set;}
        public string Genero {get; set;}
        public HistoriaClinica HistoriaClinica {get; set;}
        public Veterinario veterinario {get; set;}
        public List<Vacunas> vacunas {get; set;}
    }
}
