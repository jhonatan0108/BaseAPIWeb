using System.ComponentModel.DataAnnotations;

namespace EcommerceAPI.Comunes.Classes.Contracts.Ecommerce
{
    public class ClienteContract
    {
        [Required]
        public int id_cliente { get; set; }
        public string nombre { get; set; }
        public string contrasena { get; set; }
        public string correo { get; set; }
        public string direccioncliente { get; set; }
        public int telefono { get; set; }
    }
}
