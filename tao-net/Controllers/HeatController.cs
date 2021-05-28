using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using tao_net.Models;
using tao_net.ViewModels;

namespace tao_net.Controllers
{
    public class HeatController : Controller
    {

        private ApplicationDbContext _context;

        public HeatController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Heat
        public ActionResult Index()
        {
            var viewModel = new HeatViewModel
            {
               HeatTypes = _context.HeatTypes.ToList()
            };

            return View(viewModel);
        }

        // test GET: iframe
        public ActionResult Calculator()
        { 
            return View();
            
        }

        public ActionResult VarmeTakster()
        {
            return View();

        }

       
        public ActionResult BookMeeting()
        {
            return View();

        }
           

         /*
         [HttpPost]
        public ActionResult BookMeeting(HeatType heatType)
        {
            if (heatType.Id == 0)
            {
                _context.HeatType.Add(heatType);
                return RedirectToAction("Confirmation");
            }
            else
            {
                var customerInDb = _context.Customers.Single(c => c.Id == heatType.Id);

                customerInDb.FirstName = heatType.FirstName;
                customerInDb.LastName = heatType.LastName;
                customerInDb.Email = heatType.Email;
                customerInDb.Phone = heatType.Phone;
                customerInDb.Address = heatType.Address;
                customerInDb.Zip = heatType.Zip;
                customerInDb.HeatTypeId = heatType.HeatTypeId;
            }

            _context.SaveChanges();

            return RedirectToAction("Orders", "heatType");
        }

         
         */





    }
}