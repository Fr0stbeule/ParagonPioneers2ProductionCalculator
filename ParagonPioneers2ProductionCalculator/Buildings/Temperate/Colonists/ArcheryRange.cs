namespace ParagonPioneers2ProductionCalculator.Buildings.Temperate.Colonists;

internal class ArcheryRange : ColonistsBuilding
{
	public override double Minutes => 5;
	public override Material? Production { get; } = null;
	public override Material[] Consumption { get; } = [new(eGood.Militia, 1), new(eGood.Bow, 1)];
	private protected override string IconName => "ArcheryRange.png";
}