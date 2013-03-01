using System;

namespace Application
{
	public class Persona
	{
		public string Nombre;
		public string Telefono;
		public string Email;
		public string Domicilio;

		public static void Main(string[] args){

			Persona persona2 =new Persona(); 
			Console.WriteLine("Dame tu Nombre");
			persona2.Nombre=Console.ReadLine();
			Console.WriteLine("Dame tu Telefono:");
			persona2.Telefono=Console.ReadLine();
			Console.WriteLine("Dame tu Email:");
			persona2.Email=Console.ReadLine;
			Console.WriteLine("Dame tu Domicilio:");
			persona2.Domicilio=Console.ReadLine;
			Console.WriteLine("El nombre es:"+persona2.Nombre);
			Console.WriteLine("Telefono:"+persona2.Telefono);
			Console.WriteLine("Email"+persona2.Email);
			Console.WriteLine("Domicilio:"+persona2.Domicilio);






		}
	
	
	
	
	
	
	}
}

