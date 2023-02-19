using System.Reflection;

namespace CloudToolbox.Common.Data
{
	public abstract class Enumeration : IComparable
	{
		public string Name { get; protected set; }

		public int Id { get; protected set; }

		protected Enumeration(int id, string name) => (Id, Name) = (id, name);

		public override string ToString() => Name;

		public static IEnumerable<T> GetAll<T>() where T : Enumeration =>
			typeof(T).GetFields(BindingFlags.Public |
								BindingFlags.Static |
								BindingFlags.DeclaredOnly)
					 .Select(f => f.GetValue(null))
					 .Cast<T>();

		public override bool Equals(object? obj)
		{
			if (obj is not Enumeration otherValue)
			{
				return false;
			}

			var typeMatches = GetType().Equals(obj.GetType());
			var valueMatches = Id.Equals(otherValue.Id);

			return typeMatches && valueMatches;
		}

		public int CompareTo(object? other)
		{
			if (other == null)
			{
				return 1;
			}

			return Id.CompareTo(((Enumeration)other).Id);
		}

		public override int GetHashCode()
		{
			return HashCode.Combine(Name, Id);
		}
	}
}
