using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BuySave_Final.Models
{
    public class Country
    {
        public int CountryID { get; set; }
        [Display(Name = "Country")]
        public string CountryName { get; set; }
        public ICollection<User> User { get; set; }
    }
}

