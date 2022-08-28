// По двум заданным числам проверять является ли первое квадратом второго
    // Console.WriteLine("Введите 1-ое число ");
    // int numberA = Convert.ToInt32(Console.ReadLine());
    // Console.WriteLine("Введите 2-ое число ");
    // int numberB = Convert.ToInt32(Console.ReadLine());
    // if (numberA == numberB * numberB)
    //     {
    //         Console.WriteLine("Da");
    //     }
    // else 
    //     {
    //         Console.WriteLine("net");
    //     }

// По заданному номеру дня недели вывести его название
    // Console.WriteLine("Введите число от 1 до 7");
    // int week = Convert.ToInt32(Console.ReadLine());
    // if (week == 1)
    //     {
    //         Console.WriteLine("Monday");
    //     }
    // else if (week == 2)
    //     {
    //         Console.WriteLine("Tuesday");
    //     }
    // else if (week == 3)
    //     {
    //         Console.WriteLine("Wednesday");
    //     }
    // else if (week == 4)
    //     {
    //         Console.WriteLine("Thursday");
    //     }
    // else if (week == 5)
    //     {
    //         Console.WriteLine("Friday");
    //     }
    // else if (week == 6)
    //     {
    //         Console.WriteLine("Saturday");
    //     }
    // else if (week == 7)
    //     {
    //         Console.WriteLine("Sunday");
    //     }

// Найти максимальное из трех чисел
    // int max;
    // Console.Write("Введите 1-ое число: ");
    // int numb1 = Convert.ToInt32(Console.ReadLine());
    // Console.Write("Введите 2-ое число: ");
    // int numb2 = Convert.ToInt32(Console.ReadLine());
    // Console.Write("Введите 3-ье число: ");
    // int numb3 = Convert.ToInt32(Console.ReadLine());
    // if (numb1 > numb2 && numb1 > numb3)
    //     {
    //         //Console.WriteLine("max = " + numb1);
    //         max = numb1;
    //     }
    // else if (numb2 > numb1 && numb2 > numb3)
    //     {
    //         //Console.WriteLine("max = " + numb2);
    //         max = numb2;
    //     }
    // else
    //     {
    //         //Console.WriteLine("max = " + numb3);
    //         max = numb3;
    //     }
    //         Console.WriteLine(max);
            
// Выяснить является ли число чётным
    // Console.Write("Введите число: ");
    // int number = Convert.ToInt32(Console.ReadLine());
    // if (number % 2 == 1)
    //     {
    //         Console.WriteLine("Нечетное");
    //     }
    // else
    //     {
    //         Console.WriteLine("Четное");
    //     }

// Показать четные числа от 1 до N (через  "while" не получилось, надо потренироваться)
    // Console.Write("Введите N: ");
    // int N = Convert.ToInt32(Console.ReadLine());
    // for (int i = 1; i <= N; i++)
    // if (i % 2 == 0)
    // Console.WriteLine(i);

// Показать вторую цифру трёхзначного числа
    // Console.Write("Введите n: ");
    // int n = Convert.ToInt32(Console.ReadLine());
    // n /= 10;
    // var r = n % 10;
    // Console.WriteLine(r);

// Дано число из отрезка [10, 99]. Показать наибольшую цифру числа
    // Console.Write("Введите число от 10 до 99: ");
    // int n = Convert.ToInt32(Console.ReadLine());
    // var r = n % 10;
    // n /= 10;
    // if (r > n)
    //     {
    //         Console.WriteLine(r);
    //     }
    // else Console.WriteLine(n);

// Удалить вторую цифру трёхзначного числа (Здесь мне помог интернет, не все понял)    
    // Console.Write("Введите трехзначное число: ");
    // int number = Convert.ToInt32(Console.ReadLine());;
    // int delete = 2;
    // var str = number.ToString();
    // number = int.Parse(str.Remove(str.Length - delete, 1));
    // Console.WriteLine(number);

// Выяснить, кратно ли число заданному, если нет, вывести остаток.
    int ostatok;
    Console.Write("Введите заданное число: ");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите кратное число: ");
    int r = Convert.ToInt32(Console.ReadLine());
    ostatok = n % r;
    if (ostatok == 0)
        {
            Console.WriteLine("Является");
        }
    else Console.WriteLine("Остаток = " + ostatok);
