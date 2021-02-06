using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork6.Repository
{
    public class CharacterJoinStory
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool Gender { get; set; }
        public int Age { get; set; }
        public string StoryName { get; set; }
        public string StoryDescription { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName} {Gender} {Age} {StoryName} {StoryDescription}";
        }
    }
}
