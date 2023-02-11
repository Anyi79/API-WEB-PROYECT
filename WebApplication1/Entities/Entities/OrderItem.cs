using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    public class OrderItem
    {
        public OrderItem()
        {
            IsActive = true;
            IsPublic = true;
        }
        public int Id { get; set; }
        public int IdCustomer { get; set; }
        public int IdProduct { get; set; }
        public string Name { get; set; }
        public DateTime InsertDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public bool IsActive { get; set; }
        public bool IsPublic { get; set; }
        public int Price { get; set; }
        public int Stock { get; set; }
        public string Brand { get; set; }
        public string Adress { get; set; }
    }
}
