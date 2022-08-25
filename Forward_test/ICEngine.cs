namespace Forward_test
{
	class ICEngine : IEngine
	{
		public double I { get; set; }
		public double overheatTemperature { get; set; }
		public double Hm { get; set; }
		public double Hv { get; set; }
		public double C { get; set; }
		public int[] startM { get; set; }
		public int[] startV { get; set; }

		public double M { get; set; }
		public	double V { get; set; }

		public double Vc(double ambientTemperature, double engineTemperature) 
		{
			return C * (ambientTemperature - engineTemperature);
		}

		public double Vh()
        {
			return M * Hm + V * V * Hv;
		}
	}
}
