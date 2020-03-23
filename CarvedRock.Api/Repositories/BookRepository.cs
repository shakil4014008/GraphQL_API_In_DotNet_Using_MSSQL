using CarvedRock.Api.GraphQL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarvedRock.Api.Repositories
{
    public class BookRepository
    {
        public static List<Book> GetBooks()
        {
            var books = new List<Book>
            {
                    new Book {
                                Id = 1 ,
                        Title = "Fullstack tutorial for GraphQL" ,
                                Pages = 356
                            },
                    new Book
                            {
                                Id = 2 ,
                                Title = "Introductory tutorial to GraphQL" ,
                                Chapters = 10
                            },
                    new Book
                            {
                        Id = 3 ,
                                Title= "GraphQL Schema Design for the Enterprise" ,
                                Pages= 550 ,
                                Chapters= 25
                            }
             };

            return books;
        }
    }
}
