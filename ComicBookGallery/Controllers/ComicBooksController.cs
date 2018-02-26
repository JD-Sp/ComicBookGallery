using System;
using System.Web;
using Microsoft.AspNetCore.Mvc;
using ComicBookGallery.Models;
using ComicBookGallery.Data;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller
    {
        private ComicBookRepository _comicBookRepository = null;

        public ComicBooksController()
        {
            _comicBookRepository = new ComicBookRepository();
        }

        public ActionResult Detail(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }
            ComicBook comicBook = _comicBookRepository.GetComicBook((int)id);
            return View(comicBook);
        }
    }
}
