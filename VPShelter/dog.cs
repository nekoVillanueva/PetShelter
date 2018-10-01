using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    public class Dog : VpetBase
    {
        public string GetDiet
        {
            get; set;
        }
        public string GetPetType
        {
            get;
        }
        public Dog(string name, string description, int health, int hunger, int thirst, string diet)
        {
            this.GetPetName = name;
            this.GetPetDescription = description;
            this.GetPetHealth = health;
            this.GetHunger = hunger;
            this.GetThirst = thirst;
            this.GetDiet = diet;
            this.GetPetType = "Dog";
        }
    }
}
