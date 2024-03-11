string letters = "abcdefghijklmnopqrstuvwxyz";

bool gameOver = false;
while (!gameOver)
{
    Console.WriteLine("Hello, World! Guessing Game");
    Console.WriteLine("I'm thinking of a letter, can you guess which one?");

    char secretLetter = letters[Random.Shared.Next(letters.Length)];
    List<char> guesses = [];

    bool playing = true;
    while (playing)
    {
        if (guesses.Any()) Console.WriteLine("Guesses so far: " + string.Join(", ", guesses));

        Console.WriteLine("Enter a letter");
        char guess = Console.ReadKey(true).KeyChar;
        
        Console.Clear();
        if(!char.IsAsciiLetter(guess))
        {
            Console.WriteLine("That's not a letter, try again");
            Console.WriteLine();
            continue;
        }

        guesses.Add(guess);
        if (guess == secretLetter)
        {
            Console.WriteLine($"{guess} is correct, You got it in {guesses.Count} tries");
            playing = false;
        }
        else Console.WriteLine("Nope, try again");
        
        Console.WriteLine();
    }

    Console.WriteLine("Play again? (y/n)");
    if (Console.ReadKey().KeyChar != 'y') gameOver = true;

    Console.Clear();
}
