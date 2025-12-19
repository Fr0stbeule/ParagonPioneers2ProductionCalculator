namespace ParagonPioneers2ProductionCalculator.Buildings.Southern.Farmers;

internal class CoffeeHouse : FarmersBuilding
{
	public override double Minutes => 4;
	public override Material? Production { get; } = null;
	public override Material[] Consumption { get; } = [new(eGood.Coffee, 1)];
	private protected override string IconName => "CoffeeHouse.png";
}