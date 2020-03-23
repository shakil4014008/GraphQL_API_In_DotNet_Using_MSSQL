using CarvedRock.Api.GraphQL.Userservice.Model;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarvedRock.Api.GraphQL.Userservice.Types
{
    
    public class UserType : ObjectGraphType<User>
    {
        public UserType()
        {
            Field(x => x.UserId);
            Field(x => x.FirstName);
            Field(x => x.LastName);
            Field(x => x.Age, nullable: true);
        }
    }
}
