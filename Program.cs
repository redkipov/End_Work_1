using System;
using System.Threading.Tasks;
using System.Threading;

//Итоговая проверочная работа C#
//Программа написана на основе наработок из домашних заданий по пройденным курсам
//Developer by kipov.m.h
//25.09.2022

namespace HomeWork2
{
    class Program
    {
        ////////////Глобальные переменные////////////////
        public const string verDev = "V.0.2.2";
        //////Номер задания//////
        public const string namberWork = "Итоговая проверочная работа C#";
        //////Название программ///////
        public const string programName_1 = "Ввод данных массива с клавиатуры.";
        public const string programName_2 = "Заранее подготовленный массив данных";
        public const string programName_3 = "Null";
        public const string programName_4 = "Null";
        public const string programName_5 = "Null";
        //////////////////////////////
        public static bool loadScrin = true;
        //public static int DownNum = 0;
        //public static int AcermanNum = 0;
        ///////
        
        //////////////////////////////////////////////// Вывод натуральных чисел рекурсия//////////////////////////////////////////////////////

        static void PrintNumNat(int[] arrayUser, int i)
        {
            if (i < arrayUser[1])
            {
                if (i>0) { Console.Write($"{i},"); }
                i++;
                PrintNumNat(arrayUser, i);
            } 
            else if (i == arrayUser[1])
            {
                Console.Write($"{i}.\n");
            }
        }

        //////////////////////////////////////////////// Вывод суммы натуральных чисел рекурсия//////////////////////////////////////////////////////

        static void PrintNumSum(int[] arrayUser, int i, int j)
        {
            if (j < arrayUser[1])
            {
                j++;
                i = i + j;
                PrintNumSum(arrayUser, i, j);
            }
            else if (j == arrayUser[1])
            {
                Console.Write($"Сумма: {i}.\n");
            }
        }
        //////////////////////////////////////////////// Вывод вычислений функции Аккермана рекурсия//////////////////////////////////////////////////////

       static int PrintNumAcerman(int n, int m)
        {
            if (n == 0)           { return m + 1; }
            if (n != 0 && m == 0) { return PrintNumAcerman(n - 1, 1); }
            if (n > 0  && m >  0) { return PrintNumAcerman(n - 1, PrintNumAcerman(n, m - 1)); }

            return PrintNumAcerman(n, m);
        }
        ///////////////////////////////////////// Промежуточное меню для выхода или продолжения программы /////////////////////////////
        static void Contin()
        {
            Console.ForegroundColor = ConsoleColor.Green; // зеленый цвет
            Console.Write("\nНажмите - ");
            Console.ForegroundColor = ConsoleColor.Blue; // синий цвет
            Console.Write("Enter ");
            Console.ForegroundColor = ConsoleColor.Green; // зеленый цвет
            Console.WriteLine("чтобы начать.");
            Console.Write("Нажмите - ");
            Console.ForegroundColor = ConsoleColor.Blue; // синий цвет
            Console.Write("Q, End, Escape ");
            Console.ForegroundColor = ConsoleColor.Green; // зеленый цвет
            Console.WriteLine("чтобы выйти.\n");
            Console.ResetColor();
        }
        //////////////////////////////////// Выход из программы по нажатию кнопок /////////////////////////////////////////////////////
        static int TextWrite(int Exit_Play, string nameProg)
        {
            Contin();

            while (true)
            {
                var pressKey = Convert.ToString(Console.ReadKey().Key);
                if (pressKey == "q0" || pressKey == "End" || pressKey == "Backspace" || pressKey == "Escape" || pressKey == "Q1" || pressKey == "Q" || pressKey == "q")
                {
                    return 0;
                }
                else if (pressKey == "Enter" || pressKey == "Spacebar")
                {
                    return 1;
                }
                else
                {
                    DevWrite(nameProg);
                    Contin();
                    return 3;
                }
            }
        }
        ///////////////////////////////// Очистка экрана и вывод redkipov. ////////////////////////////////////////////////////////////
        static void DevWrite(string s)
        {
            Console.Clear();
            const String nameDev = "redkipov";
            Console.ForegroundColor = ConsoleColor.Cyan; // цвет 
            Console.Write("developer - ");
            Console.ForegroundColor = ConsoleColor.DarkRed; // цвет 
            Console.WriteLine(nameDev);
            Console.ForegroundColor = ConsoleColor.DarkGray; // цвет 
            Console.WriteLine(verDev);
            Console.ForegroundColor = ConsoleColor.Yellow; // цвет 
            Console.WriteLine(s);
            Console.ResetColor();
        }
        /////////////////////////////////////////////////// Меню приветствия //////////////////////////////////////////////////////////
        //___________________________________________________________________________________________________________________________//
        static void WelcomeWrite(string nameProg)
        {
            DevWrite(nameProg);
            Console.ForegroundColor = ConsoleColor.DarkCyan; //  цвет
            Console.WriteLine(namberWork);
            Console.ForegroundColor = ConsoleColor.Green; //  цвет зеленый
            Console.Write("Введите соотвествующую цифру программы, которую вы хотите ");
            Console.ForegroundColor = ConsoleColor.DarkMagenta; //  цвет
            Console.WriteLine("запустить");
            Console.ForegroundColor = ConsoleColor.Blue;   // синий цвет
            Console.Write("[1] "); ////// Первая программа.
            Console.ForegroundColor = ConsoleColor.Yellow; // желтый цвет
            Console.WriteLine(programName_1);
            Console.ForegroundColor = ConsoleColor.Blue;   // синий цвет
            Console.Write("[2] ");
            Console.ForegroundColor = ConsoleColor.Yellow; // желтый цвет
            Console.WriteLine(programName_2); /*
            Console.ForegroundColor = ConsoleColor.Blue;   // синий цвет
            Console.Write("[3] ");
            Console.ForegroundColor = ConsoleColor.Yellow; // желтый цвет
            Console.WriteLine(programName_3); 
            Console.ForegroundColor = ConsoleColor.Blue;   // синий цвет
            Console.Write("[4] ");
            Console.ForegroundColor = ConsoleColor.Yellow; // желтый цвет
            Console.WriteLine(programName_4);
            Console.ForegroundColor = ConsoleColor.Blue;   // синий цвет
            Console.Write("[5] ");
            Console.ForegroundColor = ConsoleColor.Yellow; // желтый цвет
            Console.WriteLine(programName_5); */
            ///////////////////////////////////////////////////////////
            Console.Write("\nНажмите - ");
            Console.ForegroundColor = ConsoleColor.Blue; // синий цвет
            Console.Write("Q, End, Escape ");
            Console.ForegroundColor = ConsoleColor.Green; // зеленый цвет
            Console.WriteLine("чтобы выйти.");
            Console.ResetColor(); // сбрасываем в стандартный
        }
        //############################################### Программа 1 ###############################################################//
        //###########################################################################################################################//
        static void Program_1(int Exit_Play)
        {
            ///////////переменные
            string textUser = "Null";
            string[] arrayUser = new string[21];
            int numText = 0;
            ////////// Вывод меню и отслеживание нажатия кнопки для начала//////////////
            string nameProg = $"[1] {programName_1}";
            DevWrite(nameProg);
            Exit_Play = TextWrite(Exit_Play, nameProg);
            while (Exit_Play == 1)
            {
                while (Exit_Play == 3)
                {
                    DevWrite(nameProg);
                    Exit_Play = TextWrite(Exit_Play, nameProg);
                }
                Console.ResetColor();
                //))))))))))))))))) Logica (((((((((((((((((  
                Console.WriteLine("Введите любой текст через запятую или точку и нажмите Enter");
                Console.WriteLine("Без пробелов. Не больше 20 слов!");
                try
                {
                   textUser = Console.ReadLine();
                   
                    for (int i = 0; textUser.Length > i; i++)
                    {
                        if (',' == textUser[i])
                        {
                            numText++;
                        }
                        else if ('.' == textUser[i])
                        {
                            numText++;
                        }
                        else if (' ' == textUser[i])
                        {
                            //arrayUser[numText] += Convert.ToString(textUser[i]);
                        }
                        else
                        {
                            arrayUser[numText] += Convert.ToString(textUser[i]);
                        }
                       
                    }
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    DevWrite(nameProg);
                    Console.WriteLine("Результат работы: ");
                }
                catch (System.Exception)
                {
                   Console.ForegroundColor = ConsoleColor.DarkRed;
                   DevWrite(nameProg);
                   Console.WriteLine("Вы ничего не ввели. Ошибка!");
                }
                if (numText > 0)
                {
                    for (int i = 0; numText >= i; i++)
                    {
                        Console.WriteLine($"Ваше {i+1} слово: {arrayUser[i]}");
                    }
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("\nДанные из массива, которые меньше 3 символов:");
                    Console.ForegroundColor = ConsoleColor.Green;

                    for (int i = 0; numText >= i; i++)
                    {
                        if (arrayUser[i].Length < 4)
                        {
                            Console.WriteLine($" №{i+1} массива: {arrayUser[i]}");
                        }
                        
                    }
                }
                    numText=0;
                    arrayUser = new string[21];
                
                Exit_Play = TextWrite(Exit_Play, nameProg);
            }
        }
        //############################################### Программа 2 ###############################################################//
        //###########################################################################################################################//
        static void Program_2(int Exit_Play)
        {
            ///////////переменные
            string[] arrayUser = new string[10] {":)","Coding","Возможно","Ты","Генри",":D","3D2А24","F12","$","Рубль"};
            ////////// Вывод меню и отслеживание нажатия кнопки для начала//////////////
            string nameProg = $"[1] {programName_2}";
            DevWrite(nameProg);
            Exit_Play = TextWrite(Exit_Play, nameProg);
            while (Exit_Play == 1)
            {
                while (Exit_Play == 3)
                {
                    DevWrite(nameProg);
                    Exit_Play = TextWrite(Exit_Play, nameProg);
                }
                Console.ResetColor();
                //))))))))))))))))) Logica (((((((((((((((((  
                Console.WriteLine("Введите любой текст через запятую или точку и нажмите Enter");
                Console.WriteLine("Без пробелов. Не больше 20 слов!");
                try
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    DevWrite(nameProg);
                    Console.WriteLine("Результат работы: ");
                }
                catch (System.Exception)
                {
                   Console.ForegroundColor = ConsoleColor.DarkRed;
                   DevWrite(nameProg);
                   Console.WriteLine("Ошибка!");
                }

                    for (int i = 0; arrayUser.Length > i; i++)
                    {
                        Console.WriteLine($"Ваше {i+1} слово: {arrayUser[i]}");
                    }
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("\nДанные из массива, которые меньше 3 символов:");
                    Console.ForegroundColor = ConsoleColor.Green;

                    for (int i = 0; arrayUser.Length > i; i++)
                    {
                        if (arrayUser[i].Length < 4)
                        {
                            Console.WriteLine($" №{i+1} массива: {arrayUser[i]}");
                        }
                        
                    }
                
                Exit_Play = TextWrite(Exit_Play, nameProg);
            }
        }
        //############################################### Программа 3 ###############################################################//
        //###########################################################################################################################//
        static void Program_3(int Exit_Play)
        {
            ///////////переменные
            int[] arrayUser = new int[2];
            ////////// Вывод меню и отслеживание нажатия кнопки для начала//////////////
            string nameProg = $"[3] {programName_3}";
            DevWrite(nameProg);
            Exit_Play = TextWrite(Exit_Play, nameProg);
            while (Exit_Play == 1)
            {
                while (Exit_Play == 3)
                {
                    DevWrite(nameProg);
                    Exit_Play = TextWrite(Exit_Play, nameProg);
                }
                  //Пусто
                
                Exit_Play = TextWrite(Exit_Play, nameProg);
            }
        
        }
        //############################################### Программа скрытая #########################################################//
        //###########################################################################################################################//
        static void Program_7(int Exit_Play)
        {
            ////////// Вывод меню и отслеживание нажатия кнопки для начала//////////////
            string nameProg = "Скрытое меню";
            DevWrite(nameProg);
            Exit_Play = TextWrite(Exit_Play, nameProg);
            while (Exit_Play == 1)
            {
                while (Exit_Play == 3)
                {
                    DevWrite(nameProg);
                    Exit_Play = TextWrite(Exit_Play, nameProg);
                }
                DevWrite(nameProg);
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine(" ");
                Console.ResetColor();
                ////////**************** Logica **************////////
                

                ////////**************** End Logica **************////////
                Exit_Play = TextWrite(Exit_Play, nameProg);
            }
        }
        //******************************************************** MAIN *********************************************************************//
        //###################################################################################################################################//

        static void Main(string[] args)
        {
            var pressKey = "Null";
            const String nameProg = "Главное меню";
            int exitPlay = 1;
            WriteMenu(nameProg);
            while (true)
            {
                /////////////////////////////////////////// Ожидание нажатия кнопки //////////////////////////////////////////
                try
                {
                    pressKey = Convert.ToString(Console.ReadKey().Key);
                    //////////////////////////////////// Выбор пункта меню, нужной программы /////////////////////////////////////
                    if (pressKey == "D1" || pressKey == "NumPad1")
                    {
                        loadScrin = false;
                        //Console.CursorVisible = true;
                        Program_1(exitPlay); //запуск функции
                        loadScrin = true;
                        WriteMenu(nameProg);
                    }
                    else if (pressKey == "D2" || pressKey == "NumPad2")
                    {
                        loadScrin = false;
                        Console.CursorVisible = true;
                        Program_2(exitPlay); //запуск функции
                        loadScrin = true;
                        WriteMenu(nameProg);
                    }
                    else if (pressKey == "D3" || pressKey == "NumPad3")
                    { /*
                        LoadScrin = false;
                        //Console.CursorVisible = true;
                        Program_3(Exit_Play); //запуск функции
                        LoadScrin = true;
                        WriteMenu(NameProg);   */
                    }
                    else if (pressKey == "D4" || pressKey == "NumPad4")
                    { /*
                        LoadScrin = false;
                        Console.CursorVisible = true;
                        Program_4(Exit_Play); //запуск функции
                        LoadScrin = true;
                        WriteMenu(NameProg); */
                    }
                    else if (pressKey == "D5" || pressKey == "NumPad5")
                    { /*
                        LoadScrin = false;
                        Console.CursorVisible = true;
                        Program_5(Exit_Play); //запуск функции
                        LoadScrin = true;
                        WriteMenu(NameProg); */
                    }
                    else if (pressKey == "D6" || pressKey == "NumPad6")
                    {
                        //Program_6(Exit_Play);
                    }
                    else if (pressKey == "D7" || pressKey == "NumPad7")
                    {
                        loadScrin = false;
                        Console.CursorVisible = true;
                        Program_7(exitPlay); //запуск функции
                        loadScrin = true;
                        WriteMenu(nameProg);
                    }
                    else if (pressKey == "q0" || pressKey == "End" || pressKey == "Backspace" || pressKey == "Escape" || pressKey == "Q1" || pressKey == "Q" || pressKey == "q")
                    {
                        System.Environment.Exit(-1);
                        return;
                    }
                }
                catch
                {
                    Console.WriteLine("\nПроизошла ошибка...");
                    //PresskeyP = "Null";
                }
            }
        }


        static void WriteMenu(String nameProg)
        {
            WelcomeWrite(nameProg);
            Console.WriteLine(" ");
            Method();
        }

        ///// BETA
        static async void Method()
        {
            int k = 0;
            char[] LoadString = { '/', '/', '/', '/', '/', '/', '/', '/', '/', '/' };
            ///////////////////////////////////////////////// Task 1
            await Task.Run(() =>
            {
                //async
            });
            ///////////////////////////////////////////////// Task 2
            while (loadScrin)
            {
                await Task.Delay(500);
                k++;
                if (loadScrin)
                {
                    //await Task.Delay(950);
                    //Thread.Sleep(1000);
                    Console.Write($"                                                 \r");
                    try
                    {
                        Console.CursorVisible = false;
                        var Time = DateTime.Now;
                        Console.Write($"{Time}      ");
                    }
                    catch
                    {
                        var Time = DateTime.Now;
                        Console.Write($"{Time}      ");
                    }

                }
                else if (!loadScrin) { return; }
                Console.ForegroundColor = ConsoleColor.Red;
                for (int i = 0; i < k; i++) { Console.Write(LoadString[i]); if (k == LoadString.Length + 1) { k = 0; } }
                Console.ForegroundColor = ConsoleColor.White;
            }
            //await Task.Run(() => Program_7(1) );
        }
    }
    //######################################################## END ###############################################################//
}
//###########################################################################################################################//