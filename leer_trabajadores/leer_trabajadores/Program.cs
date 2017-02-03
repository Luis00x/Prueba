using System;
using System.IO;
using System.Text;
using System.Collections;

namespace leer_trabajadores
{
	class MainClass
	{
		public static void Main (string[] args)
		{       // aqui se inicializan las variables
			int Sueldo, edad, Mayor=0, menor=0;
			string nombre="1", sueldoM="", sueldoMe="";
			StreamReader r;
			r new StreamReader ("/home/luis/a2.txt");
			//aqui se hace un ciclo y lee el documento hasta que se mande false 
			while (r.EndOfStream==false) 
			{

				nombre = r.ReadLine ();
				edad = Convert.ToInt32 (r.ReadLine ());
				sueldo = Convert.ToInt32 (r.ReadLine ());
				
				if (Sueldo > Mayor) 
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
