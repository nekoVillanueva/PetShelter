using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    public class VpetBase
    {
        public string GetPetName
        {
            get;set;
        }
        public string GetPetDescription
        {
            get;set;
        }
        public int GetPetHealth
        {
            get;set;
        }
        public int GetHunger
        {
            get;set;
        }
        public int GetThirst
        {
            get;set;
        }
        public VpetBase()
        {

        }
        public VpetBase(string name, string description,int health,int hunger,int thirst)
        {
            this.GetPetName = name;
            this.GetPetDescription = description;
            this.GetPetHealth = health;
            this.GetHunger = hunger;
            this.GetThirst = thirst;
        }
        public VpetBase(string name, string description)
        {
            this.GetPetName = name;
            this.GetPetDescription= description;
            
        }
       


    }

   
    
}
