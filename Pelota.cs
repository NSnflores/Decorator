using System;

namespace DecoratorPattern
{
	 public interface IPelota
	{
		void Lanzar();
	}
	public class Pelota : IPelota
	{
		public Pelota(){}
		public void Lanzar()
		{
			Console.WriteLine("Voló 10 metros..");
		}
	}
	public class PelotaDecorator : IPelota
	{
		protected IPelota pelota;
		public PelotaDecorator(IPelota pelota)
		{
			this.pelota = pelota;
		}
		public void Lanzar()
		{
			pelota.Lanzar ();
			Console.WriteLine ("y la vimos regresar...");
		}
	}
}

