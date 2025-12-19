namespace ParagonPioneers2ProductionCalculator.Buildings.Temperate.Colonists;

internal class Barracks : ColonistsBuilding
{
	public override double Minutes => 10;
	public override Material? Production { get; } = null;
	public override Material[] Consumption { get; } = [new(eGood.Militia, 1), new(eGood.CopperSword, 1)];
	private protected override string IconName => "Barracks.png";
}