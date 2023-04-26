using System;
using System.Threading;

namespace nesneproje
{
    class MainMenu 
    {
        public static void Menu(bool loop1) 
        {
            while (loop1)
            {
                Console.WriteLine("\n\n\n\n");
                Console.WriteLine("                 --------------------------------------------------------------------------------------");
                Console.WriteLine("                 |                                      HOŞGELDİNİZ                                   |");
                Console.WriteLine("                 |                                                                                    |");
                Console.WriteLine("                 |                                                                                    |");
                Console.WriteLine("                 |                       Randevu almak için 1 değerini giriniz.                       |");
                Console.WriteLine("                 |              Randevu listesini görüntülemek için 2 değerini giriniz.               |");
                Console.WriteLine("                 |                     İletişim bilgileri için 3 değerini giriniz.                    |");
                Console.WriteLine("                 |                        Çıkış yapmak için 4 değerini giriniz.                       |");
                Console.WriteLine("                 |                                                                                    |");
                Console.WriteLine("                 |                                                                                    |");
                Console.WriteLine("                 |                                                                                    |");
                Console.WriteLine("                 --------------------------------------------------------------------------------------\n");

                try
                {
                    Console.Write("Değerinizi girdikten sonra ilerlemek için enter tuşuna basmayı unutmayınız. Girilen değer => ");

                    int answer1 = Convert.ToInt32(Console.ReadLine());

                    if (answer1 == 1)
                    {
                        NewAppointment.MakeANewAppointment();
                    }
                    else if (answer1 == 2)
                    {
                        AppointmentList.ListOfAppointments();
                    }
                    else if (answer1 == 3)
                    {
                        Contact.ContactDetails();
                    }
                    else if (answer1 == 4)
                    {
                        Exit.ExitFromProgram();
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("\nGeçersiz değer girildi, lütfen tekrar değer giriniz. (1, 2, 3, 4)");
                        Thread.Sleep(2000);
                        Console.Clear();
                    }
                }
                catch (FormatException)
                {
                    Console.Clear();
                    Console.WriteLine("\nGeçersiz formatta değer girildi, lütfen sadece sayı giriniz. (1, 2, 3, 4)");
                    Thread.Sleep(2000);
                    Console.Clear();
                }
                catch (Exception)
                {
                    Console.Clear();
                    Console.WriteLine("\nHata.");
                    Thread.Sleep(2000);
                    Console.Clear();
                }
            }
        }
    }
}
