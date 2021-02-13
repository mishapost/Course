using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeWork8.Models;

namespace EntityFrameworkCoreExample.Models
{
    public class Story
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Character> Characters { get; set; }
        public int AuthorId { get; set; }
        public Author Author { get; set; }
    }
}