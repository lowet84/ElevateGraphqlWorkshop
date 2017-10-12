using System.Net.Http;
using ElevateGraphqlWorkshop.Model;
using GraphQlRethinkDbLibrary;
using GraphQlRethinkDbLibrary.Schema.Output;
using GraphQL.Conventions.Relay;
using Random = System.Random;

namespace ElevateGraphqlWorkshop.Schema
{
    [ImplementViewer(OperationType.Mutation)]
    public class ElevateMutation
    {
        public DefaultResult<ElevateItem> AddElevateItem(UserContext context, string text, int number)
        {
            var newItem = new ElevateItem(text, number);
            context.AddDefault(newItem);
            return new DefaultResult<ElevateItem>(newItem);
        }

        public DefaultResult<ElevateItem> AddRandom(UserContext context)
        {
            using (var client = new HttpClient(new HttpClientHandler{}))
            {
                var random = new Random();
                var number = random.Next(10000);
                var text = client.GetStringAsync("http://whatthecommit.com/index.txt").Result;
                var newItem = new ElevateItem(text, number);
                context.AddDefault(newItem);
                return new DefaultResult<ElevateItem>(newItem);
            }
        }
    }
}
