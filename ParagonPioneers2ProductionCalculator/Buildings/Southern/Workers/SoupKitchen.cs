namespace ParagonPioneers2ProductionCalculator.Buildings.Southern.Workers;

internal class SoupKitchen : WorkersBuilding
{
	public override double Minutes => 1;
	public override Material? Production { get; } = new(eGood.Stew, 1);
	public override Material[] Consumption { get; } = [new(eGood.Coconut, 1), new(eGood.Meat, 1)];
	private protected override string IconName => "SoupKitchen.png";
}