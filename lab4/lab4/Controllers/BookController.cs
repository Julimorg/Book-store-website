using lab4.Models;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebGrease;

namespace lab4.Controllers
{
    public class BookController : Controller
    {
        dbBookStoreDataContext db = new dbBookStoreDataContext();
        // GET: Book
        public ActionResult Index(int? page, string searchString)
        {
            ViewBag.KeyWord = searchString;
            if (page == null) _ = page == 1;
            var all_book = (from books in db.Books select books).OrderBy(m => m.book_id);
            if (!string.IsNullOrEmpty(searchString))
                all_book = (IOrderedQueryable<Book>)all_book.Where(a => a.book_name.Contains(searchString));
            int pageSize = 3;
            int pageNum = page ?? 1;
            return View(all_book.ToPagedList(pageNum, pageSize));

        }
        // detail
        public ActionResult Detail(int id)
        {
            var D_book = db.Books.Where(m => m.book_id == id).First();
            return View(D_book);
        }
        //Edit
        public ActionResult Edit(int id)
        {
            var E_sach = db.Books.First(m => m.book_id == id);
            return View(E_sach);
        }
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            var E_book = db.Books.First(m => m.book_id == id);
            var E_name = collection["book_name"];
            var E_image = collection["image"];
            var E_price = Convert.ToDecimal(collection["price"]);
            var E_updatedate = Convert.ToDateTime(collection["update_name"]);
            var E_quantity = Convert.ToInt32(collection["quantity_instock"]);
            E_book.book_id = id;
            if (string.IsNullOrEmpty(E_name))
            {
                ViewData["Error"] = "Don't empty!";
            }
            else
            {
                E_book.book_name = E_name;
                E_book.image = E_image;
                E_book.price = E_price;
                E_book.update_date = E_updatedate;
                E_book.quantity_instock = E_quantity;
                UpdateModel(E_book);
                db.SubmitChanges();
                return RedirectToAction("Index");
            }
            return this.Edit(id);

        }
        public string ProcessUpload(HttpPostedFileBase file)
        {
            if (file == null)
            {
                return "";
            }
            file.SaveAs(Server.MapPath("~/Content/images/" + file.FileName));
            return "/Content/images/" + file.FileName;
        }
        //create - page
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(FormCollection collection, Book s)
        {
            var E_name = collection["Book_name"];
            var E_image = collection["image"];
            var E_price = Convert.ToDecimal(collection["price"]);
            var E_updatedate = Convert.ToDateTime(collection["update_date"]);
            var E_quantity = Convert.ToInt32(collection["quantity_instock"]);
            if (string.IsNullOrEmpty(E_name))
            {
                ViewData["Error"] = " Dont Empty!";
            }
            else
            {
                s.book_name = E_name.ToString();
                s.image = E_image.ToString();
                s.price = E_price;
                s.update_date = E_updatedate;
                s.quantity_instock = E_quantity;
                db.Books.InsertOnSubmit(s);
                db.SubmitChanges();
                return RedirectToAction("Index");
            }
            return this.Create();
        }
        //Delete - page
        public ActionResult Delete(int id)
        {
            var D_book = db.Books.First(m => m.book_id == id);
            return View(D_book);
        }
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            var D_sach = db.Books.Where(m => m.book_id == id).First();
            db.Books.DeleteOnSubmit(D_sach);
            db.SubmitChanges();
            return RedirectToAction("Index");
        }
        //Home-Page
        public ActionResult Home(int? size, int? page)
        {
            List<SelectListItem> items = new List<SelectListItem>();
            items.Add(new SelectListItem { Text = "3", Value = " 3 " });
            items.Add(new SelectListItem { Text = "6", Value = " 6 " });
            items.Add(new SelectListItem { Text = "12", Value = " 12" });
            items.Add(new SelectListItem { Text = "24", Value = " 24 " });
            items.Add(new SelectListItem { Text = "48", Value = " 48" });
            foreach (var item in items)
            {
                if (item.Value == size.ToString())
                    item.Selected = true;
            }
            ViewBag.size = items; //ViewBag DropdownList
            ViewBag.currentSize = size;
            if (page == null) page = 1;
            var all_book = from book in db.Books select book;
            int pageSize = (size ?? 3);
            int pageNum = page ?? 1;
            return View(all_book.ToPagedList(pageNum, pageSize));

        }
    }
}
