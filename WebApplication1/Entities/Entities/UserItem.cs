using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    public class UserItem
    {
        public UserItem()
        {
            IsActive = true;
        }
        public int Id { get; set; }
        public int IdRol { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Adress { get; set; }  
        public bool IsActive { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
    }
}
