bool resultParse;
float fator;

void Multiplicacao(float fator1)
{
    Console.WriteLine("\n\t\tMultiplicação: ");
    for(int i = 1; i <= 10 ; i++)
    {
        Console.WriteLine($"\t{fator1}\t*\t{i}\t =\t {fator1*i}");
    }
}

Console.WriteLine("Digite um número para obter a tabuada: ");

do{    
    string? numero = Console.ReadLine();
    resultParse = float.TryParse( numero , out fator );

    if(!resultParse)
    {
        Console.WriteLine("Dado inserido não é um número.");
    }
    else
    {
        Multiplicacao(fator);
    }

}while(!resultParse);