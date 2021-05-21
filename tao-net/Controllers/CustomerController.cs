using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using tao_net.Models;
using tao_net.ViewModels;
using System.Data.Entity;

namespace tao_net.Controllers
{
    public class CustomerController : Controller
    {

        private ApplicationDbContext _context;

        public CustomerController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        // GET: Customer
        public ActionResult Index()
        {
            var viewModel = new CustomerViewModel
            {
                Customer = new Customer(),
                HeatTypes = _context.HeatTypes.ToList()
            };

            return View("Order", viewModel);
        }

        [HttpPost]
        public ActionResult Save(Customer customer)
        {
            if(customer.Id == 0)
            {
                _context.Customers.Add(customer);
            }

            _context.SaveChanges();

            return RedirectToAction("Confirmation");
        }

        public ActionResult Confirmation()
        {
            return View("Confirmation");
        }

        public ActionResult Orders()
        {
            var viewModel = new CustomerViewModel
            {
                Customers = _context.Customers.Include(c => c.heatType).ToList()
            };
            return View(viewModel);
        }

        public ActionResult Details(int Id)
        {
            Customer customer = _context.Customers.SingleOrDefault(c => c.Id == Id);
            
            return View(customer);
        }
    }
}