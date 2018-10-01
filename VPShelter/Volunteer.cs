using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    class Volunteer : EmployeeBase
    {
        public Volunteer()
        {
        }
        public Volunteer(string name)
        {
            EmployeeName = name;
            Position = "volunteer";
        }
        //property prop
        //{get;set;}
        public override void WalkDog()
        {
            throw new NotImplementedException();
        }

        public override void PlayingPet()
        {
            throw new NotImplementedException();
        }
        public void feed()//method
        {
            //feed all pets 
            Console.WriteLine("Pets fed");
        }
        public void water()//method
        {
            //water all pets
            Console.WriteLine("Pets watered");
        }
    }
}
