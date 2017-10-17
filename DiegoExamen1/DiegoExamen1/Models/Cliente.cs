using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DiegoExamen1.Models
{
    public class Cliente
    {
        [Key]
        public int idCliente { get; set; }
        [Required(ErrorMessage = "Este Campo es Requerido")]
        public int Cedula { get; set; }
        [Required(ErrorMessage = "Este Campo es Requerido")]
        [DisplayName("Nombre Cliente")]
        public string Nombre_Cliente { get; set; }
        [Required(ErrorMessage = "Este Campo es Requerido")]
        public string Apellido1 { get; set; }
        [Required(ErrorMessage = "Este Campo es Requerido")]
        public string Apellido2 { get; set; }
        [Required(ErrorMessage = "Este Campo es Requerido")]
        public string Direccion { get; set; }
        [Required(ErrorMessage = "Este Campo es Requerido")]
        public string Telefono { get; set; }
        [Required(ErrorMessage = "Este Campo es Requerido")]
        public string Correo { get; set; }
        // private List<Venta> ventas;
        [Display(Name = "Fecha Registro")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime FechaCreado { get; set; }

        public ICollection<Producto> Productos { get; set; }
        //public ICollection<Venta> Ventas { get; set; }

    }
}