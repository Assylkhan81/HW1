// По двум заданным числам проверять является ли первое квадратом второго
    Console.WriteLine("Введите 1-ое число ");
    int numberA = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите 2-ое число ");
    int numberB = Convert.ToInt32(Console.ReadLine());
    if (numberA == numberB * numberB)
        {
            Console.WriteLine("Da");
        }
    else 
        {
            Console.WriteLine("net");
        }