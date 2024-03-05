namespace EcommerceAPI.Comunes.Classes.Contracts.Ecommerce
{
    public class ClienteContract
    {
        public int id_cliente { get; set; }
        public string nombre { get; set; }
        public string password { get; set; }
        public string correo { get; set; }
        public string direccioncliente { get; set; }
        public int telefono { get; set; }
        public int Consecutivo { get; set; }
    }
}
