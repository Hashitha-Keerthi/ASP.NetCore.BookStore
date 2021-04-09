using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HKSolutions.BookStore.Controllers
{
    public class BookController : Controller
    {
        public string GetallBooks() {

            return "GetAllBooks";
        }

        public string GetBook(int id)
        {
            return $"Book with id = {id} ";
        }

        public string SearchBooks (string bookName, string authorName ){

            return $"Book with name = {bookName} &  Author = {authorName} ";
  } 
    }
}
