// See https://aka.ms/new-console-template for more information

using DiamondKata;

if (args.Length != 1)
{
	Console.WriteLine("The diamond midpoint letter must be provided in the arguments.");
	return;
}

if (args[0].Length > 1)
{
	Console.WriteLine("The midpoint must be a single capital letter.");
	return;
}

var creator = new DiamondCreator();
char[,] diamond = creator.CreateDiamond(args[0][0], ' ');

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