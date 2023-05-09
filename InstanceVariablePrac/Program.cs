using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstanceVariablePrac
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //자바 스타일
            Product product1 = new Product();
            product1.name = "감자";
            product1.price = 2000;

            //C# 스타일
            Product product2 = new Product() { name = "고구마", price = 2100 };
            Product product3 = new Product() { name = "옥수수" };
            Product product4 = new Product() { price = 999999 };
            Product product5 = new Product() { price = 7777, name = "비트" };

            //클래스 변수 출력
            Console.WriteLine(Product.origin);
            Console.WriteLine(product1.name+"/"+product1.price); //이 코드는 마음에 들면 안된다.. 
            Console.WriteLine(product1);
            //Console.WriteLine(Product1.origin); 자바에서는 가능

            List<Student> list = new List<Student>(); //student가 들어간 리스트 생성?
            list.Add(new Student() { name = "곽경희", grade = 1 });
            list.Add(new Student() { name = "권하은", grade = 2 });
            list.Add(new Student() { name = "김선혜", grade = 3 });
            list.Add(new Student() { name = "김하늘", grade = 4 });
            list.Add(new Student() { name = "배서연", grade = 1 });
            list.Add(new Student() { name = "백지민", grade = 2 });

            List<Student> list2 = new List<Student>()
            {
                new Student(){name="곽경희", grade=3},
                new Student(){name="권하은", grade=2},
                new Student(){name="김선혜", grade=1},
            };
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            foreach (var item in list2)
            {
                Console.WriteLine(item);
            }

            //list안에 인스턴스 지우기(예외가 발생한 코드)
            //foreach(var item in list)
            //foreach를 사용할 때 list에 변동이 있으면 안된다. foreach는 해결방법이 없다
            //{
            //if (item.grade == 3)
            //{
            //list.Remove(item);
            //}
            //}

            //list안에 인스턴스 지우기(잘못된 코드)
            for (int i=0; i<list.Count; i++)
                //for 사용 중 list에 변동이 있으면 안된다. for문은 해결방법이 있다 (뒤에서부터 삭제)
            {
                if (list[i].grade > 1)
                {
                    list.RemoveAt(i);
                }
            }
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            //뒤에서부터 삭제하면 문제를 피할 수 있다.
            for (int i = list.Count-1; i >=0; i--)
            {
                if (list[i].grade > 1)
                {
                    list.RemoveAt(i);
                }
            }
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
