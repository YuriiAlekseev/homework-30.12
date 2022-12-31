// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int FunctionAnkerman(int M, int N)
{
    if(M == 0) return N + 1;
    if(M > 0 & N == 0) return FunctionAnkerman(M-1,1);
    else return FunctionAnkerman(M-1,FunctionAnkerman(M,N-1));
    
}
int EnterData(string text)
{
    Console.Write(text);
    int numb = int.Parse(Console.ReadLine());
    return numb;
}
int M = EnterData("Enter number M : ");
int N = EnterData("Enter number N : ");
Console.WriteLine(FunctionAnkerman(M,N));