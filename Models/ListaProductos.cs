namespace ExamenFinal.Models
{
    public class ListaProductos
    {
        public List<Bebidas> Bebidas { get; set; } = new List<Bebidas>();
        public List<PlatoFuerte> PlatoFuerte { get; set; } = new List<PlatoFuerte>();
        public List<Postres> Postres { get; set; } = new List<Postres>();
    }
}
