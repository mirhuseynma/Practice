using System.Diagnostics;
using System.Threading.Channels;

namespace Practice.Additionaltest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Tapşırıq 1: Dəyişənlər, Operatorlar və If - Else(Giriş balı hesablama)
            #region task 1
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
            #endregion
            //Tapşırıq 2: Switch Case və Sadə Alqoritm(Hesablayıcı)
            #region task 2
            Console.WriteLine("1 ci ededi daxil edin: ");
            int firstInput = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("operatoru secin edin: +, -, *, /");
            char operatorInput = Console.ReadKey().KeyChar;
            Console.ReadLine();
            Console.WriteLine("2 ci ededi daxil edin: ");
            int secondInput = Convert.ToInt32(Console.ReadLine());
            char[] operators = { '+', '-', '*', '/' };
            switch (operatorInput)
            {
                case '+':
                    Console.WriteLine($"{firstInput} ve {secondInput} ededlerinin cemi: {firstInput+secondInput}");
                    break;
                case '-':
                    Console.WriteLine($"{firstInput} ve {secondInput} ededlerinin ferqi: {firstInput - secondInput}");
                    break;
                case '*':
                    Console.WriteLine($"{firstInput} ve {secondInput} ededlerinin hasili: {firstInput * secondInput}");
                    break;
                case '/':
                    if(firstInput == 0|| secondInput == 0) Console.WriteLine("0 a bolme yoxdur");
                    else Console.WriteLine($"{firstInput} ve {secondInput} ededlerinin cemi: {firstInput + secondInput}");
                    break;
                default:
                    Console.WriteLine("operatoru duzgun daxil edin: +, -, *, /");
                    break;       
            }

            #endregion
            //Tapşırıq 3: Dövr Operatorları və Alqoritm (Faktorial)
            #region task 3
            int fact = 5;
            int sumFact = 1;
            for(int i = 1; i<=fact; i++)
            {
                sumFact *= i;
            }
            Console.WriteLine($"{fact} ededinin faktoriali: {sumFact}");
            #endregion
            //Tapşırıq 4: Massivlər (Array) və Foreach (Cəm və Maksimum)
            #region task 4
            int[] massive = [1, 2, 3, 4];
            int max = massive[0];
            int sumOfArray = 0;
            for(int i = 0; i<massive.Length; i++)
            {
                if (max < massive[i])
                    max = massive[i];
                sumOfArray += massive[i];
            }
            Console.WriteLine($"massivin cemi: {sumOfArray}, massivdeki en boyuk eded: {max}");
            #endregion
            //Tapşırıq 5: Metodlar və Return Type (Sahə hesablama)
            #region task 5
            Console.WriteLine("Duzbucaqlinin sahesi: " + CalculateArea(5,6));
            #endregion
            //Tapşırıq 6: Method Overloading (Həndəsi fiqurlar) Şərt: Eyni adlı Area metodu yaradın.
            #region task 6
            Console.WriteLine("Dairenin sahesi: " + Area(5));
            Console.WriteLine("Duzbucaqlinin sahesi: " + Area(5,6));
            #endregion
            //Tapşırıq 7: String Metodları (Tərsinə çevirmə)
            #region task 7
            Console.WriteLine(ReverseString("mirhuseyn"));
            #endregion
            //

            Console.ReadLine();

        }
        public static int CalculateArea(int a, int b)
        {
            return a * b;
        }
        public static int Area(int a)
        {
            int result = (a * a) * 3;
            return result;
        }
        public static int Area(int a, int b)
        {
            return a * b;
        }
        public static string ReverseString(string text)
        {
            string reverseText = "";
            for(int i = text.Length-1; i >= 0; i--)
            {
                reverseText += text[i];
            }
            return reverseText.ToLower();
        }
    }
}
