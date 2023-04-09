﻿using Memeswamp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memeswamp.Domain.Repositories
{
    public interface IBaseRepository<T, K> where T : BaseModel<K>
    {
        Task<T> GetById(K id);
        Task<List<T>> GetAll();
        Task<T> Create(T entity);
        Task<T> Update(T entity);
        Task<T> Delete(K id);
    }
}
