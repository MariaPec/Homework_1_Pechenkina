Console.Write("Введите число => ");
string paramString = Console.ReadLine();
int paramInt = int.Parse(paramString);


int result = paramInt % 2;   

if (result == 1)
{
Console.WriteLine($"Число {paramInt} является нечетным");
}

else
{
Console.WriteLine($"Число {paramInt} является четным");
}

