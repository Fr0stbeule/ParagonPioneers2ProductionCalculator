namespace ParagonPioneers2ProductionCalculator.Buildings.Temperate.Pioneers;

internal abstract class PioneersBuilding : TemperateBuilding
{
	private protected override string Region => Path.Combine(base.Region, "Pioneers");
}