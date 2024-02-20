using Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Model:Entity // Model: Araba modeli anlaminda
    {
        public int BrandId { get; set; }
        public string Name { get; set; }
        public decimal DailyPrice { get; set; }
        public string ImageUrl { get; set; }
        public virtual Brand? Brand { get; set; } // modelin bir markasi vardir
        public Model()
        {
            
        }

        public Model(int id, int brandId, string name, decimal dailyPrice, string imageUrl)
        {
            Id = id;
            BrandId = brandId;
            Name = name;
            DailyPrice = dailyPrice;
            ImageUrl = imageUrl;
        }
    }
}
