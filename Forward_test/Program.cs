using System;

namespace Forward_test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ICEngine engine = new ICEngine();
            TestEngine testEngine = new TestEngine();

            engine.I = 0.1;
            engine.overheatTemperature = 110;
            engine.Hm = 0.01;
            engine.Hv = 0.0001;
            engine.C = 0.1;
            engine.startM = new int[] { 20, 75, 100, 105, 75, 0 };
            engine.startV = new int[] { 0, 75, 150, 200, 250, 300 };
            engine.M = engine.startM[0];
            engine.V = engine.startV[0];
            
            Console.WriteLine("Введите температуру окружающий среды в градусах Цельсия: ");

            int ambientTemperature = Convert.ToInt32(Console.ReadLine());
            int resultTime = testEngine.StartTest(engine, ambientTemperature);
            
            if (resultTime == TestEngine.maxTime)
                Console.WriteLine("При такой температуре окружающей среды двигатель не перегревается");
            else
                Console.WriteLine($"Время за которое перегрелся двигатель {resultTime} с.");

            Console.ReadKey();
        }
    }
}
