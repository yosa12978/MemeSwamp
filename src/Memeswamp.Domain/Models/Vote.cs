using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memeswamp.Domain.Models
{
    public class Vote : BaseModel<string>
    {
        public string userId { get; set; } = default!;
        public string memeId { get; set; } = default!;
        public VoteType voteType { get; set; }
    }
}
