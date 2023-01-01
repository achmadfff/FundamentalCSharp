/*
 *      ARRAY
 *      adalah koleksi item yang tersimpan secara terstruktur didalam block memory dengan tipe data yang sama.
 *      Setiap item dalam array dinamakan elemen, dan setiap elemen dalam array memiliki posisi yang disebut index.
 *      Array digunakan untuk menyimpan koleksi data, seperti list nama, list nomor.
 *      type[] arrayName <-- Syntax deklarasi array
 *      type <-- string,integer,double dll
 *      int[] numbers
 *      type[] arrayName = {value1,value2,value3, ... }
 */


//class Program
//{
//    static void Main()
//    {
//        int[] ints = { 1, 2, 3, 4, 5, 6, }; // Array dengan inisialisasi diawal
//        int[] arrNum = new int[5]; // Deklarasi menentukan range elemen array.
//        arrNum[0] = 1; // Assign value pada index tertentu didalam array.
//        arrNum[1] = 2;
//        arrNum[2] = 3;
//        arrNum[3] = 4;
//        arrNum[4] = 5;

//        Console.WriteLine(arrNum[0]); // Mengakses langsung array dengan index

//        for (int i = 0; i < arrNum.Length; i++)
//        {
//            Console.Write(arrNum[i] + " "); // Menggunakan variable i dari looping
//        }

//        int j = 0;
//        while (j < arrNum.Length)
//        {
//            Console.WriteLine("\n" + arrNum[j]);
//            j++;
//        }

//    }
//}

//class Program
//{
//    static void Main()
//    {
//        int[] numbers;
//        numbers = new int[] {1,2,3,4,5};

//        for (int i = 0; i < numbers.Length; i++)
//        {
//            Console.WriteLine(numbers[i]);
//        }
//    }
//}
//class Program
//{
//    static void Main()
//    {
//        int[] numbers = new int[5];
//        numbers[0] = 1;
//        numbers[1] = 2;
//        numbers[2] = 3;
//        numbers[3] = 4;
//        numbers[4] = 5;


//        for (int i = 0; i < numbers.Length; i++)
//        {
//            numbers[2] = 100; // Merubah nilai array pada index
//            Console.WriteLine(numbers[i]);
//        }
//    }
//}


//class Program
//{
//    static void Main()
//    {
//        int[] numbers = new int[5];

//        for (int i = 0; i < numbers.Length; i++)
//        {
//            Console.Write("Masukkan nilai array ke " + i + " : ");
//            numbers[i] = Convert.ToInt32(Console.ReadLine()); // Assign value elemen array
//        }

//        numbers[4] = 4; // Reassign Elemen array

//        for(int j = 0; j < numbers.Length; j++)
//        {
//            Console.Write(numbers[j] + " "); // Display
//        }
//    }
//}

//class Program
//{
//    static void Main()
//{
//        // 0x00003h2
//        int[] numbers = new int[5];

//        numbers[0] = 1;
//        numbers[1] = 2;
//        numbers[2] = 3;
//        numbers[3] = 4;
//        numbers[4] = 5;

//        // 0x00001h2
//        Array.Resize(ref numbers, 10);
//        //Menduplikat memory array yang lama ke memori array yang baru, yang sudah ditentukan

//        numbers[5] = 6;
//        numbers[6] = 7;
//        numbers[7] = 8;
//        numbers[8] = 9;
//        numbers[9] = 10;

//        for (int i = 0; i < numbers.Length; i++)
//        {
//            Console.WriteLine(numbers[i]);
//        }
//}
//}

//class Program
//{
//    static void Main()
//    {
//        // 0x00003h2
//        int[] numbers = new int[5];

//        numbers[0] = 5;
//        numbers[1] = 2;
//        numbers[2] = 1;
//        numbers[3] = 3;
//        numbers[4] = 4;

//        Console.WriteLine("Sebelum di sort");
//        for (int i = 0; i < numbers.Length; i++)
//        {
//            Console.WriteLine(numbers[i]);
//        }

//        Array.Sort(numbers);

//        Console.WriteLine("Setelah di sort");
//        for (int i = 0; i < numbers.Length; i++)
//        {
//            Console.WriteLine(numbers[i]);
//        }
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        string[] weekDays;
//        weekDays = new string[] { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };

//        foreach (string day in weekDays) // Foreach di c#
//        {
//            Console.Write(day + " ");
//        }
//    }
//}

//Multidimensi Array
//class Program
//{
//    static void Main()
//    {
//        /*
//         *      Syntax type[,] arrayName
//         *      int[,] arrayName // Deklarasi Array 2Dimensi
//         *      type[,] arrayName = {{value1, value2, value3},{value4, value5, value6}}
//         *      1 2 3
//         *      4 5 6
//         *      7 8 9
//         *      int[,] arrayName = {{1,2,3},{4,5,6},{7,8,9}}
//         * 
//         */

//        int[,] numbers = new int[3, 3];

//        numbers[0,0] = 1;
//        numbers[0,1] = 2;
//        numbers[0,2] = 3;
//        numbers[1,0] = 4;
//        numbers[1,1] = 5;
//        numbers[1,2] = 6;
//        numbers[2,0] = 7;
//        numbers[2,1] = 8;
//        numbers[2,2] = 9;

//        for(int i = 0; i < numbers.GetLength(0); i++) 
//        { 
//            for (int j = 0; j < numbers.GetLength(1); j++)
//            {
//                Console.Write(numbers[i,j] + " ");
//            }

//            Console.WriteLine(); 
//        }
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        int[] numbers = { 1, 2, 3, 4, 5 };

//        // & << untuk mendapatkan lokasi memori
//        for (int i = 0; i < numbers.Length; i++)
//        {
//            Console.WriteLine(numbers[i]);
//        }
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        var numbers = new[] { 1, 2, 3, 4 };

//        var tests = new dynamic[] { 1, "r", 2 }; //

//      // anotherNumbers = numbers; Copy by reference

//        var anotherNumbers = new int[numbers.Length];

//        Array.Copy(numbers, anotherNumbers, numbers.Length); // Copy by value

//        anotherNumbers[0] = 10;

//        Console.WriteLine("Numbers");
//        foreach (var number in numbers)
//        {
//            Console.Write($"{number} ");
//        }

//        Console.WriteLine("\nAnother Numbers");
//        foreach (var anotherNumber in anotherNumbers)
//        {
//            Console.Write($"{anotherNumber} ");
//        }

//        Console.WriteLine("\nDynamic Array");
//        foreach (var test in tests)
//        {
//            Console.WriteLine(test);
//        }
//    }
//}