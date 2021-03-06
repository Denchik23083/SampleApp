using System;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace DataRequestSample
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var connectionString = @"Data Source = USER-PC\SQLEXPRESS; Initial Catalog = Book; Integrated Security = True;";
            
            using var connection = new SqlConnection(connectionString);
            await connection.OpenAsync();

            #region SELECT
            // SELECT
            //await RawQueriesExample.GetBooksQueryAsync(connection);
            #endregion

            #region INSERT
            // INSERT
            //var book = new Book
            //{
            //    Title = "Гарри Поттер и Кубок Огня",
            //    Author = "Дж. Роулинг",
            //    PagesCount = 600,
            //    PublishDate = new DateTime(2004, 10, 11)
            //};

            //await RawQueriesExample.InsertBookAsync(book, connection);
            #endregion

            #region SCHEMA
            //await RawQueriesExample.SelectViaSchema(connection);
            #endregion

            using var bookRepository = new Repository<Book>(connection);
            var books = bookRepository.Get();

            foreach (var book in books)
            {
                Console.WriteLine($"{book.Id} {book.Title} {book.Author} {book.PagesCount} {book.PublishDate}");
            }
        }


    }
}
