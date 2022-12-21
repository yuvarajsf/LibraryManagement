using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationFinalAssignment.Data;
using WebApplicationFinalAssignment.Models;

namespace WebApplicationFinalAssignment.Controllers
{

    [Route("{controller}")]
    public class BookController : Controller
    {
        private readonly BookDbContext _db;

        public BookController(BookDbContext db)
        {
            _db = db;
        }

        //Home page for list all the books



        [Route("books")]
        [Route("/")]
        public IActionResult ListBooks()
        {
            List<Books> Obj = (from b in _db.Book
                               where b.IsDeleted == false
                               join bc in _db.Bookcategory
                               on b.BookCategoryId equals bc.CategoryId
                               select new Books
                               {
                                   BookId = b.BookId,
                                   BookDept = bc.CategoryName,
                                   BookName = b.BookName,
                                   AuthorName = b.AuthorName,
                                   PublisherYear = b.PublisherYear,
                                   Price = b.Price,
                                   UpdatedOn = b.UpdatedOn,

                               }).ToList();
            return View(Obj);
        }


        [HttpGet]
        [Route("/Details/{id}")]

        public IActionResult BookDetails(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound("404 - Requested Book Not found");
            }

            //To take selected book department from BookCategory table
            var Obj = (from b in _db.Book
                       where b.BookId == id
                       join bc in _db.Bookcategory
                       on b.BookCategoryId equals bc.CategoryId
                       select new Books
                       {
                           BookDept = bc.CategoryName,
                       }).ToList();

            ViewData["dept"] = Obj;
            //End
            ViewData["id"] = id;
            var dataObj = _db.Book.Find(id);
            if (dataObj == null)
            {
                return NotFound("404 - Given Book Details Not found!");
            }

            return View(dataObj);
        }


        // Render New book update page
        [HttpGet("[action]")]
        [Route("add")]
        public IActionResult AddBook()
        {
            var Obj = from e in _db.Bookcategory where e.IsDeleted == false select e;
            ViewBag.Dept = Obj;
            return View();
        }


        //Update new books into database
        [HttpPost("[action]")]
        [Route("insert")]
        public IActionResult AddBook(Books obj)
        {
           //Do the db action
            if (!ModelState.IsValid)
            {
                var Obj = from e in _db.Bookcategory where e.IsDeleted == false select e;
                ViewBag.Dept = Obj;
                return View(obj);
            }
            _db.Book.Add(obj);
            _db.SaveChanges();

            return RedirectToAction("books");
        }


        //Book edit page
        [HttpGet]
        [Route("edit/{id}")]

        public IActionResult EditBook(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound("404 - Not found!");
            }

            //Select department to return razor pages
            var Obj = from e in _db.Bookcategory where e.IsDeleted == false select e;
            ViewBag.Dept = Obj;
            //end

            var DataObj = _db.Book.Find(id);
            if (DataObj == null)
            {
                return NotFound("404 - No Book was Seleted!");
            }
            return View(DataObj);
        }

        //Insert edited data into database
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("Update")]
        public IActionResult EditBookDetails(Books Obj)
        {
            _db.Book.Update(Obj);
            _db.SaveChanges();
            //Do the db ACtion
            return RedirectToAction("ListBooks");
        }

        //Delete data from database

        [HttpPost]
        [Route("DeleteBook")]
        public IActionResult DeleteBook(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound("404 - Requested Book Not found");
            }
            var obj = _db.Book.Find(id);
            if (obj == null)
            {
                return NotFound("This Book Not available");
            }
            obj.IsDeleted = true;
            _db.Book.Update(obj);
            _db.SaveChanges();

            return Ok();
        }
    }
}
