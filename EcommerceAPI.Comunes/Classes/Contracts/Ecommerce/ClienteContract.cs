namespace EcommerceAPI.Comunes.Classes.Contracts.Ecommerce
{
    public class ClienteContract
    {
        // No es necesidad que tenga el mismos nombres de campos de la tabla en este punto
        // Esto es como se le presentara al usuario final.
        public Int64 id_cliente { get; set; }
        public string nombre { get; set; }
        public string contrasena { get; set; }
        public string correo { get; set; }
        public string direccioncliente { get; set; }
        public decimal telefono { get; set; }
    }
}
