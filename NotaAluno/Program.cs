// Implementar um programa que recebe a norta de um aluno e imprime se ele está aprovado, reprovado ou em recuperaçao.

using System.Reflection.Metadata;

float nota = 0f;
double? notaDouble = 0;
string? entrada = "";
bool returnParse;
Console.WriteLine("Digite a nota do aluno: ");
// notaDouble = Convert.ToDouble(Console.ReadLine());
entrada = Console.ReadLine();
returnParse = float.TryParse(entrada, out nota);

if(returnParse){
    if(nota >7)
    {
        Console.WriteLine("Aprovado");
    }
    else if (nota>5)
    {
        Console.WriteLine("Recuperação");

    }else
    Console.WriteLine("Reprovado");
}
else{
    Console.WriteLine("Valor inserido é invalido");
}
