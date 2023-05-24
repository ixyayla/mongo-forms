using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MongoForms.Models
{
    [Serializable]
    public class Book
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
        public List<ShelfCount> ShelfCounts { get; set; }

        public Book() { }

        public Book(
            string title,
            string isin,
            List<string> colors,
            List<ShelfCount> shelfCounts
            ) {
            Title = title;
            ISIN = isin;
            Colors = colors;
            ShelfCounts = shelfCounts;
        }
    }

    public class BookLookedUp: Book
    {
        public List<BookEdition> BookEditions { get; set; }
    }
}
