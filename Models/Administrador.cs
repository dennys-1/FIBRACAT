using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FIBRACAT.Models
{
    public class Administrador
    {
        [Key]
        public int CID { get; set; }
        [Column(TypeName ="nvarchar(250)")]
        [Required(ErrorMessage ="This field is required.")]
        [DisplayName("CORREO")]
        public string CORREO { get; set; }
        [Column(TypeName = "varchar(10)")]
        [DisplayName("TELEFONO")]
        public string TELEFONO { get; set; }
        [Column(TypeName = "varchar(100)")]
         [DisplayName("DNI / RUC")]
        public string DNI { get; set; }
        [Column(TypeName = "varchar(100)")]
        [DisplayName("DIRECCION")]
        public string DIRECCION { get; set; }
    }
}
