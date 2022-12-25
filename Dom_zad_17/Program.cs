
string EnterData(string text_cord)
{
    Console.WriteLine(text_cord);
    string txt_num =Console.ReadLine();
    return txt_num;
}

int EnterDataIf()
{
    int count=0;
     while (true)
    {
        string txt_num =EnterData("Vvedite chislo: ");
        if (txt_num=="") break;
        else 
        {
            int num_t=int.Parse(txt_num);
            if (num_t>0) count+=1;
        }
    }
    return count;
}

int max_zero=EnterDataIf();
Console.WriteLine($"Chisel bolshe nulya: {max_zero}");