using System;

namespace Colonizers
{
	/// <summary>
	/// Generates random numbers
	/// </summary>
	static class RandomNumberGenerator
	{
		static Random rand;

		/// <summary>
		/// Initializes the random number generator
		/// </summary>
		static void Initialize()
		{
			rand = new Random();
		}

		/// <summary>
		/// Initialise RandomNumberGenerator with first call 
		/// </summary>
		static RandomNumberGenerator()
		{
			Initialize();
		}

		/// <summary>
		/// Returns a non-negative random integer that is less than the specified 
		/// maximum
		/// </summary>
		/// <param name="maxValue">The exclusive upper bound of the random number 
		///     to be generated (must be greater than or equal to 0)</param>
		/// <returns>A 32-bit integer that is greater than or equal 
		///     to 0, and less than maxValue</returns>
		public static int Next(int maxValue)
		{
			return rand.Next(maxValue);
		}
	}
}
