namespace ParagonPioneers2ProductionCalculator.Buildings.Southern.Farmers;

internal class BallMaker : FarmersBuilding
{
	public override double Minutes => 2;
	public override Material? Production { get; } = new(eGood.Ball, 1);
	public override Material[] Consumption { get; } = [new(eGood.Leather, 1)];
	private protected override string IconName => "BallMaker.png";
}