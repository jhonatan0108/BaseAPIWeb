﻿using EcommerceAPI.Infraestructura.Database.Context;
using EcommerceAPI.Infraestructura.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceAPI.Infraestructura.Repositorios.Clientes
{
    public class ClientesRepository : IClientesRepository
    {
        private readonly EcommerceContext _context;
        //private listClientes;

        public ClientesRepository(EcommerceContext context)
        {
            _context = context;
        }

        public ClienteEntity Crear(ClienteEntity entidad)
        {
            if (entidad == null)
            {
                _context.Add(entidad);
                _context.SaveChanges();
                return entidad;
            }
            else
            {
                string mensaje1 = "Registro ya existe";
                throw new Exception(mensaje1);
            }

        }

        public void Delete(ClienteEntity entidad)
        {
            ClienteEntity ClienteBorrar = new ClienteEntity();
            try
            {
                ClienteBorrar = (ClienteEntity)(from Cliente in _context.Clientes
                                                where Cliente.cedula == entidad.cedula
                                                select Cliente);
                _context.Remove(ClienteBorrar);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                if (ClienteBorrar == null)
                {
                    string mensaje = "El registro no existe";
                    throw new Exception(mensaje);
                }
                else
                {
                    e.ToString();
                }

            }

        }

        public List<ClienteEntity> ObtenerClientes()
        {
            return _context.Clientes.ToList();
        }

        public ClienteEntity ObtenerPorId(decimal id)
        {
            return _context.Clientes.Find(id);
        }

        public ClienteEntity Update(ClienteEntity entidad)
        {
            _context.Clientes.Update(entidad);
            _context.SaveChanges();
            return entidad;
        }
    }
}


