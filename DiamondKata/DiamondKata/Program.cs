// See https://aka.ms/new-console-template for more information

using DiamondKata;

var creator = new DiamondCreator();
char[,] diamond = creator.CreateDiamond('H');

PrintDiamondModel(diamond);

void PrintDiamondModel(char[,] diamondModel)
{
	for (int i = 0; i < diamondModel.GetLength(0); i++)
	{
		for (int j = 0; j < diamondModel.GetLength(1); j++)
		{
			Console.Write(diamondModel[i, j]);
		}

		Console.WriteLine();
	}
}