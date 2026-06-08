namespace ExamenFinal.Models
{
    public class Bebidas:Productos
    {
        public int medida { get; set; } = 0;
        public enum Tipobebida
        {
            Refresco,
            Cerveza,
            Agua
        }
        public Tipobebida tipobebida1 { get; set; } 
        
    }
}
