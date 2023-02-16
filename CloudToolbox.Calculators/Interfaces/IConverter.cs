namespace CloudToolbox.Calculators.Interfaces
{
	public interface IConverter<T>
	{
		public T Convert(T val);
	}
}
