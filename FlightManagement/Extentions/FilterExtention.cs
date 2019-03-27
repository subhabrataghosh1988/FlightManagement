using FlightManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FlightManagement.Extentions
{
	/// <summary>
	/// This is an extention method to filter based on a collection
	/// </summary>
	public static class FilterExtention
	{
		/// <summary>
		/// Filter an enumerable based on the expression
		/// </summary>
		/// <typeparam name="TSource"></typeparam>
		/// <param name="source">Source collection</param>
		/// <param name="predicate">Expression to be used in the filter</param>
		/// <returns></returns>
		public static IEnumerable<TSource> Filter<TSource>(this IEnumerable<TSource> source,Func<TSource, bool> predicate)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			if (predicate == null)
			{
				throw new ArgumentNullException("predicate");
			}
			return WhereImpl(source, predicate);
		}
		/// <summary>
		/// Private method with all the predicates
		/// </summary>
		/// <typeparam name="TSource"></typeparam>
		/// <param name="source"></param>
		/// <param name="predicate"></param>
		/// <returns></returns>
		private static IEnumerable<TSource> WhereImpl<TSource>(
			this IEnumerable<TSource> source,
			Func<TSource, bool> predicate)
		{
			foreach (TSource item in source)
			{
				if (predicate(item))
				{
					yield return item;
				}
			}
		}


	}
}
