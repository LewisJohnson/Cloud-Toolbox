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
		calculatorCollectionsCache ??=
				typeof(CalculatorCollection)
				.Assembly.GetTypes()
				.Where(t => t.IsSubclassOf(typeof(CalculatorCollection)) && !t.IsAbstract)
				.Select(t => (CalculatorCollection)Activator.CreateInstance(t))
				.ToList();

		return calculatorCollectionsCache;
	}

	public CalculatorCollection GetCollectionOfType(CalculatorAreaTypes type)
	{
		return calculatorCollectionsCache.FirstOrDefault(col => col.Type == type);
	}
}
