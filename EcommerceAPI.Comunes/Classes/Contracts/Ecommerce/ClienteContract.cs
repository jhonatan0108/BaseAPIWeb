namespace EcommerceAPI.Comunes.Classes.Contracts.Ecommerce
{
    public class ClienteContract
    {
        public decimal cedula { get; set; }
        public string nombre { get; set; }
        public string contraseña { get; set; }
        public string correo { get; set; }
        public string direccion { get; set; }
        public decimal telefono { get; set; }
    }
}
