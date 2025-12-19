namespace ParagonPioneers2ProductionCalculator.Buildings.Southern.Farmers;

internal class SportsGround : FarmersBuilding
{
	public override double Minutes => 2;
	public override Material? Production { get; } = null;
	public override Material[] Consumption { get; } = [new(eGood.Ball, 1)];
	private protected override string IconName => "SportsGround.png";
}