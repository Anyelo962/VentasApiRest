using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ventas.Core.Interfaces;
using Ventas.Infraestructure.Repository;

namespace Ventas.ApiRest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoria categoria;
        private readonly CategoriaRepository categoriaRepository;

        public CategoryController(ICategoria categoria)
        {
            this.categoria = categoria;
        }

        [HttpGet]
        public async Task<IActionResult> getAllCategoria()
        {
            var getAll = await categoria.GetCategorias();
            return Ok(getAll);
        }
    }

}
