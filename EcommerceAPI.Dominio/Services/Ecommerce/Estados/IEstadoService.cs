using EcommerceAPI.Comunes.Clases.Contracts.Ecommerce;
using EcommerceAPI.Comunes.Classes.Contracts.Ecommerce;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceAPI.Dominio.Services.Ecommerce.Estados
{
    public interface IEstadoService
    {
        List<EstadoContract> ObtenerEstados();
        EstadoContract ObtenerEstado(int id_estado);
        EstadoContract Crear(EstadoContract contract);
        EstadoContract Update(EstadoContract contract);
        bool Delete(int id_estado);
    }
}
