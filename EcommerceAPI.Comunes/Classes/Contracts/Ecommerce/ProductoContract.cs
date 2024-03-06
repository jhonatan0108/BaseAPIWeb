
namespace EcommerceAPI.Comunes.Classes.Contracts.Ecommerce
{
    public class ProductoContract
    {
        public int id_producto{ get; set; }
        public string nombre_producto { get; set; }
        public string descripcion {  get; set; }
        public string imagen { get; set; }
        public Double valor_unitario { get; set; }
        public decimal stock { get; set; }
        public int id_estado { get; set; }
    }
}
