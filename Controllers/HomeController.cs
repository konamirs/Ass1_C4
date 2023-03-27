using Microsoft.AspNetCore.Mvc;
using C_sharf_4_Ass_1.Models;
using System.Diagnostics;
using C_sharf_4_Ass_1.IServices;
using C_sharf_4_Ass_1.Services;

namespace C_sharf_4_Ass_1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IProductService productServices;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;

            productServices = new ProductServices();
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ShowListProduct()
        {
            List<Product> products = productServices.GetAllProducts();
            return View(products);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Product p)
        {
            if (productServices.CreateProduct(p))
            {
                return RedirectToAction("ShowListProduct");

            }
            else return BadRequest();
        }
        [HttpGet]
        public IActionResult Edit(Guid id)
        {
            Product p = productServices.GetProductById(id);
            return View(p);
        }
        public IActionResult Edit(Product p)
        {
            Product product = productServices.GetProductById(p.Id);
            if (p.Price > product.Price)
            {
                return BadRequest("Giá mới phải nhỏ hơn giá cũ");
            }
            if (productServices.UpdateProduct(p))
            {
                return RedirectToAction("ShowListProduct");
            }
            else return BadRequest();
        }
        public IActionResult Delete(Guid id)
        {
            if (productServices.DeleteProduct(id))
            {
                return RedirectToAction("ShowListProduct");
            }
            else return View("Index");
        }

       
        public IActionResult Details(Guid id)
        {
            ShopDbContext shopDbContext = new ShopDbContext();
            var product = shopDbContext.Products.Find(id);
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}