using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1.Properties;

namespace ClassLibrary1
{
    public class Class1
    {
	    private Class1()
	    {
	    }

	    /// <summary>
		/// This calc area of retangle.
		/// </summary>
		/// <exception cref="ArgumentNullException">If any of parameters is less than zero</exception>
		/// <returns>Returns value of area of a rectangle</returns>
		public static double GetAreaOfRectangle(double a, double b)
	    {
			if(a<0||b<0)throw new ArgumentOutOfRangeException(Resources.less_than_zero);
		    return a*b;
	    }
    }
}
