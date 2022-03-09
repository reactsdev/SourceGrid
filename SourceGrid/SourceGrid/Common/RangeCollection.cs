
using System;
using System.Collections.Generic;

namespace SourceGrid
{
	/// <summary>
	/// A collection of elements of type Range
	/// </summary>
	[Serializable]
	public class RangeCollection : List<SourceGrid.Range>
	{
		/// <summary>
		/// Returns true if the specified cell position is present in any range in the current collection.
		/// </summary>
		/// <param name="p_Position"></param>
		/// <returns></returns>
		public bool ContainsCell(Position p_Position)
		{
			foreach(SourceGrid.Range range in this)
			{
				if ( range.Contains(p_Position) )
					return true;
			}
			return false;
		}
	}
}
