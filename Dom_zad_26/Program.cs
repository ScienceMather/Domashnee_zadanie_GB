
int GetNumber(string text)
{
    Console.WriteLine(text);
    int numb = int.Parse(Console.ReadLine());
    return numb;
}

string[,] Create_duo_mass(int strok, int stolb)
{
    string[,] rand_mass = new string[strok, stolb];
    return rand_mass;
}

void PrintMass(string[,] mass)
{
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < mass.GetLength(1); j++)
        {
            Console.Write(mass[i, j] + "  ");
        }
    }
    Console.WriteLine();
}

int[] GoUp(int[] kort)
{
    kort[0] = kort[0] + 1;
    kort[1] = kort[1];
    return kort;
}

int[] GoDown(int[] kort)
{
    kort[0] = kort[0] - 1;
    kort[1] = kort[1];
    return kort;
}

int[] GoLeft(int[] kort)
{
    kort[0] = kort[0];
    kort[1] = kort[1] - 1;
    return kort;
}

int[] GoRight(int[] kort)
{
    kort[0] = kort[0];
    kort[1] = kort[1] + 1;
    return kort;
}

string[,] FillSpiral(string[,] mass)
{
    // int[]spiral= new int [00,01,02,03,13,23,33,32,31,30,20,10,11,12,22,21];
    int lenmass=mass.GetLength(0)*mass.GetLength(1);
    int i =0;
    int j =-1;
    for (int k = 0; k < lenmass; k++)
    {
        if (k<4)
        {
            j++;
            mass[i,j]=$"0{k+1}";
            
        }
        if (k>3 && k<7)
        {
            i++;
            mass[i,j]=$"0{k+1}";
            
        }
        if (k>6 && k<10)
        {
            j--;
            if(k+1>9) mass[i,j]=$"{k+1}";
            else mass[i,j]=$"0{k+1}";
        }
        if (k>9 && k<12)
        {
            i--;
            mass[i,j]=$"{k+1}";
            
        }
        if (k>11 && k<14)
        {
            j++;
            mass[i,j]=$"{k+1}";
            
        }
        if (k>13 && k<16)
        {
            if(k==14)
            {
                i++;
                j++;
            }
            j--;
            mass[i,j]=$"{k+1}";
        }
    }
    return mass;
}



string[,] d_mass = Create_duo_mass(4, 4);

string[,] result = FillSpiral(d_mass);
PrintMass(result);


