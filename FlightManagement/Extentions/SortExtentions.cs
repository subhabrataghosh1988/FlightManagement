using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FlightManagement.Extentions
{
	/// <summary>
	/// This is an extention method applied to sort data based on the column
	/// </summary>
	public static class SortExtentions
	{
		/// <summary>
		/// Sort a collection based on the property name
		/// </summary>
		/// <typeparam name="TEntity"></typeparam>
		/// <param name="source">Source collection</param>
		/// <param name="orderByProperty">Property name</param>
		/// <param name="desc">True= Descending / False= Ascending</param>
		/// <returns></returns>
		public static IEnumerable<TEntity> Sort<TEntity>(this IEnumerable<TEntity> source,
													string orderByProperty, bool desc)
		{
			string command = desc ? "OrderByDescending" : "OrderBy";
			var type = typeof(TEntity);
			var property = type.GetProperty(orderByProperty);
			var parameter = Expression.Parameter(type, "p");
			var propertyAccess = Expression.MakeMemberAccess(parameter, property);
			var orderByExpression = Expression.Lambda(propertyAccess, parameter);
			var resultExpression = Expression.Call(typeof(Queryable), command,
												   new[] { type, property.PropertyType },
												   source.AsQueryable().Expression,
												   Expression.Quote(orderByExpression));
			return source.AsQueryable().Provider.CreateQuery<TEntity>(resultExpression);
		}
	}
}
