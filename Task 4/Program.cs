Console.Write("Введите число => ");
string paramString = Console.ReadLine();
int paramInt = int.Parse(paramString);

int startInt = 2;

while (startInt < paramInt)
{
    Console.Write($"{startInt}, ");
    startInt = startInt + 2;
}

