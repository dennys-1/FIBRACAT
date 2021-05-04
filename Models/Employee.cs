using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.netCoreMVCCRUD.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        [Column(TypeName ="nvarchar(250)")]
        [Required(ErrorMessage ="This field is required.")]
        [DisplayName("Correo")]
        public string FullName { get; set; }
        [Column(TypeName = "varchar(10)")]
        [DisplayName("Telefono")]
        public string EmpCode { get; set; }
        [Column(TypeName = "varchar(100)")]
         [DisplayName("DNI / RUC")]
        public string Position { get; set; }
        [Column(TypeName = "varchar(100)")]
        [DisplayName("Direccion")]
        public string OfficeLocation { get; set; }
    }
}
