using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WypozyczalniaFilmow.Models;

namespace WypozyczalniaFilmow.Controllers
{
    public class FilmyController :Controller
    {
        FilmyContext db;

        public FilmyController(FilmyContext db)
        {
            this.db = db;
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
    }
}
