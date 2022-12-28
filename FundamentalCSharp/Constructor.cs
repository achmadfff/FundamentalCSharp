
/*
	 *		Constructor
	 *		Constructor : fungsi atau method yang akan dipanggil ketika object di create/instance dari sebuah class.
	 *		Constructor digunakan untuk inisialisasi object properties dan set up yang diperlukan.
	 *		1. Default Constructor
	 *		2. Parameterized Constructor
	 *		3. Copy Constructor
	 *		4. Private Constructor
	 *		5. Static Constructor
	 *		
	 *		Poin untuk membuat constructor
	 *		1. Constructor harus memiliki nama yang sama dengan class nya
	 *		2. Constructor void tidak memiliki return
	 */

//		DEFAULT CONSTRUCTOR : Constructor tanpa parameter.
//		
//class Program
//{
//	int num;
//	string name;
//	Program()
//	{	
//		// Statement yang akan dipanggil ketika class di instance
//		Console.WriteLine("Constructor Programm Called");
//	}
//	static void Main()
//	{
//		Program program = new Program(); // Class di instance menjadi object
//		program.num= 1;
//		program.name = "Achmad";
//		Console.WriteLine(program.num);
//		Console.WriteLine(program.name);
//	}
//}


//		PARAMETERIZED CONSTRUCTOR : Constructor dengan parameter atau method nya menggunakan parameter.
//class Enigma
//{
//	int id; 
//	string name;

//	Enigma(int id, string name) // Parameterize Constructor
//	{
//		this.id = id; // Assign value ke property class via constructor
//		this.name = name;
//	}
//	static void Main()
//	{
//		Enigma enigma = new Enigma(2,"Achmad"); // Create Instance dengan parameter
//		Console.WriteLine($"Enigma Id = {enigma.id} " +
//			$"Enigma Name = {enigma.name}");
//	}
//}

//		COPY CONSTRUCTOR : Constructor ini membuat object dari object lain, Biasa digunakan untk new instance yg memiliki nilai yang sama dengan
// Instance yang sudah ada
//class Enigma
//{
//    int id;
//    string name;
//    Enigma(int id, string name) // Parameterized Constructor
//    {
//        this.id = id;
//        this.name = name;
//    }
//    Enigma(Enigma enigma) // Deklarasi Copy Constructor
//    {
//        id = enigma.id;
//        name = enigma.name;
//    }
//    static void Main()
//    {
//        Enigma enigma = new Enigma(1, "Achmad");
//        Enigma copyEnigma = new Enigma(enigma); // Copy Constructor dengan assign dari instance yang sudah ada

//        Console.WriteLine($"Enigma Id = {enigma.id} " +
//            $"Enigma Name = {enigma.name}");
//        Console.WriteLine("Copy Constructor");
//        Console.WriteLine($"Enigma Id = {copyEnigma.id} " +
//            $"Enigma Name = {copyEnigma.name}");
//    }
//
//

/*			PRIVATE CONSTRUCTOR : Constructor dengan private modifier.
*			Tidak bisa diturunkan ke class lain, dan juga tidak mungkin untuk mengcreate instance dari class ini
*			Class ini tidak bisa dipanggil dari class lain.
*			
*			1. Gunakan private constructor jika kita hanya memiliki static member
*			2. Gunakan private constructor jika kita ingin class tidak di create/instance
*/
//class Enigma
//{
//	public static int id;
//	public static string name;

//	private Enigma()
//	{
//		Console.WriteLine("Private Constructor");
//	}

//	public static void Addition()
//	{
//		Enigma enigma = new Enigma();
//	}

//}

//class Program
//{
//    static void Main()
//    {
//        // Enigma privateEnigma = new Enigma(); // Error karena private

//		Enigma.id = 1;
//		Enigma.name = "Fadhil";
//		Console.WriteLine(Enigma.id);
//		Console.WriteLine(Enigma.name);
//		Enigma.Addition();
//    }
//}

/*
 *		STATIC CONSTRUCTOR : Constructor yang bersifat static, dan hanya di invoke sekali ketika instance di create.
 *		Ketika di create user tidak memiliki control terhadap constructor ini
 *		Dan dipanggil otomatis ketika class di create
 */
//class Enigma
//{
//    static Enigma() // Static Constructor
//    {
//        Console.WriteLine("Static Constructor");
//    }

//    Enigma(int i) // Parameterized Constructor
//    {
//		Console.WriteLine("Instance Constructor " + i);
//    }

//	static void Main()
//	{
//		Enigma enigma = new Enigma(1);
//		Enigma enigma1 = new Enigma(2);
//	}
//}