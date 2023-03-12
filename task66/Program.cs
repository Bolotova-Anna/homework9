// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов 
// в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30
int Read(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}
int Sum(int num1, int num2)
{
    if(num1 == num2) return 0;
    num1++;
    return num1+ Sum(num1,num2);
}
int m = Read("введите первое число");
int n = Read("введите второе число");
if (m>n)
{
    int c = m;
    m = n;
    n = c;
}
System.Console.WriteLine(Sum(m-1, n));