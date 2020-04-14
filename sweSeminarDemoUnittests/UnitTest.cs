using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace sweSeminarDemoUnittests
{
	[TestClass]
	public class UnitTests
	{
		[TestMethod]
		public void TestAPlusB()
		{
			Assert.AreEqual(3, MyMath.Add(1, 2));
		}
		[TestMethod]
		public void TestAMultipliedByB()
		{
			Assert.AreEqual(15, MyMath.Multiply(3, 5));
		}
	}
}
