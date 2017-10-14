using System;
using System.Net.Http;
using ElevateGraphqlWorkshop.Model;
using GraphQlRethinkDbLibrary;
using GraphQlRethinkDbLibrary.Schema.Output;
using GraphQL.Conventions;
using GraphQL.Conventions.Relay;
using Random = System.Random;

namespace ElevateGraphqlWorkshop.Schema
{
    [ImplementViewer(OperationType.Mutation)]
    public class ElevateMutation
    {
        public DefaultResult<ElevateItem> AddElevateItem(
            UserContext context,
            NonNull<string> firstname,
            NonNull<string> lastname,
            int number,
            NonNull<string> colour,
            NonNull<string> text)
        {
            var newItem = new ElevateItem(firstname, lastname, number, colour, text);
            context.AddDefault(newItem);
            return new DefaultResult<ElevateItem>(newItem);
        }

        //public DefaultResult<ElevateItem> AddRandom(UserContext context)
        //{
        //    using (var client = new HttpClient(new HttpClientHandler()))
        //    {
        //        var random = new Random();
        //        var number = random.Next(10000);
        //        var text = client.GetStringAsync("http://whatthecommit.com/index.txt").Result;
        //        long longNumber = random.Next(1000000000);
        //        var negative = random.Next(-10000, 10000);
        //        var guid = Guid.NewGuid().ToString();
        //        var newItem = new ElevateItem(text, number, longNumber, negative, guid);
        //        context.AddDefault(newItem);
        //        return new DefaultResult<ElevateItem>(newItem);
        //    }
        //}
    }
}
