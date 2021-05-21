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
    }
}