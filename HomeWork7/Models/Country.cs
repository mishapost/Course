using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HomeWork7.Models
{
    [Table("Country")]
    public class Country
    {
        [Key]
        public int Id { get; set; }
        
        public string CountryName { get; set; }

       public IEnumerable<City> Cities { get; set; }
    }
}
