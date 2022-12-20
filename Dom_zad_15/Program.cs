int[] CreateMass(int len, int start,int end)
{
    int [] sumass= new int [len];
    for (int i = 0; i < len; i++)
    {
        sumass[i] = new Random().Next(start,end+1);
    }
    return sumass;
}

int Summ_neChetn(int [] mass)
{
    int summ =0;
    for (int n = 0; n < mass.Length; n++)
    {
        if (n%2==1) summ+=mass[n];
    }
    return summ;
}
int size_mass = new Random().Next(5,11);
int [] massiv = CreateMass(size_mass,-10,11);
int  Summ_2 =Summ_neChetn(massiv);
Console.WriteLine($"[{string.Join(",",massiv)}]");
Console.WriteLine($"Summa nechetnih chisel: {Summ_2}");