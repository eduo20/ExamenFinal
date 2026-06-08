namespace ExamenFinal.Models
{
    public class Postres : Productos
    {
        public bool azucar { get; set; } 
        public enum Tipoporcion
        {
            Individual,
            Compartida
        }
        public Tipoporcion Tipoporcion1 { get; set; }

    }
}
