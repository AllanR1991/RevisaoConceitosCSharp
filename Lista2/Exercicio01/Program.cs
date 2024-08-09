int numeroDigitado;
bool resultTry;
Console.WriteLine("Digite um numero inteiro: ");

do{
    resultTry = int.TryParse(Console.ReadLine(), out numeroDigitado);
    if(!resultTry)
    {
        Console.WriteLine("\nO valor digitado não é valido, Tente novamente: ");
    }
    else{
        if(numeroDigitado % 2 == 0 )
        {
            Console.WriteLine($"\nNumero digitado {numeroDigitado} é par");
        }
        else
        {
            Console.WriteLine($"\nNumero digitado {numeroDigitado} é impar ");
        }
    }

}while(!resultTry);