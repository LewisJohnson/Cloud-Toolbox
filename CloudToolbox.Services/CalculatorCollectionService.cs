using CloudToolbox.Common.Data;
using CloudToolbox.Common.Enums;

namespace CloudToolbox.Services;

public class CalculatorCollectionService
{
	private List<CalculatorCollection> calculatorCollectionsCache;

	public CalculatorCollectionService()
	{
	}

	public List<CalculatorCollection> GetCollections()
	{
#pragma warning disable CS8619 // Nullability of reference types in value doesn't match target type.
		calculatorCollectionsCache ??=
				typeof(CalculatorCollection)
				.Assembly.GetTypes()
				.Where(t => t.IsSubclassOf(typeof(CalculatorCollection)) && !t.IsAbstract)
				.Select(t => Activator.CreateInstance(t) as CalculatorCollection)
				.ToList();
#pragma warning restore CS8619 // Nullability of reference types in value doesn't match target type.

		return calculatorCollectionsCache;
	}

	public CalculatorCollection GetCollectionOfType(CalculatorAreaTypes type)
	{
		return calculatorCollectionsCache.First(col => col.Type == type);
	}
}
