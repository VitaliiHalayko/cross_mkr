using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("cross_mkr.Tests")]
namespace cross_mkr
{
	public static class IO 
	{
		private const string inputFilePath = "INPUT.txt";
		private const string outputFilePath = "OUTPUT.txt";

		public static (int n, int k) readDataFromFile() 
		{
			if (File.Exists(inputFilePath))
			{
				// Read all lines from the file
				string[] lines = File.ReadAllLines(inputFilePath);

				if (lines.Length == 2)
				{
					// Parse the first line as integer 'n' and the second line as integer 'k'
					try {
						int n = int.Parse(lines[0]);
						int k = int.Parse(lines[1]);

						return (n, k);
					} catch (FormatException e) {
						// If the file contains invalid data, throw an error message
						throw new IOException("Input data is incorrect! The file must contain exactly 2 int values.");
					}
				}
				else
				{
					// If the file does not contain exactly 2 lines, throw an error message
					throw new IOException("Input data is incorrect! The file must contain exactly 2 lines.");
				}
			}
			else
			{
				// If the file is not found, throw an error message
				throw new IOException("Input data is incorrect! The file must contain exactly 2 lines.");
			}
		}

		public static void writePermutationToFile(int[] permutation) 
		{
			// Write the permutation to the file
			File.WriteAllText(outputFilePath, string.Join(" ", permutation));
		}

		public static void writeErrorToFile(string errorMessage) 
		{
			// Write the error message to the file
			File.WriteAllText(outputFilePath, errorMessage);
		}
	}	
}