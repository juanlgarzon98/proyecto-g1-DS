namespace Ganaderia.App.Dominio
{
    public class Veterinario : Persona
    {
        public float Latitud { get; set; }
        public float Longitud { get; set; }
        public float TargetaProfesional { get; set; }
        public float Especialidad { get; set; }        
    }
}