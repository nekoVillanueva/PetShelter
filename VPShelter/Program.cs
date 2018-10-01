using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    class Program
    {
        static void Main()
        {
            bool condition = true;
            int input = 0;
            var manager = new Manager();
            var employee = new Volunteer();
            while (condition == true)
            {
                Console.WriteLine("Welcome to Big Nekos Pet Extravaganza. What type of worker are you?");
                Console.WriteLine("Type 1 for manager");
                Console.WriteLine("Type 2 for volunteer");
                input = int.Parse(Console.ReadLine());
                if (input == 1 || input == 2)
                {
                    condition = false;
                }
                else
                {
                    Console.WriteLine("Please enter valid input");

                }
            }    

            foreach(VpetBase pet in VirtualPetShelter.GetPetValues())
            {
                Console.WriteLine("Pet Name: {0} Pet Description: {1} ... ", pet.GetPetName, pet.GetPetDescription);
            }

            if (input == 1)
            {
                while (!condition)//while condition stays false run loop
                {
                    Console.WriteLine();
                    Console.WriteLine("What would you like to do next?");
                    Console.WriteLine("Type 1 to adopt a pet");
                    Console.WriteLine("Type 2 to walk the pets");
                    Console.WriteLine("Type 3 to play with pets");
                    Console.WriteLine("Type 4 to quit");
                    
                    input = int.Parse(Console.ReadLine());
                    if (input > 0 && input < 5)
                    {
                        switch (input)
                        {
                            case 1:
                                manager.AdoptPet();
                                break;
                            case 2:
                                manager.WalkDog();
                                break;
                            case 3:
                                manager.PlayingPet();
                                break;
                            case 4:
                                condition = !condition;
                                break;
                        }

                    }
                    else
                    {
                        Console.WriteLine("please insert a valid number");
                    }
                }
            }

            else
            {
                while (!condition)//while condition stays false run loop
                {
                    Console.WriteLine();
                    Console.WriteLine("What would you like to do next?");
                    Console.WriteLine("Type 1 to feed the pets");
                    Console.WriteLine("Type 2 to water the pets");
                    Console.WriteLine("Type 3 to play with pets");
                    Console.WriteLine("Type 4 to walk the pets");
                    Console.WriteLine("Type 5 to quit");
                    input = int.Parse(Console.ReadLine());
                    if (input > 0 && input < 6)
                    {
                        switch (input)
                        {
                            case 1:
                                employee.feed();
                                break;
                            case 2:
                                employee.water();
                                break;
                            case 3:
                                employee.PlayingPet();
                                break;
                            case 4:
                                employee.WalkDog();
                                break;
                            case 5:
                                condition = !condition;
                                break;

                        }

                    }
                    else
                    {
                        Console.WriteLine("please insert a valid number");
                    }
                    
                }
                

            }
            while (condition)
            {
                Console.WriteLine("Do you want to come back to work tommorow? Y or N");
                string finalAnswer = Console.ReadLine().ToUpper();
                if (finalAnswer == "Y")
                {
                    Main();
                }
                else if (finalAnswer == "N")
                {

                    return;
                }
                else
                {
                    Console.WriteLine("Please learn the alphabet before continuing your education");
                }

            }
            
        }
    }
}
