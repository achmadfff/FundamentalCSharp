/*
 *      ABSTRACTION : 
 *      adalah contract. Menggunakan keyword abstract. Abstract class tidak bisa di instance tapi harus di derived ke derived class
 *      Abstract class adalah class  yang tidak full di implementasi dan hanya sebagai contract.
 */

abstract class CalculatorAbs
{
    protected int a;
    protected int b;

    public CalculatorAbs(int a, int b)
    {
        this.a = a;
        this.b = b;
    }
    public abstract int Add(int x, int y); // Abstract Method tidak memiliki body

    public void GetString(string input)
    {
        Console.WriteLine("Input : " + input);
    }

    public int GetA() { return a; }
    public int GetB() { return b; }
}

class Calculator : CalculatorAbs
{
    public Calculator(int a, int b) : base(a, b)
    {
    }

    public override int Add(int x, int y)
    {
        return x + y;
    }
}

class CalculatorTwo : CalculatorAbs
{
    public CalculatorTwo(int a, int b) : base(a, b)
    {
    }

    public override int Add(int x, int y)
    {
        int z = x + y;
        return z;
    }
}

class Program
{
    static void Main()
    {
        Calculator abs = new Calculator(3,4);
        var result = abs.Add(1, 2);
        abs.GetString("Helloo");
        Console.WriteLine(result);
        Console.WriteLine(abs.GetA());

        CalculatorTwo calculatorTwo= new CalculatorTwo(4,3);
        int resultTwo = calculatorTwo.Add(1, 9);
        Console.WriteLine(resultTwo);
        Console.WriteLine(calculatorTwo.GetB());
    }
}