using System.Reflection;
using CloudToolbox.Common.Data;
using CloudToolbox.Common.Enums;

namespace CloudToolbox.Services;

public class CalculatorCollectionService
{
	public List<CalculatorCollection> CalculatorCollectionsCache;

	public CalculatorCollectionService()
	{
	}

	public List<CalculatorCollection> GetCollections()
	{
		if (CalculatorCollectionsCache == null)
		{
			CalculatorCollectionsCache =
				typeof(CalculatorCollection)
				.Assembly.GetTypes()
				.Where(t => t.IsSubclassOf(typeof(CalculatorCollection)) && !t.IsAbstract)
				.Select(t => (CalculatorCollection)Activator.CreateInstance(t))
				.ToList();
		}

		return CalculatorCollectionsCache;
	}

	public CalculatorCollection GetCollectionOfType(CalculatorAreaTypes type)
	{
		return CalculatorCollectionsCache.FirstOrDefault(col => col.Type == type);
	}
}
