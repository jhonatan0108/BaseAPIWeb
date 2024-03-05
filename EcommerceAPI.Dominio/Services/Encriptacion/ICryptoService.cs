

namespace EcommerceAPI.Dominio.Services.Encriptacion
{
    public interface ICryptoService
    {
        string Encript(string value);
        string DesEncript (string value);
    }
}
