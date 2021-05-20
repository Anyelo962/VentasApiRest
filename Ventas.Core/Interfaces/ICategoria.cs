using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Ventas.Core.Models;

namespace Ventas.Core.Interfaces
{
    public interface ICategoria
    {
        Task<List<Categoria>> GetCategorias();
        Task UpdateCategoia(Categoria categoria);
        Task<Categoria> GetCategoriaById(int id);
        Task<Categoria> deleteCategoria(int id);
    }
}
