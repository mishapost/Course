namespace HomeWork9.Models
{
    public class Character
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool Gender { get; set; }
        public int Age { get; set; }

        public int StoryId { get; set; }
        public Story Story { get; set; }
    }
}