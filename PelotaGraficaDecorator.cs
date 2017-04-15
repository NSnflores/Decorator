using System;
using System.Threading;

namespace DecoratorPattern
{
	public class PelotaGraficaDecorator : PelotaDecorator, IPelota
	{
		public PelotaGraficaDecorator(IPelota pelota) : base(pelota)
		{
			
		}
		public new void Lanzar()
		{
			base.Lanzar();
			Console.WriteLine("Esto fue lo que pasó:");
			Console.ReadKey();
			bool active = true;
			Thread thread = new Thread(new ThreadStart(delegate 
			{
				int dif = 1; 
				int pos = 1;
				while(active)
				{
						Console.Clear();
						Console.SetCursorPosition(pos,0);
						Console.WriteLine("o");
						Console.WriteLine("Enter para terminar.");
						Console.SetCursorPosition(0,0);
						dif = pos == Console.BufferWidth-1 || pos <= 0 ? -dif : dif;
						pos += dif;
						Thread.Sleep(10);
				}
			}));
			thread.Start ();
			Console.ReadKey ();
			active = false;
		}
	}
}

