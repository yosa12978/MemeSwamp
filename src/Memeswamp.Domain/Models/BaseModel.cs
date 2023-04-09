using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memeswamp.Domain.Models
{
    public class BaseModel<T>
    {
        [Key]
        public T id { get; set; } = default!;
    }
}
