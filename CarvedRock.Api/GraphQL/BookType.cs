using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarvedRock.Api.GraphQL
{
    public class BookType : ObjectGraphType<Book>
    {
        public BookType()
        {
            Field(x => x.Id);
            Field(x => x.Title);
            Field(x => x.Pages, nullable: true);
            Field(x => x.Chapters, nullable: true);
        }
    }
}
