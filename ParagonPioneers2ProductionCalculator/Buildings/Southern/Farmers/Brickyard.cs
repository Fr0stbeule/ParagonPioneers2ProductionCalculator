namespace ParagonPioneers2ProductionCalculator.Buildings.Southern.Farmers;

internal class Brickyard : FarmersBuilding
{
	public override double Minutes => 4;
	public override Material? Production { get; } = new(eGood.Brick, 2);
	public override Material[] Consumption { get; } = [new(eGood.Coal, 1), new(eGood.Clay, 2)];
	private protected override string IconName => "Brickyard.png";
}