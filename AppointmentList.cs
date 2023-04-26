using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace nesneproje
{
    class AppointmentList
    {
        public static void ListOfAppointments()
        {
            Console.Clear();

            StreamReader reader = new StreamReader(Environment.CurrentDirectory + @"\appointments.json");
            string json = reader.ReadToEnd();

            List<Informations> appointerslist = JsonConvert.DeserializeObject<List<Informations>>(json);

            Console.WriteLine("\nNo" + " - " + "İsim-soyisim" + " - " + "Randevu tarihi" + " - " + "Email adresi" + " - " + "Randevu sebebi\n");

            int nocounter = 1;

            foreach (var customer in appointerslist)
            {
                Console.WriteLine(nocounter + " - " + customer.NameSurname + " - " + customer.Date.ToShortDateString() + " - " + customer.Email + " - " + customer.Choice);
                nocounter++;
            }

            reader.Close();

            Console.WriteLine("\nGeri dönmek için 1, çıkış yapmak için 2 değerini giriniz.");

            bool loop3 = true;

            while (loop3)
            {
                try
                {
                    Console.Write("Değerinizi girdikten sonra ilerlemek için enter tuşuna basmayı unutmayınız. Girilen değer => ");

                    int answer3 = Convert.ToInt32(Console.ReadLine());

                    Console.Write("\n");

                    if (answer3 == 1)
                    {
                        loop3 = false;
                        Console.Clear();
                    }
                    else if (answer3 == 2)
                    {
                        loop3 = false;
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
