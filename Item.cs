using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropExample
{
    public class Item
    {
        private static int count;
        public const string ApplicationName = "app";    // 정적 상수 같은 활용
        public readonly int id;     // readonly 키워드는 const 상수와 비슷하나 선언을 객체 생성 시점으로 미룰 수 있다, 초기 값 설정 가능
        public string name;
        public int price;

        public Item(string name, int price)
        {
            this.id = count++;      // readonly 키워드는 변수 선언 또는 생성자 안에서만 값 할당 가능, 생성자에서 수정 가능
            this.name = name;
            this.price = price;
        }

        public void setId(int id)
        {
            //this.id = id; // readonly로 한번 세팅되면 수정 불가
        }
    }
}
