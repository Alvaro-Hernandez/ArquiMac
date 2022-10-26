using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlTypes;

namespace BackEnd.Models
{
    public class CursosArq
    {
        public int Id_Curso { get; set; }
        public int Id_Admin { get; set; }
        [Required, StringLength(250)]
        public string Imagen_Pres { get; set; }
        [Required, StringLength(50)]
        public string Nombre_Curso { get; set; }
        [Required, StringLength(250)]
        public string Descripcion { get; set; }
        public decimal Costo { get; set; }
        public Int16 Num_Materiales {get; set; }
        [Required, StringLength(120)]
        public string Docente {get; set;}
        public string Error { get; set; }
    }
}
