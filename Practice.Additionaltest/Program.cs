using System.Threading.Channels;

namespace Practice.Additionaltest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Tapşırıq 1: Dəyişənlər, Operatorlar və If - Else(Giriş balı hesablama)
            //Şərt: İstifadəçidən 3 fərqli fənn üzrə imtahan balını(0 - 100 arası) qəbul edən proqram yazın. 
            //Bu balların ortalamasını hesablayın. Əgər ortalama 65 - dən böyükdürsə ekrana "Keçdi", əks halda "Kəsildi" yazılsın.
            Console.WriteLine("1 ci imtahan balinizi qeyd edin: ");
            int examOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2 ci imtahan balinizi qeyd edin: ");
            int examSecond = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("3 cu imtahan balinizi qeyd edin: ");
            int examThird = Convert.ToInt32(Console.ReadLine());
            int result = examThird + examSecond + examOne;
            if(examOne > 100 || examSecond > 100 || examThird > 100) Console.WriteLine("Imtahan balinizi duzgun daxil edin: 1 - 100 daxilinde");
            else if(result / 3 > 65) Console.WriteLine("imthandan kecdiniz");
            else Console.WriteLine("imtahandan kesilddiniz");

        }
    }
}
