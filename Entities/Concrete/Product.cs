using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    //Public yapıldığı zaman bu class'a diğer katmanlar da ulaşabilecek
    public class Product : IEntity
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }

        public string ProductName { get; set; }
        public short UnitsInStock { get; set; }
        public decimal UnitPrice { get; set; }


    }
}
