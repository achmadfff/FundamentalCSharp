//class Program
//{
//    static void Main()
//    {
//        try
//        {
//            Console.Write("NILAI A: ");
//            int a = Convert.ToInt32(Console.ReadLine());
//            Console.Write("NILAI B: ");
//            int b = Convert.ToInt32(Console.ReadLine());
//            int c;

//            c = a / b;
//            Console.WriteLine(c);

//        }
//        catch (DivideByZeroException ex)
//        {
//            Console.WriteLine($"Message : {ex.Message}");
//            Console.WriteLine($"Source : {ex.Source}");
//            Console.WriteLine("Some Error Ocurred");
//        }
//        catch (FormatException ex)
//        {
//            Console.WriteLine($"Message : {ex.Message}");
//            Console.WriteLine($"Source : {ex.Source}");
//            Console.WriteLine("Some Error Ocurred");
//        }
//        finally
//        {
//            Console.WriteLine("This is finally Exception");
//        }
//    }
//}

//class Program
//{
//    static void MethodEnigma()
//    {
//        try
//        {
//            Console.WriteLine("Inside MethodEnigma");
//            int a = 10; int b = 0;
//            int c = a / b;
//            Console.WriteLine(c);
//        }
//        finally
//        {
//            Console.WriteLine("MethodEnigma finally executed");
//        }
//    }
//    static void Main()
//    {
//        try
//        {
//            MethodEnigma();
//        }
//        catch(Exception e)
//        {
//            Console.WriteLine("Error Occurred");
//        }
//    }
//}

// Custom Exception


//using FundamentalCSharp;
//using System.Text;

//class Program
//{
//    static void Main()
//    {
//        int a, b, c;
//        try
//        {
//            Console.WriteLine("Enter First Number");
//            a = Convert.ToInt32(Console.ReadLine());
//            Console.WriteLine("Enter First Number");
//            b = Convert.ToInt32(Console.ReadLine());

//            if (b % 2 > 0)
//            {
//                // Draw errorr ke exception yang dimaksud atau parentnya
//                throw new CustomEnigmaError("Telah terjadi error ketika melakukan perhitungan"); 
//            }
//        }
//        catch (FormatException ex)
//        {
//            Console.WriteLine($"Message : {ex.Message}");
//            Console.WriteLine($"Source : {ex.Source}");
//            Console.WriteLine("Some Error Ocurred");
//        }
//        catch (CustomEnigmaError ex)
//        {
//            Console.WriteLine($"Message : {ex.Message}");
//            Console.WriteLine($"Helplink : {ex.HelpLink}");

//            string filePath = @"C:\TestFile\log.txt";

//            if (File.Exists(filePath))
//            {
//                StringBuilder stringBuilder = new StringBuilder();
//                stringBuilder.Append($"Message : {ex.Message}");
//                stringBuilder.Append($"Helplink : {ex.HelpLink}");

//                StreamWriter sw = new StreamWriter(filePath);
//                sw.WriteLine(stringBuilder.ToString());
//                sw.Close();
//            }else
//            {
//                string Message = filePath + " Does not exist";
//                throw new FileNotFoundException(Message, ex);
//            }
//        }
//    }
//}