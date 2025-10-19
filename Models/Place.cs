using System.Collections.Generic;

namespace NatureApi2.Models
{
    public class Place
    {
        public int Id { get; set; }                      
        public string Nombre { get; set; } = "";         
        public string Categoria { get; set; } = "";     
        public string Descripcion { get; set; } = "";   
        public double Latitud { get; set; }              
        public double Longitud { get; set; }            
        public double Altitud { get; set; }              
        public bool Accesible { get; set; }              
        public decimal CuotaEntrada { get; set; }       
        public string Horario { get; set; } = "";        
        public List<string> Amenities { get; set; } = new(); 
        public List<string> Fotos { get; set; } = new();     
        public List<Trail> Senderos { get; set; } = new();  
    }
}