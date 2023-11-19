using System;
using System.Collections.Generic;

namespace NhatKi2023.Models
{
    public partial class User
    {
        public User()
        {
            Comments = new HashSet<Comment>();
            Entries = new HashSet<Entry>();
        }

        public int UserId { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }
        public string? ConPassword { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<Entry> Entries { get; set; }
    }
}
