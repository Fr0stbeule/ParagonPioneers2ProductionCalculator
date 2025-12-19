namespace ParagonPioneers2ProductionCalculator.Buildings.Northern;

internal class CopperSmelter : NorthernBuilding
{
	public override double Minutes => 4;
	public override Material? Production { get; } = new(eGood.CopperIngot, 1);
	public override Material[] Consumption { get; } = [new(eGood.Wood, 2), new(eGood.CopperOre, 1)];
	private protected override string IconName => "CopperSmelter.png";
}