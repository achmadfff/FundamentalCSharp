/*
 *      ABSTRACTION : 
 *      adalah contract. Menggunakan keyword abstract. Abstract class tidak bisa di instance tapi harus di derived ke derived class
 *      Abstract class adalah class  yang tidak full di implementasi dan hanya sebagai contract.
 */

//abstract class CalculatorAbs
//{
//    protected int a;
//    protected int b;

//    public CalculatorAbs(int a, int b)
//    {
//        this.a = a;
//        this.b = b;
//    }
//    public abstract int Add(int x, int y); // Abstract Method tidak memiliki body
//    public abstract int Subtract(int x, int y);

//    public void GetString(string input)
//    {
//        Console.WriteLine("Input : " + input);
//    }

//    public int GetA() { return a; }
//    public int GetB() { return b; }
//}

//class Calculator : CalculatorAbs
//{
//    public Calculator(int a, int b) : base(a, b)
//    {
//    }

//    public override int Add(int x, int y)
//    {
//        return x + y;
//    }

//    public override int Subtract(int x, int y)
//    {
//        return x - y;
//    }
//}

//class CalculatorTwo : CalculatorAbs
//{
//    public CalculatorTwo(int a, int b) : base(a, b)
//    {
//    }

//    public override int Add(int x, int y)
//    {
//        int z = x + y;
//        return z;
//    }

//    public override int Subtract(int x, int y)
//    {
//        int z = x - y;
//        return z;
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Calculator abs = new Calculator(3,4);
//        var result = abs.Add(1, 2);
//        abs.GetString("Helloo");
//        Console.WriteLine(result);
//        Console.WriteLine(abs.Subtract(10,4));
//        Console.WriteLine(abs.GetA());

//        CalculatorTwo calculatorTwo= new CalculatorTwo(4,3);
//        int resultTwo = calculatorTwo.Add(1, 9);
//        Console.WriteLine(resultTwo);
//        Console.WriteLine(calculatorTwo.Subtract(20, 4));
//        Console.WriteLine(calculatorTwo.GetB());
//    }
//}

/*
 *      CONTOH LAIN ABSTRACTIONS
 */
//public abstract class Person
//{
//    protected string _name;
//    protected int _age;

//    public Person(string name, int age)
//    {
//        _name = name;
//        _age = age;
//    }

//    public string Name { get { return _name; } set { _name = value; } }
//    public int Age
//    {
//        get { return _age; }
//        set { _age = value; }
//    }

//    public abstract string GetOccupation();
//}

//public class Student : Person
//{
//    private string _major;
//    public Student(string name, int age, string major) : base(name, age)
//    {
//        _major = major;
//    }

//    public string Major
//    {
//        get { return _major; }
//        set { _major = value; }
//    }

//    public override string GetOccupation()
//    {
//        return "Student";
//    }
//}

//public class Teacher : Person
//{
//    private string _subject;
//    public Teacher(string name, int age, string subject) : base(name, age)
//    {
//        _subject = subject;
//    }

//    public string Subject
//    {
//        get { return _subject; }
//        set { _subject = value; }
//    }

//    public override string GetOccupation()
//    {
//        return "Teacher";
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        Student student = new Student("Fadhil", 18, "Multimedia");
//        Console.WriteLine($"{student.Name} - {student.Age} - {student.Major} - {student.GetOccupation()}");

//        Teacher teacher = new Teacher("Nani", 40, "Desain Grafis");
//        Console.WriteLine($"{teacher.Name} - {teacher.Age} - {teacher.Subject} - {teacher.GetOccupation()}");
//    }
//}

/*  Perbedaan antara Class dan Abstract Class
 *  1. Class bisa di instance, Abstract class tidak
 *  2. Class hanya ada non abstract method (method dgn body)
 *  3. Abstract class boleh ada non abstract method dan abstract method
 */