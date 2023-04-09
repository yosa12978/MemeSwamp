using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memeswamp.Domain.Models
{
    public class User : BaseModel<string>
    {
        public string username { get; set; } = default!;
        public string email { get; set; } = default!;
        public string password { get; set; } = default!;
        public string salt { get; set; } = default!;
        public DateTime regDate { get; set; } = DateTime.UtcNow;
        public Role role { get; set; } = Role.USER;
        public bool isActive { get; set; } = true;
        public bool isEmailConfirmed { get; set; } = false;
        public List<Meme> memes { get; set; } = default!;
        public List<Comment> comments { get; set; } = default!;
        public List<Vote> votes { get; set; } = default!;
    }
}
