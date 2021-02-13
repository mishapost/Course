using System;
using System.Collections.Generic;
using System.Text;
using EntityFrameworkCoreExample.Models;

namespace HomeWork8.Models
{
    public class Author
    {
        public int Id { get; set; }

        public string AuthorName { get; set; }
        
        public List<Story> Stories { get; set; }
    }
}
