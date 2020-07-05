using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRose.Console.Classes.Item.ItemTypes
{
    /// <summary>
    /// Fancy items, like aged brie, increase in Quality over time
    /// </summary>
    public class FancyItem : BaseItem, IItem
    {
        public FancyItem(string name, int sellIn, int quality) : base(sellIn, quality)
        {
            Name = name;
        }

        public void UpdateQuality(int daysToElapse)
        {
            SetSellIn(SellIn - daysToElapse);

            for (int i = 0; i < daysToElapse; i++)
            {
                if (Quality < 50)
                {
                    SetQuality(Quality + 1);
                }
            }
        }
    }
}
