using System;

namespace nesneproje
{
    class Contact 
    {
        public static void ContactDetails()
        {
            Console.Clear();
            Console.WriteLine("\nTelefon numarası => 0543 123 45 67\n");
            Console.WriteLine("E-posta => kuaforunepostasi@hotmail.com\n");
            Console.WriteLine("Geri dönmek için 1, çıkış yapmak için 2 değerini giriniz.");

            bool loop4 = true;

            while (loop4)
            {
                try
                {
                    Console.Write("Değerinizi girdikten sonra ilerlemek için enter tuşuna basmayı unutmayınız. Girilen değer => ");

                    int answer4 = Convert.ToInt32(Console.ReadLine());

                    Console.Write("\n");

                    if (answer4 == 1)
                    {
                        loop4 = false;
                        Console.Clear();
                    }
                    else if (answer4 == 2)
                    {
                        loop4 = false;
                        Exit.ExitFromProgram();
                    }
                    else
                    {
                        Console.WriteLine("Geçersiz değer girildi, lütfen tekrar değer giriniz.");
                        Console.WriteLine("Geri dönmek için 1, çıkış yapmak için 2 değerini giriniz.");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("\nGeçersiz formatta değer girildi, lütfen sadece sayı giriniz.");
                    Console.WriteLine("Geri dönmek için 1, çıkış yapmak için 2 değerini giriniz.");
                }
                catch (Exception)
                {
                    Console.WriteLine("\nHata.");
                    Console.WriteLine("Geri dönmek için 1, çıkış yapmak için 2 değerini giriniz.");
                }
            } 
        }
    }
}
