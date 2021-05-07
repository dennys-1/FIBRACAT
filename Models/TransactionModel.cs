using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
namespace Asp.netCoreMVCCRUD.Models
{
    public class TransactionModel
    {
        [Key]
        public int CID { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Correo")]
        [Required(ErrorMessage = "Campo Obligatorio.")]
        
        public string CORREO { get; set; }

        [Column(TypeName = "nvarchar(10)")]
        [DisplayName("Telefono")]
        [Required(ErrorMessage = "Campo Obligatorio.")]
        public string TELEFONO { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Dni")]
        [Required(ErrorMessage = "Campo Obligatorio.")]
        public string DNI { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Producto")]
        [Required(ErrorMessage = "Campo Obligatorio.")]
        
        public string DIRECCION { get; set; }

     [Column(TypeName = "nvarchar(100)")]   
        [DisplayName("Servicio")]
        [Required(ErrorMessage = "Campo Obligatorio.")]
        public string VELOCIDAD { get; set; }

        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime Date { get; set; }
    }
}
