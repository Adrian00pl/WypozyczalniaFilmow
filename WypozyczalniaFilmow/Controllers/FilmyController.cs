using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using WypozyczalniaFilmow.Models;

namespace WypozyczalniaFilmow.Controllers
{
    public class FilmyController :Controller
    {
        FilmyContext db;
        IWebHostEnvironment webHostEnvironment;

        public FilmyController(FilmyContext db, IWebHostEnvironment webHostEnvironment)
        {
            this.db = db;
            this.webHostEnvironment = webHostEnvironment;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Lista(string nazwaKategori)
        {
            var kategoria = db.Kategorie.Include("Filmy").Where(k=>k.Nazwa.ToUpper() == nazwaKategori).Single();
            var filmy = kategoria.Filmy.ToList();
            FilmyKategorie model = new FilmyKategorie();
            model.Kategoria = kategoria;
            model.FilmyKategoria = filmy;
            model.FilmyNajnowsze = db.Filmy.OrderByDescending(f => f.DataDodania).Take(3);
            model.FilmyNajdluzsze= db.Filmy.OrderByDescending(f => f.DlFilmu).Take(3);
            return View(model);

        }
        public IActionResult Szczegoly(int IdFilmu) {
            var kategoria = db.Kategorie.Find(db.Filmy.Find(IdFilmu).KategoriaId);
            var film = db.Filmy.Find(IdFilmu);
            return View(film);
        }
        public IActionResult Wszystkie()
        {
            var filmy = db.Filmy.ToList();
            return View(filmy);
        }
        [HttpGet]
        public IActionResult DodajFilm()
        {
            DodawanieViewModel dodaj = new DodawanieViewModel();
            var kategorie = db.Kategorie.ToList();
            dodaj.Kategorie = kategorie;
            return View(dodaj);
        }
        [HttpPost]
        public ActionResult DodajFilm(DodawanieViewModel  obj)
        {
            var filePath = Path.Combine(webHostEnvironment.WebRootPath, "Grafiki");
            var uniqePosterName = Guid.NewGuid() + "_" + obj.Plakat.FileName;
            var picFilePath = Path.Combine(filePath, uniqePosterName);
            obj.Plakat.CopyTo(new FileStream(picFilePath, FileMode.Create));
            obj.Film.Plakat = uniqePosterName;
            obj.Film.DataDodania = DateTime.Now;
            db.Filmy.Add(obj.Film);
            db.SaveChanges();
            return RedirectToAction("DodajFilm");
        }
        [HttpPost]
        public IActionResult Szukaj(string tekst)
        {
            var filmy = from f in db.Filmy select f;
            if (!String.IsNullOrEmpty(tekst))
            {
                filmy = filmy.Where(f => f.Tytul.Contains(tekst));
                filmy.ToList();
                ViewBag.Fraza = tekst;
                return View(filmy);
            }
            return RedirectToAction("Wszystkie");
        }
        [HttpGet]
        public ActionResult EdytujFilm(int id)
        {
            var film = db.Filmy.Where(f => f.Id == id).FirstOrDefault();
            return View(film);
        }
        [HttpPost]
        public ActionResult EdytujFilm(Film obj)
        {
            var film = db.Filmy.Where(f => f.Id == obj.Id).FirstOrDefault();
            film.Tytul = obj.Tytul;
            film.Rezyser = obj.Rezyser;
            film.Cena = obj.Cena;
            db.Entry(film).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Szczegoly", new { idFilmu = film.Id });
        }
    }
}
