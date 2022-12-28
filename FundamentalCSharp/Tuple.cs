//using System;

//public class Program
//{
//	public static void Main()
//	{
//		/*
//		 *		Tuple termasuk struktur data di C#, Gunanya untuk menyimpan beberapa data lebih dari satu mirip dengan array tapi lebih dinamis
//		 *		Value Tuple
//		 * 
//		 */

//		// EXPLICIT
//		var person = Tuple.Create(1, "Achmad", "Fikri");
//		// IMPLICIT
//		Tuple<int, string, string> person2 = Tuple.Create(1, "Achmad", "Fikri");

//        var numbers1 = Tuple.Create(1, 2, 3, 4, 5, 6, 7, 8);
//        var numbers2 = Tuple.Create(1, 2, 3, 4, 5, 6, 7, Tuple.Create(8, 9, 10, 11, 12, 13));
//        var numbers = (1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14);


//        Console.WriteLine(numbers1.Rest); // (8)
//		Console.WriteLine(numbers1.Rest.Item1); // 8
//        Console.WriteLine(numbers2.Rest.Item1.Item1); // 8

//        var person = (1, "Bill", "Gates");
//    }

//    // TUPLE SEBAGAI PARAMETER
//    static void DisplayTuple(Tuple<int, string, string> person)
//    {
//        Console.WriteLine(person.Item1);
//        Console.WriteLine(person.Item2);
//        Console.WriteLine(person.Item3);
//    }


//    // TUPLE SEBAGAI RETURN METHOD
//    static Tuple<int, string, string> GetPerson(int id, string firstName, string lastName)
//    {
//        return Tuple.Create(id, firstName, lastName);
//    }

//    // VALUE TUPLE
//    static (int min, int max) FindMinMax()
//    {
//        return (1, 10);
//    }

//    static void DisplayTupleE((int id,string firstName, string lastName) person)
//    {
//        Console.WriteLine(person.Item1);
//        Console.WriteLine(person.Item2);
//        Console.WriteLine(person.Item3);
//    }


//}
