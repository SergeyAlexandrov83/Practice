int HowMany()
{
    Console.WriteLine("Вы можете прекратить ввод чисел с помощью ввода слова 'STOP': ");
    int positive = 0;
    while (true)
    {
        string userInput = Console.ReadLine();
        if (userInput == "STOP")
        {
            return positive;
        }
        bool flag = true;
        foreach (char c in userInput)
        {
            if (c < '0' || c > '9')
            {
                flag = false;
                break;
            }
        }
        if (flag && userInput != "0")
        {
            positive++;
        }
    }
}

Console.WriteLine(HowMany());

