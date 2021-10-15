using System;

namespace MidtermCMPS378
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Welcome message

            Console.WriteLine("Welcome to Rigby Restaurant\t");
            Console.WriteLine("---------------Food-------------- \t ");
            Console.WriteLine("Pizza $20 Chicken $15 Spaghetti $25 ");
            Console.WriteLine("---------------Drinks-------------- \t ");
            Console.WriteLine("Sprite $5 Coke $4 Mountain Dew $3 ");
            Console.WriteLine("---------------Dessert-------------- \t ");
            Console.WriteLine("Ice cream $10 Pie $12 Cinnamon roll $8 ");
            Console.WriteLine("Chose your food (P/C/S");
            char food = Convert.ToChar(Console.ReadLine());
            int foodtotal;
            if (food == 'p')
            {
                foodtotal = 20;
            }
            else if ( food == 'c')
            {
                foodtotal = 15;
            }
            else if ( food == 's')
            {
                foodtotal = 25;
            }
            Console.WriteLine("Choose your drink ");
            char drink = Convert.ToChar(Console.ReadLine());
            int drinktotal;
            if (drink == 's')
            {
                drinktotal = 5;
            }
            else if (drink == 'c')
            {
                drinktotal = 4;
            }
            else if (drink == 'm')
            {
                drinktotal = 3;
            }
            Console.WriteLine("Do you want deserts?1=Yes/ 2=No ");
            char dessert = Convert.ToChar(Console.ReadLine());
            if (dessert == '1')
            {
                Console.WriteLine("Choose your dessert");
                string dessert2 = Console.ReadLine();
            }
            else
            {
                Console.WriteLine("");
            }
            Console.WriteLine("Another order? 1=Yes/ 2=No");
            char order2 = Convert.ToChar(Console.ReadLine());
            if (order2 == '1')
            {
                Console.WriteLine("Welcome to Rigby Restaurant\t");
                Console.WriteLine("---------------Food-------------- \t ");
                Console.WriteLine("Pizza $20 Chicken $15 Spaghetti $25 ");
                Console.WriteLine("---------------Drinks-------------- \t ");
                Console.WriteLine("Sprite $5 Coke $4 Mountain Dew $3 ");
                Console.WriteLine("---------------Dessert-------------- \t ");
                Console.WriteLine("Ice cream $10 Pie $12 Cinnamon roll $8 ");
                Console.WriteLine("Chose your food (P/C/S");
                char food2 = Convert.ToChar(Console.ReadLine());
                int foodtotal2;
                if (food2 == 'p')
                {
                    foodtotal2 = 20;
                }
                else if (food2 == 'c')
                {
                    foodtotal2 = 15;
                }
                else if (food == 's')
                {
                    foodtotal2 = 25;
                }
                Console.WriteLine("Choose your drink ");
                char drink2 = Convert.ToChar(Console.ReadLine());
                int drinktotal2;
                if (drink2 == 's')
                {
                    drinktotal2 = 5;
                }
                else if (drink2 == 'c')
                {
                    drinktotal2 = 4;
                }
                else if (drink2 == 'm')
                {
                    drinktotal2 = 3;
                }
                Console.WriteLine("Do you want deserts?1=Yes/ 2=No ");
                char dessert2 = Convert.ToChar(Console.ReadLine());
                if (dessert == '1')
                {
                    Console.WriteLine("Choose your dessert");
                    string dessert3 = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("");
                }
            }
            else
            {
                Console.WriteLine("Your order was:" + food + "for" + drink + dessert );
            }

           
            Console.WriteLine("Yout total is" );
            Console.WriteLine("chose any number from 1-10");
            string fortune = Console.ReadLine();
            Console.WriteLine("Now your fortune cookie quote is");
            switch (fortune)
            {
                case "1":
                    Console.WriteLine("You will succeed ");
                    break;
                case "2":
                    Console.WriteLine("You will be rich");
                    break;
                case "3":
                    Console.WriteLine("You will be happy");
                    break;
                case "4":
                    Console.WriteLine("You will propser");
                    break;
                case "5":
                    Console.WriteLine("You will have bad luck");
                    break;
                case "6":
                    Console.WriteLine("You will be mad");
                    break;
                case "7":
                    Console.WriteLine("You are amazing");
                    break;
                case "8":
                    Console.WriteLine("You will not succeed");
                    break;
                case "9":
                    Console.WriteLine("You will not be rich");
                    break;
                default:
                    Console.WriteLine("You will suffer");
                    break;
            }
            Console.WriteLine("Thanks for dining with us");
        }
    }
}