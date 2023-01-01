
int GetNumber(string text)
{
    Console.WriteLine(text);
    int numb =int.Parse(Console.ReadLine());
    return numb;
}

int Rekyrsion(int rek)
{

    if (rek==1) return rek;
    else
    {
        Console.Write($",{rek-1}");
        Rekyrsion(rek-1);
        return rek;
    }
    
}

int rekyrs =GetNumber("VVedite N: ");
int result =Rekyrsion(chislo,stepen);
// Console.WriteLine($"{result}");
