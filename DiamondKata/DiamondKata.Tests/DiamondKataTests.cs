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
		diamond.Should().NotBeNull();
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

	[Fact]
	public void WhenMidpointIsRandom_ReturnASquareModelOfProperSize()
	{
		//act
		char[,] diamond = _creator.CreateDiamond('C');

		//assert
		diamond.GetLength(0).Should().Be(2 * 3 - 1);
		diamond.GetLength(1).Should().Be(5);

		//act
		char[,] diamond2 = _creator.CreateDiamond('D');

		//assert
		diamond2.GetLength(0).Should().Be(2 * 4 - 1);
		diamond2.GetLength(1).Should().Be(7);
	}

	[Fact]
	public void WhenMidpointIsRandom_PlaceThePeaksOfTheDiamondInTheMiddleColumn()
	{
		//act
		char[,] diamond = _creator.CreateDiamond('C');

		//assert
		diamond[0, 2].Should().Be('A');
		diamond[4, 2].Should().Be('A');
	}

	[Fact]
	public void ForRandomMidpoint_PlaceTheEdgesOfTheDiamond()
	{
		//arrange
		char[,] expectedDiamond = new char[5, 5]
		{
			{ '_', '_', 'A', '_', '_' },
			{ '_', 'B', '_', 'B', '_' },
			{ 'C', '_', '_', '_', 'C' },
			{ '_', 'B', '_', 'B', '_' },
			{ '_', '_', 'A', '_', '_' }
		};
		
		//act
		char[,] diamond = _creator.CreateDiamond('C');

		//assert
		diamond.Should().BeEquivalentTo(expectedDiamond);
	}
}