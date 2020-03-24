using CarvedRock.Api.GraphQL.Types;
using CarvedRock.Api.GraphQL.Userservice.Types;
using CarvedRock.Api.Repositories;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CarvedRock.Api.GraphQL
{
    public class CarvedRockQuery: ObjectGraphType
    {
        public CarvedRockQuery(ProductRepository productRepository, ProductReviewRepository reviewRepository)
        {
            Field<ListGraphType<ProductType>>(
                "products", 
                resolve: context => productRepository.GetAll()
            );

            Field<ProductType>(
                "product",
                arguments: new QueryArguments(new QueryArgument<NonNullGraphType<IdGraphType>> {Name = "id"}),
                resolve: context =>
                {
                    var id = context.GetArgument<int>("id");
                    return productRepository.GetOne(id);
                }
            );

          


            Field<ListGraphType<ProductReviewType>>(
                "reviews",
                arguments: new QueryArguments(new QueryArgument<NonNullGraphType<IdGraphType>> {Name = "productId"}),
                resolve: context =>
                {
                    var id = context.GetArgument<int>("productId");
                    return reviewRepository.GetForProduct(id);
                });


         
            Field<ListGraphType<BookType>>("books", resolve: context => Repositories.BookRepository.GetBooks());

            Field<BookType>(
               "book",
               arguments: new QueryArguments(new QueryArgument<NonNullGraphType<IdGraphType>> { Name = "id" }),
               resolve: context =>
               {
                   var id = context.GetArgument<int>("id");
                   return Repositories.BookRepository.GetBooks().FirstOrDefault(x => x.Id == id);
               });


            // UserType
            Field<ListGraphType<UserType>>("users", resolve: context => UserserviceRepository.GetUserAsync());



        }

        
    }

    
}
