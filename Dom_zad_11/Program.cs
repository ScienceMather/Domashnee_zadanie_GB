
int SummNumb(int a,int b)
{
    int pro =1;
    for (int i = 1; i <=b; i++) pro= pro*a;
    return pro;
}


int GetNumbers(string text)
{
    Console.WriteLine(text);
    int numb =int.Parse(Console.ReadLine());
    return numb;
}



int numA = GetNumbers("Vvedite chislo A: ");
int numB = GetNumbers("Vvedite chislo B: ");
int power = SummNumb(numA,numB);
Console.WriteLine($"Chislo {numA} v stepeni {numB} ravno {power}!");


