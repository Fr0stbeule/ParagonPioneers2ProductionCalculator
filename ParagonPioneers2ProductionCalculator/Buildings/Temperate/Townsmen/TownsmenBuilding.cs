namespace ParagonPioneers2ProductionCalculator.Buildings.Temperate.Townsmen;

internal abstract class TownsmenBuilding : TemperateBuilding
{
	private protected override string Region => Path.Combine(base.Region, "Townsmen");
}