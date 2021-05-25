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


        [Column(TypeName ="nvarchar(50)")]
        [Required(ErrorMessage ="This field is required.")]
        [DisplayName("N_PRODUCTO")]
        public string NPRODUCTO { get; set; }



        [Column(TypeName = "varchar(10)")]
        [DisplayName("FOTO")]
        public string FOTO { get; set; }


        
        [Column(TypeName = "varchar(100)")]
         [DisplayName("DESC")]
        public string DESCRIPCION { get; set; }


        [Column(TypeName = "varchar(100)")]
        [DisplayName("PRECIO")]
        public string PRECIO { get; set; }





        [Column(TypeName = "varchar(100)")]
        [DisplayName("CELULAR")]
        public string CELULAR { get; set; }


        [Column(TypeName = "varchar(100)")]
        [DisplayName("LUGAR")]
        public string LUGAR { get; set; }


        [Column(TypeName = "varchar(100)")]
        [DisplayName("N_COM")]
        public string NCOMPRADOR { get; set; }

              [Column(TypeName = "varchar(100)")]
        [DisplayName("CATEGORIA")]
        public string CATEGORIA { get; set; }

    }
}
