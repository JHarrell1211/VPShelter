using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    public class Manager : Employee
    {
        //Fields
        private string mangDept;

        //Properties
        public string MangDept
        {
            get { return this.mangDept; }
            //set { this.mangDept = value; }
        }

        //Constructors
        public Manager()
        {

        }

        public Manager(string empName, int empID, string mangDept)
        {
            EmpName = empName;
            EmpID = empID;
            this.mangDept = mangDept;
            EmpTitle = "Manager";
        }

        //Methods
        public void AdoptPet()
        {

        }

        public override void FeedAllPets()
        {
            Console.WriteLine(EmpName + " has fed the " + MangDept);
        }

        public override string PrintEmpName()
        {
            return base.PrintEmpName();
        }

        public override int PrintEmpID()
        {
            return EmpID;
        }

        public override string PrintEmpTitle()
        {
            return EmpTitle;
        }

        public override string BasicEmpInfo()
        {
            return EmpName + ", " + EmpID + ", " + EmpTitle + ", " + mangDept;
        }
    }
}
