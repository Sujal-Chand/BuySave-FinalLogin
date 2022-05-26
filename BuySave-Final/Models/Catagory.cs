using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BuySave_Final.Models
{
    public class Catagory
    {
        public int CatagoryID { get; set; }
        [Display(Name = "Catagory")]
        public string CatagoryName { get; set; }
        public ICollection<Product> Product { get; set; }
    }
}
