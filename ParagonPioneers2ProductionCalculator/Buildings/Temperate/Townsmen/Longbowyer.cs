namespace ParagonPioneers2ProductionCalculator.Buildings.Temperate.Townsmen;

internal class Longbowyer : TownsmenBuilding
{
	public override double Minutes => 4;
	public override Material? Production { get; } = new(eGood.Longbow, 1);
	public override Material[] Consumption { get; } = [new(eGood.Fiber, 2), new(eGood.Wood, 10)];
	private protected override string IconName => "Longbowyer.png";
}