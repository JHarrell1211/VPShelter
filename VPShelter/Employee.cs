using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    public abstract class Employee
    {
        //Fields
        private string empName;
        private int empID;
        private string empTitle;

        //Properties
        public string EmpName
        {
            get { return this.empName; }
            set { this.empName = value; }
        }

        public int EmpID
        {
            get { return this.empID; }
            set { this.empID = value; }
        }

        public string EmpTitle
        {
            get { return this.empTitle; }
            set { this.empTitle = value; }
        }

        //Constructors
        //public Employee(string empName, int empID, string empTitle)
        //{

        //}

        //Methods
        public virtual string PrintEmpTitle()
        {
            return EmpTitle;
        }

        public virtual int PrintEmpID()
        {
            return EmpID;
        }

        public virtual string PrintEmpName()
        {
            return EmpName;
        }

        public abstract string BasicEmpInfo();

        public abstract void FeedAllPets();

        public abstract void WaterAllPets();

    }
}
