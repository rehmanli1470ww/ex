using System;
using System.Data;
using System.Security.Principal;
using System.Text.Json;

namespace c__imtahan_Ya_Allah
{
    public class Program
    {
        static void fillData()
        {
            if (File.Exists("workers.json"))
            {
                var data = File.ReadAllText("workers.json");
                Database.workers = JsonSerializer.Deserialize<List<Worker>>(data);
            }
            if (File.Exists("employers.json"))
            {
                var data = File.ReadAllText("employers.json");
                Database.employers = JsonSerializer.Deserialize<List<Employer>>(data);
            }
        }
        static void LogInWorker()
        {
            Console.Clear();
            Console.Write("name: ");
            string name = Console.ReadLine();
            Console.Write("password: ");
            string password = Console.ReadLine();
            foreach (var item in Database.workers)
            {
                if (name == item.Name && password == item.Pasword)
                {
                Start:
                    Console.Clear();
                    Console.WriteLine("1 - notfications\n2 - show all vacanies\n3 - filtered vacannies\n4 - creat a new cv\n5 - exit");
                    int choice = 0;
                    try
                    {
                        choice= int.Parse(Console.ReadLine());

                    }
                    catch (Exception)
                    {

                        goto Start;
                    }
                    if (choice == 1)
                    {
                        foreach (var node in item.notfications)
                            Console.WriteLine(node);
                        Console.ReadKey();
                        goto Start;
                    }
                    if (choice == 2)
                    {
                        Console.Clear();
                        foreach (var em in Database.employers)
                            foreach (var vc in em.Vakansiyas)
                                Console.WriteLine(vc);
                        Console.WriteLine("1 - REQUEST\n 2 - GO TO BACK");
                        choice = int.Parse(Console.ReadLine());
                        switch (choice)
                        {
                            case 1:
                                Console.WriteLine("enter id of vc");
                                choice = int.Parse(Console.ReadLine());
                                foreach (var em in Database.employers)
                                    foreach (var vc in em.Vakansiyas)
                                    {
                                        if (vc.Id == choice)
                                        {
                                            em.notfications.Add(new Natfication(item.Name, "request", DateTime.Now));
                                            File.WriteAllText("employers.json", JsonSerializer.Serialize(Database.employers, new JsonSerializerOptions() { WriteIndented = true }));
                                        }
                                    }
                                break;
                            case 2: goto Start;
                        }
                    }
                    if (choice == 3)
                    {
                        Console.Clear();
                        Console.WriteLine("programming \nIT\nDesign\n\nenter full name of profession");
                        string profession = Console.ReadLine();
                        foreach (var em in Database.employers)
                            foreach (var vc in em.Vakansiyas)
                            {
                                if (vc.IsName == profession)
                                    Console.WriteLine(vc);
                            }
                        Console.WriteLine("1 - REQUEST\n 2 - GO TO BACK");
                        choice = int.Parse(Console.ReadLine());
                        switch (choice)
                        {
                            case 1:
                                Console.WriteLine("enter id of vc");
                                choice = int.Parse(Console.ReadLine());
                                foreach (var em in Database.employers)
                                    foreach (var vc in em.Vakansiyas)
                                    {
                                        if (vc.Id == choice)
                                        {
                                            em.notfications.Add(new Natfication(item.Name, "request", DateTime.Now));
                                            File.WriteAllText("employers.json", JsonSerializer.Serialize(Database.employers, new JsonSerializerOptions() { WriteIndented = true }));
                                        }
                                    }
                                break;
                            case 2: goto Start;
                        }

                    }
                    if (choice == 4)
                    {
                        Console.Clear();
                        Cv cv = new();
                    error:
                        Console.Write("enter vc id: ");
                        try
                        {
                            cv.Id = int.Parse(Console.ReadLine());

                        }
                        catch (Exception)
                        {
                            goto error;
                        }
                        Console.WriteLine("programming \nIT\nDesign\n\nenter full name of profession");
                        cv.Ixtisas = Console.ReadLine();
                    error2:
                        Console.Write("enter uniye qebul bal: ");
                        try
                        {
                            cv.UQBali = int.Parse(Console.ReadLine());
                        }
                        catch (Exception)
                        {
                            goto error2;
                        }
                        Console.Write("enter bildiyin diller: ");
                        cv.BDiller = (Console.ReadLine());
                        cv.yaratmatarixi = DateTime.Now;
                        item.Sv.Add(cv);
                        File.WriteAllText("workers.json", JsonSerializer.Serialize(Database.workers, new JsonSerializerOptions() { WriteIndented = true }));
                        goto Start;
                    }
                    else
                    {
                        Workers();
                    }
                }
            }
        }
        static void LogInemployer()
        {
            Console.Clear();
            Console.Write("enter name: ");
            string name = Console.ReadLine();
            Console.Write("enter password: ");
            string password = Console.ReadLine();
            foreach (var item in Database.employers)
            {
                if (name == item.Name && password == item.Pasword)
                {
                Start:
                    Console.Clear();
                    Console.WriteLine("1 - notfications\n2 - show all cv\n3 - filtered cv\n4 - creat a new vacancs\n5 - exit");
                    int choice = int.Parse(Console.ReadLine());
                    if (choice == 1)
                    {
                        foreach (var node in item.notfications)
                            Console.WriteLine(node);
                        Console.ReadKey();
                        goto Start;
                    }
                    if (choice == 2)
                    {
                        Console.Clear();
                        foreach (var em in Database.workers)
                            foreach (var vc in em.Sv)
                                Console.WriteLine(vc);
                        Console.WriteLine("1 - REQUEST\n 2 - GO TO BACK");
                        choice = int.Parse(Console.ReadLine());
                        switch (choice)
                        {
                            case 1:
                                Console.WriteLine("enter id of vc");
                                choice = int.Parse(Console.ReadLine());
                                foreach (var em in Database.workers)
                                    foreach (var vc in em.Sv)
                                    {
                                        if (vc.Id == choice)
                                        {
                                            em.notfications.Add(new Natfication(item.Name, "invited", DateTime.Now));
                                            File.WriteAllText("workers.json", JsonSerializer.Serialize(Database.workers, new JsonSerializerOptions() { WriteIndented = true }));
                                        }
                                    }
                                break;
                            case 2: goto Start;
                        }
                    }
                    if (choice == 3)
                    {
                        Console.Clear();
                        Console.WriteLine("programming \nIT\nDesign\n\nenter full name of profession");
                        string profession = Console.ReadLine();
                        foreach (var em in Database.workers)
                            foreach (var vc in em.Sv)
                            {
                                if (vc.Ixtisas == profession)
                                    Console.WriteLine(vc);
                            }
                        Console.WriteLine("1 - REQUEST\n 2 - GO TO BACK");
                        choice = int.Parse(Console.ReadLine());
                        switch (choice)
                        {
                            case 1:
                                Console.WriteLine("enter id of vc");
                                choice = int.Parse(Console.ReadLine());
                                foreach (var em in Database.workers)
                                    foreach (var vc in em.Sv)
                                    {
                                        if (vc.Id == choice)
                                        {
                                            em.notfications.Add(new Natfication(item.Name, "invited", DateTime.Now));
                                            File.WriteAllText("workers.json", JsonSerializer.Serialize(Database.workers, new JsonSerializerOptions() { WriteIndented = true }));
                                        }
                                    }
                                break;
                            case 2: goto Start;
                        }
                    }
                    if (choice == 4)
                    {
                        Vakansiya vc = new();
                        Console.Write("enter vc id: ");
                        vc.Id = int.Parse(Console.ReadLine());
                        Console.WriteLine("programming \nIT\nDesign\n\nenter full name of profession");
                        vc.IsName = Console.ReadLine();
                        Console.Write("enter salary: ");
                        vc.Maas = (Console.ReadLine());
                        Console.Write("enter work experence: ");
                        vc.IsTecrubesi = (Console.ReadLine());
                        item.Vakansiyas.Add(vc);
                        File.WriteAllText("employers.json", JsonSerializer.Serialize(Database.employers, new JsonSerializerOptions() { WriteIndented = true }));
                        goto Start;
                    }
                    else { Employers(); }
                }
            }
        }
        static void Registrationworker()
        {
            Console.Clear();

            Worker wk = new Worker();
            error:
            Console.Write("iD: ");
            try
            {

            wk.Id = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {

                goto error;
            }
            Console.Write("name: ");
            wk.Name = (Console.ReadLine());
            Console.Write("surname: ");
            wk.Surname = (Console.ReadLine());
            Console.Write("seher: ");
            wk.Seher = (Console.ReadLine());
            Console.Write("password: ");
            wk.Pasword = (Console.ReadLine());
            Console.Write("phone: ");
            wk.Phone = (Console.ReadLine());
            error2:
            Console.Write("age: ");
            try
            {

            wk.Age = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {

                goto error2;
            }
            Console.WriteLine("is successfully");
            Database.workers.Add(wk);
            File.WriteAllText("workers.json", JsonSerializer.Serialize(Database.workers, new JsonSerializerOptions() { WriteIndented = true }));
            Workers();
        }
        static void Registrationemployer()
        {
            Console.Clear();

            Employer em = new();
            error:
            Console.Write("iD: ");
            try
            {
            em.Id = int.Parse(Console.ReadLine());

            }
            catch (Exception)
            {

                goto error;
            }
            Console.Write("name: ");
            em.Name = (Console.ReadLine());
            Console.Write("surname: ");
            em.Surname = (Console.ReadLine());
            Console.Write("seher: ");
            em.Seher = (Console.ReadLine());
            Console.Write("password: ");
            em.Pasword = (Console.ReadLine());
            Console.Write("phone: ");
            em.Phone = (Console.ReadLine());
            error2:
            Console.Write("age: ");
            try
            {
            em.Age = int.Parse(Console.ReadLine());

            }
            catch (Exception)
            {

                goto error2;
            }
            Console.WriteLine("is successfully");
            Database.employers.Add(em);
            File.WriteAllText("employers.json", JsonSerializer.Serialize(Database.employers, new JsonSerializerOptions() { WriteIndented = true }));
            Employers();
        }
        static void Workers()
        {
            Console.Clear();

            string? sec;
            Console.WriteLine("1 Login \n2 Registration\n3 - exit\nenter choice: ");
            sec = Console.ReadLine();
            if (sec == "1")
            {
                LogInWorker();
            }
            else if (sec == "2")
            {
                Registrationworker();
            }
            else Start();
        }


        static void Employers()
        {
            Console.Clear();

            string? sec;
            Console.Write("1 Login \n2 Registration\n3 - exit\nenter choice: ");
            sec = Console.ReadLine();
            if (sec == "1")
            {
                LogInemployer();
            }
            else if (sec == "2")
            {
                Registrationemployer();
            }
            else Start();
        }
        static void Start()
        {
            bool starts = true;
            int temp = 1;


            while (starts)
            {
                Console.Clear();
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
                    Console.ForegroundColor = ConsoleColor.White;
                }

                var key = Console.ReadKey();

                switch (key.Key)
                {
                    case ConsoleKey.Enter:
                        if (temp == 1)
                            Workers();
                        else if (temp == 2)
                            Employers();
                        break;
                    case ConsoleKey.DownArrow:
                        if (temp == 1)
                        {
                            temp = 2;
                        }
                        else if (temp == 2)
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
            bool start = true;
            while (start)
            {
                fillData();
                Start();
                start = false;
            }
        }
    }
}