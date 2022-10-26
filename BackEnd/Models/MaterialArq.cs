using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlTypes;

namespace BackEnd.Models
{
    public class MaterialArq
    {
        public int Id_Material { get; set; }
        public int Id_Curso { get; set; }
        [Required, StringLength(10)]
        public string Tipo_Material { get; set; }
        [Required, StringLength(250)]
        public string Almacenado_en { get; set; }
        public string Error { get; set; }
    }
}
