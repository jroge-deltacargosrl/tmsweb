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
        public byte tipo_c { get; set; }
        [DisplayName("Proveedor")]
        public byte tipo_s { get; set; }
        [DisplayName("Empleado")]
        public byte tipo_e { get; set; }


    }
}
