namespace ParagonPioneers2ProductionCalculator.Buildings.Temperate.Colonists;

internal abstract class ColonistsBuilding : TemperateBuilding
{
	private protected override string Region => Path.Combine(base.Region, "Colonists");
}