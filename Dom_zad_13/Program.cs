
int GetNumber(string text)
{
    Console.WriteLine(text);
    int numb =int.Parse(Console.ReadLine());
    return numb;
}


int chislo = GetNumber("Vvedite dliny massiva: ");

int [] mass = new int [chislo];
for (int i = 0; i < mass.Length; i++)
{
    mass[i] = new Random().Next(-101,100);
    // Console.Write($"{mass[i]} ");
}
Console.WriteLine($"[{string.Join(",",mass)}]");
