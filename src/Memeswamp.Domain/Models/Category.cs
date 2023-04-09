using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memeswamp.Domain.Models
{
    public class Category : BaseModel<string>
    {
        public string name { get; set; } = default!;
    }
}
