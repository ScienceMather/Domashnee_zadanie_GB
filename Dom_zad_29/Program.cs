int GetNumber(string text)
{
    Console.WriteLine(text);
    int numb =int.Parse(Console.ReadLine());
    return numb;
}


int Rekyrsion(int m,int n)
{
    {
        if (m==0) return n+1;
        else
        {
            if (m>0 && n==0) return Rekyrsion(m-1,1);
            else if (m>0 && n>0) return Rekyrsion(m-1,Rekyrsion(m,n-1));
        }
        
    }
    return n;
    
}


int MM=GetNumber("VVedite M: ");
int NN =GetNumber("VVedite N: ");
int result =Rekyrsion(MM,NN);
Console.WriteLine($"{result}");