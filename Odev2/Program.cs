using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev2
{
    internal class Program
    {
        //1-10 arasında çarpım tablosunu yazdıran bir method tasarlayınız.

        //CarpimTablosunuYazdir();

        //Console.ReadLine();

        //klavyeden girilen değerler arasında rastgele sayı üreten ve bu değerleri 10 elemanlı bir diziye atayan SayiUret() isimli bir metot yazın.
        //Bu dizinin elemanlarını yazan DiziYazdır() isimli bir metot daha yazarak elemanları listeleyin.
        //Daha sonra bu dizi içerisinde EnBuyukDeger() adında bir metot ile dizinin en büyük değerini bulan,en küçük değerinin bulan EnKucukDeger() adından başka bir metot daha yazınız.
        //EnBuyukDeger ve EnKucukDeger metotlarında dönen değerleri ekranda gösteren programı yazınız
        //kullanıcının bütün hataları kontrol altına alınmalı

        static void Main(string[] args)
        {
            
            try
            {
                Console.WriteLine("Random için tanımlamak istediğiniz aralığı yazınız. \n1. Sayı: ");
                int baseInput = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("2. Sayı: ");
                int upperInput = Convert.ToInt32(Console.ReadLine());
                int[] numbers = GenerateNumberArray(baseInput, upperInput);

                Console.WriteLine("************ Dizi Elemanları ************");
                PrintArray(numbers);
                PrintMaxMinValue(FindMaxNumber(numbers),FindMinNumber(numbers));
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata mesajı: " + ex.Message);
                Console.ReadLine();
            }

            Console.ReadLine();
        }
        
        static void MultiplicationTable()
        {
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine($"{i}x{j}=" + i * j);
                }
            }
            Console.ReadLine();
        }
        static int[] GenerateNumberArray(int sayi, int sayi2)
        {
            if (sayi > sayi2)
            { throw new Exception("1.değer 2.değerden büyük olamaz!!!"); }
            int[] randomNumber = new int[10];
            Random randoms = new Random();
            for (int i = 0; i < 10; i++)
            {
                randomNumber[i] = randoms.Next(sayi, sayi2);

            }
            return randomNumber;
        }
        static void PrintArray(int[] RandomNumber)
        {
            foreach (int number in RandomNumber)
            {
                Console.WriteLine(number);
            }
        }
        static int FindMaxNumber(int[] NumberArray)
        {
            int maxValue = NumberArray[0];
            for (int i = 1; i < NumberArray.Length; i++)
            {
                if (maxValue < NumberArray[i])
                {
                    maxValue = NumberArray[i];
                }
                
            }
            return maxValue;
        }

        static int FindMinNumber(int[] NumberArray)
        {
            int minValue = NumberArray[0];
            for (int i = 1; i < NumberArray.Length; i++)
            {
                if (minValue > NumberArray[i])
                {
                    minValue = NumberArray[i];
                }

            }
            return minValue;
        }
        static void PrintMaxMinValue(int maxValue, int minValue)
        {
            Console.WriteLine("Dizideki en büyük değer:" + maxValue + "\nDizideki en küçük değer:" + minValue);
        }


    }
}
