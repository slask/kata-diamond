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

	[Fact]
	public void When_MidpointIsA_Then_DiamondIsADot()
	{
		//arrange
		var creator = new DiamondCreator();

		//act
		char[,] diamond = creator.CreateDiamond('A');

		//assert
		diamond.GetLength(0).Should().Be(1);
		diamond.GetLength(1).Should().Be(1);
		diamond[0, 0].Should().Be('A');
	}
}