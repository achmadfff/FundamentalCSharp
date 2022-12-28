/*
 *      OOP : Object Oriented Programming
 *      Paradigma pemrograman yang berorientasi object.
 *      OOP di C# melibatkan class, dimana class adalah template dari object dan membuat object dari class tersebut.
 *      di C# Class adalah template dari object yang mendefinisikan properties(data), dan behaviors(Method) dr sebuah object.
 *      Object di instance/create menggunakan perintah new.
 *      OOP Membuat developer dapat membuat aplikasi yang kompleks dengan melakukan organisasi code menjadi reusable object.
 */

/*
 *      POLYMORPHISM : Banyak bentuk
 *      Adalah konsep dimana kita bisa melakukan taks/perintah dengan berbagai cara.
 *      Yaitu ketika satu entity berperilaku berbeda tergantung dari kondisi atau kasusnya.
 *      Person => Student (Dikelas)
 *      Person => Customer (Dimall0
 *      Person => Passenger (Dimobil)
 *      Polymorphism di C# bisa di implementasikan dengan 4 cara:
 *      1. Method Overloading
 *      2. Operator Overloading
 *      3. Method Overriding
 *      4. Method Hiding
 *      
 */
// ====================================================================================================================================
/*
 *      1. Method Overloading
 *      Adalah banyak method dengan nama yang sama dalam 1 class yang sama dengan parameter yang berbeda.
 *      Method yang dipanggil sesuai dengan parameter yang dikirimkan.
 */

//class MethodOverloading
//{
//    public void Method()
//    {
//        Console.WriteLine("1st Method");
//    }
//    public void Method(int i)
//    {
//        Console.WriteLine("2nd Method");
//    }
//    public void Method(string i)
//    {
//        Console.WriteLine("3rd Method");
//    }
//    public void Method(int i, string j)
//    {
//        Console.WriteLine("4th Method");
//    }

//}
//class Program
//{
//    static void Main()
//    {
//        MethodOverloading obj = new MethodOverloading();
//        obj.Method();
//        obj.Method(1);
//        obj.Method("1");
//        obj.Method(1, "1");
//    }
//}

//class PrintData
//{
//    void Print(int i)
//    {
//        Console.WriteLine("Print " + i);
//    }
//    void Print(double i)
//    {
//        Console.WriteLine("Print " + i);
//    }
//    void Print(string i)
//    {
//        Console.WriteLine("Print " + i);
//    }

//    static void Main()
//    {
//        PrintData p = new PrintData();
//        p.Print(100);
//        p.Print(100.200);
//        p.Print("Helo");
//    }
//}

// ====================================================================================================================================
/*
 *      2. Operator Overloading
 *      -> Redefined behavior (method) dari sebuah operator
 */
//class Complex
//{
//    public double Real { get; set; }
//    public double Imaginary { get; set; }

//    public Complex(double real, double imaginary)
//    {
//        Real = real;
//        Imaginary = imaginary;
//    }

//    public static Complex operator +(Complex a, Complex b)
//    {
//        return new Complex(a.Real + b.Real, a.Imaginary + b.Imaginary);
//    }

//    public static Complex operator *(Complex a, Complex b)
//    {
//        return new Complex(a.Real * b.Real - b.Imaginary * a.Imaginary, a.Real * b.Imaginary - b.Real * a.Imaginary);
//    }

//    public override string ToString()
//    {
//        return $"{Real} {Imaginary}";
//    }
//}

//class Program
//{
//    static void Main()
//    {

//        Complex c1 = new Complex(1, 2);
//        Complex c2 = new Complex(3, 4);

//        Complex c3 = c1 + c2;
//        Complex c4 = c1 * c2;

//        Console.WriteLine(c3.ToString());
//        Console.WriteLine(c3);
//        Console.WriteLine(c4.ToString());
//        Console.WriteLine(c4);

//    }


//}
// ====================================================================================================================================
/*
 *      3. Method Overriding
 *      -> Mendefinisikan ulang method parent, apabila class child menginginkan implementasi yg berbeda.
 */

//class Animal  // Base class (parent) 
//{
//    public virtual void AnimalSound() // Keyword virtual agar method bisa di override
//    {
//        Console.WriteLine("The animal makes a sound");
//    }
//}

//class Pig : Animal  // Derived class (child) 
//{
//    public override void AnimalSound() // Keyword override sebagai info bahwa method tersebut merupakan override dari parent
//    {
//        Console.WriteLine("The pig says: wee wee");
//    }
//}

//class Dog : Animal  // Derived class (child) 
//{
//    public override void AnimalSound() // Keyword override sebagai info bahwa method tersebut merupakan override dari parent
//    {
//        Console.WriteLine("The dog says: bow wow");
//    }
//}

//class Cat : Animal // Tidak mengoverride method parent
//{
//    // No overrid parents
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        Animal myAnimal = new Animal();  // Create a Animal object
//        Animal myPig = new Pig();  // Create a Pig object
//        Animal myDog = new Dog();  // Create a Dog object

//        myAnimal.AnimalSound();
//        myPig.AnimalSound();
//        myDog.AnimalSound();
//    }
//}

/*
 *      Contoh Studi Kasus
 *      Jika employee = Developer maka dapat kenaikan gaji atau bonus sebanyak 50.000 / 20%
 *      Jika employee = Manager maka dapat kenaikan gaji atau bonus sebanyak 50.000 / 25%
 *      Jika employee = Admin maka dapat kenaikan gaji atau bonus sebanyak 50.000 / 20%
 */
//public class Employee{
//    public int Id { get; set; }
//    public string Name { get; set; }
//    public string Position { get; set; }
//    public double Salary{ get; set; }

//    public virtual double CalculateBonus(double Salary)
//    {
//        return 50000;
//    }
//}

//public class Developer : Employee
//{
//    public override double CalculateBonus(double Salary)
//    {
//        double baseSalary = base.CalculateBonus(Salary);
//        double calculatedSalary = Salary * .20;
//        if (baseSalary >= calculatedSalary)
//        {
//            return baseSalary;
//        }
//        else
//        {
//            return calculatedSalary;
//        }
//    }
//}

//public class Manager : Employee
//{
//    public override double CalculateBonus(double Salary)
//    {
//        double baseSalary = base.CalculateBonus(Salary);
//        double calculatedSalary = Salary * .25;
//        if (baseSalary >= calculatedSalary)
//        {
//            return baseSalary;
//        }
//        else
//        {
//            return calculatedSalary;
//        }
//    }
//}

//public class Admin : Employee
//{

//}

//class Program
//{
//    static void Main()
//    {
//        Employee emp1 = new Developer
//        {
//            Id= 1,
//            Name= "Achmad",
//            Position="Developer",
//            Salary= 500000
//        };
//        double bonus = emp1.CalculateBonus(emp1.Salary);
//        Console.WriteLine("Id = {0}, Nama = {1}, Posisi = {2}, Bonus = {3}",emp1.Id,emp1.Name,emp1.Position, bonus);

//        Employee emp2 = new Manager
//        {
//            Id = 2,
//            Name = "Fikri",
//            Position = "Manager",
//            Salary = 800000
//        };
//        bonus = emp2.CalculateBonus(emp2.Salary);
//        Console.WriteLine("Id = {0}, Nama = {1}, Posisi = {2}, Bonus = {3}", emp2.Id, emp2.Name, emp2.Position, bonus);

//        Employee emp3 = new Admin
//        {
//            Id = 3,
//            Name = "Fadhilah",
//            Position = "Admin",
//            Salary = 5000
//        };
//        bonus = emp3.CalculateBonus(emp3.Salary);
//        Console.WriteLine("Id = {0}, Nama = {1}, Posisi = {2}, Bonus = {3}", emp3.Id, emp3.Name, emp3.Position, bonus);
//    }
//}
//}
// ====================================================================================================================================
/*
 *      4. Method Hiding
 *      -> Mendefinisikan ulang method parent, apabila class child menginginkan implementasi yg berbeda.
 */
//public class Parent
//{
//    public virtual void Show()
//    {
//        Console.WriteLine("Parent Class Show Method");
//    }

//    public void Display()
//    {
//        Console.WriteLine("Parent Class Display Method");
//    }
//}

//public class Child : Parent
//{
//    // Method Hiding menggunakan keyword new
//    public new void Show()
//    {
//        Console.WriteLine("Child Class Show Method");
//    }

//    // Method hiding without using new keyword
//    // Dapat warning "Use new keyword if hiding is intended"
//    public void Display()
//    {
//        Console.WriteLine("Child Class Display Method");
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Parent parent= new Parent();
//        Child child= new Child();

//        parent.Show();
//        parent.Display();
//        child.Show();
//        child.Display();
//    }
//}

//public class Parent
//{
//    public virtual void Show()
//    {
//        Console.WriteLine("Parent Class Show Method");
//    }

//    public void Display()
//    {
//        Console.WriteLine("Parent Class Display Method");
//    }
//}

//public class Child  : Parent
//{
//    public override void Show()
//    {
//        Console.WriteLine("Child Class Show Method");
//    }

//    public new void Display()
//    {
//        Console.WriteLine("Child Class Display Method");
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Child obj = new Child();
//        obj.Show();
//        obj.Display();
//    }
//}