using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__imtahan_Ya_Allah
{
    public class Worker
    {

        public int Id { get; set; }
        public string ?Name { get; set; }
        public string ?Surname { get; set; }
        public string? Pasword { get; set; }
        public string ?Seher { get; set; }
        public string ?Phone{ get; set; }
        public int Age { get; set; }
        public List<Cv> ?Sv { get; set; }
        public List<Natfication> notfications { get; set; }

        public Worker(int ıd, string? name, string? surname, string? pasword,
            string? seher, string? phone, int age, List<Cv> sv)
        {
            Id = ıd;
            Name = name;
            Surname = surname;
            Pasword = pasword;
            Seher = seher;
            Phone = phone;
            Age = age;
            Sv=sv;  
        }
        public override string ToString()
        {
            
            return "Id : " + Id + "\nName : " + Name + "\nSurname : "
                + Surname + "\nPasword : "+ Pasword+"\nSeher : " + Seher + "\nPhone : " + Phone + "\nAge : " + Age;
            
            
        }

    }
}
