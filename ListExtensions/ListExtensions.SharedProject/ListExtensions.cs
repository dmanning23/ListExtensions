using System;
using System.Collections.Generic;

namespace ListExtensions
{
	public static class ListExt
	{
		/// <summary>
		/// extension method to shuffle teh contents of the list
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="list"></param>
		public static void Shuffle<T>(this IList<T> list, Random rand)
		{
			for (var i = 0; i < list.Count - 1; i++)
			{
				list.Swap(i, rand.Next(i, list.Count));
			}
		}

		/// <summary>
		/// extension method to swap two elements of a list
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="list"></param>
		/// <param name="i"></param>
		/// <param name="j"></param>
		public static void Swap<T>(this IList<T> list, int i, int j)
		{
			var temp = list[i];
			list[i] = list[j];
			list[j] = temp;
		}
	}
}