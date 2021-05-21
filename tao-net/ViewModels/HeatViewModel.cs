using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using tao_net.Models;


namespace tao_net.ViewModels
{
    public class HeatViewModel
    {

        public HeatType heatType { get; set; }
        public List<HeatType> HeatTypes { get; set; }


    }
}