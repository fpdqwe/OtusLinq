namespace OtusLinq
{
	internal class Program
	{
		private static readonly List<int> _intList = new List<int>{1,2,3,4,5,6,7,8,9};
		private static readonly List<Person> _persons = new List<Person>
		{
			new Person("bob", 1),
			new Person("alice", 2),
			new Person("name3", 3),
			new Person("name4", 4),
			new Person("name5", 5),
			new Person("name6", 6),
			new Person("name7", 7),
			new Person("name8", 8),
			new Person("name9", 9)
		};
		static void Main(string[] args)
		{
			var newIntList = _intList.Top(30);
			foreach (int i in newIntList)
			{
				Console.WriteLine(i);
			}
			var newPersonList = _persons.Top(30, person => person.Age);
			foreach(var person in newPersonList)
			{
				Console.WriteLine($"{person.Name} - {person.Age}");
			}
		}
	}
}
