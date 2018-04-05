using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinifde2
{
    interface IPay
    {
        void Pay();
    }



    class AzerCell : IPay
    {
        public string number;

        public AzerCell(string a)
        {
            number = a;
        }

        public void Pay()
        {
            Console.WriteLine("AzerCell Pay");
        }
    }

    class BakCell : IPay
    {
        public string number;

        public BakCell(string a)
        {
            number = a;
        }
        
        public void Pay()
        {
            Console.WriteLine("BakCell Pay");
        }
    }

    class Nar : IPay
    {
        public string number;

        public Nar(string a)
        {
            number = a;
        }

        public void Pay()
        {
            Console.WriteLine("Nar Pay");
        }
    }

    class CIB
    {
        IPay gg;

        public CIB(IPay a)//Ipay a=new Azer();
        {
            gg = a;
        }

        public void Increase()
        {
            gg.Pay();
        }
    }

}
