using Memeswamp.Domain.Models;
using Memeswamp.EFCore.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memeswamp.EFCore.Impl
{
    public class BaseRepository<T, K> where T : BaseModel<K>
    {
        private readonly DatabaseContext _db;
        public BaseRepository(DatabaseContext db) 
        {
            _db = db;
        }

        public virtual async Task<T?> GetById(K id) 
        {
            return await _db.Set<T>().FindAsync(id);
        }
        public virtual async Task<List<T>> GetAll() 
        {
            return await _db.Set<T>().ToListAsync();
        }
        public virtual async Task<T?> Create(T entity) 
        {
            await _db.Set<T>().AddAsync(entity);
            await _db.SaveChangesAsync();
            return entity;
        }
        public virtual async Task<T?> Update(T entity) 
        {
            _db.Set<T>().Update(entity);
            await _db.SaveChangesAsync();
            return entity;
        }
        public virtual async Task<T?> Delete(K id) 
        {
            T? obj = await _db.Set<T>().FindAsync(id);
            if (obj == null) 
                return obj;
            _db.Set<T>().Remove(obj);
            await _db.SaveChangesAsync();
            return obj;
        }
    }
}