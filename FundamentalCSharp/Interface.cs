/*
 *      INTERFACE : Class yang tidak di implementasikan secara menyeluruh
 *      Interface hanya kontrak yang digunakan untuk mendeklarasi banyak method dari sebuah object.
 *      Jadi kita bisa mendefinisikan abstract class secara menyeluruh dan hanya mendefinisikan HANYA abstract method.
 *      Keyword = interface
 *      
 *      Interface adalah kontrak yang harus diimplementasikan ke child class nya
 *      Interface bisa di implementasi ke banyak class
 *      Interface tidak bisa ada Constructor
 *      Interface tidak boleh ada fields/variable
 */

//interface ICalculator // Interface harus menggunakan "I" di depan namanya
//{
//    int Add(int a, int b);
//    int Subtract(int a, int b);
//    int Multiply(int a, int b);
//    int Divide(int a, int b);

//    void GetData()
//    {
//        Console.WriteLine("Method from interface");
//    }
//}

//public class Calculator : ICalculator
//{
//    public int Add(int a, int b)
//    {
//        return a + b;
//    }

//    public int Divide(int a, int b)
//    {
//        return (a / b);
//    }

//    public int Multiply(int a, int b)
//    {
//        return a * b;
//    }

//    public int Subtract(int a, int b)
//    {
//        return a - b;
//    }

//    public void PrintConsole()
//    {
//        Console.WriteLine("Method from calculator class");
//    }
//}

//public class CalculatorTwo : ICalculator
//{
//    public int Add(int a, int b)
//    {
//        return a + a + b;
//    }

//    public int Divide(int a, int b)
//    {
//        return (a / b) * a;
//    }

//    public int Multiply(int a, int b)
//    {
//        return a * b * b;
//    }

//    public int Subtract(int a, int b)
//    {
//        return a - b - b;
//    }

//    public void PrintConsole()
//    {
//        Console.WriteLine("Method from calculator two class");
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Calculator calculator = new Calculator(); // Meng implementasikan Interface ke dalam Class, Hanya Method didalam Class
//        int resultAdd = calculator.Add(1, 2);
//        var resultSubtract = calculator.Subtract(10, 2);
//        var resultDivide = calculator.Divide(10, 2);
//        var resultMultiply = calculator.Multiply(10, 2);
//        calculator.PrintConsole();

//        Console.WriteLine($"Add : {resultAdd} - Subtract : {resultSubtract} - Divide : {resultDivide} - Multiply : {resultMultiply}");

//        CalculatorTwo calculator2 = new CalculatorTwo(); // Meng implementasikan Interface ke dalam Class, Hanya Method didalam Class
//        int resultAdd2 = calculator2.Add(20, 2);
//        var resultSubtract2 = calculator2.Subtract(20, 2);
//        var resultDivide2 = calculator2.Divide(2, 2);
//        var resultMultiply2 = calculator2.Multiply(20, 2);
//        calculator2.PrintConsole();
//        Console.WriteLine($"Add : {resultAdd2} - Subtract : {resultSubtract2} - Divide : {resultDivide2} - Multiply : {resultMultiply2}");

//        ICalculator iCalc = new Calculator(); // Meng implementasikan Interface ke dalam Class, Hanya Method didalam Interface
//        int resultAddICalc = iCalc.Add(1, 2);
//        var resultSubtractICalc = iCalc.Subtract(10, 2);
//        var resultDivideICalc = iCalc.Divide(10, 2);
//        var resultMultiplyICalc = iCalc.Multiply(10, 2);
//        iCalc.GetData();
//        Console.WriteLine($"Add : {resultAddICalc} - Subtract : {resultSubtractICalc} - Divide : {resultDivideICalc} - Multiply : {resultMultiplyICalc}");
//    }
//}

//interface IPerson
//{
//    string Name { get; set; }
//    int Age { get; set; }
//    string GetInfo();
//}

//class Person : IPerson
//{
//    protected string _name;
//    protected int _age;

//    public Person(string name, int age)
//    {
//        _name= name;
//        _age= age;
//    }
//    public string Name
//    {
//        get { return _name; }
//        set { _name = value; }
//    }
//    public int Age
//    {
//        get { return _age; }
//        set { _age = value; }
//    }

//    public virtual string GetInfo()
//    {
//        return $"Name : {_name}, Age : {_age}";
//    }
//}

//class Employee : Person
//{
//    private int _salary;
//    private string _department;
//    public Employee(string name, int age, int salary, string department) : base(name, age)
//    {
//        this._salary = salary;
//        this._department = department;
//    }

//    public int Salary
//    {
//        get { return _salary; }
//        set { _salary = value; }
//    }

//    public string Department
//    {
//        get { return _department; }
//        set { _department = value; }
//    }

//    public override string GetInfo()
//    {
//        return $"{base.GetInfo()} - Salary: {_salary} - Department: {_department}";
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Employee emp = new Employee("Achmad", 20, 1000000, "IT");
//        Console.WriteLine(emp.GetInfo());

//        Person pers = new Person("Achmad", 20);
//        Console.WriteLine(pers.GetInfo());

//        IPerson person = new Employee("Achmad", 20, 1000000, "IT");
//        Console.WriteLine(person.GetInfo());
//    }
//}

//interface IDrawable
//{
//    void Draw();

//}

//abstract class Shape : IDrawable
//{

//    public abstract double Area();
//    public void Draw()
//    {
//        Console.WriteLine("Drawing Shape....");
//    }
//}

//class Circle : Shape
//{
//    private double _radius;

//    public Circle(double radius)
//    {
//        this._radius = radius;
//    }
//    public override double Area()
//    {
//        return Math.PI * _radius * _radius;
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Circle c = new Circle(10);
//        Console.WriteLine(c.Area());
//        c.Draw();

//        IDrawable d = new Circle(10);
//        // var iArea = d.Area(); // Error karena bukan milik interface
//        d.Draw();

//        Shape s = new Circle(10);
//        Console.WriteLine(s.Area());
//        s.Draw();
//    }
//}

//public interface IWorkable
//{
//    int WorkHours
//    { get; set; }
//    void work();
//}

//public abstract class Person : IWorkable
//{
//    protected string _name;
//    protected int _age;
//    protected int _workHours;

//    public Person(string name, int age)
//    {
//        _name = name;
//        _age = age;
//    }

//    public string Name
//    {
//        get { return _name; }
//        set { _name = value; }
//    }

//    public int Age
//    {
//        get { return _age; }
//        set { _age = value; }
//    }

//    public int WorkHours
//    {
//        get { return _workHours; }
//        set { _workHours = value; }
//    }

//    public void work()
//    {
//        Console.WriteLine($"{_name} is working for {_workHours} hours.");
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
//        return $"Student";
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
//    static void Main()
//    {
//        Student student = new Student("Achmad", 20, "Multimedia");
//        student.WorkHours = 10;
//        Console.WriteLine($"{student.GetOccupation()}: {student.Name} - Age: {student.Age} - Major: {student.Major}");
//        student.work();

//        Teacher teacher = new Teacher("Indra", 30, "Ngoding");
//        teacher.WorkHours = 10;
//        Console.WriteLine($"{teacher.GetOccupation()}: {teacher.Name} - Age: {teacher.Age} - Subject: {teacher.Subject}");
//        teacher.work();
//    }
//}

//interface ICalculatorA
//{
//    int Add(int a, int b);
//}

//interface ICalculatorB
//{
//    int Multiply(int a, int b);
//}

//class Calculator : ICalculatorA, ICalculatorB
//{
//    public int Add(int a, int b)
//    {
//        return a + b;
//    }

//    public int Multiply(int a, int b)
//    {
//        return (a * b);
//    }
//}
//class Program
//{
//    static void Main(string[] args)
//    {
//        Calculator calculator = new Calculator();
//        var resultAdd = calculator.Add(1, 2);
//        Console.WriteLine(resultAdd);
        
//        ICalculatorA calcA = new Calculator();
//        var resultAddA = calcA.Add(4, 2);
//        Console.WriteLine(resultAddA);

//        ICalculatorB calcB = new Calculator();
//        var resultMultiplyB = calcB.Multiply(4, 2);
//        Console.WriteLine(resultMultiplyB);
//    }
//}