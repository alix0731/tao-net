using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace tao_net.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Display(Name = "Fornavn:")]
        public string FirstName { get; set; }
        [Display(Name = "Efternavn:")]
        public string LastName { get; set; }
        [Display(Name = "Email:")]
        public string Email { get; set; }
        [Display(Name = "Tlf:")]
        public int Phone { get; set; }
        [Display(Name = "Adresse:")]
        public string Address { get; set; }
        [Display(Name = "Post nummer:")]
        public int Zip { get; set; }
     
        public HeatType heatType { get; set; }
        
        [Display(Name = "HeatType:")]
        public int HeatTypeId { get; set; }




    }
}