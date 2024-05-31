// See https://aka.ms/new-console-template for more information


//creating input for the player and input for the computer
Random random = new Random();   
int playerScore = 0;
int enemyScore = 0;

Console.WriteLine("Welcome to rock paper scissors");
while(playerScore != 3 && enemyScore != 3)
{
    Console.WriteLine("player score is " + playerScore + "enemy score " + enemyScore);
    Console.WriteLine("Please enter r for rock p for paper or anythinng for scissors");
    string playerChoice = Console.ReadLine();  
    
    int enemyChoice = random.Next(0, 3);
    if (enemyChoice == 0)
    {
        Console.WriteLine("Enemy choosed rock ");
        switch (playerChoice)
        {
            case "r":
                Console.WriteLine("tie");
                break;
            case "p":
                Console.WriteLine("Player wins the round");
                playerScore++;
                break;
            default:
                Console.WriteLine("Enemy wins the round");
                enemyScore++; break;    

        }
    }
    else if (enemyChoice == 1)
    {
        Console.WriteLine("Enemy choosed paper");
        switch(playerChoice)
        { case "r":
                Console.WriteLine("enemy won this round");
                enemyScore++;
                break;
                case "p":
                Console.WriteLine("Its a tie");
                break;
                default:
                Console.WriteLine("Player won the round");
                playerScore++;
                break;

        }
    }
    else
    {
        Console.WriteLine("Enemy choosed Scissors");
        switch(playerChoice)
        {
            case "r":
                Console.WriteLine("Playerr won this round");
                playerScore++;
                break;
            case "p":
                Console.WriteLine("Enemy won this round");
                enemyScore++;
                break;
            default:
                Console.WriteLine("Its a tie");
                break;

        }
    }
}
if (playerScore == 3)
{
    Console.WriteLine("You won");
}
else
{
    Console.WriteLine("you lost");
}