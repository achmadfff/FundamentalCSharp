using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

//public class Person
//{
//    public string Name { get; set; }
//    public int Age { get; set; }
//    public Person(string name, int age)
//    {
//        Name = name;
//        Age = age;
//    }

//    public override string ToString()
//    {
//        return $"Name : {Name} - Age : {Age}";

//    }
//}

//class Program
//{
//    static void Main()
//    {
//        var persons = new List<Person>();

//        while (true)
//        {
//            Console.Clear();
//            Console.WriteLine("Menu");
//            Console.WriteLine("1. Create New Person");
//            Console.WriteLine("2. Read All Person");
//            Console.WriteLine("3. Update Person");
//            Console.WriteLine("4. Delete Person");
//            Console.WriteLine("5. Exit");

//            Console.Write("Enter Your Choice: ");
//            int choice = int.Parse(Console.ReadLine());

//            switch (choice)
//            {
//                case 1:
//                    Console.WriteLine("Enter Name");
//                    string name = Console.ReadLine();
//                    Console.WriteLine("Enter Age");
//                    int age = int.Parse(Console.ReadLine());
//                    Person person = new Person(name, age);

//                    persons.Add(person);
//                    break;
//                case 2:
//                    foreach (Person p in persons)
//                    {
//                        Console.WriteLine(p.ToString());
//                    }
//                    Console.ReadKey();
//                    break;
//                case 3:
//                    Console.WriteLine("Enter Name to update: ");
//                    string updateName = Console.ReadLine();
//                    Console.WriteLine("Enter Age to update: ");
//                    int updateAge = int.Parse(Console.ReadLine());
//                    Person personToUpdate = null;
//                    foreach (var p in persons)
//                    {
//                        if (p.Name == updateName)
//                        {
//                            personToUpdate = p;
//                            break;
//                        }
//                        if (personToUpdate != null)
//                        {
//                            personToUpdate.Age = updateAge;
//                        }
//                        else
//                        {
//                            Console.WriteLine("Person not found");
//                        }
//                    }
//                    break;
//                case 4:
//                    Console.WriteLine("Enter Name to Delete: ");
//                    string deleteName = Console.ReadLine();
//                    Person personToDelete = null;

//                    foreach (Person p in persons)
//                    {
//                        if (p.Name == deleteName)
//                        {
//                            personToDelete = p;
//                            break;
//                        }
//                    }

//                    if (personToDelete != null)
//                    {
//                        persons.Remove(personToDelete);
//                    }
//                    else
//                    {
//                        Console.WriteLine("Person not found");
//                    }
//                    break;
//                case 5:
//                    return;
//            }
//        }
//    }
//}

/*
 *      Stream
 *      File : adalah koleksi data yang tersimpan didalam disk dengan nama, ekstensi, dan direktori
 *      Ketika kita membuka file di c# untuk membaca dan menulis itu disebutnya adalah stream.
 *      Stream => bentuk data berupa byte dari sumber ke destinasi untuk tujuan dibaca dan ditulis.
 *      System.IO
 *      Filestream, BinaryReader, BinaryWriter, StreamReader, StreamWriter dll.
 */

//class Program
//{
//    static void Main()
//    {   
//        // Define nama file dan file path
//        string filePath = @"C:\TestFile\myFile.txt";

//        // Create file via Filestream
//        FileStream fs = new FileStream(filePath, FileMode.Create);
//        fs.Close(); // Fs di close
//        Console.WriteLine("File myFile.txt sudah dibuat");
//    }
//}

// Open and Write
//class Program
//{
//    static void Main()
//    {
//        string filePath = @"C:\TestFile\myFile.txt";
//        // Membuka dan memberikan fs mode untuk menulis data ke file
//        byte[] byteData = Encoding.Default.GetBytes("C# adalah bahasa pemrograman OOP");
//        // Merubah string menjadi byte array, karena fs.write hanya terima byte[] array
//        FileStream fs = new FileStream(filePath, FileMode.Append);
//        fs.Write(byteData, 0, byteData.Length);
//        fs.Close();
//        Console.WriteLine("Sukses menambahkan isi file myFile.txt");
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        string filePath = @"C:\TestFile\myFile.txt";
//        string data;

//        // fs menjadi open dengan hak akses adalah read
//        FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
//        // fs kita ubah menjadi stream yang akan dibaca oleh StreamReader
//        using (var sr = new StreamReader(fs))
//        {
//            data = sr.ReadToEnd(); // Read file hingga akhir
//        }

//        fs.Close(); // Close Filestream
//        fs.Dispose(); // Remove all buffers dari memori

//        Console.WriteLine(data);
//    }
//}

// Delete File
//class Program
//{
//    static void Main()
//    {
//        string filePath = @"C:\TestFile\myFile.txt";
//        var fs = File.Open(filePath,FileMode.OpenOrCreate);
//        File.Delete(filePath);
//    }
//}

/*
    *  STREAMWRITER adalah class di .Net yang menyediakan text-based stream untuk menulis karakter ke sebuah file
    *  Write(), WriteLine(), WriteAsync()
 */

//class Program
//{
//    static void Main(string[] args)
//    {
//        string filePath = @"C:\TestFile\myFile2.txt";

//        // Membuat file via System.IO yang kemudian di assign ke StreamWriter
//        StreamWriter sw = File.CreateText(filePath);
//        // Menulis ke streamwriter
//        sw.WriteLine("Hello from c#");
//        sw.WriteLine("EnigmaCamp");
//        // Tutup Stream
//        sw.Close();
//        // Remove buffer dr memory
//        sw.Dispose();

//        Console.WriteLine("Sukses menambahkan text");

//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        string filePath = @"C:\TestFile\myFile2.txt";
//        StreamWriter sw = new StreamWriter(filePath); // Menimpa file yang sudah ada

//        Console.WriteLine("Masukan text yang ingin di tulis ke file : ");
//        string strText = Console.ReadLine();
//        sw.WriteLine(strText);
//        sw.Flush();
//        sw.Close();
//        sw.Dispose();

//    }
//}

//class Program
//{
//    static void Main()
//    {
//        string filePath = @"C:\TestFile\myFile2.txt";

//        int a, b, c;
//        a = 15;
//        b = 20;
//        c = a + b;

//        StreamWriter sw = new StreamWriter(filePath);
//        sw.Write($"Sum dari {a} + {b} = {c}");
//        sw.Flush();
//        sw.Close();
//        sw.Dispose();
//        Console.WriteLine("Saved");
//    }
//}

/*
 *      StreamReader
 */

//class Program
//{
//    static void Main()
//    {
//        string filePath = @"C:\TestFile\myFile.txt";

//        StreamReader sr = new StreamReader(filePath);

//        Console.WriteLine("Isi dari myFile.txt");
//        // Digunakan untuk membaca stream dari awal file
//        sr.BaseStream.Seek(0, SeekOrigin.Begin);
//        // read stream ke string
//        string strFile = sr.ReadLine();
//        // Baca semua isi dr stream secara baris per baris
//        while (strFile != null)
//        {
//            Console.WriteLine(strFile);
//            strFile = sr.ReadLine();
//        }

//        sr.Close();
//        sr.Dispose();
//    }
//}

/*
 *      StreamReader and StreamWriter
 */
//class Program
//{
//    static void Main()
//    {
//        string filePath = @"C:\TestFile\myFile.txt";

//        using (StreamWriter sw = new StreamWriter(filePath))
//        {
//            sw.WriteLine("StreamWriter in C#");
//            sw.WriteLine("Bootcamp .Net EnigmaCamp");

//        };

//        using (StreamReader sr = new StreamReader(filePath))
//        {
//            Console.WriteLine(sr.ReadToEnd());
//        };
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        string filePath = @"C:\TestFile\myFile.txt";
//        // StreamWriter
//        using (StreamWriter sw = new StreamWriter(filePath))
//        {
//            var names = new List<string>()
//            {
//                "Achmad", "Fikri", "Fadhilah"
//            };

//            sw.WriteLine("Nama:");
//            foreach (string name in names)
//            {
//                sw.WriteLine(name);
//            }
//            var phoneNumber = new Dictionary<int, string>(){
//                {1001, "Achmad" },
//                {1002, "Fikri" },
//                {1003, "Fadhilah" }
//            };
//            sw.WriteLine("Phone Numbers:");
//            foreach (var phone in phoneNumber)
//            {
//                sw.WriteLine($"{phone.Key}-{phone.Value}");
//            }
//        }
//        // StreamReader
//        using (StreamReader sr = new StreamReader(filePath))
//        {
//            var names = new List<string>();
//            sr.ReadLine();
//            string line;
//            while ((line = sr.ReadLine()) != null && line != "Nama:")
//            {
//                names.Add(line);
//            }

//            var phoneNumbers = new Dictionary<int, string>();
//            sr.ReadLine();
//            while ((line = sr.ReadLine()) != null && line != "Phone Numbers:")
//            {
//                string[] parts = line.Split('-');
//                int key = int.Parse(parts[0]);
//                string value = parts[1];
//                phoneNumbers.Add(key, value);
//            }
//            Console.WriteLine("Names:");
//            foreach (string name in names)
//            {
//                Console.WriteLine(name);
//            }
//            Console.WriteLine("Phone Numbers:");
//            foreach (var phone in phoneNumbers)
//            {
//                Console.WriteLine($"{phone.Key}-{phone.Value}");
//            }
//            //Console.WriteLine(sr.ReadToEnd());
//        }
//    }
//}

/*
 *      File Class
 *      Reading, Writing, Menambah
 *      Dipakai untuk : Membuat File, Copy File, Memindahkan File, dan Menghapus File.  Juga dia bekerja dengan FileStream.
 *      Method = Copy, Create, Decrypt, Delete, Encrypt, Open, Move, Exist, dll
 */
//class Program
//{
//    static void Main()
//    {
//        string filePath = @"C:\TestFile\myFile.txt";

//        // Check jika file ada atau tidak
//        if (File.Exists(filePath))
//        {
//            Console.WriteLine("File Exist in Directory");
//        }
//        else
//        {
//            Console.WriteLine("File Does Not Exist in Directory");
//        }
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        string filePath = @"C:\TestFile\myFile.txt";

//        if (File.Exists(filePath))
//        {
//            // Membaca isi file dan diubah menjadi string array
//            string[] lines = File.ReadAllLines(filePath);
//            // Read per line dan ditampilkan ke console
//            foreach (var line in lines)
//            {
//                Console.WriteLine(line);
//            }
//        }
//        else
//        {
//            Console.WriteLine("File Does Not Exist");
//        }
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        string filePath = @"C:\TestFile\myFile.txt";

//        if(File.Exists(filePath))
//        {
//            // Membuka file dan membaca file kemudian ditutup
//            string lines = File.ReadAllText(filePath);
//            Console.WriteLine(lines);
//        }
//        else
//        {
//            Console.WriteLine("File Doesn't exist");
//        }
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        string filePath = @"C:\TestFile\myFile.txt";
//        string fileCopyPath = @"C:\TestFile\myFileCopy.txt";

//        if (File.Exists(filePath))
//        {
//            // Melakukan Copy file ke destination lalu overwrite bila true
//            // Jika pakai argumen true makan akan menimpa file yang sudah ada
//            File.Copy(filePath, fileCopyPath,true);
//            string lines = File.ReadAllText(fileCopyPath);
//            Console.WriteLine(lines);
//        }
//        else
//        {
//            Console.WriteLine("File Doesn't exist");
//        }
//    }
//}
//class Program
//{
//    static void Main()
//    {
//        string filePath = @"C:\TestFile\myFile.txt";

//        if (File.Exists(filePath))
//        {
//            string[] contents = { "Achmad", "Fikri", "Fadhilah" };
//            // Akan melakukan overwrite pada file yang sudah ada
//            File.WriteAllLines(filePath, contents);
//            Console.WriteLine("File Created");
//            // Membaca semua line
//            string lines = File.ReadAllText(filePath);
//            Console.WriteLine(lines);
//        }
//        else
//        {
//            Console.WriteLine("File Doesn't exist");
//        }
//    }
//}
// TextWriter dan TestReader
//class Program
//{
//    static void Main()
//    {
//        string filePath = @"C:\TestFile\myFile.txt";
//        string lines;
//        using(TextReader tr = File.OpenText(filePath))
//        {
//            lines = tr.ReadToEnd();
//            Console.WriteLine(lines);
//        }
//        using (TextWriter writer = File.CreateText(filePath))
//        {
//            writer.WriteLine("C# EFCore");
//            writer.WriteLine("C# REST API");
//        }
//        Console.WriteLine("File Write Success");

//        using (TextReader reader = File.OpenText(filePath))
//        {
//            Console.WriteLine(reader.ReadToEnd());
//        }
//    }
//}

/*
 *  BinaryWriter dan BinaryReader
 *  Salah satu cara menyimpan file ke binary format
 */
// Write BinaryWriter
//class Program
//{
//    static void Main()
//    {
//        string filePath = @"C:\TestFile\myBinary.txt";
//        // Melakukan pembuatan file via filestream
//        using (FileStream fs = new FileStream(filePath,FileMode.Create))
//        // Menggunakan binarywriter ke filestream
//        using(BinaryWriter bw = new BinaryWriter(fs))
//        {
//            bw.Write("C# Fundamental Enigmacamp");
//            bw.Write(12345);
//        }
//        Console.WriteLine("Success");
//    }
//}

/*      BinaryReader
 *      penyimpanan pada binarywriter adalah secara primitive sesuai dengan tipe datanya
 *      binary reader akan membaca sesuai dengan tipe datanya
 *      Akan membaca tipe data per line
 */
//class Program
//{
//    static void Main()
//    {
//        string filePath = @"C:\TestFile\myBinary.txt";
//        // Menggunakan binarywriter ke filestream
//        using (BinaryWriter bw = new BinaryWriter(File.Open(filePath, FileMode.Create)))
//        {
//            bw.Write("C# Fundamental Enigmacamp");
//            bw.Write(12345);
//        }
//        // Menggunakan binarywriter ke filestream
//        using (BinaryReader br = new BinaryReader(File.Open(filePath, FileMode.Open)))
//        {
//            string s = br.ReadString();
//            int i = br.ReadInt32();
//            Console.WriteLine(s);
//            Console.WriteLine(i);
//        }
//        Console.WriteLine("Success");
//    }
//}

// MENYIMPAN OBJECT VIA BINARYWRITER DAN BINARYREADER
//class Program
//{
//    // Serialisasi adalah proses mengubah object atau class menjadi format yg bisa disimpan atau ditransmit.
//    // Ketika object atau class diserialisasi, semua nilai yang ada di object tersebut akan di transformasi ke xml,json, atau biner atau ke db
//    [Serializable] // Attribut di C# yg mengindikasikan bahwa object atau class ini bisa di serialisasi
//    class Person
//    {
//        public string Name { get; set; }
//        public int Age { get; set; }
//        public Person(string name, int age)
//        {
//            Name = name;
//            Age = age;
//        }
//    }
//    static void Main()
//    {

//        string filePath = @"C:\TestFile\myFile.txt";

//        var person = new Person("Achmad", 20);
//        // Membuka file untuk di write
//        using (FileStream fs = File.OpenWrite(filePath))
//        // Melakukan 
//        using (BinaryWriter bw = new BinaryWriter(fs))
//        {
//            BinaryFormatter formatter = new BinaryFormatter();
//            // Serialisasi object person ke basestream punya binarywriter
//            // Kemudian disimpan via FileStream
//            formatter.Serialize(bw.BaseStream, person);
//        }

//        // Membuka file untuk dibaca
//        using(FileStream fs = File.OpenRead(filePath))
//        // Melakukan pembacaan binary via filestream
//        using(BinaryReader reader = new BinaryReader(fs))
//        {
//            BinaryFormatter formatter  = new BinaryFormatter();
//            // Deserialiasi binary data via binaryreader ke object person
//            // Menggunakan type casting
//            Person readPerson = (Person)formatter.Deserialize(reader.BaseStream);

//            Console.WriteLine($"{readPerson.Name} - {readPerson.Age}");
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
//    static readonly string filePath = @"C:\TestFile\myFile.txt";
//    public static void Main()
//    {
//        Person person = new Person("Fikri", 20);
//        SavePerson(person);

//        Person readPerson = ReadPerson();
//        Console.WriteLine($"{readPerson.Name} - {readPerson.Age}");
//    }

//    static void SavePerson(Person person)
//    {
//        using (StreamWriter writer = new StreamWriter(new FileStream(filePath, FileMode.Open, FileAccess.Write)))
//        {
//            string line = string.Format("{0},{1}", person.Name, person.Age);
//            writer.WriteLine(line);
//        }
//    }

//    static Person ReadPerson()
//    {
//        using (StreamReader reader = new StreamReader(new FileStream(filePath, FileMode.Open, FileAccess.Read)))
//        {
//            string line = reader.ReadLine();
//            string[] persons = line.Split(',');
//            string name = persons[0];
//            int age = int.Parse(persons[1]);

//            return new Person(name, age);
//        }
//    }
//}

//public class Person
//{
//    public string FirstName { get; set; }
//    public string LastName { get; set; }
//    public int Age { get; set; }
//    public Person(string firstName, string lastName, int age)
//    {
//        FirstName = firstName;
//        LastName = lastName;
//        Age = age;
//    }
//}

//public class Program
//{
//    private static List<Person> people = new List<Person>();
//    private static readonly string filePath = @"C:\TestFile\myPersons.txt";
//    public static void Main()
//    {
//        while (true)
//        {
//            Console.Clear();
//            Console.WriteLine("Menu");
//            Console.WriteLine("1. Create Person");
//            Console.WriteLine("2. Read People");
//            Console.WriteLine("3. Update Person");
//            Console.WriteLine("4. Delete Person");
//            Console.WriteLine("5. Exit");
//            Console.Write("Enter Your Choice: ");
//            int choice = int.Parse(Console.ReadLine());
//            Console.WriteLine();
//            switch (choice)
//            {
//                case 1:
//                    CreatePerson();
//                    break;
//                case 2:
//                    ReadPeople();
//                    break;
//                case 3:
//                    UpdatePerson();
//                    break;
//                case 4:
//                    DeletePerson();
//                    break;
//                case 5:
//                    return;
//                default:
//                    Console.WriteLine("Invalid Choice. Try Again");
//                    break;
//            }
//        }
//    }
//    public static void CreatePerson()
//    {
//        Console.Write("Enter First Name: ");
//        string firstName = Console.ReadLine();

//        Console.Write("Enter Last Name: ");
//        string lastName = Console.ReadLine();

//        Console.Write("Enter Age");
//        int age = int.Parse(Console.ReadLine());

//        Person person = new Person(firstName, lastName, age);

//        people.Add(person);

//        SavePeople();
//    }
//    public static void ReadPeople()
//    {
//        LoadPeople();

//        Console.WriteLine("People: ");
//        foreach (Person person in people)
//        {
//            Console.WriteLine($"{person.FirstName} {person.LastName} Age: {person.Age}");
//        }

//        Console.ReadKey();
//    }
//    private static void UpdatePerson()
//    {
//        LoadPeople();

//        Console.Write("Enter index of person to update: ");
//        int index = int.Parse(Console.ReadLine());

//        Console.Write("Enter First Name: ");
//        string firstName = Console.ReadLine();

//        Console.Write("Enter Last Name: ");
//        string lastName = Console.ReadLine();

//        Console.Write("Enter Age");
//        int age = int.Parse(Console.ReadLine());

//        Person person = new Person(firstName, lastName, age);

//        people[index] = person;

//        SavePeople();

//    }
//    private static void DeletePerson()
//    {
//        LoadPeople();

//        Console.Write("Enter index of person to update: ");
//        int index = int.Parse(Console.ReadLine());

//        people.RemoveAt(index);

//        SavePeople();
//    }
//    private static void SavePeople()
//    {
//        if (File.Exists(filePath))
//        {
//            using (StreamWriter sw = new StreamWriter(new FileStream(filePath,FileMode.OpenOrCreate,FileAccess.ReadWrite)))
//            {
//                foreach (Person person in people)
//                {
//                    sw.WriteLine($"Name: {person.FirstName} {person.LastName} - Age: {person.Age}");
//                }
//            }

//        }
//    }

//    private static void LoadPeople()
//    {
//        people.Clear();

//        if (File.Exists(filePath))
//        {
//            using (StreamReader sr = new StreamReader(new FileStream(filePath, FileMode.Open, FileAccess.Read)))
//            {
//                while(!sr.EndOfStream)
//                {
//                    string lines = sr.ReadLine();
//                    string[] parts = lines.Split(',');

//                    string firstName = parts[0];
//                    string lastName = parts[1];
//                    int age = int.Parse(parts[2]);

//                    Person person = new Person(firstName, lastName, age);
//                    people.Add(person);
//                }
//            }
//        }
//    }
//}

class Program
{
    static void Main()
    {
        string fileName = "myFile.txt";
        // Akan mendapatkan path dari current directory punya si app.exe
        // c:\TestFiles\
        string appPath = AppDomain.CurrentDomain.BaseDirectory;
        // Join appPath dgn filename
        string filePath = Path.Combine(appPath, fileName);

        using (StreamWriter sw = new StreamWriter(filePath))
        {
            sw.WriteLine("Mencoba Dynamic Path");
        }
    }
}