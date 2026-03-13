using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

FilePathValidator filepathvi = new FilePathValidator();
Console.WriteLine("=== 경로 검증 테스트 ===");
try
{
    filepathvi.ValidatePath("C:/Users/data /report.txt");
    filepathvi.ValidatePath(null);
    
    
}
catch(ArgumentNullException ex)
{
    Console.WriteLine(ex.Message);
}
catch(ArgumentOutOfRangeException ex)
{
    Console.WriteLine(ex.Message); 
}
catch(ArgumentException ex)
{
    Console.WriteLine(ex.Message);
}
try
{
    filepathvi.ValidatePath("<<<<<<<");
}
catch(ArgumentNullException ex)
{
    Console.WriteLine(ex.Message);
}
catch(ArgumentOutOfRangeException ex)
{
    Console.WriteLine(ex.Message); 
}
catch(ArgumentException ex)
{
    Console.WriteLine(ex.Message);
}
try
{
    filepathvi.ValidatePath("dddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddd");
}
catch(ArgumentNullException ex)
{
    Console.WriteLine(ex.Message);
}
catch(ArgumentOutOfRangeException ex)
{
    Console.WriteLine(ex.Message); 
}
catch(ArgumentException ex)
{
    Console.WriteLine(ex.Message);
}
Console.WriteLine();
Console.WriteLine("=== 확장자 검증 테스트 ===");
string[] check ={ ".txt", ".csv" };
try
{
    filepathvi.ValidateExtension(".txt",check);
    filepathvi.ValidateExtension(".csv",check);
    filepathvi.ValidateExtension(".exe",check);
}
catch(ArgumentException ex)
{
    Console.WriteLine(ex.Message);
}