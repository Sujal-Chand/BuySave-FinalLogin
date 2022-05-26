using BuySave_Final.Models;
using System;
using System.Linq;

namespace BuySave_Final.Data
{
    public class DbInitializer
    {
        public static void Initialize(BuySave_FinalContextdb context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Catagory.Any())
            {
                return;   // DB has been seeded
            }

            var catagory = new Catagory[]
            {
            new Catagory{CatagoryName="Phone"},
            new Catagory{CatagoryName="Mouse"},
            new Catagory{CatagoryName="Keyboard"},
            new Catagory{CatagoryName="Monitor"},
            new Catagory{CatagoryName="CPU"},
             new Catagory{CatagoryName="GPU"},
              new Catagory{CatagoryName="RAM"},
               new Catagory{CatagoryName="Video Game"},
                new Catagory{CatagoryName="PC parts"},
            };
            foreach (Catagory cat in catagory)
            {
                context.Catagory.Add(cat);
            }
            context.SaveChanges();

            var country = new Country[]
            {
            new Country{CountryName="New Zealand"},
            new Country{CountryName="Fiji"},
              new Country{CountryName="Samoa"},
                new Country{CountryName="Japan"},
                  new Country{CountryName="United Kingdom"},
                    new Country{CountryName="China"},
                      new Country{CountryName="United States of America"},
            };
            foreach (Country con in country)
            {
                context.Country.Add(con);
            }
            context.SaveChanges();

        
        }
    }
}
    