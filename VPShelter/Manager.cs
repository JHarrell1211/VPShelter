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

        public override void FeedAllPets()
        {
            Console.WriteLine(EmpName + " has fed the " + MangDept);
        }

        public override void WaterAllPets()
        {
            Console.WriteLine(EmpName + " has given all the " + MangDept + " water");
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
