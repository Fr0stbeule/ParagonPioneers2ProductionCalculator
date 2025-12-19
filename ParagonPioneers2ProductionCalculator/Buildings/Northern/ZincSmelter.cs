namespace ParagonPioneers2ProductionCalculator.Buildings.Northern;

internal class ZincSmelter : NorthernBuilding
{
	public override double Minutes => 6;
	public override Material? Production { get; } = new(eGood.ZincIngot, 1);
	public override Material[] Consumption { get; } = [new(eGood.Wood, 2), new(eGood.ZincOre, 1)];
	private protected override string IconName => "ZincSmelter.png";
}