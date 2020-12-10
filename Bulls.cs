using System;
namespace Lesson2
{
    class Bulls
    { 

        static void Main(string[] args)
        {
            int[] nums = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            RandomNumber<int>(ref nums);
            int[] EnteredNumber = new int[4];
            Array.Copy(nums, EnteredNumber, 4);

            Console.WriteLine("Введите четырехзначное число, чтобы угадать количество Быков и Коров.");
            while (!GameBC(EnteredNumber, Console.ReadLine()))
            {
                Console.WriteLine("Попробуйте снова!)");
            }

            Console.ReadKey();
        }

        public static void RandomNumber<RndArr>(ref RndArr[] RndNumber)
        {
            Random rnd = new Random();
            for (int i = 0; i < RndNumber.Length; i++)
            {
                int j = rnd.Next(RndNumber.Length);
                RndArr cnum = RndNumber[i]; 
                RndNumber[i] = RndNumber[j]; 
                RndNumber[j] = cnum;
            }
        }

        public static bool GameBC(int[] number, string inter)
        {
            int Bulls = 0;
            int Cows = 0;
            char[] EnterNum = inter.ToCharArray();

            if (EnterNum.Length != 4)
            {
                Console.WriteLine("Некорректный ввод. Введите четырехзначное число.");
                return false;
            }

            for (int i = 0; i < 4; i++)
            {
                int EqualNumbers = (int)char.GetNumericValue(EnterNum[i]);
                if (EqualNumbers < 1 || EqualNumbers > 9)
                {
                    Console.WriteLine("Необходимо ввести число от 0 до 10.");
                    return false;
                }
                if (EqualNumbers == number[i])
                {
                    Bulls++;
                }
                else
                {
                    for (int j = 0; j < 4; j++)
                    {
                        if (EqualNumbers == number[j])
                            Cows++;
                    }
                }
            }

            if (Bulls == 4)
            {
                Console.WriteLine("Победитель!");
                return true;
            }
            else
            {
                Console.WriteLine("Вы угадали {0} Быков и {1} Коров", Bulls, Cows);
                return false;
            }
        }
    }
}