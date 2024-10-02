using System;
using System.Threading; // Oferece recursos para trabalhar com threads, como a sincronização de threads e a transmissão de dados

class Program
{
    static void Main()
    {
        int tempo, escolha2;
        bool continuar;
        do
        {
        Console.WriteLine("Escreva qual é a unidade de tempo:\n");// Imprime na tela para o usuário ler
        Console.WriteLine("1 - horas"); // Imprime na tela para o usuário ler qual é a opção
        Console.WriteLine("2 - minutos"); // Imprime na tela para o usuário ler qual é a opção
        Console.WriteLine("3 - segundos"); // Imprime na tela para o usuário ler qual é a opção
        int escolha1 = int.Parse(Console.ReadLine()); // Lê a opção do usuário
        switch(escolha1) // Valor que será comparado com os valores de cada case pela variável escolha
        {
        case 1: // Caso a pessoa escolher 1
        Console.WriteLine("Escolha uma opção:"); // Imprime na tela para o usuário ler
        Console.WriteLine("1 - Temporizador (contagem regressiva)"); // Imprime na tela para o usuário ler qual é a opção
        Console.WriteLine("2 - Cronômetro (contagem progressiva)"); // Imprime na tela para o usuário ler qual é a opção
        escolha2 = int.Parse(Console.ReadLine()); // Lê a opção do usuário
        switch(escolha2)  // Valor que será comparado com os valores de cada case pela variável escolha
        {
        case 1: // Caso a pessoa escolher 1
        Console.Write("Insira o tempo para o temporizador: "); // Imprime na tela para o usuário escolher a quantidade de tempo
        tempo = int.Parse(Console.ReadLine()); // Lê a variavel inteira "tempo"

        for (int i = tempo; i >= 0; i--) // Função "para" a variavel 'i' igual ao valor de "tempo", continua enquanto 'i' for maior ou igual a 0, e diminui 'i' em 1 a cada fez que rodar.
        {
            Console.Clear(); // limpa o que estava escrito anteriormente
            Console.WriteLine($"Temporizador iniciado para {tempo} horas..."); // Imprime na tela que o temporizador vai iniciar em tantas horas
            Console.WriteLine($"Tempo restante: {i} hora(s)"); // Imprime na tela o tempo restante 
            Thread.Sleep(3600000); // Pausa por 1 hora
        }
		Console.Clear(); // limpa o que estava escrito anteriormente
        Console.WriteLine("Tempo esgotado!"); // Imprime na tela que o tempo acabou
        break; // Para o caso

        case 2: // Caso a pessoa escolher 2
        Console.Write("Insira o tempo para o cronômetro: "); // Imprime na tela para o usuário escolher a quantidade de tempo
        tempo = int.Parse(Console.ReadLine()); // Lê a variavel inteira "tempo"

        for (int i = 0; tempo >= i; i++) // Função "para" a variavel 'i' igual ao valor de "tempo", continua enquanto 'i' for maior ou igual a 0, e diminui 'i' em 1 a cada fez que rodar.
        {
            Console.Clear(); // limpa o que estava escrito anteriormente
            Console.WriteLine($"Cronômetro iniciado para até {tempo} horas..."); // Imprime na tela que o cronômetro vai iniciar em tantas horas
            Console.WriteLine($"Tempo: {i} hora(s)"); // Imprime na tela o tempo restante 
            Thread.Sleep(3600000); // Pausa por 1 hora
        }
		Console.Clear(); // limpa o que estava escrito anteriormente
        Console.WriteLine("Tempo chegado ao seu limite!"); // Imprime na tela que o tempo chegou no limite
        break; // Para o caso

        default: // Caso a pessoa escolher outro número
        Console.WriteLine("Opção inválida!"); // Imprime na tela número inválido
        break; // Para o default
        }
        break;


        case 2: // Caso a pessoa escolher 2
        Console.WriteLine("Escolha uma opção:"); // Imprime na tela para o usuário ler
        Console.WriteLine("1 - Temporizador (contagem regressiva)"); // Imprime na tela para o usuário ler qual é a opção
        Console.WriteLine("2 - Cronômetro (contagem progressiva)"); // Imprime na tela para o usuário ler qual é a opção
        escolha2 = int.Parse(Console.ReadLine()); // Lê a opção do usuário
        switch(escolha2)  // Valor que será comparado com os valores de cada case pela variável escolha
        {
        case 1: // Caso a pessoa escolher 1
        Console.Write("Insira o tempo para o temporizador: "); // Imprime na tela para o usuário escolher a quantidade de tempo
        tempo = int.Parse(Console.ReadLine()); // Lê a variavel inteira "tempo"

        for (int i = tempo; i >= 0; i--) // Função "para" a variavel 'i' igual ao valor de "tempo", continua enquanto 'i' for maior ou igual a 0, e diminui 'i' em 1 a cada fez que rodar.
        {
            Console.Clear(); // limpa o que estava escrito anteriormente
            Console.WriteLine($"Temporizador iniciado para {tempo} minutos..."); // Imprime na tela que o temporizador vai iniciar em tantos minutos
            Console.WriteLine($"Tempo restante: {i} minuto(s)"); // Imprime na tela o tempo restante 
            Thread.Sleep(60000); // Pausa por 1 minuto
        }
		Console.Clear(); // limpa o que estava escrito anteriormente
        Console.WriteLine("Tempo esgotado!"); // Imprime na tela que o tempo acabou
        break; // Para o caso

        case 2: // Caso a pessoa escolher 2
        Console.Write("Insira o tempo para o cronômetro: "); // Imprime na tela para o usuário escolher a quantidade de tempo
        tempo = int.Parse(Console.ReadLine()); // Lê a variavel inteira "tempo"

        for (int i = 0; tempo >= i; i++) // Função "para" a variavel 'i' igual ao valor de "tempo", continua enquanto 'i' for maior ou igual a 0, e diminui 'i' em 1 a cada fez que rodar.
        {
            Console.Clear(); // limpa o que estava escrito anteriormente
            Console.WriteLine($"Cronômetro iniciado para até {tempo} minutos..."); // Imprime na tela que o cronômetro vai iniciar em tantos minutos
            Console.WriteLine($"Tempo: {i} minuto(s)"); // Imprime na tela o tempo restante 
            Thread.Sleep(60000); // Pausa por 1 minuto
        }
		Console.Clear(); // limpa o que estava escrito anteriormente
        Console.WriteLine("Tempo chegado ao seu limite!"); // Imprime na tela que o tempo chegou no limite
        break; // Para o caso

        default: // Caso a pessoa escolher outro número
        Console.WriteLine("Opção inválida!"); // Imprime na tela número inválido
        break; // Para o default
        }
        break;


        case 3: // Caso a pessoa escolher 3
        Console.WriteLine("Escolha uma opção:"); // Imprime na tela para o usuário ler
        Console.WriteLine("1 - Temporizador (contagem regressiva)"); // Imprime na tela para o usuário ler qual é a opção
        Console.WriteLine("2 - Cronômetro (contagem progressiva)"); // Imprime na tela para o usuário ler qual é a opção
        escolha2 = int.Parse(Console.ReadLine()); // Lê a opção do usuário
        switch(escolha2)  // Valor que será comparado com os valores de cada case pela variável escolha
        {
        case 1: // Caso a pessoa escolher 1
        Console.Write("Insira o tempo para o temporizador: "); // Imprime na tela para o usuário escolher a quantidade de tempo
        tempo = int.Parse(Console.ReadLine()); // Lê a variavel inteira "tempo"

        for (int i = tempo; i >= 0; i--) // Função "para" a variavel 'i' igual ao valor de "tempo", continua enquanto 'i' for maior ou igual a 0, e diminui 'i' em 1 a cada fez que rodar.
        {
            Console.Clear(); // limpa o que estava escrito anteriormente
            Console.WriteLine($"Temporizador iniciado para {tempo} horas..."); // Imprime na tela que o temporizador vai iniciar em tantos segundos
            Console.WriteLine($"Tempo restante: {i} segundos"); // Imprime na tela o tempo restante 
            Thread.Sleep(1000); // Pausa por 1 segundo
        }
		Console.Clear(); // limpa o que estava escrito anteriormente
        Console.WriteLine("Tempo esgotado!"); // Imprime na tela que o tempo acabou
        break; // Para o caso

        case 2: // Caso a pessoa escolher 2
        Console.Write("Insira o tempo para o cronômetro: "); // Imprime na tela para o usuário escolher a quantidade de tempo
        tempo = int.Parse(Console.ReadLine()); // Lê a variavel inteira "tempo"

        for (int i = 0; tempo >= i; i++) // Função "para" a variavel 'i' igual ao valor de "tempo", continua enquanto 'i' for maior ou igual a 0, e diminui 'i' em 1 a cada fez que rodar.
        {
            Console.Clear(); // limpa o que estava escrito anteriormente
            Console.WriteLine($"Cronômetro iniciado para até {tempo} segundos..."); // Imprime na tela que o cronômetro vai iniciar em tantos segundos
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
        break;
        default: // Caso a pessoa escolher outro número
        Console.WriteLine("Opção inválida!"); // Imprime na tela número inválido
        break; // Para o default
        }
        Console.WriteLine("\nDeseja continuar?");
        continuar = Console.ReadLine() == "1";
        }while(continuar);
    }
}
