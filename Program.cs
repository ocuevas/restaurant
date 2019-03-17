using System;

namespace project21
{
    class Program
    {
        static void Main(string[] args) {

            string[] workers = {"Luis", "Pedro", "Chris", "Perla"};
            Random r = new Random();

            Console.WriteLine("**********************");
            Console.WriteLine("Welcome to La Familia Restaurante");
            Console.WriteLine("Hello! My name is  {0}, and going to take your order today", workers[r.Next(0,5)]);


 // loop until you finished orden

        }
       
    }
}
