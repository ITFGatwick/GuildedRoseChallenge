using System;
using System.Collections.Generic;
using MarkdownLog;

namespace GildedRose.Application
{
    public static class Program
    {
        public static IList<Item> Items;

        static void Main(string[] args)
        {
            Console.WriteLine("OMGHAI!");

            Shop.Items = new List<Item>
                {
                    new Item { Name = "Fresh Orange Juice", SellIn = 10, Quality = 20 },
                    new Item { Name = "Single Malt Whisky", SellIn = 2, Quality = 0 },
                    new Item { Name = "Leg of Lamb", SellIn = 5, Quality = 7 },
                    new Item { Name = "Gold", SellIn = 0, Quality = 80 },
                    new Item
                        {
                            Name = "VIP tickets to Glastonbury",
                            SellIn = 15,
                            Quality = 20
                        },
                    new Item { Name = "Apple Pie", SellIn = 3, Quality = 6 }
                };

            while (true)
            {
                Console.Clear();

                Shop.UpdateQuality();

                Console.WriteLine(Shop.Items.ToMarkdownTable());
                
                Console.ReadKey();
            }
        }
    }
}
