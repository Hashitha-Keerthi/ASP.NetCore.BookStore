using HKSolutions.BookStore.Models;
using HKSolutions.BookStore.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HKSolutions.BookStore.Controllers
{
    public class BookController : Controller
    {
        private readonly BookRepository _bookRepository =null;

        public BookController()
        {
            _bookRepository = new BookRepository();    
        }

        public List<BookModel> GetallBooks() {

            return _bookRepository.GetAllBooks();
        }

        public BookModel GetBook(int id)
        {
            return _bookRepository.GetBookById(id);
        }

        public List<BookModel> SearchBooks (string bookName, string authorName ){

            return _bookRepository.SearchBook(bookName,authorName);
  } 
    }
}
