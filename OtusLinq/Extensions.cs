namespace OtusLinq
{
	public static class Extensions
	{
		public static IEnumerable<T> Top<T>(this IEnumerable<T> source, int percent) where T : IComparable<T>
		{
			if (percent < 1 || percent > 100)
			{
				throw new ArgumentException("Value must be between 1 and 100.", nameof(percent));
			}

			var sortedList = source.ToList();
			sortedList.Sort((x, y) => y.CompareTo(x));

			int countToTake = (int)Math.Ceiling(sortedList.Count * (percent / 100.0));

			return sortedList.Take(countToTake);
		}

		public static IEnumerable<TSource> Top<TSource, TKey>(this IEnumerable<TSource> source,
			int percent, Func<TSource, TKey> keySelector)
		where TKey : IComparable<TKey>
		{
			if (percent < 1 || percent > 100)
			{
				throw new ArgumentException("Value must be between 1 and 100.", nameof(percent));
			}

			var sortedList = source.OrderByDescending(keySelector).ToList();

			int countToTake = (int)Math.Ceiling(sortedList.Count * (percent / 100.0));

			return sortedList.Take(countToTake);
		}
	}
}
