using System;
using System.Threading; // Oferece recursos para trabalhar com threads, como a sincronização de threads e a transmissão de dados

class Program
{
    static void Main()
    {
        int segundos;
        Console.WriteLine("Escolha uma opção:"); // Imprime na tela para o usuário ler
        Console.WriteLine("1 - Temporizador (contagem regressiva)"); // Imprime na tela para o usuário ler qual é a opção
        Console.WriteLine("2 - Cronômetro (contagem progressiva)"); // Imprime na tela para o usuário ler qual é a opção
        int escolha = int.Parse(Console.ReadLine()); // Lê a opção do usuário
        switch(escolha)  // Valor que será comparado com os valores de cada case pela variável escolha
        {
        case 1: // Caso a pessoa escolher 1
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
        break; // Para o caso

        case 2: // Caso a pessoa escolher 2
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
        Console.WriteLine("Tempo chegado ao seu limite!"); // Imprime na tela que o tempo chegou no limite
        break; // Para o caso

        default: // Caso a pessoa escolher outro número
        Console.WriteLine("Opção inválida!"); // Imprime na tela número inválido
        break; // Para o default
        }
    }
}