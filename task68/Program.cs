// Задача 68: Напишите программу вычисления функции Аккермана с 
// помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
int Read(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}
int FunctionAcc(int m, int n)
 {
     if (m==0)  
     {
        return n+1;
     }
     else if  (m>0 && n==0)
     {
        return FunctionAcc(m-1, 1);
     } 
     else 
     {
        return (FunctionAcc(m-1, FunctionAcc(m, n-1)));
     }
 }
int num1 = Read("введите первое число");
int num2 = Read("введите второе число");
System.Console.WriteLine(FunctionAcc(num1, num2)); 