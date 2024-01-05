using System.Runtime.InteropServices;

namespace ConsoleAppTask8
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Misal - 1

            //    Console.Write("Eded daxil edin: ");
            //    int eded = Convert.ToInt32(Console.ReadLine());

            //    if (IsTek(eded))
            //    {
            //        Console.WriteLine($"{eded} tekdir");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{eded} cutdur");
            //    }
            //}

            //static bool IsTek(int eded)
            //{
            //    return eded % 2 != 0;

            //}

            //==================================

            //Misal - 2

            //    Console.Write("Birinci ededi daxil edin: ");
            //    int eded1 = Convert.ToInt32(Console.ReadLine());

            //    Console.Write("Ikinci ededi daxil edin: ");
            //    int eded2 = Convert.ToInt32(Console.ReadLine());

            //    if (IsBolunur(eded1, eded2))
            //    {
            //        Console.WriteLine($"{eded1} ikinci edede tam bolunur. ");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{eded1} ikinci edede tam bolunmur. ");
            //    }
            //}
            //static bool IsBolunur(int a, int b)
            //{
            //    return a % b == 0;
            //}

            //=========================

            //Misal - 3

            //    Console.Write("Ededi daxil edin: ");
            //    int eded = Convert.ToInt32(Console.ReadLine());

            //    if (SonuncuReqem(eded))
            //    {
            //        Console.WriteLine($"Beli, ededin sonuncu reqemi 7 ile qurtarir. ");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"Xeyr, ededin sonuncu reqemi 7 ile qurtarmir. ");
            //    }
            //}
            //static bool SonuncuReqem(int eded)
            //{
            //    int sonuncuReqem = eded % 10;
            //    return sonuncuReqem == 7;
            //}

            //===========================

            //Misal - 4

            //    Console.Write("Iki reqeli ededi daxil edin: ");
            //    int eded = Convert.ToInt32(Console.ReadLine());

            //    if (ReqemlerEynidir(eded))
            //    {
            //        Console.WriteLine($"Beli, ededin reqemleri eynidir. ");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"Xeyr, ededin reqemleri eyni deyildir. ");
            //    }
            //}
            //static bool ReqemlerEynidir(int eded)
            //{
            //    int birinciReqem = eded / 10;
            //    int IkinciReqem = eded % 10;

            //    return birinciReqem == IkinciReqem;
            //}

            //===========================

            //Misal - 5

            //    Console.Write("Iki reqemli ededi daxil edin: ");
            //    int eded = Convert.ToInt32(Console.ReadLine());

            //    int birinciReqem, ikinciReqem;
            //    int cem = 0;

            //    while (eded > 0)
            //    {
            //        birinciReqem = eded % 10;
            //        cem += birinciReqem;
            //        eded /= 10;
            //    }

            //    if (cem % 2 == 0)
            //    {
            //        Console.WriteLine($"Reqemlerin cemi cutdur. Reqemlerin hasili: {HasilTap(cem)}");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Ededde tek reqem movcuddur. ");
            //    }
            //}
            //static int HasilTap(int cem)
            //{
            //    int hasil = 1;
            //    while (cem > 0)
            //    {
            //        hasil *= cem % 10;
            //        cem /= 10;
            //    }
            //    return hasil;
            //}

            //============================

            //Misal - 6

            //    Student[] student = new Student[100];
            //    int studentCount = 0;

            //    while (true)
            //    {
            //        Console.WriteLine("Enter duymesini sixdigda yeni telebe elave edin. Baglamaq ucun basqa duyme sixin. ");
            //        ConsoleKeyInfo keyInfo = Console.ReadKey();

            //        if (keyInfo.Key == ConsoleKey.Enter)
            //        {
            //            Student newStudent = CreateStudent();
            //            student[studentCount] = newStudent;
            //            studentCount++;
            //            Console.WriteLine("\nYeni telebe elave edildi.\n");
            //        }
            //        else
            //        {
            //            Console.Clear();
            //            Console.WriteLine("Telebe melumatlari :\n");

            //            for (int i = 0; i < studentCount; i++)
            //            {
            //                Console.WriteLine(student[i].ToString());
            //            }
            //            break;
            //        }
            //    }
            //}

            //static Student CreateStudent()
            //{
            //    Console.WriteLine("\nYeni telebe melumatlarini daxil edin:");

            //    Console.Write("ID: ");
            //    int id = Convert.ToInt32(Console.ReadLine());

            //    Console.Write("Ad: ");
            //    string name = Console.ReadLine();

            //    Console.Write("Soyad: ");
            //    string surname = Console.ReadLine();

            //    Console.Write("Dogum tarixi (yyyy-MM-dd: ");
            //    DateTime birthDate = DateTime.Parse(Console.ReadLine());

            //    return new Student { Id = id, Name = name, Surname = surname, BirthDate = birthDate };
            //}

            //====================================

            //Misal - 7

            DateTime tarix0 = new DateTime(2023, 3, 14);
            Console.Write(tarix0.ToString("dd.MM.yyyy"));
            Console.Write(" - ");
            Console.WriteLine(TarixFormatla(tarix0));

            DateTime tarix1 = new DateTime(2009, 9, 18);
            Console.Write(tarix1.ToString("dd.MM.yyyy"));
            Console.Write(" - ");
            Console.WriteLine(TarixFormatla(tarix1));

            DateTime tarix2 = new DateTime(2002, 2, 18);
            Console.Write(tarix2.ToString("dd.MM.yyyy"));
            Console.Write(" - ");
            Console.WriteLine(TarixFormatla(tarix2));

            DateTime tarix3 = new DateTime(2006, 12, 18);
            Console.Write(tarix3.ToString("dd.MM.yyyy"));
            Console.Write(" - ");
            Console.WriteLine(TarixFormatla(tarix3));
        }

        static string TarixFormatla(DateTime tarix)
        {
            string gun = tarix.ToString("dd");
            string ay = AyAdiniGetir(tarix.Month);
            string il = tarix.ToString("yyyy");

            string formatliTarix = $"{gun} {ay} {il}-cu il";
            return formatliTarix;
        }
        static string AyAdiniGetir(int ay)
        {
            switch (ay)
            {
                case 1:
                    return "yanvar";
                case 2:
                    return "fevral";
                case 3:
                    return "mart";
                case 4:
                    return "aprel";
                case 5:
                    return "may";
                case 6:
                    return "iyun";
                case 7:
                    return "iyul";
                case 8:
                    return "avgust";
                case 9:
                    return "sentyabr";
                case 10:
                    return "oktyabr";
                case 11:
                    return "noyabr";
                case 12:
                    return "dekabr";
                default:
                    return "";
            }
        }

    }
}