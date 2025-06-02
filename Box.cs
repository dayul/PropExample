using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropExample
{
    class Box
    {
        // C#에서는 속성(Property), 첫글자는 대문자로
        //public int Width { get; set; }
        //public int Height { get; set; }

        private int width;

        public int Width
        {
            get { return width; }
            set { if (value > 0)
                {
                    width = value;
                }
                else
                {
                    Console.WriteLine("너비는 자연수로 초기화 해 주세요");
                }
            }
        }

        private int height;
        
        public int Height
        {
            get { return height; }
            set
            {
                if (value > 0)
                {
                    height = value;
                }
                else
                {
                    Console.WriteLine("너비는 자연수로 초기화 해 주세요");
                }
            }
        }


        public Box(int width, int height)
        {
            // 알아서 setter를 호출, 검증은 setter에서 처리(코드 중복 방지)
            Width = width;
            Height = height;
        }

        private int area;

        public int Area
        {
            get { return Height * Width; }
        }
    }
}
