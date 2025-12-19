namespace ParagonPioneers2ProductionCalculator.Buildings.Southern.Workers;

internal class Cemetery : WorkersBuilding
{
	public override double Minutes => 1;
	public override Material? Production { get; } = null;
	public override Material[] Consumption { get; } = [new(eGood.FuneralFlowers, 1)];
	private protected override string IconName => "Cemetery.png";
}