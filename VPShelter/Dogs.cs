using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    public class Dogs : VirtualPet
    {
        //field
        private string dogType;
        

        //properties
        public string DogType
        {
            get { return this.dogType; }
            set { this.dogType = value; }
        }

        //Constructors
        public Dogs(string petName, string dogType)
        {
            PetName = petName;
            this.dogType = dogType;
        }

        public Dogs(string petName, string petDiet, string dogType) : base()
        {
            this.PetName = petName;
            this.PetType = "dog";
            this.PetDiet = petDiet;
            this.dogType = dogType;
        }

        //Methods
        public override string PrintPetInfo()
        {
            return base.PrintPetInfo() + ", " + DogType;
        }

        public override string PrintName()
        {
            return PetName;
        }

        public override string PrintPetType()
        {
            return PetType;
        }

        public override string PrintPetDiet()
        {
            return PetName + " eats " + PetDiet;
        }

        public override string Adopted()
        {
            return base.Adopted();
        }
        public override string CheckLevels()
        {
           return  base.CheckLevels();
        }

        public void Eat()
        {
            if (Hunger >= 3)
            {
                Hunger -= 2;
                //Tiredness += 1;
                //Waste += 2;
                Thirst += 2;
                Console.WriteLine("You fed " + PetName);
            }
            else
            {
                Console.WriteLine(PetName + " is not hungry");
            }
        }

        public void DrinkUp()
        {
            if (Thirst >= 2)
            {
                Thirst -= 2;
                //Waste += 1;
                Console.WriteLine("You gave water to " + PetName);
            }
            else
            {
                Console.WriteLine(PetName + " is not thirsty");
            }
        }

        //public void IsTired()
        //{
        //    if (Tiredness >= 5)
        //    {
        //        Tiredness -= 5;
        //        Hunger += 2;
        //        Waste += 1;
        //        Interact += 1;
        //        Console.WriteLine(PetName + " sleeps for 6 hours");
        //    }
        //    else
        //    {
        //        Console.WriteLine(PetName + " is not tired");
        //    }

        //}

        //public void Potty()
        //{
        //    if (Waste >= 3)
        //    {
        //        Waste -= 3;
        //        Interact += 2;
        //        Console.WriteLine(PetName + " thanks you");
        //    }
        //    else
        //    {
        //        Console.WriteLine(PetName + "ignores you, he must not have to go");
        //    }
        //}

        public void Play()
        {
            if (Interact >= 3)
            {
                Interact -= 3;
                //Tiredness += 3;
                Hunger += 2;
                Thirst += 2;
                //Waste += 1;
                Console.WriteLine("You played with " + PetName);
            }
            else
            {
                Console.WriteLine(PetName + " doesn't want to play");
            }
        }
    }
}
