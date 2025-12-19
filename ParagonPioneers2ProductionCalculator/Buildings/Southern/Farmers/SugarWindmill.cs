namespace ParagonPioneers2ProductionCalculator.Buildings.Southern.Farmers;

internal class SugarWindmill : FarmersBuilding
{
	public override double Minutes => 4;
	public override Material? Production { get; } = new(eGood.Sugar, 1);
	public override Material[] Consumption { get; } = [new(eGood.SugarCane, 2)];
	private protected override string IconName => "SugarWindmill.png";
}