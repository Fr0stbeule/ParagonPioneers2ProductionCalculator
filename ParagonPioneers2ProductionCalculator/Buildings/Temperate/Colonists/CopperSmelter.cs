namespace ParagonPioneers2ProductionCalculator.Buildings.Temperate.Colonists;

internal class CopperSmelter : ColonistsBuilding
{
	public override double Minutes => 8;
	public override Material? Production { get; } = new(eGood.CopperIngot, 1);
	public override Material[] Consumption { get; } = [new(eGood.Wood, 4), new(eGood.CopperOre, 1)];
	private protected override string IconName => "CopperSmelter.png";
}