//  Crie um programa que permita que o usuário cadastre 5 nomes em um vetor. Após o cadastro, o programa deve imprimir na tela os nomes cadastrados em ordem alfabética. Utilize um laço for para o cadastro e um método de ordenação de sua preferência (por exemplo, bubble sort) para ordenar os nomes.

//  Declaração
using System.Globalization;

string[] nomes = new string[5];
int tamanhoArrayNomes = nomes.Length;
int i,j;

//  Inserção de dados no array

for(i = 0; i < tamanhoArrayNomes ; i++ )
{
    string? nomeAtual;
    
    do
    {
        Console.WriteLine($"Digite o {i+1} nome: ");
        
        nomeAtual = Console.ReadLine();
        
        if(string.IsNullOrEmpty(nomeAtual))
        {
            Console.WriteLine("Valor digitado não pode ser null");
        }

    }while(String.IsNullOrEmpty(nomeAtual));
    
    nomes[i] = nomeAtual.Trim();
}

// Ordena os dados.
void OrdenaDados(string[] textos){
    for(i = 0; i < tamanhoArrayNomes ; i++)
    {
        for(j = 0 ; j < tamanhoArrayNomes ; j++)
        {
            // Acessamos a classe String para comparar 2 string
            if(string.Compare(textos[i], textos[j]) < 0)
            {
                string temporaria = nomes[i];
                textos[i] = textos[j];
                textos[j] = temporaria;
            }
        }
    }
}

OrdenaDados(nomes);

Console.WriteLine("\nDado Ordenados :");

foreach( string nome in nomes)
{
    Console.WriteLine(nome);
}