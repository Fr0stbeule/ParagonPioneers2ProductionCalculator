namespace ParagonPioneers2ProductionCalculator.Buildings.Southern.Workers;

internal class Rickyard : WorkersBuilding
{
	public override double Minutes => 1;
	public override Material? Production { get; } = null;
	public override Material[] Consumption { get; } = [new(eGood.Wheat, 1)];
	private protected override string IconName => "Rickyard.png";
}