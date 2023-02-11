using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    public class ProductItem
    {
        public ProductItem()
        {
            IsActive = true;
            IsPublic = true;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public bool IsPublic { get; set; }
        public int Price { get; set; }
        public string Brand { get; set; }
    }
}
