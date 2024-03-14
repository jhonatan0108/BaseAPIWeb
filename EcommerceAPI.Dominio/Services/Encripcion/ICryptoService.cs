using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceAPI.Dominio.Services.Encripcion
{
    public interface ICryptoService
    {
        string Encript(string value);

        string  DesEncript(string value) ;

    }
}
