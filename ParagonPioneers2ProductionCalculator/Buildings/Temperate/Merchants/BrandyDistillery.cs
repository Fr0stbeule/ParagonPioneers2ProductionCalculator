namespace ParagonPioneers2ProductionCalculator.Buildings.Temperate.Merchants;

internal class BrandyDistillery : MerchantsBuilding
{
	public override double Minutes => 8;
	public override Material? Production { get; } = new(eGood.Brandy, 1);
	public override Material[] Consumption { get; } = [new(eGood.Wood, 8), new(eGood.Cider, 12)];
	private protected override string IconName => "BrandyDistillery.png";
}