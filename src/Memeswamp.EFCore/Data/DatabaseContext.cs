using Memeswamp.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memeswamp.EFCore.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext()
        {

        }
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<User>().HasKey(x => x.id);
            builder.Entity<Meme>().HasKey(x => x.id);
            builder.Entity<Vote>().HasKey(x => x.id);
            builder.Entity<Comment>().HasKey(x => x.id);
            builder.Entity<Category>().HasKey(x => x.id);

            builder.Entity<User>()
                .HasMany(x => x.memes)
                .WithOne(x => x.author)
                .HasForeignKey(x => x.authorId)
                .HasPrincipalKey(x => x.id);
            builder.Entity<User>()
                .HasMany(x => x.comments)
                .WithOne(x => x.author)
                .HasForeignKey(x => x.authorId)
                .HasPrincipalKey(x => x.id);
            builder.Entity<User>()
                .HasMany(x => x.votes)
                .WithOne()
                .HasForeignKey(x => x.userId)
                .HasPrincipalKey(x => x.id);

            builder.Entity<Vote>()
                .HasOne<User>()
                .WithMany(x => x.votes)
                .HasForeignKey(x => x.userId);
            builder.Entity<Vote>()
                .HasOne<Meme>()
                .WithMany()
                .HasForeignKey(x => x.memeId);

            builder.Entity<Meme>()
                .HasOne(x => x.author)
                .WithMany(x => x.memes)
                .HasForeignKey(x => x.authorId);
            builder.Entity<Meme>()
                .HasMany(x => x.comments)
                .WithOne(x => x.meme)
                .HasForeignKey(x => x.memeId);
            builder.Entity<Meme>()
                .HasOne(x => x.category)
                .WithMany()
                .HasForeignKey(x => x.categoryId);

            builder.Entity<Category>()
                .HasMany<Meme>()
                .WithOne(x => x.category)
                .HasForeignKey(x => x.categoryId);


            builder.Entity<Comment>()
                .HasOne(x => x.author)
                .WithMany(x => x.comments)
                .HasForeignKey(x => x.authorId);
            builder.Entity<Comment>()
                .HasOne(x => x.meme)
                .WithMany(x => x.comments)
                .HasForeignKey(x => x.memeId);
            builder.Entity<Comment>()
                .HasOne(x => x.root)
                .WithMany(x => x.replies)
                .HasForeignKey(x => x.rootId);

            builder.Entity<User>().HasData(
                new User
                {
                    id = "23960c7c-1a89-4a31-abd4-d4077782c9c4",
                    username = "admin",
                    email = "admin@memes.com",
                    password = "3042d7230c565a47d72a21d39759cb3d",
                    salt = "salt",
                    role = Role.ADMIN,
                    isEmailConfirmed = true
                },
                new User
                {
                    id = "13edac6b-4633-4e0e-900f-ef858ce0f068",
                    username = "user",
                    email = "user@memes.com",
                    password = "1f4b954ea460f19cfdb2fd4f775536dd", // md5 password + salt
                    salt = "salt",
                    role = Role.USER,
                    isEmailConfirmed = true
                });

            builder.Entity<Category>().HasData(
                new Category
                {
                    id = "695e99fc-462b-4c1e-b4d3-6292f269c960",
                    name = "dank"
                });

            builder.Entity<Meme>().HasData(
                new Meme
                {
                    url = "https://upload.wikimedia.org/wikipedia/commons/thumb/1/18/Deep_fried_meme.jpg/154px-Deep_fried_meme.jpg",
                    nonce = Guid.NewGuid().ToString(),
                    authorId = "13edac6b-4633-4e0e-900f-ef858ce0f068",
                    categoryId = "695e99fc-462b-4c1e-b4d3-6292f269c960"
                });
        }

        public DbSet<User> users { get; set; } = default!;
        public DbSet<Meme> memes { get; set; } = default!;
        public DbSet<Vote> votes { get; set; } = default!;
        public DbSet<Category> categories { get; set; } = default!;
        public DbSet<Comment> comments { get; set; } = default!;
    }
}
