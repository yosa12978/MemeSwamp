using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memeswamp.Domain.Models
{
    public class Meme : BaseModel<string>
    {
        public string url { get; set; } = default!;
        public string nonce { get; set; } = default!;
        public DateTime pubDate { get; set; } = DateTime.UtcNow;
        public long upvotes { get; set; } = 0;
        public long downvotes { get; set; } = 0;
        public string authorId { get; set; } = default!;
        public User author { get; set; } = default!;
        public List<Comment> comments { get; set; } = default!;
        public string categoryId { get; set; } = default!;
        public Category category { get; set; } = default!;
        public bool nsfw { get; set; } = false;
        public bool spoiler { get; set; } = false;
    }
}
