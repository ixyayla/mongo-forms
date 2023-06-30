using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoForms.Models
{
    public class BookUnwindResultByColor
    {
        [BsonId, BsonElement("_id"), BsonRepresentation(BsonType.ObjectId)]
        public string BookId { get; set; }

        [BsonElement("isin"), BsonRepresentation(BsonType.String)]
        public string ISIN { get; set; }

        [BsonElement("title"), BsonRepresentation(BsonType.String)]
        public string Title { get; set; }

        [BsonElement("colors")]
        public string Color { get; set; }

        [BsonElement("shelf_counts")]
        public List<ShelfCount> ShelfCounts { get; set; }
    }


    public class BookUnwindResultByShelf
    {
        [BsonId, BsonElement("_id"), BsonRepresentation(BsonType.ObjectId)]
        public string BookId { get; set; }

        [BsonElement("isin"), BsonRepresentation(BsonType.String)]
        public string ISIN { get; set; }

        [BsonElement("title"), BsonRepresentation(BsonType.String)]
        public string Title { get; set; }

        [BsonElement("colors")]
        public List<string> Colors { get; set; }

        [BsonElement("shelf_counts")]
        public ShelfCount ShelfCount { get; set; }
    }
}
