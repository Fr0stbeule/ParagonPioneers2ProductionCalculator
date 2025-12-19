namespace ParagonPioneers2ProductionCalculator.Buildings.Southern.Farmers;

internal class Dairy : FarmersBuilding
{
	public override double Minutes => 2;
	public override Material? Production { get; } = new(eGood.Cheese, 1);
	public override Material[] Consumption { get; } = [new(eGood.Milk, 2)];
	private protected override string IconName => "Dairy.png";
}