Console.WriteLine("Введите первое число: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int n2 = Convert.ToInt32(Console.ReadLine());
int count = 0;
for(int i =n1; i <= n2; i++)
{
    count = count + i;
}
Console.WriteLine(count);
