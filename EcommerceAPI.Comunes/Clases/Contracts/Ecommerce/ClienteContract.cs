namespace EcommerceAPI.Comunes.Classes.Contracts.Ecommerce
{
    public class ClienteContract
    {
        public int cedula { get; set; }
        public string nombre { get; set; }
        public string contrasena { get; set; }
        public string correo { get; set; }
        public string direccion { get; set; }
        public decimal telefono { get; set; }
    }
}
