﻿/*
 * Created by SharpDevelop.
 * User: user
 * Date: 08.09.2017
 * Time: 12:31
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace quersumme
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			int zahl = 579;
			
			zahl = calcCrosSum(zahl);
			Console.Write(zahl);
			Console.ReadKey(true);
		}
		

		//Aufgabe 1 
		//
		public static int calcCrosSum(int number) 
		{
			// modulo anwenden um die Reste zu finden
			int moduloRest = number % 10;
			
			//die rest von Modulo von der Nummer abziehen
			number = number - moduloRest;
			
			//Nummer mit 10 teilen
			number = number / 10;
			
			//Wenn der Zahl kein einstelliger Zahle wäre, ruft die Methode sich mit der Zahle
			if (number >= 10) {
				return number = calcCrosSum(number);
			}
			
			return number;
		}
	}
}