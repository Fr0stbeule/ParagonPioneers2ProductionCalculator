namespace ParagonPioneers2ProductionCalculator.Buildings.Temperate.Colonists;

internal class CopperAxesmith : ColonistsBuilding
{
	public override double Minutes => 8;
	public override Material? Production { get; } = new(eGood.CopperAxe, 1);
	public override Material[] Consumption { get; } = [new(eGood.Wood, 4), new(eGood.CopperIngot, 1)];
	private protected override string IconName => "CopperAxesmith.png";
}