///*
// *      ENCAPSULATION : DATA HIDING
// */

//public class Person
//{
//    private string name;
//    private string age;

//    public Person(string name, string age)
//    {
//        this.name = name;
//        this.age = age;
//    }

//    public string Name
//    {
//        get { return name; }
//        set { name = value; }
//    }

//    public string Age
//    {
//        get { return age; }
//        set { age = value; }
//    }
//}

//public class Employee : Person
//{
//    private int salary;
//    private string department;

//    public Employee(string name, string age, int salary, string department) : base(name, age)
//    {
//        this.salary = salary;
//        this.department = department;
//    }

//    public int Salary
//    {
//        get { return salary; }
//        set
//        {
//            this.salary = value;
//        }
//    }

//    public string Department
//    {
//        get { return department; }
//        set { this.department = value; }
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Employee emp = new Employee("Achmad", "20", 1000000, "IT Department");

//        Console.WriteLine($"Name : {emp.Name}, Age : {emp.Age}, Salary : {emp.Salary}, Department : {emp.Department}");
//    }
//}