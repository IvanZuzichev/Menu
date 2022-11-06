using System.Security.Authentication.ExtendedProtection;
using System.Security.Cryptography.X509Certificates;

namespace menu
{
    public class Tort
    {
        public string Forma;
        public string Razmer;
        public string Vkus;
        private int cena;
        public List<string> korsina = new List<string>();
        public DateTime Now2;
        public Tort(int cenaKorobka)
        {
            cena = cenaKorobka;
        }
        public void Menu()
        {
            Tort var1 = new Tort(0);
            Tort var2 = new Tort(0);
            Tort var3 = new Tort(0);
            var1.Forma = "Квадрат - 300";
            var2.Forma = "Круг - 350";
            var3.Forma = "Сердце - 550";

            var1.Razmer = "Большой - 800";
            var2.Razmer = "Средний - 600";
            var3.Razmer = "Маленький - 500";

            var1.Vkus = "Клубника - 400";
            var2.Vkus = "Шоколад - 300";
            var3.Vkus = "Бисквит - 600";
            

            ConsoleKeyInfo clavisha = Console.ReadKey();
            int qq = 0;
            int position = 2;
            while (qq == 0)
            {
                while (clavisha.Key != ConsoleKey.Enter)
                {
                    if (clavisha.Key == ConsoleKey.UpArrow)
                    {
                        position--;
                        if (position < 2)
                        {
                            position = 2;
                        }
                    }
                    else if (clavisha.Key == ConsoleKey.DownArrow)
                    {
                        position++;
                        if (position > 5)
                        {
                            position = 5;
                        }
                    }
                    Console.Clear();
                    Console.WriteLine("Добро пожаловать в меню: 'Утортелло'");
                    Console.WriteLine("Выберите состовляющие торта. Для переключения используйте 'стрелочки', а для выбора позиции enter");
                    Console.WriteLine("   1. Выбор формы");
                    Console.WriteLine("   2. Выбор размера");
                    Console.WriteLine("   3. Выбор начинки");
                    Console.WriteLine("   4. Конец заказа");
                    Console.WriteLine("цена =" + " " + cena);
                    Console.SetCursorPosition(0, position);
                    Console.WriteLine("-->");
                    clavisha = Console.ReadKey();
                    Console.Clear();
                }
                    if (position == 2)
                  {
                    ConsoleKeyInfo clavisa = Console.ReadKey();
                    int positin = 2;
                    int qqq = 0;
                    while (qqq == 0)
                    {
                        while (clavisa.Key != ConsoleKey.Enter)
                        {
                            if (clavisa.Key == ConsoleKey.UpArrow)
                            {
                                positin--;
                                if (positin < 2)
                                {
                                    positin = 2;
                                }
                            }
                            else if (clavisa.Key == ConsoleKey.DownArrow)
                            {
                                positin++;
                                if (positin > 4)
                                {
                                    positin = 4;
                                }
                            }
                            Console.Clear();
                            Console.WriteLine("Выберите форму:");
                            Console.WriteLine("Для выбора формы нажмите enter");
                            Console.WriteLine("   1. " + var1.Forma);
                            Console.WriteLine("   2. " + var2.Forma);
                            Console.WriteLine("   3. " + var3.Forma);
                            Console.SetCursorPosition(0, positin);
                            Console.WriteLine("-->");
                            clavisa = Console.ReadKey();
                            Console.Clear();
                        }
                        if (positin == 2)
                        {
                            cena = cena + 300;
                            qqq++;
                            korsina.Add(var1.Forma);
                        }
                        else if (positin == 3)
                        {
                            cena = cena + 350;
                            qqq++;
                            korsina.Add(var2.Forma);
                        }
                        else if (positin == 4)
                        {
                            cena = cena + 550;
                            qqq++;
                            korsina.Add(var3.Forma);
                        }
                    }
                    Menu();
                  }
                    else if (position == 3)
                  {
                    ConsoleKeyInfo clavisa = Console.ReadKey();
                    int positin = 2;
                    int qqq = 0;
                    while (qqq == 0)
                    {
                        while (clavisa.Key != ConsoleKey.Enter)
                        {
                            if (clavisa.Key == ConsoleKey.UpArrow)
                            {
                                positin--;
                                if (positin < 2)
                                {
                                    positin = 2;
                                }
                            }
                            else if (clavisa.Key == ConsoleKey.DownArrow)
                            {
                                positin++;
                                if (positin > 4)
                                {
                                    positin = 4;
                                }
                            }
                            Console.Clear();
                            Console.WriteLine("Выберите размер:");
                            Console.WriteLine("Для выбора размера нажмите enter");
                            Console.WriteLine("   1. " + var1.Razmer);
                            Console.WriteLine("   2. " + var2.Razmer);
                            Console.WriteLine("   3. " + var3.Razmer);
                            Console.SetCursorPosition(0, positin);
                            Console.WriteLine("-->");
                            clavisa = Console.ReadKey();
                            Console.Clear();
                        }
                        if (positin == 2)
                        {
                            cena = cena + 800;
                            qqq++;
                            korsina.Add(var1.Razmer);
                        }
                        else if (positin == 3)
                        {
                            cena = cena + 600;
                            qqq++;
                            korsina.Add(var2.Razmer);
                        }
                        else if (positin == 4)
                        {
                            cena = cena + 500;
                            qqq++;
                            korsina.Add(var3.Razmer);
                        }
                    }
                    Menu();
                 }
                    else if (position == 4)
                    {
                    ConsoleKeyInfo clavisa = Console.ReadKey();
                    int positin = 2;
                    int qqq = 0;
                    while (qqq == 0)
                    {
                        while (clavisa.Key != ConsoleKey.Enter)
                        {
                            if (clavisa.Key == ConsoleKey.UpArrow)
                            {
                                positin--;
                                if (positin < 2)
                                {
                                    positin = 2;
                                }
                            }
                            else if (clavisa.Key == ConsoleKey.DownArrow)
                            {
                                positin++;
                                if (positin > 4)
                                {
                                    positin = 4;
                                }
                            }
                            Console.Clear();
                            Console.WriteLine("Выберите начинку:");
                            Console.WriteLine("Для выбора вкуса нажмите enter");
                            Console.WriteLine("   1. " + var1.Vkus);
                            Console.WriteLine("   2. " + var2.Vkus);
                            Console.WriteLine("   3. " + var3.Vkus);
                            Console.SetCursorPosition(0, positin);
                            Console.WriteLine("-->");
                            clavisa = Console.ReadKey();
                            Console.Clear();
                        }
                        if (positin == 2)
                        {
                            cena = cena + 400;
                            qqq++;
                            korsina.Add(var1.Vkus);
                        }
                        else if (positin == 3)
                        {
                            cena = cena + 300;
                            qqq++;
                            korsina.Add(var2.Vkus);
                        }
                        else if (positin == 4)
                        {
                            cena = cena + 600;
                            qqq++;
                            korsina.Add(var3.Vkus);
                        }
                    }
                    Menu();
                }
                    else if (position == 5)
                    {
                        qq++; 
                    }
            }
            Console.Clear();
            End();
        }
        private void End()
        {
            Console.WriteLine("Чтобы сделать еще один заказ нажмите Escape");
            ConsoleKeyInfo clavisa = Console.ReadKey();
            Save();
            int w = 0;
            while (w == 0)
            {
                if (clavisa.Key == ConsoleKey.Escape)
                {
                    w++;
                    cena = 0;
                    Console.Clear();
                    Menu();
                }
                else if (clavisa.Key != ConsoleKey.Escape)
                {
                    w++;
                    Console.Clear();
                }
                Console.WriteLine("Конец заказа");
            }
        }
        private void Save()
        {
            if (File.Exists("C:\\Users\\79671\\Desktop\\Torti.txt"))
            {
                DateTime data = DateTime.Now;
                File.AppendAllText("C:\\Users\\79671\\Desktop\\Torti.txt", " \n " + " текущая дата " + data + " \n " + "Ваш заказ:"+ korsina[0] + " , " + korsina[1] + " , " + korsina[2] + " \n " + "Цена:" + cena + " \n ");
            }
            else
            {
                File.Create("C:\\Users\\79671\\Desktop\\Torti.txt");
                Save();
            }
        }
    } 
}

