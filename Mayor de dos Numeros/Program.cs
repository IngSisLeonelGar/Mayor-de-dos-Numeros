int Num1, Num2;
string linea;
Console.WriteLine("Numero 1 : ");
linea = Console.ReadLine();
Num1 = int.Parse(linea);
Console.WriteLine("Numero 2 :");
linea = Console.ReadLine();
Num2 = int.Parse(linea);
if(Num1 > Num2)
{
    Console.WriteLine("{0} Es Mayor que {1}", Num1, Num2);
}
else
{
    if(Num1 == Num2)
    {
        Console.WriteLine("{0} Es Igual que {1}", Num1, Num2);
    }
    else
    {
        Console.WriteLine("{0} Es Menor que {1}", Num1, Num2);
    }
}
Console.WriteLine();
Console.WriteLine("Otra Manera");
string result;
if(Num1 > Num2)
{
    result = "Mayor";
}
else
{
    if(Num1 == Num2)
    {
        result = "Igual";
    }
    else
    {
        result = "Menor";
    }
}
Console.WriteLine("{0} Es {1} que {2}", Num1, result, Num2);
Console.Write("Pulse una tecla:");
Console.ReadLine();