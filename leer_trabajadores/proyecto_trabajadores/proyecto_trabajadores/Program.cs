using System;
using System.IO;
using System.Text;

namespace proyecto_trabajadores
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			//creador del archivo
			int ca=0;
			int op=0, may=0, men=0;
			//--------------------------------------------------------------------------
			while (op!=7) 
			{

				Console.WriteLine ("elige una opcion:\n" +
					"1--crear archivo\n" +
				    "2--agregar informacion\n" +
				    "3--mostrar contenido\n" +
				    "4--sueldos mas altos\n" +
				    "5--promedio segun edad\n" +
					"6--contar numero de trabajadores regisrados con sueldo mayor a x sueldo\n" +
					"7--salir");
				op=int.Parse(Console.ReadLine());
				switch (op) {
				case 1:
					if (ca == 0) {
						StreamWriter arch = File.AppendText ("sueldos.txt");
						Console.WriteLine ("archivo de registros listo");
						ca = 1;
						arch.Close ();
					} else
						Console.WriteLine ("ya creaste el archivo");
					Console.Read ();
					break;
				case 2:
					agregar ();
					break;
				case 3:
					lista ();
					Console.Read ();
					break;
				case 4:
					sueldosM ();
					Console.Read ();
					break;
				case 5:
					Console.Clear ();
					may = mayor ();
					men = menor ();

					while (men!=may+1) {
						promEdad (men);
						men++;
					}
					Console.Read ();
					break;
				case 6:
					op6 ();
					Console.Read ();
					break;
				case 7:
					Console.WriteLine ("Adios!!");
					break;
				default:
					Console.WriteLine ("opcion invalida");
					break;
				}
			}
		}
		//***********************************************************************************
		//funciones
		public static void agregar ()
		{
			Console.Clear ();
			StreamWriter add = File.AppendText ("sueldos.txt");
			Console.WriteLine ("Agregar un empleado\n" +
			                   "introduce el nombre:");
			add.WriteLine (Console.ReadLine ());
			Console.WriteLine ("introdusca la edad:");
			add.WriteLine (Console.ReadLine ());
			Console.WriteLine ("introdusca el sueldo:");
			add.WriteLine (Console.ReadLine ());
			add.Close ();
		}
		public static void sueldosM ()
		{
			Console.Clear ();
			int sueldo, edad, mayor=0;
			string nombre="1", sueldoM="";
			StreamReader r = new StreamReader ("sueldos.txt");
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

			r.Close ();
			StreamReader r2 = new StreamReader ("sueldos.txt");
			while (r2.EndOfStream==false) 
			{
				nombre = r2.ReadLine ();
				edad = Convert.ToInt32 (r2.ReadLine ());
				sueldo = Convert.ToInt32 (r2.ReadLine ());

				if (sueldo == mayor && nombre != sueldoM) {
					sueldoM +=" " + nombre;
				}
			}
			r2.Close ();
			Console.WriteLine ("el de mayor sueldo es: " + sueldoM);
		}
		public static void lista ()
		{
			Console.Clear ();
			StreamReader r2 = new StreamReader ("sueldos.txt");
			string list = r2.ReadToEnd ();
			Console.WriteLine (list);
			r2.Close ();
		}
		public static void op6 ()
		{
			Console.Clear ();
			StreamReader r2 = new StreamReader ("sueldos.txt");
			int c = 0, x=0;
			int sueldo, edad, mayor=0;
			string nombre = "1";

			Console.WriteLine ("cual es la cantidad a comparar");
			x = int.Parse (Console.ReadLine ());
			while (r2.EndOfStream==false) 
			{
				nombre = r2.ReadLine ();
				edad = Convert.ToInt32 (r2.ReadLine ());
				sueldo = Convert.ToInt32 (r2.ReadLine ());

				if (sueldo > x)
					c++;
			}
			Console.WriteLine ("hay {0} empleados que ganan mas de {1}", c, x);
		}
		public static void promEdad (int edad)
		{
			StreamReader r2 = new StreamReader ("sueldos.txt");
			int c = 0, x=0;
			int sueldo, edad2,p=0;
			string nombre = "1";

			while (r2.EndOfStream==false) 
			{
				nombre = r2.ReadLine ();
				edad2 = Convert.ToInt32 (r2.ReadLine ());
				sueldo = Convert.ToInt32 (r2.ReadLine ());

				if (edad2 == edad) 
				{
					p += sueldo;
					c++;
				}
			}
			if(c!=0)
			Console.WriteLine ("promedio de sueldo para la edad {0} es de {1}", edad, p = p / c);
		}
		public static int menor ()
		{
			int sueldo, edad, edadMenor=100;
			string nombre = "1";
			StreamReader r = new StreamReader ("sueldos.txt");
			while (r.EndOfStream==false) 
			{

				nombre = r.ReadLine ();
				edad = Convert.ToInt32 (r.ReadLine ());
				sueldo = Convert.ToInt32 (r.ReadLine ());

				if (edad < edadMenor) 
				{
					edadMenor = edad;
				}
			}

			r.Close ();
			return edadMenor;
		}
		public static int mayor ()
		{
			int sueldo, edad, edadMayor=0;
			string nombre = "1";
			StreamReader r = new StreamReader ("sueldos.txt");
			while (r.EndOfStream==false) 
			{

				nombre = r.ReadLine ();
				edad = Convert.ToInt32 (r.ReadLine ());
				sueldo = Convert.ToInt32 (r.ReadLine ());

				if (edad > edadMayor) 
				{
					edadMayor = edad;
				}
			}

			r.Close ();
			return edadMayor;
		}
	}
}
