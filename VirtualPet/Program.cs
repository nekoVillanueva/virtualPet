using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    class Program
    {

        static void Main()
        {

            string answer;
            Virtual_Pet pet = new Virtual_Pet();


            Console.WriteLine("Welcome to Jurassic Park");
            Console.WriteLine("What would you like to call your new dinosaur?");
            pet.GetName = Console.ReadLine().ToLower();

            Console.WriteLine(pet.GetName + " the dinosaur needs TLC so make sure you take care of him");
            while (pet.GetHealth > 0 && pet.GetThirst > 0 && pet.GetHunger > 0)
            {

                Console.WriteLine("{0} health is: {1}", pet.GetName, pet.GetHealth);
                Console.WriteLine("hunger: {0}", pet.GetHunger);
                Console.WriteLine("thirst:{0}", pet.GetThirst);
                Console.WriteLine("What would you like to do for your new dinosaur ,type feed to give pet food or drink to give pet water .");
                answer = Console.ReadLine().ToLower();
                pet.StatusChange(answer);




            }

            if (pet.GetHealth <= 0)
            {
                Console.WriteLine("{0} has been hit by an asteroid and has passed away", pet.GetName);
            }
            else if (pet.GetHunger <= 0)
            {
                Console.WriteLine("{0} has eaten you so may you R.I.P", pet.GetName);
            }
            else
            {
                Console.WriteLine("{0} has shriveled up from dehydration and decided to get his water from your blood", pet.GetName);
            }

            Console.WriteLine("Would you like to return to Jurassic Park? Enter yes if youd like to return or no to exit park.");
            answer = Console.ReadLine();
            if (answer == "yes")
            {
                Main();
            }
            else
            {
                return;

            }
        }
    }
}
//public void Menu()
//{
//    Console.WriteLine(pet.GetName+ " the dinosaur");
//    Console.WriteLine()

//}