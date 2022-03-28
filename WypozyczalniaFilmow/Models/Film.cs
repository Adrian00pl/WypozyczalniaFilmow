using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WypozyczalniaFilmow.Models
{
    public class Film
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="Brak tytułu!")]
        public string Tytul { get; set; }
        public string Rezyser { get; set; }
        [StringLength(500)]
        public string Opis { get; set; }
        public decimal Cena { get; set; }
        public DateTime DataDodania { get; set; }
        public int KategoriaId { get; set; }
        public int DlFilmu { get; set; }
        public Kategoria Kategoria { get; set; }
        public String Plakat { get; set; }

    }
}
