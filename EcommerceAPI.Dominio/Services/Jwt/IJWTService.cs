using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceAPI.Dominio.Services.Jwt
{
    public interface IJWTService
    {
        string GenerarToken();
    }
}
