//using System;

//public class AccessModifier
//{
//    static void main()
//    {
//        /*
//		 *		Access Modifier adalah keyword yang mengontrol aksesibilitas dari sebuah class, method, property dan lainnya dari sebuah program
//		 *		Access Modifier menentukan apakah anggota dari class itu bisa diakses dari luar atau hanya dari class itu sendiri
//		 *		
//		 *		- Public	: Access Modifier ini membuat method, property atau class bisa dipanggil dimanapun dalam sebuah program.
//		 *		- Private	: Access Modifier ini membuat method, property atau class hanya bisa dipanggil didalam class itu sendiri.
//		 *		- Protected	: Access Modifier ini membuat method, property atau class hanya bisa dipanggil didalam class itu sendiri. Atau dari
//		 *		class turunannya.
//		 *		- Internal	: Access Modifier ini membuat method, property atau class bisa dipanggil dimanapun dalam sebuah program tapi
//		 *		hanya dalam project sendiri atau assemblies sendiri.
//		 *		- Protected Internal : Gabungan internal dan protected
//		 *		
//		 *		Solution -> Projects -> File Cs, berisi class atau enum
//		 *		1 File bisa terdiri dari banyak class
//		 *		
//		 *		Solution -> Berisi 1 atau lebih project -> terdiri dari class / enum atau folder
//		 *		
//		 *		Project1 -> class Student (Internal) -> public SaveStudent
//		 *		Project2 -> Tidak bisa akses student karena Internal
//		 */

//        MyClass myClass = new MyClass(); // Create Instance / Create Object
//        var myClassVar = new MyClass();

//        var result = myClass.Addition(10, 20);
//        var resultVar = myClassVar.Addition(20,30);

//        var resultStatic = MyClass.AdditionStatic(10, 20);
//        var publicInternal = new PublicInternal();
//        publicInternal.Addition(10, 20);
//    }

//    class MyClass
//    {
//        public int Addition(int x, int y)
//        {
//            return x + y;
//        }

//        public static int AdditionStatic(int x, int y)
//        {
//            return x + y;
//        }
//    }

//}

//class PublicInternal
//{
//    public int Addition(int x, int y)
//    {
//        return x + y;
//    }
//}
