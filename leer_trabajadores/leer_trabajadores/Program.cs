using System;
using System.IO;
using System.Text;
using System.Collections;

namespace leer_trabajadores
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int sueldo, edad, mayor=0, menor=0;
			string nombre="1", sueldoM="", sueldoMe="";
			StreamReader r;
			r new StreamReader ("/home/luis/a2.txt");

			while (r.EndOfStream==false) 
			{

				nombre = r.ReadLine ();
				edad = Convert.ToInt32 (r.ReadLine ());
				sueldo = Convert.ToInt32 (r.ReadLine ());

				if (sueldo > mayor) 
				{
					mayor = sueldo;
					sueldoM = nombre;
				}
			}
			Console.WriteLine ("El de mayor sueldo es: " + sueldoM);
			
			while (r.EndOfStream==false) 
			{

				nombre = r.ReadLine ();
				edad = Convert.ToInt32 (r.ReadLine ());
				sueldo = Convert.ToInt32 (r.ReadLine ());

				if (sueldo < menor) 
				{
					menor = sueldo;
					sueldoMe = nombre;
				}
			}
			Console.WriteLine ("El trabajdor con mayor sueldo ganado: " + sueldoM);
			r.Close ();
			
		}
	}
}
