namespace ParagonPioneers2ProductionCalculator.Buildings.Southern.Farmers;

internal class WhimHouse : FarmersBuilding
{
	public override double Minutes => 1.5;
	public override Material? Production { get; } = null;
	public override Material[] Consumption { get; } = [new(eGood.WaterBuffalo, 1)];
	private protected override string IconName => "WhimHouse.png";
}