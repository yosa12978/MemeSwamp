using Memeswamp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memeswamp.Domain.Repositories
{
    public interface ICategoryRepository : IBaseRepository<Category, string>
    {
    }
}
