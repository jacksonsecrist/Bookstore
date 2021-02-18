using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookstore.Models
{
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder application)
        {
            BookstoreDBContext context = application.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<BookstoreDBContext>();

            if(context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            if(!context.Books.Any())
            {
                context.Books.AddRange(
                
                    new Book //book 1
                    {
                        Title = "Les Miserables",
                        Author = "Victor Hugo",
                        Publisher = "Signet",
                        ISBN = "978-0451419439",
                        ClassOrCategory = "Fiction, Classic",
                        Price = 9.95F
                    },

                    new Book //book 2
                    {
                        Title = "Team of Rivals",
                        Author = "Doris Kearns Goodwin",
                        Publisher = "Simon & Schuster",
                        ISBN = "978-0743270755",
                        ClassOrCategory = "Non-Fiction, Biography",
                        Price = 14.58F
                    },

                    new Book //book 3
                    {
                        Title = "The Snowball",
                        Author = "Alice Schroeder",
                        Publisher = "Bantam",
                        ISBN = "978-0553384611",
                        ClassOrCategory = "Non-Fiction, Biography",
                        Price = 21.54F
                    },

                    new Book //book 4
                    {
                        Title = "American Ulysses",
                        Author = "Ronal C. White",
                        Publisher = "Random House",
                        ISBN = "978-0812981254",
                        ClassOrCategory = "Non-Fiction, Biography",
                        Price = 11.61F
                    },

                    new Book //book 5
                    {
                        Title = "Unbroken",
                        Author = "Laura Hillenbrand",
                        Publisher = "Random House",
                        ISBN = "978-0812974492",
                        ClassOrCategory = "Non-Fiction, Historical",
                        Price = 13.33F
                    },

                    new Book //book 6
                    {
                        Title = "The Great Train Robbery",
                        Author = "Michael Crichton",
                        Publisher = "Vintage",
                        ISBN = "978-0804171281",
                        ClassOrCategory = "Fiction, Historical Fiction",
                        Price = 15.95F
                    },

                    new Book //book 7
                    {
                        Title = "Deep Work",
                        Author = "Cal Newport",
                        Publisher = "Grand Central Publishing",
                        ISBN = "978-1455586691",
                        ClassOrCategory = "Non-Fiction, Self-Help",
                        Price = 14.99F
                    },

                    new Book //book 8
                    {
                        Title = "It's Your Ship",
                        Author = "Michael Abrashoff",
                        Publisher = "Grand Central Publishing",
                        ISBN = "978-1455523023",
                        ClassOrCategory = "Non-Fiction, Self-Help",
                        Price = 21.66F
                    },

                    new Book //book 9
                    {
                        Title = "The Virgin Way",
                        Author = "Richard Branson",
                        Publisher = "Portfolio",
                        ISBN = "978-1591847984",
                        ClassOrCategory = "Non-Fiction, Business",
                        Price = 29.16F
                    },

                    new Book //book 10
                    {
                        Title = "Sycamore Row",
                        Author = "John Grisham",
                        Publisher = "Bantam",
                        ISBN = "978-0553393613",
                        ClassOrCategory = "Fiction, Thrillers,",
                        Price = 15.03F
                    }
                );

                context.SaveChanges();
            }
        }
    }
}
