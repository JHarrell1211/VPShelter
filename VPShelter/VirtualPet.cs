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
        //private int tiredness;
        //private int waste;
        private int interact;

        Random r = new Random();

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
        // Not being used in this program
        //public int Tiredness
        //{
        //    get { return this.tiredness; }
        //    set { this.tiredness = value; }
        //}

        //public int Waste
        //{
        //    get { return this.waste; }
        //    set { this.waste = value; }
        //}

        public int Interact
        {
            get { return this.interact; }
            set { this.interact = value; }
        }

        //Constructors
        public VirtualPet()
        {
         
            hunger = r.Next(2, 8);
            thirst = r.Next(2, 8);
            //tiredness = r.Next(2, 8);
            //waste = r.Next(2, 8);
            interact = r.Next(2, 8);
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

        public int HungerLevel()
        {
            Random r = new Random();
            hunger = 0;
            hunger = r.Next(2,8);
            return hunger;
        }

        public virtual string PrintPetInfo()
        {
            return petName + ", " + petType + ", " + petDiet;
        }
  
        public virtual void CheckLevels()
        {
            Console.WriteLine(PetName);
            Console.Write("Hunger: " + hunger);
            Console.Write("  Thirst: " + thirst);
            //Console.Write("  Tiredness: " + tiredness);
            //Console.Write("  Waste: " + waste);
            Console.WriteLine("  Interact: " + interact + " \n");
        }

        public void Tick()
        {
            int i;
            Random r = new Random();
            int[] rNum = new int[3];


            for (i = 0; i < 3; i++)
            {
                int j = r.Next(-1, 3);
                rNum[i] = j;
            }
            hunger += rNum[0];
            thirst += rNum[1];
            //tiredness += rNum[2];
            //waste += rNum[3];
            interact += rNum[2];
        }

    }


}
