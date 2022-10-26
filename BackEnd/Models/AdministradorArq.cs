using System.ComponentModel.DataAnnotations;

namespace BackEnd.Models
{
    public class AdministradorArq
    {
        public int Id_Admin { get; set; }
        [Required, StringLength(40)]
        public string Nombres { get; set; }
        [Required, StringLength(40)]
        public string Apellidos { get; set; }
        [Required, StringLength(20)]
        public string Usuario { get; set; }
        [Required, StringLength(40)]
        public string Contrasena { get; set; }
        [Required, StringLength(60)]
        public string Email { get; set; }
        public string Error { get; set; }
    }
}
