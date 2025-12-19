namespace ParagonPioneers2ProductionCalculator.Buildings.Southern.Farmers;

internal class RoastHouse : FarmersBuilding
{
	public override double Minutes => 2;
	public override Material? Production { get; } = new(eGood.Coffee, 1);
	public override Material[] Consumption { get; } = [new(eGood.CoffeeBeans, 2)];
	private protected override string IconName => "RoastHouse.png";
}