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

            // const vs readonly
            Item item1 = new Item("고구마", 1500);
            Item item2 = new Item("감자", 1000);
            Item item3 = new Item("옥수수", 2000);
            Console.WriteLine(item1.id);
            //Item1.id;
            Console.WriteLine(item2.id);

            Console.WriteLine(Item.ApplicationName);

            Box box = new Box(100, 100);
            //Console.WriteLine(box.getHeight());
            //box.setWidth(200);

            // 속성 사용
            Console.WriteLine(box.Height);
            box.Height = 200;

            Console.WriteLine(box.Area);

            // 값 복사 vs 참조 복사
            // 값 복사(value) : 값이 매개변수로 넘어가서 원본에 영향 X
            int a = 10;
            Change(a);
            Console.WriteLine(a);

            // 참조 복사(reference) : 객체의 레퍼런스(주소값)가 넘어가서 원본에 영향 O
            Test test = new Test();
            Change(test);
            Console.WriteLine(test.value);

            Test testA = new Test();
            Test testB = testA;     // 같은 레퍼런스를 가리킴
            testA.value = 10;
            testB.value = 20;
            Console.WriteLine("testA: " + testA);

            // 재귀함수를 이용한 피보나치 수 구하기
            Console.WriteLine(Fibonacci.Get(1));
            Console.WriteLine(Fibonacci.Get(5));
            Console.WriteLine(Fibonacci.Get(10));
            Console.WriteLine(Fibonacci.GetM()30);
        }
        static void Change(int input)
        {
            input = 20;
        }
        static void Change(Test input)
        {
            input.value = 20;
        }

        class Test
        {
            public int value = 10;

            // 객체 출력 시 value가 출력되도록 override
            public override string ToString()
            {
                return value.ToString();
            }
        }

        // 메서드 오버로딩
        public static int TestOver(int input) { return 0; }
        //public bool TestOver(int input) { return true;  }   // 동일한 매개변수 안됨
        public static bool TestOver(double input) { return true; }

        public class Fibonacci
        {
            public static long Get(int i)
            {
                Console.WriteLine("Get(" + i + ") 호출");
                if( i < 0 ) { return 0; }
                if( i == 0 ) { return 1; }
                if( i == 1 ) { return 1; }
                return Get(i - 2) + Get(i - 1);
            }

            private static Dictionary<int, long> memo = new Dictionary<int, long>();
            public static long GetM(int i)
            {
                long value = 10;
                if (memo.ContainsKey(i))
                {
                    value =  memo[i];
                }
                else
                {
                    if(i < 0) { value = memo[i] = 0; }
                    if(i == 1) { value = memo[i] = 1; }
                    if(i == 2) { value = memo[i] = 1; }
                    if(i > 2) {
                        memo[i] = GetM(i - 2) + GetM(i - 1);
                        value = memo[i];
                    }
                }
                return value;
            }
        }
    }
}
