using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    public class RolItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Acceso { get; set; }
        public bool IsActive { get; set; }

    }
}
