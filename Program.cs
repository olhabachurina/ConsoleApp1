// See https://aka.ms/new-console-template for more information
using ConsoleApp1;

Console.WriteLine("Exercise 1,3");
    using Play play1 = new Play("Forest Song", "Lesya Ukrainka", "Drama", 1911);
{
    play1.DisplayInfo();
}
    /*play2 = null;
    GC.Collect();*/

using Play play2 = new Play("Host", "Ivan Karpenko-Karyy", "Сomedy", 1900);
{
    play2.DisplayInfo();
}
/*play2 = null;
GC.Collect();*/


Console.WriteLine("Exercise 2,3");
using (Shop groceryShop = new Shop("Vegetables fruits", "Panteleimonovskaya  street, 21", ShopType.Grocery))
{
    groceryShop.DisplayInfo();
    groceryShop.PerformAction();
}
using (Shop clothingShop = new Shop("Benetton", "Deribasovskaya street, 19", ShopType.Clothing))
{
    clothingShop.DisplayInfo();
    clothingShop.PerformAction();
}
using (Shop shoesShop = new Shop("Intertop", "Deribasovskaya street, 21", ShopType.Shoes))
{
    shoesShop.DisplayInfo();
    shoesShop.PerformAction();
}
using (Shop householdShop = new Shop("Eva", "Panteleimonovskaya  street, 21", ShopType.Household))
{
    householdShop.DisplayInfo();
    householdShop.PerformAction();
}


Console.ReadLine();
    





