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
            //set { this.dogType = value; }
        }

        //Constructors
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
            return PetDiet;
        }
        public override void CheckLevels()
        {
            base.CheckLevels();
        }
    }
}
