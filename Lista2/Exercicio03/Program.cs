int[] numeros = {1,2,4,5,6,7,8,9,10};
int soma = 0;
for (int i = 0; i < numeros.Length; i++)
{
    int numero = numeros[i];
    bool ehNumeroPar = numero % 2 == 0;
    if(ehNumeroPar)
    {
        soma += numero;
        Console.WriteLine(soma);
    }
}

