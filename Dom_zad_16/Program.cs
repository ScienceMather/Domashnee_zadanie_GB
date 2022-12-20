int[] CreateMass(int len, int start,int end)
{
    int [] sumass= new int [len];
    for (int i = 0; i < len; i++)
    {
        sumass[i] = new Random().Next(start,end+1);
    }
    return sumass;
}

int Max_Min(int [] mass)
{
    int max =mass[0];
    int min =mass[0];
    for (int n = 0; n < mass.Length; n++)
    {
        if (mass[n]>max) max=mass[n];
    }

    for (int n = 0; n < mass.Length; n++)
    {
        if (mass[n]<min) min=mass[n];
    }
    int result =max-min;
    return result;

   
}
// int size_mass = new Random().Next(5,11);
int [] massiv = CreateMass(5,0,21);
int  raznitca =Max_Min(massiv);
Console.WriteLine($"[{string.Join(",",massiv)}]");
Console.WriteLine($"Raznitca max i min ravna: {raznitca}");