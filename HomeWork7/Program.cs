using System;
using System.Drawing.Text;
using System.Linq;
using HomeWork7.DbContext;
using HomeWork7.Models;

namespace HomeWork7
{
    class Program
    {
        static void Main()
        {
            var context = new DbContext.AppContext();

            var country = new Country {CountryName = "BY"}; 
            
            context.Countries.Add(country);
            SaveChangeToDatabase(context);

            var countryId = context.Countries?.FirstOrDefault(c => c.CountryName == "BY")?.Id ?? 0;

            var city1 = new City {CityName = "Minsk", CountryId = countryId };
            var city2 = new City {CityName = "Brest", CountryId = countryId };
            context.Cities.Add(city1);
            context.Cities.Add(city2);
            SaveChangeToDatabase(context);

        }

        private static void SaveChangeToDatabase(Microsoft.EntityFrameworkCore.DbContext context)
        {
            try
            {
                context.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.GetBaseException());
            }
        }
    }
}
