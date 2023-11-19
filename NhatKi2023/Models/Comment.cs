using System;
using System.Collections.Generic;

namespace NhatKi2023.Models
{
    public partial class Comment
    {
        public int CommentId { get; set; }
        public int? EntryId { get; set; }
        public int? UserId { get; set; }
        public DateTime? CommentDate { get; set; }
        public string? CommentText { get; set; }

        public virtual Entry? Entry { get; set; }
        public virtual User? User { get; set; }
    }
}
