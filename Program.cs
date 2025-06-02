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
            //Product p = new Product("라떼", 3000);

            // 팩토리 메서드 패턴 : private 생성자 사용
            Product p = Product.getInstance("커피", 2500);

            // 정적 생성자
            Console.WriteLine("첫 번째 위치");
            Console.WriteLine(Sample.value);        // Sample.value 값 조회 전에 생성자 호출
            Console.WriteLine("두번째 위치");
            Sample sample = new Sample();
            Console.WriteLine("세번째 위치");

            // 정적 생성자 패턴 2
            Console.WriteLine("첫 번째 위치");
            Sample sample2 = new Sample();
            Console.WriteLine("두번째 위치");
            Console.WriteLine(Sample.value);        // Sample 객체 생성 전, 레퍼런스 변수 생성 전에 정적 생성자 호출
            Console.WriteLine("세번째 위치");
        }

        // 메서드 오버로딩
        public static int TestOver(int input) { return 0; }
        //public bool TestOver(int input) { return true;  }   // 동일한 매개변수 안됨
        public static bool TestOver(double input) { return true; }
    }
}
