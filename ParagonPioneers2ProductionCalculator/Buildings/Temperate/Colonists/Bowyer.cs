namespace ParagonPioneers2ProductionCalculator.Buildings.Temperate.Colonists;

internal class Bowyer : ColonistsBuilding
{
	public override double Minutes => 4;
	public override Material? Production { get; } = new(eGood.Bow, 1);
	public override Material[] Consumption { get; } = [new(eGood.Fiber, 2), new(eGood.Wood, 3)];
	private protected override string IconName => "Bowyer.png";
}