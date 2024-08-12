// Escreva um programa que peça ao usuário para digitar um número inteiro e informe se o número é par ou ímpar. Utilize uma estrutura condicional if/else para realizar o teste.

int numeroLido = 0;

bool resultTry;

Console.WriteLine("Digite um número: ");

do{

    resultTry = int.TryParse(Console.ReadLine(), out numeroLido);
    
    if(!resultTry)
    {
        Console.WriteLine("Erro: valor inserido não conrresponde a um número.");
    }
    else if (numeroLido % 2 == 0)
    {
        Console.WriteLine($"O número digitado {numeroLido} é par.");
    }
    else
    {
        Console.WriteLine($"O número digitado {numeroLido} é impar.");
    }

}while(!resultTry);

