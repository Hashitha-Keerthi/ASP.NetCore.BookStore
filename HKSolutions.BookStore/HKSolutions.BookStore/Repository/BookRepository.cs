using HKSolutions.BookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HKSolutions.BookStore.Repository
{
    public class BookRepository
    {
        public List<BookModel> GetAllBooks()

        {
            return DataSource();
        }

        public BookModel GetBookById(int id)
        {
            return DataSource().Where(x => x.Id == id).FirstOrDefault();
        }

        public List<BookModel> SearchBook(string title, string authorName)
        {

            return DataSource().Where(x => x.Title.Contains(title) && x.Author.Contains(authorName)).ToList();

        }

        private List<BookModel> DataSource()
        {
            return new List<BookModel>()
            { 
            new BookModel(){ Id = 1,Title = "MVC", Author = "Hashitha" },
               new BookModel(){ Id = 2,Title = "JS", Author = "Keerthi" },
                  new BookModel(){ Id=3 ,Title = "PHP", Author = "Navod" },
                     new BookModel(){ Id = 4,Title = "GO", Author = "Lakshan" },
                        new BookModel(){ Id = 5,Title = "C#", Author = "Imesha" },

            };
        
        }

    }
}
