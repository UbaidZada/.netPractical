using Microsoft.AspNetCore.Mvc;
using Practical.Models;
using System.Diagnostics;

namespace Practical.Controllers
{
    public class HomeController : Controller
    {
 private readonly PracticalContext _context;

    public HomeController(PracticalContext context)
    {
        _context = context;
    }

        public IActionResult Index()
        {

           ViewBag.products = from product in _context.Products
                        join order in _context.Orders on product.ProductId equals order.ProductId
                        select new {prodName = product.ProdName, prodPrice = product.ProdPrice, prodDesc = product.ProdDesc, orderid = order.OrderId,
                        productid = order.ProductId , amount = order.TotalAmount, date = order.OrderDate };

       



            return View();
        }

 


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}