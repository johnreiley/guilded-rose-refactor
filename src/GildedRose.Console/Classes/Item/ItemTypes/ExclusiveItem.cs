using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRose.Console.Classes.Item.ItemTypes
{
    /// <summary>
    /// Exclusive items, like backstage passes, increases in Quality as it's SellIn 
    /// value approaches; Quality increases by 2 when there are 10 days or less
    /// and by 3 when there are 5 days or less but Quality drops to 0 after the
    /// concert.
    /// </summary>
    public class ExclusiveItem : BaseItem, IItem
    {
        public ExclusiveItem(string name, int sellIn, int quality) : base(sellIn, quality)
        {
            Name = name;
        }

        public void UpdateQuality(int daysToElapse)
        {
            for (int i = 0; i < daysToElapse; i++)
            {
                SetSellIn(SellIn - 1);

                if (SellIn == 0)
                {
                    SetQuality(0);
                }
                else if (SellIn <= 5)
                {
                    SetQuality(Quality + 3);
                }
                else if (SellIn <= 10)
                {
                    SetQuality(Quality + 2);
                }
                else
                {
                    SetQuality(Quality + QualityChangeRate);
                }
            }
        }
    }
}
