using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace VPShelter
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = 0;
            int newInput = 0;
            Random r = new Random();
            int i = 0;

            Dogs dog1 = new Dogs("Bruce", "Nutro", "Pitbull");
            Dogs dog2 = new Dogs("Lucky", "Blue Buffalo", "Terrier");
            Dogs dog3 = new Dogs("Coco", "Science Diet", "Pug");
            Dogs dog4 = new Dogs("Goku", "Nutro", "Great Dane");

            Volunteer vol1 = new Volunteer("James", 349056, "dogs");
            Volunteer vol2 = new Volunteer("Jasmine", 353098, "dogs");

            Manager mang1 = new Manager("Lisa", 983258, "dogs");

            List<Dogs> dogsList = new List<Dogs>
            {
                dog1,
                dog2,
                dog3,
                dog4
            };

            List<Employee> employeeList = new List<Employee>
            {
                vol1,
                vol2,
                mang1
            };

            //foreach (Dogs name in dogsList)   Will print each dog name
            //{
            //    Console.WriteLine(name.PetName);
            //}

            Timer petTimer = new Timer();
            petTimer.Interval = 12000; // 12 second intervals

            petTimer.AutoReset = true;  // Resets for repeated events

            petTimer.Enabled = true;  // Start timer

            petTimer.Elapsed += Event;  // Create event after elapsed time

            void Event(Object source, ElapsedEventArgs e)
            {
                i = r.Next(0, 3);
                dogsList[i].Tick();
                Console.WriteLine(dogsList[i].PrintName() + " levels have changed!!");
            }

            Console.WriteLine("Pets levels start the same, but will randomly change over time \n");

            while (input != 6)
            {
                Console.WriteLine("Enter Employee Type");
                Console.WriteLine("1. Volunteer");
                Console.WriteLine("2. Manager");
                Console.WriteLine("");
                Console.WriteLine("6. Exit");
                input = int.Parse(Console.ReadLine());
               
                if (input == 1)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Volunteer");
                    Console.WriteLine("Please keep our pets level's as close to 0 as possible.  Thank You! \n");
                    Console.WriteLine("1. Check Pet Levels");
                    Console.WriteLine("2. Feed Pets");
                    Console.WriteLine("3. Give Pets Water");
                    Console.WriteLine("4. Play with Pets");
                    Console.WriteLine("5. Exit");
                    newInput = int.Parse(Console.ReadLine());
                    Console.WriteLine("");

                    if (newInput == 1)
                    {
                        foreach (Dogs level in dogsList)
                        {
                            Console.WriteLine(level.CheckLevels());
                        }

                        Console.WriteLine("");
                        newInput = 0;
                    }

                    if (newInput == 2)
                    {
                        Console.WriteLine("1. Feed " + dog1.PetName);
                        Console.WriteLine("2. Feed " + dog2.PetName);
                        Console.WriteLine("3. Feed " + dog3.PetName);
                        Console.WriteLine("4. Feed " + dog4.PetName);
                        Console.WriteLine("5. Feed all dogs ");
                        newInput = int.Parse(Console.ReadLine());
                        Console.WriteLine("");

                        if (newInput == 1)
                        {
                            dog1.Eat();
                        }
                        if (newInput == 2)
                        {
                            dog2.Eat();
                        }
                        if (newInput == 3)
                        {
                            dog3.Eat();
                        }
                        if (newInput == 4)
                        {
                            dog4.Eat();
                        }
                        if (newInput == 5)
                        {
                            dog1.Eat(); dog2.Eat(); dog3.Eat(); dog4.Eat();
                            Console.WriteLine("");
                        }
                        newInput = 0;
                    }

                    if (newInput == 3)
                    {
                        Console.WriteLine("1. Give water to " + dog1.PetName);
                        Console.WriteLine("2. Give water to " + dog2.PetName);
                        Console.WriteLine("3. Give water to " + dog3.PetName);
                        Console.WriteLine("4. Give water to " + dog4.PetName);
                        Console.WriteLine("5. Give water to all dogs ");
                        newInput = int.Parse(Console.ReadLine());
                        Console.WriteLine("");

                        if (newInput == 1)
                        {
                            dog1.DrinkUp();
                        }
                        if (newInput == 2)
                        {
                            dog2.DrinkUp();
                        }
                        if (newInput == 3)
                        {
                            dog3.DrinkUp();
                        }
                        if (newInput == 4)
                        {
                            dog4.DrinkUp();
                        }
                        if (newInput == 5)
                        {
                            dog1.DrinkUp(); dog2.DrinkUp(); dog3.DrinkUp(); dog4.DrinkUp();
                            Console.WriteLine("");
                        }
                        newInput = 0;
                    }

                    if (newInput == 4)
                    {
                        Console.WriteLine("1. Play with " + dog1.PetName);
                        Console.WriteLine("2. Play with " + dog2.PetName);
                        Console.WriteLine("3. Play with " + dog3.PetName);
                        Console.WriteLine("4. Play with " + dog4.PetName);
                        Console.WriteLine("5. Play with all dogs ");
                        newInput = int.Parse(Console.ReadLine());
                        Console.WriteLine("");

                        if (newInput == 1)
                        {
                            dog1.Play();
                        }
                        if (newInput == 2)
                        {
                            dog2.Play();
                        }
                        if (newInput == 3)
                        {
                            dog3.Play();
                        }
                        if (newInput == 4)
                        {
                            dog4.Play();
                        }
                        if (newInput == 5)
                        {
                            dog1.Play(); dog2.Play(); dog3.Play(); dog4.Play();
                            Console.WriteLine();
                        }
                        newInput = 0;
                    }

                    if (newInput == 5)
                    {
                        input = 6;
                    }
                }

                if (input == 2)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Manager");
                    Console.WriteLine("1. Pet Adoption");
                    Console.WriteLine("2. Order Pet Food");
                    Console.WriteLine("3. Pet Information");
                    Console.WriteLine("4. Employee Information");
                    Console.WriteLine("5. Exit");
                    input = int.Parse(Console.ReadLine());

                    if (input == 1)
                    {
                        i = 1;
                        Console.WriteLine("");
                        Console.WriteLine("Choose A Pet");

                        foreach (Dogs info in dogsList)
                        {
                            Console.WriteLine(i++ + ". " + info.PrintPetInfo());        
                        }
                        Console.WriteLine("");

                        if (newInput == 1)
                        {
                            Console.WriteLine(dog1.Adopted());
                        }

                        if (newInput == 2)
                        {
                            Console.WriteLine(dog2.Adopted());
                        }

                        if (newInput == 3)
                        {
                            Console.WriteLine(dog3.Adopted());
                        }

                        if (newInput == 4)
                        {
                            Console.WriteLine(dog4.Adopted()); 
                        }
                        Console.WriteLine("");
                        newInput = 0;
                    }

                    if (input == 2)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Choose A Food To Order");
                        Console.WriteLine("1. " + dog1.PetDiet);
                        Console.WriteLine("2. " + dog2.PetDiet);
                        Console.WriteLine("3. " + dog3.PetDiet);
                        Console.WriteLine("4. " + dog4.PetDiet);
                        newInput = int.Parse(Console.ReadLine());
                        Console.WriteLine("");

                        if (newInput == 1)
                        {
                            Console.WriteLine(dog1.PetDiet + " has been ordered \n");
                        }
                        if (newInput == 2)
                        {
                            Console.WriteLine(dog2.PetDiet + " has been ordered \n");
                        }
                        if (newInput == 3)
                        {
                            Console.WriteLine(dog3.PetDiet + " has been ordered \n");
                        }
                        if (newInput == 4)
                        {
                            Console.WriteLine(dog4.PetDiet + " has been ordered \n");
                        }
                        newInput = 0;
                    }
                    if (input == 3)
                    {
                        Console.WriteLine("");
                        Console.WriteLine(dog1.PrintPetInfo());
                        Console.WriteLine(dog2.PrintPetInfo());
                        Console.WriteLine(dog3.PrintPetInfo());
                        Console.WriteLine(dog4.PrintPetInfo());
                        Console.WriteLine("");
                        input = 0;
                    }

                    if (input == 4)
                    {
                        i = 1;
                        foreach(Employee info in employeeList)
                        {
                            Console.WriteLine(i++ + ". " + info.BasicEmpInfo());
                        }
                        //Console.WriteLine("");
                        //Console.WriteLine(vol1.BasicEmpInfo());
                        //Console.WriteLine(vol2.BasicEmpInfo());
                        //Console.WriteLine(mang1.BasicEmpInfo());
                        Console.WriteLine("");
                        input = 0;
                    }

                    if (input == 5)
                    {
                        input = 6;
                    }

                }

            }
        }

    }
}
