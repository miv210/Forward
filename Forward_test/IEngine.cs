namespace Forward_test
{
	interface IEngine
	{
		double I { get; }
		double overheatTemperature { get; }
		double Hm { get; }
		double Hv { get; }
		double C { get; }
		int [] startM  { get; }
		int [] startV { get; }

		double M { get; }
		double V { get; }

		double Vc(double ambientTemperature, double engineTemperature);
		double Vh();
	}
}
