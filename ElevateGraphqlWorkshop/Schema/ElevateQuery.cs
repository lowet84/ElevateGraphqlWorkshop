using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ElevateGraphqlWorkshop.Model;
using GraphQlRethinkDbLibrary;
using GraphQL.Conventions;
using GraphQL.Conventions.Relay;

namespace ElevateGraphqlWorkshop.Schema
{
    [ImplementViewer(OperationType.Query)]
    public class ElevateQuery
    {
        public ElevateItem ElevateItem(UserContext context, Id id)
        {
            return context.Get<ElevateItem>(id);
        }

        public ElevateItem[] AllElevateItems(UserContext context)
        {
            return context.GetAll<ElevateItem>(UserContext.ReadType.WithDocument);
        }
    }
}
