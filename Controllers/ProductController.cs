using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Threading.Tasks;
using System;
using UserManagement.Model;
using UserManagement.Services.Products;
using System.Net.WebSockets;
using Microsoft.AspNetCore.Authorization;
using System.Data;

namespace UserManagement.Controllers
{
    [Authorize(Roles = UserRoles.Admin)]
    [ApiController]
    [Microsoft.AspNetCore.Mvc.Route("routing/product")]
    public class ProductController : ControllerBase
    {
        private readonly IProduct _product;
        public ProductController(IProduct product)
        {
            _product = product;
        }

        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("Create")]
        public async Task<IActionResult> CreateProduct([FromBody] ProductDTO model)
        {
            var product = await _product.Create(model);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }

        /*[HttpGet]
        [Microsoft.AspNetCore.Mvc.Route("Get")]
        public async Task<IActionResult> GetProduct(int id)
        {
            var product = await _product.Get(id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }*/
    }
}
