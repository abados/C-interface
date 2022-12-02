using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheInterface
{
    public interface IItem
    {
        public int getPrice()
        {
            Random random = new Random();

            return random.Next();
        }
    }

    public class Cola : IItem
    {
        public int getPrice() { return 10; }
    }

    public class Kinly : IItem
    {
        public int getPrice() { return 11; }
    }
}
