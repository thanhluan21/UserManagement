using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Threading.Tasks;
using UserManagement.Model;

namespace UserManagement.Services.Products
{
    public interface IProduct
    {
        Task<ProductModel> Create(ProductDTO productDTO);
        Task<Product> Update(int id);
        bool Delete();
    }
}
