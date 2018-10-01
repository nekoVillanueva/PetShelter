using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    abstract class EmployeeBase
    {
        public string EmployeeName
        {
            get; set;
        }
        public string Position
        {
            get; set;
        }

        //methods
        abstract public void WalkDog();//method
        
        abstract public void PlayingPet();//method
        
            
        
    }
}
