using System;

SafeCalculator calculator = new SafeCalculator();
Console.WriteLine("=== 테스트 1: 정상 입력 ===");
try
{
calculator.Divide("10","2");
}
catch(FormatException ex)
{
    Console.WriteLine(ex.Message);
}
catch(DivideByZeroException ex)
{
    Console.WriteLine(ex.Message); 
}
finally
{
    Console.WriteLine("계산기를 종료합니다.");
}
Console.WriteLine();
Console.WriteLine("=== 테스트 2: 0으로 나누기 ===");
try
{
calculator.Divide("2", "0");
}
catch (FormatException ex)
{
    Console.WriteLine(ex.Message);
}
catch (DivideByZeroException ex)
{
    Console.WriteLine(ex.Message);
}
finally
{
    Console.WriteLine("계산기를 종료합니다.");
}
Console.WriteLine();


Console.WriteLine("=== 테스트 3: 잘못된 형식 ===");
try
{
calculator.Divide("야미", "ㅎㅎ");
}
catch (FormatException ex)
{
    Console.WriteLine(ex.Message);
}
catch (DivideByZeroException ex)
{
    Console.WriteLine(ex.Message);
}
finally
{
    Console.WriteLine("계산기를 종료합니다.");
}