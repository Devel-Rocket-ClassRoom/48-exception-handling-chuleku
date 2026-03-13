using System;
using System.Collections.Generic;
using System.Text;

class SafeCalculator
{
    public void Divide(string num1, string num2)
    {
       if(int.TryParse(num1, out int result))
        {
            if(int.TryParse(num2,out int result1))
            {
                if (result != 0 && result1 != 0)
                {
                    int divide = (result / result1);
                    Console.WriteLine($"{result} / {result1} = {divide}");
                }
                else
                {
                    throw new DivideByZeroException("0으로 나눌 수 없습니다.");
                }
            }
        }
       else
        {
            throw new FormatException("올바른 숫자를 입력하세요");
        }

    }
}