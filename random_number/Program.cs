Random random = new Random();
int num = random.Next(1, 101);

void Attempt()
{
    bool acertou = false;

    while (!acertou)
    {
        Console.Write("Digite sua tentativa de número: ");
        string attempt = Console.ReadLine();
        int attemptNum;

        if (int.TryParse(attempt, out attemptNum))
        {
            if (attemptNum > num)
            {
                Console.WriteLine(attempt + " é maior que o número aleatório.");
            }
            else if (attemptNum < num)
            {
                Console.WriteLine(attempt + " é menor que o número aleatório.");
            }
            else
            {
                Console.WriteLine("Você acertou! O número aleatório foi " + num);
                acertou = true;
            }
        }
        else
        {
            Console.WriteLine("Digite um número válido.");
        }
    }
}

Attempt();
