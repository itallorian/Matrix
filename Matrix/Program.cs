Console.ForegroundColor = ConsoleColor.Green;

Random random = new();
string text = string.Empty;

for(int index = 0; index < 20000; index++)
{
    if((index % 2) == 0)
    {
        text = string.Empty;

        for(int subIndex = 0; subIndex < 79; subIndex++)
        {
            int number = random.Next(5);

            if(number < 2)
            {
                text += number.ToString();
                continue;
            }

            text += " ";
        }

        Console.WriteLine(text);
    }
}
