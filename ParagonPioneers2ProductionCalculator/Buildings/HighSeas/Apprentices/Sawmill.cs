namespace ParagonPioneers2ProductionCalculator.Buildings.HighSeas.Apprentices;

internal class Sawmill : ApprenticeBuilding
{
	public override double Minutes => 0.5;
	public override Material? Production { get; } = new(eGood.Plank, 3);
	public override Material[] Consumption { get; } = [new(eGood.Wood, 2)];
	private protected override string IconName => "Sawmill.png";
}