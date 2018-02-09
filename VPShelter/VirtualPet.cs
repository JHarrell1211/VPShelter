using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    public abstract class VirtualPet
    {
        //Fields
        private string petName;
        private string petType;
        private string petDiet;

        private int hunger;
        private int thirst;
        private int tiredness;
        private int waste;
        private int interact;

        //Properties
        public string PetName
        {
            get { return this.petName; }
            set { this.petName = value; }
        }

        public string PetType
        {
            get { return this.petType; }
            set { this.petType = value; }
        }

        public string PetDiet
        {
            get { return this.petDiet; }
            set { this.petDiet = value; }
        }

        public int Hunger
        {
            get { return this.hunger; }
            set { this.hunger = value; }
        }

        public int Thirst
        {
            get { return this.thirst; }
            set { this.thirst = value; }
        }

        public int Tiredness
        {
            get { return this.tiredness; }
            set { this.tiredness = value; }
        }

        public int Waste
        {
            get { return this.waste; }
            set { this.waste = value; }
        }

        public int Interact
        {
            get { return this.interact; }
            set { this.interact = value; }
        }

        //Constructors
        public VirtualPet()
        {
            int i;
            Random r = new Random();
            int[] rNum = new int[5];


            for (i = 0; i < 5; i++)
            {
                int j = r.Next(2, 8);
                rNum[i] = j;
            }
            hunger = rNum[0];
            thirst = rNum[1];
            tiredness = rNum[2];
            waste = rNum[3];
            interact = rNum[4];
        }

        public VirtualPet(string petName, string petType)
        {
            this.petName = petName;
            this.petType = petType;
        }
    

        //Methods
        public abstract string PrintName();

        public abstract string PrintPetType();

        public abstract string PrintPetDiet();


        public virtual string PrintPetInfo()
        {
            return petName + ", " + petType + ", " + petDiet;
        }

        public virtual void CheckLevels()
        {
            Console.WriteLine("Hunger: " + this.hunger);
            Console.WriteLine("Thirst: " + this.thirst);
            Console.WriteLine("Tiredness: " + this.tiredness);
            Console.WriteLine("Waste: " + this.waste);
            Console.WriteLine("Interact: " + this.interact);
        }

    }


}
