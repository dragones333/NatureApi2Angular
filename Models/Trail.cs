namespace NatureApi2.Models
{
    public class Trail
    {
        public int Id { get; set; }                      
        public string Nombre { get; set; } = "";         
        public double DistanciaKm { get; set; }         
        public string Dificultad { get; set; } = "";   
        public string TiempoEstimado { get; set; } = ""; 
        public bool EsLoop { get; set; }                 
    }
}