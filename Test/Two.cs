using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class MyBase
    {
        public virtual string Meth1()
        {
            return "MyBase-Meth1";
        }
        public virtual string Meth2()
        {
            return "MyBase-Meth2";
        }
        public virtual string Meth3()
        {
            return "MyBase-Meth3";
        }
    }

    class MyDerived : MyBase
    {
        public override string Meth1()
        {
            return "MyDerived-Meth1";
        }
        public new string Meth2()
        {
            return "MyDerived-Meth2";
        }
        public string Meth3()
        {
            return "MyDerived-Meth3";
        }

        /*public static void Main()
        {
            MyDerived mD = new MyDerived();
            MyBase mB = (MyBase)mD;

            Console.WriteLine(mB.Meth1());
            Console.WriteLine(mB.Meth2());
            Console.WriteLine(mB.Meth3());

            Console.ReadLine();
        }*/
    }
}
