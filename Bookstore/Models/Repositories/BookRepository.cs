using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookstore.Models.Repositories
{
    public class BookRepository : IBookStoreRepository<Book>
    {
        IList<Book> books;
        public BookRepository()
        {
            books = new List<Book>()
            {
                new Book
                {
                    Id = 1, Description = "No description",
                    Title = "programming",
                },
                  new Book
                  {
                      Id = 2,
                      Description = "No description",
                      Title = "programming"
                  },
                  new Book
                  {
                      Id = 3,
                      Description = "No description",
                      Title = "programming"
                  }
            };

        }
        public void Add(Book entity)
        {
            books.Add(entity);  
        }

        public void Delete(int id)
        {
            var book = Find(id);
            books.Remove(book);
        }

        public Book Find(int id)
        {
            var book = books.SingleOrDefault(b => b.Id == id);
            return book;
        }

        public IList<Book> List()
        {
            return books;
        }

        public void Update(int id, Book newBook)
        {
            var book = Find(id);
            book.Title = newBook.Title;
            book.Description = newBook.Description;
            book.Author = newBook.Author;
        }
    }
}
