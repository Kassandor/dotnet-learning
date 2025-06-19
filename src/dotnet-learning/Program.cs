using System.Text;
using ExtensionsLibrary;

namespace dotnet_learning
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            HelloWorld.SayHello();

            Console.WriteLine();
            NumbersFormatExample.WriteLineNumber();
            StringFormatExample.StringToInt();

            Console.WriteLine();
            ArithmeticOperations.Divide(10, 10);
            ArithmeticOperations.Divide(10.0, 10); // Перегрузка, выбирается double
            ArithmeticOperations.Divide(10, 10.0); // Перегрузка, выбирается double

            Console.WriteLine();
            IncrementDecrement.PostFixForEach();
            IncrementDecrement.PreFixForEach();

            Console.WriteLine();
            SwitchCase.SwitchCaseExample(1);
            SwitchCase.SwitchCaseExample();
            // Ввести TAB для проверки, что падает исключение
            Console.WriteLine("Нажми <TAB> для проверки");
            SwitchCase.SwitchCaseTryCatchExample(Console.ReadKey().Key);

            Console.WriteLine();
            ForCycle.ForExample();

            Console.WriteLine();
            ArraysExample.ArrayExample();
            // LINQ to arrays Example
            ArraysExample.ArrayExample2();

            Console.WriteLine();
            RangesExample.RangeExample();

            Console.WriteLine();
            MultiArray.TwoDimensionalArray();
            Console.WriteLine();
            MultiArray.JaggedArray();
            Console.WriteLine();
            MultiArray.ThreeDimensionalArray();

            Console.WriteLine();
            var a = 10;
            RefVarsExample.RefExample(ref a, 15);

            Console.WriteLine();
            InExample.Example(10);

            // Пример бесконечной рекурсии, которая в итоге переполнит стек
            // RecurseExample.Example();
            Console.WriteLine();
            // Ядерный Ганди
            ArithmeticOverflowExample.Example();
            ArithmeticOverflowExample.Example2();

            Console.WriteLine();
            EnumExample.Example();

            Console.WriteLine();
            // Initialize example
            // Сначала вызовется secondary конструктор, затем primary
            var gun = new Gun("Проверка, какой конструктор вызовется первым");
            gun.Shoot();

            Console.WriteLine();
            // Статический конструктор
            var dbRepository = new DbRepository();
            dbRepository.GetData();

            // Extension класс ExtensionsExample действует на все объекты типа DateTime
            Console.WriteLine();
            DateTime.Now.WriteDateTime();

            Console.WriteLine();
            var partialExample = new PartialExamples("alex", "alex");
            partialExample.PrintFullName();

            // Пример наследования
            Console.WriteLine();
            var point3d = new Point3D("Тестовый месседж");

            // Пример абстрактного класса и метода
            Console.WriteLine();
            var weaponGun = new WeaponGun();
            Player.Fire(weaponGun);
            Player.CheckInfo(weaponGun);

            // Пример реализации интерфейсов
            Console.WriteLine();
            var dataProcessor = new ConsoleDataProcessor();
            foreach (var provider in new IDataProvider[]
                         { new DbDataProvider(), new ApiDataProvider(), new FileDataProvider() })
            {
                dataProcessor.ProcessData(provider);
            }
            
            // Пример явной реализации интерфейсов
            Console.WriteLine();
            IFirstInterface firstInterfaceInstance = new ExplicityInterfaceExample();
            firstInterfaceInstance.Action();
            ISecondInterface secondInterfaceInstance = new ExplicityInterfaceExample();
            secondInterfaceInstance.Action();
            
            Console.WriteLine();
            // Пример упаковки
            // p будет упакован в тип интерфейса, потому что интерфейсы - ссылочные типы
            IPrintable p = new Point();
            p.Print();
            
            // В данном случае, упаковки не будет
            var p2 = new Point();
            // А тут все зависит от реализации Print()
            p2.Print();
        }
    }
}