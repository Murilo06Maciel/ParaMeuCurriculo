using System;
using System.Threading;

class Program
{
    static void Main()
    {
        Console.Write("Insira o número de segundos para o cronômetro: "); // Imprime na tela para o usuário escolher a quantidade de segundos
        int segundos = int.Parse(Console.ReadLine()); // Lê a variavel inteira "segundos"

        //Console.WriteLine($"Cronômetro iniciado para {segundos} segundos..."); // Imprime na tela que o cronômetro vai iniciar em tantos segundos

        for (int i = segundos; i >= 0; i--) // Função "para" a variavel 'i' igual ao valor de "segundos", continua enquanto 'i' for maior ou igual a 0, e diminui 'i' em 1 a cada fez que rodar.
        {
            Console.Clear(); // limpa o que estava escrito anteriormente
            Console.WriteLine($"Cronômetro iniciado para {segundos} segundos..."); // Imprime na tela que o cronômetro vai iniciar em tantos segundos
            Console.WriteLine($"Tempo restante: {i} segundos"); // Imprime na tela o tempo restante 
            Thread.Sleep(1000); // Pausa por 1 segundo
        }
		Console.Clear(); // limpa o que estava escrito anteriormente
        Console.WriteLine("Tempo esgotado!"); // Imprime na tela que o tempo acabou
    }
}