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
            Console.WriteLine("Welcome to Caribbean Taste!");
            Console.WriteLine("Hello! My name is  {0}, and going to take your order today.", workers[r.Next(0,4)]);
            Console.Write("Please press 1 to show menu: ");
            showMenu = int.Parse(Console.ReadLine());
            
           int n = 0;
           while (showMenu != 1) {
               n++;
               Console.Write("Please press 1 to show menu: ");
               showMenu = int.Parse(Console.ReadLine());
           }

           restaurant.displayMenu();
           Console.WriteLine();

           Console.Write("Press (end) to stop ording or press any key to continue: ");
           String f = Console.ReadLine();

           while(f != "end"){
                restaurant.displayMenu();
                Console.WriteLine(); 
                Console.Write("Press (end) to stop ording or press any key to continue: ");
                Console.WriteLine();
            
            }
          

           //Console.Write("Pay your order: ");
           //double money = double.Parse(Console.ReadLine());

           restaurant.getTotal();
           Console.WriteLine();     
           
                

            
            /*
              TODO

              #add the price to the total
              # loop until the person finish buying
              # Insert the money to pay
            
                1.  Method
                2.  Variable
                Class
                3.  Method
                4.  Variable

                5.  Overloaded method

                6.  String
                7.  String method
                8.  Composition
                9.  Random number
                10. Array
                            
            
             */
            

            
            
            

 // loop until you finished orden

        }
       
    }
}
