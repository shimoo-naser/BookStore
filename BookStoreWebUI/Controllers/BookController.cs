using BookStoreDomain.Abstruct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookStoreWebUI.Controllers
{
    public class BookController : Controller
    {
        private IBookRepository repository;


        public BookController(IBookRepository bookrep)
        {

            repository = bookrep;
        }

        public ViewResult List() {

            return View(repository.Books);
        }

    } 
}