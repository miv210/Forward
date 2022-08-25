namespace Forward_test
{
    class TestEngine
    {
        public const int maxTime = 1800;
        int nubmerOfMandV = 0;
        double engineTemperature;
        double ABSOLUTE_ERROR = 0.1;
        public int StartTest(ICEngine engine, int ambientTemperature)
        { 
            engineTemperature = ambientTemperature;
            double a = engine.M * engine.I;
            double eps = engine.overheatTemperature - engineTemperature;
            int time = 0;
            while(eps > ABSOLUTE_ERROR && time < maxTime)
            {
                time++;
                engine.V += a;
                if(nubmerOfMandV < engine.startM.Length - 2)
                {
                    nubmerOfMandV += engine.V < engine.startV[nubmerOfMandV + 1] ? 1 : 0;
                }
                double up = (engine.V - engine.startV[nubmerOfMandV]);
                double down = (engine.startV[nubmerOfMandV + 1] - engine.startV[nubmerOfMandV]);
                double factor = (engine.startM[nubmerOfMandV + 1] - engine.startM[nubmerOfMandV]);
                engine.M = up / down * factor + engine.startM[nubmerOfMandV];

                engineTemperature += engine.Vc(ambientTemperature, engineTemperature) + engine.Vh();

                a = engine.M * engine.I;

                eps = engine.overheatTemperature - engineTemperature;
            }
            return time;
        }
    }
}
