
int EnterData(string text_cord)
{
    Console.WriteLine(text_cord);
    int number = int.Parse(Console.ReadLine());
    return number;
}

double FindDist(int Ax,int Ay,int Az,int Bx,int By,int Bz)
{
    double result =(Math.Sqrt(Math.Pow(Bx-Ax,2)+Math.Pow(By-Ay,2)+Math.Pow(Bz-Az,2)));
    // int res =int.Parse(result);
    return result;
}

int Num_Ax = EnterData  ("Vvedite coordinaty x: ");
int Num_Ay = EnterData  ("Vvedite coordinaty y: ");
int Num_Az = EnterData  ("Vvedite coordinaty z: ");
int Num_Bx = EnterData  ("Vvedite coordinaty x: ");
int Num_By = EnterData  ("Vvedite coordinaty y: ");
int Num_Bz = EnterData  ("Vvedite coordinaty z: ");

double FindNum = Math.Round(FindDist(Num_Ax,Num_Ay,Num_Az,Num_Bx,Num_By,Num_Bz),2);
Console.WriteLine($"Rasstoyanie mezjdy tochkami ravno {FindNum}");





