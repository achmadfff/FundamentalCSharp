/*
 *  Looping adalah perulangan block code sesuai dengan kriteria atau kondisi tertentu
 *  for, while, do-while
 *  1. for loop : digunakan untuk mengeksekusi block code sesuai dengan iterasi berupa nilai angka
 *  2. while loop : digunakan untuk eksekusi block code selama kondisinya adalah true.
 *  3. do-while loop : digunakan untuk eksekusi block code selama kondisinya adalah true.
 * 
 */

//class Program
//{
//    static void Main()
//    {
//        for (int i = 0; i < 10; i++) 
//        {
//            Console.WriteLine(i);
//        }

//        int x = 1;
//        while (x <= 4)
//        {
//            Console.WriteLine("EnigmaCamp");
//            x++;
//        }

//        int y = 21;
//        do
//        {
//            Console.WriteLine("EnigmaCamp");
//        } while (y < 21);
//    }
//}

// Nested  For
//class Program
//{
//    static void Main()
//    {
//        //for (int i = 1; i <= 3; i++)
//        //{
//        //    for (int j = 1; j <= 3; j++)
//        //    {
//        //        Console.WriteLine($"i = {i}, j = {j}");
//        //    }
//        //}

//        int x = 1;
//        int y = 1;
//        while(x <= 3)
//        {
//            while(y <= 3)
//            {
//                Console.WriteLine($"i = {x}, j = {y}");
//                y++;
//            }
//            x++;
//            y = 1;
//        }
//    }

//}

// Continue : Melanjutkan Looping
//class Program
//{
//    static void Main()
//    {
//        for (int i = 1; i <= 10; i++)
//        {
//            if (i == 4)
//            {
//                continue;
//            }
//            Console.WriteLine($"i = {i}");
//        }
//    }

// Break : Untuk menghentikan looping
//class Program
//{
//    static void Main()
//    {
//        for (int i = 1; i < 4; i++)
//        {
//            if (i == 3)
//            {
//                break;
//            }
//            Console.WriteLine("EnigmaCamp");
//        }
//    }
//}

//  For Switch statement
//class Program
//{
//    static void Main()
//    {
//        for (int i = 1; i <= 10; i++)
//        {
//            switch (i)
//            {
//                case 1:
//                case 3:
//                case 5:
//                case 7:
//                case 9:
//                    Console.WriteLine(i + " is odd");
//                    break;
//                case 2:
//                case 4:
//                case 6:
//                case 8:
//                case 10:
//                    Console.WriteLine(i + " is even");
//                    break;
//            }

//            if (i % 5 == 0 || i % 3 == 0)
//            {
//                Console.WriteLine(i + " is divisible by 3 or 5");

//            }
//        }
//    }
//}

// While logical operator
//class Program
//{
//    static void Main()
//    {
//        int x = 10;

//        while (x > 0 && x < 20) 
//        { 
//            if (x % 2 == 0)
//            {
//                Console.WriteLine(x + " is even");
//            } else
//            {
//                Console.WriteLine(x + " is odd");
//            }

//            x++;
//        }

//        Console.WriteLine("Done!");
//    }
//}

// for, while, do while, switch, if

//class Program
//{
//    static void Main()
//    {
//        int x = 20;
//        for (int i = 1; i <= 5; i++)
//        {
//            int j = 1;
//            while(j <= i)
//            {
//                if (i % j == 0 && j != 1)
//                {
//                    Console.WriteLine(i + " is not a prime number");
//                    goto Label;
//                }

//                if (j == 1)
//                {
//                    Console.WriteLine(i + " is a prime number");
//                }

//                j++;
//            }
//        Label:
//            continue;
//        }

//        do
//        {
//            switch (x)
//            {
//                case 10:
//                    Console.WriteLine("x is 10");
//                    break;
//                case 9:
//                    Console.WriteLine("x is 9");
//                    break;
//                default:
//                    Console.WriteLine("x is not 10 or 9");
//                    break;
//            }

//            if (x % 2 == 0 && x % 3 == 0)
//            {
//                Console.WriteLine(x + " is divisible by both 2 or 3");
//            }
//            else if (x % 2 == 0 || x % 3 == 0)
//            {
//                Console.WriteLine(x + " is divisible by 2 or 3");
//            }
//            else
//            {
//                Console.WriteLine(x + " is not divisible by 2 or 3");
//            }
//            x--;
//        } while (x > 0);
//        Console.WriteLine("Done");



//    }
//}