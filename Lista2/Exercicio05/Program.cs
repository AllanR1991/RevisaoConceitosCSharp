string? texto;
int count = 0;

// Inserção de dados.
do
{
    Console.WriteLine("Digite um texto: ");
    texto = Console.ReadLine();
    if(string.IsNullOrEmpty(texto))
    {
        Console.WriteLine("Nada foi digitado. Tente novamente.");
    }
}while(string.IsNullOrEmpty(texto));

// Contagem de letras do alfabético.
foreach(char letra in texto)
{
    if(char.IsLetter(letra))
    {
        count++;
    }
}

// Exibição da contagem total de letras do alfabeto.
Console.WriteLine($"O total de letras do alfabeto contido no texto é : {count}");