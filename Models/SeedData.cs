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

            //check for existing migrations
            if(context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            //check for existing data in DB. If no data, populate the DB
            if(!context.Books.Any())
            {
                context.Books.AddRange(
                
                    new Book //book 1
                    {
                        Title = "Les Miserables",
                        Author = "Victor Hugo",
                        Publisher = "Signet",
                        ISBN = "978-0451419439",
                        Classification = "Fiction",
                        Category = "Classic",
                        Price = 9.95M,
                        NumPages = 1488
                    },

                    new Book //book 2
                    {
                        Title = "Team of Rivals",
                        Author = "Doris Kearns Goodwin",
                        Publisher = "Simon & Schuster",
                        ISBN = "978-0743270755",
                        Classification = "Non-Fiction",
                        Category = "Biography",
                        Price = 14.58M,
                        NumPages = 944
                    },

                    new Book //book 3
                    {
                        Title = "The Snowball",
                        Author = "Alice Schroeder",
                        Publisher = "Bantam",
                        ISBN = "978-0553384611",
                        Classification = "Non-Fiction",
                        Category = "Biography",
                        Price = 21.54M,
                        NumPages = 832
                    },

                    new Book //book 4
                    {
                        Title = "American Ulysses",
                        Author = "Ronal C. White",
                        Publisher = "Random House",
                        ISBN = "978-0812981254",
                        Classification = "Non-Fiction",
                        Category = "Biography",
                        Price = 11.61M,
                        NumPages = 864
                    },

                    new Book //book 5
                    {
                        Title = "Unbroken",
                        Author = "Laura Hillenbrand",
                        Publisher = "Random House",
                        ISBN = "978-0812974492",
                        Classification = "Non-Fiction",
                        Category = "Historical",
                        Price = 13.33M,
                        NumPages = 528
                    },

                    new Book //book 6
                    {
                        Title = "The Great Train Robbery",
                        Author = "Michael Crichton",
                        Publisher = "Vintage",
                        ISBN = "978-0804171281",
                        Classification = "Fiction",
                        Category = "Historical Fiction",
                        Price = 15.95M,
                        NumPages = 288
                    },

                    new Book //book 7
                    {
                        Title = "Deep Work",
                        Author = "Cal Newport",
                        Publisher = "Grand Central Publishing",
                        ISBN = "978-1455586691",
                        Classification = "Non-Fiction",
                        Category = "Self-Help",
                        Price = 14.99M,
                        NumPages = 304
                    },

                    new Book //book 8
                    {
                        Title = "It's Your Ship",
                        Author = "Michael Abrashoff",
                        Publisher = "Grand Central Publishing",
                        ISBN = "978-1455523023",
                        Classification = "Non-Fiction",
                        Category = "Self-Help",
                        Price = 21.66M,
                        NumPages = 240
                    },

                    new Book //book 9
                    {
                        Title = "The Virgin Way",
                        Author = "Richard Branson",
                        Publisher = "Portfolio",
                        ISBN = "978-1591847984",
                        Classification = "Non-Fiction",
                        Category = "Business",
                        Price = 29.16M,
                        NumPages = 400
                    },

                    new Book //book 10
                    {
                        Title = "Sycamore Row",
                        Author = "John Grisham",
                        Publisher = "Bantam",
                        ISBN = "978-0553393613",
                        Classification = "Fiction",
                        Category = "Thriller",
                        Price = 15.03M,
                        NumPages = 642
                    },

                    new Book
                    {
                        Title = "The Ruins of Gorlan",
                        Author = "John Flanagan",
                        Publisher = "Random House",
                        ISBN = "978-0142406632",
                        Classification = "Fiction",
                        Category = "Fantasy",
                        Price = 8.29M,
                        NumPages = 265
                    },

                    new Book
                    {
                        Title = "Ready Player One",
                        Author = "Ernest Cline",
                        Publisher = "Crown Publishing Group",
                        ISBN = "978-1524763282",
                        Classification = "Fiction",
                        Category = "Science Fiction",
                        Price = 12.78M,
                        NumPages = 374
                    },

                    new Book
                    {
                        Title = "Orphan X",
                        Author = "Gregg Hurwitz",
                        Publisher = "Minotaur Books",
                        ISBN = "978-1250067845",
                        Classification = "Fiction",
                        Category = "Thriller",
                        Price = 14.95M,
                        NumPages = 368
                    }
                );

                context.SaveChanges();
            }
        }
    }
}
