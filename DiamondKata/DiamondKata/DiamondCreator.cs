namespace DiamondKata;

public class DiamondCreator
{
	public char[,] CreateDiamond(char midpoint)
	{
		if (midpoint == 'A')
		{
			var diamondModel = new char[1, 1];
			diamondModel[0, 0] = 'A';
			
			return diamondModel;
		}
		return null;
	}
}