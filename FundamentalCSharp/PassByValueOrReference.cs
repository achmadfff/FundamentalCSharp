//class Program
//{
//    static void Main()
//    {
//        // Pass by value : 
//        /*
//         * 
//         *      Pass by value : Ketika kita passing argument/parameter ke dalam method, copy value ke parameter dan di
//         *      lempar ke method, itu tidak mengubah nilai aslinya.
//         * 
//         */

//        var a = 100;
//        var b = PassByValue(a);

//        Console.WriteLine(a);
//        Console.WriteLine(b);

//    }

//    static int PassByValue(int a)
//    {
//        return a * 10;
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        // Pass by reference : 
//        /*
//         * 
//         *      Pass by reference : Ketika kita passing argument/parameter ke dalam method.
//         *      Reference atau variabel aslinya akan berubah
//         * 
//         */

//        var a = 100;
//        Console.WriteLine($"Nilai a sebelum pass ke method: {a}");
//        var b = PassByReference(ref a);
//        Console.WriteLine($"Nilai a setelah pass ke method: {a}");
//        Console.WriteLine($"Nilai b: {b}");

//    }

//    static int PassByReference(ref int b)
//    {
//        return b *= 10;
//    }
//}