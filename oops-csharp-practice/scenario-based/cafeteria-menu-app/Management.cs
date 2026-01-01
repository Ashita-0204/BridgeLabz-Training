using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Training.cafeteria_menu_app
{
    internal class Management
    {
        private int bill = 0;
        public void PlaceOrder(CafeMenu menu, int idx)
        {
            if (menu.CheckAvailability(idx))
            {
                string items = menu.GetItemByIdx(idx);
                int price = menu.getPrice(idx);
                bill += price;
                Console.WriteLine("\nOrder Placed Successfully!");
                Console.WriteLine("You ordered: " + items + "    Rs. " + price);
            }
            else
            {
                Console.WriteLine(" Invalid selection!! ");

            }

        }

        public void DisplayBill()
        {
            Console.WriteLine("Total Bill Amount: Rs" + bill);
            Console.WriteLine("Thank you for ordering!");
        }
    }
}
