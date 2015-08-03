using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Tests
{
	[TestClass()]
	public class Class1Tests
	{
		[TestMethod()]
		public void GetAreaOfRectangleTest()
		{
			try
			{
				Class1.GetAreaOfRectangle(-1, 1);
				Assert.Fail();
			}
			catch (ArgumentOutOfRangeException)
			{ }
			try
			{
				Class1.GetAreaOfRectangle(1, -1);
				Assert.Fail();
			}
			catch (ArgumentOutOfRangeException)
			{ }
			Assert.AreEqual(6, Class1.GetAreaOfRectangle(2, 3));
			Assert.AreEqual((double)6.9, Class1.GetAreaOfRectangle(2.3, 3),0.1);
		}
	}
}