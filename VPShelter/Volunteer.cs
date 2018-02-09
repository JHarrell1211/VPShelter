using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    public class Volunteer : Employee
    {
        //fields
        public string volType;

        //Properties
        public string VolType
        {
            get { return this.volType; }
            //set { this.volType = value; }
        }

        //Constructors
        public Volunteer()
        {

        }

        public Volunteer(string empName, int empID, string volType)
        {
            EmpName = empName;
            EmpID = empID;
            EmpTitle = "Volunteer";
            this.volType = volType;
        }

        //Methods
        public override void FeedAllPets()
        {
            Console.WriteLine(EmpName + " has fed all the " + VolType);
        }

        public override void WaterAllPets()
        {
            Console.WriteLine(EmpName + " has given all the " + VolType + " water");
        }

        public override int PrintEmpID()
        {
            return EmpID;
        }

        public override string PrintEmpName()
        {
            return PrintEmpName();
        }

        public override string PrintEmpTitle()
        {
            return EmpTitle;
        }

        public override string BasicEmpInfo()
        {
            return EmpName + ", " + EmpID + ", " + EmpTitle + ", " + VolType;
        }

    }
}
