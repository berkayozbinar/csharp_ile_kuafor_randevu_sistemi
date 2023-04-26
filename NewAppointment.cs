using System;
using System.IO;
using Newtonsoft.Json;

namespace nesneproje
{
    class NewAppointment
    {
        public static void MakeANewAppointment()
        {
            Console.Clear();
            Console.WriteLine("\nLütfen sırasıyla isim-soyisim, randevu tarihi, e-posta adresi giriniz ve randevu sebebi seçiniz.");

            Informations newperson = new Informations();

            Console.WriteLine("\nİsim-soyisim giriniz.");
            Console.Write("İsim-soyisim girdikten sonra ilerlemek için enter tuşuna basmayı unutmayınız. Girilen isim-soyisim => ");

            newperson.NameSurname = Console.ReadLine();

            bool loop1point5 = true; 

            Console.Write("\n");

            do
            {
                try
                {
                    Console.WriteLine("Randevu tarihi giriniz(Gün Ay Yıl). Örnek kullanım => 24 12 2021");
                    Console.WriteLine($"{DateTime.Today.AddDays(1).ToShortDateString()} ile {DateTime.Today.AddDays(7).ToShortDateString()} tarihleri arasında randevu alınabilir.");
                    Console.Write("Tarih girdikten sonra ilerlemek için enter tuşuna basmayı unutmayınız. Girilen tarih => ");

                    newperson.Date = Convert.ToDateTime(Console.ReadLine());
                    
                    if (newperson.Date < DateTime.Today.AddDays(1) || newperson.Date > DateTime.Today.AddDays(7))
                    {
                        Console.WriteLine("\nGeçersiz aralıkta tarih girildi, lütfen geçerli aralıkta tarih giriniz.");
                        continue;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("\nGeçersiz formatta tarih girildi, lütfen örnek kullanıma uygun tarih giriniz.");
                    continue;
                }

                loop1point5 = false;
            }
            while (loop1point5);

            Console.WriteLine("\nE-posta adresi giriniz.");
            Console.Write("E-posta girdikten sonra ilerlemek için enter tuşuna basmayı unutmayınız. Girilen e-posta => ");

            newperson.Email = Console.ReadLine();

            Console.Write("\n");

            loop1point5 = true;

            do
            {
                try
                {
                    Console.WriteLine("Randevu sebebi seçiniz.(1-Fön, 2-Saç kesim, 3-Boya, 4-Saç bakım, 5-Manikür veya pedikür, 6-Ağda 7-Gelin sepeti 8-Diğer");
                    Console.Write("Değerinizi girdikten sonra ilerlemek için enter tuşuna basmayı unutmayınız. Girilen değer => ");

                    int choice = Convert.ToInt32(Console.ReadLine());

                    if (choice < 1 || choice > 8)
                    {
                        Console.WriteLine("\nGeçersiz değer girildi, lütfen tekrar değer giriniz.");
                        continue;
                    }
                    else
                    {
                        newperson.Choice = newperson.options[choice - 1];
                        Console.Clear();
                        newperson.options = null;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("\nGeçersiz formatta değer girildi, lütfen sadece sayı giriniz.");
                    continue;
                }

                loop1point5 = false;
            }
            while (loop1point5);

            string newappointment = "," + JsonConvert.SerializeObject(newperson, Formatting.Indented) + "\n]";
            File.WriteAllText(Environment.CurrentDirectory + @"\appointments.json", File.ReadAllText(Environment.CurrentDirectory + @"\appointments.json").Replace(']', ' '));
            File.AppendAllText(Environment.CurrentDirectory + @"\appointments.json", newappointment);
        
            Console.WriteLine("\nYeni bir randevu almak için 1, geri dönmek için 2, çıkış yapmak için 3 değerini giriniz.");

            bool loop2 = true;

            while (loop2)
            {
                try
                {
                    Console.Write("Değerinizi girdikten sonra ilerlemek için enter tuşuna basmayı unutmayınız. Girilen değer => ");

                    int answer2 = Convert.ToInt32(Console.ReadLine());

                    Console.Write("\n");

                    if (answer2 == 1)
                    {
                        loop2 = false;
                        Console.Clear();
                        NewAppointment.MakeANewAppointment();
                    }
                    else if (answer2 == 2)
                    {
                        loop2 = false;
                        Console.Clear();
                    }
                    else if (answer2 == 3)
                    {
                        loop2 = false;
                        Exit.ExitFromProgram();
                    }
                    else
                    {
                        Console.WriteLine("Geçersiz değer girildi, lütfen tekrar değer giriniz.");
                        Console.WriteLine("Yeni bir randevu almak için 1, geri dönmek için 2, çıkış yapmak için 3 değerini giriniz.");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("\nGeçersiz formatta değer girildi, lütfen sadece sayı giriniz.");
                    Console.WriteLine("Yeni bir randevu almak için 1, geri dönmek için 2, çıkış yapmak için 3 değerini giriniz.");
                }
                catch (Exception)
                {
                    Console.WriteLine("\nHata.");
                    Console.WriteLine("Yeni bir randevu almak için 1, geri dönmek için 2, çıkış yapmak için 3 değerini giriniz.");
                }
            }
        }
    }
}
