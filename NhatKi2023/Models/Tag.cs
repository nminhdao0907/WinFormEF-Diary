using System;
using System.Collections.Generic;

namespace NhatKi2023.Models
{
    public partial class Tag
    {
        public Tag()
        {
            Entries = new HashSet<Entry>();
        }

        public int TagId { get; set; }
        public string? TagName { get; set; }

        public virtual ICollection<Entry> Entries { get; set; }
    }
}
