using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQlRethinkDbLibrary.Schema.Types;

namespace ElevateGraphqlWorkshop.Model
{
    public class ElevateItem : NodeBase<ElevateItem>
    {
        public ElevateItem(string text, int number)
        {
            Text = text;
            Number = number;
        }

        public string Text { get; }
        public int Number { get; }
    }
}
