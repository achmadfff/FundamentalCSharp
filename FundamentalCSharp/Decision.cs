/*
 * Decision adalah pengambilan keputusan dalam sebuah pemrograman yang digunakan untuk mengontrol jalannya program / aplikasi
 * if, if-else, if-else if, nested-if, switch, dan nested switch
 */
//class Program
//{
//    static void Main()
//    {

//        string name = "EnigmaCamp";
//        if (name == "EnigmaCamp")
//        {
//            Console.WriteLine("EnigmaCamp Printed")
//        }

//        Console.ReadKey();
//    }
//}

//If Else
//class Program
//{
//    static void Main()
//    {
//        string name = "EnigmaCamp";
//        if (name == "EnigmaCamp")
//        {
//            Console.WriteLine("EnigmaCamp Printed");
//        } else
//        {
//            Console.WriteLine("Bukan EnigmaCamp");
//        }

//        Console.ReadKey();
//    }
//}

//IF Else If
//class Program
//{
//    static void Main()
//    {
//        int i = 20;
//        if (i == 10)
//            Console.WriteLine("i is 10");
//        else if (i == 15)
//            Console.WriteLine("i is 15");
//        else if (i == 20)
//            Console.WriteLine("i is 20");
//        else
//            Console.WriteLine("i is not present");
//    }
//}

// Nested If
//class Program
//{
//    static void Main()
//    {
//        int i = 10;
//        if (i == 10)
//        {
//            if (i < 12) 
//            { 
//            Console.WriteLine("i is smaller than 12");
//            }
//            else
//            {
//                Console.WriteLine("i is greater than 12");
//            }
//        }
//        else
//        {
//            Console.WriteLine("i is not equal 10");
//        }
//    }
//}

// Complex Nested If
//class Program
//{
//    static void Main()
//    {
//        int x = 5;
//        int y = -5;
//        int z = -5;

//        if (x > 0)
//        {
//            if (y > 0)
//            {
//                if (z > 0)
//                {
//                    Console.WriteLine("x, y, z is positive");
//                }
//                else
//                {
//                    Console.WriteLine("x, y is positive and z is negative");
//                }
//            }
//            else
//            {
//                if (z > 0)
//                {
//                    Console.WriteLine("x and z is positive but y is negative");
//                }
//                else
//                {
//                    Console.WriteLine("x is positive but y and z is negative");
//                }
//            }
//        }
//        else
//        {
//            if (y > 0)
//            {
//                if (z > 0)
//                {
//                    Console.WriteLine("x is negative but y, z is positive");
//                }
//                else
//                {
//                    Console.WriteLine("x, z is negative, but y is positive");
//                }
//            }
//            else
//            {
//                if (z > 0)
//                {
//                    Console.WriteLine("x and y is negative but z is positive");
//                }
//                else
//                {
//                    Console.WriteLine("x, y, z is negative");
//                }
//            }
//        }
//    }
//}


//class Program
//{
//    static void Main()
//    {
//        /*
//         * Swtich adalah struktur kontrol didalam pemrograman dimana membolehkan kita untuk memilih opsi yang berbeda 
//         * atau disebut dengan cases. Switch bisa digunakan selain dr if else 
//         */
//        int x = 30;
//        switch (x)
//        {
//            case 10:Console.WriteLine("10");break; 
//            case 20:Console.WriteLine("20");break;
//            case 30: Console.WriteLine("30"); break;
//            default: Console.WriteLine("Not matchs");break;
//        }
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        /*
//         * Swtich adalah struktur kontrol didalam pemrograman dimana membolehkan kita untuk memilih opsi yang berbeda 
//         * atau disebut dengan cases. Switch bisa digunakan selain dr if else 
//         */
//        int x = 30;
//        switch (x)
//        {
//            case 30: 
//                Console.WriteLine("25");
//                switch (x - 10)
//                {
//                    case 20:
//                        Console.WriteLine("20");
//                        switch (x - 15)
//                        {
//                            case 15:
//                                Console.WriteLine("15");
//                                break;
//                        }
//                        break;
//                }
//                break;
//            case 20: 
//                Console.WriteLine("20"); 
//                break;
//            case 10: 
//                Console.WriteLine("30"); 
//                break;
//            default: 
//                Console.WriteLine("Not matchs"); 
//                break;
//        }
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        /*
//         * Swtich adalah struktur kontrol didalam pemrograman dimana membolehkan kita untuk memilih opsi yang berbeda 
//         * atau disebut dengan cases. Switch bisa digunakan selain dr if else 
//         */
//        int x = 5;
//        int y = 2;
//        int z = -3;

//        switch (x)
//        {
//            case > 0:
//                if (y > 0)
//                {
//                    switch (z)
//                    {
//                        case > 0:
//                            Console.WriteLine("x,y,z are positive");
//                            break;
//                        default:
//                            Console.WriteLine("xosados");
//                            break;
//                    }
//                }
//                else
//                {
//                    switch (z)
//                    {
//                        case > 0:
//                            Console.WriteLine("x positive, y negative, z positive");
//                            break;
//                            default:
//                            Console.WriteLine("x positive, y negative, z negative");
//                            break;
//                    }
//                }
//                break;
//        }
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        int x = 5;
//        int y = 10;

//        switch(x > 0 && y > 0)
//        {
//            case true:
//                Console.WriteLine("True");
//                break;
//                case false:
//                Console.WriteLine("False");
//                break;
//        }
//        switch (x > 0 || y > 0)
//        {
//            case true:
//                Console.WriteLine("True");
//                break;
//            case false:
//                Console.WriteLine("False");
//                break;
//        }
//        switch (!(x > 0 || y > 0))
//        {
//            case true:
//                Console.WriteLine("True");
//                break;
//            case false:
//                Console.WriteLine("False");
//                break;
//        }
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        int x = 5;
//        int y = -10;
//        int z = 15;
//        int w = 20;

//        switch (x > 0 || !(y>0))
//        {
//            case true:
//                if(!(z > 0) && (w > 0 || x > 0))
//                {
//                    Console.WriteLine("sdasdsadas");
//                }
//                else
//                {
//                    Console.WriteLine("dsadasd");
//                }
//                break;
//            case false:
//                Console.WriteLine("asdasdsads");
//                break;
//        }
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        int x = 2;
//        switch(x)
//        {
//            case 1:
//                Console.WriteLine("Hello");
//                goto default;
//                case 2:
//                Console.WriteLine("Case 2");
//                goto case 3;
//                case 3:
//                Console.WriteLine("Case 3");
//                goto default;
//                default: 
//                Console.WriteLine("Entered Value is" + x);
//                break;
//        }
//    }
//}