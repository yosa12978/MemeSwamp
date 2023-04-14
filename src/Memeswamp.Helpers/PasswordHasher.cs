using System;

namespace Memeswamp.Helpers
{
    public interface IPasswordHasher
    {
        Task<string> Hash(byte[] password);
        Task<bool> Compare(byte[] p1, byte[] p2);
    }
    public class MD5Hasher : IPasswordHasher
    {
        public Task<string> Hash(byte[] password) 
        {
            return null;
        }

        public Task<bool> Compare(byte[] p1, byte[] p2)
        {
            return null;
        }
    }
}