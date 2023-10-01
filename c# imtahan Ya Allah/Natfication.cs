using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__imtahan_Ya_Allah
{
    public class Natfication
    {

        public string ?Byname { get; set; }
        public string ?Tesviri { get; set; }
        public DateTime DateTimee { get; set; }

        public Natfication(string byname, string? tesviri ,DateTime dateTimee)
        {
            Byname=byname;
            Tesviri = tesviri;
            DateTimee=dateTimee;
        }
        public override string ToString()
        {
            return "Byname : "+ Byname+ "\nTesviri : "+ Tesviri+ "\nDateTimee : "+ DateTimee;
        }
    }
}
