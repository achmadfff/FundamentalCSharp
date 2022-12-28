//class MyClass : IDisposable
//{
//    private bool disposedValue = false;

//    protected virtual void Dispose(bool disposing)
//    {
//        if (!disposedValue)
//        {
//            if (disposing)
//            {

//            }
//            disposedValue = true;
//        }
//    }

//    public MyClass()
//    {
//        Console.WriteLine("Constructor");
//    }

//    ~MyClass()
//    {
//        Dispose(false);
//    }

//    public void Dispose()
//    {
//        Dispose(true); // DisposeObject
//        GC.SuppressFinalize(this); // Call GC untuk free object
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        MyClass myClass = new MyClass();
//    }
//}

