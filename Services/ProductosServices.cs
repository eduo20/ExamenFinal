using System.Text.Json;
using ExamenFinal.Models;


namespace ExamenFinal.Services
{
    public class ProductosServices
    {
        private readonly string _datosProductos = "Productos.json";

        public ListaProductos ObtenerListas()
        {
            if (!File.Exists(_datosProductos))
            {
                return new ListaProductos();
            }
            try
            {
                var jsonData = File.ReadAllText(_datosProductos);
                return JsonSerializer.Deserialize<ListaProductos>(jsonData) ?? new ListaProductos();
            }
            catch
            {

                return new ListaProductos();
            }
        }

        public void GuardadBedbidas(Bebidas bebidas)
        {
            ListaProductos lista = ObtenerListas();
            lista.Bebidas.Add(bebidas);

            string json = JsonSerializer.Serialize(lista, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(_datosProductos, json);

        }

        public void GuardarPlatoFuerte(PlatoFuerte platoFuerte)
        {
            ListaProductos lista = ObtenerListas();
            lista.PlatoFuerte.Add(platoFuerte);
            string json = JsonSerializer.Serialize(lista, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(_datosProductos, json);

        }

        public void GuardarPostres(Postres postres)
        {
            ListaProductos lista = ObtenerListas();
            lista.Postres.Add(postres);
            string json = JsonSerializer.Serialize(lista, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(_datosProductos, json);
        }
    }
}

