using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TMS_Web.Models
{
    public class UsuarioModel
    {
        public int id { get; set; }

        [Required]
        [DisplayName("Email")]
        public string email { get; set; }

        [Required]
        [MinLength(8,ErrorMessage = "La contraseña debe tener 8 carácteres")]
        public string password { get; set; }

        [DisplayName("Cliente")]
        public byte clientType { get; set; }

        [DisplayName("Proveedor")]
        public byte supplierType { get; set; }

        [DisplayName("Empleado")]
        public byte employeeType { get; set; }

        public bool canSend;
    }
}
