/*
 *      COLLECTION : Adalah group/pengelompokan yang berelasi dengan object yang diperlakukan seperti 1 unit.
 *      Collection bisa digunakan untuk menyimpan, mengambil dan memanipulasi data dalam sebuah  program.
 *      
 *      Keterbatasan Array:
 *      1. Size Array fix, meskipun bisa di resize via array.resize ini hanya mengcopy nilai lama ke yg baru
 *      2. Kita tidak bisa insert element di tengah2 array
 *      3. Tidak menghapus element di tengah tengah array
 *      
 *      System.Collections, System.Collections.Generic, System.Collections.Concurrent
 *      1. Size bisa bertambah secara dinamis
 *      2. Kita bisa insert data di tengah2 collection
 *      3. Kita bisa hapus element di tengah collection
 *      Non Generic Collections
 *      ArrayList, Stack, Queue, Hastable, SortedList
 *      Generic Collections
 *      List<T>, Stack<T>, Queue<T>, HashSet<T>, Dictionary, SortedList, LinkedList
 *      Concurrent Collections
 *      BlockingCollection<T>, ConcurrentBag<T>, ConcurrentStack<T>
 */

/*
 *      ArrayList : non generic collections class yg bekerja mirip seperti array tp memiliki dukungan dinamis seperti
 *      add, delete, dan update collection.
 *      ArrayList juga bisa di pakai untuk add data yang type data nya tidak diketahui.
 *      ArrayList disebut juga Dynamic Array
 *      Syntax : ArrayList arrayName = new ArrayList();
 */


//class Program
//{
//    static void Main()
//    {
//        ArrayList arrayList= new ArrayList(); // Create ArrayList
//        arrayList.Add(1); // Add int value
//        arrayList.Add("Achmad"); // Add string value
//        arrayList.Add(true);

//        var arrayList2 = new ArrayList()
//        {
//            1,"Fadhil", 100.4, true
//        };

//        foreach(var item in arrayList2)
//        {
//            Console.WriteLine(item);
//        }

//        foreach (var i in arrayList)
//        {
//            Console.WriteLine(i);
//        }
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        var arrayList = new ArrayList();
//        arrayList.Add(101);
//        arrayList.Add("Achmad Fikri");
//        arrayList.Add(true); 
//        arrayList.Add(100.4);

//        var firstElemen = arrayList[0];
//        var secondElemen = arrayList[1];

//        //Console.WriteLine(firstElemen);
//        //Console.WriteLine(secondElemen);

//        arrayList[0] = "Fadhil"; // Update Value Array List
//        var firstElementUpdate = arrayList[0];
//        //Console.WriteLine(firstElementUpdate);

//        arrayList.RemoveAt(2);
//        arrayList.Insert(0, "Salma");
//        foreach (var i in arrayList)
//        {
//            Console.WriteLine(i);
//        }

//        for(int i = 0;i< arrayList.Count;i++)
//        {
//            Console.WriteLine(arrayList[i]);
//        }
//    }
//}

//class Person
//{
//    public string Name { get; set; }
//    public int Age { get; set; }
//    public Person(string name, int age)
//    {
//        Name = name;
//        Age = age;
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        ArrayList persons = new ArrayList();
//        persons.Add(new Person("Achmad", 20));
//        persons.Add(new Person("Achmaddd", 30));
//        persons.Add(new Person("Achmadddd", 40));

//        foreach(Person person in persons)
//        {
//            Console.WriteLine($"{person.Name} - {person.Age}");
//        }

//        object[] arrayListPersons = new object[persons.Count];
//        persons.CopyTo(arrayListPersons);

//        foreach(Person person in arrayListPersons)
//        {
//            Console.WriteLine($"{person.Name} - {person.Age}");
//        }
//    }
//}

/*
 *      HASHTABLE : Dynamic collections berdasarkan key value pair
 *      Hastable hastTableName = new HasTable();
 *      
 */
//class Program
//{
//    static void Main()
//    {
//        Hashtable hashTable = new Hashtable();

//        hashTable.Add("Name", "Fadhil");
//        hashTable.Add("Salary", 1000000);
//        hashTable.Add("Location", "Paris");

//        Console.WriteLine(hashTable["Name"]);

//        foreach(DictionaryEntry s in hashTable)
//        {
//            Console.WriteLine($"{s.Key} : {s.Value}");
//        }

//    }
//}

//using System.Collections;
//class Program
//{
//    static void Main()
//    {
//        // Create Hashtable via collection initializer
//        Hashtable cities = new Hashtable()
//        {
//            {"UK","London Manchester Liverpool" },
//            {"NKRI", "Jakarta Bekasi Malang" },
//            {"India", "Mumbai New Delhi" }
//        };
//        if (cities.ContainsKey("India")) // Search Element By Key
//        {
//            cities.Remove("India"); // Menghapus Hastable By Key
//        }

//        cities["NKRI"] = "Padang, Bogor, Bandung";

//        foreach (DictionaryEntry entry in cities)
//        {
//            Console.WriteLine($"Key:{entry.Key} - Value:{entry.Value}");
//        }
//    }
//}

//using System.Collections;

//class Person
//{
//    public int Age { get; set; }
//    public string Name { get; set; }

//    public Person(int age, string name)
//    {
//        Age = age;
//        Name = name;
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Hashtable persons = new Hashtable();

//        persons.Add("Faisal", new Person(20, "Fadhil"));
//        persons.Add("Fadhil", new Person(21, "Faisal"));
//        persons.Add("Royan", new Person(22, "Royan"));
//        persons.ContainsValue(new Person(22, "Royan"));

//        persons["Royan"] = new Person(450, "Royan"); // Search by Value
//        persons.Remove("Fadhil");

//        foreach (DictionaryEntry entry in persons)
//        {
//            Person person = (Person)entry.Value;
//            Console.WriteLine($"{entry.Key} - Name: {person.Name} - {person.Age}");
//        }
//    }
//}

/*
 *      Dictionary : Mirip dengan hashtable, menggunakan key-value pair. Berbeda dgn hashtable, Dictionary itu generic
 *      Artinya kita bisa mendefinisikan type nya.
 *      Dictionary<type data, type data> = namaDictionary = new Dictionary<type data, type data>
 *      var namaDictionary = new Dictionary<type data, type data>
 */

//class Program
//{
//    static void Main(string[] args)
//    {
//        Dictionary<string, string> map = new Dictionary<string, string>()
//        {
//            {"UK", "London, Manchester, Leicester" },
//            {"USA", "Washington DC, New York, Canada" },        // Add key-value ke map using collection 
//            {"India", "Mumbai, New Delhi" }
//        };

//        foreach (KeyValuePair<string, string> pair in map)
//        {
//            Console.WriteLine($"{pair.Key} - {pair.Value}");
//        }

//        Console.WriteLine();

//        for (int i = 0; i < map.Count; i++)
//        {
//            string key = map.Keys.ElementAt(i); // Get key by index
//            string value = map[key];
//            //string value = map.Values.ElementAt(i); // Get Value key
//            Console.WriteLine($"{key} - {value}");
//        }
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        Dictionary<string, string> map = new Dictionary<string, string>();
//        map.Add("UK", "London, Manchester, Leicester");
//        map.Add("USA", "Washington DC, New York, Canada");
//        map.Add("NKRI", "Jakarta, Bandung, Surabaya");

//        map["NKRI"] = "Jakarta, Bandung, Bogor";

//        if (map.ContainsKey("USA")) // Search By Key
//        {
//            map.Remove("USA");

//        }

//        foreach (KeyValuePair<string, string> pair in map)
//        {
//            Console.WriteLine($"{pair.Key} - {pair.Value}");
//        }

//        Console.WriteLine();

//        for (int i = 0; i < map.Count; i++)
//        {
//            string key = map.Keys.ElementAt(i); // Get key by index
//            string value = map[key];
//            //string value = map.Values.ElementAt(i); // Get Value key
//            Console.WriteLine($"{key} - {value}");
//        }
//    }
//}

//class Person
//{
//    public int Id { get; set; }
//    public string Name { get; set; }

//    public Person(int id, string name)
//    {
//        Id = id;
//        Name = name;
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Dictionary<int, Person> persons = new Dictionary<int, Person>();
//        persons.Add(1, new Person(1, "Achmad"));
//        persons.Add(2, new Person(2, "Fikri"));
//        persons.Add(3, new Person(3, "Fadhilah"));

//        persons[1] = new Person(20, "Achmad");
//        persons.Remove(1);

//        foreach (KeyValuePair<int, Person> entry in persons)
//        {
//            Person person = entry.Value;
//            Console.WriteLine($"{entry.Key} - {person.Name} - {person.Id}");
//        }

//    }
//}

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
}

class Program
{
    static void Main()
    {
        Dictionary<string, Dictionary<string, Person>> personsDict = new Dictionary<string, Dictionary<string, Person>>();

        personsDict.Add("UK", new Dictionary<string, Person>
        {
            {"Fadhil", new Person("Fadhil", 20) },
            {"Faisal", new Person("Faisal", 30) },
            {"Sarah", new Person("Sarah", 25) }
        });

        personsDict.Add("USA", new Dictionary<string, Person>
        {
            {"Fadhil", new Person("Fadhil", 20) },
            {"Faisal", new Person("Faisal", 30) },
            {"Sarah", new Person("Sarah", 25) }
        });

        personsDict.Add("NKRI", new Dictionary<string, Person>
        {
            {"Fadhil", new Person("Fadhil", 20) },
            {"Faisal", new Person("Faisal", 30) },
            {"Sarah", new Person("Sarah", 25) }
        });

        personsDict["UK"]["Fadhil"] = new Person("Achmad", 29);
        personsDict["USA"].Remove("Sarah");

        foreach (KeyValuePair<string, Dictionary<string,Person>> entry in personsDict)
        {
            Console.WriteLine($"Key: {entry.Key}");
            Dictionary<string,Person> personList = entry.Value;

            foreach(KeyValuePair<string, Person> personEntry in personList)
            {
                Person person = personEntry.Value;
                Console.WriteLine($"Name: {person.Name} - Age: {person.Age}");
            }
        }
    }
}