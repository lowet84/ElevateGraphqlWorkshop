using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQlRethinkDbLibrary.Handlers;

namespace ElevateGraphqlWorkshop.Handler
{
    public class ImageFileHandler : DefaultImageHandler
    {
        public override IDefaultImage GetImage(string key)
        {
            throw new NotImplementedException();
        }
    }
}
