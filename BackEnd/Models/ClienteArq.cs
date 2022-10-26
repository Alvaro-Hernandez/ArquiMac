using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlTypes;

namespace BackEnd.Models
{
    public class ClienteArq
    {
        public int Id_Cliente { get; set; }
        [Required, StringLength(40)]
        public string Nombres { get; set; }
        [Required, StringLength(40)]
        public string Apellidos { get; set; }
        [Required, StringLength(20)]
        public string Usuario { get; set; }
        [Required, StringLength(40)]
        public string Contraseña { get; set; }
        [Required, StringLength(60)]
        public string Email { get; set; }
        public string Error { get; set; }
    }
}
