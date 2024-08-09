// Implementar um programa que solicita ao usuario um numero e imprime a tabuada desse numero.

float multiplicador;
bool resultParse;

Console.WriteLine("Digite um número para que seja efetuada a tabuada do mesmo: ");
resultParse = float.TryParse(Console.ReadLine(),out multiplicador);

if(resultParse){
    for(int i = 1 ; i <= 10 ; i++ )
    {
        Console.WriteLine($"{i} x {multiplicador} = {i * multiplicador}");
    }
}
else
{
    Console.WriteLine("O valor inserido não é um número.")
}