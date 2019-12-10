using System.ComponentModel.DataAnnotations;

namespace TMS_Web.Models
{
    public class UserModel
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Campo Requerido")]
        public string email { get; set; }

        [Required]
        [MaxLength(20, ErrorMessage = "Username muy largo, 20 caracteres permitidos como maximo")]
        public string password { get; set; }
        /*1: Cliente; 2: Operador; 3: Chofer*/
        public int typeAccess { get; set; }
    }
}
