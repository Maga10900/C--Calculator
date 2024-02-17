int secim = 1;
int dovr = 0;
do
{
    Console.Clear();
    if (secim == 1)
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("[1] => Start Calcualtor");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("[2] => About");
        Console.WriteLine("[3] => Exit");
    }
    else if (secim == 2)
    {
        Console.WriteLine("[1] => Start Calcualtor");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("[2] => About");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("[3] => Exit");
    }
    else if (secim == 3)
    {
        Console.WriteLine("[1] => Start Calcualtor");
        Console.WriteLine("[2] => About");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("[3] => Exit");
        Console.ForegroundColor = ConsoleColor.White;
    }

    ConsoleKeyInfo info = Console.ReadKey(true);
    switch (info.Key)
    {
        case ConsoleKey.UpArrow:
            {
                if (secim == 1)
                {
                    secim = 3;
                }
                else
                {
                    secim--;
                }
                break;
            }

        case ConsoleKey.DownArrow:
            {
                if (secim == 3)
                {
                    secim = 1;
                }
                else
                {
                    secim++;
                }
                break;
            }

        case ConsoleKey.Enter:
            {
                if (secim == 1)
                {
                    Console.Clear();
                    int result = 0;
                    int cur_res = 0;
                    string s_num;
                    string s_num2;
                    int num = 0;
                    int num2 = 0;
                    int secim2 = 1;

                    Console.Write("Ilk ededi daxil edin: ");
                    s_num = Console.ReadLine();
                    Console.Write("Ikinci ededi daxil edin: ");
                    s_num2 = Console.ReadLine();
                    int once;
                    num = int.Parse(s_num);
                    num2 = int.Parse(s_num2);
                    once = num + num2;
                    int iterasiya = 0;
                    do
                    {
                        if(iterasiya == 0)
                        {
                            cur_res = once;
                        }
                        Console.Clear();
                        Console.WriteLine($@"
========================================================
                        {cur_res}   
========================================================");

                        if (secim2 == 1)
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("Toplama (Addition)");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("Cixma (Subtraction)");
                            Console.WriteLine("Vurma (Multiplication)");
                            Console.WriteLine("Bölme (Division)");
                        }
                        else if (secim2 == 2)
                        {
                            Console.WriteLine("Toplama (Addition)");
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("Cixma (Subtraction)");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("Vurma (Multiplication)");
                            Console.WriteLine("Bölme (Division)");
                        }
                        else if (secim2 == 3)
                        {
                            Console.WriteLine("Toplama (Addition)");
                            Console.WriteLine("Cixma (Subtraction)");
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("Vurma (Multiplication)");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("Bölme (Division)");
                        }
                        else if (secim2 == 4)
                        {
                            Console.WriteLine("Toplama (Addition)");
                            Console.WriteLine("Cixma (Subtraction)");
                            Console.WriteLine("Vurma (Multiplication)");
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("Bolme (Division)");
                            Console.ForegroundColor = ConsoleColor.White;
                        }

                        ConsoleKeyInfo info2 = Console.ReadKey(true);
                        switch (info2.Key)
                        {
                            case ConsoleKey.UpArrow:
                                {
                                    if (secim2 == 1)
                                    {
                                        secim2 = 4;
                                    }
                                    else
                                    {
                                        secim2--;
                                    }


                                    {
                                        if (secim2 == 1)
                                        {
                                            num = int.Parse(s_num);
                                            num2 = int.Parse(s_num2);
                                            cur_res = num + num2;
                                        }
                                        else if (secim2 == 2)
                                        {
                                            num = int.Parse(s_num);
                                            num2 = int.Parse(s_num2);
                                            cur_res = num - num2;
                                        }
                                        else if (secim2 == 3)
                                        {
                                            num = int.Parse(s_num);
                                            num2 = int.Parse(s_num2);
                                            cur_res = num * num2;
                                        }
                                        else if (secim2 == 4)
                                        {
                                            num = int.Parse(s_num);
                                            num2 = int.Parse(s_num2);
                                            if (num2 != 0)
                                            {
                                                cur_res = num / num2;
                                            }
                                            else
                                            {
                                                cur_res = -999999999;
                                            }
                                        }
                                    }
                                    break;
                                }

                            case ConsoleKey.DownArrow:
                                {
                                    if (secim2 == 4)
                                    {
                                        secim2 = 1;
                                    }
                                    else
                                    {
                                        secim2++;
                                    }


                                    {
                                        if (secim2 == 1)
                                        {
                                            num = int.Parse(s_num);
                                            num2 = int.Parse(s_num2);
                                            cur_res = num + num2;
                                        }
                                        else if (secim2 == 2)
                                        {
                                            num = int.Parse(s_num);
                                            num2 = int.Parse(s_num2);
                                            cur_res = num - num2;
                                        }
                                        else if (secim2 == 3)
                                        {
                                            num = int.Parse(s_num);
                                            num2 = int.Parse(s_num2);
                                            cur_res = num * num2;
                                        }
                                        else if (secim2 == 4)
                                        {
                                            num = int.Parse(s_num);
                                            num2 = int.Parse(s_num2);
                                            if (num2 != 0)
                                            {
                                                cur_res = num / num2;
                                            }
                                            else
                                            {
                                                cur_res = -999999999;
                                            }
                                        }
                                    }
                                    break;
                                }
                                    
                                    
                            case ConsoleKey.Enter:
                                {
                                    result = cur_res;
                                    break;
                                }
                        }
                        iterasiya++;
                    } while (result == 0);
                }


                else if (secim == 2)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(@"Salam bu sade bir calculatordur, hansi ki siz bu calculator uzerinde sade emeliyyatlar apara bilersiniz. Ilk olaraq menudan 'Start Calculator' secimini secin. Daha sonra ilk ededinizi daxil edin, bundan sonra ikinci ededi daxil edin. Sonra ise emeliyati secin ve yaxidda cursor ile uzerine gelin. Siz bu sayede cavabi gore bileceksiniz.
                              Qeyd: 0-a bolme emeliyati yoxdur. 
             Eger sifira bolme emeliyati etseniz neticeni '-999999999' alacaqsiniz. Buda error demekdir.

                                                                                    By: Fatullayev Muhammad");
                    Console.ForegroundColor = ConsoleColor.White;

                    Thread.Sleep(5000);
                    break;
                }
                else if (secim == 3)
                {
                    Console.WriteLine("Program ended!");
                    Thread.Sleep(1000);
                    dovr = -1;
                    break;
                }
            }

            break;
    }

} while (dovr != -1);