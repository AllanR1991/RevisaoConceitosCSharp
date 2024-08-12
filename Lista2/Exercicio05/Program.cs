//Crie um programa que peça ao usuário para digitar um texto e conte quantas vezes cada letra do alfabeto aparece no texto.

string? texto;
int i=0;

// Inserção de dados.
do
{
    Console.WriteLine("Digite um texto: ");
    texto = Console.ReadLine()?.ToLower();
    if(string.IsNullOrEmpty(texto))
    {
        Console.WriteLine("Nada foi digitado. Tente novamente.");
    }
}while(string.IsNullOrEmpty(texto));

// Contagem de letras do alfabético.
while( i < texto.Length )
{   
    Char letra = texto[i];

    if(char.IsLetter(letra))
    {        
        int count = 0;
        
        while(texto.IndexOf(letra) != -1)
        {            
            texto = texto.Remove(texto.IndexOf(letra),1);
            count++;            
        }     
       
        Console.WriteLine($"A letra {letra} aparece {count} veze(s)");
    }
    else
    {
        texto = texto.Remove(texto.IndexOf(letra),1);
    }
}