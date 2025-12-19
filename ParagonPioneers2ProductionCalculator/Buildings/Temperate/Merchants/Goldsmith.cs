namespace ParagonPioneers2ProductionCalculator.Buildings.Temperate.Merchants;

internal class Goldsmith : MerchantsBuilding
{
	public override double Minutes => 16;
	public override Material? Production { get; } = new(eGood.GoldJewelry, 6);
	public override Material[] Consumption { get; } = [new(eGood.Coal, 1), new(eGood.GoldIngot, 2)];
	private protected override string IconName => "Goldsmith.png";
}