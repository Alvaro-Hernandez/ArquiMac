using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlTypes;

namespace BackEnd.Models
{
    public class ImagenesDisenosArq
    {
        public int Id_Imagen { get; set; }
        public int Id_Diseno { get; set; }
        [Required, StringLength(250)]
        public string Almacenamiento { get; set; }
        public string Error { get; set; }
    }
}
