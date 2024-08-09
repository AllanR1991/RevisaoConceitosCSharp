// Crie um programa que gere um numero aleatorio entre 1 e 10 . O usuario deve tentar adivinhar esse numero . O Programa deve continuar pedindo um palpite ate que o usuario acerte o numero , Ao final, monstre quantas tentativas foram necessarias.

Random random = new Random();

int numeroAleatorio = random.Next(1, 11);
int chute = 0;
bool returnTry;
int tentativas = 0;

Console.Clear();

do{    
    Console.WriteLine("\nTente adivinhar um numero entre 1 e 10");
    returnTry = int.TryParse(Console.ReadLine(), out chute);
    if(!returnTry){
        Console.WriteLine("Valor inserido é invalido: ");
    }
    tentativas++;
}while(chute != numeroAleatorio);

Console.WriteLine($"\nForam necessarias {tentativas} tentativa(s).");