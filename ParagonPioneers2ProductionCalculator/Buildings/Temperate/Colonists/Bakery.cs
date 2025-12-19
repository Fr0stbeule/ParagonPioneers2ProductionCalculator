namespace ParagonPioneers2ProductionCalculator.Buildings.Temperate.Colonists;

internal class Bakery : ColonistsBuilding
{
	public override double Minutes => 4;
	public override Material? Production { get; } = new(eGood.Bread, 1);
	public override Material[] Consumption { get; } = [new(eGood.Flour, 1)];
	private protected override string IconName => "Bakery.png";
}