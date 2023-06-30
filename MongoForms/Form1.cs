using MongoDB.Driver;
using MongoForms.Models;

namespace MongoForms
{
    public partial class Form1 : Form
    {
        private const string CONN_STRING = "mongodb+srv://ildenizy:iXf57fzPnzqmy2LH@cluster0.yjpalln.mongodb.net/?retryWrites=true&w=majority";
        private const string DB_NAME = "BookStore";
        private const string COLL_NAME = "Books";
        private const string EDITION_COLL_NAME = "Editions";
        private readonly IMongoClient _client;
        private readonly IMongoDatabase _database;
        private readonly IMongoCollection<Book> _booksCollection;
        private readonly IMongoCollection<BookEdition> _editionCollection;

        private const string TEST_ISIN = "1111111";

        public Form1()
        {
            _client = new MongoClient(CONN_STRING);
            _database = _client.GetDatabase(DB_NAME);
            _booksCollection = _database.GetCollection<Book>(COLL_NAME);
            _editionCollection = _database.GetCollection<BookEdition>(EDITION_COLL_NAME);
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }

        private void btnCreateDb_Click(object sender, EventArgs e)
        {

        }

        private void btnDropCollection_Click(object sender, EventArgs e)
        {
            _database.DropCollectionAsync(COLL_NAME).GetAwaiter().GetResult();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            var book = new Book(
                title: "Book 1",
                isin: TEST_ISIN,
                colors: (new[] { "red", "blue" }).ToList(),
                shelfCounts: new List<ShelfCount>
                {
                    new ShelfCount(count: 10, shelfName: "Book Shelf 1")
                });

            _booksCollection.InsertOne(book);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var filterDefinition = Builders<Book>.Filter.Eq(x => x.ISIN, TEST_ISIN);
            var updateDefinition = Builders<Book>.Update
                .Set(x => x.Title, "Book 1 Test")
                .Set(x => x.Colors, (new[] { "yellow", "green" }).ToList())
                ;

            _booksCollection.UpdateOne(filter: filterDefinition, update: updateDefinition);
        }

        private void btnReplace_Click(object sender, EventArgs e)
        {
            var book = new Book(
                title: "Book 1",
                isin: TEST_ISIN,
                colors: (new[] { "red", "blue" }).ToList(),
                shelfCounts: new List<ShelfCount>
                {
                    new ShelfCount(count: 10, shelfName: "Book Shelf 1")
                });

            _booksCollection.ReplaceOneAsync(x => x.ISIN == book.ISIN, book);
        }

        private void btnInsertMany_Click(object sender, EventArgs e)
        {
            var books = new Book[]
            {
                new Book(
                    title: "Book 2",
                    isin: "222222",
                    colors: (new[] { "red", "blue" }).ToList(),
                    shelfCounts: new List<ShelfCount>
                    {
                        new ShelfCount(count: 10, shelfName: "Book Shelf 2")
                    }),
                new Book(
                    title: "Book 3",
                    isin: "33333",
                    colors: (new[] { "gren" }).ToList(),
                    shelfCounts: new List<ShelfCount>
                    {
                        new ShelfCount(count: 15, shelfName: "Book Shelf 3")
                    })
            };

            _booksCollection.InsertManyAsync(books).GetAwaiter().GetResult();
        }

        private void btnUpdateMany_Click(object sender, EventArgs e)
        {
            var filterDefinition = Builders<Book>.Filter.Eq(x => x.ISIN, "33333");
            var updateDefinition = Builders<Book>.Update
                .Set(x => x.Title, "Bulk Update");

            _booksCollection.UpdateManyAsync(
                filter: filterDefinition,
                update: updateDefinition,
                new UpdateOptions { IsUpsert = true }
                );
        }

        private void btnComplexFilters_Click(object sender, EventArgs e)
        {
            var filterDefinition = Builders<Book>.Filter.Eq(x => x.ISIN, TEST_ISIN) | //&
                Builders<Book>.Filter.Ne(x => x.ISIN, "123456");

            var title = _booksCollection.Find(filterDefinition).
                ToEnumerable()
                .Select(x => x.Title)
                .FirstOrDefault();

            ShowMessage(title);
        }

        private void btnFindAndUpdate_Click(object sender, EventArgs e)
        {
            var findAndUpdateOptions = new FindOneAndUpdateOptions<Book>
            {
                ReturnDocument = ReturnDocument.Before //or After update...
            };
            var filterDefinition = Builders<Book>.Filter.Eq(x => x.ISIN, TEST_ISIN);
            var updateDefinition = Builders<Book>.Update
                .Set(x => x.Title, "Book 1 Test")
                .Set(x => x.Colors, (new[] { "yellow", "green" }).ToList())
                ;

            var document = _booksCollection.FindOneAndUpdate(
                filter: filterDefinition,
                update: updateDefinition,
                options: findAndUpdateOptions
                );

            ShowMessage(document.ISIN);
        }

        private void btnSimpleCount_Click(object sender, EventArgs e)
        {
            var filterDefinition = Builders<Book>.Filter.Empty;
            var count = _booksCollection.CountDocuments(filterDefinition);
            ShowMessage(count.ToString());
        }

        private void btnBulkUpsert_Click(object sender, EventArgs e)
        {
            var isins = new string[] { TEST_ISIN };
            var bulkWriteModelList = new List<WriteModel<Book>>();

            foreach (var isin in isins)
            {
                var filterDefinition = Builders<Book>.Filter.Eq(x => x.ISIN, isin);
                var updateDefinition = Builders<Book>.Update
                    .Set(x => x.Title, $"Book {isin}")
                    ;

                bulkWriteModelList.Add(
                    new UpdateOneModel<Book>(
                        filterDefinition,
                        updateDefinition
                    )
                    { IsUpsert = false }
                    );
            }

            _booksCollection.BulkWriteAsync(bulkWriteModelList).GetAwaiter().GetResult();
        }

        private void btnPagination_Click(object sender, EventArgs e)
        {
            var filterDefinition = Builders<Book>.Filter.Empty;
            var books = _booksCollection.Find(filterDefinition)
                .SortBy(x => x.Title)
                .ThenByDescending(x => x.ISIN)
                .Skip(0)
                .Limit(1)
                .ToList();

            ShowMessage(books.Count.ToString());
        }

        private void btnCreateIndex_Click(object sender, EventArgs e)
        {
            var indexKeys = Builders<Book>.IndexKeys;
            var indexList = new List<CreateIndexModel<Book>>()
            {
                //multiple fields
                new CreateIndexModel<Book>(
                    indexKeys.Ascending(a => a.Title).Descending(x => x.ISIN),
                    new CreateIndexOptions { Unique = false }
                    ),
                //unique index
                new CreateIndexModel<Book>(
                    indexKeys.Ascending(a => a.ISIN),
                    new CreateIndexOptions { Unique = true }
                    ),
            };

            _booksCollection.Indexes.CreateMany(indexList);
        }

        private void btnCursorBatch_Click(object sender, EventArgs e)
        {
            Task.Run(async () => await RunCursorBatch());
        }

        private async Task RunCursorBatch()
        {
            var fiterDefinition = Builders<Book>.Filter.Empty;

            using (var cursor = await _booksCollection.FindAsync(
                fiterDefinition, new FindOptions<Book> { BatchSize = 10 })
                )
            {
                while (await cursor.MoveNextAsync())
                {
                    var booksList = cursor.Current.ToList();
                    foreach (var book in booksList)
                    {
                        ShowMessage(book.ISIN);
                    }
                }
            }
        }

        private void btnTransaction_Click(object sender, EventArgs e)
        {
            Task.Run(async () => await RunTransaction());
        }

        private async Task RunTransaction()
        {
            using (var session = await _client.StartSessionAsync())
            {
                session.StartTransaction();
                var books = session.Client.GetDatabase(DB_NAME).GetCollection<Book>(COLL_NAME);

                try
                {
                    var update = new UpdateDefinitionBuilder<Book>().Mul(x => x.ShelfCounts.Count, 2);

                    await books.UpdateManyAsync(
                        session: session,
                        filter: Builders<Book>.Filter.Empty,
                        update: update);

                    await session.CommitTransactionAsync();
                }
                catch (Exception ex)
                {
                    ShowMessage(ex.Message);
                    await session.AbortTransactionAsync();
                }
            }
        }

        private void btnPopulateEdition_Click(object sender, EventArgs e)
        {
            var filterDefinition = Builders<Book>.Filter.Eq(x => x.ISIN, TEST_ISIN);
            var bookId = _booksCollection.Find(filterDefinition).
               ToEnumerable()
               .Select(x => x.BookId)
               .FirstOrDefault();

            var editions = new BookEdition[]
            {
                new BookEdition(
                name: "Edition 1",
                price: 11m,
                bookId: bookId
                ),
                new BookEdition(
                name: "Edition 2",
                price: 22m,
                bookId: bookId
                )
            };

            _editionCollection.InsertMany(editions);
        }

        private void btnLookUp_Click(object sender, EventArgs e)
        {
            var result = _booksCollection.Aggregate()
                .Lookup<Book, BookEdition, BookLookedUp>(
                _editionCollection,
                x => x.BookId,
                x => x.BookId,
                x => x.BookEditions
                )
                .ToList()
                ;
        }

        private void btnFindAll_Click(object sender, EventArgs e)
        {
            var res = _booksCollection.Find(x => x.Colors.Count > 1).ToList();

        }

        private void btnUnwind_Click(object sender, EventArgs e)
        {
            var filterDefiniton = Builders<Book>.Filter.Empty;
            var resultByColor = _booksCollection.Aggregate()
                .Match(filterDefiniton)
                .Unwind<Book, BookUnwindResultByColor>(x => x.Colors)
                .ToList();

            var resultByShelf = _booksCollection.Aggregate()
                .Match(filterDefiniton)
                .Unwind<Book, BookUnwindResultByShelf>(x => x.ShelfCounts)
                .ToList();


        }
    }
}