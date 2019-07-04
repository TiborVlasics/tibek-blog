using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace TibekBlog.Models
{
    public class Post
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("Name")]
        public string title { get; set; }
    }
}
