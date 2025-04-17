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
                // 1. dizi tanimla (sayi dizisi)
                // 2. dizideki en buyugu bul ve indexini tut, maxNum
                // 3. dizideki en kucugu bul ve indexini tut, minNum
                // 4. minNum ile maxNum dizide yerini degistir

                int[] numbers = {15, -68, 4582, 0, 62, 14, -2, -652};
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
            }
        }
    }
}
