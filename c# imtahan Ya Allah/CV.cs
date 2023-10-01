using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace c__imtahan_Ya_Allah
{
    public class Cv
    {
        public int Id { get; set; }
        public string ?Ixtisas { get; set; }
        public int UQBali{ get; set; }
        public DateTime yaratmatarixi { get; set; }
        public string? BDiller { get; set; }

        public Cv()
        {
            
        }

        public Cv(int id, string? ixtisas, int uQBali, DateTime yaratmatarixi, string? bDiller)
        {
            Id = id;
            Ixtisas = ixtisas;
            UQBali = uQBali;
            this.yaratmatarixi = yaratmatarixi;
            BDiller = bDiller;
        }

        public override string ToString() => "ID: " + Id + "\nIxtisas : " + Ixtisas + "\nUniye qebul bali : " + UQBali
                + "\nIse baslama tarixi : " + yaratmatarixi +
                "\nBildiyi diller : " + BDiller;
    }
}
