using System;

namespace Tarea1
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Persona p= new Persona();
			
			Console.WriteLine ("Datos");
			
				Console.WriteLine("Ingrese su nombre:");
				p.nombre=Console.ReadLine();
					
					Console.WriteLine("Ingrese su edad:");
					p.edad =int.Parse (Console.ReadLine());
						
						Console.WriteLine("Ingrese su correo electronico:");
						p.correo=Console.ReadLine();
			
							Console.WriteLine("\nSus datos son:");
							Console.WriteLine("Nombre: "+ p.nombre);
							Console.WriteLine("Edad: "+ p.edad);
							Console.WriteLine("Correo: "+ p.correo);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}
