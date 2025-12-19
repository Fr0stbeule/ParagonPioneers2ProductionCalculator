namespace ParagonPioneers2ProductionCalculator.Buildings.Northern;

internal class IronSmelter : NorthernBuilding
{
	public override double Minutes => 8;
	public override Material? Production { get; } = new(eGood.IronIngot, 2);
	public override Material[] Consumption { get; } = [new(eGood.Coal, 1), new(eGood.IronOre, 2)];
	private protected override string IconName => "IronSmelter.png";
}