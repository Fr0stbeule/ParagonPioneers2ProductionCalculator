namespace ParagonPioneers2ProductionCalculator.Buildings.Southern.Workers;

internal abstract class WorkersBuilding : SouthernBuilding
{
	private protected override string Region => Path.Combine(base.Region,"Workers");
}