using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.cafeteria_menu_app
{
    internal class CafeMenu
    {
        private string[] items = new string[10]
        { "Coffee","Pasta","Rajma Chawal","Burger" ,"Sandwich","Momos","Chocolate Strawberry","Juice","Muffin","Pizza" };
        private int[] price = new int[10]
            {40,100,80,45,35,45,60,50,25,199};

        public void Display()
        {
            Console.WriteLine("\n--- Cafeteria Menu ---");
            for (int i = 0; i < items.Length; i++)
            {
                Console.WriteLine(i + " : " + items[i] + " - Rs." + items[i]);
            }
        }
        public bool CheckAvailability(int idx)
        {
            if (idx >= 0 && idx < items.Length)
            {
                return true;
            }
            return false;
        }
        public string GetItemByIdx(int idx)
        {
            return items[idx];
        }
        public int getPrice(int idx)
        {
            return price[idx];
        }
    }
}