/*
 * 
 *      METHOD
 *      Method : function, block code yang berisi statement code dalam suatu program, dimana bisa digunakan kembali (reuse)
 * 
 */

//class Program
//{
//    static int Sum(int x, int y)
//    {
//        return x + y;
//    }

//    static void Main()
//    {
//        int a = 12;
//        int b = 13;

//        int c = Sum(a, b);

//        Console.WriteLine("Hasil penjumalahan nya yaitu : " + c);
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        // Method tanpa parameter dan return type
//        // Panggil Method
//        PrintStatement();
//    }

//    static void PrintStatement()
//    {
//        Console.WriteLine("EnigmaCamp");
//    }
//}


//class Program
//{
//    static void Main()
//    {
//        // Method tanpa parameter dan dengan return type
//        int result = Sum();
//        Console.WriteLine(result);
//    }

//    static int Sum()
//    {
//        int a = 10;
//        int b = 20;

//        int c = a + b;
//        return c;
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        // Method dengan parameter dan tanpa return type
//        int a = 20;
//        int b = 30;
//        Sum(a, b);
//    }

//    static void Sum(int x, int y)
//    {                        
//        int c = x + y;       
//        Console.WriteLine(c);
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        // Method dengan parameter dan dengan return type
//        int result = Factorial(5);
//        Console.WriteLine(result);
//    }

//    static int Factorial(int n)
//    {
//        int f = 1;
//        for (int i = 1; i <= n; i++)
//        {
//            f *= i;
//        }
//        return f;
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        // Recursive : function atau method yg memanggil dirinya sendiri.
//        int result = Factorial(5);
//        Console.WriteLine(result);
//    }

//    static int Factorial(int n)
//    {
//        if (n == 0) return 1;

//        return n * Factorial(n - 1); // 5 * 4 * 3 * 2 * 1 = 120
//    }
//}