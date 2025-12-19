namespace ParagonPioneers2ProductionCalculator.Buildings.Temperate.Merchants;

internal class GoldSmelter : MerchantsBuilding
{
	public override double Minutes => 16;
	public override Material? Production { get; } = new(eGood.GoldIngot, 2);
	public override Material[] Consumption { get; } = [new(eGood.Coal, 1), new(eGood.GoldOre, 2)];
	private protected override string IconName => "GoldSmelter.png";
}