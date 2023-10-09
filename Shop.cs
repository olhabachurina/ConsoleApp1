using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public enum ShopType
    {
        Grocery,
        Household,
        Clothing,
        Shoes
    }

    public class Shop : IDisposable
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public ShopType Type { get; set; }

        private bool disposed = false;

        public Shop(string name, string address, ShopType type)
        {
            Name = name;
            Address = address;
            Type = type;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Name of shop: {Name}");
            Console.WriteLine($"Store address: {Address}");
            Console.WriteLine($"Store type: {Type}");
        }

        public void PerformAction()
        {
            switch (Type)
            {
                case ShopType.Grocery:
                    Console.WriteLine($"Selling fresh products in a store {Name}");
                    break;
                case ShopType.Household:
                    Console.WriteLine($"Promotion on washing powders in the store {Name}");
                    break;
                case ShopType.Clothing:
                    Console.WriteLine($"New collection of clothes in the store {Name}");
                    break;
                case ShopType.Shoes:
                    Console.WriteLine($"Discount on summer shoe collection in store {Name}");
                    break;
                default:
                    Console.WriteLine($"Actions for the store {Name}");
                    break;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
            Console.WriteLine($"Disposer called for store {Name}");
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {

                    Console.WriteLine($"Managed Store Resources {Name} released");
                }

                Console.WriteLine($"Shop {Name} closed");

                disposed = true;
            }
        }
        /*
        ~Shop()
        {
            Dispose(false);
            Console.WriteLine($"Destructor called for store {Name}");
        }
    }*/
    }
}

