using EcommerceAPI.Infraestructura.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceAPI.Infraestructura.Repositorios.Estados
{
    public interface IEstadoRepository
    {
        List<EstadoEntity> ObtenerEstados();
        EstadoEntity ObtenerEstado(int id_estado);
        EstadoEntity Crear(EstadoEntity entidad);
        EstadoEntity Update(EstadoEntity entidad);
        void Delete(EstadoEntity entidad);
    }
}
