using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memeswamp.Domain.Models
{
    public class Comment : BaseModel<string>
    {
        public string content { get; set; } = default!;
        public string nonce { get; set; } = default!;
        public DateTime pubDate { get; set; } = DateTime.UtcNow;
        public string memeId { get; set; } = default!;
        public Meme meme { get; set; } = default!;
        public string authorId { get; set; } = default!;
        public User author { get; set; } = default!;
        public string rootId { get; set; } = default!;
        public Comment root { get; set; } = default!;
        public List<Comment> replies { get; set; } = default!;
    }
}
