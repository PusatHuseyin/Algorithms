namespace Algorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Soru Numarasını Giriniz: ");
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
                #region
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
        }
    }
}
