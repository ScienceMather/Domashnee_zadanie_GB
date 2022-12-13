
int EnterData(string text_cord)
{
    Console.WriteLine(text_cord);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int N = EnterData("Vvedite chislo N: ");
int count =1; 

for(int i =1;i<=N;i++)
    if (count!=N)
        {
            Console.Write(Math.Pow(count,3)+",");
            count++;
        }
        else
        {
            Console.Write(Math.Pow(count,3)+".");
            count++;
        }
