using System;
using System.Threading; // Oferece recursos para trabalhar com threads, como a sincronização de threads e a transmissão de dados

class Program
{
    static void Main()
    {
        int segundos;
        Console.WriteLine("Escolha uma opção:");
        Console.WriteLine("1 - Temporizador (contagem regressiva)");
        Console.WriteLine("2 - Cronômetro (contagem progressiva)");
        int escolha = int.Parse(Console.ReadLine()); // Lê a opção do usuário
        switch(escolha)
        {
        case 1:
        Console.Write("Insira o número de segundos para o temporizador: "); // Imprime na tela para o usuário escolher a quantidade de segundos
        segundos = int.Parse(Console.ReadLine()); // Lê a variavel inteira "segundos"

        for (int i = segundos; i >= 0; i--) // Função "para" a variavel 'i' igual ao valor de "segundos", continua enquanto 'i' for maior ou igual a 0, e diminui 'i' em 1 a cada fez que rodar.
        {
            Console.Clear(); // limpa o que estava escrito anteriormente
            Console.WriteLine($"Temporizador iniciado para {segundos} segundos..."); // Imprime na tela que o temporizador vai iniciar em tantos segundos
            Console.WriteLine($"Tempo restante: {i} segundos"); // Imprime na tela o tempo restante 
            Thread.Sleep(1000); // Pausa por 1 segundo
        }
		Console.Clear(); // limpa o que estava escrito anteriormente
        Console.WriteLine("Tempo esgotado!"); // Imprime na tela que o tempo acabou
        break;

        case 2:
        Console.Write("Insira o número de segundos para o cronômetro: "); // Imprime na tela para o usuário escolher a quantidade de segundos
        segundos = int.Parse(Console.ReadLine()); // Lê a variavel inteira "segundos"

        for (int i = 0; segundos >= i; i++) // Função "para" a variavel 'i' igual ao valor de "segundos", continua enquanto 'i' for maior ou igual a 0, e diminui 'i' em 1 a cada fez que rodar.
        {
            Console.Clear(); // limpa o que estava escrito anteriormente
            Console.WriteLine($"Cronômetro iniciado para até {segundos} segundos..."); // Imprime na tela que o cronômetro vai iniciar em tantos segundos
            Console.WriteLine($"Tempo: {i} segundos"); // Imprime na tela o tempo restante 
            Thread.Sleep(1000); // Pausa por 1 segundo
        }
		Console.Clear(); // limpa o que estava escrito anteriormente
        Console.WriteLine("Tempo esgotado!"); // Imprime na tela que o tempo acabou
        break;

        default:
        Console.WriteLine("Opção inválida!");
        break;
        }
    }
}