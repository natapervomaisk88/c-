using System;
using DocumentWork;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;


//CIL common intermediate language - промежуточный код

/*
 Машинный код архитектурно зависимый.После компиляции такого кода у нас нет никаких объектов.
Восстановить этот код из exe файла невозможно.
Это основной проблемой.
Все библиотеки, которые подключаются в С++ через include входят в скомпилированный код.
exe файл на C++ весит достаточно много.

Вторая проблема: переносимость (exe работает только для той системы, под которую он компилировался)

Решение: создали промежуточный уровень. Изначально эта идея появилась у Java
Идея: Код на языке программирования, который работает под .NET платформу компиллируется
в промежуточный код (IL - код похож на ассемблер)
На уровне этого кода есть понятие объекта, то есть все объекты и взаимосвязи между ними сохранны.
А значит этот код можно декомпилировать (dotPeek).
IL код не зависит от архитектуры. Он сможет быть выполенным на ПК, где установлен .NET Framework.
На базе .NET Framework есть компилятор, который перевод инструкции из IL кода в команды, 
которые понимает целевой процессор (0 и 1)
Компилируются только те методы, которые нужны. IL - код платформенно-независимый

IL-код - сборка (exe) Assembly

Код на ЯП, который совместим с .NET сначала проходит через компиллятор языка, на котором он написан.
На выходе мы получаем сборку (exe)
Состав сборки:
1) Il код
2) Manifest - техническая информация о платформе (версия например)
3) Метаданные - описание типов
4) Ресурсы, если они есть (картинки например)

Далее сборку можно запускать

Виртуальный загрузчик (VES - Virtual Execution System)
JIT Just In time compilation - идея этой компиляции: компилируются из нашего кода, только те методы, которые
вызваны.
 
Что является единицей компиляции для VES? Ответ: сборка

JIT сопровождает наш exe файл во время всей работы программы

Все .NET языки должны поддерживать:
1) CLS - Common Language Specification
2) CTS - Common Type System
3) Должны реализовывать BCL - Base Class Library
FCL - Framework Class Library 

BCL это подмножество FCL


.NET Core
ASP.NET - технология для создания полноценных веб-приложений
Windows Forms, WPF

CLR - Common Language Runtime - общеязыковая среда выполнения.
Garbage Collector

C# - полностью ООП. Всё в С# - это объекты. Даже типы данных - это объект.

Типы данных.
Все типы данных в С# наследуются от класса System.Object



В CLR есть сборщик мусора, он контролируют кучу. В куче производительность ниже, чем в стеке.
При работе со значимыми типами с value type производительность выше.
Большие объекты, большие иерархии объектов располагаются в куче.
Стек - это этап компиляции, а куча - это этап выполнения
При небольших объемах данных целесообразнее работать в стеке. А значит работать не с классами, а со структурами или
перечислениями.
По стеку есть ограничения - он небольшего размера, к куче доступ менее быстрый, 
но объем у кучи гораздо больше, чем у стека
 */
namespace SPU221_NET
{
 
    internal class Program
    { 
        
        public static void gameBird(IFly bird)
        {
            bird.fly();
        }

        static void Main(string[] args)
        {

            IFly obj;
            obj = new Duck();
            gameBird(obj);
            obj = new Goose();
            gameBird(obj);


            //Point p1 = new Point(3, 4);
            //Point p2 = new Point(3, 4);


            //Console.WriteLine(p1.Equals(p2)); 

            //int r, c;
            //Console.WriteLine("Enter rows: ");
            //r = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter cols: ");
            //c = Convert.ToInt32(Console.ReadLine());
            //MyArray2D arr = new MyArray2D(r,c);


            //Random rnd = new Random();
            //for (int i = 0; i < arr.Rows; i++)
            //{
            //    for (int j = 0; j < arr.Cols; j++)
            //    {
            //        arr[i, j] = rnd.Next(10, 99);
            //        Console.Write(arr[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}


            //MyArray arr = new MyArray(10);
            //arr.Size = 30;
            //Random rnd = new Random();

            //for (int i = 0; i < arr.Size; i++)
            //{
            //    arr[i] = rnd.Next(-10, 20);
            //    Console.WriteLine(arr[i]);
            //}

            // Point p1 = new Point(100, 200);
            // Point p2 = p1 + 10 ;
            // Point p3 = 20 + p1;
            // Console.WriteLine(p2);
            // Point p4= -p2;
            // Console.WriteLine(p4);



            //if(p1>=100)
            // {
            //     Console.WriteLine("OK");
            // }
            //else
            // {
            //     Console.WriteLine("Fail");
            // }


            //if(p1)
            // {
            //     Console.WriteLine("True");
            // }






























            //Point p = new Point(100, 300);
            //Console.WriteLine(p);
            //Console.WriteLine(p.Y);
            //p.Y = -10;
            //Console.WriteLine(p);

            //Point p2 = new Point();
            //Console.WriteLine(p2);

            //Point.GetCountObject();


            //string str1 = "hello", str2 = "hello";

            //Console.WriteLine(str1.StartsWith("eh"));

            //if(String.Compare(str1, str2)==0)
            //{
            //    //строки равны
            //}
            //Console.WriteLine(String.Compare(str1, str2));

            //Console.WriteLine(str1.Equals(str2));

            //Console.WriteLine($"{str1} {str2}"); //интерполяция строк
            //Console.WriteLine(str1[0]);
            //Console.WriteLine(str1.Length);

            //int[] arr = { 1, 4, 3, 5 };


            //int[] arr3 = arr;


            //int[] arr2 = (int[])arr.Clone();
            //arr2[0] = 10;
            //Console.WriteLine(arr[0]);
            //Console.WriteLine(arr2[0]);



            //int[,] arr2D = new int[2, 3] { 
            //    { 1,2,3},
            //    { 3,4,6} 
            //};

            //Console.WriteLine(arr2D.Length);
            //Change2DArr(arr2D);

            //for (int i = 0; i < arr2D.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr2D.GetLength(1); j++)
            //    {
            //        Console.Write(arr2D[i,j]);
            //        Console.Write(" ");
            //    }
            //    Console.WriteLine();
            //}


            //int value;
            //Up(out value);
            //Console.WriteLine(value);



            //int[] arr = { 1, 2, 3, 4, 5 };
            //ChangeArr(ref arr, value);

            //foreach(var el in arr)
            //{
            //    Console.WriteLine(el);
            //}















            //int[] arr = new int[5] {1,2,3,4,5};

            //foreach(var el in arr)
            //{
            //    Console.WriteLine(el);
            //}

            //for(int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}

            //int? Val1 = null;
            //Val1 = Val1 ?? 100;
            //Console.WriteLine(Val1);
            //int num = Val1 ?? 200;
            //Console.WriteLine(num);

            //Document doc = new Document("data", "docx", 230);
            //doc.PrintInf();

            //int n = (int)10.3;

            //double n2 = n;
            //Console.WriteLine(n2);

            ////Генерация случайных чисел
            //Random r = new System.Random();
            //for(int i=0;i<10;i++)
            //{
            //    Console.WriteLine(r.Next(-10, 10));
            //}

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(r.NextDouble()*5);
            //}




            //int value1, value2;
            //Console.WriteLine("Enter first number: ");
            //value1 = Convert.ToInt32(Console.ReadLine());
            ////value1 = Int32.Parse(Console.ReadLine());

            //Console.WriteLine("Enter second number: ");
            //value2 = Convert.ToInt32(Console.ReadLine());

            //int result = value1 + value2;


            //Console.WriteLine("Result: " + result);

            //ValueType value = 10;
            //value = new Car();
            //Console.WriteLine(value);
            //Char n = new Char();
            //Console.WriteLine("Привет!");
            //Console.WriteLine(sizeof(Char));
            //Console.WriteLine(typeof(Char).Name);
            //Console.WriteLine(Char.MinValue);
            //Console.WriteLine(Char.MaxValue);


            //Car c = new Car("opel",2020);

            //Car c2 = new Car();

            //Console.WriteLine("Model: {0}. Year: {1}. IsMove? {2}", c2.getName(), c2.getYear(), c2.getIsMove());

            //int n = 10;
            //Int32 n2 = 10;
            //float n3 = 10.3f;
            //bool bl = true;
            //Console.WriteLine(bl);

        }


        //static void Move(Transport obj)
        //{
        //    obj.Drive();
        //}
        //параметры с out нужно обязательно инициализировать внутри функции
        public static void Up(out int n)
        {
            n = 50;
            n++;
        }

        public static void ChangeArr(ref int[] array, int v)
        {
            array = null;
            array = new int[3] { 7, 8, 9 };
        }

        public static void Change2DArr(int[,] arr)
        {
            arr[0, 0] = 100;
        }
    }
}
