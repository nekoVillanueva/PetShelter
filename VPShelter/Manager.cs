using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    class Manager : EmployeeBase
    {
        public Manager()
        {
        }
        public Manager(string name)
        {
            EmployeeName = name;
            Position = "manager";
        }
        public override void PlayingPet()
        {
            Console.WriteLine("played with pet");
        }
        
        public void AdoptPet()
        {
            List<VpetBase> pets = VirtualPetShelter.GetPetValues();
            Console.WriteLine("What pet is being adopted");
            int adopted = -1;
            bool condition= true;
            
            for (int i = 0; i < pets.Count; i++)
            {
                Console.WriteLine("insert {2} for: Pet Name: {0} Pet Description: {1} ", pets[i].GetPetName, pets[i].GetPetDescription, i+1);
            }
            while(condition)
            {
                adopted = int.Parse(Console.ReadLine());
                if (adopted >0 && adopted < 4)
                {
                    condition = false;
                }
                else
                {
                    Console.WriteLine("Please select a dog.");
                }
            }
            Console.WriteLine("Thanks for adopting {0}", pets[adopted-1].GetPetName);
            
        }

        public override void WalkDog()
        {
            Console.WriteLine("Walk dogg");
        }
    }
}
