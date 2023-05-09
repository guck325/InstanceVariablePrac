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
            list.Add(new Student() { name = "곽경희", grade = 3 });
            list.Add(new Student() { name = "권하은", grade = 2 });
            list.Add(new Student() { name = "김선혜", grade = 1 });

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
        }
    }
}
