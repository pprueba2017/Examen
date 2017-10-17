using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DiegoExamen1.Models
{
    public class Venta
    {
        [Key]
        public int idVenta { get; set; }


        [Required(ErrorMessage = "Este Campo es Requerido")]
        [DisplayName("Total Venta")]
        public Double Total_Venta { get; set; }

        [DisplayName("Nombre Cliente")]
        public string Nom_Cliente { get; set; }
   

        [DisplayName("Nombre Vendedor")]
        public string Nom_Vendedor { get; set; }
     

        [DisplayName("Nombre Producto")]
        public int Nom_Producto { get; set; }
       
        public double Precio { get; set; }

        public int Cantidad_Vendida { get; set; }
    }
}