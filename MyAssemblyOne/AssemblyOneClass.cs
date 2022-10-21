using System;
using System.Collections.Generic;
using System.Text;

namespace MyAssemblyOne
{
    public class AssemblyOneClass
    {
        protected internal int ID = 1010; 
    }
    public class MyTestClass
    {
        public void Example()
        {
            AssemblyOneClass A1 = new AssemblyOneClass();
            Console.WriteLine(A1.ID);
        }
    }
}
