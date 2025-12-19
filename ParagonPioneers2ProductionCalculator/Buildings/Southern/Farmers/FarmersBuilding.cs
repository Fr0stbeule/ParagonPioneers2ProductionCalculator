namespace ParagonPioneers2ProductionCalculator.Buildings.Southern.Farmers;

internal abstract class FarmersBuilding : SouthernBuilding
{
	private protected override string Region => Path.Combine(base.Region, "Farmers");
}