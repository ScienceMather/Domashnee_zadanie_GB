

int SummDigit(int a)
{
    int count =0;
    int schet =0;
    while (true)
    {
        if (a!=0)
        {
            schet= a%10;
            count=count+schet;
            a= a/10;
        }
        else break;
    }
    return count;

}


int GetNumber(string text)
{
    Console.WriteLine(text);
    int numb =int.Parse(Console.ReadLine());
    return numb;
}


int chislo = GetNumber("Vvedite chislo: ");
int sum_chisl = SummDigit(chislo);
Console.WriteLine($"summa chisel = {sum_chisl}");
