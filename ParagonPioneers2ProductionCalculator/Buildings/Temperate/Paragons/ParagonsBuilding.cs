namespace ParagonPioneers2ProductionCalculator.Buildings.Temperate.Paragons;

internal abstract class ParagonsBuilding : TemperateBuilding
{
	private protected override string Region => Path.Combine(base.Region, "Paragons");
}