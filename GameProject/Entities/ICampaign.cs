using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Entities
{
    interface ICampaign
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int DiscountRate { get; set; }
    }
}
