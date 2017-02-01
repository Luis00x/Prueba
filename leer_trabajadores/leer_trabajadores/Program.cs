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
			int sueldo, edad, mayor=0;
			string nombre="1", sueldoM="";
			StreamReader r = new StreamReader ("/home/luis/a2.txt");

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
			Console.WriteLine ("el de mayor sueldo es: " + sueldoM);
			r.Close ();
			/*StreamWriter x = File.AppendText ("/home/luis/edades.txt");
			StreamReader s = new StreamReader ("/home/luis/edades.txt");
			while (s.EndOfStream==false) 
			{

				nombre = s.ReadLine ();
				edad = Convert.ToInt32 (s.ReadLine ());
				sueldo = Convert.ToInt32 (s.ReadLine ());

			}*/
		}
	}
}
