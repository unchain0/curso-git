Console.WriteLine("Olá Mundo!");

#region Saudação

DateTime date = DateTime.Now;
int hour = date.Hour;

if (hour < 6)
{
    Console.Write("Boa madrugada");
}
else if (hour < 12)
{
    Console.Write("Bom dia");
}
else if (hour < 18)
{
    Console.Write("Boa tarde");
}
else
{
    Console.Write("Boa noite");
}

#endregion

Console.Write(", como você está? ");
Console.ReadLine();