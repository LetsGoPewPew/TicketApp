using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Payment
{
    public class Vips : IPayment
    {
        public bool PayForItem(string item, int price)
        {
            Console.WriteLine("Vips");
            return true;
        }
    }
}