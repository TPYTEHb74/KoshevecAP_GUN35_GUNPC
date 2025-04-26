using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

[Serializable]
class PlayerProfile
{
    public string Name { get; set; }
    public int Bank { get; set; } = 1000; // Начальный банк
    public const int MaxBank = 2000; // Максимально допустимый банк
}

class GameManager
{
    private PlayerProfile player;
    private readonly string profilePath = "player.dat";

    public void Run()
    {
        Console.WriteLine("Добро пожаловать в казино!");

        

        

        SelectGame();

        Console.WriteLine($"Спасибо за игру, {player.Name}! До свидания!");
        
    }

    

    private void SelectGame()
    {
        Console.WriteLine("\nВыберите игру:");
        Console.WriteLine("1. Блэкджек (21)");
        Console.WriteLine("2. Кости");
        Console.WriteLine("3. Выход");

        int choice;
        while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 3)
        {
            Console.WriteLine("Неверный ввод. Попробуйте снова.");
        }

        if (choice == 3) return;

        Console.WriteLine($"\nВаш текущий банк: {player.Bank}");
        int bet = GetBet();

        bool won = false;
        bool draw = false;

        switch (choice)
        {
            case 1:
                (won, draw) = PlayBlackjack();
                break;
            case 2:
                (won, draw) = PlayDice();
                break;
        }

        ProcessGameResult(bet, won, draw);

        if (player.Bank > 0)
        {
            SelectGame(); // Продолжаем играть
        }
        else
        {
            Console.WriteLine("No money? Kicked!");
        }
    }

    private int GetBet()
    {
        int bet;
        while (true)
        {
            Console.Write("Сделайте ставку: ");
            if (!int.TryParse(Console.ReadLine(), out bet) || bet <= 0)
            {
                Console.WriteLine("Неверная ставка. Попробуйте снова.");
                continue;
            }

            if (bet > player.Bank)
            {
                Console.WriteLine("Ставка превышает ваш банк. Попробуйте снова.");
                continue;
            }

            break;
        }
        return bet;
    }

    private (bool won, bool draw) PlayBlackjack()
    {
        Console.WriteLine("\nИграем в блэкджек!");
        Random rand = new Random();

        int playerScore = rand.Next(15, 22);
        int computerScore = rand.Next(15, 22);

        Console.WriteLine($"Ваши карты: {playerScore}");
        Console.WriteLine($"Карты компьютера: {computerScore}");

        if (playerScore > computerScore && playerScore <= 21)
        {
            return (true, false);
        }
        else if (playerScore == computerScore)
        {
            return (false, true);
        }
        else
        {
            return (false, false);
        }
    }

    private (bool won, bool draw) PlayDice()
    {
        Console.WriteLine("\nИграем в кости!");
        Random rand = new Random();

        int playerRoll = rand.Next(1, 7) + rand.Next(1, 7);
        int computerRoll = rand.Next(1, 7) + rand.Next(1, 7);

        Console.WriteLine($"Ваш бросок: {playerRoll}");
        Console.WriteLine($"Бросок компьютера: {computerRoll}");

        if (playerRoll > computerRoll)
        {
            return (true, false);
        }
        else if (playerRoll == computerRoll)
        {
            return (false, true);
        }
        else
        {
            return (false, false);
        }
    }

    private void ProcessGameResult(int bet, bool won, bool draw)
    {
        if (draw)
        {
            Console.WriteLine("Ничья! Ставка возвращена.");
            return;
        }

        if (won)
        {
            player.Bank += bet;
            Console.WriteLine($"Поздравляем! Вы выиграли {bet}. Ваш банк: {player.Bank}");

            if (player.Bank > PlayerProfile.MaxBank)
            {
                int excess = player.Bank - PlayerProfile.MaxBank;
                player.Bank = PlayerProfile.MaxBank / 2;
                Console.WriteLine($"You wasted half of your bank money in casino's bar. Ваш банк теперь: {player.Bank}");
                Console.WriteLine($"Вы разорили казино! На вашем месте построят новое. Вы получили бонус: {excess}");
            }
        }
        else
        {
            player.Bank -= bet;
            Console.WriteLine($"Вы проиграли {bet}. Ваш банк: {player.Bank}");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        GameManager game = new GameManager();
        game.Run();
    }
}