string[] nomes = new string[5];
string? nome;
for(int i = 0 ; i < nomes.Length ; i++)
{
    Console.WriteLine($"Digite o {i} nome");
    nomes[i] =  Console.ReadLine();
}

Console.WriteLine("\n\n");
Array.Sort(nomes);


foreach(string name in nomes)
{
    Console.WriteLine(name);
}