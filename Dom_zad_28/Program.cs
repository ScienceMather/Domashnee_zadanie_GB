int GetNumber(string text)
{
    Console.WriteLine(text);
    int numb =int.Parse(Console.ReadLine());
    return numb;
}


int Rekyrsion(int start,int end)
{
    if (start==end) return start;
    else
    {
        end=end%10+Rekyrsion(start,end-1);
        // Console.Write($"{end},");
        return end;
    }
    
}



int start =GetNumber("VVedite SN: ");
int end =GetNumber("VVedite EN: ");
int result =Rekyrsion(start,end);
Console.WriteLine($"{result}");