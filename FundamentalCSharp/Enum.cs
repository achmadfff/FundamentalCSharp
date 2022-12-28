//public class Enum
//{
//    public static void Main()
//    {
//        /*
//         *      Enum itu adalah tipe data yang digunakan untuk membuat variable constant
//         *      Variable / isi enum dipisahkan dengan koma.
//         *      Cara memanggil enum itu dengan cara memanggil data enum lalu  diikuti tanda (.)
//         *      Pembuatan enum itu ada 2 cara :
//         *      - Didalam class (Di dalam class itu sendiri)
//         *      - Diluar class (Global)
//         *      Naming Convention Enum -> PascalCase
//         *      
//         *      Enum secara default mempunyai values dengan data angka dimulai dari 0
//         */

//        Gender male = Gender.Male;
//        Gender female = Gender.Female;

//        Console.WriteLine("Laki-laki : " + male);
//        Console.WriteLine("Perempuan : " + female);
//        Console.WriteLine("Senin : " + Days.Monday);
//        Console.WriteLine("Selasa : " + Days.Tuesday);
//        Console.WriteLine("Rabu : " + Days.Wednesday);
//        Console.WriteLine("Kamis : " + Days.Thursday);
//        Console.WriteLine("Jumat : " + Days.Friday);
//        Console.WriteLine("Sabtu : " + Days.Saturday);
//        Console.WriteLine("Minggu : " + Days.Sunday);

//        // Casting : Konversi dari satu tipe data ke tipe data lain
//        var maleNumber = (int)male;
//        Console.WriteLine(maleNumber);

//    }
//}

//public enum Gender
//{
//    Male = 1, // 0
//    Female, // 1
//}
//public enum Days
//{
//    Sunday,Monday,Tuesday,Wednesday,Thursday,Friday,Saturday
//}