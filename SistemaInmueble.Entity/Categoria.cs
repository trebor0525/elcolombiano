using System;
using System.Collections.Generic;

namespace SistemaInmueble.Entity
{
    public partial class Categoria
    {
        public Categoria()
        {
            Proyectos = new HashSet<Proyecto>();
        }

        public int IdCategoria { get; set; }
        public string? Descripcion { get; set; }
        public bool? EsActivo { get; set; }
        public DateTime? FechaRegistro { get; set; }

        public virtual ICollection<Proyecto> Proyectos { get; set; }
    }
}
