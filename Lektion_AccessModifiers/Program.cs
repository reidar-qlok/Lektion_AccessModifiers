using System;

namespace Lektion_AccessModifiers
{
    public class Student
    {
        internal int _id;
        public int ID { get { return _id; } set { _id = value; } }
    }
    public class Student1 : Student
    {
        public void PrinId()
        {
            Student1 s1 = new Student1();
            Console.WriteLine(s1._id);
            base._id = 1020;
            this._id = 1030;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student S1 = new Student();
            S1.ID = 1010;
        }
    }
}
