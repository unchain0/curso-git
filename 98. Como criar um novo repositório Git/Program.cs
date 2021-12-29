Console.WriteLine("Olá Mundo!");

#region GetHours

DateTime date = DateTime.Now;
int hour = date.Hour;

if (hour <= 6)
{
    Console.WriteLine("Boa madrugada!");
}
else if (hour <= 12)
{
    Console.WriteLine("Bom dia!");
}
else if (hour <= 18)
{
    Console.WriteLine("Boa tarde!");
}
else
{
    Console.WriteLine("Boa noite!");
}

#endregion

Console.ReadLine();