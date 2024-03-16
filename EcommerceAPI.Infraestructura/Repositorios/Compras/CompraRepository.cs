﻿using EcommerceAPI.Infraestructura.Database.Context;
using EcommerceAPI.Infraestructura.Database.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceAPI.Infraestructura.Repositorios.Compras
{
    public class CompraRepository : IComprasRepository
    {

        private readonly EcommerceContext _context;
        public CompraRepository(EcommerceContext context)
        {
            _context = context;
        }
        public CompraEntity Create(CompraEntity entidad)
        {
            _context.Compras.Add(entidad);
            try
            {
                _context.SaveChanges();
            }
            catch (DbUpdateException ex)
            {
                // Manejar la excepción aquí
                Console.WriteLine(ex.Message);
            }
            return entidad;
        }

        public void Delete(CompraEntity entidad)
        {
            _context.Compras.Remove(entidad);
            _context.SaveChanges();
        }

        public List<CompraEntity> GetAll()
        {
            return _context.Compras.ToList();
        }

        public CompraEntity GetById(int id)
        {
           return _context.Compras.Find(id);

        }

        public CompraEntity Update(CompraEntity entidad)
        {
            _context.Compras.Update(entidad);
            _context.SaveChanges();
            return entidad;
        }
    }
}