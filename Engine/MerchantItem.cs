using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class MerchantItem
    {
        public int Value { set; get; }
        public Item Details { set; get; }
        public string Name { set; get; }

        public MerchantItem (Item details, int value, string name)
        {
            Details = details;
            Name = name;
            Value = value;
        }
    }
}
