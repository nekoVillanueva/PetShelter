using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    public static class VirtualPetShelter

    {
        static List<VpetBase> petHouse = new List<VpetBase>();
        static List<EmployeeBase> employeesHouse = new List<EmployeeBase>();

        static VirtualPetShelter()
        {
               //saving actual pet objects with info in list
            petHouse.Add(new Dog("lala", "retarded dog", 50, 30, 25,"garbage"));
            petHouse.Add(new Dog("Kodi", "dumb dog", 85, 90, 80,"plastic cups"));
            petHouse.Add(new Dog("Bud", "smart dog", 100, 100, 100,"footballs"));

            //saving employees and creating new objects in string 
            employeesHouse.Add(new Manager("BOB"));
            employeesHouse.Add(new Volunteer("BOBBY"));
        }

        public static List<VpetBase> GetPetValues()
        {
            return petHouse;
        }
       
        
    }
}
