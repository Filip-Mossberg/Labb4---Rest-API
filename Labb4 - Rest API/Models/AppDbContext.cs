using Microsoft.EntityFrameworkCore;
using APILibrary.Models;
using System;

namespace Labb4___Rest_API.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Hobby> Hobby { get; set; }
        public DbSet<Link> Link { get; set; }
        public DbSet<Person> Person { get; set; }
        public DbSet<PersonHobby> PersonHobby { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Person>().HasData(new Person { PersonID = 1, FirstName = "Arne", LastName = "Trampo", Phone = 123483723 });
            modelBuilder.Entity<Person>().HasData(new Person { PersonID = 2, FirstName = "Börje", LastName = "Severinsson", Phone = 124383723 });
            modelBuilder.Entity<Person>().HasData(new Person { PersonID = 3, FirstName = "Sara", LastName = "Palmqvist", Phone = 123443723 });
            modelBuilder.Entity<Person>().HasData(new Person { PersonID = 4, FirstName = "Reidar", LastName = "Folkesson", Phone = 123543723 });
            modelBuilder.Entity<Person>().HasData(new Person { PersonID = 5, FirstName = "Elina", LastName = "Johansson", Phone = 125483723 });
            modelBuilder.Entity<Person>().HasData(new Person { PersonID = 6, FirstName = "Hans", LastName = "Gustavsson", Phone = 126383723 });
            modelBuilder.Entity<Person>().HasData(new Person { PersonID = 7, FirstName = "Lena", LastName = "Karlsson", Phone = 127443723 });
            modelBuilder.Entity<Person>().HasData(new Person { PersonID = 8, FirstName = "Mikael", LastName = "Lindgren", Phone = 128543723 });
            modelBuilder.Entity<Person>().HasData(new Person { PersonID = 9, FirstName = "Pernilla", LastName = "Ekström", Phone = 129483723 });
            modelBuilder.Entity<Person>().HasData(new Person { PersonID = 10, FirstName = "Oscar", LastName = "Nilsson", Phone = 130383723 });


            modelBuilder.Entity<Hobby>().HasData(new Hobby { HobbyID = 1, Title = "Fishing", Description = "Fishing club" });
            modelBuilder.Entity<Hobby>().HasData(new Hobby { HobbyID = 2, Title = "Racing", Description = "Racing with motorized vehicles." });
            modelBuilder.Entity<Hobby>().HasData(new Hobby { HobbyID = 3, Title = "Gardening", Description = "Plant flowers." });
            modelBuilder.Entity<Hobby>().HasData(new Hobby { HobbyID = 4, Title = "Skiing", Description = "Skiing down steep slopes." });

            modelBuilder.Entity<Link>().HasData(new Link { LinkID = 1, LinkName = "Google", URL = "http://www.google.com" });
            modelBuilder.Entity<Link>().HasData(new Link { LinkID = 2, LinkName = "YouTube", URL = "http://www.youtube.com" });
            modelBuilder.Entity<Link>().HasData(new Link { LinkID = 3, LinkName = "Facebook", URL = "http://www.facebook.com" });
            modelBuilder.Entity<Link>().HasData(new Link { LinkID = 4, LinkName = "Twitter", URL = "http://www.twitter.com" });
            modelBuilder.Entity<Link>().HasData(new Link { LinkID = 5, LinkName = "Instagram", URL = "http://www.instagram.com" });
            modelBuilder.Entity<Link>().HasData(new Link { LinkID = 6, LinkName = "LinkedIn", URL = "http://www.linkedin.com" });
            modelBuilder.Entity<Link>().HasData(new Link { LinkID = 7, LinkName = "Reddit", URL = "http://www.reddit.com" });
            modelBuilder.Entity<Link>().HasData(new Link { LinkID = 8, LinkName = "Pinterest", URL = "http://www.pinterest.com" });
            modelBuilder.Entity<Link>().HasData(new Link { LinkID = 9, LinkName = "Tumblr", URL = "http://www.tumblr.com" });
            modelBuilder.Entity<Link>().HasData(new Link { LinkID = 10, LinkName = "Snapchat", URL = "http://www.snapchat.com" });

            modelBuilder.Entity<PersonHobby>().HasData(new PersonHobby { PersonHobbyID = 1, HobbyID = 1, PersonID = 1, LinkID = 1 });
            modelBuilder.Entity<PersonHobby>().HasData(new PersonHobby { PersonHobbyID = 2, HobbyID = 2, PersonID = 2, LinkID = 2 });
            modelBuilder.Entity<PersonHobby>().HasData(new PersonHobby { PersonHobbyID = 3, HobbyID = 3, PersonID = 3, LinkID = 3 });
            modelBuilder.Entity<PersonHobby>().HasData(new PersonHobby { PersonHobbyID = 4, HobbyID = 4, PersonID = 4, LinkID = 4 });
            modelBuilder.Entity<PersonHobby>().HasData(new PersonHobby { PersonHobbyID = 5, HobbyID = 1, PersonID = 5, LinkID = 5 });
            modelBuilder.Entity<PersonHobby>().HasData(new PersonHobby { PersonHobbyID = 6, HobbyID = 2, PersonID = 6, LinkID = 6 });
            modelBuilder.Entity<PersonHobby>().HasData(new PersonHobby { PersonHobbyID = 7, HobbyID = 3, PersonID = 7, LinkID = 7 });
            modelBuilder.Entity<PersonHobby>().HasData(new PersonHobby { PersonHobbyID = 8, HobbyID = 4, PersonID = 8, LinkID = 8 });
            modelBuilder.Entity<PersonHobby>().HasData(new PersonHobby { PersonHobbyID = 9, HobbyID = 1, PersonID = 9, LinkID = 9 });
            modelBuilder.Entity<PersonHobby>().HasData(new PersonHobby { PersonHobbyID = 10, HobbyID = 3, PersonID = 1, LinkID = 5 });
            modelBuilder.Entity<PersonHobby>().HasData(new PersonHobby { PersonHobbyID = 11, HobbyID = 1, PersonID = 4, LinkID = 4 });
            modelBuilder.Entity<PersonHobby>().HasData(new PersonHobby { PersonHobbyID = 12, HobbyID = 4, PersonID = 1, LinkID = 8 });
            modelBuilder.Entity<PersonHobby>().HasData(new PersonHobby { PersonHobbyID = 13, HobbyID = 2, PersonID = 8, LinkID = 8 });
            modelBuilder.Entity<PersonHobby>().HasData(new PersonHobby { PersonHobbyID = 14, HobbyID = 3, PersonID = 6, LinkID = 2 });
            modelBuilder.Entity<PersonHobby>().HasData(new PersonHobby { PersonHobbyID = 15, HobbyID = 1, PersonID = 6, LinkID = 9 });
        }
    }
}
