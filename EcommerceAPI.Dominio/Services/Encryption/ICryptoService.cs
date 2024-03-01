using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceAPI.Dominio.Services.Encryption
{
    public interface ICryptoService
    {
        string DesEncript(string value);
        string Encript(string value);
     }
}
