

using System.Collections.Generic;

namespace ApiGateway.Dtos
{
    public class User
    {
        public int Username { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public int Email { get; set; }

        public List<Post> Posts { get; set; } = new List<Post>();

    }
}
