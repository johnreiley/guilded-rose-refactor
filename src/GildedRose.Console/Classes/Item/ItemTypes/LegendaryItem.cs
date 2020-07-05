using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRose.Console.Classes.Item.ItemTypes
{
    /// <summary>
    /// Legendary items don't decrease in Quality which is always 80
    /// </summary>
    public class LegendaryItem : BaseItem, IItem
    {
        public LegendaryItem(string name)
        {
            QualityMax = 80;
            Name = name;
            SellIn = 0;
            Quality = 80;
        }

        public void UpdateQuality(int daysToElapse) { }
    }
}
