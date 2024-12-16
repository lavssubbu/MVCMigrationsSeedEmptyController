using CMSMVCCodeFirstEFDemo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace CMSMVCCodeFirstEFDemo.Controllers
{
    public class OrdersController : Controller
    {
        //Context class - connect with db
        private readonly CustDbContext _custDb;

        public OrdersController(CustDbContext custDb)
        {
            _custDb = custDb;
        }
        public IActionResult Index()
        {
            return View(_custDb.Order.Include(c => c.customer).ToList());
        }
        public IActionResult Details(int id)
        {
            Order or = _custDb.Order.Include(c => c.customer).FirstOrDefault(o => o.OrderId == id) ?? new Order();
            return View(or);
        }
        //Create,Edit and Delete - Get & Post Method

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.CustName = new SelectList(_custDb.customers, "custId", "custName");
            return View();
        }
        [HttpPost]
        public IActionResult Create(Order ord)
        {
            ViewBag.CustName = new SelectList(_custDb.customers, "custId", "custName");
            _custDb.Order.Add(ord);
            _custDb.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.CustName = new SelectList(_custDb.customers, "custId", "custName");

           Order or = _custDb.Order.Include(c => c.customer).FirstOrDefault(o => o.OrderId == id) ?? new Order();
            return View(or);
        }
        [HttpPost]
        public IActionResult Edit(int id,Order ord)
        {
            ViewBag.CustName = new SelectList(_custDb.customers, "custId", "custName");
            _custDb.Order.Update(ord);
            _custDb.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
