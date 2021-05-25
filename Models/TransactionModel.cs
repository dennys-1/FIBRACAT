using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
namespace FIBRACAT.Models
{
    public class TransactionModel
    {
        [Key]
        public int CID { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        [DisplayName("CATEGORIA")]
        [Required(ErrorMessage = "Campo Obligatorio.")]
        
        public string CATEGORIA { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        [DisplayName("IDCATEGORIA")]
        [Required(ErrorMessage = "Campo Obligatorio.")]
        public string IDCATEGORIA { get; set; }

       
    }
}
