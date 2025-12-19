namespace ParagonPioneers2ProductionCalculator.Buildings.Northern;

internal class GoldSmelter : NorthernBuilding
{
	public override double Minutes => 8;
	public override Material? Production { get; } = new(eGood.GoldIngot, 1);
	public override Material[] Consumption { get; } = [new(eGood.Wood, 2), new(eGood.GoldOre, 1)];
	private protected override string IconName => "GoldSmelter.png";
}