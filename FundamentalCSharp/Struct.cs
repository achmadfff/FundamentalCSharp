//using System;

//public class Program
//{
//	static void Main()
//	{
//		/*
//		 *		Struct adalah data type yang merepresentasikan data struktur.
//		 *		mempunyai constructor, field/property, method mirip dengan class
//		 *		bedanya untuk struct digunakan untuk data yang lingkup nya kecil
//		 *		
//		 *		struct tidak memerlukan inheritance/pewarisan.
//		 *		
//		 *		struct bisa dibuat didalam class atau diluar class.
//		 */

//		Person name = new Person();
//		name.FirstName= string.Empty;
//		name.LastName= string.Empty;

//		Console.WriteLine(name.FirstName);
//        Console.WriteLine(name.LastName);

//		Person nama = new Person();
//		name.SayHello();
//		Person.SayHello2();

//    }


//}

//struct Person
//{
//	// Property : 
//	public string FirstName;
//	public string LastName;

//	public void SayHello()
//	{
//		Console.WriteLine("Hello Dunia");
//	}

//	public static void SayHello2()
//	{
//		Console.WriteLine("Hello Dunia 2");
//	}
//}