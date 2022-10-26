using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlTypes;

namespace BackEnd.Models
{
    public class VentasArq
    {
        public int Id_Venta { get; set; }
        public int Id_Curso { get; set; }
        public int Id_Cliente { get; set; }
        public decimal Descuento { get; set; }
        public decimal Costo_Total { get; set; }
        public string Error { get; set; }
    }
}