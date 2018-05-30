using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLesson2
{
	class Program
	{

		static int Add(int nbr, int inc)
		{
			return nbr + inc;
		}

		static int Add1(int nbr)
		{
			return Add(nbr,1);
		}
		static void Main(string[] args)
		{
			int nbrs = 12;
			int result = Add1(nbrs);
			Console.WriteLine("{0} Add1 is {1}", nbrs, result);
			result = Add(nbrs, -2);
			Console.WriteLine("{0} Add is {1}", nbrs, result);
		}

		
	}


}
