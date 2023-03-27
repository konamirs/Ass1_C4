using C_sharf_4_Ass_1.Models;
namespace C_sharf_4_Ass_1.IServices
{
    public interface IProductService
    {
        public bool CreateProduct(Product p);
        public bool UpdateProduct(Product p);
        public bool DeleteProduct(Guid id);
        public List<Product> GetAllProducts();
        public Product GetProductById(Guid id);
        public List<Product> GetProductsByName(string name);
    }
}
