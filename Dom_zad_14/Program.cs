int[] CreateMass(int len, int start,int end)
{
    int [] sumass= new int [len];
    for (int i = 0; i < len; i++)
    {
        sumass[i] = new Random().Next(start,end+1);
    }
    return sumass;
}

int Check_Chetn(int [] mass)
{
    int count=0;
    for (int n = 0; n < mass.Length; n++)
    {
        if (mass[n]%2==0) count+=1;
    }
    return count;
}
int size_mass = new Random().Next(5,11);
int [] massiv = CreateMass(size_mass,100,1000);
int  Count_Chetn =Check_Chetn(massiv);
Console.WriteLine($"[{string.Join(",",massiv)}]");
Console.WriteLine($"Chetnih chisel: {Count_Chetn}");