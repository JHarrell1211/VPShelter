using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    class Program
    {
        static void Main(string[] args)
        {
            Dogs dog1 = new Dogs("Bruce", "Nutro", "Pitbull");
            Dogs dog2 = new Dogs("Lucky", "Blue Buffalo", "Terrier");
            Dogs dog3 = new Dogs("Coco", "Science Diet", "Pug");
            Dogs dog4 = new Dogs("Goku", "Nutro", "Great Dane");

            Volunteer vol1 = new Volunteer("James", 349056, "dogs");

            Manager mang1 = new Manager("Lisa", 983258, "dogs");

            Console.WriteLine(mang1.BasicEmpInfo());


            Console.WriteLine(dog1.PrintPetInfo());
            dog1.CheckLevels();

        }
    }
}
