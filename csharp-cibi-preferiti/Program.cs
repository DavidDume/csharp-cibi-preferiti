// See https://aka.ms/new-console-template for more information
string[] cibi = { "pizza", "hamburger", "gelato", "bistecca", "patatine" };

Console.WriteLine("Lunghezza classifica" + cibi.Length);

for(int i = 0; i < cibi.Length; i++)
{
    Console.WriteLine(i + " " + cibi[i]);
}

Console.WriteLine("Primo Posto - " + cibi[0]);

Console.WriteLine("Ultimo Posto - " + cibi[cibi.Length - 1]);

if (cibi.Length % 2 == 0)
{
    Console.WriteLine(cibi[(cibi.Length / 2) - 1] + " " + cibi[cibi.Length / 2]);
} else
{
    Console.WriteLine(cibi[cibi.Length / 2]);
}