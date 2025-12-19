namespace ParagonPioneers2ProductionCalculator.Buildings.Temperate.Colonists;

internal class BerserkerHall : ColonistsBuilding
{
	public override double Minutes => 8;
	public override Material? Production { get; } = null;
	public override Material[] Consumption { get; } = [new(eGood.Militia, 1), new(eGood.CopperAxe, 1)];
	private protected override string IconName => "BerserkerHall.png";
}