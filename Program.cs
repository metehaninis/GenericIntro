using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> names = new MyList<string>();
            names.Add("Engin");

            MyDictionary<int, string> students = new MyDictionary<int, string>();
            students.Add(1, "Metehan");
            students.Add(2, "Selinay");
            
        }
    }
}
