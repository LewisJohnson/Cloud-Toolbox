namespace CloudToolbox.Common.Data
{
	/// <summary>
	/// A base class for the singleton design pattern.
	/// </summary>
	/// <typeparam name="T">Class type of the singleton</typeparam>
	public abstract class Singleton<T> where T : class
	{
		private static readonly Lazy<T> sInstance = new(CreateInstanceOfT);

		public static T Instance { get { return sInstance.Value; } }

		private static T CreateInstanceOfT()
		{
			return Activator.CreateInstance(typeof(T), true) as T;
		}

	}
}
