﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__imtahan_Ya_Allah
{
    public class Employer
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string?Pasword { get; set; }
        public string? Seher { get; set; }
        public string? Phone { get; set; }
        public int Age { get; set; }
        public List<Vakansiya>? Vakansiyas { get; set; }
        public List<Natfication>? notfications { get; set; }
        public Employer()
        {
            Vakansiyas = new();
            notfications = new();
        }

        public Employer(int ıd, string? name, string? surname, string? pasword,
            string? seher, string? phone, int age)
        {
            Id = ıd;
            Name = name;
            Surname = surname;
            Pasword = pasword;
            Seher = seher;
            Phone = phone;
            Age = age;
            Vakansiyas = new();
            notfications = new();
        }
        public override string ToString()
        {
            return "Id : " + Id + "\nName : " + Name + "\nSurname : "
                + Surname +"Pasword :  "+ Pasword+"\nSeher : " + Seher + "\nPhone : " + Phone + "\nAge : " + Age;
                
        }
    }
}

