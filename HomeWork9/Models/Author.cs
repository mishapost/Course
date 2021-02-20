using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;


namespace HomeWork9.Models
{
    [Index("AuthorCode","AuthorName", IsUnique = true, Name = "Author_Index")]
    public class Author
    {
        public int Id { get; set; }

        public int AuthorCode { get; set; }

        public string AuthorName { get; set; }
        
        public List<Story> Stories { get; set; }
    }
}
