namespace ParagonPioneers2ProductionCalculator.Buildings.Temperate.Merchants;

internal class MerchantsMansion : MerchantsBuilding, IPopulationBuilding
{
	public override double Minutes => 60;
	public override Material? Production { get; } = null;
	public override Material[] Consumption { get; } = [new(eGood.Cauldron, 25d / 45400 * 3600), new(eGood.Beer, 25d / 17900 * 3600), new(eGood.Leather, 25d / 22100 * 3600), new(eGood.Coffee, 25d / 20900 * 3600), new(eGood.Jam, 25d / 13400 * 3600), new(eGood.Hat, 25d / 8000 * 3600), new(eGood.TobaccoPipe, 25d / 9000 * 3600), new(eGood.MeatPie, 25d / 8000 * 3600), new(eGood.Caviar, 25d / 36000 * 3600), new(eGood.GoldJewelry, 25d / 12400 * 3600), new(eGood.Perfume, 25d / 12400 * 3600)];
	private protected override string IconName => "MerchantsMansion.png";
}