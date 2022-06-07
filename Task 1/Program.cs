Console.Write("Введите первое число => ");
string paramString1 = Console.ReadLine();
int paramInt1 = int.Parse(paramString1);
Console.Write("Введите второе число => ");
string paramString2 = Console.ReadLine();
int paramInt2 = int.Parse(paramString2);
Console.WriteLine("Вы ввели первое число: " + paramInt1);
Console.WriteLine("Вы ввели первое число: " + paramInt2);

if (paramInt1 > paramInt2)
{
    Console.WriteLine($"Число {paramInt1} является максимальным"); 
}
else
{
    Console.WriteLine($"Число {paramInt2} является максимальным");
}