using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.cafeteria_menu_app
{
    internal class CafeApp
    {
        public static void Main()
        {
            CafeMenu app = new CafeMenu();
            Management order = new Management();
            char choice;
            do
            {
                app.Display();
                Console.Write("Enter item index to order: ");
                int option = int.Parse(Console.ReadLine());
                order.PlaceOrder(app, option);
                Console.Write("Do you want to order again? (y/n): ");
                choice = char.Parse(Console.ReadLine());
            }
            while (choice == 'y' || choice == 'Y');
            order.DisplayBill();

        }
    }
}
