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
			char letter = GetEdgePointLetter(row);
			for (int col = 0; col < diamondSize; col++)
			{
				if (IsEdgePoint(col, midpointRowIndex, row))
				{
					diamondModel[row, col] = letter;
				}
				else
				{
					diamondModel[row, col] = '_';
				}
				
				if (InBottomHalf(row, midpointRowIndex))
				{
					int mirrorRowIndex =  midpointRowIndex - (row - midpointRowIndex);
					diamondModel[row, col] = diamondModel[mirrorRowIndex, col];
				}
			}
		}

		return diamondModel;
	}

	private static bool InBottomHalf(int row, int midpointRowIndex)
	{
		return row > midpointRowIndex;
	}

	private static char GetEdgePointLetter(int row)
	{
		return (char)('A' + row);
	}

	private static bool IsEdgePoint(int row, int col, int midpointRowIndex)
	{
		return col == midpointRowIndex - row || col == midpointRowIndex + row;
	}
}