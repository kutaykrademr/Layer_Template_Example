using Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using WebUi.ViewModels;

namespace WebUi.Controllers
{
    public class ProductController : Controller
    {
        private IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        public JsonResult GetAllProducts()
        {
            var products = _productService.GetAll();

            ProductListViewModel model = new ProductListViewModel
            {
                Products = products
            };
            return Json(model);
        }
    }
}
