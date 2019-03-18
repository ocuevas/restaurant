using System;
class Restaurant{

// Instentive variables 
    private double price;
    private double cost;
    private double balance;
    private static int payment = 0;

 public Restaurant() {
      price = 0;
      cost = 0;
  }
public void Payment(double initialAmount) {
    balance = initialAmount;
  }
public Restaurant(int p, int t) {
      price = p;
      cost = t;

  }
    //Display Menu
    public void displayMenu(){
        // display menu with the price
        String menu ="###############################\n"+
                "----Menu----\n"+
                "(A) Brown Stew Chicken           $5.89 \n"+
                "(B) Fried Chicken                $7.89 \n"+
                "(C) Jerk Chicken                 $9.89 \n" +
                "(D) Curry Goat                   $8.89 \n" +
                "(E) Steam Fish                   $10.89 \n"+
                "###############################\n"
                ; 
                
     Console.WriteLine(menu);
     Console.WriteLine("Please make you selection: ");
     SelectIterm(Convert.ToChar(Console.ReadLine().ToUpper()));
}

    //Select the food 
    private void SelectIterm(char selection) {
       bool selectionOk = false;
       while(!selectionOk){
           switch(selection){
                case 'A':
                    Console.WriteLine("Brown Stew Chicken was added");
                    price = 5.89;
                    cost =+ price;
                    Payment(cost);
                    Console.WriteLine("${0}", cost);
                    selectionOk = true;
                    break;
                case 'B':
                    Console.WriteLine("Fried Chicken was added");
                    price = 7.89;
                    cost =+ price;
                    Console.WriteLine("${0}", cost);
                    selectionOk = true;
                    break; 
                case 'C':
                    Console.WriteLine("Jerk Chicken was added");
                    price = 9.89;
                    cost =+ price;
                    Console.WriteLine("${0}", cost);
                    selectionOk = true;
                    break;
                case 'D':
                    Console.WriteLine("Curry Goat was added");
                    price = 8.89;
                    cost =+ price;
                    Console.WriteLine("${0}", cost);
                    selectionOk = true;
                    break;
                case 'E':
                    Console.WriteLine("Steam Fish was added");
                    price = 10.89;
                    cost =+ price;
                    Console.WriteLine("${0}", cost);
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

   public double getTotal(){
       payment++;
       return cost;
   }
    //Pay
    // Return change
}


