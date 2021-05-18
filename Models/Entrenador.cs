using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.netCoreMVCCRUD.Models
{
    public class Entrenador
    {

        [Key]
        public int Id { get; set; }

        [Column(TypeName ="nvarchar(50)")]
        [Required(ErrorMessage ="Campo Obligatorio")]
        [DisplayName("Nombre")]
        public string Nombre { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        [DisplayName("Foto")]
        public string foto { get; set; }

        [Column(TypeName = "nvarchar(50)")]
         [DisplayName("Pueblo")]
        public string pueblo { get; set; }

        
        
    }
}