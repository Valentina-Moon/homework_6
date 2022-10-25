//Показать числа Фибоначчи

Console.WriteLine("Ввидите значения Фибоначчи: ");
int n = int.Parse(Console.ReadLine() ?? "0");

int[] fibonacci = new int[n];

int nm0 = 0;
int nm1 = 1;

fibonacci[0] = nm0;
fibonacci[1] = nm1;

for (int i = 2; i < n; i++)
{
    int nm = nm0 + nm1;
    fibonacci[i] = nm;

    nm0 = nm1;
    nm1 = nm;
}
foreach (int fib in fibonacci)
{
    Console.WriteLine($"{fib}");
}
