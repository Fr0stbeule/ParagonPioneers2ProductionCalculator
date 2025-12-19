namespace ParagonPioneers2ProductionCalculator.Buildings.Temperate.Merchants;

internal class IronSmelter : MerchantsBuilding
{
	public override double Minutes => 16;
	public override Material? Production { get; } = new(eGood.IronIngot, 2);
	public override Material[] Consumption { get; } = [new(eGood.Coal, 1), new(eGood.IronOre, 2)];
	private protected override string IconName => "IronSmelter.png";
}