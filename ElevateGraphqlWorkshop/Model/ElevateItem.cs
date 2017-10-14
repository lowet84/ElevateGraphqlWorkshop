using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQlRethinkDbLibrary.Schema.Types;
using GraphQL.Conventions;

namespace ElevateGraphqlWorkshop.Model
{
    public class ElevateItem : NodeBase<ElevateItem>
    {
        public ElevateItem(
            NonNull<string> firstname,
            NonNull<string> lastname,
            int number,
            NonNull<string> colour,
            NonNull<string> text)
        {
            Text = text;
            Number = number;
            Colour = colour;
            Name = new ElevateName(firstname, lastname);
        }

        public string Text { get; }
        public int Number { get; }
        public NonNull<string> Colour { get; }
        public ElevateName Name { get; }
    }

    public class ElevateName
    {
        public string Firstname { get; }
        public string Lastname { get; }

        public ElevateName(string firstname, string lastname)
        {
            Firstname = firstname;
            Lastname = lastname;
        }
    }
}
