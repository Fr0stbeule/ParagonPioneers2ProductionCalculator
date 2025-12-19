namespace ParagonPioneers2ProductionCalculator.Buildings.Southern.Workers;

internal class Costumier : WorkersBuilding
{
	public override double Minutes => 2;
	public override Material? Production { get; } = new(eGood.Costume, 1);
	public override Material[] Consumption { get; } = [new(eGood.Dye, 2), new(eGood.Fabric, 3)];
	private protected override string IconName => "Costumier.png";
}