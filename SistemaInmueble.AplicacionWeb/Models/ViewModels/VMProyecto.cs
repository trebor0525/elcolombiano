using SistemaInmueble.Entity;

namespace SistemaInmueble.AplicacionWeb.Models.ViewModels
{
    public class VMProyecto
    {
        public int IdProducto { get; set; }
        public string? CodigoBarra { get; set; }
        public string? Marca { get; set; }
        public string? Descripcion { get; set; }
        public int? IdCategoria { get; set; }
        public string? NombreCategoria { get; set; }
        public int? Stock { get; set; }
        public string? UrlImagen { get; set; }
        public string? Precio { get; set; }
        public int? EsActivo { get; set; }
    }
}
