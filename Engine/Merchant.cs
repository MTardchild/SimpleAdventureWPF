using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Merchant
    {
        public int ID { set; get; }
        public string Name { set; get; }
        public string Description { set; get; }
        public List<MerchantItem> MerchTable { set; get; }

        public Merchant (int id, string name, string description) 
        {
            ID = id;
            Name = name;
            Description = description;
            MerchTable = new List<MerchantItem>();
        }
    }
}
