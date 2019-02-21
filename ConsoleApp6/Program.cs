using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Test<T>
    {
        T myValue;

        public Test(T t)
        {
            myValue = t;
        }
        public void Write()
        {
            Console.WriteLine(myValue);
        }
        class Program
        {
            static void Main(string[] args)
            {
                //use the generic type Test with an int type parameter
                Test<int> test1 = new Test<int>(5);
                test1.Write();

                //use generic type Test with a string type parameter
                Test<string> test2 = new Test<string>("cat");
                test2.Write();
            }
        }
    }
}
