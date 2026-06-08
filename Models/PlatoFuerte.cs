namespace ExamenFinal.Models
{
    public class PlatoFuerte : Productos
    {
        public enum TipoCarne{
           Res,
            Pollo,
            Pescado,
            Vegetariano
        }
        public TipoCarne Carne { get; set; }
        public enum Acompaniamiento
        {
            Arroz,
            Papas,
            Ensalada
        }
        public Acompaniamiento Acompaniamiento1 { get; set; }
    }
}
