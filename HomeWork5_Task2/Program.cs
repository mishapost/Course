using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Channels;
using System.Xml.Xsl;
using HomeWork5_Task2.Classes;

namespace HomeWork5_Task2
{
    class Program
    {
       
        static void Main()
        {
            var myCollection = new List<Country>();
            // Заполняю коллекцию данными

            #region Add value1
            myCollection.Add(new Country
            {
                CountryName = "BY",
                District = new District
                {
                    DistrictName = "Minsk obl.",
                    City = new City
                    {
                        CityName = "Minsk",
                        Neighborhood = new Neighborhood
                        {
                            HouseNumber = 9,
                            StreetName = "Kalvariyskay str."
                        }
                    }
                }
            });
            #endregion

            #region Add value2
            myCollection.Add(new Country
            {
                CountryName = "BY",
                District = new District
                {
                    DistrictName = "Minsk obl.",
                    City = new City
                    {
                        CityName = "Minsk",
                        Neighborhood = new Neighborhood
                        {
                            HouseNumber = 23,
                            StreetName = "Kulman str."
                        }
                    }
                }
            });
            #endregion

            #region Add value3
            myCollection.Add(new Country
            {
                CountryName = "BY",
                District = new District
                {
                    DistrictName = "Minsk obl.",
                    City = new City
                    {
                        CityName = "Minsk",
                        Neighborhood = new Neighborhood
                        {
                            HouseNumber = 55,
                            StreetName = "Kulman str."
                        }
                    }
                }
            });
            #endregion

            var listStreetName = myCollection?.Select(strName=> strName.District?.City?.Neighborhood?.StreetName)?
                                             .Distinct()?.ToList();

            Console.WriteLine("В коллекции стран - уникальные улицы:");
            listStreetName.ForEach(Console.WriteLine);

        }
    }
}
