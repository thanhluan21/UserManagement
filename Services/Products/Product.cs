using Microsoft.AspNetCore.Authentication;
using System;
using System.Linq;
using System.Threading.Tasks;
using UserManagement.Model;

namespace UserManagement.Services.Products
{
    public class Product : IProduct
    {
        private readonly ApplicationDbContext _dbcontext;
        public Product(ApplicationDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }
        public async Task<ProductModel> Create(ProductDTO productDTO)
        {
            var productExist = _dbcontext.productModels.FirstOrDefault(c => c.Name == productDTO.Name);
            if (productExist != null)
                return null;
            ProductModel product = new ProductModel()
            {
                Name = productDTO.Name,
                NumberOf = productDTO.NumberOf,
                Price = productDTO.Price,
                DateAdd = DateTime.UtcNow,
            };
           await _dbcontext.AddAsync(product);
            _dbcontext.SaveChanges();
            return product;
        }

        public bool Delete()
        {
            throw new System.NotImplementedException();
        }

        public Task<Product> Update(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
