namespace ParagonPioneers2ProductionCalculator.Buildings.Temperate.Colonists;

internal class Rickyard : ColonistsBuilding
{
	public override double Minutes => 1;
	public override Material? Production { get; } = null;
	public override Material[] Consumption { get; } = [new(eGood.Wheat, 1)];
	private protected override string IconName => "Rickyard.png";
}