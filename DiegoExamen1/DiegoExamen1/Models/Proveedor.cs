using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DiegoExamen1.Models
{
    public class Proveedor
    {
        [Key]
        public int idProveedor { get; set; }
        [Required(ErrorMessage = "Este Campo es Requerido")]
        [DisplayName("Nombre Proveedor")]
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        public ICollection<Producto> Productos { get; set; }
    }
}