using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.netCoreMVCCRUD.Models
{

    public class Ventas
    {
       /*
        public int  IdProducto{get; set;}
         public int  Codigo{get; set;}
    
     public string  Nombre{get; set;}
    
     public string  Descripcion{get; set;}
    
     public int  Activo{get; set;}
     */



      [Key]
        public int IdProducto { get; set; }



        [Column(TypeName ="varchar(10)")]
        [Required(ErrorMessage ="This field is required.")]
        public int Codigo { get; set; }



        [Column(TypeName = "varchar(100)")]
        public string Nombre { get; set; }


        [Column(TypeName = "varchar(100)")]
        public string Descripcion { get; set; }


        [Column(TypeName = "varchar(1)")]
        public int Activo { get; set; }
    


    
     

        
    }
}