using System;
using System.Collections.Generic;

namespace Messages.Models
{
    public class Profile
    {
        public int ProfileId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName => $"{FirstName} {LastName}";
        public string Nickname { get; set; }
        public int GenderId { get; set; }
        public string Image { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
