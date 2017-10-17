using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DiegoExamen1.Models
{
    public class Vendedor
    {
        [Key]
        public int idVendedor { get; set; }
        [Required(ErrorMessage = "Este Campo es Requerido")]
        [DisplayName("Nombre Vendedor")]
        public string Nombre_Vendedor { get; set; }
        [Required(ErrorMessage = "Este Campo es Requerido")]
        public string Cedula { get; set; }
        [Required(ErrorMessage = "Este Campo es Requerido")]
        public string Apellido1 { get; set; }
        [Required(ErrorMessage = "Este Campo es Requerido")]
        public string Apellido2 { get; set; }
        [Required(ErrorMessage = "Este Campo es Requerido")]
        public string Telefono { get; set; }
        public string Correo { get; set; }
        [Display(Name = "Fecha Registro")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime FechaCreado { get; set; }

        // public ICollection<Venta> Ventas { get; set; }
        public ICollection<Producto> Productos { get; set; }
    }
}