using System;
using System.Collections.Generic;

namespace NhatKi2023.Models
{
    public partial class Entry
    {
        public Entry()
        {
            Comments = new HashSet<Comment>();
        }

        public int EntryId { get; set; }
        public int? UserId { get; set; }
        public int? TagId { get; set; }
        public DateTime? EntryDate { get; set; }
        public string? Title { get; set; }
        public string? Content { get; set; }
        public bool? Status { get; set; }

        public virtual Tag? Tag { get; set; }
        public virtual User? User { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }

    }
}
