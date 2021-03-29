using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    class Product    //entity varlık bölümü burasıdır.
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public double UnitPrice { get; set; }
        public int UnitInStock { get; set; }
    }
}
