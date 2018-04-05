using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct
{
    struct A
    {
        public DateTime x;
    }

    class Program
    {
        static void Main(string[] args)
        {
             
            A a=new A();
            Console.WriteLine(a.x);

            Int32 a = new Int32();
        }
    }
}
