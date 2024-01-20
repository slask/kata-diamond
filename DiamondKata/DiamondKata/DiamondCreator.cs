namespace DiamondKata;

public class DiamondCreator
{
	public char[,] CreateDiamond(char midpoint)
	{
		if (midpoint < 'A' || 'Z' < midpoint)
		{
			// in the real world something like this could be handled with a Result<T> depending on scenario and location in the architecture 
			throw new ArgumentException("Must be a capital letter of the English alphabet", nameof(midpoint));
		}

		int midpointRowIndex = midpoint - 'A';
		int diamondSize = 2 * (midpointRowIndex + 1) - 1;

		char[,] diamondModel = new char[diamondSize, diamondSize];

		if (midpoint == 'A')
		{
			diamondModel[0, 0] = 'A';
			return diamondModel;
		}

		for (int row = 0; row < diamondSize; row++)
		{
			char valueToPlace = (char)('A' + row);
			for (int col = 0; col < diamondSize; col++)
			{
				if ((row == 0 || row == diamondSize - 1) &&
				    col == midpointRowIndex)
				{
					diamondModel[row, col] = 'A';
				}

				if (col == midpointRowIndex - row || col == midpointRowIndex + row)
				{
					diamondModel[row, col] = valueToPlace;
				}
				else
				{
					diamondModel[row, col] = '_';
				}

				if (row > midpointRowIndex)
				{
					diamondModel[row, col] = diamondModel[midpointRowIndex - (row - midpointRowIndex), col];
				}
			}
		}

		return diamondModel;
	}
}