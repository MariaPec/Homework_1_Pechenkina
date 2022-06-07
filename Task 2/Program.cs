Console.Write("Введите первое число => ");

string paramString1 = Console.ReadLine();

int paramInt1 = int.Parse(paramString1);

Console.Write("Введите второе число => ");

string paramString2 = Console.ReadLine();

int paramInt2 = int.Parse(paramString2);

Console.Write("Введите третье число => ");

string paramString3 = Console.ReadLine();

int paramInt3 = int.Parse(paramString3);

int max = 0;
     

if (paramInt1 > paramInt2)

{
        
max = paramInt1;
}

else

{
  
max = paramInt2;  
}

if (paramInt3 > max)

{
        
max = paramInt3;
}
    
Console.WriteLine($"Максимальным числом является {max}");
