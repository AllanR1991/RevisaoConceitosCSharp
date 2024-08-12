int[] numeros = [1,2,3,4,5,6,7,8,9,10];
int soma = 0;

foreach(int numero in numeros){
    if(numero % 2 == 0)
    {
        soma += numero;
    }
}

Console.WriteLine($"O valor total da soma dos pares é : {soma} ");