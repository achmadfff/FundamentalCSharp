///*
// *      Inheritance
// *      => Mewarisi method dan property ke class lain dari Super Class
// *      Type Inheritance
// *      1. Single Inheritance : Superclass hanya memiliki satu derived class atau child class
// *      2. Multilevel Inheritance : Superclass memiliki 1 derived class dan derived class tersebut memiliki satu derived class.
// *      3. Hierarchy Inheritance : Superclass memiliki banyak derived class.
// *      4. Multiple Inheritance : 1 Derived class memiliki banyak Superclass // TIDAK SUPPORT MULTIPLE INHERITANCE
// *      5. Hybrid Inheritance : Gabungan antara multilevel dan multiple. // TIDAK SUPPORT HYBRID INHERITANCE
// */

////class Base_Class
////{

////}
////class SubClass : Base_Class
////{

////}
////class SubSubClass : SubClass
////{

////}

////class A
////{
////    public A()
////    {
////        Console.WriteLine("Class A Constructor");
////    }

////    public void Method1()
////    {
////        Console.WriteLine("Method 1");
////    }
////    public void Method2()
////    {
////        Console.WriteLine("Method 2");
////    }


////}
////class B : A

////{
////    public B()
////    {
////        Console.WriteLine("Class B Constructor");
////    }
////    public void Method3()
////    {
////        Console.WriteLine("Method 3");
////    }

////}

////class C : B
////{
////    static void Main()
////    {
////        A a = new A();
////        a.Method1();
////        a.Method2();
////        // a.Method3(); // Tidak bisa mengakses method child

////        B obj = new B();
////        obj.Method1(); // Method milik Parent Class 
////        obj.Method2(); // Method milik Parent Class 
////        obj.Method3(); // Method milik sendiri

////        C c = new C();
////        c.Method3();
////        c.Method2();
////        c.Method1();

////        A objA;
////        B objB = new B();
////        objA = objB;
////        objA.Method1();
////        objA.Method2();

////    }
////}

////class A
////{
////    public A()
////    {
////        Console.WriteLine("Class A Constructor");
////    }

////    public void Method1()
////    {
////        Console.WriteLine("Method 1");
////    }
////    public void Method2()
////    {
////        Console.WriteLine("Method 2");
////    }


////}
////class B : A

////{
////    public B()
////    {
////        Console.WriteLine("Class B Constructor");
////    }
////    public void Method3()
////    {
////        Console.WriteLine("Method 3");
////    }

////    static void Main()
////    {
////        object obj = new object(); // Superclass
////        obj.Equals(null);

////        B b = new B();
////        b.MemberwiseClone(); // Hanya dimiliki child class yang derived dari parent class contoh nya Class A

////        A a = new A(); // Derived class
////        a.Equals(null);
////    }

////}

////class A
////{
////    public A(int num, string name)
////    {
////        Console.WriteLine("Class A Constructor! " + num);
////    }

////    public void Method1()
////    {
////        Console.WriteLine("Method 1");
////    }
////    public void Method2()
////    {
////        Console.WriteLine("Method 2");
////    }


////}
////class B : A

////{
////    public B(int num, string name) : base(num, name) // Kirim base value ke parameterized constructor A
////    {
////        Console.WriteLine("Class B Constructor");
////    }
////    public void Method3()
////    {
////        Console.WriteLine("Method 3");
////    }

////    static void Main()
////    {
////        B obj = new B(1, "fadhil");
////        obj.Method1();
////    }

////}