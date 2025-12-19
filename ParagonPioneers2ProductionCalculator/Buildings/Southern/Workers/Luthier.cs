namespace ParagonPioneers2ProductionCalculator.Buildings.Southern.Workers;

internal class Luthier : WorkersBuilding
{
	public override double Minutes => 2;
	public override Material? Production { get; } = new(eGood.Guitar, 8);
	public override Material[] Consumption { get; } = [new(eGood.BrassIngot, 1), new(eGood.FineWood, 8)];
	private protected override string IconName => "Luthier.png";
}