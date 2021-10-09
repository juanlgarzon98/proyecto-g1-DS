namespace Ganaderia.App.Dominio
{
    public class Ganadero : Persona
    {
        public int Ejemplares { get; set; }
        public string Finca { get; set;} 
        public float Latitud { get; set; }
        public float Longitud { get; set; }
    }
}