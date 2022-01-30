using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test.Models
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                    new User
                    {
                        id = 1,
                        user_name = "Mary",
                        password ="132",
                    }   ,
                   new User
                    {
                       id = 2,
                      user_name = "Harry",
                    password = "456",
                    }
                );
        }
    }
}

