using Microsoft.AspNetCore.Mvc;
using MVC_christenZarif.Models;

namespace MVC_christenZarif.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult ShowAll()
        {
            ProductBL productBL = new ProductBL();
            List<Product> products = productBL.GetAllProducts();
            return View("ShowAll", products);
        }

        public IActionResult Details(int id)
        {
            ProductBL productBL = new ProductBL();
            Product products = productBL.GetDetails(id);
            return View("ShowDetails",products);

        }
    }
}
