using FluentAssertions;

namespace DiamondKata.Tests;

public class DiamondKataTests
{
	private readonly DiamondCreator _creator = new();

	[Fact]
	public void DesignPubicApi()
	{
		//act
		char[,] diamond = _creator.CreateDiamond('Z');

		//assert
		diamond.Should().BeNull();
	}

	[Fact]
	public void When_MidpointIsA_Then_DiamondIsADot()
	{
		//act
		char[,] diamond = _creator.CreateDiamond('A');

		//assert
		diamond.GetLength(0).Should().Be(1);
		diamond.GetLength(1).Should().Be(1);
		diamond[0, 0].Should().Be('A');
	}

	[Fact]
	public void When_MidpointIsNotACapitalLetter_ThrowArgumentException()
	{
		Action createLeft = () => _creator.CreateDiamond((char)('A' - 1));
		createLeft.Should().Throw<ArgumentException>();

		Action createRight = () => _creator.CreateDiamond((char)('Z' + 1));
		createRight.Should().Throw<ArgumentException>();
	}
}