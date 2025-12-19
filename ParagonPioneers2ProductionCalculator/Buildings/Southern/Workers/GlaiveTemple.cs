namespace ParagonPioneers2ProductionCalculator.Buildings.Southern.Workers;

internal class GlaiveTemple : WorkersBuilding
{
	public override double Minutes => 20;
	public override Material? Production { get; } = null;
	public override Material[] Consumption { get; } = [new(eGood.Slinger, 4), new(eGood.Glaive, 1)];
	private protected override string IconName => "GlaiveTemple.png";
}