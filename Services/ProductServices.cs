using C_sharf_4_Ass_1.Models;
using C_sharf_4_Ass_1.IServices;

namespace C_sharf_4_Ass_1.Services
{
    public class ProductServices : IProductService

    {
        ShopDbContext _dbContext;
        public ProductServices()
        {
            _dbContext = new ShopDbContext();
        }

        public bool CreateProduct(Product p)
        {
            try
            {
                _dbContext.Products.Add(p);
                _dbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool DeleteProduct(Guid id)
        {
            try
            {
                var product = _dbContext.Products.Find(id);
                _dbContext.Products.Remove(product);
                _dbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<Product> GetAllProducts()
        {
            return _dbContext.Products.Where(p => p.Status < 3).ToList();
            return _dbContext.Products.ToList();

        }

        public Product GetProductById(Guid id)
        {
            return _dbContext.Products.FirstOrDefault(p => p.Id == id);

        }

        public List<Product> GetProductsByName(string name)
        {
            return _dbContext.Products.Where(p=>p.Name.Contains(name)).ToList();
        }

        public bool UpdateProduct(Product p)
        {
            try
            {
                var product = _dbContext.Products.Find(p.Id);
                product.Name = p.Name;
                product.Description = p.Description;
                product.Price = p.Price;
                product.Supplier = p.Supplier;
                product.AvailableQuantity = p.AvailableQuantity;
                product.Status = p.Status;
                _dbContext.Products.Update(product);
                _dbContext.SaveChanges();
                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }
    }
}
