using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__imtahan_Ya_Allah
{
    public class Vakansiya
    {

        public int Id{ get; set; }
        public string ?IsName{ get; set; }
        public string ?IsTecrubesi { get; set; }
        public string ?Maas { get; set; }
        public Vakansiya()
        {
            
        }
        public Vakansiya(int ıd, string? ısName, string? ısTecrubesi, string? maas)
        {
            Id = ıd;
            IsName = ısName;
            IsTecrubesi = ısTecrubesi;
            Maas = maas;
        }
        public override string ToString()
        {
            return "Id : "+Id+ "\nIsName : "+ IsName+ "\nIsTecrubesi : "+ IsTecrubesi+ "\nMaas : "+ Maas;
        }
    }
}
