using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BuySave_Final.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        [Display(Name = "Catagory")]
        public int CatagoryID { get; set; }

        [Display(Name = "Product Name")]
        [StringLength(50, ErrorMessage = "The product name must be less than 50 characters long.")]
        public string ProductName { get; set; }

        [Display(Name = "Upload Date")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime CreatedDate { get; set; }
        public ICollection<Review> Review { get; set; }
        public Catagory Catagory { get; set; }
    }
}
