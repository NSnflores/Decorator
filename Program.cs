using System;

namespace DecoratorPattern
{
	class MainClass
	{
		
		public static void Main (string[] args)
		{
			IPelota pelota = new Pelota ();
			pelota.Lanzar();
			Console.ReadKey();
			Console.Clear();
			pelota = new PelotaGraficaDecorator(pelota);
			pelota.Lanzar ();
		}
	}
}
