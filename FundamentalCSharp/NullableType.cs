//using System;
//using System.Runtime.InteropServices;

//public class NullableType
//{
//    public static void Main()
//    {
//        /*
//		 *		Nullable Types -> Membuat variable dengan tipe data default null
//		 *		Ada 2 Cara penggunaan nullable :
//		 *		- Nullable (Class) dengan data generic
//		 *		- tanda (?) tanda optional
//		 */

//        // CARA PERTAMA
//        Nullable<int> number = null; // <> isinya tipe data
//        Nullable<byte> numberByte = null;

//        // CARA KEDUA -> Hanya bisa explicit
//        int? numberSecond = null;
//        byte? numberByteSecond = null;
//        string? numberString = null;
//        // var? number3= null; // Error

//        // VALIDASI NULL OR NOTNULL
//        if (number.HasValue)
//        {
//            Console.WriteLine(number.Value); // Pengambilan data tanpa validasi
//        }


//        // PRINT
//        Console.WriteLine(numberSecond.GetValueOrDefault()); // Pengambilan data dengan validasi dengan default 0 jika null
//        Console.WriteLine(numberByte);
//        Console.WriteLine(numberByteSecond);

//        /*
//         *      - Nullable<T> untuk membuat tipe data menjadi null atau bisa diisi kosong terlebih dahulu
//         *      - ? Operator untuk cara singkatnya
//         *      - Kita bisa menggunakan property value untuk mengakses data nullable
//         *      - Gunakan HasValue untuk mengecek sebelum mengakses data nullable
//         */

//        // Operator ?? (Null Coalescing) : Untuk memberikan default value jika variable yang di assign adalah null
//        int? i = null;
//        var j = i ?? 10;

//    }

//    public static void SayHello(string? name)
//    {

//    }
//}
