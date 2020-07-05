using GildedRose.Console.Classes.Item;
using GildedRose.Console.Classes.Item.ItemTypes;
using System;
using System.Collections.Generic;

namespace GildedRose.Console
{
    class Program
    {
        IList<IItem> Items;
        static void Main(string[] args)
        {
            System.Console.WriteLine("OMGHAI!");

            var app = new Program()
                {
                    Items = new List<IItem>
                        {
                            new NormalItem( "+5 Dexterity Vest", 10, 20 ),
                            new FancyItem( "Aged Brie", 2, 0 ),
                            new NormalItem( "Elixir of the Mongoose", 5, 7 ),
                            new LegendaryItem( "Sulfuras, Hand of Ragnaros" ),
                            new ExclusiveItem( "Backstage passes to a TAFKAL80ETC concert", 15, 20 ),
                            new ConjuredItem( "Conjured Mana Cake", 3, 6 )
                        }

                };

            app.UpdateItems();

            System.Console.ReadKey();

        }

        public void UpdateItems()
        {
            foreach(IItem item in Items)
            {
                item.UpdateQuality(1);
            }
        }


    }


}
