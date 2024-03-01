using Microsoft.Extensions.Configuration;
using System.Security.Cryptography;
using System.Text;

public class CryptoService : ICryptoService
{
    private readonly IConfiguration _configuration;
    private readonly string _key;

    public CryptoService(IConfiguration configuration)
    {
        _configuration = configuration;
        this._key = _configuration["Crypto:KeySecret"] ?? string.Empty;
    }

    public string DesEncript(string value)
    {
        try
        {
            using (var rsa = new RSACryptoServiceProvider())
            {
                rsa.FromXmlString(this._key);
                byte[] dataBytes = Encoding.UTF8.GetBytes(value);
                byte[] encryptedBytes = rsa.Encrypt(dataBytes, false);
                return Convert.ToBase64String(encryptedBytes);
            }
        }
        catch
        {
            return string.Empty;
        }

    }

    public string Encript(string value)
    {
        try
        {
            using (var rsa = new RSACryptoServiceProvider())
            {
                rsa.FromXmlString(this._key);
                byte[] encryptedBytes = Convert.FromBase64String(value);
                byte[] decryptedBytes = rsa.Decrypt(encryptedBytes, false);
                return Encoding.UTF8.GetString(decryptedBytes);
            }
        }
        catch
        {
            return string.Empty;
        }
    }
}