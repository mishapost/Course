using System.Collections.Generic;


namespace HomeWork9.Models
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