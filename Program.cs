using System;

namespace TestTask
{
	class MainClass
	{
        // 10^9, near to the max char[] and string size 
		private const int MaxSize = 1000000000;

		public static void Main (string[] args)
		{
			string example = (string) "abcdefghijklmnoprstu";
			int[] arrayExample = {4, 6, 7, 8, 2, 320, 34, 67, 87, 15};
			// Test output: 
			Console.WriteLine ("Original string: " + example);
			Console.WriteLine ("Reversed string: " + reverse(example));
			Console.WriteLine ();
			Console.WriteLine ("Numbers array: " + string.Join(",", arrayExample));
			Console.WriteLine ("Largest value: " + findLargest(arrayExample));
		}
		public static int? findLargest ( int[] input ) {
			int arrayLength = input.Length; 
			// Checking array for emptiness
			if (arrayLength == 0) return null;
			// Checking array for overflow
			if (arrayLength > MaxSize) {
				throw new System.ArgumentException("Array is too big", "original");
			}
			int result = input [0];
			for (int i = 1; i < arrayLength - 1; ++i) {
				result = result > input [i] ? result : input [i];
			}
			return result;
		}
		public static string reverse ( string s ) {
			int stringLength = s.Length;
			// Checking array for overflow
			// No much sense because we already have string with no overflow
			if (stringLength > MaxSize) {
				throw new System.ArgumentException ("String is too long", "original");
			}
			char[] charArr = s.ToCharArray ();
			// Iterating only through the half of string, switching char's on both sides
			for (int i = 0; i < stringLength / 2; ++i) {
				charArr [i] = s [stringLength - i - 1];
				charArr [stringLength - i - 1] = s [i];
			}
			string result = new string (charArr);
			return result;
		}
	}
}
