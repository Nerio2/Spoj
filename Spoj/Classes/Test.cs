using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Spoj.Classes
{
	/*
	 * TEST - Life, the Universe, and Everything
	 * Your program is to use the brute-force approach in order to find the Answer to Life, the Universe, and Everything. More precisely... 
	 * rewrite small numbers from input to output. 
	 * Stop processing input after reading in the number 42.
	 * All numbers at input are integers of one or two digits.
	 */
	public class Test
	{
		public static string EndWith42(string optionalInput="")
		{
			StringBuilder response = new StringBuilder(optionalInput);
			string input="";
			do
			{
				response.Append(input + " ");
				input = Console.ReadLine();
			} while (!input.Equals("42"));
			return response.ToString().Trim();
		}
	}
}
