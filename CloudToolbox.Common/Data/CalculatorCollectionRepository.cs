using CloudToolbox.Common.Data.DisplayCalculatorCollections;
using CloudToolbox.Common.Enums;
using CloudToolbox.Common.Routes;
using static System.Net.Mime.MediaTypeNames;

namespace CloudToolbox.Common.Data;

public static class CalculatorCollectionRepository
{
	public static List<CalculatorCollection> CalculatorCollectionsCache;

	public static List<CalculatorCollection> GetCollections()
	{
		return new List<CalculatorCollection>()
		{
			new UnitsCalculatorCollection(),
			new DateAndTimeCalculatorCollection(),
			new TextCalculatorCollection()
		};
	}

	//public static CalculatorCollection DateAndTime = new()
	//{
	//};

	//public static CalculatorCollection Developer = new()
	//{
	//};

	//public static CalculatorCollection Maths = new()
	//{

	//};

	//public static CalculatorCollection Text = new()
	//{

	//};

	//public static CalculatorCollection Travel = new()
	//{

	//};
}
