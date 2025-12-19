namespace ParagonPioneers2ProductionCalculator.Buildings.Southern.Workers;

internal class GlaiveSmith : WorkersBuilding
{
	public override double Minutes => 8;
	public override Material? Production { get; } = new(eGood.Glaive, 1);
	public override Material[] Consumption { get; } = [new(eGood.FineWood, 1), new(eGood.Gemstone, 2), new(eGood.CopperIngot, 1)];
	private protected override string IconName => "GlaiveSmith.png";
}