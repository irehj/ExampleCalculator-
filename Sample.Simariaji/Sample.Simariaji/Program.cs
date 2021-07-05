using System;

namespace Sample.Simariaji
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("두개의 숫자를 입력하세요");
            Console.WriteLine("첫번째 숫자를 입력하세요");
            string firtsnum = Console.ReadLine();
            Console.WriteLine("두번째 숫자를 입력하세요");
            string secondnum = Console.ReadLine();
            Console.WriteLine("연산자를 입력하세요");
            string oper = Console.ReadLine();
            Console.Write("값 : ");
            int result = 0;

            if (oper == "+")
            {
                result = Plus(int.Parse(firtsnum), int.Parse(secondnum));
            }
            else if (oper == "-")
            {
                result = Minus(int.Parse(firtsnum), int.Parse(secondnum));
            }
            else if (oper == "*")
            {
                result = Mulit(int.Parse(firtsnum), int.Parse(secondnum));
            }
            else if (oper == " /")
            {
                result = Div(int.Parse(firtsnum), int.Parse(secondnum));
            }
            Console.WriteLine(result);
        }

        //참조 1개 
        public static int Plus(int num1, int num2)
        {
            int result = num1 + num2;

            return result;

        }

        public static int Minus(int num1, int num2)
        {
            int result = num1 - num2;
            return result;
        }

        public static int Mulit(int num1, int num2)
        {
            int result = num1 * num2;
            return result;
        }
        public static int Div(int num1, int num2)
        {
            int result = num1 / num2;
            return result;
        }
    }


}
