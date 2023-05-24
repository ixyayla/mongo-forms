using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoForms.Models
{
    [Serializable]
    public class BookEdition
    {
        [BsonId, BsonElement("_id"), BsonRepresentation(BsonType.ObjectId)]
        public string BookEditionId { get; set; }

        [BsonElement("name"), BsonRepresentation(BsonType.String)]
        public string Name { get; set; }

        [BsonElement("price"), BsonRepresentation(BsonType.Decimal128)]
        public decimal Price { get; set; }

        [BsonElement("book_id"), BsonRepresentation(BsonType.ObjectId)]
        public string BookId { get; set; }

        public BookEdition() { }

        public BookEdition(
            string name,
            decimal price,
            string bookId
            )
        {
            Name = name;
            Price = price;
            BookId = bookId;
        }
    }
}
