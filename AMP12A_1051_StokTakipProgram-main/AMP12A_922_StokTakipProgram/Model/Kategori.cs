using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMP12A_922_StokTakipProgram.Model
{
    public class Kategori
    {
        [Key]

        public int Id { get; set; }
        public string KatergoriAdi { get; set; }

        // İlişki : Bir Kategorinin birden fazla ürüne sahip olabilir


        public virtual ICollection<Urun> Urunler { get; set; } = new HashSet<Urun>();
    }
}
