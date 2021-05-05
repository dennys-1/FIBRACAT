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
       [Key]
        public int  IdVenta{get; set;}
         public int  Codigo{get; set;}
    
     public int  idTienda{get; set;}
    
     public int  IdUsuario{get; set;}
    
     public int  IdCliente{get; set;}
    
     public int  TipoDocumento{get; set;}
      public int  CantidadProducto{get; set;}
       public int  CantiddadTotal{get; set;}
        public int  TotalCosto{get; set;}
         public int  ImporteRecibido{get; set;}
          public int  ImporteCambio{get; set;}
           public string  Activo{get; set;}
            public int  FechaRegistro{get; set;}
    
    
        
    }
}