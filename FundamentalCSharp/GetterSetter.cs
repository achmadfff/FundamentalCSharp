/*
 *      Getter Setter : 
 */

//public class Person
//{
//    private int _id;
//    private string _name;
//    private int _age;

//    public string GetName() // Hanya digunakan ketika property nya adalah private
//    {
//        return _name;
//    }
//    public void SetName(string name) // Set value ke property bertipe private
//    {
//        this._name = name;
//    }


//}

//class Program
//{
//    static void Main()
//    {
//        Person p = new Person();
//        p.SetName("Fadhil");
//        Console.WriteLine(p.GetName());
//    }
//}

//      SHORT HAND
//class Person
//{
//    public int Id { get; set; }
//    public string Name { get; set; }
//    public string Description { get; set; }
//}

//class Program
//{
//    static void Main()
//    {
//        Person p = new Person();
//        p.Id = 1;
//        p.Name= "test";
//        p.Description = "halo";

//        Console.WriteLine($"{p.Id} {p.Name} {p.Description}");
//    }
//}

//class Person
//{
//    public string Name { get; set; }
//    private int _age;
//    public int Age
//    {
//        get
//        {
//            return _age;
//        }
//    }

//    public void SetAge(int age)
//    {
//        _age = age;
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Person p = new Person();
//        p.Name = "Fadhil";
//        p.SetAge(20);

//        Console.WriteLine($"{p.Name} {p.Age}");
//    }
//}

//class Student
//{
//    private string _name;

//    public string Name
//    {
//        get { return _name; }
//        set { _name = value; }
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Student student = new Student();
//        student.Name = "Fadhil";

//        Console.WriteLine("Student Name : " + student.Name);
//    }
//}


// SETTER DENGAN VALIDASI
//class Student
//{
//    private string _name;

//    public string Name
//    {
//        get { return _name; }
//        set
//        {
//            if (value != null && value.Length > 0)
//            {
//                _name = value;
//            }
//            else
//            {
//                throw new ArgumentNullException("Null Value");
//            }
//        }
//    }
//}
//class Program
//{
//    static void Main()
//    {
//        Student student= new Student();
//        student.Name = "Fadhil";
//        Console.WriteLine(student.Name);
//        student.Name = null;
//        Console.WriteLine(student.Name);
//    }
//}

//using System.Diagnostics;

//class CalculateWeight
//{
//    private int _weight;
//    public int Weight
//    {
//        get { return _weight; }
//        set
//        {
//            if (value < 100)
//            {
//                throw new ArgumentException("Weight too small");
//            }
//            _weight = value;
//            RecalculateWeight();
//        }
//    }

//    void RecalculateWeight()
//    {
//        Console.WriteLine("Method Recalculate");
//    }
//}
//class Program
//{
//    static void Main()
//    {
//        CalculateWeight cw = new CalculateWeight();
//        cw.Weight = 101;
//        Console.WriteLine(cw.Weight);

//        cw.Weight = 50;


//    }
//}



