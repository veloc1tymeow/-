Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
void Counter(int num, int i = 1)
{
    if(num >= i)
    {
        Console.Write(num + " ");
        num = num - 1;
        Counter(num, 1);
    }
    else
    {
        return;
    }
}
Counter(n, 1);
