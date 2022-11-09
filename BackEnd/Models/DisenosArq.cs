using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlTypes;
namespace BackEnd.Models
{
    public class DisenosArq
    {
        public int Id_Diseno { get; set; }
        public int Id_Admin { get; set; }
        [Required, StringLength(500)]
        public string Descripcion { get; set; }
        [Required, StringLength(50)]
        public string Pais_Ubic { get; set; }
        [Required, StringLength(50)]
        public string Ciudad_Ubic { get; set; }
        [Required, StringLength(50)]
        public string Estilo_Art { get; set; }
        [Required, StringLength(50)]
        public string Creado_por { get; set; }
        public string Error { get; set; }
        //public List<ImagenesDisenosArq> imgDisenos { get; set; }
    }
}
