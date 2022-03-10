using System;

namespace _5._6_Fin_Pr_Module_5
{
    class Program
    {
        static void Main(string[] args)
        {
            var Data = YourData();
            ShowData(Data);
            Console.ReadKey();

        }

        static (string, string, byte, bool, byte, string[], byte, string[]) YourData()
        {
            (string name, string secondname, byte age, bool Pet, byte CountOfPets, string[] NamePets, byte CountOfColors, string[] Colors) Data1 = ("Георгий", "", 0, false, 0, new string[1] { "" }, 0, new string[1] { "" }); ;
            bool ans;
            do
            {
                Data1.CountOfPets = 1;
                Console.WriteLine("Введите свое имя");
                Data1.name = Console.ReadLine();

                Console.WriteLine("Введите фамилию");
                Data1.secondname = Console.ReadLine();

                Console.WriteLine("Введите возраст");
                Data1.age = byte.Parse(Console.ReadLine());

                Console.WriteLine("Есть ли у вас питомец? Да/Нет");
                string ans2 = Console.ReadLine();
                if (ans2 == "Да")
                {
                    Data1.Pet = true;
                    Console.WriteLine("Введите кол-во питомцев");
                    Data1.CountOfPets = byte.Parse(Console.ReadLine());
                    Data1.NamePets = ArrayPet(Data1.CountOfPets);
                }

                Console.WriteLine("Введите кол-во любимых цветов");
                Data1.CountOfColors = byte.Parse(Console.ReadLine());

                Data1.Colors = ArrayColors(Data1.CountOfColors);

                ans = CheckData(Data1.age, Data1.CountOfColors, Data1.CountOfPets);
            } while (ans == true);

            var result = Data1;

            return result;
        }

        static string[] ArrayPet(int Count)
        {
            string[] Pets = new string[Count];
            for (int i = 0; i < Pets.Length; i++)
            {
                Console.WriteLine("Введите имя питомца {0}", i + 1);
                Pets[i] = Console.ReadLine();

            }
            return Pets;
        }

        static string[] ArrayColors(int Count)
        {
            string[] Colors = new string[Count];
            for (int i = 0; i < Colors.Length; i++)
            {
                Console.WriteLine("Введите цвет {0}", i + 1);
                Colors[i] = Console.ReadLine();

            }
            return Colors;
        }

        static void ShowData((string name, string secondname, byte age, bool Pet, byte CountOfPets, string[] NamePets, byte CountOfColors, string[] Colors) Data1)
        {
            Console.WriteLine("\nВаше имя: {0}", Data1.name);
            Console.WriteLine("\nВаше фамилия: {0}", Data1.secondname);
            Console.WriteLine("\nВаше возраст: {0}", Data1.age);
            if (Data1.Pet)
            {
                Console.WriteLine("\nКол-во ваших питомцев {0}", Data1.CountOfPets);
                Console.WriteLine("\nИмена ваших питомцев");
                foreach (string a in Data1.NamePets)
                {
                    Console.WriteLine(a);
                }
            }
            else { Console.WriteLine("\nУ вас нет питомцев"); }

            Console.WriteLine("\nВаши любимые цвета");
            foreach (string a in Data1.Colors)
            {
                Console.WriteLine(a);
            }



        }

        static bool CheckData(byte Age, byte Colors, byte Pets) 
        {
            bool ans = true;
            if ( Age > 0 & Colors > 0 & Pets > 0)
            {
                ans = false;
            }
            else
            {
                Console.WriteLine("Какие-то данные были введены некорректно. Повторите ввод (Проверьте возраст, наличие питомцев и кол-во цветов - они должны быть больше 0)");
            }

            return ans;
        }

    }
}
