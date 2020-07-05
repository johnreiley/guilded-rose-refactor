using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRose.Console.Classes.Item.ItemTypes
{
    public class ConjuredItem : BaseItem, IItem
    {
        /// <summary>
        /// Conjured items depreciate in value twice as much as normal items
        /// </summary>
        public ConjuredItem(string name, int sellIn, int quality) : base(sellIn, quality)
        {
            Name = name;
        }

        public void UpdateQuality(int daysToElapse)
        {
            SetSellIn(SellIn - daysToElapse);

            for (int i = 0; i < daysToElapse; i++)
            {
                SetQuality(Quality - (QualityChangeRate * 2));
            }
        }
    }
}
