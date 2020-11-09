using Microsoft.EntityFrameworkCore;
using StudentClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentAPI.Data
{
    public class StudentDBContext:DbContext
    {
        public DbSet<Student> Students { get; set; }

        public StudentDBContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Student>().HasData(
                
              new
                        {
                            StudentId = Guid.NewGuid().ToString(),
                            BCIT_ID = "A01222210",
                            City = "Burnaby",
                            Email = "aa@gmail.com",
                            FirstName = "Yashi",
                            LastName = "Girdhar",
                            MobileNumber = "604-111-1234",
                            Option = "AI",
                            Set = "S"
                        },
                        new
                        {
                            StudentId = Guid.NewGuid().ToString(),
                            BCIT_ID = "A01882220",
                            City = "Vancouver",
                            Email = "bb@gmail.com",
                            FirstName = "Frey",
                            LastName = "Tolman",
                            MobileNumber = "604-000-1234",
                            Option = "Web",
                            Set = "A"
                        },
                        new
                        {
                            StudentId = Guid.NewGuid().ToString(),
                            BCIT_ID = "A01772230",
                            City = "Surrey",
                            Email = "cc@gmail.com",
                            FirstName = "John",
                            LastName = "Doe",
                            MobileNumber = "604-333-1234",
                            Option = "Cloud",
                            Set = "B"
                        },
                        new
                        {
                            StudentId = Guid.NewGuid().ToString(),
                            BCIT_ID = "A01662240",
                            City = "Burnaby",
                            Email = "dd@gmail.com",
                            FirstName = "Yun",
                            LastName = "Wong",
                            MobileNumber = "604-444-1234",
                            Option = "Web",
                            Set = "A"
                        },
                        new
                        {
                            StudentId = Guid.NewGuid().ToString(),
                            BCIT_ID = "A01552250",
                            City = "Vancouver",
                            Email = "ee@gmail.com",
                            FirstName = "Brian",
                            LastName = "White",
                            MobileNumber = "604-555-1234",
                            Option = "AI",
                            Set = "S"
                        },
                        new
                        {
                            StudentId = Guid.NewGuid().ToString(),
                            BCIT_ID = "A01442260",
                            City = "Burnaby",
                            Email = "ff@gmail.com",
                            FirstName = "Jane",
                            LastName = "Kim",
                            MobileNumber = "604-666-1234",
                            Option = "Technical Program",
                            Set = "D"
                        },
                        new
                        {
                            StudentId = Guid.NewGuid().ToString(),
                            BCIT_ID = "A01332270",
                            City = "Surrey",
                            Email = "gg@gmail.com",
                            FirstName = "Kay",
                            LastName = "K",
                            MobileNumber = "604-777-1234",
                            Option = "AI",
                            Set = "S"
                        });
        }
    }
}
