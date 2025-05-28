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

            // 생성자
            //Product p = new Product();  // 기본 생성자(기정생성자)는 정의한 생성자가 없을 경우, 자동 생성
            Product p = new Product("라떼", 3000);
        }

        // 메서드 오버로딩
        public static int TestOver(int input) { return 0; }
        //public bool TestOver(int input) { return true;  }   // 동일한 매개변수 안됨
        public static bool TestOver(double input) { return true; }
    }
}
