using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tweetbook2.Contracts
{
    public class ApiRoutes
    {
        public static class Posts
        {
            public const string Root = "api";
            public const string Version = "v1";
            public const string Base = Root + "/" + Version;

            public const string GetAll = Base + "/posts";
            public const string Get = Base + "/post/{postId}";
            public const string Create = Base + "/post";
            public const string Update = Base + "/post/{postId}";
        }
    }
}