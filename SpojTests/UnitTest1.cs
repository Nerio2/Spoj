using Spoj.Classes;
using System;
using Xunit;

namespace SpojTests
{
	public class UnitTest1
	{
		[Fact]
		public void EndWith42Test()
		{
			Assert.Equal("1 2 88", Test.EndWith42("1 2 88 42 99"));
		}
	}
}
