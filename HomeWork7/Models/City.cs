using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HomeWork7.Models
{
    [Table("City")]
    public class City
    {
        [Key]
        public int Id { get; set; }
        
        public string CityName { get; set; }

        [ForeignKey("Country")]
        public int CountryId { get; set; }

        public Country Country { get; set; }
    }
}
