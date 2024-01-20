using FluentAssertions;

namespace DiamondKata.Tests;

public class DiamondKataTests
{
	[Fact]
	public void DesignPubicApi()
	{
		//arrange
		var creator = new DiamondCreator();

		//act
		char[,] diamond = creator.CreateDiamond('A');

		//assert
		diamond.Should().BeNull();
	}
}