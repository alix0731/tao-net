using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using tao_net.Models;

namespace tao_net.ViewModels
{
    public class CustomerViewModel
    {
        public Customer Customer { get; set; }
        public List<Customer> Customers { get; set; }
        public List<HeatType> HeatTypes { get; set; }

    }
}