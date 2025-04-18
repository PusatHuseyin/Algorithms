namespace Algorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Soru Numarasını Giriniz: ");
            int qNum = int.Parse(Console.ReadLine());
            if (qNum == 1)
            {
                #region bir dizideki max ile min yerini degistiren algoritma
                // 1. dizi tanimla (sayi dizisi)
                // 2. dizideki en buyugu bul ve indexini tut, maxNum
                // 3. dizideki en kucugu bul ve indexini tut, minNum
                // 4. minNum ile maxNum dizide yerini degistir

                int[] numbers = { 15, -68, 4582, 0, 62, 14, -2, -652 };
                int maxNum = numbers[0];
                int minNum = numbers[0];
                int maxIndex = 0, minIndex = 0, tempMin = 0;
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] > maxNum)
                    {
                        maxNum = numbers[i];
                        maxIndex = i;
                    }
                    if (numbers[i] < minNum)
                    {
                        minNum = numbers[i];
                        minIndex = i;
                    }
                }
                tempMin = numbers[minIndex];// -652
                numbers[minIndex] = numbers[maxIndex];
                numbers[maxIndex] = tempMin;
                foreach (var num in numbers)
                {
                    Console.Write(num + " ");
                }

                Console.Read();

                #endregion
            }
            else if (qNum == 2)
            {
                #region kullanicidan alinan sayilarin toplami
                // 1. kullanicidan devamli sayi girmesi istenecek
                // 2. negatif sayi girince dongu bitecek
                // 3. girilen sayilar tek ise atlanacak
                // 4. cift sayilar ve cift sayilar toplami ekrana yazdirilacak
                int num = 0, sum = 0;
                do
                {
                    Console.WriteLine("Enter a number: ");
                    num = int.Parse(Console.ReadLine());
                    if (num % 2 != 0)
                    {
                        continue;
                    }
                    sum += num;
                    Console.Write(num + " ");
                }
                while (num >= 0);
                Console.Write("Total: {0}", sum);
                #endregion
            }
            else if (qNum == 3)
            {
                #region guclu sayiyi bulan algoritma
                // guclu sayi --> her basamagin faktoriyeli toplaminin kendisine esit olan sayilar 
                //  -- 1. solution -
                // 1. kullanicidan bir sayi al, num
                // 2. int total=0, temp = num;
                // 3. Factorial() tanimla
                // 4. temp > 0 oldugu sürece dön
                //  4.1. temp'in 10'a modunu al, rakam degiskenina ata
                //  4.2. rakami Factorial()' e gonder, ve dönen sonucu total'e ekle
                //  4.3. temp / 10;
                // 5. total == num ise yazdir

                Console.Write("Enter a number: ");
                int num = int.Parse(Console.ReadLine());

                int total = 0;
                int temp = num;

                while (temp > 0)
                {
                    int rakam = temp % 10;
                    total += Factorial(rakam);
                    temp /= 10;
                }

                if (total == num)
                {
                    Console.WriteLine($"{num} sayisi gucludur.");
                } else
                {
                    Console.WriteLine($"{num} sayisi guclu degil!.");
                }
                #endregion
            }
        }
        static int Factorial(int number)
        {
            int result = 1;
            for (int i = 1; i <= number; i++)
            {
                result *= i;            
            }
            return result;
        }
    }
}
