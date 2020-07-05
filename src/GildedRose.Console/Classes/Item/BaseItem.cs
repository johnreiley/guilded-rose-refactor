using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRose.Console.Classes.Item
{
    public abstract class BaseItem : Item
    {
        protected int QualityMax = 50;
        protected int QualityChangeRate = 1;

        protected BaseItem() { }
        protected BaseItem(int sellIn, int quality)
        {
            if (sellIn < 0)
            {
                throw new Exception("Sellin must be 0 or greater!");
            }
            SellIn = sellIn;

            if (quality < 0 || quality > QualityMax)
            {
                throw new Exception($"Quality cannot be less than 0 or greater than { QualityMax }!");
            }
            Quality = quality;
        }

        protected void SetSellIn(int sellIn)
        {
            if (sellIn < 0)
            {
                SellIn = 0;
            }
            else
            {
                SellIn = sellIn;
            }
        }
        protected void SetQuality(int quality)
        {
            if (quality < 0)
            {
                Quality = 0;
            }
            else if (quality > QualityMax)
            {
                Quality = QualityMax;
            }
            else
            {
                Quality = quality;
            }
        }
    }
}
