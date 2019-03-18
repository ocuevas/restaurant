using System;
class Restaurant{

// Instentive variables 
    private int price;
    private int total;

 public Restaurant() {
      price = 0;
      total = 0;

  }
//Methods
    //Display Menu
    public void displayMenu(){
        // display menu with the price
    Console.Write("(1) Brown Stew Chicken - $5.89 \n"+
                "(2) Fried Chicken - $7.89 \n"+
                "(3) Jerk Chicken - $9.89 \n" +
                "(4) Curry Goat - $8.89 \n" +
                "(5) Steam Fish - $10.89 \n" 
     ); 
     Console.WriteLine();
     Console.WriteLine("Please make you selection");
     SelectIterm(Convert.ToChar(Console.ReadLine().ToUpper()));
}
        
    //Select the food 
    private void SelectIterm(char selection) {
       bool selectionOk = false;
       while(!selectionOk){
           switch(selection){
                case '1':
                    Console.WriteLine("Brown Stew Chicken was added");
                    selectionOk = true;
                    break;
                case '2':
                    Console.WriteLine("Fried Chicken was added");
                    selectionOk = true;
                    break; 
                case '3':
                    Console.WriteLine("Jerk Chicken was added");
                    selectionOk = true;
                    break;
                case '4':
                    Console.WriteLine("Curry Goat was added");
                    selectionOk = true;
                    break;
                case '5':
                    Console.WriteLine("Steam Fish was added");
                    selectionOk = true;
                    break;
                default:
                    Console.WriteLine("Invalied Selection. Please re-enter your selection: ");
                    selection = Convert.ToChar(Console.ReadLine().ToUpper());
                    selectionOk = false;
                    break;
            }
           
       }

    }
    //Pay
    // Return change
}


