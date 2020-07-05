using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRose.Console.Classes.Item
{
    public interface IItem
    {
        void UpdateQuality(int daysToElapse);
    }
}
