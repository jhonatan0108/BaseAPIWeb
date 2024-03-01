namespace EcommerceAPI.Comunes.Classes.Contracts.Ecommerce
{
    public class ClienteContract//DTO
    {
        public int id_cliente { get; set; }
        public string contrasena { get; set; } 
        public string nombre { get; set; }
        public int cedula { get; set; }
        public string coorreo { get; set; }
        public string direccion { get; set; }
        public decimal? telefono { get; set; }
    }
}
