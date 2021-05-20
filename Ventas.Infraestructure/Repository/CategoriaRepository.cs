using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Ventas.Core.Interfaces;
using Ventas.Core.Models;
using Ventas.Infraestructure.Data;

namespace Ventas.Infraestructure.Repository
{
    public class CategoriaRepository : ICategoria
    {

        private readonly dbventasContext _context;
        public CategoriaRepository(dbventasContext context)
        {
            _context = context;
        }
        public Task<Categoria> deleteCategoria(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Categoria> GetCategoriaById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Categoria>> GetCategorias()
        {
            var getAll = await _context.Categoria.ToListAsync();
            return getAll;
        }

        public Task UpdateCategoia(Categoria categoria)
        {
            throw new NotImplementedException();
        }
    }
}
