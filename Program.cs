using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropExample
{
    class Program
    {
        static void Main(string[] args)
        {
            TestOver(3);
        }

        // 메서드 오버로딩
        public static int TestOver(int input) { return 0; }
        //public bool TestOver(int input) { return true;  }   // 동일한 매개변수 안됨
        public static bool TestOver(double input) { return true; }
    }
}
