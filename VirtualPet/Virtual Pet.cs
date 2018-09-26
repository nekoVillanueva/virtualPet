using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    class Virtual_Pet
    {
        //fields
        private string name;
        private int health=100;
        private int hunger=10;
        private int thirst=10;

        //Properties
        public string GetName
        {

            get { return this.name; }
            set { this.name = value; }
        }
        public int GetHealth
        {
            get { return this.health; }
            set { this.health = value; }
        }
        public int GetHunger
        {
            get { return this.hunger; }
            set { this.hunger = value; }
        }
        public int GetThirst
        {
            get { return this.thirst; }
            set { this.thirst = value; }
        }

        //Constructors
        public Virtual_Pet()
        {

        }
        public Virtual_Pet(int health,int hunger,int thirst)
        {
            this.GetHealth = health;
            this.GetHunger = hunger;
            this.GetThirst = thirst;
        }

        //Methods
        public void HealthChange()
        {
            if ((GetHunger<=6)&&(GetThirst<=6))
            {
                GetHealth = GetHealth - 10;
            }
        }
        public void StatusChange(string answer)
        {
            if(answer=="feed")
            {
                HungerChange();
                Tic();
            }
            else if(answer=="drink")
            {
                ThirstChange();
                Tic();
            }
            else
            {
                Console.WriteLine("Please choose valid entry before your dinosaur consumes you");

            }
        }
        public void HungerChange()
        {
            GetHunger = GetHunger + 2;
        }
        public void ThirstChange()
        {
            GetThirst = GetThirst + 4;
        }
        public void Vet()
        {
            GetHealth = 100;
            Console.WriteLine("{0} health has been restored to 100 but your vet bills were not cheap", GetName);

        }
        public void Tic()
        {
            GetHealth = GetHealth - 20;
            GetHunger = GetHunger - 2;
            GetThirst = GetThirst - 2;
            HealthChange();
            if (GetHealth <= 40)
            {
                
                Console.WriteLine("Your dinosaur is looking sickly would you like go to the vet?");
                string input = Console.ReadLine().ToLower();
                if (input == "yes")
                {
                    Vet();
                }
                else if (GetHealth <= 20)

                {
                    Console.WriteLine("Your dinosaur is having dreams of asteroids and coughing up blood.He isnt going to make  it.");
                    
                    return;
                }
                else
                {

                }
            }
        }
    }
}
