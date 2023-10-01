using System;
using System.Data;

namespace c__imtahan_Ya_Allah
{
    public class Program
    {
        static void Workers(List<Worker> vorker)
        {
            string ?sec;
            Console.WriteLine("1 Login \n2 Registration");
            sec=Console.ReadLine();
            if (sec == "1")
            {
                string ?namee;
                string ?pasvord;
                Console.WriteLine("Name daxil edin : ");
                namee = Console.ReadLine();
                Console.WriteLine("Paswordu daxil edin : ");
                pasvord = Console.ReadLine();
                foreach (var item in vorker)
                {
                    if (item.Name == namee&& item.Pasword== pasvord)
                    {
                        Console.WriteLine(item);
                    }
                }
            }
            else if (sec == "2")
            {
                string ?id;
                string? namee;
                string? surnamee;
                string? pasvord;
                string? seher;
                string? phone;
                string? age;


            }
            else 
            {
                Workers(vorker);
            }
            

        }


        static void Start(List<Worker> workers,List<Vakansiya> vakansiyas)
        {
            bool starts = true;
            int temp = 1;
            Workers(workers);


            while (starts)
            {
                if (temp == 1)
                {
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine(temp == 1 ? "-> Worker" : "   Worker");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.WriteLine(temp == 2 ? "-> Employer" : "   Employer");
                }
                else if (temp == 2)
                {
                    
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(temp == 1 ? "-> Worker" : "   Worker");
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine(temp == 2 ? "-> Employer" : "   Employer");
                    Console.BackgroundColor = ConsoleColor.Black;
                }
                
                var key = Console.ReadKey();

                switch (key.Key)
                {
                    case ConsoleKey.Enter:
                        if (temp == 1)
                        {
                            Console.WriteLine("Salam 1");
                            Thread.Sleep(1000);
                        }
                        else if (temp == 2)
                        {

                        }

                        break;
                    case ConsoleKey.DownArrow:
                        if (temp == 1)
                        {
                            temp = 2;
                        }
                        else if (temp==2)
                        {
                            temp = 1;
                        }
                        break;
                    case ConsoleKey.UpArrow:
                        if (temp == 2)
                        {
                            temp = 1;
                        }
                        else if (temp == 1)
                        {
                            temp = 2;
                        }
                        break;
                    default: break;
                    
                    
                }
            }
        }
        static void Main()
        {
            Cv c1 = new Cv("Praqramis", "Steep it Academiya", 550, "Developer", "Steep", new DateTime(2001, 1, 2), "Pyton,C++,C#", "Var", "Var", "Var");
            Cv c2 = new Cv("It", "Steep it Academiya", 600, "Sinior", "Steep", new DateTime(2004, 1, 2), "Microsoft,Azure ","Var", "Var", "Var");
            Cv c3 = new Cv("Praqramis", "Code cademiya", 380, "Sinior Developer", "Code Academiya", new DateTime(2008, 1, 2), "Pyton,C++,C#", "Var", "Var", "Var");
            Cv c4 = new Cv("It", "Code cademiya", 320, "Sinior Developer", "Code Academiya", new DateTime(2005, 1, 2), "Azure", "Var", "Var", "Var");

            List<Cv> cvs = new List<Cv>();
            cvs.Add(c1);
            cvs.Add(c2);
            cvs.Add(c3);
            cvs.Add(c4);
            
            


            Worker worker1 = new Worker(1,"Rubail", "Rehmanli", "1234","Qebele", "070 213 57 77",28,cvs);
            
            Worker worker2 = new Worker(2,"Mehemmed", "Hemzeyev","4321", "Quba", "050 873 66 78",16,cvs);
            Worker worker3 = new Worker(3,"Pervin", "Agayev","2468", "Qobustan", "070 615 92 66",21,cvs);
            
            List<Worker> workers = new List<Worker>();
            workers.Add(worker1);
            workers.Add(worker2);
            workers.Add(worker3);
            //workers.ToString();
            Vakansiya vakansiya1 = new Vakansiya(1, "Praqramis", "5", "1500");
            Vakansiya vakansiya2 = new Vakansiya(2, "It", "5", "2300");
            Vakansiya vakansiya3 = new Vakansiya(3, "Praqramis", "5", "5000");
            List<Vakansiya> vakansiyas = new List<Vakansiya>();
            vakansiyas.Add(vakansiya1);
            vakansiyas.Add(vakansiya2);
            vakansiyas.Add(vakansiya3);


            Employer employer1 = new Employer(1, "Dasdi", "Dasdiyev","3214", "Qebele", "050 555 66 77", 32,cvs, vakansiyas);
            Employer employer2 = new Employer(2, "Haci", "Haciyev", "3216", "Qusar", "050 666 66 77", 34, cvs, vakansiyas);
            Employer employer3 = new Employer(3, "Eli", "Eliyev","3333", "Quba", "050 777 66 77", 31, cvs, vakansiyas);



            bool start=true;
            while (start)
            {
                //Console.WriteLine(worker1.ToString());
                Start(workers, vakansiyas);
                start = false;
            }
        }
    }
}