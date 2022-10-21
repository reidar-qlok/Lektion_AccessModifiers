using System;
using System.Collections.Generic;
using System.Text;
using MyAssemblyOne;

namespace MyAssemblyTwo
{
    class AssemblyTwoClass : AssemblyOneClass
    {
        public void Example2()
        {
            AssemblyTwoClass A1 = new AssemblyTwoClass();
            Console.WriteLine(this.ID);
            Console.WriteLine(A1.ID);
        }
    }
}
