using System;

namespace project21
{
    class Program
    {
        static void Main(string[] args) {
            int showMenu; 
            string[] workers = {"Luis", "Pedro", "Chris", "Perla"};

            Random r = new Random();
            Restaurant restaurant = new Restaurant();
            Console.WriteLine("**********************");
            Console.WriteLine("Welcome G Press!");
            Console.WriteLine("Hello! My name is  {0}, and going to take your order today", workers[r.Next(0,4)]);
            Console.Write("Press 1 to show the menu ");
            showMenu = int.Parse(Console.ReadLine());

            if(showMenu != 1) {
                Console.Write("Press 1 to show the menu ");
            }else {
                restaurant.displayMenu();
                Console.WriteLine();
            }
            

            
            
            

 // loop until you finished orden

        }
       
    }
}
