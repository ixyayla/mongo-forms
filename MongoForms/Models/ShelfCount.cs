using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace MongoForms.Models
{
    public class ShelfCount
    {
        [BsonElement("shelf_name"), BsonRepresentation(BsonType.String)]
        public string ShelfName { get; set; }

        [BsonElement("count"), BsonRepresentation(BsonType.Int32)]
        public int Count { get; set; }

        public ShelfCount() { }

        public ShelfCount(int count, string shelfName) {
            Count = count;
            ShelfName = shelfName;
        }
    }
}
